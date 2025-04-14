Public Class Form6
    Dim x As Integer
    Dim kalaban As Integer


    Private Sub Form6_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.D) Then
            x = x + 1
            If (x >= 11) Then x = 0
            Boy.Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\Boy" & x & ".png")
            Boy.Left = Boy.Left + 10
        End If
        If (e.KeyCode = Keys.A) Then
            x = x + 1
            If (x >= 24) Then x = 13
            Boy.Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\Boy" & x & ".png")
            Boy.Left = Boy.Left - 10
        End If
        If (e.KeyCode = Keys.W) Then
            bullettimer.Enabled = True
            bullet.Left = Boy.Left
        End If
        If (e.KeyCode = Keys.E) Then
            firetimer.Enabled = True
            fire.Left = Boy.Left
        End If
        If (e.KeyCode = Keys.Q) Then
            speartimer.Enabled = True
            spear.Left = Boy.Left
        End If
        If (vhp.Width <= 100) Then
            dfiretimer.Enabled = True
            dfire.Left = fdrag.Left
        End If


    End Sub

    Private Sub Form6_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If (e.KeyCode = Keys.D) Then
            x = 12
            Boy.Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\Boy" & x & ".png")
        End If
        If (e.KeyCode = Keys.A) Then
            x = 12
            Boy.Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\Boy" & x & ".png")
        End If
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        x = 0
        With lbg
            .Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\lbg.png")
            .SizeMode = PictureBoxSizeMode.Zoom
        End With
        With Boy
            .Parent = lbg
            .Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\Boy" & x & ".png")
            .SizeMode = PictureBoxSizeMode.Zoom
            .BackColor = Color.Transparent
        End With
        With bullet
            .Parent = lbg
            .Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\bullet1.png")
            .SizeMode = PictureBoxSizeMode.Zoom
            .BackColor = Color.Transparent
        End With
        With fdrag
            .Parent = lbg
            .Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\fdrag0.png")
            .SizeMode = PictureBoxSizeMode.Zoom
            .BackColor = Color.Transparent
        End With
        With fire
            .Parent = lbg
            .Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\fire.png")
            .SizeMode = PictureBoxSizeMode.Zoom
            .BackColor = Color.Transparent
        End With
        With dfire
            .Parent = lbg
            .Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\Dfire.png")
            .SizeMode = PictureBoxSizeMode.Zoom
            .BackColor = Color.Transparent
        End With
        With spear
            .Parent = lbg
            .Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\spear.png")
            .SizeMode = PictureBoxSizeMode.Zoom
            .BackColor = Color.Transparent
        End With


    End Sub

    Private Sub bullettimer_Tick(sender As Object, e As EventArgs) Handles bullettimer.Tick
        If ImageCollision(bullet, fdrag) = True Then
            bullet.Left = 900
            bullettimer.Enabled = False
            vhp.Width = vhp.Width - 30
            If vhp.Width <= 1000 Then
                vhp.BackColor = Color.Red
            Else
                vhp.BackColor = Color.Green
            End If
            If vhp.Width <= 0 Then
                Form7.Show()
                Me.Close()
            End If
        End If
        bullet.Left = bullet.Left + 50
        If bullet.Left >= 900 Then
            bullettimer.Enabled = False
        End If
    End Sub

    Private Sub dragtimer_Tick(sender As Object, e As EventArgs) Handles dragtimer.Tick
        kalaban += 1
        fdrag.Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\fdrag" & kalaban & ".png")
        If (kalaban >= 3) Then kalaban = 0
        If fdrag.Left <= -80 Then
            fdrag.Left = 900
        End If
        If ImageCollision(fdrag, Boy) = True Then
            fdrag.Left = 900
            dragtimer.Enabled = False
            Boyhp.Width = Boyhp.Width - 200
            If Boyhp.Width <= 100 Then
                Boyhp.BackColor = Color.Red
            Else
                Boyhp.BackColor = Color.Green

            End If
            If Boyhp.Width <= 0 Then
                Form9.Show()
                Me.Close()
            End If
            fdrag.Left = fdrag.Left + 25
        End If
    End Sub

    Private Sub firetimer_Tick(sender As Object, e As EventArgs) Handles firetimer.Tick
        If ImageCollision(fire, fdrag) = True Then
            fire.Left = 900
            firetimer.Enabled = False
            vhp.Width = vhp.Width - 30
            If vhp.Width <= 1000 Then
                vhp.BackColor = Color.Red
            Else
                vhp.BackColor = Color.Green
            End If
            If vhp.Width <= 0 Then
                Form7.Show()
                Me.Close()
            End If

        End If
        fire.Left = fire.Left + 50
        If fire.Left >= 900 Then
            firetimer.Enabled = False

        End If
    End Sub
    Private Sub dfiretimer_Tick(sender As Object, e As EventArgs) Handles dfiretimer.Tick
        If ImageCollision(Boy, dfire) = True Then
            dfire.Left = -10
            dfiretimer.Enabled = False
            Boyhp.Width = Boyhp.Width - 50
        End If
        dfire.Left = dfire.Left - 300
        If Boyhp.Width <= 500 Then
            Boyhp.BackColor = Color.Red
        Else
            Boyhp.BackColor = Color.Green
        End If
        If Boyhp.Width <= 0 Then
            Form8.Show()
            Form7.Close()
            Me.Hide()
        End If
    End Sub

    Private Sub speartimer_Tick(sender As Object, e As EventArgs) Handles speartimer.Tick
        If ImageCollision(spear, fdrag) = True Then
            spear.Left = 900
            speartimer.Enabled = False
            vhp.Width = vhp.Width - 60
            If vhp.Width <= 600 Then
                vhp.BackColor = Color.Red
            Else
                vhp.BackColor = Color.Green

            End If
            If vhp.Width <= 0 Then
                Form7.Show()
                Me.Close()
            End If

        End If
        spear.Left = spear.Left + 25
        If spear.Left >= 900 Then
            speartimer.Enabled = False
        End If
    End Sub
End Class