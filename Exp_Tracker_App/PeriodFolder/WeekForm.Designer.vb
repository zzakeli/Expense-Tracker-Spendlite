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
        okayButton = New Button()
        selectWeekLabel = New Label()
        weekComboBox = New ComboBox()
        selectWeekLabelPanel = New Panel()
        selectWeekLabelPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' okayButton
        ' 
        okayButton.BackColor = SystemColors.Window
        okayButton.FlatAppearance.BorderColor = SystemColors.Window
        okayButton.FlatAppearance.BorderSize = 0
        okayButton.FlatStyle = FlatStyle.Flat
        okayButton.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        okayButton.Location = New Point(61, 176)
        okayButton.Name = "okayButton"
        okayButton.Size = New Size(117, 39)
        okayButton.TabIndex = 6
        okayButton.Text = "Okay"
        okayButton.UseVisualStyleBackColor = False
        ' 
        ' selectWeekLabel
        ' 
        selectWeekLabel.AutoSize = True
        selectWeekLabel.Font = New Font("Roboto Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        selectWeekLabel.Location = New Point(11, 7)
        selectWeekLabel.Name = "selectWeekLabel"
        selectWeekLabel.Size = New Size(151, 28)
        selectWeekLabel.TabIndex = 4
        selectWeekLabel.Text = "SELECT RANGE"
        ' 
        ' weekComboBox
        ' 
        weekComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        weekComboBox.FlatStyle = FlatStyle.Flat
        weekComboBox.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        weekComboBox.FormattingEnabled = True
        weekComboBox.Location = New Point(36, 124)
        weekComboBox.Name = "weekComboBox"
        weekComboBox.Size = New Size(170, 32)
        weekComboBox.TabIndex = 8
        ' 
        ' selectWeekLabelPanel
        ' 
        selectWeekLabelPanel.BackColor = SystemColors.Window
        selectWeekLabelPanel.Controls.Add(selectWeekLabel)
        selectWeekLabelPanel.Location = New Point(35, 35)
        selectWeekLabelPanel.Name = "selectWeekLabelPanel"
        selectWeekLabelPanel.Size = New Size(173, 42)
        selectWeekLabelPanel.TabIndex = 9
        ' 
        ' WeekForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(98), CByte(129), CByte(181))
        ClientSize = New Size(245, 253)
        Controls.Add(weekComboBox)
        Controls.Add(okayButton)
        Controls.Add(selectWeekLabelPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "WeekForm"
        Text = "WeekForm"
        selectWeekLabelPanel.ResumeLayout(False)
        selectWeekLabelPanel.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents okayButton As Button
    Friend WithEvents selectWeekLabel As Label
    Friend WithEvents weekComboBox As ComboBox
    Friend WithEvents selectWeekLabelPanel As Panel
End Class
