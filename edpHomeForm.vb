Public Class edpHomeForm


	Private Sub edpHomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Call KoneksiINV()
		Call viewBeginning()

	End Sub

	Private Sub Buttonmaster_MouseHover(sender As Object, e As EventArgs) Handles Buttonmaster.MouseHover
		Call showPanelSubMenuMaster()

	End Sub

	Private Sub Buttonmaster_MouseLeave(sender As Object, e As EventArgs) Handles Buttonmaster.MouseLeave
		Call hidePanelSubMenuMaster()

	End Sub


End Class