<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FConsultas
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
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.dgvConsultas = New System.Windows.Forms.DataGridView()
        CType(Me.dgvConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(32, 53)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(50, 13)
        Me.lblProducto.TabIndex = 0
        Me.lblProducto.Text = "Producto"
        '
        'cbProducto
        '
        Me.cbProducto.FormattingEnabled = True
        Me.cbProducto.Location = New System.Drawing.Point(48, 80)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Size = New System.Drawing.Size(121, 21)
        Me.cbProducto.TabIndex = 1
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(253, 344)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 2
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'dgvConsultas
        '
        Me.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultas.Location = New System.Drawing.Point(86, 164)
        Me.dgvConsultas.Name = "dgvConsultas"
        Me.dgvConsultas.Size = New System.Drawing.Size(240, 150)
        Me.dgvConsultas.TabIndex = 3
        '
        'FConsultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 449)
        Me.Controls.Add(Me.dgvConsultas)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.cbProducto)
        Me.Controls.Add(Me.lblProducto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FConsultas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultas"
        CType(Me.dgvConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProducto As Label
    Friend WithEvents cbProducto As ComboBox
    Friend WithEvents btnRegresar As Button
    Friend WithEvents dgvConsultas As DataGridView
End Class
