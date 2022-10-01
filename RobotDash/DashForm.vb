
Imports System.ComponentModel

Public Class DashForm

   Private c_buttonIndex         As Integer = -1
   Private c_colorGreen          As Color = Color.FromArgb(190, 255, 190)
   Private c_colorRed            As Color = Color.FromArgb(255, 210, 210)
   Private c_formName            As String = "Dashboard"
   Private c_formResize          As Boolean = False
   Private c_ignoreEvents        As Boolean = False
   Private c_intakeButtonList    As List(Of Button) = New List(Of Button)
   Private c_liftButtonList      As List(Of Button) = New List(Of Button)

   Private Sub ButtonDataCapture_Click(sender As Object, e As EventArgs) Handles ButtonDataCapture.Click
      If DashButton(DBIndex.dbDataCapture)
         DashButton(DBIndex.dbDataCapture) = False
         ButtonDataCapture.BackColor = Color.WhiteSmoke
      Else
         DashButton(DBIndex.dbDataCapture) = True
         ButtonDataCapture.BackColor = Color.SpringGreen
      End If
   End Sub

   Private Sub ButtonSSAuto_Click(sender As Object, e As EventArgs) Handles ButtonSSAuto.Click
      If DashButton(DBIndex.dbSandStormAuto)
         DashButton(DBIndex.dbSandStormAuto) = False
         ButtonSSAuto.BackColor = Color.WhiteSmoke
      Else
         DashButton(DBIndex.dbSandStormAuto) = True
         ButtonSSAuto.BackColor = Color.SpringGreen
      End If
   End Sub

   Private Sub ButtonVisionAuto_Click(sender As Object, e As EventArgs) Handles ButtonVisionAuto.Click
      If DashButton(DBIndex.dbVisionAuto)
         DashButton(DBIndex.dbVisionAuto) = False
         ButtonVisionAuto.BackColor = Color.WhiteSmoke
      Else
         DashButton(DBIndex.dbVisionAuto) = True
         ButtonVisionAuto.BackColor = Color.SpringGreen
      End If
   End Sub

   Private Sub DashForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
      m_dashForm = Nothing
   End Sub

   Private Sub DashForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
      If c_formResize
         c_formResize = False
      Else
         SaveDashValues()
         StopClient()
         m_tcpClient = Nothing
         m_shellForm.Close()
      End If
   End Sub

   Private Sub DashForm_Load(sender As Object, e As EventArgs) Handles Me.Load
      m_dashForm = Me
      SetFormZoom(m_dashOptions.dashFormZoom, 100, Me)

      ShowData()

      c_ignoreEvents = True
         ListHatch.SelectedIndex = DashValue(DVindex.dvAutoHatchPlace)
         If Not m_dashValue(DVindex.dvAutoHatchPlace).sentToHost Then ListHatch.BackColor = m_colorPending

         ListLoad.SelectedIndex = DashValue(DVindex.dvAutoStop)
         If Not m_dashValue(DVindex.dvAutoStop).sentToHost Then ListLoad.BackColor = m_colorPending
      c_ignoreEvents = False

      Me.Top = Screen.GetBounds(Me).Top + 5
      Me.Left = Screen.GetBounds(Me).Left + (Screen.GetBounds(Me).Width - Me.Width) / 2
   End Sub

   Private Sub DashForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
      Static myWindowState As FormWindowState = FormWindowState.Normal

      If myWindowState <> Me.WindowState
         myWindowState = Me.WindowState
         SetAppWindowState(myWindowState)
      End If
   End Sub

   Private Sub FileExit_Click(sender As Object, e As EventArgs) Handles FileExit.Click
      Me.Close()
   End Sub

   Private Sub FileReconnect_Click(sender As Object, e As EventArgs) Handles FileReconnect.Click
      LabelStatus.BackColor = Color.FromArgb(252, 252, 252)         
      LabelStatus.Text = ""

      StopClient()
      m_tcpClient = Nothing
      TimerRestart.Start()
   End Sub

   Public Property FormResize() As Boolean
      Get
         FormResize = c_formResize
      End Get
       Set(value As Boolean)
         c_formResize = value
       End Set
   End Property

   Private Sub ListSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListHatch.SelectedIndexChanged,
                                                                                         ListLoad.SelectedIndexChanged
      If Not c_ignoreEvents
         Dim dashIndex  As Integer
         Dim list       As ComboBox = CType(sender, ComboBox)

         Select list.Tag
            Case 0:  dashIndex = DVindex.dvAutoHatchPlace
            Case 1:  dashIndex = DVindex.dvAutoStop
         End Select

         m_dashValue(dashIndex).revised = True
         list.BackColor = m_colorPending
         DashValue(dashIndex, True) = CDbl(list.SelectedIndex)
         DashValue(-1, True) = 0
      End If
   End Sub

   Private Function PercentValue(value As Double, range As Double) As Integer
      Dim percent As Integer = 0

      If range > 0
         percent = 100 * (value / range)
         If percent < 0
            percent = 0
         ElseIf percent > 100
            percent = 100
         End If
      End If

      Return percent
   End Function

   Public Sub ShowData()
      Static shiftLow      As Boolean = False
      Static climbSound    As Boolean = False
      Static noClimbSound  As Boolean = False
      Static targetSound   As Boolean = False
      Static cargoSound    As Boolean = False

      If m_robotValueCount > 0
         LabelDriveLeft1.Text        = GetRobotValue(RVindex.rvDriveAmpsLeft1).ToString("0.0")
         LabelDriveLeft2.Text        = GetRobotValue(RVindex.rvDriveAmpsLeft2).ToString("0.0")
         LabelDriveRight1.Text       = GetRobotValue(RVindex.rvDriveAmpsRight1).ToString("0.0")
         LabelDriveRight2.Text       = GetRobotValue(RVindex.rvDriveAmpsRight2).ToString("0.0")
         LabelEncoderLeft.Text       = GetRobotValue(RVindex.rvDriveEncoderL).ToString("0.0")
         LabelEncoderRight.Text      = GetRobotValue(RVindex.rvDriveEncoderR).ToString("0.0")
         LabelGyro.Text              = GetRobotValue(RVindex.rvDriveGyro).ToString("0.0")

         If GetRobotStatus(RSIndex.rsShifterLow)
            LabelShift.ForeColor = Color.Red
            LabelShift.Text = "LOW"
            If Not shiftLow Then My.Computer.Audio.Play(Application.StartupPath & "\Resources\LowGear.wav", AudioPlayMode.Background)
            shiftLow = True
         Else
            LabelShift.ForeColor = Color.DarkGreen
            LabelShift.Text = "HIGH"
            shiftLow = False
         End If

         LabelElevSetpoint.Text      = GetRobotValue(RVindex.rvElevatorSetpoint).ToString("0.0")

         If m_dashValue(DVindex.dvElevRetracted).value < 1
            LabelElevSetpoint.BackColor = Color.Pink
         Else
            LabelElevSetpoint.BackColor = Color.White
         End If

         LabelElevPosition.Text      = GetRobotValue(RVindex.rvElevatorPosition).ToString("0.0")
         LabelElevAmps.Text          = GetRobotValue(RVindex.rvElevatorAmps).ToString("0.0")

         If GetRobotStatus(RSIndex.rsFootRetracted)
            LabelElevFoot.Text = "RETRACT"
            LabelElevFoot.ForeColor = Color.Red
         Else
            LabelElevFoot.Text = "EXTEND"
            LabelElevFoot.ForeColor = Color.DarkGreen
         End If

         If GetRobotStatus(RSIndex.rsFloorFront)
            LabelFloorFront.Text = "YES"
            LabelFloorFront.ForeColor = Color.Red
         Else
            LabelFloorFront.Text = "NO"
            LabelFloorFront.ForeColor = Color.DarkGreen
         End If

         If GetRobotStatus(RSIndex.rsFloorRear)
            LabelFloorRear.Text = "YES"
            LabelFloorRear.ForeColor = Color.Red
         Else
            LabelFloorRear.Text = "NO"
            LabelFloorRear.ForeColor = Color.DarkGreen
         End If

         LabelShoulderSetpoint.Text  = GetRobotValue(RVindex.rvShoulderSetpoint).ToString("0.0")
         LabelShoulderPosition.Text  = GetRobotValue(RVindex.rvShoulderPosition).ToString("0.0")
         LabelShoulderAmps.Text      = GetRobotValue(RVindex.rvShoulderAmps).ToString("0.0")

         LabelWristSetpoint.Text     = GetRobotValue(RVindex.rvWristSetpoint).ToString("0.0")
         LabelWristPosition.Text     = GetRobotValue(RVindex.rvWristPosition).ToString("0.0")
         LabelWristAmps.Text         = GetRobotValue(RVindex.rvWristAmps).ToString("0.0")

         If GetRobotStatus(RSIndex.rsHatchMode)
            LabelHandMode.Text       = "HATCH"
            LabelHandMode.ForeColor  = Color.Red
         Else
            LabelHandMode.Text       = "CARGO"
            LabelHandMode.ForeColor  = Color.DarkGreen
         End If

         If GetRobotStatus(RSIndex.rsHatchGrab)
            LabelHatch.Text          = "RELEASE"
            LabelHatch.ForeColor     = Color.DarkGreen
         Else
            LabelHatch.Text          = "GRAB"
            LabelHatch.ForeColor     = Color.Red
         End If

         If GetRobotStatus(RSIndex.rsCargo)
            LabelCargo.Text          = "YES"
            LabelCargo.ForeColor     = Color.Red
         Else
            LabelCargo.Text          = "NO"
            LabelCargo.ForeColor     = Color.DarkGreen
         End If

         Select CInt(GetRobotValue(RVindex.rvVisionStatus))
            Case 0:  LabelTarget.Text           = "---"           ' Done
                     LabelTargetAngle.Text      = "---"
                     LabelTargetDistance.Text   = "---"
            Case 1:  LabelTarget.Text           = "Looking"       ' Looking
                     LabelTargetAngle.Text      = "---"
                     LabelTargetDistance.Text   = "---"
            Case 2:  LabelTarget.Text           = "No Image"      ' No Image
                     LabelTargetAngle.Text      = "---"
                     LabelTargetDistance.Text   = "---"
            Case 3:  LabelTarget.Text           = "Not Found"     ' Not Found
                     LabelTargetAngle.Text      = "---"
                     LabelTargetDistance.Text   = "---"
            Case 4:  Select CInt(GetRobotValue(RVindex.rvVisionSelect))
                        Case 0: LabelTarget.Text = "Best"
                        Case 1: LabelTarget.Text = "Left"
                        Case 2: LabelTarget.Text = "Right" 
                     End Select
                     LabelTargetAngle.Text      = GetRobotValue(RVindex.rvVisionAngle).ToString("0.0")
                     LabelTargetDistance.Text   = GetRobotValue(RVindex.rvVisionDistance).ToString("0.0")
         End Select

         If GetRobotStatus(RSIndex.rsClimb)
            If Not climbSound Then
               climbSound = True
               My.Computer.Audio.Play(Application.StartupPath & "\Resources\Climb.wav", AudioPlayMode.Background)
            End If
         Else
            climbSound = False
         End If

         If GetRobotStatus(RSIndex.rsNoClimb)
            If Not noClimbSound Then
               noClimbSound = True
               My.Computer.Audio.Play(Application.StartupPath & "\Resources\NoClimb.wav", AudioPlayMode.Background)
            End If
         Else
            noClimbSound = False
         End If

         If GetRobotStatus(RSIndex.rsTargetFound)
            If Not targetSound Then
               targetSound = True
               My.Computer.Audio.Play(Application.StartupPath & "\Resources\TargetFound.wav", AudioPlayMode.Background)
            End If
         Else
            targetSound = False
         End If

         If GetRobotStatus(RSIndex.rsCargoLoaded)
            If Not cargoSound Then
               cargoSound = True
               My.Computer.Audio.Play(Application.StartupPath & "\Resources\CargoLoaded.wav", AudioPlayMode.Background)
            End If
         Else
            cargoSound = False
         End If
      End If
   End Sub

   Private Sub TimerClick_Tick(sender As Object, e As EventArgs) Handles TimerClick.Tick
      TimerClick.Enabled = False
      DashButton(c_buttonIndex) = False
      c_buttonIndex = -1
   End Sub

   Private Sub TimerRestart_Tick(sender As Object, e As EventArgs) Handles TimerRestart.Tick
      TimerRestart.Enabled = False
      StartClient()
   End Sub

   Public Sub UpdateStatus()
      If Not m_dashValue(DVindex.dvAutoHatchPlace).revised And m_dashValue(DVindex.dvAutoHatchPlace).sentToHost Then ListHatch.BackColor = Color.White
      If Not m_dashValue(DVindex.dvAutoStop).revised And m_dashValue(DVindex.dvAutoStop).sentToHost Then ListLoad.BackColor = Color.White
   End Sub

   Private Sub ViewData_Click(sender As Object, e As EventArgs) Handles ViewData.Click
      If m_dataForm Is Nothing
         m_dataForm = New DataForm
         m_dataForm.Show()
      ElseIf m_dataForm.WindowState = FormWindowState.Minimized
         m_dataForm.WindowState = FormWindowState.Normal
      Else
         m_dataForm.Activate()
      End If
   End Sub

   Private Sub ViewGraph_Click(sender As Object, e As EventArgs) Handles ViewGraph.Click
      If m_graphForm Is Nothing
         m_graphForm = New GraphForm
         m_graphForm.Show()
      ElseIf m_graphForm.WindowState = FormWindowState.Minimized
         m_graphForm.WindowState = FormWindowState.Normal
      Else
         m_graphForm.Activate()
      End If
   End Sub

   Private Sub ViewOptions_Click(sender As Object, e As EventArgs) Handles ViewOptions.Click
      If m_optionsForm Is Nothing
         m_optionsForm = New OptionsForm
         m_optionsForm.Show()
      ElseIf m_optionsForm.WindowState = FormWindowState.Minimized
         m_optionsForm.WindowState = FormWindowState.Normal
      Else
         m_optionsForm.Activate()
      End If
   End Sub

   Private Sub ViewRobotStatus_Click(sender As Object, e As EventArgs) Handles ViewRobotStatus.Click
      If m_robotStatusForm Is Nothing
         m_robotStatusForm = New RobotStatusForm
         m_robotStatusForm.Show()
      ElseIf m_robotStatusForm.WindowState = FormWindowState.Minimized
         m_robotStatusForm.WindowState = FormWindowState.Normal
      Else
         m_robotStatusForm.Activate()
      End If
   End Sub

   Private Sub ViewRobotValues_Click(sender As Object, e As EventArgs) Handles ViewRobotValues.Click
      If m_robotValuesForm Is Nothing
         m_robotValuesForm = New RobotValuesForm
         m_robotValuesForm.Show()
      ElseIf m_robotValuesForm.WindowState = FormWindowState.Minimized
         m_robotValuesForm.WindowState = FormWindowState.Normal
      Else
         m_robotValuesForm.Activate()
      End If
   End Sub

   Private Sub ViewSettings_Click(sender As Object, e As EventArgs) Handles ViewSettings.Click
      If m_settingsForm Is Nothing
         m_settingsForm = New SettingsForm
         m_settingsForm.Show()
      ElseIf m_settingsForm.WindowState = FormWindowState.Minimized
         m_settingsForm.WindowState = FormWindowState.Normal
      Else
         m_settingsForm.Activate()
      End If
   End Sub

   Private Sub ViewTraffic_Click(sender As Object, e As EventArgs) Handles ViewTraffic.Click 
      If m_hostTrafficForm Is Nothing
         m_hostTrafficForm = New HostTrafficForm
         m_hostTrafficForm.Show()
      ElseIf m_hostTrafficForm.WindowState = FormWindowState.Minimized
         m_hostTrafficForm.WindowState = FormWindowState.Normal
      Else
         m_hostTrafficForm.Activate()
      End If
   End Sub

   Private Sub ViewTune_Click(sender As Object, e As EventArgs) Handles ViewTune.Click
      If m_tunePIDForm Is Nothing
         m_tunePIDForm = New TunePidForm
         m_tunePIDForm.Show()
      ElseIf m_tunePIDForm.WindowState = FormWindowState.Minimized
         m_tunePIDForm.WindowState = FormWindowState.Normal
      Else
         m_tunePIDForm.Activate()
      End If
   End Sub

End Class
