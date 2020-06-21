Imports System.Data.SqlClient

' Create By Mr. Agus using VB 6.0
' renew by Me Agahari.IJ using VB.NET
' Start built at 19 June 2020
Public Class edpLoginForm


	Private Sub edpLoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		' Call Connection Module
		' Change text to status Between Program And Database
		Call KoneksiINV()
		'Make TextBoxuserName Focus when Form loaded
		TextBoxuserName.Focus()



	End Sub

	Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
		'Close Program When Button Exit Clicked
		Me.Close()
	End Sub

	' Config Cursor auto focus
	Private Sub TextBoxuserName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxuserName.KeyPress
		' After press enter button, cursor move to TextBoxpassWord, when its not empty clear it
		If e.KeyChar = Chr(13) Then
			If TextBoxpassWord.Text = "" Then
				TextBoxpassWord.Focus()
			Else
				TextBoxpassWord.Text = ""
				TextBoxpassWord.Focus()
			End If
		End If


	End Sub

	Private Sub TextBoxpassWord_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxpassWord.KeyPress
		' After press enter button cursor auto move to Login Button
		If e.KeyChar = Chr(13) Then ButtonLogin.Focus()
	End Sub

	'Define Login Proccess
	'Login Proccess Start Here
	Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
		'Make Sure input user 
		If TextBoxuserName.Text = "" Or TextBoxpassWord.Text = "" Then
			If MsgBox("Data belum lengkap, lengkapi data? ", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
				' program read empty textbox to set to focus
				If TextBoxuserName.Text = "" Then
					Me.Show()
					TextBoxuserName.Focus()
				Else
					Me.Show()
					TextBoxpassWord.Focus()
				End If
			End If

		Else
			'After user Input username and password
			'calling connection module to database
			Call KoneksiINV()
			'load all data from table, then compare with user's input 
			Cmd = New SqlCommand("SELECT * FROM inv_user WHERE [user] = '" & TextBoxuserName.Text & "' AND [password] = '" & TextBoxpassWord.Text & "' ", Conn)
			Dr = Cmd.ExecuteReader()
			Dr.Read()

			'Result, if user input correct
			If Dr.HasRows Then
				'do next op
				edpHomeForm.Show()
				Me.Visible = False

				' if input user fail
			Else
				' confirm user to re-login
				If MsgBox("Login Gagal, Ulangi?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
					TextBoxuserName.Text = ""
					TextBoxpassWord.Text = ""
					TextBoxuserName.Focus()
				Else
					' if user canceled login
					Me.Close()
				End If
			End If
		End If





	End Sub


End Class
