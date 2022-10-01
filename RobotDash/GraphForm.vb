Imports System.ComponentModel

Public Class GraphForm
   Private c_formName         As String = "Graph Plotter"
   Private c_defIndex         As Integer = -1
   Private c_drawTimeLine     As Boolean = False
   Private c_graphHeight      As Integer = 400
   Private c_graphMin         As Integer
   Private c_graphMax         As Integer
   Private c_graphRange       As Integer
   Private c_graphTick        As Integer
   Private c_graphTickPixels  As Integer
   Private c_graphWidth       As Integer = 750
   Private c_graphX           As Integer
   Private c_graphXstep       As Integer = 2
   Private c_labelList        As List(Of Label) = New List(Of Label)
   Private c_plotGraph        As Boolean = False
   Private c_plotScale        As Boolean = True
   Private c_plotStart        As Boolean = True
   Private c_pixelsPerUnit    As Double
   Private c_revised          As Boolean = False

   Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
      ClearGraph()
   End Sub

   Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
      If c_plotGraph
         c_plotGraph = False
         c_drawTimeLine = False
         TimerTimeLine.Enabled = False
         ButtonStart.Text = "Start"
         ButtonStart.BackColor = Color.FromArgb(190, 255, 190)

      Else
         c_plotGraph = True
         c_plotStart = True
         ButtonStart.Text = "Stop"
         ButtonStart.BackColor = Color.FromArgb(255, 210, 210)

         If c_revised
            With m_graphList(c_defIndex)
               .Minimum = CInt(TextMin.Text)
               .Maximum = CInt(TextMax.Text)
               .TickSpacing = CInt(TextTick.Text)

               If .TickSpacing > .Maximum - .Minimum
                  .TickSpacing = 0
                  TextTick.Text = "0"
               End If
            End With

            Revised(False)
            SaveOptions()
            c_plotScale = True
         End If

         With m_graphList(c_defIndex)
            c_graphMin = .Minimum
            c_graphMax = .Maximum
            c_graphTick = .TickSpacing
         End With

         c_graphRange = (c_graphMax - c_graphMin)
         c_pixelsPerUnit = c_graphHeight / c_graphRange
         c_graphTickPixels = c_graphTick * c_pixelsPerUnit

         If c_plotScale Then PlotScale()
      End If 
      
'      TimerPlot.Enabled = c_plotGraph     
   End Sub

   Private Sub ClearGraph()
      PBGraph.Image = My.Resources.Whitebackground
      c_graphX = 0
   End Sub

   Private Sub ClearScale()
      For Each axisLabel In c_labelList
         Me.Controls.Remove(axisLabel)
      Next

      c_labelList.Clear()
      c_plotScale = True
   End Sub

   Private Sub GraphForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
      m_graphForm = Nothing
   End Sub

   Private Sub GraphForm_Load(sender As Object, e As EventArgs) Handles Me.Load
      Me.Top = m_dashForm.Top + 60
      Me.Left = m_dashForm.Left + 20

      ListGraph.Items.Clear()

      For i As Integer = 0 To m_graphCount - 1
         ListGraph.Items.Add(New ListItem(m_graphList(i).ValueIndex, m_graphList(i).GraphName))
      Next

      If ListGraph.Items.Count > 0 Then ListGraph.SelectedIndex = 0
      UpdateRobotStatus()
   End Sub

   Private Sub ListGraph_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListGraph.SelectedIndexChanged
      Dim enabled As Boolean = False

      If c_plotGraph 
         c_plotGraph = False
         TimerPlot.Enabled = False
         ButtonStart.Text = "Start"
         ButtonStart.BackColor = Color.FromArgb(190, 255, 190)
      End If

      ClearGraph()
      ClearScale()

      c_defIndex = ListGraph.SelectedIndex
      Revised(False)

      If c_defIndex >= 0
         enabled = True

         With m_graphList(c_defIndex)
            TextMin.Text = .Minimum.ToString
            TextMax.Text = .Maximum.ToString
            TextTick.Text = .TickSpacing.ToString
         End With
      Else
         TextMin.Text = ""
         TextMax.Text = ""
         TextTick.Text = ""
      End If

      TextMin.Enabled = enabled
      TextMax.Enabled = enabled
      TextTick.Enabled = enabled
      ButtonStart.Enabled = enabled
      ButtonClear.Enabled = enabled
   End Sub

   Public Sub NewValues()
      If c_plotGraph And c_defIndex >= 0
         If m_robotMode > 1
            PlotGraph(m_robotValue(m_graphList(c_defIndex).ValueIndex))
         Else
            c_plotStart = True
            c_drawTimeLine = False
            TimerTimeLine.Enabled = False
         End if
      End If
   End Sub

   Private Sub PlotGraph(value As Double)
      Static lastY   As Integer = 0

      Dim map        As New Bitmap(c_graphWidth, c_graphHeight)
      Dim graph      As Graphics = Graphics.FromImage(map)
      Dim newY       As Integer
      Dim xStart     As Integer
      Dim xEnd       As Integer

      If value > c_graphMax
         newY = c_graphHeight
      ElseIf value < c_graphMin
         newY = 0
      Else
         newY = c_graphHeight - (c_graphHeight * (value - c_graphMin) / c_graphRange)
      End If

      If c_graphX < c_graphWidth
         c_graphX += c_graphXstep
         xStart = c_graphX - c_graphXstep
         xEnd = c_graphX
         graph.DrawImage(PBGraph.Image, 0, 0)
      Else 
         xStart = c_graphX - c_graphXstep - 1
         xEnd = c_graphX - 1
         graph.DrawImage(PBGraph.Image, -c_graphXstep, 0)
      End If

      For i As Integer = c_graphHeight To 0 Step -c_graphTickPixels
         graph.DrawLine(Pens.Blue, c_graphX - c_graphXstep, i, c_graphX, i)
      Next

      If c_plotStart
         c_plotStart = False
         lastY = newY
         Dim verticalPen   As New Pen(Brushes.Black)
         verticalPen.Width = 3.0
         graph.DrawLine(verticalPen, c_graphX - c_graphXstep, 0, c_graphX - c_graphXstep, c_graphHeight)
         TimerTimeLine.Enabled = True
      End If

      If c_drawTimeLine
         c_drawTimeLine = False
         graph.DrawLine(Pens.Blue, c_graphX - 1, 0, c_graphX - 1, c_graphHeight)
      End If

      graph.DrawLine(Pens.Red, xStart, lastY, xEnd, newY)

      PBGraph.Image = map
      PBGraph.Refresh()
      graph.Dispose()

      lastY = newY
   End Sub

   Private Sub PlotScale()
      Dim labelCount    As Integer = PBGraph.Height \ (c_graphTick * c_pixelsPerUnit)
      Dim labelFont     As Font = New Font("Verdana", 8)
      Dim labelY        As Integer = PBGraph.Location.Y + PBGraph.Size.Height - 12
      Dim labelValue    As Integer = c_graphMin
      Dim newLabel      As Label

      If c_labelList.Count > 0 Then ClearScale()

      For i As Integer = 0 To labelCount
         newLabel = New Label
         newLabel.AutoSize = False
         newLabel.Left = 0
         newLabel.Top = labelY
         newLabel.Width = 40
         newLabel.Font = labelFont
         newLabel.TextAlign = ContentAlignment.MiddleRight
         newLabel.Text = labelValue.ToString
         Me.Controls.Add(newLabel)
         c_labelList.Add(newLabel)

         labelValue += c_graphTick
         labelY -= c_graphTickPixels

         If labelValue > c_graphMax Then Exit For
      Next

      c_plotScale = False
   End Sub 

   Private Sub Revised(state As Boolean)
      If c_revised <> state
         c_revised = state
         LabelRevised.Visible = state
      End If
   End Sub

   Private Sub Text_GotFocus(sender As Object, e As EventArgs) Handles TextMin.GotFocus, TextMax.GotFocus, TextTick.GotFocus
      Dim box As TextBox = CType(sender, TextBox)
      box.SelectAll
   End Sub

   Private Sub Text_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextMin.KeyPress, TextMax.KeyPress, TextTick.KeyPress
      Dim box As TextBox = CType(sender, TextBox)

      If box.Tag = 2
         e.KeyChar = TextBoxKeyPress(TextBoxType.PositiveInteger, e.KeyChar)
      Else
         e.KeyChar = TextBoxKeyPress(TextBoxType.AnyInteger, e.KeyChar)
      End If

      Revised(True)
   End Sub

   Private Sub Text_Validating(sender As Object, e As CancelEventArgs) Handles TextMin.Validating, TextMax.Validating, TextTick.Validating
      Dim box As TextBox = CType(sender, TextBox)
      Dim value As Long = CLng(box.Text)

      If c_defIndex >= 0
         Select box.Tag
            Case 0
               If Math.Abs(value) > 1000
                  Dim result As DialogResult = MessageBox.Show(Me, "Minimum Value range = -1000 to 1000.", c_formName, MessageBoxButtons.OK,
                                                               MessageBoxIcon.Information)
                  TextMin.Text = m_graphList(c_defIndex).Minimum.ToString
                  e.Cancel = True 
               ElseIf value > CInt(TextMax.Text)
                  Dim result As DialogResult = MessageBox.Show(Me, "Minimum Value cannot be greater than Maximum value.", c_formName, 
                                                               MessageBoxButtons.OK, MessageBoxIcon.Information)
                  TextMin.Text = TextMax.Text
                  e.Cancel = True   
               End If

            Case 1
               If Math.Abs(value) > 1000
                  Dim result As DialogResult = MessageBox.Show(Me, "Maximum Value range = -1000 to 1000.", c_formName, MessageBoxButtons.OK,
                                                               MessageBoxIcon.Information)
                  TextMin.Text = m_graphList(c_defIndex).Maximum.ToString
                  e.Cancel = True 
               ElseIf value < CInt(TextMin.Text)
                  Dim result As DialogResult = MessageBox.Show(Me, "Maximum Value cannot be less than Minimum value.", c_formName, 
                                                               MessageBoxButtons.OK, MessageBoxIcon.Information)
                  TextMax.Text = TextMin.Text
                  e.Cancel = True   
               End If 

            Case 2
               Dim range   As Integer = CInt(TextMax.Text) - CInt(TextMin.Text)

               If Math.Abs(value) > 1000
                  Dim result As DialogResult = MessageBox.Show(Me, "Tick Spacing range = -1000 to 1000.", c_formName, MessageBoxButtons.OK,
                                                               MessageBoxIcon.Information)
                  TextTick.Text = m_graphList(c_defIndex).TickSpacing.ToString
                  e.Cancel = True 

               ElseIf value > range
                  Dim result As DialogResult = MessageBox.Show(Me, "Tick Spacing cannot be greater than the range defined by the " &
                                                               "Minimum and Maximum Values.", c_formName, MessageBoxButtons.OK,
                                                               MessageBoxIcon.Information)
                  TextTick.Text = "0"
                  e.Cancel = True 

               ElseIf range / value > 25
                  Dim tickMin As Integer = range \ 25
                  Dim result As DialogResult = MessageBox.Show(Me, "Minimum Tick Spacing for this range is " & tickMin.ToString,
                                                               c_formName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                  TextTick.Text = tickMin.ToString
                  e.Cancel = True
               End If

         End Select
      End If
   End Sub

   Private Sub TimerTimeLine_Tick(sender As Object, e As EventArgs) Handles TimerTimeLine.Tick
      c_drawTimeLine = True
      TimerTimeLine.Start()
   End Sub

   Private Sub TimerPlot_Tick(sender As Object, e As EventArgs) Handles TimerPlot.Tick
      Static Yvalue As Double = 5

      Yvalue += 1
      If Yvalue > 20 Then Yvalue = 5

      if c_plotGraph Then PlotGraph(Yvalue)
   End Sub

   Public Sub UpdateRobotStatus()
      LabelNoRobot.Visible = Not m_robotConnected
   End Sub
End Class