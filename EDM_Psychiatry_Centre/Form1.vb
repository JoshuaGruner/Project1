Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show() 'When the button Anxiety has been click, it will link to Anxiety form '
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show() 'When the button Depression has been click, it will link to Depression form '
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.Show() 'When the button Social Anxiety has been click, it will link to Social Anxiety form '
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form5.Show() 'When the button OCD has been click, it will link to OCD form '
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form6.Show() 'When the button Insomnia has been click, it will link to  form '
        Me.Hide()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Form8.Show() 'Click button Resources From Homepage to link to form 8 to display the page of resources about mental health'
        Me.Hide()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        AboutBox.Show() 'Click button About us to display The information about our company or purpose of our application
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim x As String = txtMsgBox.Text
        MsgBox(x + vbNewLine + vbNewLine + "(YOUR FEEDBACK HAS BEEN RECORDED.)")
        'When then submit button has been click, it will show the form has been recorded'
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Me.Hide()
        New_Appointment.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form8.Show() 'Click button Resources From Homepage to link to form 8 to display the page of resources about mental health'
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        New_Appointment.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AboutBox.Show() 'Click button About us to display The information about our company or purpose of our application
    End Sub

    Private Sub AnxietyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnxietyToolStripMenuItem.Click
        Form2.Show() 'Button from menustrip at hompage to anxiety page'

    End Sub

    Private Sub DepreessionToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Form3.Show() 'Button from menustrip at hompage to depression page'
    End Sub

    Private Sub DepreessionToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DepreessionToolStripMenuItem.Click
        Form3.Show() 'Button from menustrip at hompage to depression page'
    End Sub

    Private Sub SocialAnxietyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SocialAnxietyToolStripMenuItem.Click
        Form4.Show() 'Button from menustrip at hompage to social anxiety page'
    End Sub

    Private Sub OCDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OCDToolStripMenuItem.Click
        Form5.Show() 'Button from menustrip at hompage to ocd page'
    End Sub

    Private Sub InsomniaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsomniaToolStripMenuItem.Click
        Form6.Show() 'Button from menustrip at hompage to insomnia page'
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtMsgBox.TextChanged

    End Sub
End Class
