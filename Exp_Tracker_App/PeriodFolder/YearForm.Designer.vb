<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YearForm
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
        yearPicker = New DateTimePicker()
        selectYearLabel = New Label()
        SuspendLayout()
        ' 
        ' cancelButton
        ' 
        cancelButton.Location = New Point(242, 195)
        cancelButton.Name = "cancelButton"
        cancelButton.Size = New Size(94, 29)
        cancelButton.TabIndex = 11
        cancelButton.Text = "Cancel"
        cancelButton.UseVisualStyleBackColor = True
        ' 
        ' okayButton
        ' 
        okayButton.Location = New Point(95, 195)
        okayButton.Name = "okayButton"
        okayButton.Size = New Size(94, 29)
        okayButton.TabIndex = 10
        okayButton.Text = "Okay"
        okayButton.UseVisualStyleBackColor = True
        ' 
        ' yearPicker
        ' 
        yearPicker.AllowDrop = True
        yearPicker.CustomFormat = "yyyy"
        yearPicker.Format = DateTimePickerFormat.Custom
        yearPicker.Location = New Point(95, 112)
        yearPicker.Name = "yearPicker"
        yearPicker.ShowUpDown = True
        yearPicker.Size = New Size(241, 27)
        yearPicker.TabIndex = 9
        ' 
        ' selectYearLabel
        ' 
        selectYearLabel.AutoSize = True
        selectYearLabel.Location = New Point(167, 50)
        selectYearLabel.Name = "selectYearLabel"
        selectYearLabel.Size = New Size(96, 20)
        selectYearLabel.TabIndex = 8
        selectYearLabel.Text = "SELECT YEAR"
        ' 
        ' YearForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        ClientSize = New Size(430, 275)
        Controls.Add(cancelButton)
        Controls.Add(okayButton)
        Controls.Add(yearPicker)
        Controls.Add(selectYearLabel)
        FormBorderStyle = FormBorderStyle.None
        Name = "YearForm"
        Text = "YearForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cancelButton As Button
    Friend WithEvents okayButton As Button
    Friend WithEvents yearPicker As DateTimePicker
    Friend WithEvents selectYearLabel As Label
End Class
