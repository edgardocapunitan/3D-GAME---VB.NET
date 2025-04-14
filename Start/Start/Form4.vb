Public Class Form4
    Dim x As Integer
    Dim kalaban As Integer
    Dim langaw As Integer
    Private Sub Form4_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
        If (e.KeyCode = Keys.Q) Then
            spear1timer.Enabled = True
            spear1.Left = Boy.Left
        End If
        If (e.KeyCode = Keys.E) Then
            firetimer.Enabled = True
            fire.Left = Boy.Left
        End If

    End Sub

    Private Sub Form4_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If (e.KeyCode = Keys.D) Then
            x = 12
            Boy.Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\Boy" & x & ".png")
        End If
        If (e.KeyCode = Keys.A) Then
            x = 12
            Boy.Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\Boy" & x & ".png")
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With bg2
            .Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\bg2.png")
            .SizeMode = PictureBoxSizeMode.Zoom
            x = 0
        End With
        With Boy
            .Parent = bg2
            .Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\Boy" & x & ".png")
            .SizeMode = PictureBoxSizeMode.Zoom
            .BackColor = Color.Transparent
        End With
        With rhino
            .Parent = bg2
            .Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\rhino0.png")
            .SizeMode = PictureBoxSizeMode.Zoom
            .BackColor = Color.Transparent
        End With
        With spear1
            .Parent = bg2
            .Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\spear.png")
            .SizeMode = PictureBoxSizeMode.Zoom
            .BackColor = Color.Transparent
        End With
        With fire
            .Parent = bg2
            .Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\fire.png")
            .SizeMode = PictureBoxSizeMode.Zoom
            .BackColor = Color.Transparent
        End With
        With fly
            .Parent = bg2
            .Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\fly0.png")
            .SizeMode = PictureBoxSizeMode.Zoom
            .BackColor = Color.Transparent
        End With
    End Sub

    Private Sub speartimer_Tick(sender As Object, e As EventArgs) Handles spear1timer.Tick
        If ImageCollision(spear1, rhino) = True Then
            spear1.Left = 900
            spear1timer.Enabled = False
            buhayngkalaban.Width = buhayngkalaban.Width - 30
            If buhayngkalaban.Width <= 750 Then
                buhayngkalaban.BackColor = Color.Red
            Else
                buhayngkalaban.BackColor = Color.Green
            End If
            If buhayngkalaban.Width <= 0 Then
                Form5.Show()
                Me.Close()
            End If
        End If
        spear1.Left = spear1.Left + 50
        If spear1.Left >= 900 Then
            spear1timer.Enabled = False
        End If
    End Sub

    Private Sub spear1_Click(sender As Object, e As EventArgs) Handles spear1.Click

    End Sub

    Private Sub rhinotimer_Tick(sender As Object, e As EventArgs) Handles rhinotimer.Tick
        rhino.Left = rhino.Left - 7
        kalaban += 1
        rhino.Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\rhino" & kalaban & ".png")
        If (kalaban >= 3) Then kalaban = 0
        If rhino.Left <= -80 Then
            rhino.Left = 900
        End If
        If ImageCollision(rhino, Boy) = True Then
            rhino.Left = 900
            rhinotimer.Enabled = False
            TextBox1.Width = TextBox1.Width - 200
            If TextBox1.Width <= 100 Then
                TextBox1.BackColor = Color.Red
            Else
                TextBox1.BackColor = Color.Green

            End If
            If TextBox1.Width <= 0 Then
                Form10.Show()
                Me.Close()
            End If
            rhino.Left = rhino.Left + 25
        End If
    End Sub

    Private Sub firetimer_Tick(sender As Object, e As EventArgs) Handles firetimer.Tick
        If ImageCollision(fire, rhino) = True Then
            fire.Left = 900
            firetimer.Enabled = False
            buhayngkalaban.Width = buhayngkalaban.Width - 25
            If buhayngkalaban.Width <= 750 Then
                buhayngkalaban.BackColor = Color.Red
            Else
                buhayngkalaban.BackColor = Color.Green
            End If
            If buhayngkalaban.Width <= 0 Then
                Form5.Show()
                Me.Close()
            End If
        End If
        fire.Left = fire.Left + 50
        If fire.Left >= 900 Then
            firetimer.Enabled = False
        End If
    End Sub

    Private Sub flytimer_Tick(sender As Object, e As EventArgs) Handles flytimer.Tick
        fly.Left = fly.Left - 80
        langaw += 1
        fly.Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\fly" & langaw & ".png")
        If (langaw >= 2) Then langaw = 0
    End Sub
End Class