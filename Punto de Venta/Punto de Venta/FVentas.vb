Public Class FVentas

    Private Sub FVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Esto me da los indices del comodin
        consultas(dgvcomodin, "select id_producto, nombre_producto, precio_producto from Producto WHERE enventa=1")


        For i = 0 To dgvcomodin.Rows.Count - 1
            'Agregar los elementos que se pueden vender
            cbProducto.Items.Add(dgvcomodin.Rows(i).Cells(1).Value)
            'Agregar los elementos que se pueden eliminar
            cbEliminar.Items.Add(dgvcomodin.Rows(i).Cells(1).Value)
        Next
        intIndicedeVentas = 0                   'El indice en el data grid view que me dice que venta sigue
        dbTotal = 0
        lblTotalSuma.Text = "$ " & dbTotal
        dgvVentas.ColumnCount = 3
        dgvVentas.Columns(0).HeaderText = "Producto"
        dgvVentas.Columns(1).HeaderText = "Precio"
        dgvVentas.Columns(2).Visible = False    'Esta la utilizare para el id del producto para guardar la venta


    End Sub

    Private Sub cbProducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProducto.SelectedIndexChanged
        Dim k As Integer = cbProducto.SelectedIndex
        dgvVentas.RowCount = intIndicedeVentas + 1              'Por cada producto que escoja debo aumentar una fila en el dgvVentas


        dgvVentas.Rows(intIndicedeVentas).Cells(0).Value = dgvcomodin.Rows(k).Cells(1).Value    'Nombre del producto
        dgvVentas.Rows(intIndicedeVentas).Cells(1).Value = dgvcomodin.Rows(k).Cells(2).Value    'Precio del producto
        dgvVentas.Rows(intIndicedeVentas).Cells(2).Value = dgvcomodin.Rows(k).Cells(0).Value     'id del producto..es invisible
        intIndicedeVentas += 1          'Me paso al siguiente indice
        cbProducto.Text = ""            'Limpio el combobox para que no se vea nada
        dbTotal += dgvcomodin.Rows(k).Cells(2).Value    'Le sumo el precio al total
        lblTotalSuma.Text = "$ " & dbTotal              'Muestro el precio en pantalla
    End Sub

    Private Sub btnCobrar_Click(sender As Object, e As EventArgs) Handles btnCobrar.Click
        Dim cobrar As New FCobrar
        cobrar.Show()
        Me.Hide()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        MsgBox("En Construccion")           'Quiza no lo haga, en un lugar donde todos los precios estan visibles quiza sea innecesario
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        dgvVentas.RowCount = 0              'Si cancelo limpio todo
        intIndicedeVentas = 0
        dbTotal = 0
        lblTotalSuma.Text = "$ " & dbTotal
    End Sub

    Private Sub cbEliminar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEliminar.SelectedIndexChanged
        'Falta hacer que el procuto que quiero eliminar este en el dgvVentas
        '''''''''''''''''''''''''''''''''''''''''''''''

        Dim k As Integer = cbEliminar.SelectedIndex
        dgvVentas.RowCount = intIndicedeVentas + 1              'Por cada producto que escoja debo aumentar una fila en el dgvVentas


        dgvVentas.Rows(intIndicedeVentas).Cells(0).Value = dgvcomodin.Rows(k).Cells(1).Value    'Nombre del producto
        dgvVentas.Rows(intIndicedeVentas).Cells(1).Value = -dgvcomodin.Rows(k).Cells(2).Value    'Precio del producto
        dgvVentas.Rows(intIndicedeVentas).Cells(2).Value = dgvcomodin.Rows(k).Cells(0).Value     'id del producto..es invisible
        intIndicedeVentas += 1          'Me paso al siguiente indice
        cbEliminar.Text = ""            'Limpio el combobox para que no se vea nada
        dbTotal -= dgvcomodin.Rows(k).Cells(2).Value    'Resto el precio al total, acabo de eliminar un producto
        lblTotalSuma.Text = "$ " & dbTotal              'Muestro el precio en pantalla
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'Antes de salir verifico si hay un venta en proceso
        If dgvVentas.Rows.Count <> 0 Then
            Dim k As MsgBoxResult
            k = MsgBox("Hay una venta en proceso, desea salir?", MsgBoxStyle.YesNo, "Cuidado")
            If k = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
        End
    End Sub
End Class