Module DashModule

   Public Structure DashboardButton
      Dim value            As Long
      Dim sentToHost       As Boolean
   End Structure

   <Serializable> Public Structure DashboardValue
      Dim value            As Double
      Dim revised          As Boolean
      Dim sentToHost       As Boolean
   End Structure

   <Serializable> Public Structure DashOptions
      Dim robotHost        As String
      Dim robotPort        As Int32
      Dim dashFormZoom     As Integer
      Dim buttonsEnabled   As Boolean
      Dim settingsFile     As String
   End Structure

   Public m_dashButtonCount As Integer = 1

   Public Enum DBIndex
      dbRunPID          = 0
      dbDataCapture     = 1
      dbVisionAuto      = 2
      dbSandStormAuto   = 3
   End Enum

   Public m_dashValueCount As Integer = 63                 
   Public m_robotSetting1  As Integer = 14

   Public Enum DVindex
      dvAutoHatchPlace     = 0
      dvAutoStop           = 1
      dvPidSelect			   = 2
      dvPidSetpoint			= 3
      dvPidMaxOut			   = 4
      dvPidPthreshold		= 5
      dvPidPabove				= 6
      dvPidPbelow				= 7
      dvPidIthreshold		= 8
      dvPidIabove				= 9
      dvPidIbelow				= 10
      dvPidDthreshold		= 11
      dvPidDabove				= 12
      dvPidDbelow				= 13

      dvElevOffset         = 14
      dvElevMin            = 15
      dvElevMax            = 16
      dvFloorSensorMin     = 17
      dvElevRetracted      = 18
      dvElevLevel2         = 19
      dvElevLevel3         = 20

      dvShoulderOffset     = 21
      dvShoulderMin        = 22
      dvShoulderMax        = 23
      dvShoulderClear      = 24
      dvShoulderTravel     = 25
      dvSCPickup           = 26     ' SC = Shoulder Cargo
      dvSCLoad             = 27
      dvSCCargoShip        = 28
      dvSCRocketLow        = 29
      dvSCRocketMid        = 30
      dvSCRocketHigh       = 31
      dvSCCatch            = 32     ' SH = Shoulder Hatch
      dvSHRocketLow        = 33
      dvSHRocketMid        = 34
      dvSHRocketHigh       = 35

      dvWristOffset        = 36
      dvWristMin           = 37
      dvWristMax           = 38
      dvWristClear         = 39
      dvWristTravel        = 40
      dvWCPickup           = 41     ' WC = Wrist Cargo
      dvWCLoad             = 42
      dvWCCargoShip        = 43
      dvWCRocketLow        = 44
      dvWCRocketMid        = 45
      dvWCRocketHigh       = 46
      dvWCCatch            = 47     ' WH = Wrist Hatch
      dvWHRocketLow        = 48
      dvWHRocketMid        = 49
      dvWHRocketHigh       = 50

      dvCargoSpeedIn       = 51
      dvCargoSpeedOut      = 52
      dvCargoSpeedRotate   = 53
      dvCargoRotateRatio   = 54
      dvCargoEjectTime     = 55
      dvCargoRotateTime    = 56
      dvVisionTargetAngle  = 57
      dvVisionCargoLoad    = 58
      dvVisionHatchLoad    = 59
      dvVisionHatchLow     = 60
      dvVisionHatchMid     = 61
      dvVisionHatchHigh    = 62
   End Enum

   Public Enum RSIndex
      rsShifterLow         = 0
      rsFootRetracted      = 1
      rsFloorFront         = 2
      rsFloorRear          = 3
      rsCargo              = 4
      rsHatchMode          = 5
      rsHatchGrab          = 6
      rsClimb              = 7
      rsNoClimb            = 8
      rsTargetFound        = 9
      rsCargoLoaded        = 10
   End Enum

   Public Enum RVindex
      rvDriveGyro          = 0
      rvDriveEncoderL      = 1
      rvDriveEncoderR      = 2
      rvDriveAmpsLeft1     = 3
      rvDriveAmpsLeft2     = 4
      rvDriveAmpsRight1    = 5
      rvDriveAmpsRight2    = 6
      rvElevatorPosition   = 7
      rvElevatorSetpoint   = 8
      rvElevatorAmps       = 9
      rvShoulderPosition   = 10
      rvShoulderSetpoint   = 11
      rvShoulderAmps       = 12
      rvWristPosition      = 13
      rvWristSetpoint      = 14
      rvWristAmps          = 15
      rvVisionStatus       = 16
      rvVisionSelect       = 17
      rvVisionAngle        = 18
      rvVisionDistance     = 19
   End Enum

   Public Enum TextBoxType
      None = 0
      AnyInteger = 1
      PositiveInteger = 2
      Float = 3
      Text = 4
      Time = 5
   End Enum

   Public Enum TrafficFrom
      Code = 0
      Host = 1
      Client = 2
   End Enum

   Public m_colorPending         As Color = Color.PaleTurquoise
   Public m_commandPrefix        As String = "2019"
   Public m_dashFile             As String
   Public m_dashValue()          As DashboardValue
   Public m_dashButton()         As DashboardButton
   Public m_dashOptions          As DashOptions
   Public m_graphList            As List(Of GraphDef) = New List(Of GraphDef)
   Public m_graphCount           As Integer
   Public m_imageDone            As Image
   Public m_imagePending         As Image
   Public m_optionsFile          As String = Application.StartupPath & "\RobotDash.cfg"
   Public m_robotConnected       As Boolean = False
   Public m_robotStatus()        as Int32
   Public m_robotStatusCount     As Integer
   Public m_robotValue()         As Double
   Public m_robotValueCount      As Integer
   Public m_robotMode            As Integer = -1
   Public m_robotSettings()      As Double
   Public m_robotSettingsCount   As Integer

   Public m_autoList             As List(Of AutoOption) = New List(Of AutoOption)

   Public m_dashForm             As DashForm
   Public m_dataForm             As DataForm
   Public m_graphForm            As GraphForm
   Public m_hostTrafficForm      As HostTrafficForm
   Public m_optionsForm          As OptionsForm
   Public m_robotStatusForm      As RobotStatusForm
   Public m_robotValuesForm      As RobotValuesForm
   Public m_shellForm            As ShellForm
   Public m_settingsForm         As SettingsForm
   Public m_tunePIDForm          As TunePidForm
   Public m_tcpClient            As TcpClient

   Public Function ConvertToDouble(value As String) As Double
      If IsNumeric(value) Then Return CDbl(value)
      Return 0
   End Function

   Public Function ConvertToInt(value As String) As Integer
      If IsNumeric(value) Then Return CInt(value)
      Return 0
   End Function

   Public Function ConvertToLong(value As String) As Long
      If IsNumeric(value) Then Return CLng(value)
      Return 0
   End Function

   Public Property DashButton(buttonIndex As Integer) As Boolean
      Get
         Dim group   As Integer = buttonIndex \ 16
         Dim index   As Integer = buttonIndex Mod 16

         If group < m_dashButtonCount
            Dim bitValue As Long = 2 ^ index
            Return ((m_dashButton(group).value And bitValue) > 0)
         Else
            Return False
         End If
      End Get

      Set(value As Boolean)
         Dim group   As Integer = buttonIndex \ 16
         Dim index   As Integer = buttonIndex Mod 16

         If group < m_dashButtonCount
            Dim bitValue As Long = 2 ^ index

            If value
               m_dashButton(group).value = m_dashButton(group).value Or bitValue
            ElseIf (m_dashButton(group).value And bitValue) > 0
               m_dashButton(group).value = m_dashButton(group).value Xor bitValue
            End If

            m_dashButton(group).sentToHost = False

            If m_tcpClient IsNot Nothing Then m_tcpClient.SendMessage("PUT:B," & group.ToString & "," & m_dashButton(group).value.ToString & "|")
            If m_dataForm IsNot Nothing Then m_dataForm.ShowData(DataForm.DataGroup.DashButton)
         End If
      End Set
   End Property

   Public Property DashValue(index As Integer, Optional sendToHost As Boolean = False) As Double
      Get
         If index >= 0 And  index < m_dashValueCount
            Return m_dashValue(index).value
         Else
            Return -1
         End If
      End Get

      Set(value As Double)
         Static newSetting As Boolean = False
         Static mesg       As String = String.Empty
         Static trim()     As Char = {"0", "."}

         If index >= 0 And index < m_dashValueCount
            If index >= m_robotSetting1 Then newSetting = True
            m_dashValue(index).value = value
            m_dashValue(index).revised = False

            If sendToHost
               m_dashValue(index).sentToHost = False

               If Len(mesg) = 0 Then mesg = "PUT:"
               mesg &= "V," & index.ToString & "," & FormatValue(value, 6) & "|"
            Else
               m_dashValue(index).sentToHost = True
            End If

         ElseIf index = -1 And sendToHost
            If Len(mesg) > 0 And m_tcpClient IsNot Nothing 
               If newSetting Then m_tcpClient.SendMessage("SET:")
               m_tcpClient.SendMessage(mesg)
            End If

            SaveDashValues()
            newSetting = False
            mesg = String.Empty
         End If

         If m_dataForm IsNot Nothing Then m_dataForm.ShowData(DataForm.DataGroup.DashValue)
      End Set
   End Property

   Public Function FormatValue(value As Double, precision As Integer) As String
      Static trim()     As Char = {"0"}
      Dim myValue       As String = FormatNumber(value, precision, TriState.True, TriState.False, TriState.False)
      Dim decimalIndex  As Integer = myValue.IndexOf(".")

      If decimalIndex >= 0
         myValue = myValue.TrimEnd(trim)
         If decimalIndex = myValue.Length - 1 Then myValue = Mid(myValue, 1, myValue.Length - 1)
      End If

      If myValue.Length = 0 Then myValue = "0"

      Return myValue
   End Function

   Public Function GetRobotStatus(statusIndex As Integer) As Boolean
      Dim group   As Integer = statusIndex \ 16
      Dim index   As Integer = statusIndex Mod 16

      If group < m_robotStatusCount
         Return ((m_robotStatus(group) And 2 ^ index) <> 0)
      Else
         Return False
      End If
   End Function

   Public Function GetRobotValue(index As Integer) As Double
      If index >= 0 And index < m_robotValueCount
         Return m_robotValue(index)
      Else
         Return 0
      End If
   End Function

   Public Sub LoadAutoList()
      ' AutoOption(Index, Description, Start, LRL, RLR, LLL, RRR)
      '     Start Bit: 0=Left, 1=Center, 2=Right

      With m_autoList
         .Clear()
         .Add(New AutoOption(1, "Drive Forward", 5, True, True, True, True))                    ' Drive Forward
         .Add(New AutoOption(11, "Left: Switch", 1, True, False, True, False))                  ' 1: Switch Left
         .Add(New AutoOption(12, "Left: Scale", 1, False, True, True, False))                   ' 1: Scale Left
         .Add(New AutoOption(13, "Left: Scale-Scale", 1, False, True, True, False))             ' 1: Scale X 2 Left
         .Add(New AutoOption(14, "Left: Scale-Switch", 1, False, False, True, False))           ' 1: Scale Switch Left
         .Add(New AutoOption(15, "Right: Scale", 1, True, False, False, True))                  ' 1: Scale Right
         .Add(New AutoOption(16, "Right: Scale-Scale", 1, True, False, False, True))            ' 1: Scale X 2 Right
         .Add(New AutoOption(17, "Drive and Turn", 1, False, False, False, True))               ' Drive Forward
         .Add(New AutoOption(21, "Left: Switch", 2, True, False, True, False))                  ' 2: Switch Left
         .Add(New AutoOption(22, "Left: Switch-Switch", 2, True, False, True, False))           ' 2: Switch X 2 Left
         .Add(New AutoOption(23, "Left: Switch-Exchange", 2, True, False, True, False))         ' 2: Switch Exchange Left
         .Add(New AutoOption(24, "Right: Switch", 2, False, True, False, True))                 ' 2: Switch Right
         .Add(New AutoOption(25, "Right: Switch-Switch", 2, False, True, False, True))          ' 2: Switch X 2 Right
         .Add(New AutoOption(26, "Right: Switch-Exchange", 2, False, True, False, True))        ' 2: Switch Exchange Right
         .Add(New AutoOption(31, "Right: Switch", 4, False, True, False, True))                 ' 3: Switch Right
         .Add(New AutoOption(32, "Right: Scale", 4, True, False, False, True))                  ' 3: Scale Right 
         .Add(New AutoOption(33, "Right: Scale-Scale", 4, True, False, False, True))            ' 3: Scale X 2 Right
         .Add(New AutoOption(34, "Right: Scale-Switch", 4, False, False, False, True))          ' 3: Scale Switch Right
         .Add(New AutoOption(35, "Left: Scale", 4, False, True, True, False))                   ' 3: Scale Left
         .Add(New AutoOption(36, "Left: Scale-Scale", 4, False, True, True, False))             ' 3: Scale X 2 Left
         .Add(New AutoOption(37, "Drive and Turn", 4, False, False, True, False))                ' Drive Forward
      End With
   End Sub

   Public Function LoadDashValues() As Boolean
      Dim fileFound        As Boolean = My.Computer.FileSystem.FileExists(m_dashFile)

      If fileFound
         Dim binaryFormatter  As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter
         Dim fileStream       As New IO.FileStream(m_dashFile, IO.FileMode.OpenOrCreate)
         Dim count            As Integer

         count = binaryFormatter.Deserialize(fileStream)

         For i As Integer = 0 To count - 1
            If i < m_dashValueCount
               m_dashValue(i) = binaryFormatter.Deserialize(fileStream)
               m_dashValue(i).revised = False
               m_dashValue(i).sentToHost = False
            Else
               Exit For
            End If
         Next

         fileStream.Close()

      Else
         Dim result As DialogResult = MessageBox.Show(m_shellForm, "The Robot Settings file '" & m_dashOptions.settingsFile & 
                                       "' could not be found.  A new file named 'Robot.set' will be created with all settings set
                                       to zero (0).", "Load Robot Settings", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

         If result = DialogResult.Cancel Then Return False

         m_dashOptions.settingsFile = "Robot.set"
         m_dashFile = Application.StartupPath & "\Settings\" & m_dashOptions.settingsFile
         ReDim m_dashValue(m_dashValueCount)
         SaveDashValues()
         SaveOptions()
      End If

      Return True
   End Function

   Public Sub LoadOptions()
      Dim fileFound        As Boolean = My.Computer.FileSystem.FileExists(m_optionsFile)
      Dim binaryFormatter  As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter
      Dim fileStream       As New IO.FileStream(m_optionsFile, IO.FileMode.OpenOrCreate)

      If Not fileFound
         With m_dashOptions
            .robotHost = "roborio-525-frc.local"
            .robotPort = 5801
            .dashFormZoom = 100
            .buttonsEnabled = False
            .settingsFile = "Robot.set"
         End With

         m_graphCount = 7
         m_graphList.Clear()
         m_graphList.Add(New GraphDef(RVindex.rvDriveAmpsLeft1, "Drive Left 1 Amps"))
         m_graphList.Add(New GraphDef(RVindex.rvDriveAmpsLeft2, "Drive Left 2 Amps"))
         m_graphList.Add(New GraphDef(RVindex.rvDriveAmpsRight1, "Drive Right 1 Amps"))
         m_graphList.Add(New GraphDef(RVindex.rvDriveAmpsRight2, "Drive Right 2 Amps"))
         m_graphList.Add(New GraphDef(RVindex.rvElevatorAmps, "Elevator Amps"))
         m_graphList.Add(New GraphDef(RVindex.rvShoulderAmps, "Shoulder Amps"))
         m_graphList.Add(New GraphDef(RVindex.rvWristAmps, "Wrist Amps"))

         binaryFormatter.Serialize(fileStream, m_dashOptions)
         binaryFormatter.Serialize(fileStream, m_graphCount)
         For i As Integer = 0 To m_graphCount - 1
            binaryFormatter.Serialize(fileStream, m_graphList.Item(i))
         Next

         fileStream.Position = 0
      End If

      m_dashOptions = binaryFormatter.Deserialize(fileStream)
      m_graphCount = binaryFormatter.Deserialize(fileStream)
      m_graphList.Clear()

      Dim def As GraphDef
      For i As Integer = 0 To m_graphCount - 1
         def = binaryFormatter.Deserialize(fileStream)
         m_graphList.Add(def)
      Next

      fileStream.Close()
   End Sub

   Public Sub ResizeControl(myControl As Control, scaleFactor As Single)
      Dim font As New Font(myControl.Font.FontFamily, myControl.Font.Size * scaleFactor, myControl.Font.Style)
      
      myControl.Font = font
      myControl.Left *= scaleFactor
      myControl.Top *= scaleFactor
      myControl.Height *= scaleFactor
      myControl.Width *= scaleFactor

      If TypeOf myControl Is DataGridView
         Dim grid          As DataGridView = CType(myControl, DataGridView)
         Dim totalWidth    As Integer = 0

         grid.ColumnHeadersHeight *= scaleFactor

         For col As Integer = 0 To grid.ColumnCount - 1
            If col = grid.ColumnCount - 1
               grid.Columns(col).Width = myControl.Width - totalWidth - 20
            ElseIf grid.Columns(col).Visible
               grid.Columns(col).Width *= scaleFactor
               totalWidth += grid.Columns(col).Width
            End If
         Next

         For row As Integer = 0 To grid.RowCount - 1
            grid.Rows(row).Height *= scaleFactor
         Next

         grid.RowTemplate.Height *= scaleFactor
      End If
   End Sub

   Public Function RobotModeCaption(mode As Integer) As String
      Dim caption As String = String.Empty

      Select mode
         Case 0:     caption = "BOOT-UP"
         Case 1:     caption = "DISABLED"
         Case 2:     caption = "AUTONOMOUS"
         Case 3:     caption = "TELEOPERATED"
         Case 4:     caption = "TEST"
      End Select

      Return caption
   End Function

   Public Sub SaveDashValues()
      Dim binaryFormatter  As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter
      Dim fileStream       As New IO.FileStream(m_dashFile, IO.FileMode.OpenOrCreate)

      binaryFormatter.Serialize(fileStream, m_dashValueCount)

      For i As Integer = 0 To m_dashValueCount - 1
         binaryFormatter.Serialize(fileStream, m_dashValue(i))
      Next

      fileStream.Close()
   End Sub

   Public Sub SaveOptions()
      Dim binaryFormatter  As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter
      Dim fileStream       As New IO.FileStream(m_optionsFile, IO.FileMode.OpenOrCreate)

      binaryFormatter.Serialize(fileStream, m_dashOptions)
      binaryFormatter.Serialize(fileStream, m_graphCount)

      For i As Integer = 0 To m_graphCount - 1
         binaryFormatter.Serialize(fileStream, m_graphList.Item(i))
      Next

      fileStream.Close()
   End Sub

   Public Sub SetAppWindowState(state As FormWindowState)
      If state = FormWindowState.Minimized
         If m_dataForm IsNot Nothing
            m_dataForm.WindowState = state
            m_dataForm.Visible = False
         End If

         If m_optionsForm IsNot Nothing
            m_optionsForm.WindowState = state
            m_optionsForm.Visible = False
         End If

         If m_graphForm IsNot Nothing
            m_graphForm.WindowState = state
            m_graphForm.Visible = False
         End If

         If m_hostTrafficForm IsNot Nothing
            m_hostTrafficForm.WindowState = state
            m_hostTrafficForm.Visible = False
         End If

         If m_robotStatusForm IsNot Nothing
            m_robotStatusForm.WindowState = state
            m_robotStatusForm.Visible = False
         End If

         If m_robotValuesForm IsNot Nothing
            m_robotValuesForm.WindowState = state
            m_robotValuesForm.Visible = False
         End If

         If m_settingsForm IsNot Nothing
            m_settingsForm.WindowState = state
            m_settingsForm.Visible = False
         End If

         If m_tunePIDForm IsNot Nothing
            m_tunePIDForm.WindowState = state
            m_tunePIDForm.Visible = False
         End If

      Else
         If m_dataForm IsNot Nothing
            m_dataForm.Visible = True
            m_dataForm.WindowState = state
         End If

         If m_optionsForm IsNot Nothing
            m_optionsForm.Visible = True
            m_optionsForm.WindowState = state
         End If

         If m_graphForm IsNot Nothing
            m_graphForm.Visible = True
            m_graphForm.WindowState = state
         End If

         If m_hostTrafficForm IsNot Nothing
            m_hostTrafficForm.Visible = True
            m_hostTrafficForm.WindowState = state
         End If

         If m_robotStatusForm IsNot Nothing
            m_robotStatusForm.Visible = True
            m_robotStatusForm.WindowState = state
         End If

         If m_robotValuesForm IsNot Nothing
            m_robotValuesForm.Visible = True
            m_robotValuesForm.WindowState = state
         End If

         If m_settingsForm IsNot Nothing
            m_settingsForm.Visible = True
            m_settingsForm.WindowState = state
         End If

         If m_tunePIDForm IsNot Nothing
            m_tunePIDForm.Visible = True
            m_tunePIDForm.WindowState = state
         End If
      End If
   End Sub

   Public Sub SetFormZoom(ByVal newZoom As Integer, ByVal oldZoom As Integer, myForm As Form)
      Dim scaleFactor   As Single = newZoom / oldZoom

      myForm.Height *= scaleFactor
      myForm.Width *= scaleFactor

      For Each myControl As Control In myForm.Controls
         ResizeControl(myControl, scaleFactor)

         If TypeOf myControl Is Panel
            Dim myPanel As Panel = CType(myControl, Panel)

            For Each child As Control In myPanel.Controls
               ResizeControl(child, scaleFactor)

               If TypeOf child Is Panel
                  Dim childPanel As Panel = CType(child, Panel)

                  For Each grandchild As Control In childPanel.Controls
                     ResizeControl(grandchild, scaleFactor)
                  Next
               End If
            Next
         End If
      Next
   End Sub

   Public Sub StartClient()
      If m_tcpClient Is Nothing Then m_tcpClient = New TcpClient
      m_tcpClient.Start()
   End Sub

   Public Sub StopClient()
      If m_tcpClient IsNot Nothing Then m_tcpClient.Shutdown()
   End Sub

   Public Function TextBoxKeyPress(ByVal boxType As TextBoxType, ByVal newChar As Char) As Char
      ' TextBoxType:  0=None; 1=AnyInteger; 2=PositiveInteger; 3=Float; 4=Text; 5=Time

      Dim myChar As Char = newChar

      Select Case Asc(myChar)
         Case 8, 48 To 57        ' Backspace, 0 to 9
         Case 45                 ' - (minus)
            Select boxType
               Case TextBoxType.PositiveInteger, TextBoxType.Time
                  myChar = ""
            End Select
         Case 46                 ' . (Period)
            Select boxType
               Case TextBoxType.AnyInteger, TextBoxType.PositiveInteger, TextBoxType.Time
                  myChar = ""
            End Select
         Case 58                 ' : (colon)
            Select boxType
               Case TextBoxType.AnyInteger, TextBoxType.PositiveInteger, TextBoxType.Float
                  myChar = ""
            End Select
         Case 124                ' | (pipe)
            myChar = ""
         Case Else
            If boxType <> TextBoxType.Text Then myChar = ""
      End Select

      Return myChar
   End Function

End Module
