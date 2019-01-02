Public Class FConsultasPlatillos
    Dim kanterior As Integer = -1
    Dim intidPlatilloCambiar As Long
    Dim boolNuevoPlatillo As Boolean = False
    Private Sub FConsultasPlatillos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Esto me da los indices del comodin
        consultas(dgvcomodin, "select id_producto, nombre_producto, precio_producto, caracteristica from Producto")

        cbProducto.Items.Clear()

        For i = 0 To dgvcomodin.Rows.Count - 1
            'Agregar los elementos que se pueden vender
            cbProducto.Items.Add(dgvcomodin.Rows(i).Cells(1).Value)
        Next
    End Sub

    Private Sub cbProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProducto.SelectedIndexChanged
        Dim k As Integer = cbProducto.SelectedIndex

        'dgvPlatillos.RowCount = 1
        'dgvPlatillos.ColumnCount = 4
        'dgvPlatillos.Columns(0).Visible = False

        'Dim i As Integer
        'For i = 0 To 3
        'dgvPlatillos.Rows(0).Cells(i).Value = dgvcomodin.Rows(k).Cells(i).Value
        'Next

        consultas(dgvPlatillos, "select id_producto, nombre_producto, precio_producto, caracteristica from Producto WHERE id_producto=" & dgvcomodin.Rows(k).Cells(0).Value)
        dgvPlatillos.Columns(0).Visible = False

        cbProducto.Text = ""
        chbTodos.Checked = False
        pPanel.Visible = True
    End Sub

    Private Sub chbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chbTodos.CheckedChanged
        'dgvPlatillos.RowCount = 0
        'dgvPlatillos.ColumnCount = 0
        If chbTodos.Checked = True Then
            consultas(dgvPlatillos, "select id_producto, nombre_producto, precio_producto, caracteristica from Producto")
            dgvPlatillos.Columns(0).Visible = False
        Else
            'consultas(dgvPlatillos, "select id_producto, nombre_producto, precio_producto, caracteristica from Producto where id_producto=-1")
            'dgvPlatillos.RowCount = 0
        End If
        pPanel.Visible = True
    End Sub

    Private Sub dgvPlatillos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPlatillos.CellClick
        pPanel.Visible = False
        btGuardarCambios.Visible = True
        Dim k As Integer = dgvPlatillos.CurrentRow.Index
        If kanterior = k Then
            Exit Sub
        End If
        intidPlatilloCambiar = dgvPlatillos.Rows(k).Cells(0).Value
        txtNombre.Text = dgvPlatillos.Rows(k).Cells(1).Value
        txtCaracteristica.Text = dgvPlatillos.Rows(k).Cells(3).Value
        txtPrecio.Text = dgvPlatillos.Rows(k).Cells(2).Value
        boolNuevoPlatillo = False
    End Sub

    Private Sub btGuardarCambios_Click(sender As Object, e As EventArgs) Handles btGuardarCambios.Click
        If boolNuevoPlatillo = False Then
            cambios("UPDATE Producto SET nombre_producto='" & txtNombre.Text & "', caracteristica='" & txtCaracteristica.Text &
                "', precio_producto=" & txtPrecio.Text & " WHERE id_producto=" & intidPlatilloCambiar)
        Else
            cambios("INSERT INTO Producto VALUES (" & NProducto & ",'" & txtNombre.Text & "', '" & txtCaracteristica.Text & "', " & txtPrecio.Text & ", 0, 1)")
            NProducto += 1
            archivos("Producto", CStr(NProducto))
        End If


        txtNombre.Text = ""
        txtCaracteristica.Text = ""
        txtPrecio.Text = ""

        btGuardarCambios.Visible = False
        pPanel.Visible = True
        boolNuevoPlatillo = False
        FConsultasPlatillos_Load(sender, e)
    End Sub

    Private Sub btnAgregarPlatillo_Click(sender As Object, e As EventArgs) Handles btnAgregarPlatillo.Click
        pPanel.Visible = False
        btGuardarCambios.Visible = True
        boolNuevoPlatillo = True
        MsgBox("Despues de agregar los datos del platillo, de clic en guardar cambios")
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Hide()
        MMenu.Show()
    End Sub
End Class