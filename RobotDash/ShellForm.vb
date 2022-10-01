Public Class ShellForm

   Public Enum LinkStatus
      None = 0
      Connecting = 1
      NoAddress = 2
      Connected = 3
   End Enum

   Private Delegate Sub ClientStatusCallback(status As LinkStatus)
   Private Delegate Sub FinishCountCallback(mode As Integer, robotStatus As Integer, robotValue As Integer, dashButton As Integer, dashValue As Integer)
   Private Delegate Sub FinishGetCallback(mode As Integer)
   Private Delegate Sub FinishPullCallback()
   Private Delegate Sub FinishPutCallback(buttonAck As Boolean, valueAck As Boolean)

   Private Sub ClientStatus(status As LinkStatus)
      If m_dashForm IsNot Nothing
         If status = LinkStatus.Connected 
            m_dashForm.LedRobot.BackColor = Color.PaleGreen
            m_dashForm.LabelStatus.BackColor = Color.FromArgb(252, 252, 252) 
            m_robotConnected = True        
         Else
            m_dashForm.LedRobot.BackColor = Color.WhiteSmoke
            m_dashForm.LabelStatus.BackColor = Color.Yellow
            m_robotConnected = False
         End If

         Select status
            Case LinkStatus.Connecting
               m_dashForm.LabelStatus.Text = "Connecting..."
            Case LinkStatus.NoAddress
               m_dashForm.LabelStatus.Text = "No IP Address"
            Case Else
               m_dashForm.LabelStatus.Text = ""
         End Select

         If m_dataForm           IsNot Nothing Then m_dataForm.UpdateRobotStatus()
         If m_graphForm          IsNot Nothing Then m_graphForm.UpdateRobotStatus()
         If m_robotStatusForm    IsNot Nothing Then m_robotStatusForm.UpdateRobotStatus()
         If m_robotValuesForm    IsNot Nothing Then m_robotValuesForm.UpdateRobotStatus()
         If m_settingsForm       IsNot Nothing Then m_settingsForm.UpdateRobotStatus()
      End If
   End Sub

   Private Sub FinishCount(mode As Integer, robotStatus As Integer, robotValue As Integer, dashButton As Integer, dashValue As Integer)
      m_robotStatusCount = robotStatus
      ReDim m_robotStatus(m_robotStatusCount)

      m_robotValueCount = robotValue
      ReDim m_robotValue(m_robotValueCount)

      If m_robotMode <> mode
         m_robotMode = mode
         If m_dashForm IsNot Nothing Then m_dashForm.LabelStatus.Text = RobotModeCaption(mode)
      End If

      If dashValue <> m_dashValueCount Or dashButton <> m_dashButtonCount
         m_dashForm.LabelStatus.BackColor = Color.Red
         m_dashForm.LabelStatus.ForeColor = Color.White
         m_dashForm.LabelStatus.Text = "Data Counts Issue"

         Dim dataIssue As New DataIssuesForm
         dataIssue.CountIssue(dashValue, dashButton)
         dataIssue.ShowDialog(m_dashForm)
      Else
         m_tcpClient.SendPullRequest()
      End If

      If m_dataForm IsNot Nothing Then m_dataForm.BuildGrids(True)
   End Sub

   Private Sub FinishGet(mode As Integer)
      If m_robotMode <> mode
         m_robotMode = mode
         If m_dashForm IsNot Nothing Then m_dashForm.LabelStatus.Text = RobotModeCaption(mode)
      End If

      If m_dashForm IsNot Nothing Then          m_dashForm.showData()
      If m_robotStatusForm IsNot Nothing Then   m_robotStatusForm.ShowStatus()
      If m_robotValuesForm IsNot Nothing Then   m_robotValuesForm.ShowValues()
      If m_graphForm IsNot Nothing Then         m_graphForm.NewValues()
      If m_tunePIDForm IsNot Nothing Then       m_tunePIDForm.UpdateStatus(TunePidForm.DataGroup.RobotValue)

      If m_dataForm IsNot Nothing 
         m_dataForm.ShowData(DataForm.DataGroup.RobotValue)
         m_dataForm.ShowData(DataForm.DataGroup.RobotStatus)
      End If
   End Sub

   Private Sub FinishPull()
      Dim i          As Integer
      Dim mismatch   As Boolean = False

      For i = m_robotSetting1 To m_dashValueCount - 1
         If i < m_robotSettingsCount
            If m_dashValue(i).value <> m_robotSettings(i)
               mismatch = True
               Exit For
            End If
         End If
      Next

      If mismatch
         m_dashForm.LabelStatus.BackColor = Color.Red
         m_dashForm.LabelStatus.ForeColor = Color.White
         m_dashForm.LabelStatus.Text = "Settings Mismatch"
         m_tcpClient.SetPingEnable(True)

         If m_settingsForm IsNot Nothing Then m_settingsForm.Close()

         m_settingsForm = New SettingsForm
         m_settingsForm.ShowRobotValues()
         m_settingsForm.ShowDialog(m_dashForm)

         m_tcpClient.SetPingEnable(False)

      Else
         For i = m_robotSetting1 To m_dashValueCount
            With m_dashValue(i)
               .revised = False
               .sentToHost = True
            End With
         Next

         m_tcpClient.SendDashboardData(True)
         m_tcpClient.SetGetOK()
      End If
   End Sub

   Private Sub FinishPut(buttonAck As Boolean, valueAck As Boolean)
      If buttonAck
         If m_dataForm IsNot Nothing Then m_dataForm.ShowData(DataForm.DataGroup.DashButton)
      End If

      If valueAck
         If m_dashForm IsNot Nothing Then       m_dashForm.UpdateStatus()
         If m_dataForm IsNot Nothing Then       m_dataForm.ShowData(DataForm.DataGroup.DashValue)
         If m_settingsForm IsNot Nothing Then   m_settingsForm.UpdateStatus()
         If m_tunePIDForm IsNot Nothing Then    m_tunePIDForm.UpdateStatus(TunePidForm.DataGroup.DashValue)
      End If

      m_tcpClient.SetGetOK()
   End Sub

   Public Sub InvokeClientStatus(status As LinkStatus)
      Try
         Me.Invoke(New ClientStatusCallback(AddressOf ClientStatus), New Object () {status})
      Catch
      End Try
   End Sub

   Public Sub InvokeFinishCount(mode As Integer, robotStatus As Integer, robotValue As Integer, dashButton As Integer, dashValue As Integer)
      Try
         Me.Invoke(New FinishCountCallback(AddressOf FinishCount), New Object () {mode, robotStatus, robotValue, dashButton, dashValue})
      Catch
      End Try
   End Sub

   Public Sub InvokeFinshGet(mode As Integer)
      Try
         Me.Invoke(New FinishGetCallback(AddressOf FinishGet), New Object () {mode})
      Catch
      End Try
   End Sub

   Public Sub InvokeFinishPull()
      Try
         Me.Invoke(New FinishPullCallback(AddressOf FinishPull), New Object () {})
      Catch
      End Try
   End Sub

   Public Sub InvokeFinishPut(buttonAck As Boolean, valueAck As Boolean)
      Try
         Me.Invoke(New FinishPutCallback(AddressOf FinishPut), New Object () {buttonAck, valueAck})
      Catch
      End Try
   End Sub

   Private Sub ShellForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
      m_shellForm = Nothing
   End Sub

   Private Sub ShellForm_Load(sender As Object, e As EventArgs) Handles Me.Load
      m_shellForm = Me

      Me.Top = Screen.GetBounds(Me).Top
      Me.Left = Screen.GetBounds(Me).Left

      m_imageDone       = Image.FromFile(Application.StartupPath & "\Resources\Done.png")
      m_imagePending    = Image.FromFile(Application.StartupPath & "\Resources\Pending.png")

      ReDim m_dashValue(m_dashValueCount)
      ReDim m_dashButton(m_dashButtonCount)

      LoadOptions()

      m_dashFile = Application.StartupPath & "\Settings\" & m_dashOptions.settingsFile

      If Not LoadDashValues()
         m_shellForm.Close()
         Exit Sub
      End If

      LoadAutoList()
      DashButton(DBIndex.dbVisionAuto) = True
      DashButton(DBIndex.dbSandStormAuto) = False

      m_dashForm = New DashForm
      m_dashForm.Show()

      StartClient()
   End Sub

End Class