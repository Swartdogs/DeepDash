Public Class RobotStatusForm

   Private Sub BuildGrid()
      Dim cIndex  As Integer = colDsIndex.Index
      Dim cDesc   As Integer = colDesc.Index

      With GridStatus
         .RowCount = 7

         .Item(cIndex, 0).Value  = RSindex.rsShifterLow
         .Item(cDesc, 0).Value  = "Drive:    Shifter in Low"

         .Item(cIndex, 1).Value  = RSindex.rsFootRetracted
         .Item(cDesc, 1).Value  = "Elevator: Foot Retracted"
         
         .Item(cIndex, 2).Value  = RSindex.rsFloorFront
         .Item(cDesc, 2).Value  = "          Front Floor Detected"

         .Item(cIndex, 3).Value  = RSindex.rsFloorRear
         .Item(cDesc, 3).Value  = "          Rear Floor Detected"

         .Item(cIndex, 4).Value  = RSindex.rsCargo
         .Item(cDesc, 4).Value  = "Arm:      Cargo Detected"

         .Item(cIndex, 5).Value  = RSindex.rsHatchMode
         .Item(cDesc, 5).Value  = "          In Hatch Mode"

         .Item(cIndex, 6).Value  = RSindex.rsHatchGrab
         .Item(cDesc, 6).Value  = "          In Hatch Grab"
      End With
   End Sub

   Private Sub RobotStatusForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
      m_robotStatusForm = Nothing
   End Sub

   Private Sub RobotStatusForm_Load(sender As Object, e As EventArgs) Handles Me.Load
      Me.Top = m_dashForm.Top + 60
      Me.Left = m_dashForm.Left + 20
      BuildGrid()
      ShowStatus()
      UpdateRobotStatus()
   End Sub

   Public Sub ShowStatus()
      Dim cellColor  As Color
      Dim cellText   As String
      Dim index      As Integer

      With GridStatus
         .SuspendLayout

         For row As Integer = 0 To .RowCount - 1
            index = .Item(colDsIndex.Index, row).Value

            If index < m_robotStatusCount * 16
               Dim group      = row \ 16
               Dim bitValue   = 2 ^ (row Mod 16)

               If (m_robotStatus(group) And bitValue)
                  cellColor = Color.Red
                  cellText = "TRUE"                  
               Else
                  cellColor = Color.DarkGreen
                  cellText = "FALSE"
               End If
            Else
               cellColor = Color.Black
               cellText = "---"
            End If

            .Item(colState.Index, row).Style.ForeColor = cellColor
            .Item(colState.Index, row).Value = cellText
         Next
      End With
   End Sub

   Public Sub UpdateRobotStatus()
      LabelNoRobot.Visible = Not m_robotConnected
   End Sub
End Class