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
        selectDayLabelPanel = New Panel()
        selectDayLabelPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' selectDayLabel
        ' 
        selectDayLabel.AutoSize = True
        selectDayLabel.Font = New Font("Roboto Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        selectDayLabel.Location = New Point(16, 7)
        selectDayLabel.Name = "selectDayLabel"
        selectDayLabel.Size = New Size(124, 28)
        selectDayLabel.TabIndex = 0
        selectDayLabel.Text = "SELECT DAY"
        ' 
        ' dayPicker
        ' 
        dayPicker.CustomFormat = "yyyy-MM-dd"
        dayPicker.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dayPicker.Format = DateTimePickerFormat.Custom
        dayPicker.Location = New Point(44, 124)
        dayPicker.Name = "dayPicker"
        dayPicker.Size = New Size(156, 32)
        dayPicker.TabIndex = 1
        ' 
        ' okayButton
        ' 
        okayButton.BackColor = SystemColors.Window
        okayButton.FlatAppearance.BorderColor = SystemColors.Window
        okayButton.FlatStyle = FlatStyle.Flat
        okayButton.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        okayButton.Location = New Point(66, 176)
        okayButton.Name = "okayButton"
        okayButton.Size = New Size(117, 39)
        okayButton.TabIndex = 2
        okayButton.Text = "Okay"
        okayButton.UseVisualStyleBackColor = False
        ' 
        ' selectDayLabelPanel
        ' 
        selectDayLabelPanel.BackColor = SystemColors.Window
        selectDayLabelPanel.Controls.Add(selectDayLabel)
        selectDayLabelPanel.Location = New Point(44, 35)
        selectDayLabelPanel.Name = "selectDayLabelPanel"
        selectDayLabelPanel.Size = New Size(156, 42)
        selectDayLabelPanel.TabIndex = 3
        ' 
        ' DayForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(98), CByte(129), CByte(181))
        ClientSize = New Size(245, 253)
        Controls.Add(okayButton)
        Controls.Add(dayPicker)
        Controls.Add(selectDayLabelPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "DayForm"
        Text = "DayForm"
        selectDayLabelPanel.ResumeLayout(False)
        selectDayLabelPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents selectDayLabel As Label
    Friend WithEvents dayPicker As DateTimePicker
    Friend WithEvents okayButton As Button
    Friend WithEvents selectDayLabelPanel As Panel
End Class
