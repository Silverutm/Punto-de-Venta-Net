<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FMenu
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
        Me.btnConsultas = New System.Windows.Forms.Button()
        Me.btnPlatillos = New System.Windows.Forms.Button()
        Me.btnAgregarUsuarios = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnConsultas
        '
        Me.btnConsultas.Location = New System.Drawing.Point(61, 55)
        Me.btnConsultas.Name = "btnConsultas"
        Me.btnConsultas.Size = New System.Drawing.Size(112, 40)
        Me.btnConsultas.TabIndex = 0
        Me.btnConsultas.Text = "Consultas de Ventas"
        Me.btnConsultas.UseVisualStyleBackColor = True
        '
        'btnPlatillos
        '
        Me.btnPlatillos.Location = New System.Drawing.Point(61, 115)
        Me.btnPlatillos.Name = "btnPlatillos"
        Me.btnPlatillos.Size = New System.Drawing.Size(112, 39)
        Me.btnPlatillos.TabIndex = 1
        Me.btnPlatillos.Text = "Platillos (Precios)"
        Me.btnPlatillos.UseVisualStyleBackColor = True
        '
        'btnAgregarUsuarios
        '
        Me.btnAgregarUsuarios.Location = New System.Drawing.Point(61, 183)
        Me.btnAgregarUsuarios.Name = "btnAgregarUsuarios"
        Me.btnAgregarUsuarios.Size = New System.Drawing.Size(105, 44)
        Me.btnAgregarUsuarios.TabIndex = 2
        Me.btnAgregarUsuarios.Text = "Agregar Usuarios"
        Me.btnAgregarUsuarios.UseVisualStyleBackColor = True
        '
        'FMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 280)
        Me.Controls.Add(Me.btnAgregarUsuarios)
        Me.Controls.Add(Me.btnPlatillos)
        Me.Controls.Add(Me.btnConsultas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnConsultas As Button
    Friend WithEvents btnPlatillos As Button
    Friend WithEvents btnAgregarUsuarios As Button
End Class
