<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.bg2 = New System.Windows.Forms.PictureBox()
        Me.Boy = New System.Windows.Forms.PictureBox()
        Me.rhino = New System.Windows.Forms.PictureBox()
        Me.spear1 = New System.Windows.Forms.PictureBox()
        Me.spear1timer = New System.Windows.Forms.Timer(Me.components)
        Me.buhayngkalaban = New System.Windows.Forms.TextBox()
        Me.rhinotimer = New System.Windows.Forms.Timer(Me.components)
        Me.fire = New System.Windows.Forms.PictureBox()
        Me.firetimer = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.fly = New System.Windows.Forms.PictureBox()
        Me.flytimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.bg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Boy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rhino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spear1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fly, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bg2
        '
        Me.bg2.Image = CType(resources.GetObject("bg2.Image"), System.Drawing.Image)
        Me.bg2.Location = New System.Drawing.Point(1, -5)
        Me.bg2.Name = "bg2"
        Me.bg2.Size = New System.Drawing.Size(745, 503)
        Me.bg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bg2.TabIndex = 0
        Me.bg2.TabStop = False
        '
        'Boy
        '
        Me.Boy.Image = CType(resources.GetObject("Boy.Image"), System.Drawing.Image)
        Me.Boy.Location = New System.Drawing.Point(1, 285)
        Me.Boy.Name = "Boy"
        Me.Boy.Size = New System.Drawing.Size(77, 148)
        Me.Boy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Boy.TabIndex = 1
        Me.Boy.TabStop = False
        '
        'rhino
        '
        Me.rhino.Image = CType(resources.GetObject("rhino.Image"), System.Drawing.Image)
        Me.rhino.Location = New System.Drawing.Point(533, 285)
        Me.rhino.Name = "rhino"
        Me.rhino.Size = New System.Drawing.Size(213, 147)
        Me.rhino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.rhino.TabIndex = 2
        Me.rhino.TabStop = False
        '
        'spear1
        '
        Me.spear1.Image = CType(resources.GetObject("spear1.Image"), System.Drawing.Image)
        Me.spear1.Location = New System.Drawing.Point(752, 312)
        Me.spear1.Name = "spear1"
        Me.spear1.Size = New System.Drawing.Size(206, 17)
        Me.spear1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.spear1.TabIndex = 3
        Me.spear1.TabStop = False
        '
        'spear1timer
        '
        '
        'buhayngkalaban
        '
        Me.buhayngkalaban.BackColor = System.Drawing.Color.Green
        Me.buhayngkalaban.Enabled = False
        Me.buhayngkalaban.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buhayngkalaban.Location = New System.Drawing.Point(576, 240)
        Me.buhayngkalaban.Name = "buhayngkalaban"
        Me.buhayngkalaban.Size = New System.Drawing.Size(125, 29)
        Me.buhayngkalaban.TabIndex = 4
        '
        'rhinotimer
        '
        Me.rhinotimer.Enabled = True
        '
        'fire
        '
        Me.fire.Image = CType(resources.GetObject("fire.Image"), System.Drawing.Image)
        Me.fire.Location = New System.Drawing.Point(752, 295)
        Me.fire.Name = "fire"
        Me.fire.Size = New System.Drawing.Size(44, 45)
        Me.fire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fire.TabIndex = 5
        Me.fire.TabStop = False
        '
        'firetimer
        '
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Green
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(12, 249)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(126, 20)
        Me.TextBox1.TabIndex = 6
        '
        'fly
        '
        Me.fly.Image = CType(resources.GetObject("fly.Image"), System.Drawing.Image)
        Me.fly.Location = New System.Drawing.Point(652, 65)
        Me.fly.Name = "fly"
        Me.fly.Size = New System.Drawing.Size(94, 75)
        Me.fly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fly.TabIndex = 7
        Me.fly.TabStop = False
        '
        'flytimer
        '
        Me.flytimer.Enabled = True
        Me.flytimer.Interval = 1000
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(746, 499)
        Me.Controls.Add(Me.fly)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.fire)
        Me.Controls.Add(Me.buhayngkalaban)
        Me.Controls.Add(Me.spear1)
        Me.Controls.Add(Me.rhino)
        Me.Controls.Add(Me.Boy)
        Me.Controls.Add(Me.bg2)
        Me.MaximizeBox = False
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        CType(Me.bg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Boy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rhino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spear1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fly, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bg2 As System.Windows.Forms.PictureBox
    Friend WithEvents Boy As System.Windows.Forms.PictureBox
    Friend WithEvents rhino As System.Windows.Forms.PictureBox
    Friend WithEvents spear1 As System.Windows.Forms.PictureBox
    Friend WithEvents spear1timer As System.Windows.Forms.Timer
    Friend WithEvents buhayngkalaban As System.Windows.Forms.TextBox
    Friend WithEvents rhinotimer As System.Windows.Forms.Timer
    Friend WithEvents fire As System.Windows.Forms.PictureBox
    Friend WithEvents firetimer As System.Windows.Forms.Timer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents fly As System.Windows.Forms.PictureBox
    Friend WithEvents flytimer As System.Windows.Forms.Timer
End Class
