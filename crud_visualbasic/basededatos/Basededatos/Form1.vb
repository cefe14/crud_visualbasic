Imports System.Data.OleDb
Public Class Form1
    '::: Cadena de conexion
    '::: Base de datos Local.
    'Private conexion As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=BASE.accdb;Persist Security Info=False;")
    Dim boleano As Boolean = False
    Dim idupdate As Integer
    Dim nombreSeleccionado As String
    Dim direccionSeleccionada As String
    Dim telefonoSeleccionado As String
    Dim fechaNacSeleccionada As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectarse()
        Consulta()
    End Sub
    Public Sub Registro()
        Try
            conex.Open()
            'Creo variable tipo string
            Dim sql As String = "INSERT INTO Tabla1 (Nombre, Direccion, Telefono, fecha_nac, idCiudad) VALUES (@Nombre, @Direccion , @Telefono, @fecha_nac, @idCiudad)"
            'Variable tipo oledbcommand
            Dim comando As New OleDbCommand(sql, conex)
            With comando.Parameters
                .AddWithValue("@Nombre", Form2.tbNombre.Text)
                .AddWithValue("@Direccion", Form2.tbDireccion.Text)
                .AddWithValue("@Telefono", Form2.tbTelefono.Text)
                .AddWithValue("@fecha_nac", Form2.tbfnacim.Text)
                .AddWithValue("@idCiudad", CiudadesForm.NombreCiudad)
            End With
            'Ejecutar ejecuciones de sql'
            comando.ExecuteNonQuery()
            MessageBox.Show("registro completado")
            conex.Close()
            Consulta()
            borrarTextos()
        Catch ex As Exception
            MessageBox.Show("Falla de registro debido a: " & ex.Message)
            conex.Close()
        End Try
    End Sub
    ' FIN INSERT

    Private Sub borrarTextos()
        Form2.tbNombre.Text = ""
        Form2.tbDireccion.Text = ""
        Form2.tbTelefono.Text = ""
        Form2.tbfnacim.Text = ""
        Form2.tbciudad.Text = ""
    End Sub
    Private Sub Consulta()
        Try
            conex.Open()
            Dim sql As String = "SELECT Tabla1.idCliente, Tabla1.Nombre, Tabla1.Direccion, Tabla1.Telefono, Tabla1.fecha_Nac, Ciudad.nombre " &
                                "FROM Tabla1 " &
                                "INNER JOIN Ciudad ON Tabla1.idCiudad = Ciudad.IdCiudad " &
                                "ORDER BY Tabla1.idCliente DESC"
            Dim comando As New OleDbCommand(sql, conex)
            Dim da As New OleDbDataAdapter(comando)
            Dim dt As New DataTable()
            da.Fill(dt)
            'Ver en el datagriev

            DGVClientes.DataSource = dt
            'Modifico los nombres de las columnas del DGV'
            DGVClientes.Columns("fecha_nac").HeaderText = "Nacimiento"
            DGVClientes.Columns("Ciudad.nombre").HeaderText = "Ciudad"
            DGVClientes.Columns("Tabla1.Nombre").HeaderText = "Nombre"
            'Oculto la columna ID CLIENTE'
            DGVClientes.Columns("Idcliente").Visible = False
            conex.Close()
        Catch ex As Exception
            MessageBox.Show("error al mostrar datos, debido a: " & ex.Message)

        End Try

    End Sub
    Private Sub busqueda(columna)
        Try
            conex.Open()
            Dim sql As String = "SELECT IdCliente, Nombre, Direccion, Telefono, Fecha_Nac FROM Tabla1 " & columna & " ORDER BY IdCliente Desc"
            Dim comando As New OleDbCommand(sql, conex)
            Dim da As New OleDbDataAdapter(comando)
            Dim dt As New DataTable()
            da.Fill(dt)
            'Ver en el datagriev
            DGVClientes.DataSource = dt
            'Modifico los nombres de las columnas del DGV'
            DGVClientes.Columns("fecha_nac").HeaderText = "Nacimiento"
            'Oculto la columna ID CLIENTE'
            DGVClientes.Columns("Idcliente").Visible = False
            conex.Close()
        Catch ex As Exception
            MessageBox.Show("error al mostrar datos, debido a: " & ex.Message)

        End Try

    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Select Case cbCliente.SelectedIndex
            Case "0"
                If txtBuscar.Text Is "" Then
                    Dim columna_vacia As String = ""
                    busqueda(columna_vacia)
                Else
                    Dim columna As String = "WHERE Idcliente = " & txtBuscar.Text
                    busqueda(columna)
                End If

            Case "1"
                If txtBuscar.Text Is "" Then
                    Dim columna_vacia As String = ""
                    busqueda(columna_vacia)
                Else
                    Dim columna As String = "WHERE Nombre Like '" & txtBuscar.Text & "%'"
                    busqueda(columna)
                End If
            Case "2"
                If txtBuscar.Text Is "" Then
                    Dim columna_vacia As String = ""
                    busqueda(columna_vacia)
                Else
                    Dim columna As String = "WHERE Direccion like '" & txtBuscar.Text & "%'"
                    busqueda(columna)
                End If
            Case "3"
                If txtBuscar.Text Is "" Then
                    Dim columna_vacia As String = ""
                    busqueda(columna_vacia)
                Else
                    Dim columna As String = "WHERE Telefono like '" & txtBuscar.Text & "%'"
                    busqueda(columna)
                End If
            Case "4"
                If txtBuscar.Text Is "" Then
                    Dim columna_vacia As String = ""
                    busqueda(columna_vacia)
                Else
                    Dim columna As String = "WHERE Fecha_Nac like '" & txtBuscar.Text & "%'"
                    busqueda(columna)
                End If
        End Select
        conex.Close()
    End Sub

    Private Sub DGVClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVClientes.CellClick
        idupdate = DGVClientes.CurrentRow.Cells(0).Value
        Form2.tbNombre.Text = DGVClientes.CurrentRow.Cells(1).Value
        Form2.tbDireccion.Text = DGVClientes.CurrentRow.Cells(2).Value
        Form2.tbTelefono.Text = DGVClientes.CurrentRow.Cells(3).Value
        Form2.tbfnacim.Text = DGVClientes.CurrentRow.Cells(4).Value

    End Sub
    Public Sub update()
        Try
            If Form2.tbNombre.Text IsNot "" Then
                conex.Open()
                Dim sql As String = "UPDATE Tabla1 SET Nombre = @Nombre , Direccion = @Direccion , Telefono = @Telefono WHERE idCliente = " & idupdate
                Dim comando As New OleDbCommand(sql, conex)
                comando.Parameters.AddWithValue("@Nombre", Form2.tbNombre.Text)
                comando.Parameters.AddWithValue("@Direccion", Form2.tbDireccion.Text)
                comando.Parameters.AddWithValue("@Telefono", Form2.tbTelefono.Text)
                comando.Parameters.AddWithValue("@fecha_nac", Form2.tbfnacim.Text)
                comando.ExecuteNonQuery()
                MessageBox.Show("Actualización completado")
                conex.Close()
                Consulta()
            Else
                MsgBox("No ingresaste un nombre")
            End If
        Catch ex As Exception
            MsgBox("No se logro realizar la operacion por: " & ex.Message)
            conex.Close()
        End Try
    End Sub
    Public Sub delete()
        Dim ideliminar As Integer

        ideliminar = DGVClientes.CurrentRow.Cells(0).Value
        Dim sql As String = "DELETE FROM Tabla1 WHERE IdCliente = " & ideliminar

        Try
            conex.Open()
            'Variable tipo oledbcommand
            Dim comando As New OleDbCommand(sql, conex)
            'Ejecutar ejecuciones de sql'
            comando.ExecuteNonQuery()
            MessageBox.Show("registro completado")
            conex.Close()

            Consulta()
        Catch ex As Exception
            MsgBox("No se logro realizar la operacion por: " & ex.Message)
        End Try
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        delete()
    End Sub
    Private Sub UserForm_Initialize()
        Form2.Show()
    End Sub
    Private Sub btnPrueba_Click(sender As Object, e As EventArgs) Handles btnPrueba.Click
        UserForm_Initialize()
        Form2.btnCrear.Visible = False


    End Sub

    Private Sub DGVClientes_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DGVClientes.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        UserForm_Initialize()
        Form2.btnUpdate.Visible = False
        borrarTextos()

    End Sub
End Class