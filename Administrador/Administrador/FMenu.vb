Public Class FMenu
    Private Sub btnConsultas_Click(sender As Object, e As EventArgs) Handles btnConsultas.Click
        ConsultasVentas.Show()
        Me.Hide()
    End Sub

    Private Sub btnPlatillos_Click(sender As Object, e As EventArgs) Handles btnPlatillos.Click
        ConsultasPlatillos.Show()
        Me.Hide()
    End Sub

    Private Sub FMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAgregarUsuarios_Click(sender As Object, e As EventArgs) Handles btnAgregarUsuarios.Click
        AgregarUsuarios.Show()
        Me.Hide()
    End Sub
End Class