Module Funciones
    Public conex As New OleDb.OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=BASE.accdb;Persist Security Info=False;")
    Public Sub conectarse()
        Try
            conex.Open()
            'MsgBox("Conectado..!")
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module
