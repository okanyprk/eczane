Imports System.Data

Imports System.Data.OleDb
Public Class ilackayit
    Public bag As New OleDbConnection("Provider=Microsoft.ace.Oledb.12.0;Data Source=eczane.accdb")
    Public kmt As New OleDbCommand()
    Public adtr As New OleDbDataAdapter()
    Public tablo As New DataTable()
    Dim idfir As Integer
    Public Sub firmaEkle()

        bag.Open()

        kmt.Connection = bag

        Dim oku As OleDbDataReader

        kmt.CommandText = "Select * from firmabil"

        oku = kmt.ExecuteReader()

        While oku.Read()

            ComboBox1.Items.Add(New DictionaryEntry(oku(1).ToString(), oku(0).ToString()))

        End While

        bag.Close()

        oku.Dispose()

        ComboBox1.DisplayMember = "Key"

        ComboBox1.ValueMember = "Value"

        ComboBox1.DataSource = ComboBox1.Items

        ComboBox1.Text = ""

    End Sub
    Public Sub idFirma()

        Dim kmt2 As New OleDbCommand()

        Try

            bag.Open()

            kmt2.Connection = bag

            Dim oku As OleDbDataReader

            kmt2.CommandText = "Select * from firmabil where id=@id"

            kmt2.Parameters.AddWithValue("@id", idfir)

            oku = kmt2.ExecuteReader()

            While oku.Read()

                ComboBox1.Text = oku(1).ToString()

            End While

            bag.Close()

            oku.Close()

            kmt2.Dispose()

        Catch ex As Exception

        End Try

    End Sub
    Public Sub listele()

        tablo.Clear()

        Dim adtr As New OleDbDataAdapter("select * From ilacbil ", bag)

        adtr.Fill(tablo)

        DataGridView1.DataSource = tablo

        adtr.Dispose()

    End Sub
    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick

        TextBox1.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()

        TextBox2.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()

        TextBox3.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()

        TextBox4.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()

        ComboBox1.Text = ComboBox1.DisplayMember.Length.ToString()

        idfir = DataGridView1.CurrentRow.Cells(5).Value

        idFirma()

    End Sub
    Private Sub ilackayit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listele()
        ComboBox1.Refresh()
        firmaEkle()
    End Sub

    Private Sub anamenu_Click(sender As Object, e As EventArgs) Handles anamenu.Click
        girismenu.Show()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        Me.Hide()
    End Sub

    Private Sub kaydetbtn_Click(sender As Object, e As EventArgs) Handles kaydetbtn.Click
        bag.Open()

        kmt.Connection = bag

        kmt.CommandText = "INSERT INTO ilacbil(barkod,adi,fiyat,miktar,firmaId) VALUES (@barkod,@adi,@fiyat,@miktar,@firmaId) "

        kmt.Parameters.AddWithValue("@barkod", TextBox1.Text)

        kmt.Parameters.AddWithValue("@adi", TextBox2.Text)

        kmt.Parameters.AddWithValue("@fiyat", TextBox3.Text)

        kmt.Parameters.AddWithValue("@miktar", TextBox4.Text)

        kmt.Parameters.AddWithValue("@firmaId", ComboBox1.SelectedValue)

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

    Private Sub silbtn_Click(sender As Object, e As EventArgs) Handles silbtn.Click
        bag.Open()

        kmt.Connection = bag

        kmt.CommandText = "DELETE from ilacbil WHERE id=@id"

        kmt.Parameters.AddWithValue("@id", DataGridView1.CurrentRow.Cells(0).Value)

        kmt.ExecuteNonQuery()

        kmt.Dispose()

        bag.Close()

        listele()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""

    End Sub

    Private Sub guncellebtn_Click(sender As Object, e As EventArgs) Handles guncellebtn.Click
        bag.Open()

        kmt.Connection = bag

        kmt.CommandText = "UPDATE ilacbil SET barkod=@barkod,adi=@adi,fiyat=@fiyat,miktar=@miktar,firmaId=@firmaId WHERE id=@id"

        kmt.Parameters.AddWithValue("@barkod", TextBox1.Text)

        kmt.Parameters.AddWithValue("@adi", TextBox2.Text)

        kmt.Parameters.AddWithValue("@fiyat", TextBox3.Text)

        kmt.Parameters.AddWithValue("@miktar", TextBox4.Text)

        kmt.Parameters.AddWithValue("@firmaId", ComboBox1.SelectedValue)

        kmt.Parameters.AddWithValue("@id", DataGridView1.CurrentRow.Cells(0).Value)

        kmt.ExecuteNonQuery()

        bag.Close()

        listele()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
    End Sub

    Private Sub cikisbtn_Click(sender As Object, e As EventArgs) Handles cikisbtn.Click
        Close()
    End Sub

    Private Sub arabtn_Click(sender As Object, e As EventArgs) Handles arabtn.Click
        Dim adtr As New OleDbDataAdapter("select * From ilacbil", bag)

        Dim alan As String = ""

        If ComboBox2.Text = "Barkod" Then

            alan = "barkod"

        ElseIf ComboBox2.Text = "Adı" Then

            alan = "adi"

        End If

        If ComboBox2.Text = "Tümü" Then

            bag.Open()

            tablo.Clear()

            kmt.Connection = bag

            kmt.CommandText = "Select * from ilacbil"

            adtr.SelectCommand = kmt

            adtr.Fill(tablo)

            bag.Close()

        End If

        If alan <> "" Then

            bag.Open()

            adtr.SelectCommand.CommandText = (" Select * From ilacbil" & " where(" & alan & " like '%") + TextBox5.Text & "%' )"

            tablo.Clear()

            adtr.Fill(tablo)

            bag.Close()

        End If

        kmt.Dispose()
    End Sub

    Private Sub firmabtn_Click(sender As Object, e As EventArgs) Handles firmabtn.Click
        firmakaydet.Show()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        Me.Close()
    End Sub

    Private Sub ilackayit_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        TextBox5.Text = ""
    End Sub
End Class