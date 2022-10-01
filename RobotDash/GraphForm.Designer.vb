<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GraphForm
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GraphForm))
      Me.PBGraph = New System.Windows.Forms.PictureBox()
      Me.ListGraph = New System.Windows.Forms.ComboBox()
      Me.Label0 = New System.Windows.Forms.Label()
      Me.ButtonStart = New System.Windows.Forms.Button()
      Me.ButtonClear = New System.Windows.Forms.Button()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.TextTick = New System.Windows.Forms.TextBox()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.TextMax = New System.Windows.Forms.TextBox()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.TextMin = New System.Windows.Forms.TextBox()
      Me.LabelRevised = New System.Windows.Forms.Label()
      Me.TimerPlot = New System.Windows.Forms.Timer(Me.components)
      Me.LabelNoRobot = New System.Windows.Forms.Label()
      Me.TimerTimeLine = New System.Windows.Forms.Timer(Me.components)
      CType(Me.PBGraph,System.ComponentModel.ISupportInitialize).BeginInit
      Me.SuspendLayout
      '
      'PBGraph
      '
      Me.PBGraph.BackColor = System.Drawing.Color.White
      Me.PBGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.PBGraph.Image = Global.RobotDash.My.Resources.Resources.Whitebackground
      Me.PBGraph.Location = New System.Drawing.Point(40, 66)
      Me.PBGraph.Name = "PBGraph"
      Me.PBGraph.Size = New System.Drawing.Size(751, 401)
      Me.PBGraph.TabIndex = 3
      Me.PBGraph.TabStop = false
      '
      'ListGraph
      '
      Me.ListGraph.BackColor = System.Drawing.SystemColors.Window
      Me.ListGraph.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.ListGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.ListGraph.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.ListGraph.FormattingEnabled = true
      Me.ListGraph.ImeMode = System.Windows.Forms.ImeMode.Hangul
      Me.ListGraph.Items.AddRange(New Object() {"None"})
      Me.ListGraph.Location = New System.Drawing.Point(41, 33)
      Me.ListGraph.Name = "ListGraph"
      Me.ListGraph.Size = New System.Drawing.Size(182, 24)
      Me.ListGraph.TabIndex = 0
      Me.ListGraph.Tag = "1"
      '
      'Label0
      '
      Me.Label0.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label0.Location = New System.Drawing.Point(41, 8)
      Me.Label0.Name = "Label0"
      Me.Label0.Size = New System.Drawing.Size(165, 20)
      Me.Label0.TabIndex = 6
      Me.Label0.Text = "Graph Selection"
      Me.Label0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'ButtonStart
      '
      Me.ButtonStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(190,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(190,Byte),Integer))
      Me.ButtonStart.Enabled = false
      Me.ButtonStart.Location = New System.Drawing.Point(645, 27)
      Me.ButtonStart.Name = "ButtonStart"
      Me.ButtonStart.Size = New System.Drawing.Size(70, 30)
      Me.ButtonStart.TabIndex = 4
      Me.ButtonStart.Text = "Start"
      Me.ButtonStart.UseVisualStyleBackColor = false
      '
      'ButtonClear
      '
      Me.ButtonClear.Enabled = false
      Me.ButtonClear.Location = New System.Drawing.Point(721, 27)
      Me.ButtonClear.Name = "ButtonClear"
      Me.ButtonClear.Size = New System.Drawing.Size(70, 30)
      Me.ButtonClear.TabIndex = 5
      Me.ButtonClear.Text = "Clear"
      Me.ButtonClear.UseVisualStyleBackColor = true
      '
      'Label3
      '
      Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label3.Location = New System.Drawing.Point(474, 0)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(70, 32)
      Me.Label3.TabIndex = 19
      Me.Label3.Text = "Tick Spacing"
      Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'TextTick
      '
      Me.TextTick.BackColor = System.Drawing.SystemColors.Window
      Me.TextTick.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.TextTick.Location = New System.Drawing.Point(474, 34)
      Me.TextTick.Name = "TextTick"
      Me.TextTick.Size = New System.Drawing.Size(70, 23)
      Me.TextTick.TabIndex = 3
      Me.TextTick.Tag = "2"
      Me.TextTick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'Label2
      '
      Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label2.Location = New System.Drawing.Point(399, 0)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(70, 32)
      Me.Label2.TabIndex = 18
      Me.Label2.Text = "Maximum Value"
      Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'TextMax
      '
      Me.TextMax.BackColor = System.Drawing.SystemColors.Window
      Me.TextMax.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.TextMax.Location = New System.Drawing.Point(399, 34)
      Me.TextMax.Name = "TextMax"
      Me.TextMax.Size = New System.Drawing.Size(70, 23)
      Me.TextMax.TabIndex = 2
      Me.TextMax.Tag = "1"
      Me.TextMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'Label1
      '
      Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label1.Location = New System.Drawing.Point(324, 0)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(70, 32)
      Me.Label1.TabIndex = 17
      Me.Label1.Text = "Minimum Value"
      Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'TextMin
      '
      Me.TextMin.BackColor = System.Drawing.SystemColors.Window
      Me.TextMin.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.TextMin.Location = New System.Drawing.Point(324, 34)
      Me.TextMin.Name = "TextMin"
      Me.TextMin.Size = New System.Drawing.Size(70, 23)
      Me.TextMin.TabIndex = 1
      Me.TextMin.Tag = "0"
      Me.TextMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'LabelRevised
      '
      Me.LabelRevised.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelRevised.ForeColor = System.Drawing.Color.Red
      Me.LabelRevised.Location = New System.Drawing.Point(679, 0)
      Me.LabelRevised.Name = "LabelRevised"
      Me.LabelRevised.Size = New System.Drawing.Size(78, 16)
      Me.LabelRevised.TabIndex = 20
      Me.LabelRevised.Text = "Revised"
      Me.LabelRevised.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      Me.LabelRevised.Visible = false
      '
      'TimerPlot
      '
      Me.TimerPlot.Interval = 50
      '
      'LabelNoRobot
      '
      Me.LabelNoRobot.BackColor = System.Drawing.Color.Yellow
      Me.LabelNoRobot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelNoRobot.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelNoRobot.ForeColor = System.Drawing.Color.Red
      Me.LabelNoRobot.Location = New System.Drawing.Point(681, 66)
      Me.LabelNoRobot.Name = "LabelNoRobot"
      Me.LabelNoRobot.Size = New System.Drawing.Size(110, 20)
      Me.LabelNoRobot.TabIndex = 21
      Me.LabelNoRobot.Text = "Not Connected"
      Me.LabelNoRobot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'TimerTimeLine
      '
      Me.TimerTimeLine.Interval = 5000
      '
      'GraphForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 14!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225,Byte),Integer), CType(CType(230,Byte),Integer), CType(CType(245,Byte),Integer))
      Me.ClientSize = New System.Drawing.Size(801, 477)
      Me.Controls.Add(Me.LabelNoRobot)
      Me.Controls.Add(Me.LabelRevised)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.ButtonClear)
      Me.Controls.Add(Me.TextTick)
      Me.Controls.Add(Me.ButtonStart)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label0)
      Me.Controls.Add(Me.TextMax)
      Me.Controls.Add(Me.ListGraph)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.TextMin)
      Me.Controls.Add(Me.PBGraph)
      Me.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
      Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
      Me.MaximizeBox = false
      Me.Name = "GraphForm"
      Me.Text = "GRAPH PLOTTER"
      CType(Me.PBGraph,System.ComponentModel.ISupportInitialize).EndInit
      Me.ResumeLayout(false)
      Me.PerformLayout

End Sub

   Friend WithEvents PBGraph As PictureBox
   Friend WithEvents ListGraph As ComboBox
   Friend WithEvents Label0 As Label
   Friend WithEvents ButtonStart As Button
   Friend WithEvents ButtonClear As Button
   Friend WithEvents Label3 As Label
   Friend WithEvents TextTick As TextBox
   Friend WithEvents Label2 As Label
   Friend WithEvents TextMax As TextBox
   Friend WithEvents Label1 As Label
   Friend WithEvents TextMin As TextBox
   Friend WithEvents LabelRevised As Label
   Friend WithEvents TimerPlot As Timer
   Friend WithEvents LabelNoRobot As Label
   Friend WithEvents TimerTimeLine As Timer
End Class
