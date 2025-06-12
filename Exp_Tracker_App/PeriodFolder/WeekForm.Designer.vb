<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WeekForm
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
        selectWeekLabel = New Label()
        weekComboBox = New ComboBox()
        SuspendLayout()
        ' 
        ' cancelButton
        ' 
        cancelButton.Location = New Point(217, 178)
        cancelButton.Name = "cancelButton"
        cancelButton.Size = New Size(94, 29)
        cancelButton.TabIndex = 7
        cancelButton.Text = "Cancel"
        cancelButton.UseVisualStyleBackColor = True
        ' 
        ' okayButton
        ' 
        okayButton.Location = New Point(70, 178)
        okayButton.Name = "okayButton"
        okayButton.Size = New Size(94, 29)
        okayButton.TabIndex = 6
        okayButton.Text = "Okay"
        okayButton.UseVisualStyleBackColor = True
        ' 
        ' selectWeekLabel
        ' 
        selectWeekLabel.AutoSize = True
        selectWeekLabel.Location = New Point(136, 33)
        selectWeekLabel.Name = "selectWeekLabel"
        selectWeekLabel.Size = New Size(109, 20)
        selectWeekLabel.TabIndex = 4
        selectWeekLabel.Text = "SELECT RANGE"
        ' 
        ' weekComboBox
        ' 
        weekComboBox.FormattingEnabled = True
        weekComboBox.Location = New Point(70, 95)
        weekComboBox.Name = "weekComboBox"
        weekComboBox.Size = New Size(241, 28)
        weekComboBox.TabIndex = 8
        ' 
        ' WeekForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        ClientSize = New Size(391, 284)
        Controls.Add(weekComboBox)
        Controls.Add(cancelButton)
        Controls.Add(okayButton)
        Controls.Add(selectWeekLabel)
        FormBorderStyle = FormBorderStyle.None
        Name = "WeekForm"
        Text = "WeekForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cancelButton As Button
    Friend WithEvents okayButton As Button
    Friend WithEvents selectWeekLabel As Label
    Friend WithEvents weekComboBox As ComboBox
End Class
