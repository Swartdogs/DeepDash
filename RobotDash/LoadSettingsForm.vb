Imports System.ComponentModel
Imports System.IO

Public Class LoadSettingsForm
   Public settingsFile As String = String.Empty

   Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
      DialogResult = DialogResult.Cancel
   End Sub

   Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
      settingsFile = TextFile.Text & ".set"
      DialogResult = DialogResult.OK
   End Sub

   Private Sub ListSettings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListSettings.SelectedIndexChanged
      If ListSettings.SelectedIndex >= 0 Then TextFile.Text = ListSettings.Items(ListSettings.SelectedIndex)
   End Sub

   Private Sub LoadSettingsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
      Me.Top = m_optionsForm.Top + 60
      Me.Left = m_optionsForm.Left + (m_optionsForm.Width - Me.Width) / 2

      Dim settingsFolder As String = Application.StartupPath & "\Settings"

      If Directory.Exists(settingsFolder)
         Dim binaryFormatter As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter
         Dim settingsFiles As String() = Directory.GetFiles(settingsFolder, "*.set")

         For Each file As String In settingsFiles
            ListSettings.Items.Add(Path.GetFileNameWithoutExtension(file))
         Next
      End If
   End Sub

   Private Sub TextFile_GotFocus(sender As Object, e As EventArgs) Handles TextFile.GotFocus
      TextFile.SelectAll
   End Sub

   Private Sub TextFile_TextChanged(sender As Object, e As EventArgs) Handles TextFile.TextChanged
      ButtonSave.Enabled = (TextFile.Text.Length > 0)
   End Sub

   Private Sub TextFile_Validating(sender As Object, e As CancelEventArgs) Handles TextFile.Validating
      Dim file As String = TextFile.Text
      TextFile.Text = Path.GetFileNameWithoutExtension(file)
   End Sub
End Class