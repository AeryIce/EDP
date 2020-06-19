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


End Module
