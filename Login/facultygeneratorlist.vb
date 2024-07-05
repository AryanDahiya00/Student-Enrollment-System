Imports MySql.Data.MySqlClient
Public Class facultygeneratorlist

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub facultygeneratorlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = "server=localhost;port=3308;user id=root;password=;database=db"
        Dim con As New MySqlConnection(str)
        Dim com As String = "Select studnum as 'Student No.', studname as 'Student Name', subjectcode as 'Subject Code', course as 'Course', year as 'Year Level'  from subject where subjectcode = '" & facultypanel.Label5.Text & "' and year = '" & facultypanel.ComboBox2.SelectedItem & "' "
        Dim adpt As New MySqlDataAdapter(com, con)

        Dim ds As New DataSet()

        adpt.Fill(ds, "acc")
        DataGridView1.DataSource = ds.Tables(0)
        Dim y As Integer = ds.Tables(0).Rows.Count

        TextBox1.Text = y

        lblcourse.Text = facultypanel.ComboBox1.SelectedItem
        lblyear.Text = facultypanel.ComboBox2.SelectedItem
        lblsubject.Text = facultypanel.Label5.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        facultypanel.Label5.Text = ""

        facultypanel.Show()
        Me.Close()
    End Sub
End Class