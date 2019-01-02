Public Class FInicio
    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        consultas(dgv, "select * from Persona where usuario='" & txtUsuario.Text & "' and contraseña='" & txtContrasena.Text & "' and id_persona=1")

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

        Me.Hide()
        MMenu.Show()
    End Sub
End Class
