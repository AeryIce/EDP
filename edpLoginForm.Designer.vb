<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edpLoginForm
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.TextBoxuserName = New System.Windows.Forms.TextBox()
		Me.TextBoxpassWord = New System.Windows.Forms.TextBox()
		Me.Label_statusKoneksi = New System.Windows.Forms.Label()
		Me.Label_Status = New System.Windows.Forms.Label()
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		Me.ButtonExit = New System.Windows.Forms.Button()
		Me.ButtonLogin = New System.Windows.Forms.Button()
		Me.PictureBoxpassWord = New System.Windows.Forms.PictureBox()
		Me.PictureBoxuserName = New System.Windows.Forms.PictureBox()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBoxpassWord, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBoxuserName, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'TextBoxuserName
		'
		Me.TextBoxuserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.TextBoxuserName.Location = New System.Drawing.Point(100, 172)
		Me.TextBoxuserName.Name = "TextBoxuserName"
		Me.TextBoxuserName.Size = New System.Drawing.Size(125, 20)
		Me.TextBoxuserName.TabIndex = 5
		'
		'TextBoxpassWord
		'
		Me.TextBoxpassWord.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.TextBoxpassWord.Location = New System.Drawing.Point(100, 214)
		Me.TextBoxpassWord.Name = "TextBoxpassWord"
		Me.TextBoxpassWord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.TextBoxpassWord.Size = New System.Drawing.Size(125, 20)
		Me.TextBoxpassWord.TabIndex = 7
		'
		'Label_statusKoneksi
		'
		Me.Label_statusKoneksi.AutoSize = True
		Me.Label_statusKoneksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label_statusKoneksi.Location = New System.Drawing.Point(249, 378)
		Me.Label_statusKoneksi.Name = "Label_statusKoneksi"
		Me.Label_statusKoneksi.Size = New System.Drawing.Size(0, 9)
		Me.Label_statusKoneksi.TabIndex = 10
		'
		'Label_Status
		'
		Me.Label_Status.AutoSize = True
		Me.Label_Status.Font = New System.Drawing.Font("Lucida Console", 6.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label_Status.Location = New System.Drawing.Point(248, 365)
		Me.Label_Status.Name = "Label_Status"
		Me.Label_Status.Size = New System.Drawing.Size(0, 8)
		Me.Label_Status.TabIndex = 12
		'
		'PictureBox3
		'
		Me.PictureBox3.BackgroundImage = Global.EDP.My.Resources.Resources.Logo_Periplus_Dasar_Puth
		Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.PictureBox3.Location = New System.Drawing.Point(57, 63)
		Me.PictureBox3.Name = "PictureBox3"
		Me.PictureBox3.Size = New System.Drawing.Size(204, 68)
		Me.PictureBox3.TabIndex = 13
		Me.PictureBox3.TabStop = False
		'
		'ButtonExit
		'
		Me.ButtonExit.BackgroundImage = Global.EDP.My.Resources.Resources.cancel_32px
		Me.ButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonExit.Location = New System.Drawing.Point(165, 246)
		Me.ButtonExit.Name = "ButtonExit"
		Me.ButtonExit.Size = New System.Drawing.Size(44, 39)
		Me.ButtonExit.TabIndex = 9
		Me.ButtonExit.UseVisualStyleBackColor = True
		'
		'ButtonLogin
		'
		Me.ButtonLogin.BackgroundImage = Global.EDP.My.Resources.Resources.login_32px
		Me.ButtonLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.ButtonLogin.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ButtonLogin.Location = New System.Drawing.Point(109, 246)
		Me.ButtonLogin.Name = "ButtonLogin"
		Me.ButtonLogin.Size = New System.Drawing.Size(46, 39)
		Me.ButtonLogin.TabIndex = 8
		Me.ButtonLogin.UseVisualStyleBackColor = True
		'
		'PictureBoxpassWord
		'
		Me.PictureBoxpassWord.BackgroundImage = Global.EDP.My.Resources.Resources.password_32px
		Me.PictureBoxpassWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.PictureBoxpassWord.Location = New System.Drawing.Point(61, 208)
		Me.PictureBoxpassWord.Name = "PictureBoxpassWord"
		Me.PictureBoxpassWord.Size = New System.Drawing.Size(33, 32)
		Me.PictureBoxpassWord.TabIndex = 6
		Me.PictureBoxpassWord.TabStop = False
		'
		'PictureBoxuserName
		'
		Me.PictureBoxuserName.BackgroundImage = Global.EDP.My.Resources.Resources.user_32px
		Me.PictureBoxuserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.PictureBoxuserName.Location = New System.Drawing.Point(61, 166)
		Me.PictureBoxuserName.Name = "PictureBoxuserName"
		Me.PictureBoxuserName.Size = New System.Drawing.Size(33, 32)
		Me.PictureBoxuserName.TabIndex = 4
		Me.PictureBoxuserName.TabStop = False
		'
		'edpLoginForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Aqua
		Me.ClientSize = New System.Drawing.Size(300, 400)
		Me.Controls.Add(Me.PictureBox3)
		Me.Controls.Add(Me.Label_Status)
		Me.Controls.Add(Me.Label_statusKoneksi)
		Me.Controls.Add(Me.ButtonExit)
		Me.Controls.Add(Me.ButtonLogin)
		Me.Controls.Add(Me.TextBoxpassWord)
		Me.Controls.Add(Me.PictureBoxpassWord)
		Me.Controls.Add(Me.TextBoxuserName)
		Me.Controls.Add(Me.PictureBoxuserName)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "edpLoginForm"
		Me.Opacity = 0.85R
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Login"
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBoxpassWord, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBoxuserName, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents TextBoxuserName As TextBox
	Friend WithEvents PictureBoxuserName As PictureBox
	Friend WithEvents TextBoxpassWord As TextBox
	Friend WithEvents PictureBoxpassWord As PictureBox
	Friend WithEvents ButtonLogin As Button
	Friend WithEvents ButtonExit As Button
	Public WithEvents Label_statusKoneksi As Label
	Public WithEvents Label_Status As Label
	Friend WithEvents PictureBox3 As PictureBox
End Class
