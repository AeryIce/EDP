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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TextBoxuserName = New System.Windows.Forms.TextBox()
		Me.TextBoxpassWord = New System.Windows.Forms.TextBox()
		Me.Label_statusKoneksi = New System.Windows.Forms.Label()
		Me.Label_Status = New System.Windows.Forms.Label()
		Me.ButtonExit = New System.Windows.Forms.Button()
		Me.ButtonLogin = New System.Windows.Forms.Button()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Arial Unicode MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Location = New System.Drawing.Point(50, 96)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(205, 28)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Periplus Indonesia"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Location = New System.Drawing.Point(75, 124)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(150, 13)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "JKT - BDG - BALI - SBY - JGJ "
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
		'PictureBox2
		'
		Me.PictureBox2.BackgroundImage = Global.EDP.My.Resources.Resources.password_32px
		Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.PictureBox2.Location = New System.Drawing.Point(61, 208)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(33, 32)
		Me.PictureBox2.TabIndex = 6
		Me.PictureBox2.TabStop = False
		'
		'PictureBox1
		'
		Me.PictureBox1.BackgroundImage = Global.EDP.My.Resources.Resources.user_32px
		Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.PictureBox1.Location = New System.Drawing.Point(61, 166)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(33, 32)
		Me.PictureBox1.TabIndex = 4
		Me.PictureBox1.TabStop = False
		'
		'PictureBox3
		'
		Me.PictureBox3.BackgroundImage = Global.EDP.My.Resources.Resources._732c2664fba77085839be9be4e80e4aa
		Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.PictureBox3.Location = New System.Drawing.Point(-1, 12)
		Me.PictureBox3.Name = "PictureBox3"
		Me.PictureBox3.Size = New System.Drawing.Size(300, 375)
		Me.PictureBox3.TabIndex = 11
		Me.PictureBox3.TabStop = False
		'
		'edpLoginForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Aqua
		Me.ClientSize = New System.Drawing.Size(300, 400)
		Me.Controls.Add(Me.Label_Status)
		Me.Controls.Add(Me.Label_statusKoneksi)
		Me.Controls.Add(Me.ButtonExit)
		Me.Controls.Add(Me.ButtonLogin)
		Me.Controls.Add(Me.TextBoxpassWord)
		Me.Controls.Add(Me.PictureBox2)
		Me.Controls.Add(Me.TextBoxuserName)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.PictureBox3)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "edpLoginForm"
		Me.Opacity = 0.85R
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Login"
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents TextBoxuserName As TextBox
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents TextBoxpassWord As TextBox
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents ButtonLogin As Button
	Friend WithEvents ButtonExit As Button
	Public WithEvents Label_statusKoneksi As Label
	Friend WithEvents PictureBox3 As PictureBox
	Public WithEvents Label_Status As Label
End Class
