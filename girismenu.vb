Imports System.Data

Imports System.Data.OleDb
Public Class girismenu
    Public baglan As New OleDbConnection("Provider=Microsoft.ace.Oledb.12.0;Data Source=eczane.accdb")
    Public komut As New OleDbCommand()
    Public adtr As New OleDbDataAdapter()
    Public tablo As New DataTable()
    Private Sub girismenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub ilacbtn_Click(sender As Object, e As EventArgs) Handles ilacbtn.Click
        ilackayit.Show()
        Me.Close()
    End Sub

    Private Sub recetebtn_Click(sender As Object, e As EventArgs) Handles recetebtn.Click
        recetesatis.Show()
        Me.Close()
    End Sub

    Private Sub hastabtn_Click(sender As Object, e As EventArgs) Handles hastabtn.Click
        hastakayit.Show()
        Me.Close()
    End Sub

    Private Sub cikisbtn_Click(sender As Object, e As EventArgs) Handles cikisbtn.Click
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class