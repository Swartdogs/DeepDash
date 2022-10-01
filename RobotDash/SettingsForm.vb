Public Class SettingsForm

   Private Structure CellError
      Public grid          As DataGridView
      Public columnIndex   As Integer
      Public rowIndex      As Integer
   End Structure

   Private c_allowKey         As Boolean = False
   Private c_cellError        As CellError
   Private c_formLeft         As Integer = m_dashForm.Left + 20
   Private c_formName         As String = "ROBOT SETTINGS"
   Private c_formTop          As Integer = m_dashForm.Top + 60
   Private c_showRobotValues  As Boolean = False

   Private Sub BuildGrid()
      Dim cIndex  As Integer = colDvIndex.Index
      Dim cDesc   As Integer = colDesc.Index

      With GridSetting
         .RowCount = 49

         .Item(cIndex, 0).Value  = DVindex.dvElevOffset
         .Item(cDesc, 0).Value   = "Elevator: Pot Offset (V-O)"

         .Item(cIndex, 1).Value  = DVindex.dvElevMin
         .Item(cDesc, 1).Value   = "          Minimum"

         .Item(cIndex, 2).Value  = DVindex.dvElevMax
         .Item(cDesc, 2).Value   = "          Maximum"

         .Item(cIndex, 3).Value  = DVindex.dvFloorSensorMin
         .Item(cDesc, 3).Value   = "          Floor Sensor Minimum"

         .Item(cIndex, 4).Value  = DVindex.dvElevRetracted
         .Item(cDesc, 4).Value   = "          Retracted"

         .Item(cIndex, 5).Value  = DVindex.dvElevLevel2
         .Item(cDesc, 5).Value   = "          Level 2"

         .Item(cIndex, 6).Value  = DVindex.dvElevLevel3
         .Item(cDesc, 6).Value   = "          Level 3"

         .Item(cIndex, 7).Value  = DVindex.dvShoulderOffset
         .Item(cDesc, 7).Value   = "Shoulder: Pot Offset (V-O)"

         .Item(cIndex, 8).Value  = DVindex.dvShoulderMin
         .Item(cDesc, 8).Value   = "          Minimum"

         .Item(cIndex, 9).Value = DVindex.dvShoulderMax
         .Item(cDesc, 9).Value  = "          Maximum"

         .Item(cIndex, 10).Value = DVindex.dvShoulderClear
         .Item(cDesc, 10).Value  = "          Clear"

         .Item(cIndex, 11).Value = DVindex.dvShoulderTravel
         .Item(cDesc, 11).Value  = "          Travel"

         .Item(cIndex, 12).Value = DVindex.dvSCPickup
         .Item(cDesc, 12).Value  = "          Cargo Pickup"

         .Item(cIndex, 13).Value = DVindex.dvSCLoad
         .Item(cDesc, 13).Value  = "          Cargo Load"

         .Item(cIndex, 14).Value = DVindex.dvSCCargoShip
         .Item(cDesc, 14).Value  = "          Cargo Cargo Ship"

         .Item(cIndex, 15).Value = DVindex.dvSCRocketLow
         .Item(cDesc, 15).Value  = "          Cargo Rocket Low"

         .Item(cIndex, 16).Value = DVindex.dvSCRocketMid
         .Item(cDesc, 16).Value  = "          Cargo Rocket Mid"

         .Item(cIndex, 17).Value = DVindex.dvSCRocketHigh
         .Item(cDesc, 17).Value  = "          Cargo Rocket High"

         .Item(cIndex, 18).Value = DVindex.dvSCCatch
         .Item(cDesc, 18).Value  = "          Cargo Catch"

         .Item(cIndex, 19).Value = DVindex.dvSHRocketLow
         .Item(cDesc, 19).Value  = "          Hatch Rocket Low"

         .Item(cIndex, 20).Value = DVindex.dvSHRocketMid
         .Item(cDesc, 20).Value  = "          Hatch Rocket Mid"

         .Item(cIndex, 21).Value = DVindex.dvSHRocketHigh
         .Item(cDesc, 21).Value  = "          Hatch Rocket High"

         .Item(cIndex, 22).Value = DVindex.dvWristOffset
         .Item(cDesc, 22).Value  = "Wrist:    Pot Offset (O-V)"

         .Item(cIndex, 23).Value = DVindex.dvWristMin
         .Item(cDesc, 23).Value  = "          Minimum"

         .Item(cIndex, 24).Value = DVindex.dvWristMax
         .Item(cDesc, 24).Value  = "          Maximum"

         .Item(cIndex, 25).Value = DVindex.dvWristClear
         .Item(cDesc, 25).Value  = "          Clear"

         .Item(cIndex, 26).Value = DVindex.dvWristTravel
         .Item(cDesc, 26).Value  = "          Travel"

         .Item(cIndex, 27).Value = DVindex.dvWCPickup
         .Item(cDesc, 27).Value  = "          Cargo Pickup"

         .Item(cIndex, 28).Value = DVindex.dvWCLoad
         .Item(cDesc, 28).Value  = "          Cargo Load"

         .Item(cIndex, 29).Value = DVindex.dvWCCargoShip
         .Item(cDesc, 29).Value  = "          Cargo Cargo Ship"

         .Item(cIndex, 30).Value = DVindex.dvWCRocketLow
         .Item(cDesc, 30).Value  = "          Cargo Rocket Low"

         .Item(cIndex, 31).Value = DVindex.dvWCRocketMid
         .Item(cDesc, 31).Value  = "          Cargo Rocket Mid"

         .Item(cIndex, 32).Value = DVindex.dvWCRocketHigh
         .Item(cDesc, 32).Value  = "          Cargo Rocket High"

         .Item(cIndex, 33).Value = DVindex.dvWCCatch
         .Item(cDesc, 33).Value  = "          Cargo Catch"

         .Item(cIndex, 34).Value = DVindex.dvWHRocketLow
         .Item(cDesc, 34).Value  = "          Hatch Rocket Low"

         .Item(cIndex, 35).Value = DVindex.dvWHRocketMid
         .Item(cDesc, 35).Value  = "          Hatch Rocket Mid"

         .Item(cIndex, 36).Value = DVindex.dvWHRocketHigh
         .Item(cDesc, 36).Value  = "          Hatch Rocket High"

         .Item(cIndex, 37).Value = DVindex.dvCargoSpeedIn
         .Item(cDesc, 37).Value  = "Cargo:    Speed In"

         .Item(cIndex, 38).Value = DVindex.dvCargoSpeedOut
         .Item(cDesc, 38).Value  = "          Speed Out"

         .Item(cIndex, 39).Value = DVindex.dvCargoSpeedRotate
         .Item(cDesc, 39).Value  = "          Speed Rotate"

         .Item(cIndex, 40).Value = DVindex.dvCargoRotateRatio
         .Item(cDesc, 40).Value  = "          Rotate Ratio"

         .Item(cIndex, 41).Value = DVindex.dvCargoEjectTime
         .Item(cDesc, 41).Value  = "          Eject Time Count"

         .Item(cIndex, 42).Value = DVindex.dvCargoRotateTime
         .Item(cDesc, 42).Value  = "          Rotate Time Count"

         .Item(cIndex, 43).Value = DVindex.dvVisionTargetAngle
         .Item(cDesc, 43).Value  = "Vision:   Target Angle"

         .Item(cIndex, 44).Value = DVindex.dvVisionCargoLoad
         .Item(cDesc, 44).Value  = "          Cargo Load"

         .Item(cIndex, 45).Value = DVindex.dvVisionHatchLoad
         .Item(cDesc, 45).Value  = "          Hatch Load"

         .Item(cIndex, 46).Value = DVindex.dvVisionHatchLow
         .Item(cDesc, 46).Value  = "          Hatch Low"

         .Item(cIndex, 47).Value = DVindex.dvVisionHatchMid
         .Item(cDesc, 47).Value  = "          Hatch Mid"

         .Item(cIndex, 48).Value = DVindex.dvVisionHatchHigh
         .Item(cDesc, 48).Value  = "          Hatch High"
      End With

      ShowSettings()
   End Sub

   Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
      ShowSettings()
      ButtonSend.Enabled = False
      ButtonCancel.Enabled = False
   End Sub

   Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
      Me.Close()
   End Sub

   Private Sub ButtonDash_Click(sender As Object, e As EventArgs) Handles ButtonDash.Click
      If m_dashForm IsNot Nothing
         m_dashForm.LabelStatus.BackColor = Color.FromArgb(252, 252, 252) 
         m_dashForm.LabelStatus.ForeColor = Color.Red        
         m_dashForm.LabelStatus.Text = RobotModeCaption(m_robotMode)
      End If

      m_tcpClient.SendDashboardData()
      Me.Close()
   End Sub

   Private Sub ButtonRobot_Click(sender As Object, e As EventArgs) Handles ButtonRobot.Click
      If m_dashForm IsNot Nothing
         m_dashForm.LabelStatus.BackColor = Color.FromArgb(252, 252, 252) 
         m_dashForm.LabelStatus.ForeColor = Color.Red       
         m_dashForm.LabelStatus.Text = RobotModeCaption(m_robotMode)
      End If

      For i As Integer = 0 To m_robotSettingsCount
         If i < m_dashValueCount Then DashValue(i, False) = m_robotSettings(i)
      Next

      Me.Close()
   End Sub

   Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click
      Dim index As Integer

      With GridSetting
         For row As Integer = 0 To .RowCount - 1
            index = .Item(colDvIndex.Index, row).Value
            If m_dashValue(index).revised Then DashValue(index, True) = .Item(colValue.Index, row).Value
         Next
      End With

      DashValue(-1, True) = 0
   End Sub

   Private Sub Grid_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles GridSetting.CellEndEdit
      Dim grid    As DataGridView = CType(sender, DataGridView)
      Dim count   As Integer = 0
      Dim found   As Integer
      Dim text    As String

      If grid.Item(e.ColumnIndex, e.RowIndex).Value Is Nothing
         text = "0"
      Else
         text = grid.Item(e.ColumnIndex, e.RowIndex).Value.ToString
      End If

      Do
         found = text.IndexOf(".")

         If found >= 0
            count += 1
            text = Mid(text, found + 2)
         Else
            Exit Do
         End If
      Loop

      If count > 1
         Dim result As DialogResult = MessageBox.Show(Me, "Multiple decimal points are not permitted", c_formName, _
                                                      MessageBoxButtons.OK, MessageBoxIcon.Information)

         With c_cellError
            .grid = grid
            .columnIndex = e.ColumnIndex
            .rowIndex = e.RowIndex
         End With
         TimerError.Start()

      Else
         Dim index      As Integer = grid.Item(colDvIndex.Index, e.RowIndex).Value
         Dim newValue   As Double = ConvertToDouble(grid.Item(e.ColumnIndex, e.RowIndex).Value)
         
         If m_dashValue(index).value <> newValue
            m_dashValue(index).revised = True
            grid.Item(e.ColumnIndex, e.RowIndex).Value = newValue
            grid.Item(e.ColumnIndex, e.RowIndex).Style.BackColor = m_colorPending   

            ButtonSend.Enabled = True
            ButtonCancel.Enabled = True
         End If
      End If
   End Sub

   Private Sub Grid_CurrentCellChanged(sender As Object, e As EventArgs) Handles GridSetting.CurrentCellChanged
      If GridSetting.CurrentCell IsNot Nothing
         Select GridSetting.CurrentCell.ColumnIndex
             Case 1: c_allowKey = True: SendKeys.Send("{RIGHT}")
         End Select
      End If
   End Sub

   Private Sub Grid_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles GridSetting.EditingControlShowing
      Dim grid    As DataGridView = CType(sender, DataGridView)

      If grid.CurrentCell.ColumnIndex = colValue.Index
         AddHandler e.Control.KeyPress, AddressOf GridTextBox_Keypress
      Else
         RemoveHandler e.Control.KeyPress, AddressOf GridTextBox_Keypress
      End If
   End Sub

   Private Sub Grid_KeyDown(sender As Object, e As KeyEventArgs) Handles GridSetting.KeyDown
      Select e.KeyCode
         Case Keys.Right
            If c_allowKey Then c_allowKey = False Else e.Handled = True
      End Select
   End Sub

   Private Sub Grid_LostFocus(sender As Object, e As EventArgs) Handles GridSetting.LostFocus
      Dim grid    As DataGridView = CType(sender, DataGridView)
      grid.ClearSelection()
   End Sub

   Private Sub GridTextBox_Keypress(sender As Object, e As KeyPressEventArgs) 
      e.KeyChar = TextBoxKeyPress(TextBoxType.Float, e.KeyChar)
   End Sub

   Private Sub SettingsForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
      m_settingsForm = Nothing
   End Sub

   Private Sub SettingsForm_Load(sender As Object, e As EventArgs) Handles Me.Load
      Me.Top = c_formTop
      Me.Left = c_formLeft

      Me.Text = "ROBOT SETTINGS  (" & m_dashOptions.settingsFile & ")"
      BuildGrid()

      UpdateRobotStatus()
   End Sub

   Public Sub ShowRobotValues()
      c_showRobotValues = True

      GridSetting.ReadOnly = True
      GridSetting.Columns(2).HeaderText = "Dash Value"
      GridSetting.Columns(2).HeaderCell.Style.BackColor = Color.SpringGreen
      GridSetting.Columns(3).HeaderCell.Style.BackColor = Color.Yellow
      GridSetting.Columns(3).Visible = True
      GridSetting.Width += 90
      LabelSettings.Width = GridSetting.Width
      LabelNoRobot.Left += 90

      GridSetting.Anchor = AnchorStyles.Left + AnchorStyles.Top

      Me.Height += 125
      Me.MinimumSize = New System.Drawing.Size(477, 592)
      Me.MaximumSize = New System.Drawing.Size(477, 1010)
      Me.MinimizeBox = False

      c_formLeft = m_dashForm.Left + (m_dashForm.Width - Me.Width) \ 2

      GridSetting.Anchor = AnchorStyles.Left + AnchorStyles.Top + AnchorStyles.Bottom
      PanelMismatch.Anchor = AnchorStyles.Left + AnchorStyles.Bottom

      PanelMismatch.Visible = True
      PanelSave.Visible = False
   End Sub

   Public Sub ShowSettings()
      Dim index      As Integer

      With GridSetting
         .SuspendLayout()

         For row As Integer = 0 To .RowCount - 1
            index = .Item(colDvIndex.Index, row).Value
            .Item(colValue.Index, row).Value = m_dashValue(index).value

            If c_showRobotValues
               If index < m_robotSettingsCount
                  .Item(colFromRobot.Index, row).Value = m_robotSettings(index)

                  If m_dashValue(index).value <> m_robotSettings(index)
                     .Item(colValue.Index, row).Style.BackColor = Color.Pink
                     .Item(colValue.Index, row).Style.SelectionBackColor = Color.Pink
                     .Item(colFromRobot.Index, row).Style.BackColor = Color.Pink
                     .Item(colFromRobot.Index, row).Style.SelectionBackColor = Color.Pink
                  End If
               End if
            Else
               If m_dashValue(index).sentToHost
                  .Item(colValue.Index, row).Style.BackColor = Color.White
               Else
                  .Item(colValue.Index, row).Style.BackColor = m_colorPending
               End If
            End If
         Next

         .ResumeLayout()
      End With
   End Sub

   Private Sub TimerError_Tick(sender As Object, e As EventArgs) Handles TimerError.Tick
      TimerError.Stop()
      With c_cellError
         .grid.CurrentCell = .grid.Item(.columnIndex, .rowIndex)
      End With
   End Sub

   Public Sub UpdateRobotStatus()
      LabelNoRobot.Visible = Not m_robotConnected
   End Sub

   Public Sub UpdateStatus()
      Dim index  As Integer

      With GridSetting
         .SuspendLayout()

         For row As Integer = 0 To .RowCount - 1
            index = .Item(colDvIndex.Index, row).Value

            If Not m_dashValue(index).revised And m_dashValue(index).sentToHost
               .Item(colValue.Index, row).Style.BackColor = Color.White
            Else
               .Item(colValue.Index, row).Style.BackColor = m_colorPending
            End If
         Next

         .ResumeLayout()
      End With
   End Sub

End Class