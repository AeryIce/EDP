Imports System.Data.SqlClient


Module Koneksi
	Public Conn As SqlConnection
	Public Da As SqlDataAdapter
	Public Dr As SqlDataReader
	Public Cmd As SqlCommand
	Public Ds As DataSet

	Sub Koneksi()
		Try
			Conn = New SqlConnection("se")
		Catch ex As Exception

		End Try
	End Sub


End Module
