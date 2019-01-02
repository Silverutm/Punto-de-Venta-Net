Public Class FConsultasVentas
    Dim kanterior As Integer = -1
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        'MsgBox(CDate(mtxtFecha1.Text),, CDate(mtxtFecha2.Text))
        consultas(dgvVentas, "SELECT id_venta, fecha, total, usuario FROM Ventas, Persona WHERE id_persona=id_Persona_V and '" & CDate(mtxtFecha1.Text) & "' <= fecha " &
        "and '" & CDate(mtxtFecha2.Text).AddDays(1) & "' >= fecha ")

        Dim i As Integer
        Dim bdTotal As Double = 0
        For i = 0 To dgvVentas.Rows.Count - 1
            bdTotal += dgvVentas.Rows(i).Cells(2).Value
        Next
        lblTotalSuma.Text = bdTotal
    End Sub

    Private Sub dgvVentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvVentas.CellClick
        Dim k As Integer = dgvVentas.CurrentRow.Index
        If kanterior = k Then
            Exit Sub
        End If
        consultas(dgvDetallesVenta, "SELECT nombre_producto, precio FROM Ventas_Detalle, Producto WHERE id_producto=id_producto_D and id_venta_D=" &
                  dgvVentas.Rows(k).Cells(0).Value)
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        MMenu.Show()
        Me.Hide()
    End Sub
End Class