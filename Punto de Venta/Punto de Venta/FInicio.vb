Public Class FInicio
    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        consultas(dgv, "select * from Persona where usuario='" & txtUusuario.Text & "' and contraseña='" & txtContrasena.Text & "'")

        If dgv.Rows.Count <> 1 Then
            MsgBox("Nombre de Usuario y/o Contrasenha incorrectos")
            Exit Sub
        End If

        'cargar datos de usuario
        intIdPersona = dgv.Rows(0).Cells(0).Value
        strnombre = dgv.Rows(0).Cells(1).Value
        strapellidos = dgv.Rows(0).Cells(2).Value & " " & strnombre = dgv.Rows(0).Cells(3).Value
        intgenero = dgv.Rows(0).Cells(6).Value

        'cargar indices
        NPersona = cargarindices("Persona")
        NProducto = cargarindices("Producto")
        NTipo_Usuario = cargarindices("Tipo_Usuario")
        NVentas = cargarindices("Ventas")
        NVentas_Detalle = cargarindices("Ventas_Detalle")

        'abrir las ventas
        arrFVentas1.Show()
        Me.Hide()

    End Sub
End Class
