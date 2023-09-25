Public Class Form6
    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Form7.Show() 'When the button submit has been click, it will show the form has been submitted'
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Form1.Hide() 'Go back to Homepage' 'button homepage'
        Form1.Show()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Form1.Hide() 'Go back to Homepage' 'button cancel'
        Form1.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Form8.Show() 'Click button Resources From Homepage to link to form 8 to display the page of resources about mental health'
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Me.Hide()
        New_Appointment.Show()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        AboutBox.Show() 'Click button About us to display The information about our company or purpose of our application
    End Sub
End Class