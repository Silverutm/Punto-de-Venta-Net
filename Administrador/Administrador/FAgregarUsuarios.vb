Public Class FAgregarUsuarios
    Dim kanterior As Integer = -1
    Dim intidPersonaCambiar As Long
    Dim boolNuevaPersona As Boolean = False
    Private Sub btnVerAdministradores_Click(sender As Object, e As EventArgs) Handles btnVerAdministradores.Click
        consultas(dgvPersonas, "SELECT * FROM Persona WHERE " &
                  "id_tipo_usuario_P=1")
        btnGuardar.Visible = False
    End Sub

    Private Sub btnVerVendedores_Click(sender As Object, e As EventArgs) Handles btnVerVendedores.Click
        consultas(dgvPersonas, "SELECT * FROM Persona WHERE " &
                  "id_tipo_usuario_P=2")
        btnGuardar.Visible = False
    End Sub

    Private Sub dgvPersonas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPersonas.CellClick
        Dim k As Integer = dgvPersonas.CurrentRow.Index
        If kanterior = k Then
            Exit Sub
        End If
        intidPersonaCambiar = dgvPersonas.Rows(k).Cells(0).Value
        txtNombre.Text = dgvPersonas.Rows(k).Cells(1).Value
        txtApellidoPaterno.Text = dgvPersonas.Rows(k).Cells(2).Value
        txtApellidoMaterno.Text = dgvPersonas.Rows(k).Cells(3).Value
        mtxtFecha.Text = dgvPersonas.Rows(k).Cells(4).Value
        txtCorreo.Text = dgvPersonas.Rows(k).Cells(5).Value
        txtTelefono.Text = dgvPersonas.Rows(k).Cells(7).Value
        txtCalle.Text = dgvPersonas.Rows(k).Cells(8).Value
        txtColonia.Text = dgvPersonas.Rows(k).Cells(9).Value
        txtMunicipio.Text = dgvPersonas.Rows(k).Cells(10).Value
        txtCodigoPostal.Text = dgvPersonas.Rows(k).Cells(11).Value
        txtUsuario.Text = dgvPersonas.Rows(k).Cells(12).Value
        txtContrasena.Text = dgvPersonas.Rows(k).Cells(13).Value

        btnGuardar.Visible = True
        boolNuevaPersona = False
        pPanel.Visible = False

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Hide()
        MMenu.Show()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If boolNuevaPersona = False Then
            cambios("UPDATE Persona SET nombres_persona='" & txtNombre.Text & "', apellido_paterno_persona='" & txtApellidoPaterno.Text & "', " &
                "apellido_materno_persona='" & txtApellidoMaterno.Text & "', fecha_nacimiento_persona='" & CDate(mtxtFecha.Text) & "', " &
                "correo_electronico='" & txtCorreo.Text & "', telefono='" & txtTelefono.Text & "', calle_numero='" & txtCalle.Text & "', " &
                "colonia='" & txtColonia.Text & "', municipio='" & txtMunicipio.Text & "', codigo_postal='" & txtCodigoPostal.Text & "' " &
                "usuario='" & txtUsuario.Text & ", contraseña='" & txtContrasena.Text & "' " &
                " WHERE id_persona=" & intidPersonaCambiar)
        Else
            cambios("INSERT INTO Persona VALUES(" & NPersona & ",'" & txtNombre.Text & "','" & txtApellidoPaterno.Text & "','" & txtApellidoMaterno.Text &
                    "','" & CDate(mtxtFecha.Text) & "','" & txtCorreo.Text & "',1,'" & txtTelefono.Text & "','" & txtCalle.Text & "'" &
                    ",'" & txtColonia.Text & "','" & txtMunicipio.Text & "','" & txtCodigoPostal.Text & "','" & txtUsuario.Text & "','" & txtContrasena.Text & "'," & txtTipoUsuario.Text & " )")
            NPersona += 1
            archivos("Persona", CStr(NPersona))
        End If


        txtNombre.Text = ""
        txtApellidoPaterno.Text = ""
        txtApellidoMaterno.Text = ""
        mtxtFecha.Text = ""
        txtCorreo.Text = ""
        txtTelefono.Text = ""
        txtCalle.Text = ""
        txtColonia.Text = ""
        txtMunicipio.Text = ""
        txtCodigoPostal.Text = ""
        txtUsuario.Text = ""
        txtContrasena.Text = ""

        btnGuardar.Visible = False
        pPanel.Visible = True
        boolNuevaPersona = False
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        pPanel.Visible = False
        btnGuardar.Visible = True
        boolNuevaPersona = True
        MsgBox("Despues de agregar los datos de clic en guardar cambios")
    End Sub
End Class