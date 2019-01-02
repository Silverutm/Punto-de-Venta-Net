Public Class FCobrar
    Private Sub txtPago_TextChanged(sender As Object, e As EventArgs) Handles txtPago.TextChanged
        Try
            txtCambio.Text = txtPago.Text - txtPorPagar.Text
            If txtCambio.Text < 0 Then
                txtCambio.ForeColor = Color.Red
            Else
                txtCambio.ForeColor = Color.Green
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCorrecto_Click(sender As Object, e As EventArgs) Handles btnCorrecto.Click
        guardarventa()

        arrFVentas1.Close()
        arrFVentas1 = New FVentas
        arrFVentas1.Show()
        Me.Close()
    End Sub

    Private Sub FCobrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPorPagar.Text = dbTotal
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        arrFVentas1.Show()
        Me.Close()
    End Sub
End Class