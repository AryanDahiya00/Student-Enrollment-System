Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Public Class addfaculty

    Public Function validateEmail(emailAddress) As Boolean
        ' Dim email As New Regex("^(?<user>[^@]+)@(?<host>.+)$")
        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()

    End Sub


  

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strr As String = "server=localhost;port=3308;user id=root;password=;database=db"
        Dim conn As New MySqlConnection(strr)
        Dim comm As String = "Select * from faculty where employeenum = '" & empnum.Text & "' "
        Dim adpt As New MySqlDataAdapter(comm, conn)
        Dim ds As New DataSet()
        Try
            adpt.Fill(ds, "ac")
            Label8.Text = ds.Tables(0).Rows(0).Item(0)
            If empnum.Text = String.Empty Then
                MsgBox("Please enter Employee no.")
            End If
        Catch ex As Exception

        End Try

        Dim str As String = "server=localhost;port=3308;user id=root;password=;database=db"
        Dim con As New MySqlConnection(str)
        Dim com As String = "insert into faculty(employeenum,name,email) values('" & empnum.Text & "','" & lname.Text & "' '" & ", " & "' '" & fname.Text & "' '" & " " & "' '" & mname.Text & "','" & email.Text & "' )"
        con.Open()

        If empnum.Text = Label8.Text Then
            MsgBox("Employee no. already exists!")
            empnum.Clear()

        ElseIf email.Text = String.Empty Then
            MsgBox("Email is required!")
        ElseIf lname.Text = String.Empty Then
            MsgBox("Please enter Last Name!")
        ElseIf fname.Text = String.Empty Then
            MsgBox("Please enter First Name!")
        ElseIf mname.Text = String.Empty Then
            MsgBox("Please enter Middle Name!")
        ElseIf empnum.Text = String.Empty Then
            MsgBox("Employee Number is required!")
       

        ElseIf validateEmail(email.Text) = True Then
            Dim cmd As New MySqlCommand(com, con)


            Dim x As String = cmd.ExecuteNonQuery
            If x >= 1 Then
                MsgBox("Record updated successfully!")
                Me.Close()
            End If
        End If
        con.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub addfaculty_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class