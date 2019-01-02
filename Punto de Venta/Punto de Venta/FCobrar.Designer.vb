<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FCobrar
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
        Me.lblPorPagar = New System.Windows.Forms.Label()
        Me.lblPago = New System.Windows.Forms.Label()
        Me.lblCambio = New System.Windows.Forms.Label()
        Me.txtPorPagar = New System.Windows.Forms.TextBox()
        Me.txtPago = New System.Windows.Forms.TextBox()
        Me.txtCambio = New System.Windows.Forms.TextBox()
        Me.btnCorrecto = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPorPagar
        '
        Me.lblPorPagar.AutoSize = True
        Me.lblPorPagar.Location = New System.Drawing.Point(66, 69)
        Me.lblPorPagar.Name = "lblPorPagar"
        Me.lblPorPagar.Size = New System.Drawing.Size(54, 13)
        Me.lblPorPagar.TabIndex = 0
        Me.lblPorPagar.Text = "Por Pagar"
        '
        'lblPago
        '
        Me.lblPago.AutoSize = True
        Me.lblPago.Location = New System.Drawing.Point(69, 114)
        Me.lblPago.Name = "lblPago"
        Me.lblPago.Size = New System.Drawing.Size(32, 13)
        Me.lblPago.TabIndex = 1
        Me.lblPago.Text = "Pago"
        '
        'lblCambio
        '
        Me.lblCambio.AutoSize = True
        Me.lblCambio.Location = New System.Drawing.Point(69, 168)
        Me.lblCambio.Name = "lblCambio"
        Me.lblCambio.Size = New System.Drawing.Size(42, 13)
        Me.lblCambio.TabIndex = 2
        Me.lblCambio.Text = "Cambio"
        '
        'txtPorPagar
        '
        Me.txtPorPagar.BackColor = System.Drawing.Color.White
        Me.txtPorPagar.Location = New System.Drawing.Point(165, 61)
        Me.txtPorPagar.Name = "txtPorPagar"
        Me.txtPorPagar.ReadOnly = True
        Me.txtPorPagar.Size = New System.Drawing.Size(100, 20)
        Me.txtPorPagar.TabIndex = 3
        '
        'txtPago
        '
        Me.txtPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPago.Location = New System.Drawing.Point(183, 114)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.Size = New System.Drawing.Size(100, 20)
        Me.txtPago.TabIndex = 4
        '
        'txtCambio
        '
        Me.txtCambio.BackColor = System.Drawing.Color.White
        Me.txtCambio.Location = New System.Drawing.Point(165, 160)
        Me.txtCambio.Name = "txtCambio"
        Me.txtCambio.ReadOnly = True
        Me.txtCambio.Size = New System.Drawing.Size(100, 20)
        Me.txtCambio.TabIndex = 5
        '
        'btnCorrecto
        '
        Me.btnCorrecto.Location = New System.Drawing.Point(165, 211)
        Me.btnCorrecto.Name = "btnCorrecto"
        Me.btnCorrecto.Size = New System.Drawing.Size(75, 23)
        Me.btnCorrecto.TabIndex = 6
        Me.btnCorrecto.Text = "Correcto"
        Me.btnCorrecto.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(283, 210)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'FCobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 296)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnCorrecto)
        Me.Controls.Add(Me.txtCambio)
        Me.Controls.Add(Me.txtPago)
        Me.Controls.Add(Me.txtPorPagar)
        Me.Controls.Add(Me.lblCambio)
        Me.Controls.Add(Me.lblPago)
        Me.Controls.Add(Me.lblPorPagar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FCobrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cobrar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPorPagar As Label
    Friend WithEvents lblPago As Label
    Friend WithEvents lblCambio As Label
    Friend WithEvents txtPorPagar As TextBox
    Friend WithEvents txtPago As TextBox
    Friend WithEvents txtCambio As TextBox
    Friend WithEvents btnCorrecto As Button
    Friend WithEvents btnCancelar As Button
End Class
