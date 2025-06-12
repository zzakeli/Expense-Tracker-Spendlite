<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MonthForm
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
        cancelButton = New Button()
        okayButton = New Button()
        monthPicker = New DateTimePicker()
        selectMonthLabel = New Label()
        SuspendLayout()
        ' 
        ' cancelButton
        ' 
        cancelButton.Location = New Point(251, 201)
        cancelButton.Name = "cancelButton"
        cancelButton.Size = New Size(94, 29)
        cancelButton.TabIndex = 7
        cancelButton.Text = "Cancel"
        cancelButton.UseVisualStyleBackColor = True
        ' 
        ' okayButton
        ' 
        okayButton.Location = New Point(104, 201)
        okayButton.Name = "okayButton"
        okayButton.Size = New Size(94, 29)
        okayButton.TabIndex = 6
        okayButton.Text = "Okay"
        okayButton.UseVisualStyleBackColor = True
        ' 
        ' monthPicker
        ' 
        monthPicker.AllowDrop = True
        monthPicker.CustomFormat = "MMMM yyyy"
        monthPicker.Format = DateTimePickerFormat.Custom
        monthPicker.Location = New Point(104, 118)
        monthPicker.Name = "monthPicker"
        monthPicker.ShowUpDown = True
        monthPicker.Size = New Size(241, 27)
        monthPicker.TabIndex = 5
        ' 
        ' selectMonthLabel
        ' 
        selectMonthLabel.AutoSize = True
        selectMonthLabel.Location = New Point(176, 56)
        selectMonthLabel.Name = "selectMonthLabel"
        selectMonthLabel.Size = New Size(115, 20)
        selectMonthLabel.TabIndex = 4
        selectMonthLabel.Text = "SELECT MONTH"
        ' 
        ' MonthForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        ClientSize = New Size(448, 286)
        Controls.Add(cancelButton)
        Controls.Add(okayButton)
        Controls.Add(monthPicker)
        Controls.Add(selectMonthLabel)
        FormBorderStyle = FormBorderStyle.None
        Name = "MonthForm"
        Text = "MonthForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cancelButton As Button
    Friend WithEvents okayButton As Button
    Friend WithEvents monthPicker As DateTimePicker
    Friend WithEvents selectMonthLabel As Label
End Class
