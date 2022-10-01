Public Class DataIssuesForm

   Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
      Me.Close()
   End Sub

   Public Sub CountIssue(robotValues As Integer, robotButtons As Integer)
      LabelDashSettings.Text = m_dashValueCount.ToString
      LabelDashButtons.Text = m_dashButtonCount.ToString

      LabelRobotSettings.Text = robotValues.ToString
      LabeRobotButtons.Text = robotButtons.ToString
   End Sub

   Private Sub DataIssuesForm_Load(sender As Object, e As EventArgs) Handles Me.Load
      Me.Top = m_dashForm.Top + 60
      Me.Left = m_dashForm.Left + (m_dashForm.Width - Me.Width) \ 2
   End Sub

End Class