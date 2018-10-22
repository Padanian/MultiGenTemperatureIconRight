<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultiGenTemperatureIcon
    Inherits System.Windows.Forms.UserControl

    'UserControl1 esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblTemp = New System.Windows.Forms.Label()
        Me.pbLED = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pbLED, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(4, 25)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(37, 13)
        Me.lblName.TabIndex = 22
        Me.lblName.Text = "Tashp"
        '
        'lblTemp
        '
        Me.lblTemp.AutoSize = True
        Me.lblTemp.Location = New System.Drawing.Point(4, 44)
        Me.lblTemp.Name = "lblTemp"
        Me.lblTemp.Size = New System.Drawing.Size(39, 13)
        Me.lblTemp.TabIndex = 23
        Me.lblTemp.Text = "99.9°C"
        '
        'pbLED
        '
        Me.pbLED.Image = Global.MultiGenTemperatureIcon.My.Resources.Resources.ledoff
        Me.pbLED.Location = New System.Drawing.Point(63, 3)
        Me.pbLED.Name = "pbLED"
        Me.pbLED.Size = New System.Drawing.Size(16, 16)
        Me.pbLED.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLED.TabIndex = 25
        Me.pbLED.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MultiGenTemperatureIcon.My.Resources.Resources.thermometer_symbol
        Me.PictureBox1.Location = New System.Drawing.Point(47, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pbLED)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTemp)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(84, 63)
        CType(Me.pbLED, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbLED As PictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblTemp As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
