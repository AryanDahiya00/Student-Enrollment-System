Public Class Main

    Private Sub HOMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HOMEToolStripMenuItem.Click

    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        changepw.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
        Form1.TextBox2.Text = ""

    End Sub

    Private Sub STudeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STudeToolStripMenuItem.Click
        addstudent.Show()
    End Sub

    Private Sub FacultyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacultyToolStripMenuItem.Click
        addfaculty.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Show()
        Form1.TextBox2.Text = ""
        Form1.lblid.Text = ""
        changepw.old.Text = ""
        changepw.newpw.Text = ""
        changepw.confirm.Text = ""
        Form1.rows.Text = ""

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class