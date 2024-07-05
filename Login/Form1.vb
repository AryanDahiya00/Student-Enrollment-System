Imports MySql.Data.MySqlClient
Public Class Form1


    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
    Dim attempt As Integer = 1
    Dim ts, sysdate, actualanderror, addminute As TimeSpan
    Dim sys, addsys, datewhenerror As Date




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If ComboBox1.SelectedItem = "ADMIN" Then


            Dim str As String = "server=localhost;port=3308;user id=root;password=;database=db"
            Dim con As New MySqlConnection(str)
            Dim com As String = "Select * from admin where username = '" & TextBox1.Text & "' and password = '" & TextBox2.Text & "' "


            Dim adpt As New MySqlDataAdapter(com, con)
            Dim ds As New DataSet()
            If Val(rows.Text) = 1 Then
                adpt.Fill(ds, "account")
                Try
                    Dim id As Integer = ds.Tables(0).Rows(0).Item(0)
                    lblid.Text = id
                Catch ex As Exception
                    Dim attempt As Integer = 0
                    For attempt = 0 To 3 Step 1
                        attempt = attempt + 1
                    Next
                    If attempt = 3 Then
                        MsgBox("The System has been locked!")
                    End If
                End Try

                Dim a As Integer = ds.Tables(0).Rows.Count
                If a > 0 Then


                    MsgBox("Log In Successful")
                    Main.Show()
                    Me.Hide()
                Else

                    MsgBox("Incorrect Password! Number of attempts: " & attempt & "/  3 ")
                    TextBox2.Text = ""
                    attempt = attempt + 1
                    If attempt = 4 Then
                        MsgBox("The System has been locked!")
                        TextBox1.Enabled = False
                        TextBox2.Enabled = False
                        Button1.Enabled = False

                        Dim date1 As Date = Now()
                        datewhenerror = date1
                        Dim date2 As Date = date1.AddMinutes(60)
                        ts = date2.Subtract(date1)
                        lblerrordate.Text = datewhenerror
                        addsys = date2
                        Label6.Text = ts.TotalMinutes.ToString

                        Label5.Text = sysdate.TotalMinutes.ToString

                        sysdate = addsys.Subtract(datewhenerror)
                        actualanderror = sys - datewhenerror
                        Button3.Visible = True
                        Button3.Enabled = True
                    End If

                End If



            ElseIf Val(rows.Text) > 1 Then

                Dim com1 As String = "Select * from admin where username = '" & TextBox1.Text & "' and password = '" & TextBox2.Text & "' and id = '" & lblrowcount.Text & "' "
                Dim adpt1 As New MySqlDataAdapter(com1, con)
                Dim ds1 As New DataSet()
                adpt1.Fill(ds1, "accounts")
                Try
                    Dim id As Integer = ds1.Tables(0).Rows(0).Item(0)
                    lblid.Text = id
                Catch ex As Exception
                    Dim attempt As Integer = 0
                    For attempt = 0 To 3 Step 1
                        attempt = attempt + 1
                    Next
                    If attempt = 3 Then
                        MsgBox("The System has been locked!")
                    End If
                End Try

                Dim x As Integer = ds1.Tables(0).Rows.Count
                If x >= 1 Then

                    MsgBox("Login Successful!")
                    Main.Show()
                    Me.Hide()
                ElseIf TextBox2.Text = String.Empty Then
                    MsgBox("Please Enter your password")
                Else

                    MsgBox("Incorrect Password! Number of attempts: " & attempt & "/  3 ")
                    TextBox2.Text = ""
                    attempt = attempt + 1
                    If attempt = 4 Then
                        MsgBox("The System has been locked!")
                        TextBox1.Enabled = False
                        TextBox2.Enabled = False

                        Button1.Enabled = False

                        Dim date1 As Date = Now()
                        datewhenerror = date1
                        Dim date2 As Date = date1.AddMinutes(60)
                        ts = date2.Subtract(date1)
                        lblerrordate.Text = datewhenerror
                        addsys = date2
                        Label6.Text = ts.TotalMinutes.ToString

                        Label5.Text = sysdate.TotalMinutes.ToString

                        sysdate = addsys.Subtract(datewhenerror)
                        actualanderror = sys - datewhenerror
                        Button3.Visible = True
                        Button3.Enabled = True
                    End If






                End If
            End If



        ElseIf ComboBox1.SelectedItem = "STUDENT" Then
            Dim str2 As String = "server=localhost;port=3308;user id=root;password=;database=db"
            Dim con2 As New MySqlConnection(str2)
            Dim com2 As String = "Select * from student where email = '" & TextBox1.Text & "' and studentno = '" & TextBox2.Text & "' "

            Dim adpt2 As New MySqlDataAdapter(com2, con2)
            Dim ds2 As New DataSet()
            adpt2.Fill(ds2, "acc")
            Dim h As Integer = ds2.Tables(0).Rows.Count
            If TextBox1.Text = String.Empty Then
                MsgBox("Please enter your email")

            ElseIf TextBox2.Text = String.Empty Then
                MsgBox("Please enter your password")
            End If

            If h >= 1 Then
                Label8.Text = ds2.Tables(0).Rows(0).Item(3)
                Label11.Text = ds2.Tables(0).Rows(0).Item(0)
                Label9.Text = ds2.Tables(0).Rows(0).Item(4)
                Label10.Text = ds2.Tables(0).Rows(0).Item(1)
                MsgBox("Login Successful!")
                If Label8.Text = "BCA" Then
                    subjectis.Show()
                    Me.Hide()

                ElseIf Label8.Text = "BTECH" Then

                    subject.Show()
                    Me.Hide()
                End If
            Else
                MsgBox("Incorrect username/password!")

            End If

        ElseIf ComboBox1.SelectedItem = "FACULTY" Then
            Dim str2 As String = "server=localhost;port=3308;user id=root;password=;database=db"
            Dim con2 As New MySqlConnection(str2)
            Dim com2 As String = "Select * from faculty where email = '" & TextBox1.Text & "' and employeenum = '" & TextBox2.Text & "' "

            Dim adpt2 As New MySqlDataAdapter(com2, con2)
            Dim ds2 As New DataSet()
            adpt2.Fill(ds2, "acc")
            Dim h As Integer = ds2.Tables(0).Rows.Count
            If TextBox1.Text = String.Empty Then
                MsgBox("Please enter your email")

            ElseIf TextBox2.Text = String.Empty Then
                MsgBox("Please enter your password")
            End If

            If h >= 1 Then
                MsgBox("Login Successful!")

                facultypanel.Show()
                Me.Hide()

            Else
                MsgBox("Incorrect username/password!")
                Label2.Text = ""
            End If
            con2.Close()






        End If












    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Application.Exit()




    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("FACULTY")
        ComboBox1.Items.Add("STUDENT")
        ComboBox1.Items.Add("ADMIN")




        Timer1.Start()
        Dim str As String = "server=localhost;port=3308;user id=root;password=;database=db"
        Dim con As New MySqlConnection(str)
        Dim com As String = "Select * from admin "
        Dim adpt As New MySqlDataAdapter(com, con)

        Dim ds As New DataSet()

        adpt.Fill(ds, "acc")
        Dim y As Integer = ds.Tables(0).Rows.Count
        lblrowcount.Text = ds.Tables(0).Rows(y - 1).Item(0)
        rows.Text = y



       



        


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim udate As Date = Now()
        sys = udate
        lbldate.Text = udate.ToString("MM/dd/yy h:mm:ss tt")
        Label5.Text = actualanderror.TotalMinutes.ToString

        If ComboBox1.SelectedItem = "ADMIN" Then
            TextBox1.Text = "Admin"
        
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (Date.Compare(sys, addsys) > 0) Then
            Label7.Text = "Yes"
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            Button1.Enabled = True
            Button3.Visible = False
            attempt = 1
            TextBox2.Text = ""
        Else
            Label7.Text = "No"
        End If

    End Sub
End Class
