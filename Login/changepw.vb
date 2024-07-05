Imports MySql.Data.MySqlClient
Public Class changepw

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.lblid.Text = ""
        old.Clear()
        newpw.Clear()
        confirm.Clear()
        Me.Close()
    End Sub

    Private Sub changepw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = "server=localhost;port=3308;user id=root;password=;database=db"
        Dim con As New MySqlConnection(str)
        Dim com As String = "select * from admin where id = '" & Form1.lblid.Text & "' "
        Dim adpt As New MySqlDataAdapter(com, con)
        Dim ds As New DataSet()

        adpt.Fill(ds, "account")
        lblpassword.Text = ds.Tables(0).Rows(0).Item(2)
        lblusername.Text = ds.Tables(0).Rows(0).Item(1)
        
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click






        Dim str As String = "server=localhost;port=3308;user id=root;password=;database=db"
        Dim con As New MySqlConnection(str)
        Dim com As String = "insert into admin(username,password) values('" & lblusername.Text & "','" & confirm.Text & "')"
        con.Open()

        Dim cmd As New MySqlCommand(com, con)
        Dim x As Integer = cmd.ExecuteNonQuery
        Try

            If old.Text <> lblpassword.Text Then
                MsgBox("Old Password doesn't match with your current Password!")
            ElseIf newpw.Text <> confirm.Text Then
                MsgBox("New Password and Confirmation Password must be the same!")
            ElseIf old.Text = String.Empty Then
                MsgBox("You must fill in your old password!")

            ElseIf newpw.Text = String.Empty Then
                MsgBox("You must fill in your new password!")

            ElseIf confirm.Text = String.Empty Then
                MsgBox("You must fill in your confirmation password!")


            ElseIf x = 1 Then
                MsgBox("Password changed successfully! Changes will be saved after closing the application")
                Me.Close()
            End If


        Catch ex As Exception

            MsgBox("An error occured")
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class