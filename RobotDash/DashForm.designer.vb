<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashForm
   Inherits System.Windows.Forms.Form

   'Form overrides dispose to clean up the component list.
   <System.Diagnostics.DebuggerNonUserCode()> _
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      Try
         If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
         End If
      Finally
         MyBase.Dispose(disposing)
      End Try
   End Sub

   'Required by the Windows Form Designer
   Private components As System.ComponentModel.IContainer

   'NOTE: The following procedure is required by the Windows Form Designer
   'It can be modified using the Windows Form Designer.  
   'Do not modify it using the code editor.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashForm))
      Me.DashMenu = New System.Windows.Forms.MenuStrip()
      Me.MenuFile = New System.Windows.Forms.ToolStripMenuItem()
      Me.FileReconnect = New System.Windows.Forms.ToolStripMenuItem()
      Me.FileSeparator = New System.Windows.Forms.ToolStripSeparator()
      Me.FileExit = New System.Windows.Forms.ToolStripMenuItem()
      Me.MenuView = New System.Windows.Forms.ToolStripMenuItem()
      Me.ViewSettings = New System.Windows.Forms.ToolStripMenuItem()
      Me.ViewRobotStatus = New System.Windows.Forms.ToolStripMenuItem()
      Me.ViewRobotValues = New System.Windows.Forms.ToolStripMenuItem()
      Me.ViewGraph = New System.Windows.Forms.ToolStripMenuItem()
      Me.ViewTune = New System.Windows.Forms.ToolStripMenuItem()
      Me.ViewSeparator1 = New System.Windows.Forms.ToolStripSeparator()
      Me.ViewData = New System.Windows.Forms.ToolStripMenuItem()
      Me.ViewTraffic = New System.Windows.Forms.ToolStripMenuItem()
      Me.ViewOptions = New System.Windows.Forms.ToolStripMenuItem()
      Me.LedRobot = New System.Windows.Forms.Label()
      Me.LabelStatus = New System.Windows.Forms.Label()
      Me.LabelDrive = New System.Windows.Forms.Label()
      Me.PanelDrive = New System.Windows.Forms.Panel()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.LabelDriveRight2 = New System.Windows.Forms.Label()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.LabelDriveLeft2 = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label6 = New System.Windows.Forms.Label()
      Me.LabelShift = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.Label0 = New System.Windows.Forms.Label()
      Me.LabelDriveRight1 = New System.Windows.Forms.Label()
      Me.LabelGyro = New System.Windows.Forms.Label()
      Me.LabelDriveLeft1 = New System.Windows.Forms.Label()
      Me.LabelEncoderRight = New System.Windows.Forms.Label()
      Me.LabelEncoderLeft = New System.Windows.Forms.Label()
      Me.Label7 = New System.Windows.Forms.Label()
      Me.Label8 = New System.Windows.Forms.Label()
      Me.Label5 = New System.Windows.Forms.Label()
      Me.TimerClick = New System.Windows.Forms.Timer(Me.components)
      Me.PanelArm = New System.Windows.Forms.Panel()
      Me.LabelCargo = New System.Windows.Forms.Label()
      Me.Label23 = New System.Windows.Forms.Label()
      Me.Label22 = New System.Windows.Forms.Label()
      Me.LabelHatch = New System.Windows.Forms.Label()
      Me.Label21 = New System.Windows.Forms.Label()
      Me.Label20 = New System.Windows.Forms.Label()
      Me.LabelHandMode = New System.Windows.Forms.Label()
      Me.Label16 = New System.Windows.Forms.Label()
      Me.LabelWristAmps = New System.Windows.Forms.Label()
      Me.LabelWristPosition = New System.Windows.Forms.Label()
      Me.LabelWristSetpoint = New System.Windows.Forms.Label()
      Me.Label15 = New System.Windows.Forms.Label()
      Me.Label19 = New System.Windows.Forms.Label()
      Me.LabelShoulderAmps = New System.Windows.Forms.Label()
      Me.Label18 = New System.Windows.Forms.Label()
      Me.LabelShoulderPosition = New System.Windows.Forms.Label()
      Me.Label17 = New System.Windows.Forms.Label()
      Me.LabelShoulderSetpoint = New System.Windows.Forms.Label()
      Me.TimerRestart = New System.Windows.Forms.Timer(Me.components)
      Me.ButtonDataCapture = New System.Windows.Forms.Button()
      Me.PanelElevator = New System.Windows.Forms.Panel()
      Me.LabelFloorRear = New System.Windows.Forms.Label()
      Me.LabelFloorFront = New System.Windows.Forms.Label()
      Me.Label14 = New System.Windows.Forms.Label()
      Me.Label12 = New System.Windows.Forms.Label()
      Me.LabelElevFoot = New System.Windows.Forms.Label()
      Me.Label10 = New System.Windows.Forms.Label()
      Me.Label13 = New System.Windows.Forms.Label()
      Me.LabelElevAmps = New System.Windows.Forms.Label()
      Me.Label11 = New System.Windows.Forms.Label()
      Me.LabelElevPosition = New System.Windows.Forms.Label()
      Me.Label9 = New System.Windows.Forms.Label()
      Me.LabelElevSetpoint = New System.Windows.Forms.Label()
      Me.LabelElevator = New System.Windows.Forms.Label()
      Me.LabelArm = New System.Windows.Forms.Label()
      Me.PanelVision = New System.Windows.Forms.Panel()
      Me.LabelTarget = New System.Windows.Forms.Label()
      Me.Label24 = New System.Windows.Forms.Label()
      Me.Label26 = New System.Windows.Forms.Label()
      Me.LabelTargetDistance = New System.Windows.Forms.Label()
      Me.Label25 = New System.Windows.Forms.Label()
      Me.LabelTargetAngle = New System.Windows.Forms.Label()
      Me.LabelVision = New System.Windows.Forms.Label()
      Me.Label28 = New System.Windows.Forms.Label()
      Me.ListHatch = New System.Windows.Forms.ComboBox()
      Me.Label29 = New System.Windows.Forms.Label()
      Me.ListLoad = New System.Windows.Forms.ComboBox()
      Me.ButtonVisionAuto = New System.Windows.Forms.Button()
      Me.Label27 = New System.Windows.Forms.Label()
      Me.ButtonSSAuto = New System.Windows.Forms.Button()
      Me.DashMenu.SuspendLayout
      Me.PanelDrive.SuspendLayout
      Me.PanelArm.SuspendLayout
      Me.PanelElevator.SuspendLayout
      Me.PanelVision.SuspendLayout
      Me.SuspendLayout
      '
      'DashMenu
      '
      Me.DashMenu.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.DashMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuFile, Me.MenuView})
      Me.DashMenu.Location = New System.Drawing.Point(0, 0)
      Me.DashMenu.Name = "DashMenu"
      Me.DashMenu.Size = New System.Drawing.Size(701, 24)
      Me.DashMenu.TabIndex = 0
      Me.DashMenu.Text = "MenuStrip1"
      '
      'MenuFile
      '
      Me.MenuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileReconnect, Me.FileSeparator, Me.FileExit})
      Me.MenuFile.Name = "MenuFile"
      Me.MenuFile.Size = New System.Drawing.Size(40, 20)
      Me.MenuFile.Text = "File"
      '
      'FileReconnect
      '
      Me.FileReconnect.Name = "FileReconnect"
      Me.FileReconnect.Size = New System.Drawing.Size(139, 22)
      Me.FileReconnect.Text = "Reconnect"
      '
      'FileSeparator
      '
      Me.FileSeparator.Name = "FileSeparator"
      Me.FileSeparator.Size = New System.Drawing.Size(136, 6)
      '
      'FileExit
      '
      Me.FileExit.Name = "FileExit"
      Me.FileExit.Size = New System.Drawing.Size(139, 22)
      Me.FileExit.Text = "Exit"
      '
      'MenuView
      '
      Me.MenuView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewSettings, Me.ViewRobotStatus, Me.ViewRobotValues, Me.ViewGraph, Me.ViewTune, Me.ViewSeparator1, Me.ViewData, Me.ViewTraffic, Me.ViewOptions})
      Me.MenuView.Name = "MenuView"
      Me.MenuView.Size = New System.Drawing.Size(49, 20)
      Me.MenuView.Text = "View"
      '
      'ViewSettings
      '
      Me.ViewSettings.Name = "ViewSettings"
      Me.ViewSettings.Size = New System.Drawing.Size(167, 22)
      Me.ViewSettings.Text = "Robot Settings"
      '
      'ViewRobotStatus
      '
      Me.ViewRobotStatus.Name = "ViewRobotStatus"
      Me.ViewRobotStatus.Size = New System.Drawing.Size(167, 22)
      Me.ViewRobotStatus.Text = "Robot Status"
      '
      'ViewRobotValues
      '
      Me.ViewRobotValues.Name = "ViewRobotValues"
      Me.ViewRobotValues.Size = New System.Drawing.Size(167, 22)
      Me.ViewRobotValues.Text = "Robot Values"
      '
      'ViewGraph
      '
      Me.ViewGraph.Name = "ViewGraph"
      Me.ViewGraph.Size = New System.Drawing.Size(167, 22)
      Me.ViewGraph.Text = "Graph Plotter"
      '
      'ViewTune
      '
      Me.ViewTune.Name = "ViewTune"
      Me.ViewTune.Size = New System.Drawing.Size(167, 22)
      Me.ViewTune.Text = "Tune PID"
      '
      'ViewSeparator1
      '
      Me.ViewSeparator1.Name = "ViewSeparator1"
      Me.ViewSeparator1.Size = New System.Drawing.Size(164, 6)
      '
      'ViewData
      '
      Me.ViewData.Name = "ViewData"
      Me.ViewData.Size = New System.Drawing.Size(167, 22)
      Me.ViewData.Text = "Data Tables"
      '
      'ViewTraffic
      '
      Me.ViewTraffic.Name = "ViewTraffic"
      Me.ViewTraffic.Size = New System.Drawing.Size(167, 22)
      Me.ViewTraffic.Text = "Host Traffic"
      '
      'ViewOptions
      '
      Me.ViewOptions.Name = "ViewOptions"
      Me.ViewOptions.Size = New System.Drawing.Size(167, 22)
      Me.ViewOptions.Text = "Options"
      '
      'LedRobot
      '
      Me.LedRobot.BackColor = System.Drawing.Color.WhiteSmoke
      Me.LedRobot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LedRobot.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LedRobot.Location = New System.Drawing.Point(637, 0)
      Me.LedRobot.Name = "LedRobot"
      Me.LedRobot.Size = New System.Drawing.Size(58, 24)
      Me.LedRobot.TabIndex = 24
      Me.LedRobot.Text = "Robot"
      Me.LedRobot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'LabelStatus
      '
      Me.LabelStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(252,Byte),Integer), CType(CType(252,Byte),Integer), CType(CType(252,Byte),Integer))
      Me.LabelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelStatus.ForeColor = System.Drawing.Color.Red
      Me.LabelStatus.Location = New System.Drawing.Point(486, 0)
      Me.LabelStatus.Name = "LabelStatus"
      Me.LabelStatus.Size = New System.Drawing.Size(146, 24)
      Me.LabelStatus.TabIndex = 25
      Me.LabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'LabelDrive
      '
      Me.LabelDrive.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelDrive.Location = New System.Drawing.Point(15, 58)
      Me.LabelDrive.Name = "LabelDrive"
      Me.LabelDrive.Size = New System.Drawing.Size(72, 20)
      Me.LabelDrive.TabIndex = 40
      Me.LabelDrive.Text = "DRIVE"
      Me.LabelDrive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'PanelDrive
      '
      Me.PanelDrive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.PanelDrive.Controls.Add(Me.Label4)
      Me.PanelDrive.Controls.Add(Me.LabelDriveRight2)
      Me.PanelDrive.Controls.Add(Me.Label3)
      Me.PanelDrive.Controls.Add(Me.LabelDriveLeft2)
      Me.PanelDrive.Controls.Add(Me.Label1)
      Me.PanelDrive.Controls.Add(Me.Label6)
      Me.PanelDrive.Controls.Add(Me.LabelShift)
      Me.PanelDrive.Controls.Add(Me.Label2)
      Me.PanelDrive.Controls.Add(Me.Label0)
      Me.PanelDrive.Controls.Add(Me.LabelDriveRight1)
      Me.PanelDrive.Controls.Add(Me.LabelGyro)
      Me.PanelDrive.Controls.Add(Me.LabelDriveLeft1)
      Me.PanelDrive.Controls.Add(Me.LabelEncoderRight)
      Me.PanelDrive.Controls.Add(Me.LabelEncoderLeft)
      Me.PanelDrive.Controls.Add(Me.Label7)
      Me.PanelDrive.Controls.Add(Me.Label8)
      Me.PanelDrive.Controls.Add(Me.Label5)
      Me.PanelDrive.Location = New System.Drawing.Point(5, 68)
      Me.PanelDrive.Name = "PanelDrive"
      Me.PanelDrive.Size = New System.Drawing.Size(375, 122)
      Me.PanelDrive.TabIndex = 3
      '
      'Label4
      '
      Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label4.Location = New System.Drawing.Point(210, 36)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(65, 20)
      Me.Label4.TabIndex = 66
      Me.Label4.Text = "Right 2"
      Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'LabelDriveRight2
      '
      Me.LabelDriveRight2.BackColor = System.Drawing.Color.White
      Me.LabelDriveRight2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelDriveRight2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelDriveRight2.ForeColor = System.Drawing.Color.Black
      Me.LabelDriveRight2.Location = New System.Drawing.Point(278, 35)
      Me.LabelDriveRight2.Name = "LabelDriveRight2"
      Me.LabelDriveRight2.Size = New System.Drawing.Size(80, 20)
      Me.LabelDriveRight2.TabIndex = 65
      Me.LabelDriveRight2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label3
      '
      Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label3.Location = New System.Drawing.Point(70, 36)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(50, 20)
      Me.Label3.TabIndex = 64
      Me.Label3.Text = "Left 2"
      Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'LabelDriveLeft2
      '
      Me.LabelDriveLeft2.BackColor = System.Drawing.Color.White
      Me.LabelDriveLeft2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelDriveLeft2.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelDriveLeft2.ForeColor = System.Drawing.Color.Black
      Me.LabelDriveLeft2.Location = New System.Drawing.Point(124, 35)
      Me.LabelDriveLeft2.Name = "LabelDriveLeft2"
      Me.LabelDriveLeft2.Size = New System.Drawing.Size(80, 20)
      Me.LabelDriveLeft2.TabIndex = 63
      Me.LabelDriveLeft2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label1
      '
      Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label1.Location = New System.Drawing.Point(70, 11)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(50, 20)
      Me.Label1.TabIndex = 62
      Me.Label1.Text = "Left 1"
      Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'Label6
      '
      Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label6.Location = New System.Drawing.Point(224, 63)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(50, 20)
      Me.Label6.TabIndex = 61
      Me.Label6.Text = "Right"
      Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'LabelShift
      '
      Me.LabelShift.BackColor = System.Drawing.Color.White
      Me.LabelShift.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelShift.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelShift.ForeColor = System.Drawing.Color.DarkGreen
      Me.LabelShift.Location = New System.Drawing.Point(278, 89)
      Me.LabelShift.Name = "LabelShift"
      Me.LabelShift.Size = New System.Drawing.Size(80, 20)
      Me.LabelShift.TabIndex = 60
      Me.LabelShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label2
      '
      Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label2.Location = New System.Drawing.Point(210, 11)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(65, 20)
      Me.Label2.TabIndex = 59
      Me.Label2.Text = "Right 1"
      Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'Label0
      '
      Me.Label0.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label0.Location = New System.Drawing.Point(8, 11)
      Me.Label0.Name = "Label0"
      Me.Label0.Size = New System.Drawing.Size(58, 35)
      Me.Label0.TabIndex = 58
      Me.Label0.Text = "MOTOR AMPS:"
      Me.Label0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'LabelDriveRight1
      '
      Me.LabelDriveRight1.BackColor = System.Drawing.Color.White
      Me.LabelDriveRight1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelDriveRight1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelDriveRight1.ForeColor = System.Drawing.Color.Black
      Me.LabelDriveRight1.Location = New System.Drawing.Point(278, 10)
      Me.LabelDriveRight1.Name = "LabelDriveRight1"
      Me.LabelDriveRight1.Size = New System.Drawing.Size(80, 20)
      Me.LabelDriveRight1.TabIndex = 57
      Me.LabelDriveRight1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'LabelGyro
      '
      Me.LabelGyro.BackColor = System.Drawing.Color.White
      Me.LabelGyro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelGyro.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelGyro.Location = New System.Drawing.Point(124, 89)
      Me.LabelGyro.Name = "LabelGyro"
      Me.LabelGyro.Size = New System.Drawing.Size(80, 20)
      Me.LabelGyro.TabIndex = 40
      Me.LabelGyro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'LabelDriveLeft1
      '
      Me.LabelDriveLeft1.BackColor = System.Drawing.Color.White
      Me.LabelDriveLeft1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelDriveLeft1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelDriveLeft1.ForeColor = System.Drawing.Color.Black
      Me.LabelDriveLeft1.Location = New System.Drawing.Point(124, 10)
      Me.LabelDriveLeft1.Name = "LabelDriveLeft1"
      Me.LabelDriveLeft1.Size = New System.Drawing.Size(80, 20)
      Me.LabelDriveLeft1.TabIndex = 56
      Me.LabelDriveLeft1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'LabelEncoderRight
      '
      Me.LabelEncoderRight.BackColor = System.Drawing.Color.White
      Me.LabelEncoderRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelEncoderRight.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelEncoderRight.Location = New System.Drawing.Point(278, 62)
      Me.LabelEncoderRight.Name = "LabelEncoderRight"
      Me.LabelEncoderRight.Size = New System.Drawing.Size(80, 20)
      Me.LabelEncoderRight.TabIndex = 39
      Me.LabelEncoderRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'LabelEncoderLeft
      '
      Me.LabelEncoderLeft.BackColor = System.Drawing.Color.White
      Me.LabelEncoderLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelEncoderLeft.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelEncoderLeft.Location = New System.Drawing.Point(124, 62)
      Me.LabelEncoderLeft.Name = "LabelEncoderLeft"
      Me.LabelEncoderLeft.Size = New System.Drawing.Size(80, 20)
      Me.LabelEncoderLeft.TabIndex = 38
      Me.LabelEncoderLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label7
      '
      Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label7.Location = New System.Drawing.Point(8, 89)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(98, 20)
      Me.Label7.TabIndex = 37
      Me.Label7.Text = "GYROSCOPE:"
      Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'Label8
      '
      Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label8.Location = New System.Drawing.Point(212, 89)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(63, 20)
      Me.Label8.TabIndex = 36
      Me.Label8.Text = "SHIFT:"
      Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'Label5
      '
      Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label5.Location = New System.Drawing.Point(8, 63)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(112, 20)
      Me.Label5.TabIndex = 35
      Me.Label5.Text = "ENCODER:  Left"
      Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'TimerClick
      '
      '
      'PanelArm
      '
      Me.PanelArm.BackColor = System.Drawing.Color.FromArgb(CType(CType(225,Byte),Integer), CType(CType(230,Byte),Integer), CType(CType(245,Byte),Integer))
      Me.PanelArm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.PanelArm.Controls.Add(Me.LabelCargo)
      Me.PanelArm.Controls.Add(Me.Label23)
      Me.PanelArm.Controls.Add(Me.Label22)
      Me.PanelArm.Controls.Add(Me.LabelHatch)
      Me.PanelArm.Controls.Add(Me.Label21)
      Me.PanelArm.Controls.Add(Me.Label20)
      Me.PanelArm.Controls.Add(Me.LabelHandMode)
      Me.PanelArm.Controls.Add(Me.Label16)
      Me.PanelArm.Controls.Add(Me.LabelWristAmps)
      Me.PanelArm.Controls.Add(Me.LabelWristPosition)
      Me.PanelArm.Controls.Add(Me.LabelWristSetpoint)
      Me.PanelArm.Controls.Add(Me.Label15)
      Me.PanelArm.Controls.Add(Me.Label19)
      Me.PanelArm.Controls.Add(Me.LabelShoulderAmps)
      Me.PanelArm.Controls.Add(Me.Label18)
      Me.PanelArm.Controls.Add(Me.LabelShoulderPosition)
      Me.PanelArm.Controls.Add(Me.Label17)
      Me.PanelArm.Controls.Add(Me.LabelShoulderSetpoint)
      Me.PanelArm.Location = New System.Drawing.Point(387, 68)
      Me.PanelArm.Name = "PanelArm"
      Me.PanelArm.Size = New System.Drawing.Size(308, 166)
      Me.PanelArm.TabIndex = 5
      '
      'LabelCargo
      '
      Me.LabelCargo.BackColor = System.Drawing.Color.White
      Me.LabelCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelCargo.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelCargo.ForeColor = System.Drawing.Color.DarkGreen
      Me.LabelCargo.Location = New System.Drawing.Point(212, 139)
      Me.LabelCargo.Name = "LabelCargo"
      Me.LabelCargo.Size = New System.Drawing.Size(80, 20)
      Me.LabelCargo.TabIndex = 80
      Me.LabelCargo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label23
      '
      Me.Label23.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label23.Location = New System.Drawing.Point(227, 118)
      Me.Label23.Name = "Label23"
      Me.Label23.Size = New System.Drawing.Size(50, 20)
      Me.Label23.TabIndex = 79
      Me.Label23.Text = "Cargo"
      Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'Label22
      '
      Me.Label22.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label22.Location = New System.Drawing.Point(139, 118)
      Me.Label22.Name = "Label22"
      Me.Label22.Size = New System.Drawing.Size(50, 20)
      Me.Label22.TabIndex = 78
      Me.Label22.Text = "Hatch"
      Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'LabelHatch
      '
      Me.LabelHatch.BackColor = System.Drawing.Color.White
      Me.LabelHatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelHatch.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelHatch.ForeColor = System.Drawing.Color.Black
      Me.LabelHatch.Location = New System.Drawing.Point(124, 138)
      Me.LabelHatch.Name = "LabelHatch"
      Me.LabelHatch.Size = New System.Drawing.Size(80, 20)
      Me.LabelHatch.TabIndex = 77
      Me.LabelHatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label21
      '
      Me.Label21.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label21.Location = New System.Drawing.Point(65, 98)
      Me.Label21.Name = "Label21"
      Me.Label21.Size = New System.Drawing.Size(50, 20)
      Me.Label21.TabIndex = 76
      Me.Label21.Text = "Mode"
      Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'Label20
      '
      Me.Label20.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label20.Location = New System.Drawing.Point(8, 98)
      Me.Label20.Name = "Label20"
      Me.Label20.Size = New System.Drawing.Size(51, 20)
      Me.Label20.TabIndex = 75
      Me.Label20.Text = "HAND:"
      Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'LabelHandMode
      '
      Me.LabelHandMode.BackColor = System.Drawing.Color.White
      Me.LabelHandMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelHandMode.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelHandMode.ForeColor = System.Drawing.Color.Black
      Me.LabelHandMode.Location = New System.Drawing.Point(124, 97)
      Me.LabelHandMode.Name = "LabelHandMode"
      Me.LabelHandMode.Size = New System.Drawing.Size(168, 20)
      Me.LabelHandMode.TabIndex = 74
      Me.LabelHandMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label16
      '
      Me.Label16.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label16.Location = New System.Drawing.Point(212, 2)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(80, 20)
      Me.Label16.TabIndex = 73
      Me.Label16.Text = "Wrist"
      Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'LabelWristAmps
      '
      Me.LabelWristAmps.BackColor = System.Drawing.Color.White
      Me.LabelWristAmps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelWristAmps.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelWristAmps.ForeColor = System.Drawing.Color.Black
      Me.LabelWristAmps.Location = New System.Drawing.Point(212, 72)
      Me.LabelWristAmps.Name = "LabelWristAmps"
      Me.LabelWristAmps.Size = New System.Drawing.Size(80, 20)
      Me.LabelWristAmps.TabIndex = 72
      Me.LabelWristAmps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'LabelWristPosition
      '
      Me.LabelWristPosition.BackColor = System.Drawing.Color.White
      Me.LabelWristPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelWristPosition.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelWristPosition.ForeColor = System.Drawing.Color.Black
      Me.LabelWristPosition.Location = New System.Drawing.Point(212, 47)
      Me.LabelWristPosition.Name = "LabelWristPosition"
      Me.LabelWristPosition.Size = New System.Drawing.Size(80, 20)
      Me.LabelWristPosition.TabIndex = 71
      Me.LabelWristPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'LabelWristSetpoint
      '
      Me.LabelWristSetpoint.BackColor = System.Drawing.Color.White
      Me.LabelWristSetpoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelWristSetpoint.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelWristSetpoint.ForeColor = System.Drawing.Color.Black
      Me.LabelWristSetpoint.Location = New System.Drawing.Point(212, 22)
      Me.LabelWristSetpoint.Name = "LabelWristSetpoint"
      Me.LabelWristSetpoint.Size = New System.Drawing.Size(80, 20)
      Me.LabelWristSetpoint.TabIndex = 70
      Me.LabelWristSetpoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label15
      '
      Me.Label15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label15.Location = New System.Drawing.Point(124, 2)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(80, 20)
      Me.Label15.TabIndex = 69
      Me.Label15.Text = "Shoulder"
      Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label19
      '
      Me.Label19.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label19.Location = New System.Drawing.Point(8, 73)
      Me.Label19.Name = "Label19"
      Me.Label19.Size = New System.Drawing.Size(107, 20)
      Me.Label19.TabIndex = 68
      Me.Label19.Text = "MOTOR AMPS:"
      Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'LabelShoulderAmps
      '
      Me.LabelShoulderAmps.BackColor = System.Drawing.Color.White
      Me.LabelShoulderAmps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelShoulderAmps.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelShoulderAmps.ForeColor = System.Drawing.Color.Black
      Me.LabelShoulderAmps.Location = New System.Drawing.Point(124, 72)
      Me.LabelShoulderAmps.Name = "LabelShoulderAmps"
      Me.LabelShoulderAmps.Size = New System.Drawing.Size(80, 20)
      Me.LabelShoulderAmps.TabIndex = 67
      Me.LabelShoulderAmps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label18
      '
      Me.Label18.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label18.Location = New System.Drawing.Point(8, 48)
      Me.Label18.Name = "Label18"
      Me.Label18.Size = New System.Drawing.Size(107, 20)
      Me.Label18.TabIndex = 66
      Me.Label18.Text = "POSITION:"
      Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'LabelShoulderPosition
      '
      Me.LabelShoulderPosition.BackColor = System.Drawing.Color.White
      Me.LabelShoulderPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelShoulderPosition.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelShoulderPosition.ForeColor = System.Drawing.Color.Black
      Me.LabelShoulderPosition.Location = New System.Drawing.Point(124, 47)
      Me.LabelShoulderPosition.Name = "LabelShoulderPosition"
      Me.LabelShoulderPosition.Size = New System.Drawing.Size(80, 20)
      Me.LabelShoulderPosition.TabIndex = 65
      Me.LabelShoulderPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label17
      '
      Me.Label17.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label17.Location = New System.Drawing.Point(8, 23)
      Me.Label17.Name = "Label17"
      Me.Label17.Size = New System.Drawing.Size(107, 20)
      Me.Label17.TabIndex = 64
      Me.Label17.Text = "SETPOINT:"
      Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'LabelShoulderSetpoint
      '
      Me.LabelShoulderSetpoint.BackColor = System.Drawing.Color.White
      Me.LabelShoulderSetpoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelShoulderSetpoint.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelShoulderSetpoint.ForeColor = System.Drawing.Color.Black
      Me.LabelShoulderSetpoint.Location = New System.Drawing.Point(124, 22)
      Me.LabelShoulderSetpoint.Name = "LabelShoulderSetpoint"
      Me.LabelShoulderSetpoint.Size = New System.Drawing.Size(80, 20)
      Me.LabelShoulderSetpoint.TabIndex = 63
      Me.LabelShoulderSetpoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'TimerRestart
      '
      Me.TimerRestart.Interval = 1000
      '
      'ButtonDataCapture
      '
      Me.ButtonDataCapture.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ButtonDataCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.ButtonDataCapture.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.ButtonDataCapture.Location = New System.Drawing.Point(371, 0)
      Me.ButtonDataCapture.Name = "ButtonDataCapture"
      Me.ButtonDataCapture.Size = New System.Drawing.Size(110, 24)
      Me.ButtonDataCapture.TabIndex = 7
      Me.ButtonDataCapture.Tag = "1"
      Me.ButtonDataCapture.Text = "Data Capture"
      Me.ButtonDataCapture.UseVisualStyleBackColor = false
      '
      'PanelElevator
      '
      Me.PanelElevator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.PanelElevator.Controls.Add(Me.LabelFloorRear)
      Me.PanelElevator.Controls.Add(Me.LabelFloorFront)
      Me.PanelElevator.Controls.Add(Me.Label14)
      Me.PanelElevator.Controls.Add(Me.Label12)
      Me.PanelElevator.Controls.Add(Me.LabelElevFoot)
      Me.PanelElevator.Controls.Add(Me.Label10)
      Me.PanelElevator.Controls.Add(Me.Label13)
      Me.PanelElevator.Controls.Add(Me.LabelElevAmps)
      Me.PanelElevator.Controls.Add(Me.Label11)
      Me.PanelElevator.Controls.Add(Me.LabelElevPosition)
      Me.PanelElevator.Controls.Add(Me.Label9)
      Me.PanelElevator.Controls.Add(Me.LabelElevSetpoint)
      Me.PanelElevator.Location = New System.Drawing.Point(5, 209)
      Me.PanelElevator.Name = "PanelElevator"
      Me.PanelElevator.Size = New System.Drawing.Size(375, 98)
      Me.PanelElevator.TabIndex = 4
      '
      'LabelFloorRear
      '
      Me.LabelFloorRear.BackColor = System.Drawing.Color.White
      Me.LabelFloorRear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelFloorRear.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelFloorRear.ForeColor = System.Drawing.Color.DarkGreen
      Me.LabelFloorRear.Location = New System.Drawing.Point(311, 61)
      Me.LabelFloorRear.Name = "LabelFloorRear"
      Me.LabelFloorRear.Size = New System.Drawing.Size(47, 20)
      Me.LabelFloorRear.TabIndex = 68
      Me.LabelFloorRear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'LabelFloorFront
      '
      Me.LabelFloorFront.BackColor = System.Drawing.Color.White
      Me.LabelFloorFront.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelFloorFront.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelFloorFront.ForeColor = System.Drawing.Color.DarkGreen
      Me.LabelFloorFront.Location = New System.Drawing.Point(311, 36)
      Me.LabelFloorFront.Name = "LabelFloorFront"
      Me.LabelFloorFront.Size = New System.Drawing.Size(47, 20)
      Me.LabelFloorFront.TabIndex = 67
      Me.LabelFloorFront.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label14
      '
      Me.Label14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label14.Location = New System.Drawing.Point(257, 61)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(50, 20)
      Me.Label14.TabIndex = 66
      Me.Label14.Text = "Rear"
      Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      '
      'Label12
      '
      Me.Label12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label12.Location = New System.Drawing.Point(212, 36)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(99, 20)
      Me.Label12.TabIndex = 65
      Me.Label12.Text = "FLOOR: Front"
      Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'LabelElevFoot
      '
      Me.LabelElevFoot.BackColor = System.Drawing.Color.White
      Me.LabelElevFoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelElevFoot.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelElevFoot.ForeColor = System.Drawing.Color.DarkGreen
      Me.LabelElevFoot.Location = New System.Drawing.Point(278, 10)
      Me.LabelElevFoot.Name = "LabelElevFoot"
      Me.LabelElevFoot.Size = New System.Drawing.Size(80, 20)
      Me.LabelElevFoot.TabIndex = 64
      Me.LabelElevFoot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label10
      '
      Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label10.Location = New System.Drawing.Point(212, 11)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(61, 20)
      Me.Label10.TabIndex = 63
      Me.Label10.Text = "FOOT:  "
      Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'Label13
      '
      Me.Label13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label13.Location = New System.Drawing.Point(8, 61)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(107, 20)
      Me.Label13.TabIndex = 62
      Me.Label13.Text = "MOTOR AMPS:"
      Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'LabelElevAmps
      '
      Me.LabelElevAmps.BackColor = System.Drawing.Color.White
      Me.LabelElevAmps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelElevAmps.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelElevAmps.ForeColor = System.Drawing.Color.Black
      Me.LabelElevAmps.Location = New System.Drawing.Point(124, 60)
      Me.LabelElevAmps.Name = "LabelElevAmps"
      Me.LabelElevAmps.Size = New System.Drawing.Size(80, 20)
      Me.LabelElevAmps.TabIndex = 61
      Me.LabelElevAmps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label11
      '
      Me.Label11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label11.Location = New System.Drawing.Point(8, 36)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(107, 20)
      Me.Label11.TabIndex = 60
      Me.Label11.Text = "POSITION:"
      Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'LabelElevPosition
      '
      Me.LabelElevPosition.BackColor = System.Drawing.Color.White
      Me.LabelElevPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelElevPosition.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelElevPosition.ForeColor = System.Drawing.Color.Black
      Me.LabelElevPosition.Location = New System.Drawing.Point(124, 35)
      Me.LabelElevPosition.Name = "LabelElevPosition"
      Me.LabelElevPosition.Size = New System.Drawing.Size(80, 20)
      Me.LabelElevPosition.TabIndex = 59
      Me.LabelElevPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label9
      '
      Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label9.Location = New System.Drawing.Point(8, 11)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(107, 20)
      Me.Label9.TabIndex = 58
      Me.Label9.Text = "SETPOINT:"
      Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'LabelElevSetpoint
      '
      Me.LabelElevSetpoint.BackColor = System.Drawing.Color.White
      Me.LabelElevSetpoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelElevSetpoint.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelElevSetpoint.ForeColor = System.Drawing.Color.Black
      Me.LabelElevSetpoint.Location = New System.Drawing.Point(124, 10)
      Me.LabelElevSetpoint.Name = "LabelElevSetpoint"
      Me.LabelElevSetpoint.Size = New System.Drawing.Size(80, 20)
      Me.LabelElevSetpoint.TabIndex = 57
      Me.LabelElevSetpoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'LabelElevator
      '
      Me.LabelElevator.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelElevator.Location = New System.Drawing.Point(15, 199)
      Me.LabelElevator.Name = "LabelElevator"
      Me.LabelElevator.Size = New System.Drawing.Size(104, 20)
      Me.LabelElevator.TabIndex = 53
      Me.LabelElevator.Text = "ELEVATOR"
      Me.LabelElevator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'LabelArm
      '
      Me.LabelArm.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelArm.Location = New System.Drawing.Point(399, 58)
      Me.LabelArm.Name = "LabelArm"
      Me.LabelArm.Size = New System.Drawing.Size(48, 20)
      Me.LabelArm.TabIndex = 54
      Me.LabelArm.Text = "ARM"
      Me.LabelArm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'PanelVision
      '
      Me.PanelVision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.PanelVision.Controls.Add(Me.LabelTarget)
      Me.PanelVision.Controls.Add(Me.Label24)
      Me.PanelVision.Controls.Add(Me.Label26)
      Me.PanelVision.Controls.Add(Me.LabelTargetDistance)
      Me.PanelVision.Controls.Add(Me.Label25)
      Me.PanelVision.Controls.Add(Me.LabelTargetAngle)
      Me.PanelVision.Location = New System.Drawing.Point(387, 251)
      Me.PanelVision.Name = "PanelVision"
      Me.PanelVision.Size = New System.Drawing.Size(308, 56)
      Me.PanelVision.TabIndex = 6
      '
      'LabelTarget
      '
      Me.LabelTarget.BackColor = System.Drawing.Color.White
      Me.LabelTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelTarget.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelTarget.ForeColor = System.Drawing.Color.Black
      Me.LabelTarget.Location = New System.Drawing.Point(15, 26)
      Me.LabelTarget.Name = "LabelTarget"
      Me.LabelTarget.Size = New System.Drawing.Size(100, 20)
      Me.LabelTarget.TabIndex = 75
      Me.LabelTarget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label24
      '
      Me.Label24.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label24.Location = New System.Drawing.Point(15, 6)
      Me.Label24.Name = "Label24"
      Me.Label24.Size = New System.Drawing.Size(100, 20)
      Me.Label24.TabIndex = 74
      Me.Label24.Text = "Target"
      Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label26
      '
      Me.Label26.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label26.Location = New System.Drawing.Point(213, 6)
      Me.Label26.Name = "Label26"
      Me.Label26.Size = New System.Drawing.Size(80, 20)
      Me.Label26.TabIndex = 73
      Me.Label26.Text = "Distance"
      Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'LabelTargetDistance
      '
      Me.LabelTargetDistance.BackColor = System.Drawing.Color.White
      Me.LabelTargetDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelTargetDistance.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelTargetDistance.ForeColor = System.Drawing.Color.Black
      Me.LabelTargetDistance.Location = New System.Drawing.Point(213, 26)
      Me.LabelTargetDistance.Name = "LabelTargetDistance"
      Me.LabelTargetDistance.Size = New System.Drawing.Size(80, 20)
      Me.LabelTargetDistance.TabIndex = 72
      Me.LabelTargetDistance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label25
      '
      Me.Label25.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label25.Location = New System.Drawing.Point(124, 6)
      Me.Label25.Name = "Label25"
      Me.Label25.Size = New System.Drawing.Size(80, 20)
      Me.Label25.TabIndex = 71
      Me.Label25.Text = "Angle"
      Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'LabelTargetAngle
      '
      Me.LabelTargetAngle.BackColor = System.Drawing.Color.White
      Me.LabelTargetAngle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelTargetAngle.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelTargetAngle.ForeColor = System.Drawing.Color.Black
      Me.LabelTargetAngle.Location = New System.Drawing.Point(124, 26)
      Me.LabelTargetAngle.Name = "LabelTargetAngle"
      Me.LabelTargetAngle.Size = New System.Drawing.Size(80, 20)
      Me.LabelTargetAngle.TabIndex = 70
      Me.LabelTargetAngle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'LabelVision
      '
      Me.LabelVision.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelVision.Location = New System.Drawing.Point(398, 241)
      Me.LabelVision.Name = "LabelVision"
      Me.LabelVision.Size = New System.Drawing.Size(74, 20)
      Me.LabelVision.TabIndex = 56
      Me.LabelVision.Text = "VISION"
      Me.LabelVision.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label28
      '
      Me.Label28.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label28.Location = New System.Drawing.Point(5, 32)
      Me.Label28.Name = "Label28"
      Me.Label28.Size = New System.Drawing.Size(120, 20)
      Me.Label28.TabIndex = 65
      Me.Label28.Text = "SAND STORM: "
      Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'ListHatch
      '
      Me.ListHatch.BackColor = System.Drawing.SystemColors.Window
      Me.ListHatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.ListHatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.ListHatch.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.ListHatch.FormattingEnabled = true
      Me.ListHatch.ImeMode = System.Windows.Forms.ImeMode.Hangul
      Me.ListHatch.Items.AddRange(New Object() {"None", "Ship: End Left (L1)", "Ship: End Right (L1)", "Ship: Side Left (L1)", "Ship: Side Left (L2)", "Ship: Side Right (L1)", "Ship: Side Right (L2)", "Rocket: Left (L1)", "Rocket: Left (L2)", "Rocket: Right (L1)", "Rocket: Right (L2)"})
      Me.ListHatch.Location = New System.Drawing.Point(182, 30)
      Me.ListHatch.Name = "ListHatch"
      Me.ListHatch.Size = New System.Drawing.Size(210, 26)
      Me.ListHatch.TabIndex = 0
      Me.ListHatch.Tag = "0"
      '
      'Label29
      '
      Me.Label29.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label29.Location = New System.Drawing.Point(410, 26)
      Me.Label29.Name = "Label29"
      Me.Label29.Size = New System.Drawing.Size(54, 35)
      Me.Label29.TabIndex = 67
      Me.Label29.Text = "STOP AFTER"
      Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'ListLoad
      '
      Me.ListLoad.BackColor = System.Drawing.SystemColors.Window
      Me.ListLoad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.ListLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.ListLoad.Font = New System.Drawing.Font("Verdana", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.ListLoad.FormattingEnabled = true
      Me.ListLoad.ImeMode = System.Windows.Forms.ImeMode.Hangul
      Me.ListLoad.Items.AddRange(New Object() {"Hatch Placed", "Drive to Load", "Hatch Loaded", "Completed"})
      Me.ListLoad.Location = New System.Drawing.Point(470, 30)
      Me.ListLoad.Name = "ListLoad"
      Me.ListLoad.Size = New System.Drawing.Size(140, 26)
      Me.ListLoad.TabIndex = 1
      Me.ListLoad.Tag = "1"
      '
      'ButtonVisionAuto
      '
      Me.ButtonVisionAuto.BackColor = System.Drawing.Color.SpringGreen
      Me.ButtonVisionAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.ButtonVisionAuto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.ButtonVisionAuto.Location = New System.Drawing.Point(630, 237)
      Me.ButtonVisionAuto.Name = "ButtonVisionAuto"
      Me.ButtonVisionAuto.Size = New System.Drawing.Size(50, 24)
      Me.ButtonVisionAuto.TabIndex = 7
      Me.ButtonVisionAuto.Tag = "2"
      Me.ButtonVisionAuto.Text = "Auto"
      Me.ButtonVisionAuto.UseVisualStyleBackColor = false
      '
      'Label27
      '
      Me.Label27.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label27.Location = New System.Drawing.Point(122, 26)
      Me.Label27.Name = "Label27"
      Me.Label27.Size = New System.Drawing.Size(54, 35)
      Me.Label27.TabIndex = 68
      Me.Label27.Text = "PLACE HATCH"
      Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'ButtonSSAuto
      '
      Me.ButtonSSAuto.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ButtonSSAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.ButtonSSAuto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.ButtonSSAuto.Location = New System.Drawing.Point(630, 32)
      Me.ButtonSSAuto.Name = "ButtonSSAuto"
      Me.ButtonSSAuto.Size = New System.Drawing.Size(50, 24)
      Me.ButtonSSAuto.TabIndex = 2
      Me.ButtonSSAuto.Tag = "2"
      Me.ButtonSSAuto.Text = "Auto"
      Me.ButtonSSAuto.UseVisualStyleBackColor = false
      '
      'DashForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 14!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225,Byte),Integer), CType(CType(230,Byte),Integer), CType(CType(245,Byte),Integer))
      Me.ClientSize = New System.Drawing.Size(701, 313)
      Me.Controls.Add(Me.ButtonSSAuto)
      Me.Controls.Add(Me.Label27)
      Me.Controls.Add(Me.ButtonVisionAuto)
      Me.Controls.Add(Me.ListLoad)
      Me.Controls.Add(Me.Label29)
      Me.Controls.Add(Me.ListHatch)
      Me.Controls.Add(Me.Label28)
      Me.Controls.Add(Me.LabelVision)
      Me.Controls.Add(Me.PanelVision)
      Me.Controls.Add(Me.LabelArm)
      Me.Controls.Add(Me.LabelElevator)
      Me.Controls.Add(Me.PanelElevator)
      Me.Controls.Add(Me.ButtonDataCapture)
      Me.Controls.Add(Me.PanelArm)
      Me.Controls.Add(Me.LabelDrive)
      Me.Controls.Add(Me.PanelDrive)
      Me.Controls.Add(Me.LabelStatus)
      Me.Controls.Add(Me.LedRobot)
      Me.Controls.Add(Me.DashMenu)
      Me.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
      Me.MainMenuStrip = Me.DashMenu
      Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
      Me.MaximizeBox = false
      Me.Name = "DashForm"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "DESTINATION: DEEP SPACE"
      Me.DashMenu.ResumeLayout(false)
      Me.DashMenu.PerformLayout
      Me.PanelDrive.ResumeLayout(false)
      Me.PanelArm.ResumeLayout(false)
      Me.PanelElevator.ResumeLayout(false)
      Me.PanelVision.ResumeLayout(false)
      Me.ResumeLayout(false)
      Me.PerformLayout

End Sub

   Friend WithEvents DashMenu As MenuStrip
   Friend WithEvents MenuFile As ToolStripMenuItem
   Friend WithEvents FileExit As ToolStripMenuItem
   Friend WithEvents MenuView As ToolStripMenuItem
   Friend WithEvents ViewSettings As ToolStripMenuItem
   Friend WithEvents ViewTune As ToolStripMenuItem
   Friend WithEvents ViewSeparator1 As ToolStripSeparator
   Friend WithEvents ViewData As ToolStripMenuItem
   Friend WithEvents ViewOptions As ToolStripMenuItem
   Friend WithEvents LedRobot As Label
   Friend WithEvents LabelStatus As Label
   Friend WithEvents ViewTraffic As ToolStripMenuItem
   Friend WithEvents LabelDrive As Label
   Friend WithEvents PanelDrive As Panel
   Friend WithEvents LabelGyro As Label
   Friend WithEvents LabelEncoderRight As Label
   Friend WithEvents LabelEncoderLeft As Label
   Friend WithEvents Label7 As Label
   Friend WithEvents Label8 As Label
   Friend WithEvents Label5 As Label
   Friend WithEvents TimerClick As Timer
   Friend WithEvents FileReconnect As ToolStripMenuItem
   Friend WithEvents FileSeparator As ToolStripSeparator
   Friend WithEvents PanelArm As Panel
   Friend WithEvents LabelDriveRight1 As Label
   Friend WithEvents LabelDriveLeft1 As Label
   Friend WithEvents Label2 As Label
   Friend WithEvents Label0 As Label
   Friend WithEvents TimerRestart As Timer
   Friend WithEvents LabelShift As Label
   Friend WithEvents Label6 As Label
   Friend WithEvents ButtonDataCapture As Button
   Friend WithEvents ViewGraph As ToolStripMenuItem
   Friend WithEvents ViewRobotValues As ToolStripMenuItem
   Friend WithEvents ViewRobotStatus As ToolStripMenuItem
   Friend WithEvents Label4 As Label
   Friend WithEvents LabelDriveRight2 As Label
   Friend WithEvents Label3 As Label
   Friend WithEvents LabelDriveLeft2 As Label
   Friend WithEvents Label1 As Label
   Friend WithEvents PanelElevator As Panel
   Friend WithEvents Label13 As Label
   Friend WithEvents LabelElevAmps As Label
   Friend WithEvents Label11 As Label
   Friend WithEvents LabelElevPosition As Label
   Friend WithEvents Label9 As Label
   Friend WithEvents LabelElevSetpoint As Label
   Friend WithEvents LabelElevator As Label
   Friend WithEvents LabelFloorRear As Label
   Friend WithEvents LabelFloorFront As Label
   Friend WithEvents Label14 As Label
   Friend WithEvents Label12 As Label
   Friend WithEvents LabelElevFoot As Label
   Friend WithEvents Label10 As Label
   Friend WithEvents LabelArm As Label
   Friend WithEvents LabelCargo As Label
   Friend WithEvents Label23 As Label
   Friend WithEvents Label22 As Label
   Friend WithEvents LabelHatch As Label
   Friend WithEvents Label21 As Label
   Friend WithEvents Label20 As Label
   Friend WithEvents LabelHandMode As Label
   Friend WithEvents Label16 As Label
   Friend WithEvents LabelWristAmps As Label
   Friend WithEvents LabelWristPosition As Label
   Friend WithEvents LabelWristSetpoint As Label
   Friend WithEvents Label15 As Label
   Friend WithEvents Label19 As Label
   Friend WithEvents LabelShoulderAmps As Label
   Friend WithEvents Label18 As Label
   Friend WithEvents LabelShoulderPosition As Label
   Friend WithEvents Label17 As Label
   Friend WithEvents LabelShoulderSetpoint As Label
   Friend WithEvents PanelVision As Panel
   Friend WithEvents LabelTarget As Label
   Friend WithEvents Label24 As Label
   Friend WithEvents Label26 As Label
   Friend WithEvents LabelTargetDistance As Label
   Friend WithEvents Label25 As Label
   Friend WithEvents LabelTargetAngle As Label
   Friend WithEvents LabelVision As Label
   Friend WithEvents Label28 As Label
   Friend WithEvents ListHatch As ComboBox
   Friend WithEvents Label29 As Label
   Friend WithEvents ListLoad As ComboBox
   Friend WithEvents ButtonVisionAuto As Button
   Friend WithEvents Label27 As Label
   Friend WithEvents ButtonSSAuto As Button
End Class
