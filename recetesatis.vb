Imports System.Data

Imports System.Data.OleDb
Public Class recetesatis
    Public bag As New OleDbConnection("Provider=Microsoft.ace.Oledb.12.0;Data Source=eczane.accdb")
    Public kmt As New OleDbCommand()
    Public adtr As New OleDbDataAdapter()
    Public tablo As New DataTable()
    Dim idHas, idIla As Integer
    Public Sub tcEkle()

        bag.Open()

        kmt.Connection = bag

        Dim oku As OleDbDataReader

        kmt.CommandText = "Select id,tcKimlik from hastabil"

        oku = kmt.ExecuteReader()

        While oku.Read()

            ComboBox1.Items.Add(New DictionaryEntry(oku(1).ToString(), oku(0).ToString()))

        End While

        bag.Close()

        oku.Dispose()

        kmt.Dispose()

        ComboBox1.DisplayMember = "Key"

        ComboBox1.ValueMember = "Value"

        ComboBox1.DataSource = ComboBox1.Items

        ComboBox1.Text = ""

    End Sub
    Public Sub ilacEkle()

        bag.Open()

        kmt.Connection = bag

        Dim oku As OleDbDataReader

        kmt.CommandText = "Select id,adi from ilacbil"

        oku = kmt.ExecuteReader()

        While oku.Read()

            ComboBox2.Items.Add(New DictionaryEntry(oku(1).ToString(), oku(0).ToString()))

        End While

        bag.Close()

        oku.Dispose()

        kmt.Dispose()

        ComboBox2.DisplayMember = "Key"

        ComboBox2.ValueMember = "Value"

        ComboBox2.DataSource = ComboBox2.Items

        ComboBox2.Text = ""

    End Sub
    Public Sub idHasta()

        Try

            Dim kmt2 As New OleDbCommand()

            bag.Open()

            kmt2.Connection = bag

            Dim oku As OleDbDataReader

            kmt2.CommandText = "Select * from hastabil where id=@id"

            kmt2.Parameters.AddWithValue("@id", idHas)
            oku = kmt2.ExecuteReader()
            While oku.Read()
                ComboBox1.Text = oku(3).ToString()
                Label8.Text = oku(1).ToString()
            End While

            bag.Close()

            oku.Close()

            kmt2.Dispose()

        Catch ex As Exception

        End Try

    End Sub
    Public Sub idIlac()

        Try

            Dim kmt3 As New OleDbCommand()

            bag.Open()

            kmt3.Connection = bag

            Dim oku As OleDbDataReader

            kmt3.CommandText = "Select * from ilacbil where id=@id"

            kmt3.Parameters.AddWithValue("@id", idIla)

            oku = kmt3.ExecuteReader()

            While oku.Read()

                ComboBox2.Text = oku(2).ToString()

            End While

            bag.Close()

            oku.Close()

            kmt3.Dispose()

        Catch ex As Exception

        End Try

    End Sub
    Public Sub listele()

        tablo.Clear()

        Dim adtr As New OleDbDataAdapter("select * From satisbil ", bag)

        adtr.Fill(tablo)

        DataGridView1.DataSource = tablo

        adtr.Dispose()
    End Sub
    Private Sub anamenubtn_Click(sender As Object, e As EventArgs) Handles anamenubtn.Click
        girismenu.Show()
        Me.Close()
    End Sub
    Private Sub recetesatis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ilacEkle()
        tcEkle()
        listele()
        DateTimePicker1.ResetText()
    End Sub
    Private Sub silbtn_Click(sender As Object, e As EventArgs) Handles silbtn.Click
        bag.Open()

        kmt.Connection = bag

        kmt.CommandText = "DELETE from satisbil WHERE id=@id"

        kmt.Parameters.AddWithValue("@id", DataGridView1.CurrentRow.Cells(0).Value)

        kmt.ExecuteNonQuery()
        Label8.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        DateTimePicker1.ResetText()

        kmt.Dispose()

        bag.Close()

        listele()
    End Sub
    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick

        TextBox1.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()

        TextBox2.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()

        DateTimePicker1.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()

        idHas = DataGridView1.CurrentRow.Cells(1).Value

        idIla = DataGridView1.CurrentRow.Cells(2).Value

        idHasta()

        idIlac()

    End Sub
    Private Sub cikisbtn_Click(sender As Object, e As EventArgs) Handles cikisbtn.Click
        Application.Exit()
    End Sub

    Private Sub guncellebtn_Click(sender As Object, e As EventArgs) Handles guncellebtn.Click
        bag.Open()

        kmt.Connection = bag

        kmt.CommandText = "UPDATE satisbil SET hastaId=@hastaId,ilacId=@ilacId,tarih=@tarih,miktar=@miktar,faturaNo=@faturaNo WHERE id=@id"

        kmt.Parameters.AddWithValue("@hastaId", ComboBox1.SelectedValue)

        kmt.Parameters.AddWithValue("@ilacId", ComboBox2.SelectedValue)

        kmt.Parameters.AddWithValue("@tarih", DateTimePicker1.Text)

        kmt.Parameters.AddWithValue("@miktar", TextBox1.Text)

        kmt.Parameters.AddWithValue("@faturaNo", TextBox2.Text)

        kmt.Parameters.AddWithValue("@id", DataGridView1.CurrentRow.Cells(0).Value)

        kmt.ExecuteNonQuery()

        bag.Close()

        listele()
    End Sub

    Private Sub arabtn_Click(sender As Object, e As EventArgs) Handles arabtn.Click
        Dim adtr As New OleDbDataAdapter("select * From satisbil", bag)

        Dim alan As String = ""

        If ComboBox4.Text = "Hasta Id" Then

            alan = "hastaId"

        ElseIf ComboBox4.Text = "Fatura No" Then

            alan = "faturaNo"

        End If

        If ComboBox4.Text = "Tümü" Then

            bag.Open()

            tablo.Clear()

            kmt.Connection = bag

            kmt.CommandText = "Select * from satisbil"

            adtr.SelectCommand = kmt

            adtr.Fill(tablo)

            bag.Close()

        End If

        If alan <> "" Then

            bag.Open()

            adtr.SelectCommand.CommandText = (" Select * From satisbil" & " where(" & alan & " like '%") + TextBox3.Text & "%' )"

            tablo.Clear()

            adtr.Fill(tablo)

            bag.Close()

        End If

        kmt.Dispose()
    End Sub

    Private Sub kaydetbtn_Click(sender As Object, e As EventArgs) Handles kaydetbtn.Click
        bag.Open()
        kmt.Connection = bag
        kmt.CommandText = "INSERT INTO satisbil(hastaId,ilacId,tarih,miktar,faturaNo) VALUES (@hastaId,@ilacId,@tarih,@miktar,@faturaNo) "
        kmt.Parameters.AddWithValue("@hastaId", ComboBox1.SelectedValue)
        kmt.Parameters.AddWithValue("@ilacId", ComboBox2.SelectedValue)
        kmt.Parameters.AddWithValue("@tarih", DateTimePicker1.Text)
        kmt.Parameters.AddWithValue("@miktar", TextBox1.Text)
        kmt.Parameters.AddWithValue("@faturaNo", TextBox2.Text)
        kmt.ExecuteNonQuery()
        kmt.Dispose()
        bag.Close()
        For i As Integer = 0 To Me.Controls.Count - 1
            If TypeOf Me.Controls(i) Is TextBox Then
                Me.Controls(i).Text = ""
            End If
            If TypeOf Me.Controls(i) Is ComboBox Then
                Me.Controls(i).Text = ""
            End If
        Next
        listele()
        MessageBox.Show("Kayıt işlemi tamamlandı !")
    End Sub
End Class