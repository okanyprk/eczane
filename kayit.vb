Imports System.Data

Imports System.Data.OleDb
Public Class kayit
    Public bag As New OleDbConnection("Provider=Microsoft.ace.Oledb.12.0;Data Source=eczane.accdb")
    Public kmt As New OleDbCommand()
    Public adtr As New OleDbDataAdapter()
    Public tablo As New DataTable()
    Private Sub kayit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bag.Open()

        kmt.Connection = bag

        kmt.CommandText = "INSERT INTO kullanicibil(kullaniciAdi,parola) VALUES (@kullaniciAdi,@parola) "

        kmt.Parameters.AddWithValue("@kullaniciAdi", TextBox1.Text)

        kmt.Parameters.AddWithValue("@parola", TextBox2.Text)

        kmt.ExecuteNonQuery()

        kmt.Dispose()

        bag.Close()

        For i As Integer = 0 To Me.Controls.Count - 1

            If TypeOf Me.Controls(i) Is TextBox Then

                Me.Controls(i).Text = ""

            End If

        Next
        MessageBox.Show("Kayıt işlemi tamamlandı !")
        giris.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        giris.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class