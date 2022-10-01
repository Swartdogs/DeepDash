<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadSettingsForm
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoadSettingsForm))
      Me.Label0 = New System.Windows.Forms.Label()
      Me.ListSettings = New System.Windows.Forms.ListBox()
      Me.ButtonCancel = New System.Windows.Forms.Button()
      Me.ButtonSave = New System.Windows.Forms.Button()
      Me.TextFile = New System.Windows.Forms.TextBox()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.SuspendLayout
      '
      'Label0
      '
      Me.Label0.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.Label0.Location = New System.Drawing.Point(10, 5)
      Me.Label0.Name = "Label0"
      Me.Label0.Size = New System.Drawing.Size(350, 20)
      Me.Label0.TabIndex = 3
      Me.Label0.Text = "Existing Settings Files"
      Me.Label0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'ListSettings
      '
      Me.ListSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.ListSettings.FormattingEnabled = true
      Me.ListSettings.ItemHeight = 14
      Me.ListSettings.Location = New System.Drawing.Point(10, 30)
      Me.ListSettings.Name = "ListSettings"
      Me.ListSettings.Size = New System.Drawing.Size(350, 86)
      Me.ListSettings.Sorted = true
      Me.ListSettings.TabIndex = 0
      '
      'ButtonCancel
      '
      Me.ButtonCancel.Location = New System.Drawing.Point(187, 183)
      Me.ButtonCancel.Name = "ButtonCancel"
      Me.ButtonCancel.Size = New System.Drawing.Size(78, 30)
      Me.ButtonCancel.TabIndex = 3
      Me.ButtonCancel.Text = "Cancel"
      Me.ButtonCancel.UseVisualStyleBackColor = true
      '
      'ButtonSave
      '
      Me.ButtonSave.Enabled = false
      Me.ButtonSave.Location = New System.Drawing.Point(107, 183)
      Me.ButtonSave.Name = "ButtonSave"
      Me.ButtonSave.Size = New System.Drawing.Size(78, 30)
      Me.ButtonSave.TabIndex = 2
      Me.ButtonSave.Text = "Save"
      Me.ButtonSave.UseVisualStyleBackColor = true
      '
      'TextFile
      '
      Me.TextFile.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.TextFile.Location = New System.Drawing.Point(10, 143)
      Me.TextFile.Name = "TextFile"
      Me.TextFile.Size = New System.Drawing.Size(350, 23)
      Me.TextFile.TabIndex = 1
      '
      'Label2
      '
      Me.Label2.Location = New System.Drawing.Point(10, 123)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(350, 20)
      Me.Label2.TabIndex = 7
      Me.Label2.Text = "New or Selected File"
      Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      '
      'LoadSettingsForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 14!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(225,Byte),Integer), CType(CType(230,Byte),Integer), CType(CType(245,Byte),Integer))
      Me.ClientSize = New System.Drawing.Size(370, 221)
      Me.Controls.Add(Me.TextFile)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.ButtonCancel)
      Me.Controls.Add(Me.ButtonSave)
      Me.Controls.Add(Me.Label0)
      Me.Controls.Add(Me.ListSettings)
      Me.Font = New System.Drawing.Font("Verdana", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
      Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
      Me.MaximizeBox = false
      Me.MinimizeBox = false
      Me.Name = "LoadSettingsForm"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
      Me.Text = "ROBOT SETTINGS FILE"
      Me.ResumeLayout(false)
      Me.PerformLayout

End Sub

   Friend WithEvents Label0 As Label
   Friend WithEvents ListSettings As ListBox
   Friend WithEvents ButtonCancel As Button
   Friend WithEvents ButtonSave As Button
   Friend WithEvents TextFile As TextBox
   Friend WithEvents Label2 As Label
End Class
