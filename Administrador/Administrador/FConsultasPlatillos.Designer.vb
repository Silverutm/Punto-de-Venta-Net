<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FConsultasPlatillos
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
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.cbProducto = New System.Windows.Forms.ComboBox()
        Me.chbTodos = New System.Windows.Forms.CheckBox()
        Me.dgvPlatillos = New System.Windows.Forms.DataGridView()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btGuardarCambios = New System.Windows.Forms.Button()
        Me.btnAgregarPlatillo = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCaracteristica = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCaracteristica = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.pPanel = New System.Windows.Forms.Panel()
        Me.dgvcomodin = New System.Windows.Forms.DataGridView()
        Me.btnRegresar = New System.Windows.Forms.Button()
        CType(Me.dgvPlatillos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvcomodin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(70, 31)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(50, 13)
        Me.lblProducto.TabIndex = 0
        Me.lblProducto.Text = "Producto"
        '
        'cbProducto
        '
        Me.cbProducto.FormattingEnabled = True
        Me.cbProducto.Location = New System.Drawing.Point(73, 67)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Size = New System.Drawing.Size(121, 21)
        Me.cbProducto.TabIndex = 1
        '
        'chbTodos
        '
        Me.chbTodos.AutoSize = True
        Me.chbTodos.Location = New System.Drawing.Point(267, 71)
        Me.chbTodos.Name = "chbTodos"
        Me.chbTodos.Size = New System.Drawing.Size(56, 17)
        Me.chbTodos.TabIndex = 2
        Me.chbTodos.Text = "Todos"
        Me.chbTodos.UseVisualStyleBackColor = True
        '
        'dgvPlatillos
        '
        Me.dgvPlatillos.AllowUserToAddRows = False
        Me.dgvPlatillos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPlatillos.Location = New System.Drawing.Point(60, 141)
        Me.dgvPlatillos.Name = "dgvPlatillos"
        Me.dgvPlatillos.Size = New System.Drawing.Size(407, 140)
        Me.dgvPlatillos.TabIndex = 4
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(70, 111)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(226, 13)
        Me.lblInfo.TabIndex = 5
        Me.lblInfo.Text = "De clic en un platillo para editar su informacion"
        '
        'btGuardarCambios
        '
        Me.btGuardarCambios.Location = New System.Drawing.Point(505, 320)
        Me.btGuardarCambios.Name = "btGuardarCambios"
        Me.btGuardarCambios.Size = New System.Drawing.Size(96, 37)
        Me.btGuardarCambios.TabIndex = 6
        Me.btGuardarCambios.Text = "Guardar Cambios"
        Me.btGuardarCambios.UseVisualStyleBackColor = True
        Me.btGuardarCambios.Visible = False
        '
        'btnAgregarPlatillo
        '
        Me.btnAgregarPlatillo.Location = New System.Drawing.Point(505, 384)
        Me.btnAgregarPlatillo.Name = "btnAgregarPlatillo"
        Me.btnAgregarPlatillo.Size = New System.Drawing.Size(96, 36)
        Me.btnAgregarPlatillo.TabIndex = 7
        Me.btnAgregarPlatillo.Text = "Agregar Platillo"
        Me.btnAgregarPlatillo.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(70, 320)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblNombre.TabIndex = 8
        Me.lblNombre.Text = "Nombre"
        '
        'lblCaracteristica
        '
        Me.lblCaracteristica.AutoSize = True
        Me.lblCaracteristica.Location = New System.Drawing.Point(164, 320)
        Me.lblCaracteristica.Name = "lblCaracteristica"
        Me.lblCaracteristica.Size = New System.Drawing.Size(71, 13)
        Me.lblCaracteristica.TabIndex = 9
        Me.lblCaracteristica.Text = "Caracteristica"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Location = New System.Drawing.Point(310, 320)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(37, 13)
        Me.lblPrecio.TabIndex = 10
        Me.lblPrecio.Text = "Precio"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(48, 363)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 11
        '
        'txtCaracteristica
        '
        Me.txtCaracteristica.Location = New System.Drawing.Point(167, 363)
        Me.txtCaracteristica.Name = "txtCaracteristica"
        Me.txtCaracteristica.Size = New System.Drawing.Size(100, 20)
        Me.txtCaracteristica.TabIndex = 12
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(294, 363)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 20)
        Me.txtPrecio.TabIndex = 13
        '
        'pPanel
        '
        Me.pPanel.Location = New System.Drawing.Point(48, 320)
        Me.pPanel.Name = "pPanel"
        Me.pPanel.Size = New System.Drawing.Size(430, 100)
        Me.pPanel.TabIndex = 14
        '
        'dgvcomodin
        '
        Me.dgvcomodin.AllowUserToAddRows = False
        Me.dgvcomodin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcomodin.Location = New System.Drawing.Point(407, 29)
        Me.dgvcomodin.Name = "dgvcomodin"
        Me.dgvcomodin.Size = New System.Drawing.Size(142, 83)
        Me.dgvcomodin.TabIndex = 15
        Me.dgvcomodin.Visible = False
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(505, 239)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(83, 42)
        Me.btnRegresar.TabIndex = 16
        Me.btnRegresar.Text = "Regresar al Menu"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'FConsultasPlatillos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 482)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.dgvcomodin)
        Me.Controls.Add(Me.pPanel)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtCaracteristica)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblCaracteristica)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnAgregarPlatillo)
        Me.Controls.Add(Me.btGuardarCambios)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.dgvPlatillos)
        Me.Controls.Add(Me.chbTodos)
        Me.Controls.Add(Me.cbProducto)
        Me.Controls.Add(Me.lblProducto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FConsultasPlatillos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultas Platillos"
        CType(Me.dgvPlatillos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvcomodin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProducto As Label
    Friend WithEvents cbProducto As ComboBox
    Friend WithEvents chbTodos As CheckBox
    Friend WithEvents dgvPlatillos As DataGridView
    Friend WithEvents lblInfo As Label
    Friend WithEvents btGuardarCambios As Button
    Friend WithEvents btnAgregarPlatillo As Button
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblCaracteristica As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCaracteristica As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents pPanel As Panel
    Friend WithEvents dgvcomodin As DataGridView
    Friend WithEvents btnRegresar As Button
End Class
