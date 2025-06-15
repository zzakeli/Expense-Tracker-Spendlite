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
        okayButton = New Button()
        monthPicker = New DateTimePicker()
        selectMonthLabel = New Label()
        selectMonthLabelPanel = New Panel()
        selectMonthLabelPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' okayButton
        ' 
        okayButton.BackColor = SystemColors.Window
        okayButton.FlatAppearance.BorderColor = SystemColors.Window
        okayButton.FlatAppearance.BorderSize = 0
        okayButton.FlatStyle = FlatStyle.Flat
        okayButton.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        okayButton.Location = New Point(65, 174)
        okayButton.Name = "okayButton"
        okayButton.Size = New Size(117, 39)
        okayButton.TabIndex = 6
        okayButton.Text = "Okay"
        okayButton.UseVisualStyleBackColor = False
        ' 
        ' monthPicker
        ' 
        monthPicker.AllowDrop = True
        monthPicker.CustomFormat = "MMMM yyyy"
        monthPicker.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        monthPicker.Format = DateTimePickerFormat.Custom
        monthPicker.Location = New Point(36, 122)
        monthPicker.Name = "monthPicker"
        monthPicker.ShowUpDown = True
        monthPicker.Size = New Size(170, 32)
        monthPicker.TabIndex = 5
        ' 
        ' selectMonthLabel
        ' 
        selectMonthLabel.AutoSize = True
        selectMonthLabel.Font = New Font("Roboto Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        selectMonthLabel.Location = New Point(14, 7)
        selectMonthLabel.Name = "selectMonthLabel"
        selectMonthLabel.Size = New Size(158, 28)
        selectMonthLabel.TabIndex = 4
        selectMonthLabel.Text = "SELECT MONTH"
        ' 
        ' selectMonthLabelPanel
        ' 
        selectMonthLabelPanel.BackColor = SystemColors.Window
        selectMonthLabelPanel.Controls.Add(selectMonthLabel)
        selectMonthLabelPanel.Location = New Point(30, 33)
        selectMonthLabelPanel.Name = "selectMonthLabelPanel"
        selectMonthLabelPanel.Size = New Size(184, 42)
        selectMonthLabelPanel.TabIndex = 7
        ' 
        ' MonthForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(98), CByte(129), CByte(181))
        ClientSize = New Size(245, 253)
        Controls.Add(okayButton)
        Controls.Add(monthPicker)
        Controls.Add(selectMonthLabelPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "MonthForm"
        Text = "MonthForm"
        selectMonthLabelPanel.ResumeLayout(False)
        selectMonthLabelPanel.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents okayButton As Button
    Friend WithEvents monthPicker As DateTimePicker
    Friend WithEvents selectMonthLabel As Label
    Friend WithEvents selectMonthLabelPanel As Panel
End Class
