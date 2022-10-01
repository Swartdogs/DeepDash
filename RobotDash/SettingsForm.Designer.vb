<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
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
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsForm))
      Me.LabelSettings = New System.Windows.Forms.Label()
      Me.GridSetting = New System.Windows.Forms.DataGridView()
      Me.colDvIndex = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.colDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.colValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.colFromRobot = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.TimerError = New System.Windows.Forms.Timer(Me.components)
      Me.PanelSave = New System.Windows.Forms.Panel()
      Me.ButtonCancel = New System.Windows.Forms.Button()
      Me.ButtonSend = New System.Windows.Forms.Button()
      Me.PanelMismatch = New System.Windows.Forms.Panel()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.ButtonClose = New System.Windows.Forms.Button()
      Me.ButtonRobot = New System.Windows.Forms.Button()
      Me.ButtonDash = New System.Windows.Forms.Button()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label0 = New System.Windows.Forms.Label()
      Me.LabelNoRobot = New System.Windows.Forms.Label()
      CType(Me.GridSetting,System.ComponentModel.ISupportInitialize).BeginInit
      Me.PanelSave.SuspendLayout
      Me.PanelMismatch.SuspendLayout
      Me.SuspendLayout
      '
      'LabelSettings
      '
      Me.LabelSettings.BackColor = System.Drawing.Color.Aqua
      Me.LabelSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelSettings.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelSettings.ForeColor = System.Drawing.Color.Black
      Me.LabelSettings.Location = New System.Drawing.Point(5, 5)
      Me.LabelSettings.Name = "LabelSettings"
      Me.LabelSettings.Size = New System.Drawing.Size(360, 20)
      Me.LabelSettings.TabIndex = 6
      Me.LabelSettings.Text = "ROBOT SETTINGS"
      Me.LabelSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'GridSetting
      '
      Me.GridSetting.AllowUserToAddRows = false
      Me.GridSetting.AllowUserToDeleteRows = false
      Me.GridSetting.AllowUserToResizeColumns = false
      Me.GridSetting.AllowUserToResizeRows = false
      Me.GridSetting.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
      Me.GridSetting.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(215,Byte),Integer), CType(CType(215,Byte),Integer), CType(CType(215,Byte),Integer))
      Me.GridSetting.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
      DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      DataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua
      DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
      DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.GridSetting.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
      Me.GridSetting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
      Me.GridSetting.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDvIndex, Me.colDesc, Me.colValue, Me.colFromRobot})
      DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
      DataGridViewCellStyle5.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
      DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Window
      DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText
      DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
      Me.GridSetting.DefaultCellStyle = DataGridViewCellStyle5
      Me.GridSetting.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
      Me.GridSetting.EnableHeadersVisualStyles = false
      Me.GridSetting.Location = New System.Drawing.Point(5, 23)
      Me.GridSetting.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
      Me.GridSetting.MultiSelect = false
      Me.GridSetting.Name = "GridSetting"
      DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle6.BackColor = System.Drawing.Color.Aqua
      DataGridViewCellStyle6.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
      DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.GridSetting.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
      Me.GridSetting.RowHeadersVisible = false
      Me.GridSetting.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.GridSetting.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
      Me.GridSetting.Size = New System.Drawing.Size(360, 355)
      Me.GridSetting.TabIndex = 0
      '
      'colDvIndex
      '
      Me.colDvIndex.HeaderText = "Index"
      Me.colDvIndex.Name = "colDvIndex"
      Me.colDvIndex.ReadOnly = true
      Me.colDvIndex.Visible = false
      Me.colDvIndex.Width = 10
      '
      'colDesc
      '
      Me.colDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
      DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan
      DataGridViewCellStyle2.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCyan
      Me.colDesc.DefaultCellStyle = DataGridViewCellStyle2
      Me.colDesc.HeaderText = "Description"
      Me.colDesc.Name = "colDesc"
      Me.colDesc.ReadOnly = true
      Me.colDesc.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
      Me.colDesc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
      Me.colDesc.Width = 250
      '
      'colValue
      '
      Me.colValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
      DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      Me.colValue.DefaultCellStyle = DataGridViewCellStyle3
      Me.colValue.HeaderText = "Value"
      Me.colValue.Name = "colValue"
      Me.colValue.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
      Me.colValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
      Me.colValue.Width = 90
      '
      'colFromRobot
      '
      DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      Me.colFromRobot.DefaultCellStyle = DataGridViewCellStyle4
      Me.colFromRobot.HeaderText = "Robot Value"
      Me.colFromRobot.Name = "colFromRobot"
      Me.colFromRobot.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
      Me.colFromRobot.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
      Me.colFromRobot.Visible = false
      Me.colFromRobot.Width = 90
      '
      'TimerError
      '
      Me.TimerError.Interval = 10
      '
      'PanelSave
      '
      Me.PanelSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
      Me.PanelSave.Controls.Add(Me.ButtonCancel)
      Me.PanelSave.Controls.Add(Me.ButtonSend)
      Me.PanelSave.Location = New System.Drawing.Point(5, 384)
      Me.PanelSave.Name = "PanelSave"
      Me.PanelSave.Size = New System.Drawing.Size(360, 35)
      Me.PanelSave.TabIndex = 7
      '
      'ButtonCancel
      '
      Me.ButtonCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(225,Byte),Integer), CType(CType(230,Byte),Integer), CType(CType(245,Byte),Integer))
      Me.ButtonCancel.Enabled = false
      Me.ButtonCancel.Location = New System.Drawing.Point(184, 2)
      Me.ButtonCancel.Name = "ButtonCancel"
      Me.ButtonCancel.Size = New System.Drawing.Size(110, 30)
      Me.ButtonCancel.TabIndex = 4
      Me.ButtonCancel.Text = "Cancel"
      Me.ButtonCancel.UseVisualStyleBackColor = false
      '
      'ButtonSend
      '
      Me.ButtonSend.Enabled = false
      Me.ButtonSend.Location = New System.Drawing.Point(68, 2)
      Me.ButtonSend.Name = "ButtonSend"
      Me.ButtonSend.Size = New System.Drawing.Size(110, 30)
      Me.ButtonSend.TabIndex = 3
      Me.ButtonSend.Text = "Save and Send"
      Me.ButtonSend.UseVisualStyleBackColor = true
      '
      'PanelMismatch
      '
      Me.PanelMismatch.Controls.Add(Me.Label2)
      Me.PanelMismatch.Controls.Add(Me.ButtonClose)
      Me.PanelMismatch.Controls.Add(Me.ButtonRobot)
      Me.PanelMismatch.Controls.Add(Me.ButtonDash)
      Me.PanelMismatch.Controls.Add(Me.Label1)
      Me.PanelMismatch.Controls.Add(Me.Label0)
      Me.PanelMismatch.Location = New System.Drawing.Point(5, 384)
      Me.PanelMismatch.Name = "PanelMismatch"
      Me.PanelMismatch.Size = New System.Drawing.Size(450, 160)
      Me.PanelMismatch.TabIndex = 8
      Me.PanelMismatch.Visible = false
      '
      'Label2
      '
      Me.Label2.BackColor = System.Drawing.Color.Pink
      Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label2.Location = New System.Drawing.Point(17, 72)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(74, 22)
      Me.Label2.TabIndex = 15
      Me.Label2.Text = "Mismatch"
      Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'ButtonClose
      '
      Me.ButtonClose.BackColor = System.Drawing.SystemColors.ButtonFace
      Me.ButtonClose.Location = New System.Drawing.Point(100, 115)
      Me.ButtonClose.Name = "ButtonClose"
      Me.ButtonClose.Size = New System.Drawing.Size(260, 40)
      Me.ButtonClose.TabIndex = 14
      Me.ButtonClose.Text = "Cancel"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"(Use to select/add new Settings file)"
      Me.ButtonClose.UseVisualStyleBackColor = false
      '
      'ButtonRobot
      '
      Me.ButtonRobot.BackColor = System.Drawing.Color.Yellow
      Me.ButtonRobot.Location = New System.Drawing.Point(100, 70)
      Me.ButtonRobot.Name = "ButtonRobot"
      Me.ButtonRobot.Size = New System.Drawing.Size(260, 40)
      Me.ButtonRobot.TabIndex = 13
      Me.ButtonRobot.Text = "Use the ROBOT Values"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"(Dash values will be overwritten)"
      Me.ButtonRobot.UseVisualStyleBackColor = false
      '
      'ButtonDash
      '
      Me.ButtonDash.BackColor = System.Drawing.Color.SpringGreen
      Me.ButtonDash.Location = New System.Drawing.Point(100, 25)
      Me.ButtonDash.Name = "ButtonDash"
      Me.ButtonDash.Size = New System.Drawing.Size(260, 41)
      Me.ButtonDash.TabIndex = 12
      Me.ButtonDash.Text = "Use the DASH Values"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"(Dash values will be sent to Robot)"
      Me.ButtonDash.UseVisualStyleBackColor = false
      '
      'Label1
      '
      Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label1.Location = New System.Drawing.Point(12, 29)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(79, 32)
      Me.Label1.TabIndex = 10
      Me.Label1.Text = "Choose an option:"
      Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'Label0
      '
      Me.Label0.BackColor = System.Drawing.Color.WhiteSmoke
      Me.Label0.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label0.ForeColor = System.Drawing.Color.Red
      Me.Label0.Location = New System.Drawing.Point(24, 2)
      Me.Label0.Name = "Label0"
      Me.Label0.Size = New System.Drawing.Size(403, 18)
      Me.Label0.TabIndex = 9
      Me.Label0.Text = "Settings on the Robot and Dashboard do not match"
      Me.Label0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'LabelNoRobot
      '
      Me.LabelNoRobot.BackColor = System.Drawing.Color.Yellow
      Me.LabelNoRobot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.LabelNoRobot.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.LabelNoRobot.ForeColor = System.Drawing.Color.Red
      Me.LabelNoRobot.Location = New System.Drawing.Point(256, 5)
      Me.LabelNoRobot.Name = "LabelNoRobot"
      Me.LabelNoRobot.Size = New System.Drawing.Size(109, 20)
      Me.LabelNoRobot.TabIndex = 9
      Me.LabelNoRobot.Text = "Not Connected"
      Me.LabelNoRobot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'SettingsForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 14!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225,Byte),Integer), CType(CType(230,Byte),Integer), CType(CType(245,Byte),Integer))
      Me.ClientSize = New System.Drawing.Size(371, 428)
      Me.Controls.Add(Me.LabelNoRobot)
      Me.Controls.Add(Me.PanelSave)
      Me.Controls.Add(Me.PanelMismatch)
      Me.Controls.Add(Me.LabelSettings)
      Me.Controls.Add(Me.GridSetting)
      Me.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
      Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
      Me.MaximizeBox = false
      Me.MaximumSize = New System.Drawing.Size(387, 929)
      Me.MinimumSize = New System.Drawing.Size(387, 467)
      Me.Name = "SettingsForm"
      Me.Text = "ROBOT SETTINGS"
      CType(Me.GridSetting,System.ComponentModel.ISupportInitialize).EndInit
      Me.PanelSave.ResumeLayout(false)
      Me.PanelMismatch.ResumeLayout(false)
      Me.ResumeLayout(false)

End Sub

   Friend WithEvents LabelSettings As Label
   Friend WithEvents GridSetting As DataGridView
   Friend WithEvents TimerError As Timer
   Friend WithEvents colDvIndex As DataGridViewTextBoxColumn
   Friend WithEvents colDesc As DataGridViewTextBoxColumn
   Friend WithEvents colValue As DataGridViewTextBoxColumn
   Friend WithEvents colFromRobot As DataGridViewTextBoxColumn
   Friend WithEvents PanelSave As Panel
   Friend WithEvents ButtonCancel As Button
   Friend WithEvents ButtonSend As Button
   Friend WithEvents PanelMismatch As Panel
   Friend WithEvents Label1 As Label
   Friend WithEvents Label0 As Label
   Friend WithEvents Label2 As Label
   Friend WithEvents ButtonClose As Button
   Friend WithEvents ButtonRobot As Button
   Friend WithEvents ButtonDash As Button
   Friend WithEvents LabelNoRobot As Label
End Class
