Imports MySql.Data.MySqlClient
Public Class facultypanel
    Dim code As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
    End Sub

    Private Sub facultypanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        ComboBox1.Items.Add("BTECH")
        ComboBox1.Items.Add("BCA")
        ComboBox1.Items.Add("BBA")

        ComboBox2.Items.Add("1st Year")
        ComboBox2.Items.Add("2nd Year")
        ComboBox2.Items.Add("3rd Year")
        ComboBox2.Items.Add("4th Year")
        ComboBox2.Items.Add("5th Year")



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ComboBox1.SelectedItem = "BTECH" Then
            ComboBox2.Items.Remove("5th Year")
        ElseIf ComboBox1.SelectedItem = "BCA" Then
            ComboBox2.Items.Remove("5th Year")
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)
        If RadioButton1.Checked = True Then
            code = RadioButton1.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = "server=localhost;port=3308;user id=root;password=;database=db"
        Dim con As New MySqlConnection(str)
        Dim com As String = "Select * from subject where subjectcode = '" & Label5.Text & "' and year = '" & ComboBox2.SelectedItem & "' "
        Dim adpt As New MySqlDataAdapter(com, con)

        Dim ds As New DataSet()

        adpt.Fill(ds, "acc")
        Dim y As Integer = ds.Tables(0).Rows.Count

        If y >= 1 Then
            facultygeneratorlist.Show()
        Else

            MsgBox("No student is currently registered in  this subject")
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            code = RadioButton4.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            code = RadioButton2.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            code = RadioButton3.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            code = RadioButton5.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            code = RadioButton6.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked = True Then
            code = RadioButton7.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked = True Then
            code = RadioButton8.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        If RadioButton9.Checked = True Then
            code = RadioButton9.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        If RadioButton10.Checked = True Then
            code = RadioButton10.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        If RadioButton11.Checked = True Then
            code = RadioButton11.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton12_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        If RadioButton12.Checked = True Then
            code = RadioButton12.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton13_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
        If RadioButton13.Checked = True Then
            code = RadioButton13.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton14_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton14.CheckedChanged
        If RadioButton14.Checked = True Then
            code = RadioButton14.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton15_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton15.CheckedChanged
        If RadioButton15.Checked = True Then
            code = RadioButton15.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton16_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton16.CheckedChanged
        If RadioButton16.Checked = True Then
            code = RadioButton16.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton17_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton17.CheckedChanged
        If RadioButton17.Checked = True Then
            code = RadioButton17.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton18_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton18.CheckedChanged
        If RadioButton18.Checked = True Then
            code = RadioButton18.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton19_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton19.CheckedChanged
        If RadioButton19.Checked = True Then
            code = RadioButton19.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton20_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton20.CheckedChanged
        If RadioButton20.Checked = True Then
            code = RadioButton20.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton19_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton19.CheckedChanged

    End Sub

    Private Sub RadioButton40_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton40.CheckedChanged
        If RadioButton40.Checked = True Then
            code = RadioButton40.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton39_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton39.CheckedChanged
        If RadioButton39.Checked = True Then
            code = RadioButton39.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton38_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton38.CheckedChanged
        If RadioButton38.Checked = True Then
            code = RadioButton38.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton37_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton37.CheckedChanged
        If RadioButton37.Checked = True Then
            code = RadioButton37.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton36_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton36.CheckedChanged
        If RadioButton36.Checked = True Then
            code = RadioButton36.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton35_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton35.CheckedChanged
        If RadioButton35.Checked = True Then
            code = RadioButton35.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton34_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton34.CheckedChanged
        If RadioButton34.Checked = True Then
            code = RadioButton34.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton33_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton33.CheckedChanged
        If RadioButton33.Checked = True Then
            code = RadioButton33.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton32_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton32.CheckedChanged
        If RadioButton32.Checked = True Then
            code = RadioButton32.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton31_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton31.CheckedChanged
        If RadioButton31.Checked = True Then
            code = RadioButton31.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton30_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton30.CheckedChanged
        If RadioButton30.Checked = True Then
            code = RadioButton30.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton29_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton29.CheckedChanged
        If RadioButton29.Checked = True Then
            code = RadioButton29.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton28_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton28.CheckedChanged
        If RadioButton28.Checked = True Then
            code = RadioButton28.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton27_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton27.CheckedChanged
        If RadioButton27.Checked = True Then
            code = RadioButton27.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton26_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton26.CheckedChanged
        If RadioButton26.Checked = True Then
            code = RadioButton26.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton25_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton25.CheckedChanged
        If RadioButton25.Checked = True Then
            code = RadioButton25.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton24_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton24.CheckedChanged
        If RadioButton24.Checked = True Then
            code = RadioButton24.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton23_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton23.CheckedChanged
        If RadioButton23.Checked = True Then
            code = RadioButton23.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton22_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton22.CheckedChanged
        If RadioButton22.Checked = True Then
            code = RadioButton22.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Dim pos As Integer = Panel1.VerticalScroll.Value
        If ComboBox2.SelectedItem = "1st Year" Then
            Panel1.VerticalScroll.Value = 0

        ElseIf ComboBox2.SelectedItem = "2nd Year" Then
            Panel1.VerticalScroll.Value = 320

        ElseIf ComboBox2.SelectedItem = "3rd Year" Then
            Panel1.VerticalScroll.Value = 650

        ElseIf ComboBox2.SelectedItem = "4th Year" Then
            Panel1.VerticalScroll.Value = 1100

        End If

        If ComboBox2.SelectedItem = "1st Year" Then
            RadioButton1.Enabled = True
            RadioButton2.Enabled = True
            RadioButton3.Enabled = True
            RadioButton4.Enabled = True
            RadioButton5.Enabled = True
            RadioButton6.Enabled = True
            RadioButton7.Enabled = True
            RadioButton8.Enabled = True
            RadioButton9.Enabled = True
            RadioButton10.Enabled = True
            RadioButton11.Enabled = True
            RadioButton12.Enabled = True
            RadioButton13.Enabled = True
            RadioButton14.Enabled = True
            RadioButton15.Enabled = True
            RadioButton16.Enabled = True
            RadioButton17.Enabled = True
            RadioButton18.Enabled = True
            RadioButton19.Enabled = True
            RadioButton20.Enabled = True
            RadioButton42.Enabled = False
            RadioButton22.Enabled = False
            RadioButton23.Enabled = False
            RadioButton24.Enabled = False
            RadioButton25.Enabled = False
            RadioButton26.Enabled = False
            RadioButton27.Enabled = False
            RadioButton28.Enabled = False
            RadioButton29.Enabled = False
            RadioButton30.Enabled = False
            RadioButton31.Enabled = False
            RadioButton32.Enabled = False
            RadioButton33.Enabled = False
            RadioButton34.Enabled = False
            RadioButton35.Enabled = False
            RadioButton36.Enabled = False
            RadioButton37.Enabled = False
            RadioButton38.Enabled = False
            RadioButton39.Enabled = False
            RadioButton40.Enabled = False
            RadioButton43.Enabled = False
            RadioButton42.Enabled = False
            RadioButton44.Enabled = False
            RadioButton45.Enabled = False
            RadioButton46.Enabled = False
            RadioButton47.Enabled = False
            RadioButton48.Enabled = False
            RadioButton50.Enabled = False
            RadioButton51.Enabled = False
            RadioButton52.Enabled = False
            RadioButton53.Enabled = False
            RadioButton54.Enabled = False
            RadioButton55.Enabled = False
            RadioButton56.Enabled = False
            RadioButton57.Enabled = False
            RadioButton58.Enabled = False
            RadioButton67.Enabled = False
            RadioButton68.Enabled = False
            RadioButton69.Enabled = False
            RadioButton76.Enabled = False
            RadioButton77.Enabled = False

        ElseIf ComboBox2.SelectedItem = "2nd Year" Then
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            RadioButton3.Enabled = False
            RadioButton4.Enabled = False
            RadioButton5.Enabled = False
            RadioButton6.Enabled = False
            RadioButton7.Enabled = False
            RadioButton8.Enabled = False
            RadioButton9.Enabled = False
            RadioButton10.Enabled = False
            RadioButton11.Enabled = False
            RadioButton12.Enabled = False
            RadioButton13.Enabled = False
            RadioButton14.Enabled = False
            RadioButton15.Enabled = False
            RadioButton16.Enabled = False
            RadioButton17.Enabled = False
            RadioButton18.Enabled = False
            RadioButton19.Enabled = False
            RadioButton20.Enabled = False
            RadioButton42.Enabled = False
            RadioButton22.Enabled = True
            RadioButton23.Enabled = True
            RadioButton24.Enabled = True
            RadioButton25.Enabled = True
            RadioButton26.Enabled = True
            RadioButton27.Enabled = True
            RadioButton28.Enabled = True
            RadioButton29.Enabled = True
            RadioButton30.Enabled = True
            RadioButton31.Enabled = True
            RadioButton32.Enabled = True
            RadioButton33.Enabled = True
            RadioButton34.Enabled = True
            RadioButton35.Enabled = True
            RadioButton36.Enabled = True
            RadioButton37.Enabled = True
            RadioButton38.Enabled = True
            RadioButton39.Enabled = True
            RadioButton40.Enabled = True
            RadioButton43.Enabled = False
            RadioButton42.Enabled = False
            RadioButton44.Enabled = False
            RadioButton45.Enabled = False
            RadioButton46.Enabled = False
            RadioButton47.Enabled = False
            RadioButton48.Enabled = False
            RadioButton50.Enabled = False
            RadioButton51.Enabled = False
            RadioButton52.Enabled = False
            RadioButton53.Enabled = False
            RadioButton54.Enabled = False
            RadioButton55.Enabled = False
            RadioButton56.Enabled = False
            RadioButton57.Enabled = False
            RadioButton58.Enabled = False
            RadioButton67.Enabled = False
            RadioButton68.Enabled = False
            RadioButton69.Enabled = False
            RadioButton76.Enabled = False
            RadioButton77.Enabled = False
        ElseIf ComboBox2.SelectedItem = "3rd Year" Then
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            RadioButton3.Enabled = False
            RadioButton4.Enabled = False
            RadioButton5.Enabled = False
            RadioButton6.Enabled = False
            RadioButton7.Enabled = False
            RadioButton8.Enabled = False
            RadioButton9.Enabled = False
            RadioButton10.Enabled = False
            RadioButton11.Enabled = False
            RadioButton12.Enabled = False
            RadioButton13.Enabled = False
            RadioButton14.Enabled = False
            RadioButton15.Enabled = False
            RadioButton16.Enabled = False
            RadioButton17.Enabled = False
            RadioButton18.Enabled = False
            RadioButton19.Enabled = False
            RadioButton20.Enabled = False
            RadioButton42.Enabled = False
            RadioButton22.Enabled = False
            RadioButton23.Enabled = False
            RadioButton24.Enabled = False
            RadioButton25.Enabled = False
            RadioButton26.Enabled = False
            RadioButton27.Enabled = False
            RadioButton28.Enabled = False
            RadioButton29.Enabled = False
            RadioButton30.Enabled = False
            RadioButton31.Enabled = False
            RadioButton32.Enabled = False
            RadioButton33.Enabled = False
            RadioButton34.Enabled = False
            RadioButton35.Enabled = False
            RadioButton36.Enabled = False
            RadioButton37.Enabled = False
            RadioButton38.Enabled = False
            RadioButton39.Enabled = False
            RadioButton40.Enabled = False
            RadioButton43.Enabled = True
            RadioButton42.Enabled = True
            RadioButton44.Enabled = True
            RadioButton45.Enabled = True
            RadioButton46.Enabled = True
            RadioButton47.Enabled = True
            RadioButton48.Enabled = True
            RadioButton50.Enabled = True
            RadioButton51.Enabled = True
            RadioButton52.Enabled = True
            RadioButton53.Enabled = True
            RadioButton54.Enabled = True
            RadioButton55.Enabled = True
            RadioButton56.Enabled = True
            RadioButton57.Enabled = True
            RadioButton58.Enabled = True
            RadioButton67.Enabled = False
            RadioButton68.Enabled = False
            RadioButton69.Enabled = False
            RadioButton76.Enabled = False
            RadioButton77.Enabled = False

        ElseIf ComboBox2.SelectedItem = "4th Year" Then
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            RadioButton3.Enabled = False
            RadioButton4.Enabled = False
            RadioButton5.Enabled = False
            RadioButton6.Enabled = False
            RadioButton7.Enabled = False
            RadioButton8.Enabled = False
            RadioButton9.Enabled = False
            RadioButton10.Enabled = False
            RadioButton11.Enabled = False
            RadioButton12.Enabled = False
            RadioButton13.Enabled = False
            RadioButton14.Enabled = False
            RadioButton15.Enabled = False
            RadioButton16.Enabled = False
            RadioButton17.Enabled = False
            RadioButton18.Enabled = False
            RadioButton19.Enabled = False
            RadioButton20.Enabled = False
            RadioButton42.Enabled = False
            RadioButton22.Enabled = False
            RadioButton23.Enabled = False
            RadioButton24.Enabled = False
            RadioButton25.Enabled = False
            RadioButton26.Enabled = False
            RadioButton27.Enabled = False
            RadioButton28.Enabled = False
            RadioButton29.Enabled = False
            RadioButton30.Enabled = False
            RadioButton31.Enabled = False
            RadioButton32.Enabled = False
            RadioButton33.Enabled = False
            RadioButton34.Enabled = False
            RadioButton35.Enabled = False
            RadioButton36.Enabled = False
            RadioButton37.Enabled = False
            RadioButton38.Enabled = False
            RadioButton39.Enabled = False
            RadioButton40.Enabled = False
            RadioButton43.Enabled = False
            RadioButton42.Enabled = False
            RadioButton44.Enabled = False
            RadioButton45.Enabled = False
            RadioButton46.Enabled = False
            RadioButton47.Enabled = False
            RadioButton48.Enabled = False
            RadioButton50.Enabled = False
            RadioButton51.Enabled = False
            RadioButton52.Enabled = False
            RadioButton53.Enabled = False
            RadioButton54.Enabled = False
            RadioButton55.Enabled = False
            RadioButton56.Enabled = False
            RadioButton57.Enabled = False
            RadioButton58.Enabled = False
            RadioButton67.Enabled = True
            RadioButton68.Enabled = True
            RadioButton69.Enabled = True
            RadioButton76.Enabled = True
            RadioButton77.Enabled = True
        End If
    End Sub


    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            code = RadioButton1.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton77_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton77.CheckedChanged
        If RadioButton77.Checked = True Then
            code = RadioButton77.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton76_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton76.CheckedChanged
        If RadioButton76.Checked = True Then
            code = RadioButton76.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton69_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton69.CheckedChanged
        If RadioButton69.Checked = True Then
            code = RadioButton69.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton68_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton68.CheckedChanged
        If RadioButton68.Checked = True Then
            code = RadioButton68.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton67_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton67.CheckedChanged
        If RadioButton67.Checked = True Then
            code = RadioButton67.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton58_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton58.CheckedChanged
        If RadioButton58.Checked = True Then
            code = RadioButton58.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton57_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton57.CheckedChanged
        If RadioButton57.Checked = True Then
            code = RadioButton57.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton56_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton56.CheckedChanged
        If RadioButton56.Checked = True Then
            code = RadioButton56.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton55_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton55.CheckedChanged
        If RadioButton55.Checked = True Then
            code = RadioButton55.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton54_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton54.CheckedChanged
        If RadioButton54.Checked = True Then
            code = RadioButton54.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton53_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton53.CheckedChanged
        If RadioButton53.Checked = True Then
            code = RadioButton53.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton52_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton52.CheckedChanged
        If RadioButton52.Checked = True Then
            code = RadioButton52.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton51_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton51.CheckedChanged
        If RadioButton51.Checked = True Then
            code = RadioButton51.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton50_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton50.CheckedChanged
        If RadioButton50.Checked = True Then
            code = RadioButton50.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton48_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton48.CheckedChanged
        If RadioButton48.Checked = True Then
            code = RadioButton48.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton47_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton47.CheckedChanged
        If RadioButton47.Checked = True Then
            code = RadioButton47.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton46_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton46.CheckedChanged
        If RadioButton46.Checked = True Then
            code = RadioButton46.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton45_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton45.CheckedChanged
        If RadioButton45.Checked = True Then
            code = RadioButton45.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton44_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton44.CheckedChanged
        If RadioButton44.Checked = True Then
            code = RadioButton44.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton43_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton43.CheckedChanged
        If RadioButton43.Checked = True Then
            code = RadioButton43.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton42_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton42.CheckedChanged
        If RadioButton42.Checked = True Then
            code = RadioButton42.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "BTECH" Then
            Panel1.Visible = True
            Panel2.Visible = False
        End If
        If ComboBox1.SelectedItem = "BCA" Then
            Panel1.Visible = False
            Panel2.Visible = True
        End If


    End Sub

    Private Sub RadioButton1_CheckedChanged_2(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton102_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton102.CheckedChanged
        If RadioButton102.Checked = True Then
            code = RadioButton102.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton60_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton60.CheckedChanged
        If RadioButton60.Checked = True Then
            code = RadioButton60.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton59_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton59.CheckedChanged
        If RadioButton59.Checked = True Then
            code = RadioButton59.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton72_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton72.CheckedChanged
        If RadioButton72.Checked = True Then
            code = RadioButton72.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton49_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton49.CheckedChanged
        If RadioButton49.Checked = True Then
            code = RadioButton49.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton41_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton41.CheckedChanged
        If RadioButton41.Checked = True Then
            code = RadioButton41.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton21_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton21.CheckedChanged
        If RadioButton21.Checked = True Then
            code = RadioButton21.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton81_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton81.CheckedChanged
        If RadioButton81.Checked = True Then
            code = RadioButton81.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton80_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton80.CheckedChanged
        If RadioButton80.Checked = True Then
            code = RadioButton80.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton79_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton79.CheckedChanged
        If RadioButton79.Checked = True Then
            code = RadioButton79.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton78_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton78.CheckedChanged
        If RadioButton78.Checked = True Then
            code = RadioButton78.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton75_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton75.CheckedChanged
        If RadioButton75.Checked = True Then
            code = RadioButton75.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton74_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton74.CheckedChanged
        If RadioButton74.Checked = True Then
            code = RadioButton74.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton73_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton73.CheckedChanged
        If RadioButton73.Checked = True Then
            code = RadioButton73.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton70_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton70.CheckedChanged
        If RadioButton70.Checked = True Then
            code = RadioButton70.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton66_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton66.CheckedChanged
        If RadioButton66.Checked = True Then
            code = RadioButton66.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton65_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton65.CheckedChanged
        If RadioButton65.Checked = True Then
            code = RadioButton65.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton64_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton64.CheckedChanged
        If RadioButton64.Checked = True Then
            code = RadioButton64.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton63_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton63.CheckedChanged
        If RadioButton63.Checked = True Then
            code = RadioButton63.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton62_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton62.CheckedChanged
        If RadioButton62.Checked = True Then
            code = RadioButton62.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton61_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton61.CheckedChanged
        If RadioButton61.Checked = True Then
            code = RadioButton61.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton71_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton71.CheckedChanged
        If RadioButton71.Checked = True Then
            code = RadioButton71.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton100_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton100.CheckedChanged
        If RadioButton100.Checked = True Then
            code = RadioButton100.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton99_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton99.CheckedChanged
        If RadioButton99.Checked = True Then
            code = RadioButton99.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton98_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton98.CheckedChanged
        If RadioButton98.Checked = True Then
            code = RadioButton98.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton97_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton97.CheckedChanged
        If RadioButton97.Checked = True Then
            code = RadioButton97.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton96_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton96.CheckedChanged
        If RadioButton96.Checked = True Then
            code = RadioButton96.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton95_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton95.CheckedChanged
        If RadioButton95.Checked = True Then
            code = RadioButton95.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton94_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton94.CheckedChanged
        If RadioButton94.Checked = True Then
            code = RadioButton94.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton93_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton93.CheckedChanged
        If RadioButton93.Checked = True Then
            code = RadioButton93.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton91_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton91.CheckedChanged
        If RadioButton91.Checked = True Then
            code = RadioButton91.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton90_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton90.CheckedChanged
        If RadioButton90.Checked = True Then
            code = RadioButton90.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton89_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton89.CheckedChanged
        If RadioButton89.Checked = True Then
            code = RadioButton89.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton88_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton88.CheckedChanged
        If RadioButton88.Checked = True Then
            code = RadioButton88.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton87_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton87.CheckedChanged
        If RadioButton87.Checked = True Then
            code = RadioButton87.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton86_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton86.CheckedChanged
        If RadioButton86.Checked = True Then
            code = RadioButton86.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton85_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton85.CheckedChanged
        If RadioButton85.Checked = True Then
            code = RadioButton85.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton84_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton84.CheckedChanged
        If RadioButton84.Checked = True Then
            code = RadioButton84.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton83_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton83.CheckedChanged
        If RadioButton83.Checked = True Then
            code = RadioButton83.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton82_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton82.CheckedChanged
        If RadioButton82.Checked = True Then
            code = RadioButton82.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton120_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton120.CheckedChanged
        If RadioButton120.Checked = True Then
            code = RadioButton120.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton119_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton119.CheckedChanged
        If RadioButton119.Checked = True Then
            code = RadioButton119.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton118_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton118.CheckedChanged
        If RadioButton118.Checked = True Then
            code = RadioButton118.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton116_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton116.CheckedChanged
        If RadioButton116.Checked = True Then
            code = RadioButton116.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton115_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton115.CheckedChanged
        If RadioButton115.Checked = True Then
            code = RadioButton115.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton114_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton114.CheckedChanged
        If RadioButton114.Checked = True Then
            code = RadioButton114.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton113_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton113.CheckedChanged
        If RadioButton113.Checked = True Then
            code = RadioButton113.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton112_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton112.CheckedChanged
        If RadioButton112.Checked = True Then
            code = RadioButton112.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton111_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton111.CheckedChanged
        If RadioButton111.Checked = True Then
            code = RadioButton111.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton110_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton110.CheckedChanged
        If RadioButton110.Checked = True Then
            code = RadioButton110.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton109_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton109.CheckedChanged
        If RadioButton109.Checked = True Then
            code = RadioButton109.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton108_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton108.CheckedChanged
        If RadioButton108.Checked = True Then
            code = RadioButton108.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton107_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton107.CheckedChanged
        If RadioButton107.Checked = True Then
            code = RadioButton107.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton106_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton106.CheckedChanged
        If RadioButton106.Checked = True Then
            code = RadioButton106.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton105_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton105.CheckedChanged
        If RadioButton105.Checked = True Then
            code = RadioButton105.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton104_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton104.CheckedChanged
        If RadioButton104.Checked = True Then
            code = RadioButton104.Text
            Label5.Text = code
        End If
    End Sub

    Private Sub RadioButton101_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton101.CheckedChanged
        If RadioButton101.Checked = True Then
            code = RadioButton101.Text
            Label5.Text = code
        End If
    End Sub
End Class