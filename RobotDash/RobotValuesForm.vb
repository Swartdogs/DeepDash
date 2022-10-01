Public Class RobotValuesForm

   Private Sub BuildGrid()
      Dim cIndex  As Integer = colDvIndex.Index
      Dim cDesc   As Integer = colDesc.Index

      With GridValues
         .RowCount = 16

         .Item(cIndex, 0).Value  = RVindex.rvDriveGyro
         .Item(cDesc, 0).Value   = "Drive:    Gyro"

         .Item(cIndex, 1).Value  = RVindex.rvDriveEncoderL
         .Item(cDesc, 1).Value   = "          Encoder Left"

         .Item(cIndex, 2).Value  = RVindex.rvDriveEncoderR
         .Item(cDesc, 2).Value   = "          Encoder Right"

         .Item(cIndex, 3).Value  = RVindex.rvDriveAmpsLeft1
         .Item(cDesc, 3).Value   = "          Motor Amps Left 1"

         .Item(cIndex, 4).Value  = RVindex.rvDriveAmpsLeft2
         .Item(cDesc, 4).Value   = "          Motor Amps Left 2"

         .Item(cIndex, 5).Value  = RVindex.rvDriveAmpsRight1
         .Item(cDesc, 5).Value   = "          Motor Amps Right 1"

         .Item(cIndex, 6).Value  = RVindex.rvDriveAmpsRight2
         .Item(cDesc, 6).Value   = "          Motor Amps Right 2"

         .Item(cIndex, 7).Value  = RVindex.rvElevatorPosition
         .Item(cDesc, 7).Value   = "Elevator: Position"

         .Item(cIndex, 8).Value  = RVindex.rvElevatorSetpoint
         .Item(cDesc, 8).Value   = "          Setpoint"

         .Item(cIndex, 9).Value  = RVindex.rvElevatorAmps
         .Item(cDesc, 9).Value   = "          Motor Amps"

         .Item(cIndex, 10).Value = RVindex.rvShoulderPosition
         .Item(cDesc, 10).Value  = "Shoulder: Position"

         .Item(cIndex, 11).Value = RVindex.rvShoulderSetpoint
         .Item(cDesc, 11).Value  = "          Setpoint"

         .Item(cIndex, 12).Value = RVindex.rvShoulderAmps
         .Item(cDesc, 12).Value  = "          Motor Amps"

         .Item(cIndex, 13).Value = RVindex.rvWristPosition
         .Item(cDesc, 13).Value  = "Wrist:    Position"

         .Item(cIndex, 14).Value = RVindex.rvWristSetpoint
         .Item(cDesc, 14).Value  = "          Setpoint"

         .Item(cIndex, 15).Value = RVindex.rvWristAmps
         .Item(cDesc, 15).Value  = "          Motor Amps"
      End with
   End Sub

   Private Sub RobotValuesForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
      m_robotValuesForm = Nothing
   End Sub

   Private Sub RobotValuesForm_Load(sender As Object, e As EventArgs) Handles Me.Load
      Me.Top = m_dashForm.Top + 60
      Me.Left = m_dashForm.Left + 20
      BuildGrid()
      ShowValues()
      UpdateRobotStatus()
   End Sub

   Public Sub ShowValues()
      Dim index As Integer

      With GridValues
         .SuspendLayout()

         For row As Integer = 0 To .RowCount - 1
            index = .Item(colDvIndex.Index, row).Value

            If index < m_robotValueCount
               .Item(colValue.Index, row).Value = GetRobotValue(index)
            Else
               .Item(colValue.Index, row).Value = "---"
            End If 
         Next

         .ResumeLayout()
      End With
   End Sub

   Public Sub UpdateRobotStatus()
      LabelNoRobot.Visible = Not m_robotConnected
   End Sub
End Class