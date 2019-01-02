<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FInicio
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
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblContrasena = New System.Windows.Forms.Label()
        Me.txtUusuario = New System.Windows.Forms.TextBox()
        Me.txtContrasena = New System.Windows.Forms.TextBox()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(61, 98)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Usuario"
        '
        'lblContrasena
        '
        Me.lblContrasena.AutoSize = True
        Me.lblContrasena.Location = New System.Drawing.Point(64, 158)
        Me.lblContrasena.Name = "lblContrasena"
        Me.lblContrasena.Size = New System.Drawing.Size(61, 13)
        Me.lblContrasena.TabIndex = 1
        Me.lblContrasena.Text = "Contraseña"
        '
        'txtUusuario
        '
        Me.txtUusuario.Location = New System.Drawing.Point(175, 108)
        Me.txtUusuario.Name = "txtUusuario"
        Me.txtUusuario.Size = New System.Drawing.Size(100, 20)
        Me.txtUusuario.TabIndex = 2
        '
        'txtContrasena
        '
        Me.txtContrasena.Location = New System.Drawing.Point(175, 158)
        Me.txtContrasena.Name = "txtContrasena"
        Me.txtContrasena.Size = New System.Drawing.Size(100, 20)
        Me.txtContrasena.TabIndex = 3
        '
        'btnEntrar
        '
        Me.btnEntrar.Location = New System.Drawing.Point(175, 217)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(75, 23)
        Me.btnEntrar.TabIndex = 4
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(25, 12)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(250, 62)
        Me.dgv.TabIndex = 5
        Me.dgv.Visible = False
        '
        'FInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 336)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.btnEntrar)
        Me.Controls.Add(Me.txtContrasena)
        Me.Controls.Add(Me.txtUusuario)
        Me.Controls.Add(Me.lblContrasena)
        Me.Controls.Add(Me.lblUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de Sesion"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblContrasena As Label
    Friend WithEvents txtUusuario As TextBox
    Friend WithEvents txtContrasena As TextBox
    Friend WithEvents btnEntrar As Button
    Friend WithEvents dgv As DataGridView
End Class
