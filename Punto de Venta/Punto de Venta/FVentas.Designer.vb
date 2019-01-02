<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FVentas
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.cbProducto = New System.Windows.Forms.ComboBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalSuma = New System.Windows.Forms.Label()
        Me.btnCobrar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.dgvcomodin = New System.Windows.Forms.DataGridView()
        Me.cbEliminar = New System.Windows.Forms.ComboBox()
        Me.lblEliminar = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvcomodin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(848, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(48, 55)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(50, 13)
        Me.lblProducto.TabIndex = 1
        Me.lblProducto.Text = "Producto"
        '
        'cbProducto
        '
        Me.cbProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbProducto.FormattingEnabled = True
        Me.cbProducto.Location = New System.Drawing.Point(51, 88)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Size = New System.Drawing.Size(121, 21)
        Me.cbProducto.TabIndex = 2
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(253, 55)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 54)
        Me.btnConsultar.TabIndex = 3
        Me.btnConsultar.Text = "Consultar Precio"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(527, 429)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 13)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total"
        '
        'lblTotalSuma
        '
        Me.lblTotalSuma.AutoSize = True
        Me.lblTotalSuma.Location = New System.Drawing.Point(577, 429)
        Me.lblTotalSuma.Name = "lblTotalSuma"
        Me.lblTotalSuma.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalSuma.TabIndex = 5
        Me.lblTotalSuma.Text = "$"
        '
        'btnCobrar
        '
        Me.btnCobrar.Location = New System.Drawing.Point(451, 487)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCobrar.TabIndex = 6
        Me.btnCobrar.Text = "Cobrar"
        Me.btnCobrar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(561, 486)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'dgvVentas
        '
        Me.dgvVentas.AllowUserToAddRows = False
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Location = New System.Drawing.Point(253, 145)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.ReadOnly = True
        Me.dgvVentas.Size = New System.Drawing.Size(527, 260)
        Me.dgvVentas.TabIndex = 8
        '
        'dgvcomodin
        '
        Me.dgvcomodin.AllowUserToAddRows = False
        Me.dgvcomodin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcomodin.Location = New System.Drawing.Point(351, 41)
        Me.dgvcomodin.Name = "dgvcomodin"
        Me.dgvcomodin.Size = New System.Drawing.Size(199, 54)
        Me.dgvcomodin.TabIndex = 9
        Me.dgvcomodin.Visible = False
        '
        'cbEliminar
        '
        Me.cbEliminar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbEliminar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbEliminar.FormattingEnabled = True
        Me.cbEliminar.Location = New System.Drawing.Point(51, 234)
        Me.cbEliminar.Name = "cbEliminar"
        Me.cbEliminar.Size = New System.Drawing.Size(121, 21)
        Me.cbEliminar.TabIndex = 10
        '
        'lblEliminar
        '
        Me.lblEliminar.AutoSize = True
        Me.lblEliminar.Location = New System.Drawing.Point(51, 193)
        Me.lblEliminar.Name = "lblEliminar"
        Me.lblEliminar.Size = New System.Drawing.Size(43, 13)
        Me.lblEliminar.TabIndex = 11
        Me.lblEliminar.Text = "Eliminar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(-15, -15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(51, 485)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'FVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 571)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblEliminar)
        Me.Controls.Add(Me.cbEliminar)
        Me.Controls.Add(Me.dgvcomodin)
        Me.Controls.Add(Me.dgvVentas)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnCobrar)
        Me.Controls.Add(Me.lblTotalSuma)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.cbProducto)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvcomodin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents lblProducto As Label
    Friend WithEvents cbProducto As ComboBox
    Friend WithEvents btnConsultar As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotalSuma As Label
    Friend WithEvents btnCobrar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents dgvcomodin As DataGridView
    Friend WithEvents cbEliminar As ComboBox
    Friend WithEvents lblEliminar As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSalir As Button
End Class
