<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FConsultasVentas
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
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.mtxtFecha1 = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtFecha2 = New System.Windows.Forms.MaskedTextBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.lblmda1 = New System.Windows.Forms.Label()
        Me.lblmda2 = New System.Windows.Forms.Label()
        Me.dgvDetallesVenta = New System.Windows.Forms.DataGridView()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalSuma = New System.Windows.Forms.Label()
        Me.lblDetalles = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnRegresar = New System.Windows.Forms.Button()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetallesVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPeriodo
        '
        Me.lblPeriodo.AutoSize = True
        Me.lblPeriodo.Location = New System.Drawing.Point(30, 9)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(43, 13)
        Me.lblPeriodo.TabIndex = 0
        Me.lblPeriodo.Text = "Periodo"
        '
        'mtxtFecha1
        '
        Me.mtxtFecha1.Location = New System.Drawing.Point(12, 74)
        Me.mtxtFecha1.Mask = "00/00/0000"
        Me.mtxtFecha1.Name = "mtxtFecha1"
        Me.mtxtFecha1.Size = New System.Drawing.Size(100, 20)
        Me.mtxtFecha1.TabIndex = 1
        Me.mtxtFecha1.ValidatingType = GetType(Date)
        '
        'mtxtFecha2
        '
        Me.mtxtFecha2.Location = New System.Drawing.Point(151, 74)
        Me.mtxtFecha2.Mask = "00/00/0000"
        Me.mtxtFecha2.Name = "mtxtFecha2"
        Me.mtxtFecha2.Size = New System.Drawing.Size(100, 20)
        Me.mtxtFecha2.TabIndex = 2
        Me.mtxtFecha2.ValidatingType = GetType(Date)
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(93, 115)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultar.TabIndex = 3
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'dgvVentas
        '
        Me.dgvVentas.AllowUserToAddRows = False
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Location = New System.Drawing.Point(56, 162)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.Size = New System.Drawing.Size(438, 182)
        Me.dgvVentas.TabIndex = 4
        '
        'lblmda1
        '
        Me.lblmda1.AutoSize = True
        Me.lblmda1.Location = New System.Drawing.Point(13, 55)
        Me.lblmda1.Name = "lblmda1"
        Me.lblmda1.Size = New System.Drawing.Size(73, 13)
        Me.lblmda1.TabIndex = 5
        Me.lblmda1.Text = "mm//dd//año"
        '
        'lblmda2
        '
        Me.lblmda2.AutoSize = True
        Me.lblmda2.Location = New System.Drawing.Point(151, 54)
        Me.lblmda2.Name = "lblmda2"
        Me.lblmda2.Size = New System.Drawing.Size(73, 13)
        Me.lblmda2.TabIndex = 6
        Me.lblmda2.Text = "mm//dd//año"
        '
        'dgvDetallesVenta
        '
        Me.dgvDetallesVenta.AllowUserToAddRows = False
        Me.dgvDetallesVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetallesVenta.Location = New System.Drawing.Point(56, 435)
        Me.dgvDetallesVenta.Name = "dgvDetallesVenta"
        Me.dgvDetallesVenta.Size = New System.Drawing.Size(438, 155)
        Me.dgvDetallesVenta.TabIndex = 7
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(290, 366)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(40, 13)
        Me.lblTotal.TabIndex = 8
        Me.lblTotal.Text = "Total $"
        '
        'lblTotalSuma
        '
        Me.lblTotalSuma.AutoSize = True
        Me.lblTotalSuma.Location = New System.Drawing.Point(363, 366)
        Me.lblTotalSuma.Name = "lblTotalSuma"
        Me.lblTotalSuma.Size = New System.Drawing.Size(10, 13)
        Me.lblTotalSuma.TabIndex = 9
        Me.lblTotalSuma.Text = "."
        '
        'lblDetalles
        '
        Me.lblDetalles.AutoSize = True
        Me.lblDetalles.Location = New System.Drawing.Point(33, 397)
        Me.lblDetalles.Name = "lblDetalles"
        Me.lblDetalles.Size = New System.Drawing.Size(102, 13)
        Me.lblDetalles.TabIndex = 10
        Me.lblDetalles.Text = "Detalles de la Venta"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(256, 125)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(213, 13)
        Me.lblInfo.TabIndex = 11
        Me.lblInfo.Text = "De clic en alguna venta para verla a detalle"
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(431, 48)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(101, 46)
        Me.btnRegresar.TabIndex = 12
        Me.btnRegresar.Text = "Regresar al Menu"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'FConsultasVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 615)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblDetalles)
        Me.Controls.Add(Me.lblTotalSuma)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.dgvDetallesVenta)
        Me.Controls.Add(Me.lblmda2)
        Me.Controls.Add(Me.lblmda1)
        Me.Controls.Add(Me.dgvVentas)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.mtxtFecha2)
        Me.Controls.Add(Me.mtxtFecha1)
        Me.Controls.Add(Me.lblPeriodo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FConsultasVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultas Ventas"
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetallesVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPeriodo As Label
    Friend WithEvents mtxtFecha1 As MaskedTextBox
    Friend WithEvents mtxtFecha2 As MaskedTextBox
    Friend WithEvents btnConsultar As Button
    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents lblmda1 As Label
    Friend WithEvents lblmda2 As Label
    Friend WithEvents dgvDetallesVenta As DataGridView
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotalSuma As Label
    Friend WithEvents lblDetalles As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents btnRegresar As Button
End Class
