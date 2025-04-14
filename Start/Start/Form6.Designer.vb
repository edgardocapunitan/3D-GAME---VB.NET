<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.lbg = New System.Windows.Forms.PictureBox()
        Me.Boy = New System.Windows.Forms.PictureBox()
        Me.fdrag = New System.Windows.Forms.PictureBox()
        Me.bullet = New System.Windows.Forms.PictureBox()
        Me.bullettimer = New System.Windows.Forms.Timer(Me.components)
        Me.vhp = New System.Windows.Forms.TextBox()
        Me.dragtimer = New System.Windows.Forms.Timer(Me.components)
        Me.fire = New System.Windows.Forms.PictureBox()
        Me.firetimer = New System.Windows.Forms.Timer(Me.components)
        Me.dfiretimer = New System.Windows.Forms.Timer(Me.components)
        Me.Boyhp = New System.Windows.Forms.TextBox()
        Me.dfire = New System.Windows.Forms.PictureBox()
        Me.spear = New System.Windows.Forms.PictureBox()
        Me.speartimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.lbg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Boy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fdrag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dfire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbg
        '
        Me.lbg.Image = CType(resources.GetObject("lbg.Image"), System.Drawing.Image)
        Me.lbg.Location = New System.Drawing.Point(-1, 0)
        Me.lbg.Name = "lbg"
        Me.lbg.Size = New System.Drawing.Size(755, 572)
        Me.lbg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lbg.TabIndex = 0
        Me.lbg.TabStop = False
        '
        'Boy
        '
        Me.Boy.Image = CType(resources.GetObject("Boy.Image"), System.Drawing.Image)
        Me.Boy.Location = New System.Drawing.Point(-1, 357)
        Me.Boy.Name = "Boy"
        Me.Boy.Size = New System.Drawing.Size(77, 148)
        Me.Boy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Boy.TabIndex = 1
        Me.Boy.TabStop = False
        '
        'fdrag
        '
        Me.fdrag.Image = CType(resources.GetObject("fdrag.Image"), System.Drawing.Image)
        Me.fdrag.Location = New System.Drawing.Point(569, 282)
        Me.fdrag.Name = "fdrag"
        Me.fdrag.Size = New System.Drawing.Size(158, 125)
        Me.fdrag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.fdrag.TabIndex = 2
        Me.fdrag.TabStop = False
        '
        'bullet
        '
        Me.bullet.Image = CType(resources.GetObject("bullet.Image"), System.Drawing.Image)
        Me.bullet.Location = New System.Drawing.Point(760, 357)
        Me.bullet.Name = "bullet"
        Me.bullet.Size = New System.Drawing.Size(140, 24)
        Me.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bullet.TabIndex = 3
        Me.bullet.TabStop = False
        '
        'bullettimer
        '
        '
        'vhp
        '
        Me.vhp.BackColor = System.Drawing.Color.Green
        Me.vhp.Enabled = False
        Me.vhp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vhp.Location = New System.Drawing.Point(503, 253)
        Me.vhp.Name = "vhp"
        Me.vhp.Size = New System.Drawing.Size(238, 23)
        Me.vhp.TabIndex = 4
        '
        'dragtimer
        '
        Me.dragtimer.Enabled = True
        '
        'fire
        '
        Me.fire.Image = CType(resources.GetObject("fire.Image"), System.Drawing.Image)
        Me.fire.Location = New System.Drawing.Point(780, 357)
        Me.fire.Name = "fire"
        Me.fire.Size = New System.Drawing.Size(43, 42)
        Me.fire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fire.TabIndex = 5
        Me.fire.TabStop = False
        '
        'firetimer
        '
        '
        'dfiretimer
        '
        '
        'Boyhp
        '
        Me.Boyhp.BackColor = System.Drawing.Color.Green
        Me.Boyhp.Enabled = False
        Me.Boyhp.Location = New System.Drawing.Point(-1, 309)
        Me.Boyhp.Name = "Boyhp"
        Me.Boyhp.Size = New System.Drawing.Size(184, 20)
        Me.Boyhp.TabIndex = 7
        '
        'dfire
        '
        Me.dfire.Image = CType(resources.GetObject("dfire.Image"), System.Drawing.Image)
        Me.dfire.Location = New System.Drawing.Point(780, 347)
        Me.dfire.Name = "dfire"
        Me.dfire.Size = New System.Drawing.Size(41, 34)
        Me.dfire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dfire.TabIndex = 8
        Me.dfire.TabStop = False
        '
        'spear
        '
        Me.spear.Image = CType(resources.GetObject("spear.Image"), System.Drawing.Image)
        Me.spear.Location = New System.Drawing.Point(760, 334)
        Me.spear.Name = "spear"
        Me.spear.Size = New System.Drawing.Size(206, 17)
        Me.spear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.spear.TabIndex = 9
        Me.spear.TabStop = False
        '
        'speartimer
        '
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 572)
        Me.Controls.Add(Me.spear)
        Me.Controls.Add(Me.dfire)
        Me.Controls.Add(Me.Boyhp)
        Me.Controls.Add(Me.fire)
        Me.Controls.Add(Me.vhp)
        Me.Controls.Add(Me.bullet)
        Me.Controls.Add(Me.fdrag)
        Me.Controls.Add(Me.Boy)
        Me.Controls.Add(Me.lbg)
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form6"
        CType(Me.lbg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Boy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fdrag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dfire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbg As System.Windows.Forms.PictureBox
    Friend WithEvents Boy As System.Windows.Forms.PictureBox
    Friend WithEvents fdrag As System.Windows.Forms.PictureBox
    Friend WithEvents bullet As System.Windows.Forms.PictureBox
    Friend WithEvents bullettimer As System.Windows.Forms.Timer
    Friend WithEvents vhp As System.Windows.Forms.TextBox
    Friend WithEvents dragtimer As System.Windows.Forms.Timer
    Friend WithEvents fire As System.Windows.Forms.PictureBox
    Friend WithEvents firetimer As System.Windows.Forms.Timer
    Friend WithEvents dfiretimer As System.Windows.Forms.Timer
    Friend WithEvents Boyhp As System.Windows.Forms.TextBox
    Friend WithEvents dfire As System.Windows.Forms.PictureBox
    Friend WithEvents spear As System.Windows.Forms.PictureBox
    Friend WithEvents speartimer As System.Windows.Forms.Timer
End Class
