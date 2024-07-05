Imports MySql.Data.MySqlClient
Public Class subject
    Dim counter As Integer = 0
    
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()

        Me.Hide()
    End Sub

    Private Sub subject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pos As Integer = Panel1.VerticalScroll.Value


        If Form1.Label9.Text = "2nd Year" Then
            Panel1.VerticalScroll.Value = 280
        End If

        TextBox1.Text = Form1.Label10.Text
        TextBox2.Text = Form1.Label8.Text
        TextBox3.Text = Form1.Label9.Text

        lblyear.Text = Form1.Label9.Text
        Timer1.Start()

        Dim str As String = "server=localhost;port=3308;user id=root;password=;database=db"
        Dim con As New MySqlConnection(str)
        Dim com As String = "Select coursecode as 'Course Code', coursedescrip as 'Course Description', numunits as 'No. of Units', prereq as 'Prerequisites'  from subject where coursename = '" & Form1.Label8.Text & "'"
        Dim adpt As New MySqlDataAdapter(com, con)

        Dim ds As New DataSet()


        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If

        If lblyear.Text = "1st Year" Then
            CheckBox21.Enabled = False
            CheckBox22.Enabled = False
            CheckBox23.Enabled = False
            CheckBox24.Enabled = False
            CheckBox25.Enabled = False
            CheckBox26.Enabled = False
            CheckBox27.Enabled = False
            CheckBox28.Enabled = False
            CheckBox29.Enabled = False
            CheckBox30.Enabled = False
            CheckBox31.Enabled = False
            CheckBox32.Enabled = False
            CheckBox33.Enabled = False
            CheckBox34.Enabled = False
            CheckBox35.Enabled = False
            CheckBox36.Enabled = False
            CheckBox37.Enabled = False
            CheckBox38.Enabled = False
            CheckBox39.Enabled = False
            CheckBox40.Enabled = False
            CheckBox41.Enabled = False
            CheckBox42.Enabled = False
            CheckBox43.Enabled = False
            CheckBox44.Enabled = False
            CheckBox45.Enabled = False
            CheckBox46.Enabled = False
            CheckBox47.Enabled = False
            CheckBox48.Enabled = False
            CheckBox51.Enabled = False
            CheckBox52.Enabled = False
            CheckBox53.Enabled = False
            CheckBox54.Enabled = False
            CheckBox55.Enabled = False
            CheckBox56.Enabled = False
            CheckBox57.Enabled = False
            CheckBox59.Enabled = False
            CheckBox60.Enabled = False
            CheckBox61.Enabled = False
            CheckBox62.Enabled = False
            CheckBox63.Enabled = False
        ElseIf lblyear.Text = "2nd Year" Then
            CheckBox31.Enabled = False
            CheckBox41.Enabled = False
            CheckBox42.Enabled = False
            CheckBox43.Enabled = False
            CheckBox44.Enabled = False
            CheckBox45.Enabled = False
            CheckBox46.Enabled = False
            CheckBox47.Enabled = False
            CheckBox48.Enabled = False
            CheckBox51.Enabled = False
            CheckBox52.Enabled = False
            CheckBox53.Enabled = False
            CheckBox54.Enabled = False
            CheckBox55.Enabled = False
            CheckBox56.Enabled = False
            CheckBox57.Enabled = False
            CheckBox59.Enabled = False
            CheckBox60.Enabled = False
            CheckBox61.Enabled = False
            CheckBox62.Enabled = False
            CheckBox63.Enabled = False
        ElseIf lblyear.Text = "3rd Year" Then
           
            CheckBox59.Enabled = False
            CheckBox60.Enabled = False
            CheckBox61.Enabled = False
            CheckBox62.Enabled = False
            CheckBox63.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.Hide()
            Form1.Show()
            Form1.TextBox2.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = 1 Then
            counter = counter + 3
            CheckBox18.Enabled = False
        Else
            counter = counter - 3
            CheckBox18.Enabled = True
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.CheckState = 1 Then
            counter = counter + 5
            CheckBox19.Enabled = False
        Else
            counter = counter - 5
            CheckBox19.Enabled = True
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.CheckState = 1 Then
            counter = counter + 3
            CheckBox20.Enabled = False
        Else
            counter = counter - 3
            CheckBox20.Enabled = True
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.CheckState = 1 Then
            counter = counter + 3
            CheckBox17.Enabled = False
        Else
            counter = counter - 3
            CheckBox17.Enabled = True
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
            CheckBox7.CheckState = 0
            counter = counter - 3
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.CheckState = 1 Then
            counter = counter + 2
            CheckBox12.Enabled = False
        Else
            counter = counter - 2
            CheckBox12.Enabled = True
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
            CheckBox7.CheckState = 0
            counter = counter - 2
        End If




    End Sub

    Private Sub Label119_Click(sender As Object, e As EventArgs) Handles Label119.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub CheckBox20_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox20.CheckedChanged
        If CheckBox20.CheckState = 1 Then
            counter = counter + 3
            CheckBox5.Enabled = False
        Else
            counter = counter - 3
            CheckBox5.Enabled = True
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox19_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox19.CheckedChanged
        If CheckBox19.CheckState = 1 Then
            counter = counter + 5
        Else
            counter = counter - 5
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox18_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox18.CheckedChanged
        If CheckBox18.CheckState = 1 Then
            counter = counter + 3
            CheckBox1.Enabled = False
        Else
            counter = counter - 3
            CheckBox1.Enabled = True
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox17_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox17.CheckedChanged
        If CheckBox17.CheckState = 1 Then
            counter = counter + 3
            CheckBox10.Enabled = False
        Else
            counter = counter - 3
            CheckBox10.Enabled = True
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox16.CheckedChanged
        If CheckBox16.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox15_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox15.CheckedChanged
        If CheckBox15.CheckState = 1 Then
            counter = counter + 4
        Else
            counter = counter - 4
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged
        If CheckBox14.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged
        If CheckBox13.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.CheckState = 1 Then
            counter = counter + 2
            CheckBox7.Enabled = False
        Else
            counter = counter - 2
            CheckBox7.Enabled = True
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox30_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox30.CheckedChanged
        If CheckBox30.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox29_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox29.CheckedChanged
        If CheckBox29.CheckState = 1 Then
            counter = counter + 5
        Else
            counter = counter - 5
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox28_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox28.CheckedChanged
        If CheckBox28.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox27_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox27.CheckedChanged
        If CheckBox27.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox26_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox26.CheckedChanged
        If CheckBox26.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox25_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox25.CheckedChanged
        If CheckBox25.CheckState = 1 Then
            counter = counter + 2
        Else
            counter = counter - 2
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox24_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox24.CheckedChanged
        If CheckBox24.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox23_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox23.CheckedChanged
        If CheckBox23.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox22_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox22.CheckedChanged
        If CheckBox22.CheckState = 1 Then
            counter = counter + 2
        Else
            counter = counter - 2
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox40_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox40.CheckedChanged
        If CheckBox40.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox39_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox39.CheckedChanged
        If CheckBox39.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox38_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox38.CheckedChanged
        If CheckBox38.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox37_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox37.CheckedChanged
        If CheckBox37.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox36_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox36.CheckedChanged
        If CheckBox36.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox35_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox35.CheckedChanged
        If CheckBox35.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox34_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox34.CheckedChanged
        If CheckBox34.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox33_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox33.CheckedChanged
        If CheckBox33.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox32_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox32.CheckedChanged
        If CheckBox32.CheckState = 1 Then
            counter = counter + 2
        Else
            counter = counter - 2
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox48_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox48.CheckedChanged
        If CheckBox48.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox47_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox47.CheckedChanged
        If CheckBox47.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox46_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox46.CheckedChanged
        If CheckBox46.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox45_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox45.CheckedChanged
        If CheckBox45.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox44_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox44.CheckedChanged
        If CheckBox44.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox43_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox43.CheckedChanged
        If CheckBox43.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox42_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox42.CheckedChanged
        If CheckBox42.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox41_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox41.CheckedChanged
        If CheckBox41.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox31_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox31.CheckedChanged
        If CheckBox31.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox57_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox57.CheckedChanged
        If CheckBox57.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox56_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox56.CheckedChanged
        If CheckBox56.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox55_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox55.CheckedChanged
        If CheckBox55.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox54_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox54.CheckedChanged
        If CheckBox54.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox53_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox53.CheckedChanged
        If CheckBox53.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox52_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox52.CheckedChanged
        If CheckBox52.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox51_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox51.CheckedChanged
        If CheckBox51.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox62_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox62.CheckedChanged
        If CheckBox62.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox61_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox61.CheckedChanged
        If CheckBox61.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox60_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox60.CheckedChanged
        If CheckBox60.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox59_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox59.CheckedChanged
        If CheckBox59.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox63_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox63.CheckedChanged
        If CheckBox63.CheckState = 1 Then
            counter = counter + 10
        Else
            counter = counter - 10
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = "server=localhost;port=3308;user id=root;password=;database=db"
        Dim con As New MySqlConnection(str)



        con.Open()
        If CheckBox1.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Prog 113" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If

        If CheckBox2.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "CF 113" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox3.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "OP 113" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox4.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Math 115" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox5.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "English 113" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox10.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Filipino 113c" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox9.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Soc 213" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox8.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Hum 113" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox7.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "PE 112" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox6.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "NSTP 1" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox20.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "English 123" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox19.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Math 115a" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox18.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Prog 123" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox17.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Filipino 123a" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox16.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "CHS 123" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox15.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Chem 114" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox14.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Multi 123" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox13.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Soc Sci 323b" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox12.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "PE 122" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox11.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "NSTP 2" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox30.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "English 213" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox29.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Physics 214" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox28.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "DS 123" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox27.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "DBMS 213" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox26.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "OOP 213" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox25.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Psych 213" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox24.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "WEB 213" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox23.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "CHS 213" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox22.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Soc Sci 413" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox21.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "PE 212" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox40.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "DBP 223" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox39.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Multi 223" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox38.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "OS 223" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox37.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "SAD 223" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox36.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "NET 223" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox35.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "English 313" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox34.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Filipino 223" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox33.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Soc Sci 323" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox32.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "PE 222" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox48.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "WEB 313" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox47.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "DBP 313" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox46.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Math 313" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox45.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "DBMS 313" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox44.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Ethics 313" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox43.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "SAD 313" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox42.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "NET 313" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox41.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "QSS 313" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox31.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "IT Elective 1" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox57.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Soft Eng 323" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox56.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Com Org 323" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox55.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Tech 323" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox54.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "PHY 324" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox53.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Res 413" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox52.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Stat 1 323" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox51.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "IT Elective 2" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox62.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Thesis 413" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox61.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "CIS 413" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox60.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "IT Elective 3" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox59.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "IT Elective 4" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox63.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "OJT" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        MsgBox("Record Updated Successfully!")
        con.Close()
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.CheckState = 1 Then
            counter = counter + 0
            CheckBox11.Enabled = False
        Else
            counter = counter - 0
            CheckBox11.Enabled = True
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.CheckState = 1 Then
            counter = counter + 3
            CheckBox6.Enabled = False
        Else
            counter = counter - 3
            CheckBox6.Enabled = True
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub
End Class