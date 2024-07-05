Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class addstudent 
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub



    Private Sub addstudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        course.Items.Add("BTECH")
        course.Items.Add("BBA")
        course.Items.Add("BCA")

        year.Items.Add("1st Year")
        year.Items.Add("2nd Year")
        year.Items.Add("3rd Year")
        year.Items.Add("4th Year")
        year.Items.Add("5th Year")




    End Sub



    Public Function validateEmail(emailAddress) As Boolean
        ' Dim email As New Regex("^(?<user>[^@]+)@(?<host>.+)$")
        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim strr As String = "server=localhost;port=3308;user id=root;password=;database=db"
        Dim conn As New MySqlConnection(strr)
        Dim comm As String = "Select * from student where studentno = '" & txtno.Text & "' "
        Dim adpt As New MySqlDataAdapter(comm, conn)
        Dim ds As New DataSet()
        Try
            adpt.Fill(ds, "ac")
            Label10.Text = ds.Tables(0).Rows(0).Item(0)
            If txtno.Text = String.Empty Then
                MsgBox("Please enter Student no.")
            End If
        Catch ex As Exception

        End Try
        Dim str As String = "server=localhost;port=3308;user id=root;password=;database=db"
        Dim con As New MySqlConnection(str)
        Dim com As String = "insert into student(studentno,name,email,course,year) values('" & txtno.Text & "','" & lname.Text & "' '" & ", " & "' '" & fname.Text & "' '" & " " & "' '" & mname.Text & "','" & email.Text & "' ,'" & course.SelectedItem & "','" & year.SelectedItem & "')"


        con.Open()

        If txtno.Text = Label10.Text Then
            MsgBox("Student no. already exists!")
            txtno.Clear()

        ElseIf email.Text = String.Empty Then
            MsgBox("Email is required!")
        ElseIf lname.Text = String.Empty Then
            MsgBox("Please enter Last Name!")
        ElseIf fname.Text = String.Empty Then
            MsgBox("Please enter First Name!")
        ElseIf mname.Text = String.Empty Then
            MsgBox("Please enter Middle Name!")
        ElseIf txtno.Text = String.Empty Then
            MsgBox("Student Number is required!")
        ElseIf course.Text = String.Empty Then
            MsgBox("Please choose a course!")
        ElseIf year.Text = String.Empty Then
            MsgBox("Please choose a course!")

        ElseIf validateEmail(email.Text) = True Then
            Dim cmd As New MySqlCommand(com, con)


            Dim x As Integer = cmd.ExecuteNonQuery
            If x >= 1 Then
                MsgBox("Record updated successfully!")
                Form1.TextBox1.Text = email.Text
                Form1.ComboBox1.SelectedItem = "STUDENT"

                Me.Close()
            End If
            con.Close()

        Else
            MsgBox("Email is not Valid")

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If course.SelectedItem = "BTECH" Then
            year.Items.Remove("5th Year")
        ElseIf course.SelectedItem = "BCA" Then
            year.Items.Remove("5th Year")
        End If
    End Sub
End Class