Imports System.Data

Imports System.Data.OleDb
Public Class firmakaydet
    Public bag As New OleDbConnection("Provider=Microsoft.ace.Oledb.12.0;Data Source=eczane.accdb")

    Public kmt As New OleDbCommand()

    Public adtr As New OleDbDataAdapter()

    Public tablo As New DataTable()

    Public Sub listele()

        tablo.Clear()

        Dim adtr As New OleDbDataAdapter("select * From firmabil ", bag)

        adtr.Fill(tablo)

        DataGridView1.DataSource = tablo

        adtr.Dispose()

    End Sub
    Private Sub Firmaekle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listele()
    End Sub

    Private Sub kaydetbtn_Click(sender As Object, e As EventArgs) Handles kaydetbtn.Click
        bag.Open()

        kmt.Connection = bag

        kmt.CommandText = "INSERT INTO firmabil(adi) VALUES (@adi)"

        kmt.Parameters.AddWithValue("@adi", TextBox1.Text)

        kmt.ExecuteNonQuery()

        kmt.Dispose()

        bag.Close()

        listele()

        MessageBox.Show("Kayıt işlemi tamamlandı !")
    End Sub

    Private Sub guncellebtn_Click(sender As Object, e As EventArgs) Handles guncellebtn.Click
        bag.Open()

        kmt.Connection = bag

        kmt.CommandText = "UPDATE firmabil SET adi=@adi WHERE id=@id"

        kmt.Parameters.AddWithValue("@adi", TextBox1.Text)

        kmt.Parameters.AddWithValue("@id", DataGridView1.CurrentRow.Cells(0).Value)

        kmt.ExecuteNonQuery()

        bag.Close()

        listele()
    End Sub

    Private Sub silbtn_Click(sender As Object, e As EventArgs) Handles silbtn.Click
        bag.Open()

        kmt.Connection = bag

        kmt.CommandText = "DELETE from firmabil WHERE id=@id"

        kmt.Parameters.AddWithValue("@id", DataGridView1.CurrentRow.Cells(0).Value)

        kmt.ExecuteNonQuery()

        kmt.Dispose()

        bag.Close()

        listele()
    End Sub
    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick

        TextBox1.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
    End Sub

    Private Sub anamenubtn_Click(sender As Object, e As EventArgs) Handles anamenubtn.Click
        girismenu.Show()
        Me.Hide()
    End Sub

    Private Sub arabtn_Click(sender As Object, e As EventArgs) Handles arabtn.Click
        Dim adtr As New OleDbDataAdapter("select * From firmabil", bag)

        Dim alan As String = ""

        If ComboBox1.Text = "Firma Adı" Then

            alan = "adi"

        End If

        If ComboBox1.Text = "Tümü" Then

            bag.Open()

            tablo.Clear()

            kmt.Connection = bag

            kmt.CommandText = "Select * from firmabil"

            adtr.SelectCommand = kmt

            adtr.Fill(tablo)

            bag.Close()

        End If

        If alan <> "" Then

            bag.Open()

            adtr.SelectCommand.CommandText = (" Select * From firmabil" & " where(" & alan & " like '%") + TextBox2.Text & "%' )"

            tablo.Clear()

            adtr.Fill(tablo)

            bag.Close()

        End If

        kmt.Dispose()
    End Sub
End Class