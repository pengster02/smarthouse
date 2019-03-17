Public Class Form1
    Dim aaa As New Form()
    Dim bbb As New PictureBox()
    Dim getTime As String
    Dim getTime2 As String
    Dim getTime3 As String
    Dim timeUp As String
    Dim timeDown As String
    Dim waterTime As String
    Dim alreadyWatered As Boolean
    Dim water As Boolean
    Dim waterCan As Boolean
    Dim blindsUp As Boolean
    Dim blindsDown As Boolean
    Dim alreadyUp As Boolean
    Dim Monday As Boolean
    Dim Tuesday As Boolean
    Dim Wednesday As Boolean
    Dim Thursday As Boolean
    Dim Friday As Boolean
    Dim Saturday As Boolean
    Dim Sunday As Boolean
    Dim waterState As Integer
    Dim blindsPosition As Integer
    Dim blindsPosition1 As Integer
    Dim sarah As String
    Dim day As String = DateTime.Now.DayOfWeek.ToString()

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Height - Me.Width) / 2
        CreateMyForm()
        Out(Val(888), 0)
        Label2.Hide()
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        TextBox2.Hide()
        TextBox3.Hide()
        ComboBox1.Hide()
        ComboBox2.Hide()
        Button1.Hide()
        GroupBox1.Hide()
        Label14.Hide()
        Label15.Hide()
        TextBox1.Hide()
        ComboBox3.Hide()
        Button9.Hide()
        PictureBox5.Show()
    End Sub

    Private Sub CreateMyForm()
        bbb.Size = New Size(350, 450)
        Dim pic1 As String = "E:\VB.Net\Final Performance Task\Sarah's Pictures\Plant Care3.png"
        bbb.Image = Image.FromFile(pic1)

        aaa.FormBorderStyle = FormBorderStyle.None
        aaa.MaximizeBox = False
        aaa.MinimizeBox = False
        aaa.Size = New Size(350, 450)

        aaa.StartPosition = FormStartPosition.CenterScreen

        aaa.Controls.Add(bbb)

        aaa.Show()
        delay(3.0)
        aaa.Dispose()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        getTime = ComboBox1.SelectedItem.ToString()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        getTime2 = ComboBox2.SelectedItem.ToString()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        timeUp = TextBox3.Text + " " + getTime
        timeDown = TextBox2.Text + " " + getTime
        Label1.Hide()
        Label2.Hide()
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        TextBox2.Hide()
        TextBox3.Hide()
        ComboBox1.Hide()
        ComboBox2.Hide()
        Button1.Hide()
        PictureBox1.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label6.Text = Format(Now, "Short Time")
        If Label6.Text >= #7:00:00 AM# AndAlso Label6.Text <= #7:00:00 PM# Then
            PictureBox4.Show()
            PictureBox6.Hide()
        Else
            PictureBox4.Hide()
            PictureBox6.Show()
        End If

        If day = "Monday" And Monday = True Then
            water = True
        ElseIf day = "Tuesday" And Tuesday = True Then
            water = True
        ElseIf day = "Wednesday" And Wednesday = True Then
            water = True
        ElseIf day = "Thursday" And Thursday = True Then
            water = True
        ElseIf day = "Friday" And Friday = True Then
            water = True
        ElseIf day = "Saturday" And Saturday = True Then
            water = True
        ElseIf day = "Sunday" And Sunday = True Then
            water = True
        Else
            water = False
        End If

        If waterTime = Label6.Text And water = True And alreadyWatered = False Then
            Out(Val(888), 8)
            Timer4.Enabled = True
        ElseIf waterCan = True And alreadyWatered = False Then
            Out(Val(888), 8)
            Timer4.Enabled = True
        Else
            Out(Val(888), 0)
            Timer4.Enabled = False
        End If


        If timeUp = Label6.Text And alreadyUp = False Then
            Out(Val(888), 4)
            Timer2.Enabled = True
        ElseIf blindsUp = True And alreadyUp = False Then
            Out(Val(888), 4)
            Timer2.Enabled = True
        Else
            Out(Val(888), 0)
            Timer2.Enabled = False
        End If

        If timeDown = Label6.Text And alreadyUp = True Then
            Out(Val(888), 7)
            Timer3.Enabled = True
        ElseIf blindsDown = True And alreadyUp = True Then
            Out(Val(888), 7)
            Timer3.Enabled = True
        Else
            Out(Val(888), 0)
            Timer3.Enabled = False
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer2.Tick
        blindsPosition = blindsPosition + 1
        If blindsPosition > 18 Then
            Timer2.Enabled = False
        End If
        If blindsPosition > 18 And alreadyUp = False Then
            blindsPosition = 1
        End If
        Select Case blindsPosition
            Case 1
                Out(Val(888), 4)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl1.png")
            Case 2
                Out(Val(888), 4)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl2.png")
            Case 3
                Out(Val(888), 4)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl3.png")
            Case 4
                Out(Val(888), 4)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl4.png")
            Case 5
                Out(Val(888), 4)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl5.png")
            Case 6
                Out(Val(888), 4)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl6.png")
            Case 7
                Out(Val(888), 4)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl7.png")
            Case 8
                Out(Val(888), 4)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl8.png")
            Case 9
                Out(Val(888), 4)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl9.png")
            Case 10
                Out(Val(888), 4)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl10.png")
            Case 11
                Out(Val(888), 4)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl11.png")
            Case 12
                Out(Val(888), 4)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl12.png")
            Case 13
                Out(Val(888), 4)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl13.png")
            Case 14
                Out(Val(888), 4)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl14.png")
            Case 15
                Out(Val(888), 4)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl15.png")
            Case 16
                Out(Val(888), 4)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl16.png")
            Case 17
                Out(Val(888), 4)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl17.png")
            Case 18
                Out(Val(888), 0)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl18.png")
                alreadyUp = True
        End Select

    End Sub


    Private Sub Timer3_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer3.Tick
        blindsPosition1 = blindsPosition1 + 1
        If blindsPosition1 > 18 Then
            Timer3.Enabled = False
        End If
        If blindsPosition1 > 18 And alreadyUp = True Then
            blindsPosition1 = 1
        End If
        Select Case blindsPosition1
            Case 1
                Out(Val(888), 7)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl18.png")
            Case 2
                Out(Val(888), 7)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl17.png")
            Case 3
                Out(Val(888), 7)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl16.png")
            Case 4
                Out(Val(888), 7)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl15.png")
            Case 5
                Out(Val(888), 7)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl14.png")
            Case 6
                Out(Val(888), 7)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl13.png")
            Case 7
                Out(Val(888), 7)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl12.png")
            Case 8
                Out(Val(888), 7)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl11.png")
            Case 9
                Out(Val(888), 7)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl10.png")
            Case 10
                Out(Val(888), 7)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl9.png")
            Case 11
                Out(Val(888), 7)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl8.png")
            Case 12
                Out(Val(888), 7)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl7.png")
            Case 13
                Out(Val(888), 7)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl6.png")
            Case 14
                Out(Val(888), 7)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl5.png")
            Case 15
                Out(Val(888), 7)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl4.png")
            Case 16
                Out(Val(888), 7)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl3.png")
            Case 17
                Out(Val(888), 7)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl2.png")
            Case 18
                Out(Val(888), 0)
                PictureBox1.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\Bl1.png")
                alreadyUp = False
        End Select
    End Sub

    Sub delay(ByVal dblSecs As Double)
        Const oneSec As Double = 1.0# / (1440.0# * 60.0)
        Dim dblWaitTil As Date
        Now.AddSeconds(oneSec)
        dblWaitTil = Now.AddSeconds(oneSec).AddSeconds(dblSecs)
        Do Until Now > dblWaitTil
            Application.DoEvents()
        Loop
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If blindsUp = False Then
            blindsUp = True
            delay(10.0)
            blindsUp = False
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If blindsDown = False Then
            blindsDown = True
            delay(10.0)
            blindsDown = False
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        GroupBox1.Hide()
        Label14.Hide()
        Label15.Hide()
        TextBox1.Hide()
        ComboBox3.Hide()
        Button9.Hide()
        PictureBox5.Show()
        waterTime = TextBox1.Text + " " + getTime3
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As Object, ByVal e As EventArgs)
        GroupBox1.Show()
        Label14.Show()
        Label15.Show()
        TextBox1.Show()
        ComboBox3.Show()
        Button9.Show()
        PictureBox5.Hide()
    End Sub

    Private Sub Timer4_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer4.Tick
        waterState = waterState + 1
        If waterState > 20 Then
            Timer4.Enabled = False
        End If
        If waterState > 20 And alreadyWatered = False Then
            waterState = 1
        End If
        Select Case waterState
            Case 1
                Out(Val(888), 8)
                PictureBox5.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\plant2.jpg")
                PictureBox7.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\watering can.jpg")
            Case 2
                Out(Val(888), 8)
                PictureBox5.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\plant4.jpg")
                PictureBox7.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\watering can0.jpg")
            Case 3
                Out(Val(888), 8)
                PictureBox5.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\plant4.jpg")
                PictureBox7.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\watering can1.jpg")
            Case 4
                Out(Val(888), 8)
                PictureBox5.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\plant4.jpg")
                PictureBox7.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\watering can2.jpg")
            Case 5
                Out(Val(888), 8)
                PictureBox5.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\plant4.jpg")
                PictureBox7.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\watering can3.jpg")
            Case 6 To 16
                Out(Val(888), 8)
                PictureBox5.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\plant4.jpg")
                PictureBox7.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\watering can4.jpg")
            Case 17
                Out(Val(888), 8)
                PictureBox5.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\plant4.jpg")
                PictureBox7.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\watering can3.jpg")
            Case 18
                Out(Val(888), 8)
                PictureBox5.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\plant4.jpg")
                PictureBox7.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\watering can2.jpg")
            Case 19
                Out(Val(888), 8)
                PictureBox5.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\plant4.jpg")
                PictureBox7.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\watering can0.jpg")
            Case 20
                Out(Val(888), 0)
                PictureBox5.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\plant2.jpg")
                PictureBox7.Image = Image.FromFile("E:\VB.Net\Final Performance Task\Sarah's Pictures\watering can.jpg")
                alreadyWatered = True
                delay(45.0)
                alreadyWatered = False
        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        If Monday = False Then
            Button2.BackColor = Color.Black
            Monday = True
        Else
            Button2.BackColor = Color.White
            Monday = False
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button3.Click
        If Tuesday = False Then
            Button3.BackColor = Color.Black
            Tuesday = True
        Else
            Button3.BackColor = Color.White
            Tuesday = False
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button4.Click
        If Wednesday = False Then
            Button4.BackColor = Color.Black
            Wednesday = True
        Else
            Button4.BackColor = Color.White
            Wednesday = False
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button5.Click
        If Thursday = False Then
            Button5.BackColor = Color.Black
            Thursday = True
        Else
            Button5.BackColor = Color.White
            Thursday = False
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button6.Click
        If Friday = False Then
            Button6.BackColor = Color.Black
            Friday = True
        Else
            Button6.BackColor = Color.White
            Friday = False
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button7.Click
        If Saturday = False Then
            Button7.BackColor = Color.Black
            Saturday = True
        Else
            Button7.BackColor = Color.White
            Saturday = False
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button8.Click
        If Sunday = False Then
            Button8.BackColor = Color.Black
            Sunday = True
        Else
            Button8.BackColor = Color.White
            Sunday = False
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Label1.Show()
        Label2.Show()
        Label3.Show()
        Label4.Show()
        Label5.Show()
        TextBox2.Show()
        TextBox3.Show()
        ComboBox1.Show()
        ComboBox2.Show()
        Button1.Show()
        PictureBox1.Hide()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        getTime3 = ComboBox3.SelectedItem.ToString()
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        waterCan = True
        Timer4.Enabled = True
        Out(Val(888), 8)
        delay(10.0)
        Out(Val(888), 0)
        Timer4.Enabled = False
        waterCan = False
    End Sub

End Class
