Imports System.Data

Imports System.Data.OleDb
Public Class hastakayit
    Public baglan As New OleDbConnection("Provider=Microsoft.ace.Oledb.12.0;Data Source=eczane.accdb")

    Public komut As New OleDbCommand()

    Public adtr As New OleDbDataAdapter()

    Public tablo As New DataTable()

    Public Sub listele()

        tablo.Clear()

        Dim adtr As New OleDbDataAdapter("select * From hastabil ", baglan)

        adtr.Fill(tablo)

        DataGridView1.DataSource = tablo

        adtr.Dispose()

    End Sub
    Private Sub hastakayit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listele()
    End Sub
    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        TextBox1.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()

        TextBox2.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()

        TextBox3.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()

        TextBox4.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()

        TextBox5.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString()
    End Sub

    Private Sub anamenu_Click(sender As Object, e As EventArgs) Handles anamenu.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        girismenu.Show()
        Me.Hide()
    End Sub

    Private Sub kaydetbtn_Click(sender As Object, e As EventArgs) Handles kaydetbtn.Click
        baglan.Open()

        komut.Connection = baglan

        komut.CommandText = "INSERT INTO hastabil(adi,soyadi,tcKimlik,cepTel,adres) VALUES (@adi,@soyadi,@tcKimlik,@cepTel,@adres) "

        komut.Parameters.AddWithValue("@adi", TextBox1.Text)

        komut.Parameters.AddWithValue("@soyadi", TextBox2.Text)

        komut.Parameters.AddWithValue("@tcKimlik", TextBox3.Text)

        komut.Parameters.AddWithValue("@cepTel", TextBox4.Text)

        komut.Parameters.AddWithValue("@adres", TextBox5.Text)

        komut.ExecuteNonQuery()

        komut.Dispose()

        baglan.Close()

        For i As Integer = 0 To Me.Controls.Count - 1

            If TypeOf Me.Controls(i) Is TextBox Then

                Me.Controls(i).Text = ""

            End If

        Next

        listele()

        MessageBox.Show("Kayıt işlemi tamamlandı !")
    End Sub

    Private Sub silbtn_Click(sender As Object, e As EventArgs) Handles silbtn.Click
        baglan.Open()

        komut.Connection = baglan

        komut.CommandText = "DELETE from hastabil WHERE id=@id"

        komut.Parameters.AddWithValue("@id", DataGridView1.CurrentRow.Cells(0).Value)

        komut.ExecuteNonQuery()

        komut.Dispose()

        baglan.Close()

        listele()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub guncellebtn_Click(sender As Object, e As EventArgs) Handles guncellebtn.Click
        baglan.Open()

        komut.Connection = baglan

        komut.CommandText = "UPDATE hastabil SET adi=@adi,soyadi=@soyadi,tcKimlik=@tcKimlik,cepTel=@cepTel,adres=@adres WHERE id=@id"

        komut.Parameters.AddWithValue("@adi", TextBox1.Text)

        komut.Parameters.AddWithValue("@soyadi", TextBox2.Text)

        komut.Parameters.AddWithValue("@tcKimlik", TextBox3.Text)

        komut.Parameters.AddWithValue("@cepTel", TextBox4.Text)

        komut.Parameters.AddWithValue("@adres", TextBox5.Text)

        komut.Parameters.AddWithValue("@id", DataGridView1.CurrentRow.Cells(0).Value)

        komut.ExecuteNonQuery()

        baglan.Close()

        listele()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub

    Private Sub cikisbtn_Click(sender As Object, e As EventArgs) Handles cikisbtn.Click
        Application.Exit()
    End Sub

    Private Sub arabtn_Click(sender As Object, e As EventArgs) Handles arabtn.Click
        Dim adtr As New OleDbDataAdapter("select * From hastabil", baglan)

        Dim alan As String = ""

        If ComboBox1.Text = "Tc Kimlik" Then

            alan = "tcKimlik"

        ElseIf ComboBox1.Text = "Adı" Then

            alan = "adi"

        ElseIf ComboBox1.Text = "Soyadı" Then

            alan = "soyadi"

        End If

        If ComboBox1.Text = "Tümü" Then

            baglan.Open()

            tablo.Clear()

            komut.Connection = baglan

            komut.CommandText = "Select * from hastabil"

            adtr.SelectCommand = komut

            adtr.Fill(tablo)

            baglan.Close()

        End If

        If alan <> "" Then

            baglan.Open()

            adtr.SelectCommand.CommandText = (" Select * From hastabil" & " where(" & alan & " like '%") + TextBox6.Text & "%' )"

            tablo.Clear()

            adtr.Fill(tablo)

            baglan.Close()

        End If

        komut.Dispose()
    End Sub
End Class