Imports MySql.Data.MySqlClient
Public Class subjectis

    Dim counter As Integer = 0
    Private Sub subjectis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.Label9.Text = "1st Year" Then
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
            CheckBox32.Enabled = False
            CheckBox33.Enabled = False
            CheckBox34.Enabled = False
            CheckBox35.Enabled = False
            CheckBox36.Enabled = False
            CheckBox37.Enabled = False
            CheckBox38.Enabled = False
            CheckBox39.Enabled = False
            CheckBox40.Enabled = False
            CheckBox42.Enabled = False
            CheckBox43.Enabled = False
            CheckBox44.Enabled = False
            CheckBox45.Enabled = False
            CheckBox46.Enabled = False
            CheckBox47.Enabled = False
            CheckBox48 .Enabled = False
            CheckBox52.Enabled = False
            CheckBox51.Enabled = False

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
        ElseIf Form1.Label9.Text = "2nd Year" Then
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False
            CheckBox9.Enabled = False
            CheckBox10.Enabled = False
            CheckBox11.Enabled = False
            CheckBox12.Enabled = False
            CheckBox13.Enabled = False
            CheckBox14.Enabled = False
            CheckBox15.Enabled = False
            CheckBox16.Enabled = False
            CheckBox17.Enabled = False
            CheckBox18.Enabled = False
            CheckBox19.Enabled = False
            CheckBox20.Enabled = False
            CheckBox21.Enabled = True
            CheckBox22.Enabled = True
            CheckBox23.Enabled = True
            CheckBox24.Enabled = True
            CheckBox25.Enabled = True
            CheckBox26.Enabled = True
            CheckBox27.Enabled = True
            CheckBox28.Enabled = True
            CheckBox29.Enabled = True
            CheckBox30.Enabled = True
            CheckBox32.Enabled = True
            CheckBox33.Enabled = True
            CheckBox34.Enabled = True
            CheckBox35.Enabled = True
            CheckBox36.Enabled = True
            CheckBox37.Enabled = True
            CheckBox38.Enabled = True
            CheckBox39.Enabled = True
            CheckBox40.Enabled = True
            CheckBox42.Enabled = False
            CheckBox43.Enabled = False
            CheckBox44.Enabled = False
            CheckBox45.Enabled = False
            CheckBox46.Enabled = False
            CheckBox47.Enabled = False
            CheckBox48.Enabled = False
            CheckBox52.Enabled = False
            CheckBox51.Enabled = False

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

        ElseIf Form1.Label9.Text = "3rd Year" Then
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False
            CheckBox9.Enabled = False
            CheckBox10.Enabled = False
            CheckBox11.Enabled = False
            CheckBox12.Enabled = False
            CheckBox13.Enabled = False
            CheckBox14.Enabled = False
            CheckBox15.Enabled = False
            CheckBox16.Enabled = False
            CheckBox17.Enabled = False
            CheckBox18.Enabled = False
            CheckBox19.Enabled = False
            CheckBox20.Enabled = False
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
            CheckBox32.Enabled = False
            CheckBox33.Enabled = False
            CheckBox34.Enabled = False
            CheckBox35.Enabled = False
            CheckBox36.Enabled = False
            CheckBox37.Enabled = False
            CheckBox38.Enabled = False
            CheckBox39.Enabled = False
            CheckBox40.Enabled = False
            CheckBox42.Enabled = True
            CheckBox43.Enabled = True
            CheckBox44.Enabled = True
            CheckBox45.Enabled = True
            CheckBox46.Enabled = True
            CheckBox47.Enabled = True
            CheckBox48.Enabled = True
            CheckBox52.Enabled = True
            CheckBox51.Enabled = True

            CheckBox53.Enabled = True
            CheckBox54.Enabled = True
            CheckBox55.Enabled = True
            CheckBox56.Enabled = True
            CheckBox57.Enabled = False
            CheckBox59.Enabled = False

            CheckBox60.Enabled = False
            CheckBox61.Enabled = False
            CheckBox62.Enabled = False
            CheckBox63.Enabled = False

        ElseIf Form1.Label9.Text = "4th Year" Then
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False
            CheckBox9.Enabled = False
            CheckBox10.Enabled = False
            CheckBox11.Enabled = False
            CheckBox12.Enabled = False
            CheckBox13.Enabled = False
            CheckBox14.Enabled = False
            CheckBox15.Enabled = False
            CheckBox16.Enabled = False
            CheckBox17.Enabled = False
            CheckBox18.Enabled = False
            CheckBox19.Enabled = False
            CheckBox20.Enabled = False
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
            CheckBox32.Enabled = False
            CheckBox33.Enabled = False
            CheckBox34.Enabled = False
            CheckBox35.Enabled = False
            CheckBox36.Enabled = False
            CheckBox37.Enabled = False
            CheckBox38.Enabled = False
            CheckBox39.Enabled = False
            CheckBox40.Enabled = False
            CheckBox42.Enabled = False
            CheckBox43.Enabled = False
            CheckBox44.Enabled = False
            CheckBox45.Enabled = False
            CheckBox46.Enabled = False
            CheckBox47.Enabled = False
            CheckBox48.Enabled = False
            CheckBox52.Enabled = False
            CheckBox51.Enabled = False

            CheckBox53.Enabled = False
            CheckBox54.Enabled = False
            CheckBox55.Enabled = False
            CheckBox56.Enabled = False
            CheckBox57.Enabled = True
            CheckBox59.Enabled = True

            CheckBox60.Enabled = True
            CheckBox61.Enabled = True
            CheckBox62.Enabled = True
            CheckBox63.Enabled = True
        End If

        TextBox1.Text = Form1.Label10.Text
        TextBox2.Text = Form1.Label9.Text
        TextBox3.Text = Form1.Label8.Text

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
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

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
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
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.CheckState = 1 Then
            counter = counter + 2
        Else
            counter = counter - 2
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox20_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox20.CheckedChanged
        If CheckBox20.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox19_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox19.CheckedChanged
        If CheckBox19.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox18_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox18.CheckedChanged
        If CheckBox18.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox17_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox17.CheckedChanged
        If CheckBox17.CheckState = 1 Then
            counter = counter + 3
        Else
            counter = counter - 3
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox16.CheckedChanged
        If CheckBox16.CheckState = 1 Then
            counter = counter + 5
        Else
            counter = counter - 5
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub CheckBox15_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox15.CheckedChanged
        If CheckBox1.CheckState = 1 Then
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
        Else
            counter = counter - 2
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

    Private Sub CheckBox22_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox22.CheckedChanged
        If CheckBox22.CheckState = 1 Then
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
            counter = counter + 3
        Else
            counter = counter - 3
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
            counter = counter + 3
        Else
            counter = counter - 3
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

    Private Sub CheckBox21_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox21.CheckedChanged
        If CheckBox21.CheckState = 1 Then
            counter = counter + 2
        Else
            counter = counter - 2
        End If
        Label2.Text = counter
        If counter >= 30 Then
            MsgBox("You have exceeded 30 units!")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = "data source=localhost; user id=root; password=;database=db"
        Dim con As New MySqlConnection(str)



        con.Open()
        If CheckBox1.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "ISM 1" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If

        If CheckBox2.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "ISM 2" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox3.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "PerDev 113" & "') "
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
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "ISM 3" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox19.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "ISM 4" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox18.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "ISM 5" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox17.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "ISM 6" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox16.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Math 115a" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox15.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Chem 114" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox13.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "English 123" & "') "
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
        If CheckBox62.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "CAPS 2" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox61.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Elec 3" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox60.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "FREE 3" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox59.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "FREE 4" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox22.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Val 323" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox63.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "OJT" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox48.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "ISM 15" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox47.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "ISM 16" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox46.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "ISM 17" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox45.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "ISM 18" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox44.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Elective 1" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox43.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "FREE 1" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox42.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Philo" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox30.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "ISM 7" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox29.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "ISM 8" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox28.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "ISM 9" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox27.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "ISM 10" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox26.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "ISM 11" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox25.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Filipino 113c" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox24.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Psych 213" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox23.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "English 213" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox21.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "PE 212" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If





        If CheckBox57.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "ISM 19" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox56.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "ISM 20" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox55.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "ISM 21" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox54.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "CAPS 1" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox53.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Elec 2" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox52.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Elec 3" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox51.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "FREE 2" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        If CheckBox14.CheckState = 1 Then
            Dim com As String = "insert into subject(studnum,studname,course,year,subjectcode) values('" & Form1.Label11.Text & "','" & Form1.Label10.Text & "','" & Form1.Label8.Text & "','" & Form1.Label9.Text & "', '" & "Soc Sci 323" & "') "
            Dim cmd As New MySqlCommand(com, con)
            Dim x As Integer = cmd.ExecuteNonQuery()
        End If
        MsgBox("Record Updated Successfully!")
        con.Close()
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()

        Me.Hide()
    End Sub
End Class