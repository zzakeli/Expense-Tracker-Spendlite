<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DayForm
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
        selectDayLabel = New Label()
        dayPicker = New DateTimePicker()
        okayButton = New Button()
        cancelButton = New Button()
        SuspendLayout()
        ' 
        ' selectDayLabel
        ' 
        selectDayLabel.AutoSize = True
        selectDayLabel.Location = New Point(146, 20)
        selectDayLabel.Name = "selectDayLabel"
        selectDayLabel.Size = New Size(89, 20)
        selectDayLabel.TabIndex = 0
        selectDayLabel.Text = "SELECT DAY"
        ' 
        ' dayPicker
        ' 
        dayPicker.CustomFormat = "yyyy-MM-dd"
        dayPicker.Format = DateTimePickerFormat.Custom
        dayPicker.Location = New Point(74, 82)
        dayPicker.Name = "dayPicker"
        dayPicker.Size = New Size(241, 27)
        dayPicker.TabIndex = 1
        ' 
        ' okayButton
        ' 
        okayButton.Location = New Point(74, 165)
        okayButton.Name = "okayButton"
        okayButton.Size = New Size(94, 29)
        okayButton.TabIndex = 2
        okayButton.Text = "Okay"
        okayButton.UseVisualStyleBackColor = True
        ' 
        ' cancelButton
        ' 
        cancelButton.Location = New Point(221, 165)
        cancelButton.Name = "cancelButton"
        cancelButton.Size = New Size(94, 29)
        cancelButton.TabIndex = 3
        cancelButton.Text = "Cancel"
        cancelButton.UseVisualStyleBackColor = True
        ' 
        ' DayForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        ClientSize = New Size(388, 253)
        Controls.Add(cancelButton)
        Controls.Add(okayButton)
        Controls.Add(dayPicker)
        Controls.Add(selectDayLabel)
        FormBorderStyle = FormBorderStyle.None
        Name = "DayForm"
        Text = "DayForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents selectDayLabel As Label
    Friend WithEvents dayPicker As DateTimePicker
    Friend WithEvents okayButton As Button
    Friend WithEvents cancelButton As Button
End Class
