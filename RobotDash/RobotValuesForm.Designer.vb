﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RobotValuesForm
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
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RobotValuesForm))
      Me.Label1 = New System.Windows.Forms.Label()
      Me.GridValues = New System.Windows.Forms.DataGridView()
      Me.colDvIndex = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.colDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.colValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
      Me.LabelNoRobot = New System.Windows.Forms.Label()
      CType(Me.GridValues,System.ComponentModel.ISupportInitialize).BeginInit
      Me.SuspendLayout
      '
      'Label1
      '
      Me.Label1.BackColor = System.Drawing.Color.Aqua
      Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label1.ForeColor = System.Drawing.Color.Black
      Me.Label1.Location = New System.Drawing.Point(5, 5)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(360, 20)
      Me.Label1.TabIndex = 8
      Me.Label1.Text = "ROBOT VALUES"
      Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'GridValues
      '
      Me.GridValues.AllowUserToAddRows = false
      Me.GridValues.AllowUserToDeleteRows = false
      Me.GridValues.AllowUserToResizeColumns = false
      Me.GridValues.AllowUserToResizeRows = false
      Me.GridValues.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
      Me.GridValues.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(215,Byte),Integer), CType(CType(215,Byte),Integer), CType(CType(215,Byte),Integer))
      Me.GridValues.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
      DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      DataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua
      DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
      DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.GridValues.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
      Me.GridValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
      Me.GridValues.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDvIndex, Me.colDesc, Me.colValue})
      DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
      DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
      DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
      DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window
      DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
      DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
      Me.GridValues.DefaultCellStyle = DataGridViewCellStyle4
      Me.GridValues.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
      Me.GridValues.EnableHeadersVisualStyles = false
      Me.GridValues.Location = New System.Drawing.Point(5, 23)
      Me.GridValues.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
      Me.GridValues.MultiSelect = false
      Me.GridValues.Name = "GridValues"
      DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle5.BackColor = System.Drawing.Color.Aqua
      DataGridViewCellStyle5.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
      DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.GridValues.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
      Me.GridValues.RowHeadersVisible = false
      Me.GridValues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
      Me.GridValues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
      Me.GridValues.Size = New System.Drawing.Size(360, 355)
      Me.GridValues.TabIndex = 7
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
      Me.colValue.ReadOnly = true
      Me.colValue.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
      Me.colValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
      Me.colValue.Width = 90
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
      Me.LabelNoRobot.TabIndex = 12
      Me.LabelNoRobot.Text = "Not Connected"
      Me.LabelNoRobot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'RobotValuesForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 14!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225,Byte),Integer), CType(CType(230,Byte),Integer), CType(CType(245,Byte),Integer))
      Me.ClientSize = New System.Drawing.Size(371, 384)
      Me.Controls.Add(Me.LabelNoRobot)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.GridValues)
      Me.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
      Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
      Me.MaximizeBox = false
      Me.MaximumSize = New System.Drawing.Size(387, 819)
      Me.MinimumSize = New System.Drawing.Size(387, 313)
      Me.Name = "RobotValuesForm"
      Me.Text = "ROBOT VALUES"
      CType(Me.GridValues,System.ComponentModel.ISupportInitialize).EndInit
      Me.ResumeLayout(false)

End Sub

   Friend WithEvents Label1 As Label
   Friend WithEvents GridValues As DataGridView
   Friend WithEvents colDvIndex As DataGridViewTextBoxColumn
   Friend WithEvents colDesc As DataGridViewTextBoxColumn
   Friend WithEvents colValue As DataGridViewTextBoxColumn
   Friend WithEvents LabelNoRobot As Label
End Class
