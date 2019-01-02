<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAgregarUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnVerAdministradores = New System.Windows.Forms.Button()
        Me.btnVerVendedores = New System.Windows.Forms.Button()
        Me.dgvPersonas = New System.Windows.Forms.DataGridView()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellidopaterno = New System.Windows.Forms.Label()
        Me.lblApellidoMaterno = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblCalle = New System.Windows.Forms.Label()
        Me.lblColonia = New System.Windows.Forms.Label()
        Me.lblMunicipio = New System.Windows.Forms.Label()
        Me.lblCP = New System.Windows.Forms.Label()
        Me.mtxtFecha = New System.Windows.Forms.MaskedTextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.txtApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.txtCodigoPostal = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.pPanel = New System.Windows.Forms.Panel()
        Me.lblTipoUsuario = New System.Windows.Forms.Label()
        Me.txtTipoUsuario = New System.Windows.Forms.TextBox()
        CType(Me.dgvPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVerAdministradores
        '
        Me.btnVerAdministradores.Location = New System.Drawing.Point(47, 88)
        Me.btnVerAdministradores.Name = "btnVerAdministradores"
        Me.btnVerAdministradores.Size = New System.Drawing.Size(97, 49)
        Me.btnVerAdministradores.TabIndex = 0
        Me.btnVerAdministradores.Text = "Ver Administradores"
        Me.btnVerAdministradores.UseVisualStyleBackColor = True
        '
        'btnVerVendedores
        '
        Me.btnVerVendedores.Location = New System.Drawing.Point(47, 184)
        Me.btnVerVendedores.Name = "btnVerVendedores"
        Me.btnVerVendedores.Size = New System.Drawing.Size(97, 42)
        Me.btnVerVendedores.TabIndex = 1
        Me.btnVerVendedores.Text = "Ver Vendedores"
        Me.btnVerVendedores.UseVisualStyleBackColor = True
        '
        'dgvPersonas
        '
        Me.dgvPersonas.AllowUserToAddRows = False
        Me.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPersonas.Location = New System.Drawing.Point(184, 88)
        Me.dgvPersonas.Name = "dgvPersonas"
        Me.dgvPersonas.Size = New System.Drawing.Size(625, 150)
        Me.dgvPersonas.TabIndex = 2
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(184, 49)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(248, 13)
        Me.lblInfo.TabIndex = 3
        Me.lblInfo.Text = "De clic en alguna person apara modificar sus datos"
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(561, 286)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 44)
        Me.btnRegresar.TabIndex = 4
        Me.btnRegresar.Text = "Regresar al Menu"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(561, 345)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "Guardar Cambios"
        Me.btnGuardar.UseVisualStyleBackColor = True
        Me.btnGuardar.Visible = False
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(561, 389)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "Agregar Usuario"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(184, 286)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 7
        Me.lblNombre.Text = "Nombre"
        '
        'lblApellidopaterno
        '
        Me.lblApellidopaterno.AutoSize = True
        Me.lblApellidopaterno.Location = New System.Drawing.Point(187, 319)
        Me.lblApellidopaterno.Name = "lblApellidopaterno"
        Me.lblApellidopaterno.Size = New System.Drawing.Size(84, 13)
        Me.lblApellidopaterno.TabIndex = 8
        Me.lblApellidopaterno.Text = "Apellido Paterno"
        '
        'lblApellidoMaterno
        '
        Me.lblApellidoMaterno.AutoSize = True
        Me.lblApellidoMaterno.Location = New System.Drawing.Point(187, 353)
        Me.lblApellidoMaterno.Name = "lblApellidoMaterno"
        Me.lblApellidoMaterno.Size = New System.Drawing.Size(86, 13)
        Me.lblApellidoMaterno.TabIndex = 9
        Me.lblApellidoMaterno.Text = "Apellido Materno"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(187, 394)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(108, 13)
        Me.lblFecha.TabIndex = 10
        Me.lblFecha.Text = "Fecha de Nacimiento"
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(190, 432)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(35, 13)
        Me.lblCorreo.TabIndex = 11
        Me.lblCorreo.Text = "E-mail"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(190, 481)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefono.TabIndex = 12
        Me.lblTelefono.Text = "Telefono"
        '
        'lblCalle
        '
        Me.lblCalle.AutoSize = True
        Me.lblCalle.Location = New System.Drawing.Point(190, 519)
        Me.lblCalle.Name = "lblCalle"
        Me.lblCalle.Size = New System.Drawing.Size(30, 13)
        Me.lblCalle.TabIndex = 13
        Me.lblCalle.Text = "Calle"
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.Location = New System.Drawing.Point(190, 552)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(42, 13)
        Me.lblColonia.TabIndex = 14
        Me.lblColonia.Text = "Colonia"
        '
        'lblMunicipio
        '
        Me.lblMunicipio.AutoSize = True
        Me.lblMunicipio.Location = New System.Drawing.Point(187, 583)
        Me.lblMunicipio.Name = "lblMunicipio"
        Me.lblMunicipio.Size = New System.Drawing.Size(52, 13)
        Me.lblMunicipio.TabIndex = 15
        Me.lblMunicipio.Text = "Municipio"
        '
        'lblCP
        '
        Me.lblCP.AutoSize = True
        Me.lblCP.Location = New System.Drawing.Point(187, 615)
        Me.lblCP.Name = "lblCP"
        Me.lblCP.Size = New System.Drawing.Size(72, 13)
        Me.lblCP.TabIndex = 16
        Me.lblCP.Text = "Codigo Postal"
        '
        'mtxtFecha
        '
        Me.mtxtFecha.Location = New System.Drawing.Point(300, 391)
        Me.mtxtFecha.Mask = "00/00/0000"
        Me.mtxtFecha.Name = "mtxtFecha"
        Me.mtxtFecha.Size = New System.Drawing.Size(100, 20)
        Me.mtxtFecha.TabIndex = 17
        Me.mtxtFecha.ValidatingType = GetType(Date)
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(300, 288)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 18
        '
        'txtApellidoPaterno
        '
        Me.txtApellidoPaterno.Location = New System.Drawing.Point(300, 319)
        Me.txtApellidoPaterno.Name = "txtApellidoPaterno"
        Me.txtApellidoPaterno.Size = New System.Drawing.Size(100, 20)
        Me.txtApellidoPaterno.TabIndex = 19
        '
        'txtApellidoMaterno
        '
        Me.txtApellidoMaterno.Location = New System.Drawing.Point(300, 357)
        Me.txtApellidoMaterno.Name = "txtApellidoMaterno"
        Me.txtApellidoMaterno.Size = New System.Drawing.Size(100, 20)
        Me.txtApellidoMaterno.TabIndex = 20
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(300, 429)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(100, 20)
        Me.txtCorreo.TabIndex = 21
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(300, 474)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono.TabIndex = 22
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(287, 519)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(100, 20)
        Me.txtCalle.TabIndex = 23
        '
        'txtColonia
        '
        Me.txtColonia.Location = New System.Drawing.Point(287, 549)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(100, 20)
        Me.txtColonia.TabIndex = 24
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(278, 583)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(100, 20)
        Me.txtMunicipio.TabIndex = 25
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.Location = New System.Drawing.Point(287, 615)
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoPostal.TabIndex = 26
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(287, 658)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUsuario.TabIndex = 27
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(287, 704)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(100, 20)
        Me.txtContrasena.TabIndex = 28
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(187, 658)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 29
        Me.lblUsuario.Text = "Usuario"
        '
        'lblContrasena
        '
        Me.lblContrasena.AutoSize = True
        Me.lblContrasena.Location = New System.Drawing.Point(190, 704)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(61, 13)
        Me.lblContrasena.TabIndex = 30
        Me.lblContrasena.Text = "Contraseña"
        '
        'pPanel
        '
        Me.pPanel.Location = New System.Drawing.Point(105, 143)
        Me.pPanel.Name = "pPanel"
        Me.pPanel.Size = New System.Drawing.Size(273, 515)
        Me.pPanel.TabIndex = 31
        '
        'lblTipoUsuario
        '
        Me.lblTipoUsuario.AutoSize = True
        Me.lblTipoUsuario.Location = New System.Drawing.Point(193, 731)
        Me.lblTipoUsuario.Name = "lblTipoUsuario"
        Me.lblTipoUsuario.Size = New System.Drawing.Size(109, 13)
        Me.lblTipoUsuario.TabIndex = 32
        Me.lblTipoUsuario.Text = "Tipo de Usuario 0 o 1"
        '
        'txtTipoUsuario
        '
        Me.txtTipoUsuario.Location = New System.Drawing.Point(287, 731)
        Me.txtTipoUsuario.Name = "txtTipoUsuario"
        Me.txtTipoUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtTipoUsuario.TabIndex = 33
        '
        'FAgregarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 768)
        Me.Controls.Add(Me.pPanel)
        Me.Controls.Add(Me.lblContrasena)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtCodigoPostal)
        Me.Controls.Add(Me.txtMunicipio)
        Me.Controls.Add(Me.txtColonia)
        Me.Controls.Add(Me.txtCalle)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.txtApellidoMaterno)
        Me.Controls.Add(Me.txtApellidoPaterno)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.mtxtFecha)
        Me.Controls.Add(Me.lblCP)
        Me.Controls.Add(Me.lblMunicipio)
        Me.Controls.Add(Me.lblColonia)
        Me.Controls.Add(Me.lblCalle)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblApellidoMaterno)
        Me.Controls.Add(Me.lblApellidopaterno)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.dgvPersonas)
        Me.Controls.Add(Me.btnVerVendedores)
        Me.Controls.Add(Me.btnVerAdministradores)
        Me.Controls.Add(Me.txtTipoUsuario)
        Me.Controls.Add(Me.lblTipoUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FAgregarUsuarios"
        Me.Text = "Agregar Usuarios"
        CType(Me.dgvPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVerAdministradores As Button
    Friend WithEvents btnVerVendedores As Button
    Friend WithEvents dgvPersonas As DataGridView
    Friend WithEvents lblInfo As Label
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellidopaterno As Label
    Friend WithEvents lblApellidoMaterno As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblCalle As Label
    Friend WithEvents lblColonia As Label
    Friend WithEvents lblMunicipio As Label
    Friend WithEvents lblCP As Label
    Friend WithEvents mtxtFecha As MaskedTextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellidoPaterno As TextBox
    Friend WithEvents txtApellidoMaterno As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCalle As TextBox
    Friend WithEvents txtColonia As TextBox
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents txtCodigoPostal As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblContrasena As Label
    Friend WithEvents pPanel As Panel
    Friend WithEvents lblTipoUsuario As Label
    Friend WithEvents txtTipoUsuario As TextBox
End Class
