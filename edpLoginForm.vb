Imports System.Data.SqlClient
Public Class edpLoginForm


	Private Sub edpLoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Call KoneksiINV()
		TextBoxuserName.Focus()



	End Sub

	Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
		Me.Close()
	End Sub

	Private Sub TextBoxuserName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxuserName.KeyPress
		If e.KeyChar = Chr(13) Then TextBoxpassWord.Focus()

	End Sub

	Private Sub TextBoxpassWord_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxpassWord.KeyPress
		If e.KeyChar = Chr(13) Then ButtonLogin.Focus()
	End Sub

	Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
		If TextBoxuserName.Text = "" Or TextBoxpassWord.Text = "" Then
			If MsgBox("Data belum lengkap, lengkapi data? ", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then

				If TextBoxuserName.Text = "" Then
					Me.Show()
					TextBoxuserName.Focus()
				Else
					Me.Show()
					TextBoxpassWord.Focus()
				End If
			Else
				Call KoneksiINV()
				Cmd = New SqlCommand("SELECT * FROM inv_user WHERE [user] = '" & TextBoxuserName.Text & "' AND [password] = '" & TextBoxpassWord.Text & "' ", Conn)
				Dr = Cmd.ExecuteReader()
				Dr.Read()

				If Dr.HasRows Then
					edpHomeForm.Show()
					Me.Visible = False

				Else
					MsgBox("Salah")
				End If

				'If TextBoxuserName.Text = "ADMIN" Then
				'	edpHomeForm.Show()
				'Else
				'	MsgBox("Salah")
				'End If
			End If


		End If

	End Sub

End Class
