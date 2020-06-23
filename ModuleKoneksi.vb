Imports System.Data.SqlClient


Module ModuleKoneksi
	Public Conn As SqlConnection
	Public Da As SqlDataAdapter
	Public Dr As SqlDataReader
	Public Cmd As SqlCommand
	Public Ds As DataSet

	Sub KoneksiINV()
		Try
			Conn = New SqlConnection("Data Source =NUNU-PC\SQLEXPRESS; Initial Catalog = INV ; Integrated Security = true")
			Conn.Open()
			edpLoginForm.Label_Status.Text = "Connected"
		Catch ex As Exception
			edpLoginForm.Label_Status.Text = "Failed"

		End Try
	End Sub

	'Sub viewBeginning()
	'	edpHomeForm.PanelsubMenuMaster.Visible = True
	'	edpHomeForm.PanelsubMenuProses.Visible = True
	'	edpHomeForm.Buttonmaster.Visible = True
	'	edpHomeForm.ButtonsalesHarian.Visible = False
	'	edpHomeForm.Buttonstatus.Visible = False
	'	edpHomeForm.ButtonclassPareto.Visible = False
	'	edpHomeForm.Buttonuser.Visible = False
	'	edpHomeForm.ButtonstoreManager.Visible = False
	'	edpHomeForm.ButtonjadwalOrderToko.Visible = False
	'	edpHomeForm.ButtontargetSalesToko.Visible = False
	'	edpHomeForm.ButtonsettingDatabase.Visible = False
	'	edpHomeForm.ButtoninfoToko.Visible = False
	'	edpHomeForm.ButtonsettingPromoPOS.Visible = False
	'	edpHomeForm.ButtonmasterTokoWeeklyReport.Visible = False
	'	edpHomeForm.ButtonmasterBOW.Visible = False
	'	edpHomeForm.ButtonmasterStaffToko.Visible = False
	'	edpHomeForm.ButtonmasterStrukBandara.Visible = False
	'	edpHomeForm.ButtonmasterToko.Visible = False
	'	edpHomeForm.ButtonmasterDataPOS.Visible = False
	'End Sub

	Sub viewBeginning()
		edpHomeForm.Buttonmaster.Visible = True
		edpHomeForm.Buttonproses.Visible = True
		edpHomeForm.PanelsubMenuMaster.Visible = True
		edpHomeForm.PanelsubMenuProses.Visible = True

	End Sub


	Sub hidePanelSubMenuMaster()
		edpHomeForm.PanelsubMenuMaster.Visible = True
		edpHomeForm.Buttonmaster.Visible = True
		edpHomeForm.Buttonstatus.Visible = False
		edpHomeForm.ButtonclassPareto.Visible = False
		edpHomeForm.Buttonuser.Visible = False
		edpHomeForm.ButtonstoreManager.Visible = False
		edpHomeForm.ButtonjadwalOrderToko.Visible = False
		edpHomeForm.ButtontargetSalesToko.Visible = False
		edpHomeForm.ButtonsettingDatabase.Visible = False
		edpHomeForm.ButtoninfoToko.Visible = False
		edpHomeForm.ButtonsettingPromoPOS.Visible = False
		edpHomeForm.ButtonmasterTokoWeeklyReport.Visible = False
		edpHomeForm.ButtonmasterBOW.Visible = False
		edpHomeForm.ButtonmasterStaffToko.Visible = False
		edpHomeForm.ButtonmasterStrukBandara.Visible = False
		edpHomeForm.ButtonmasterToko.Visible = False
		edpHomeForm.ButtonmasterDataPos.Visible = False
	End Sub

	Sub showPanelSubMenuMaster()
		edpHomeForm.PanelsubMenuMaster.Visible = True
		edpHomeForm.Buttonmaster.Visible = True
		edpHomeForm.Buttonstatus.Visible = True
		edpHomeForm.ButtonclassPareto.Visible = True
		edpHomeForm.Buttonuser.Visible = True
		edpHomeForm.ButtonstoreManager.Visible = True
		edpHomeForm.ButtonjadwalOrderToko.Visible = True
		edpHomeForm.ButtontargetSalesToko.Visible = True
		edpHomeForm.ButtonsettingDatabase.Visible = True
		edpHomeForm.ButtoninfoToko.Visible = True
		edpHomeForm.ButtonsettingPromoPOS.Visible = True
		edpHomeForm.ButtonmasterTokoWeeklyReport.Visible = True
		edpHomeForm.ButtonmasterBOW.Visible = True
		edpHomeForm.ButtonmasterStaffToko.Visible = True
		edpHomeForm.ButtonmasterStrukBandara.Visible = True
		edpHomeForm.ButtonmasterToko.Visible = True
		edpHomeForm.ButtonmasterDataPos.Visible = True

	End Sub

	'Sub hidePanelSubMenuProses()
	'	edpHomeForm.PanelsubMenuProses.Visible = True
	'	edpHomeForm.Buttonmaster.Visible = True
	'	edpHomeForm.ButtonsalesHarian.Visible = False
	'End Sub

	'Sub showPanelSubMenuProses()
	'	edpHomeForm.PanelsubMenuProses.Visible = True
	'	edpHomeForm.Buttonmaster.Visible = True
	'	edpHomeForm.ButtonsalesHarian.Visible = True

	'End Sub
End Module
