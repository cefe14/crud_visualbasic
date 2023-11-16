Imports System.Data.OleDb

Public Class CiudadesForm
    Public idCiudad_Selector As Integer
    Dim NombreCiudad As String
    Public idCiudadSeleccionada As Integer
    Public NombreCiudad As String


    Private Sub CiudadesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        busqueda()

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Public Sub Registro()
        Try
            conex.Open()
            'Creo variable tipo string
            Dim sql As String = "INSERT INTO Ciudad (Nombre, CodigoPostal) VALUES (@Nombre, @CodigoPostal)"
            'Variable tipo oledbcommand
            Dim comando As New OleDbCommand(sql, conex)
            With comando.Parameters
                .AddWithValue("@Nombre", Form2.tbNombre.Text)
                .AddWithValue("@CodigoPostal", Form2.tbDireccion.Text)
            End With
            'Ejecutar ejecuciones de sql'
            comando.ExecuteNonQuery()
            MessageBox.Show("registro completado")
            conex.Close()
        Catch ex As Exception
            MessageBox.Show("Falla de registro debido a: " & ex.Message)
            conex.Close()
        End Try
    End Sub

    Private Sub busqueda()
        Try
            conex.Open()
            Dim sql As String = "SELECT idCiudad, Nombre, CodigoPostal FROM Ciudad "
            Dim comando As New OleDbCommand(sql, conex)
            Dim da As New OleDbDataAdapter(comando)
            Dim dt As New DataTable()
            da.Fill(dt)
            'Ver en el datagriev
            dtgCiudad.DataSource = dt
            'Oculto la columna ID CLIENTE'
            dtgCiudad.Columns("idCiudad").Visible = False
            conex.Close()
        Catch ex As Exception
            MessageBox.Show("error al mostrar datos, debido a: " & ex.Message)

        End Try

    End Sub
    Private Sub dtgCiudad_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgCiudad.CellClick
        idCiudadSeleccionada = dtgCiudad.CurrentRow.Cells(0).Value
        NombreCiudad = dtgCiudad.CurrentRow.Cells(1).Value
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Form2.tbciudad.Text = idCiudadSeleccionada

        Close()

    End Sub
End Class