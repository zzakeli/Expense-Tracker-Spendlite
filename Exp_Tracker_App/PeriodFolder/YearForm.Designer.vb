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
        okayButton = New Button()
        yearPicker = New DateTimePicker()
        selectYearLabel = New Label()
        selectYearLabelPanel = New Panel()
        selectYearLabelPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' okayButton
        ' 
        okayButton.BackColor = SystemColors.Window
        okayButton.FlatAppearance.BorderColor = SystemColors.Window
        okayButton.FlatAppearance.BorderSize = 0
        okayButton.FlatStyle = FlatStyle.Flat
        okayButton.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        okayButton.Location = New Point(62, 175)
        okayButton.Name = "okayButton"
        okayButton.Size = New Size(117, 39)
        okayButton.TabIndex = 10
        okayButton.Text = "Okay"
        okayButton.UseVisualStyleBackColor = False
        ' 
        ' yearPicker
        ' 
        yearPicker.AllowDrop = True
        yearPicker.CustomFormat = "yyyy"
        yearPicker.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        yearPicker.Format = DateTimePickerFormat.Custom
        yearPicker.Location = New Point(37, 123)
        yearPicker.Name = "yearPicker"
        yearPicker.ShowUpDown = True
        yearPicker.Size = New Size(170, 32)
        yearPicker.TabIndex = 9
        ' 
        ' selectYearLabel
        ' 
        selectYearLabel.AutoSize = True
        selectYearLabel.Font = New Font("Roboto Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        selectYearLabel.Location = New Point(13, 7)
        selectYearLabel.Name = "selectYearLabel"
        selectYearLabel.Size = New Size(135, 28)
        selectYearLabel.TabIndex = 8
        selectYearLabel.Text = "SELECT YEAR"
        ' 
        ' selectYearLabelPanel
        ' 
        selectYearLabelPanel.BackColor = SystemColors.Window
        selectYearLabelPanel.Controls.Add(selectYearLabel)
        selectYearLabelPanel.Location = New Point(40, 34)
        selectYearLabelPanel.Name = "selectYearLabelPanel"
        selectYearLabelPanel.Size = New Size(162, 42)
        selectYearLabelPanel.TabIndex = 11
        ' 
        ' YearForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(98), CByte(129), CByte(181))
        ClientSize = New Size(245, 253)
        Controls.Add(okayButton)
        Controls.Add(yearPicker)
        Controls.Add(selectYearLabelPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "YearForm"
        Text = "YearForm"
        selectYearLabelPanel.ResumeLayout(False)
        selectYearLabelPanel.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents okayButton As Button
    Friend WithEvents yearPicker As DateTimePicker
    Friend WithEvents selectYearLabel As Label
    Friend WithEvents selectYearLabelPanel As Panel
End Class
