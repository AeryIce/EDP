<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class edpHomeForm
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.PanelmenuLeftSide = New System.Windows.Forms.Panel()
		Me.PaneltopBanner = New System.Windows.Forms.Panel()
		Me.Panellogo = New System.Windows.Forms.Panel()
		Me.PanelsubMenuMaster = New System.Windows.Forms.Panel()
		Me.Buttonmaster = New System.Windows.Forms.Button()
		Me.PanelmenuLeftSide.SuspendLayout()
		Me.PanelsubMenuMaster.SuspendLayout()
		Me.SuspendLayout()
		'
		'PanelmenuLeftSide
		'
		Me.PanelmenuLeftSide.BackColor = System.Drawing.Color.White
		Me.PanelmenuLeftSide.Controls.Add(Me.PanelsubMenuMaster)
		Me.PanelmenuLeftSide.Location = New System.Drawing.Point(16, 75)
		Me.PanelmenuLeftSide.Name = "PanelmenuLeftSide"
		Me.PanelmenuLeftSide.Size = New System.Drawing.Size(148, 554)
		Me.PanelmenuLeftSide.TabIndex = 0
		'
		'PaneltopBanner
		'
		Me.PaneltopBanner.BackColor = System.Drawing.Color.White
		Me.PaneltopBanner.Location = New System.Drawing.Point(163, 35)
		Me.PaneltopBanner.Name = "PaneltopBanner"
		Me.PaneltopBanner.Size = New System.Drawing.Size(886, 40)
		Me.PaneltopBanner.TabIndex = 1
		'
		'Panellogo
		'
		Me.Panellogo.BackgroundImage = Global.EDP.My.Resources.Resources.Logo_Periplus_Dasar_Puth
		Me.Panellogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.Panellogo.Location = New System.Drawing.Point(16, 5)
		Me.Panellogo.Name = "Panellogo"
		Me.Panellogo.Size = New System.Drawing.Size(148, 100)
		Me.Panellogo.TabIndex = 2
		'
		'PanelsubMenuMaster
		'
		Me.PanelsubMenuMaster.BackColor = System.Drawing.Color.White
		Me.PanelsubMenuMaster.Controls.Add(Me.Buttonmaster)
		Me.PanelsubMenuMaster.Dock = System.Windows.Forms.DockStyle.Top
		Me.PanelsubMenuMaster.Location = New System.Drawing.Point(0, 0)
		Me.PanelsubMenuMaster.Name = "PanelsubMenuMaster"
		Me.PanelsubMenuMaster.Size = New System.Drawing.Size(148, 554)
		Me.PanelsubMenuMaster.TabIndex = 3
		'
		'Buttonmaster
		'
		Me.Buttonmaster.BackColor = System.Drawing.Color.Aqua
		Me.Buttonmaster.FlatAppearance.BorderSize = 0
		Me.Buttonmaster.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue
		Me.Buttonmaster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
		Me.Buttonmaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Buttonmaster.Font = New System.Drawing.Font("Centaur", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Buttonmaster.Location = New System.Drawing.Point(3, 0)
		Me.Buttonmaster.Name = "Buttonmaster"
		Me.Buttonmaster.Size = New System.Drawing.Size(141, 23)
		Me.Buttonmaster.TabIndex = 0
		Me.Buttonmaster.Text = "Master"
		Me.Buttonmaster.UseVisualStyleBackColor = False
		'
		'edpHomeForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Aqua
		Me.ClientSize = New System.Drawing.Size(1055, 629)
		Me.Controls.Add(Me.PanelmenuLeftSide)
		Me.Controls.Add(Me.Panellogo)
		Me.Controls.Add(Me.PaneltopBanner)
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "edpHomeForm"
		Me.Opacity = 0.97R
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "edpHomeForm"
		Me.PanelmenuLeftSide.ResumeLayout(False)
		Me.PanelsubMenuMaster.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents PanelmenuLeftSide As Panel
	Friend WithEvents PaneltopBanner As Panel
	Friend WithEvents Panellogo As Panel
	Friend WithEvents PanelsubMenuMaster As Panel
	Friend WithEvents Buttonmaster As Button
End Class
