Public Class Form1
    Dim down = False
    Dim down2 = False

    Dim dibujo As Graphics
    Dim al As New Random


    Dim INICIO_COLOR = Brushes.Black


   

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim abrir_archivo As New OpenFileDialog()
        abrir_archivo.Filter = "cursor file |* PNG"
        If abrir_archivo.ShowDialog() = DialogResult.OK Then
            PictureBox1.Load(abrir_archivo.FileName)
        End If

        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Public Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        down2 = False
        down = True

    End Sub
    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        down2 = True
        down = False

    End Sub

    Public Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove

        If down = True Then

            PictureBox1.CreateGraphics.FillEllipse(INICIO_COLOR, e.X, e.Y, 10, 10)

        End If


    End Sub
    Private Sub PictureBox1_MouseWheel(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseWheel
        If down2 = True Then

            PictureBox1.CreateGraphics.FillEllipse(INICIO_COLOR, e.X, e.Y, 50, 50)

        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        INICIO_COLOR = Brushes.White
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        INICIO_COLOR = Brushes.Blue

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        INICIO_COLOR = Brushes.Black
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        INICIO_COLOR = Brushes.Red

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        INICIO_COLOR = Brushes.Yellow

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        INICIO_COLOR = Brushes.Green
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        INICIO_COLOR = Brushes.Pink
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        INICIO_COLOR = Brushes.Tomato
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        INICIO_COLOR = Brushes.Purple
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        INICIO_COLOR = Brushes.DarkRed
    End Sub




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dibujo = PictureBox1.CreateGraphics()
    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button14_Click_1(sender As Object, e As EventArgs) Handles Button14.Click
        PictureBox1.BackColor = Color.Red
    End Sub

    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles Button13.Click
        PictureBox1.BackColor = Color.Yellow
    End Sub

    Private Sub Button12_Click_2(sender As Object, e As EventArgs) Handles Button12.Click
        PictureBox1.BackColor = Color.Blue
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim alea As Integer = al.Next(30, 430)
        Dim rec As Pen
        rec = New Pen(Drawing.Color.Black, 5)
        dibujo.DrawRectangle(rec, New Rectangle(New Point(alea), New Size(256, 250)))
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim cir As Pen
        cir = New Pen(Drawing.Color.Black, 5)
        dibujo.DrawEllipse(cir, 40, 20, 300, 300)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click

    End Sub
End Class
