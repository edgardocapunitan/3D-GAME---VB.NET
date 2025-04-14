Module Module1
    Public Function ImageCollision(Image1 As PictureBox, Image2 As PictureBox) As Boolean
        If Image1.Left + Image1.Width < Image2.Left Or _
            Image1.Left > Image2.Left + Image2.Width Or _
            Image1.Top + Image1.Height < Image2.Top Or _
            Image1.Top > Image2.Top + Image2.Height Then
            ImageCollision = False
        Else
            ImageCollision = True
        End If

    End Function
End Module
