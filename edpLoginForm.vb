Imports System.Data.SqlClient
Public Class edpLoginForm


	Private Sub edpLoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Call Koneksi()


	End Sub

	Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
		Me.Close()
	End Sub

	Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
		Call Koneksi()

	End Sub
End Class
