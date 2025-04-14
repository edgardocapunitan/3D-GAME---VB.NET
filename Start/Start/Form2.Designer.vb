<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.hbg = New System.Windows.Forms.PictureBox()
        Me.Boy = New System.Windows.Forms.PictureBox()
        Me.kalbo = New System.Windows.Forms.PictureBox()
        Me.flyg = New System.Windows.Forms.PictureBox()
        Me.boom = New System.Windows.Forms.PictureBox()
        Me.spear = New System.Windows.Forms.PictureBox()
        Me.fire = New System.Windows.Forms.PictureBox()
        Me.flygtimer = New System.Windows.Forms.Timer(Me.components)
        Me.firetimer = New System.Windows.Forms.Timer(Me.components)
        Me.boomtimer = New System.Windows.Forms.Timer(Me.components)
        Me.speartimer = New System.Windows.Forms.Timer(Me.components)
        Me.kalbotimer = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.hbg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Boy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kalbo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flyg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.boom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fire, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'hbg
        '
        Me.hbg.BackColor = System.Drawing.SystemColors.Control
        Me.hbg.Image = CType(resources.GetObject("hbg.Image"), System.Drawing.Image)
        Me.hbg.Location = New System.Drawing.Point(-3, -2)
        Me.hbg.Name = "hbg"
        Me.hbg.Size = New System.Drawing.Size(872, 564)
        Me.hbg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hbg.TabIndex = 0
        Me.hbg.TabStop = False
        '
        'Boy
        '
        Me.Boy.BackColor = System.Drawing.SystemColors.Control
        Me.Boy.Image = CType(resources.GetObject("Boy.Image"), System.Drawing.Image)
        Me.Boy.Location = New System.Drawing.Point(-3, 325)
        Me.Boy.Name = "Boy"
        Me.Boy.Size = New System.Drawing.Size(77, 148)
        Me.Boy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Boy.TabIndex = 1
        Me.Boy.TabStop = False
        '
        'kalbo
        '
        Me.kalbo.BackColor = System.Drawing.SystemColors.Control
        Me.kalbo.Image = CType(resources.GetObject("kalbo.Image"), System.Drawing.Image)
        Me.kalbo.Location = New System.Drawing.Point(719, 323)
        Me.kalbo.Name = "kalbo"
        Me.kalbo.Size = New System.Drawing.Size(150, 150)
        Me.kalbo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.kalbo.TabIndex = 2
        Me.kalbo.TabStop = False
        '
        'flyg
        '
        Me.flyg.BackColor = System.Drawing.SystemColors.Control
        Me.flyg.Image = CType(resources.GetObject("flyg.Image"), System.Drawing.Image)
        Me.flyg.Location = New System.Drawing.Point(12, 12)
        Me.flyg.Name = "flyg"
        Me.flyg.Size = New System.Drawing.Size(77, 71)
        Me.flyg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.flyg.TabIndex = 3
        Me.flyg.TabStop = False
        '
        'boom
        '
        Me.boom.BackColor = System.Drawing.SystemColors.Control
        Me.boom.Image = CType(resources.GetObject("boom.Image"), System.Drawing.Image)
        Me.boom.Location = New System.Drawing.Point(914, 323)
        Me.boom.Name = "boom"
        Me.boom.Size = New System.Drawing.Size(92, 88)
        Me.boom.TabIndex = 4
        Me.boom.TabStop = False
        '
        'spear
        '
        Me.spear.BackColor = System.Drawing.SystemColors.Control
        Me.spear.Image = CType(resources.GetObject("spear.Image"), System.Drawing.Image)
        Me.spear.Location = New System.Drawing.Point(875, 356)
        Me.spear.Name = "spear"
        Me.spear.Size = New System.Drawing.Size(225, 22)
        Me.spear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.spear.TabIndex = 5
        Me.spear.TabStop = False
        '
        'fire
        '
        Me.fire.BackColor = System.Drawing.SystemColors.Control
        Me.fire.Image = CType(resources.GetObject("fire.Image"), System.Drawing.Image)
        Me.fire.Location = New System.Drawing.Point(897, 344)
        Me.fire.Name = "fire"
        Me.fire.Size = New System.Drawing.Size(54, 67)
        Me.fire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fire.TabIndex = 6
        Me.fire.TabStop = False
        '
        'flygtimer
        '
        Me.flygtimer.Enabled = True
        Me.flygtimer.Interval = 1000
        '
        'firetimer
        '
        Me.firetimer.Interval = 50
        '
        'boomtimer
        '
        '
        'speartimer
        '
        '
        'kalbotimer
        '
        Me.kalbotimer.Enabled = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Green
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(595, 281)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(260, 27)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Green
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(12, 288)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(169, 20)
        Me.TextBox2.TabIndex = 8
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(870, 563)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.fire)
        Me.Controls.Add(Me.spear)
        Me.Controls.Add(Me.boom)
        Me.Controls.Add(Me.flyg)
        Me.Controls.Add(Me.kalbo)
        Me.Controls.Add(Me.Boy)
        Me.Controls.Add(Me.hbg)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.hbg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Boy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kalbo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flyg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fire, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents hbg As System.Windows.Forms.PictureBox
    Friend WithEvents Boy As System.Windows.Forms.PictureBox
    Friend WithEvents kalbo As System.Windows.Forms.PictureBox
    Friend WithEvents flyg As System.Windows.Forms.PictureBox
    Friend WithEvents boom As System.Windows.Forms.PictureBox
    Friend WithEvents spear As System.Windows.Forms.PictureBox
    Friend WithEvents fire As System.Windows.Forms.PictureBox
    Friend WithEvents flygtimer As System.Windows.Forms.Timer
    Friend WithEvents firetimer As System.Windows.Forms.Timer
    Friend WithEvents boomtimer As System.Windows.Forms.Timer
    Friend WithEvents speartimer As System.Windows.Forms.Timer
    Friend WithEvents kalbotimer As System.Windows.Forms.Timer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
End Class
