Imports System.Data

Imports System.Data.OleDb
Public Class giris

    Public baglan As New OleDbConnection("Provider=Microsoft.ace.Oledb.12.0;Data Source=eczane.accdb")

    Public komut As New OleDbCommand()

    Dim sonuc As Integer
    Private Sub giris_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub girisbtn_Click(sender As Object, e As EventArgs) Handles girisbtn.Click
        sonuc = 0

        baglan.Open()

        komut.Connection = baglan

        komut.CommandText = "Select count(id) from kullanicibil where kullaniciAdi=@kullaniciAdi and parola=@parola"

        komut.Parameters.AddWithValue("@kullaniciAdi", TextBox1.Text.ToLower().Trim())

        komut.Parameters.AddWithValue("@parola", TextBox2.Text.ToLower().Trim())

        sonuc = Convert.ToInt32(komut.ExecuteScalar().ToString())

        If (sonuc = 1) Then

            girismenu.Show()
            Me.Hide()

        Else

            Label3.Text = "Kullanici adı veya parola Hatalı !"

        End If

        baglan.Close()

        komut.Dispose()

        TextBox1.Text = ""

        TextBox2.Text = ""
    End Sub

    Private Sub cikisbtn_Click(sender As Object, e As EventArgs) Handles cikisbtn.Click
        Close()
    End Sub

    Private Sub kayitbtn_Click(sender As Object, e As EventArgs) Handles kayitbtn.Click
        kayit.Show()
        Me.Hide()
    End Sub
End Class
