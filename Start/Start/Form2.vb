Public Class Form2
    Dim x As Integer
    Dim bang As Integer
    Dim kalaban As Integer
    Dim langaw As Integer

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.D) Then

            x = x + 1
            If (x >= 11) Then x = 0
            Boy.Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\Boy" & x & ".png")
            Boy.Left = Boy.Left + 10
        End If
        If (e.KeyCode = Keys.E) Then
            firetimer.Enabled = True
            fire.Left = Boy.Left
        End If
        If (e.KeyCode = Keys.Q) Then
            speartimer.Enabled = True
            spear.Left = Boy.Left
        End If
        If (e.KeyCode = Keys.A) Then
            x = x + 1
            If (x >= 24) Then x = 13
            Boy.Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\Boy" & x & ".png")
            Boy.Left = Boy.Left - 10
        End If

    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If (e.KeyCode = Keys.D) Then
            x = 12
            Boy.Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\Boy" & x & ".png")
        End If
        If (e.KeyCode = Keys.A) Then
            x = 12
            Boy.Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\Boy" & x & ".png")
        End If

    End Sub

    Private Sub battimer_Tick(sender As Object, e As EventArgs) Handles flygtimer.Tick
        flyg.Left = flyg.Left + 80
        langaw += 1
        flyg.Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\flyg" & langaw & ".png")
        If (langaw >= 2) Then langaw = 0
    End Sub

    Private Sub firetimer_Tick(sender As Object, e As EventArgs) Handles firetimer.Tick
        If ImageCollision(fire, kalbo) = True Then
            fire.Left = 900
            firetimer.Enabled = False
            boomtimer.Enabled = True
            TextBox1.Width = TextBox1.Width - 30
            If TextBox1.Width <= 600 Then
                TextBox1.BackColor = Color.Red
            Else
                TextBox1.BackColor = Color.Green
            End If
            If TextBox1.Width <= 0 Then
                Form3.Show()
                Me.Close()
            End If

        End If
        fire.Left = fire.Left + 50
        If fire.Left >= 900 Then
            firetimer.Enabled = False

        End If
    End Sub

    Private Sub boomtimer_Tick(sender As Object, e As EventArgs) Handles boomtimer.Tick
        bang = bang + 1
        boom.Left = kalbo.Left
        If bang >= 5 Then
            boom.Left = 900
        End If
        boomtimer.Enabled = True
    End Sub

    Private Sub speartimer_Tick(sender As Object, e As EventArgs) Handles speartimer.Tick
        If ImageCollision(spear, kalbo) = True Then
            spear.Left = 900
            speartimer.Enabled = False
            TextBox1.Width = TextBox1.Width - 30
            If TextBox1.Width <= 600 Then
                TextBox1.BackColor = Color.Red
            Else
                TextBox1.BackColor = Color.Green

            End If
            If TextBox1.Width <= 0 Then
                Form3.Show()
                Me.Close()
            End If

        End If
        spear.Left = spear.Left + 50
        If spear.Left >= 900 Then
            speartimer.Enabled = False
        End If
    End Sub

    Private Sub kalbotimer_Tick(sender As Object, e As EventArgs) Handles kalbotimer.Tick
        kalbo.Left = kalbo.Left - 5
        kalaban += 1
        kalbo.Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\kalbo" & kalaban & ".png")
        If (kalaban >= 4) Then kalaban = 0
        If kalbo.Left <= -80 Then
            kalbo.Left = 900
        End If
        If ImageCollision(kalbo, Boy) = True Then
            kalbo.Left = 900
            kalbotimer.Enabled = False
            TextBox2.Width = TextBox2.Width - 200
            If TextBox2.Width <= 100 Then
                TextBox2.BackColor = Color.Red
            Else
                TextBox2.BackColor = Color.Green

            End If
            If TextBox2.Width <= 0 Then
                Form9.Show()
                Me.Close()
            End If
            kalbo.Left = kalbo.Left + 25
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With hbg
            .Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\hbg.jpg")
            .SizeMode = PictureBoxSizeMode.Zoom
            x = 0
            bang = 0
        End With
        With Boy
            .Parent = hbg
            .Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\Boy" & x & ".png")
            .SizeMode = PictureBoxSizeMode.Zoom
            .BackColor = Color.Transparent
        End With
        With kalbo
            .Parent = hbg
            .Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\kalbo0.png")
            .SizeMode = PictureBoxSizeMode.Zoom
            .BackColor = Color.Transparent
        End With
        With spear
            .Parent = hbg
            .Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\spear.png")
            .SizeMode = PictureBoxSizeMode.Zoom
            .BackColor = Color.Transparent
        End With
        With fire
            .Parent = hbg
            .Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\fire.png")
            .SizeMode = PictureBoxSizeMode.Zoom
            .BackColor = Color.Transparent
            With flyg
                .Parent = hbg
                .Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\flyg0.png")
                .SizeMode = PictureBoxSizeMode.Zoom
                .BackColor = Color.Transparent
            End With
            With boom
                .Parent = hbg
                .Image = Image.FromFile("C:\Users\A6 7400\Downloads\Start-20221209T132414Z-001\Start\boom.png")
                .SizeMode = PictureBoxSizeMode.Zoom
                .BackColor = Color.Transparent
            End With

        End With
    End Sub
End Class
