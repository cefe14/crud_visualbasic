Public Class Form2

    Private Sub btnCerrarF2_Click(sender As Object, e As EventArgs) Handles btnCerrarF2.Click
        Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Form1.update()
        Close()
    End Sub

    Private Sub btnCrear_Click(sender As Object, e As EventArgs) Handles btnCrear.Click
        Form1.Registro()
        Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCiudad_Click(sender As Object, e As EventArgs) Handles btnCiudad.Click
        CiudadesForm.Show()
    End Sub

End Class