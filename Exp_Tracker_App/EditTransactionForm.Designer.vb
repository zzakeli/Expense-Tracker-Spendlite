<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditTransactionForm
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
        editTransactionLabel = New Label()
        typeLabel = New Label()
        categoryBox = New ComboBox()
        amountBox = New TextBox()
        datePicker = New DateTimePicker()
        saveButton = New Button()
        cancelButton = New Button()
        amountBoxPanel = New Panel()
        editTransactionLabelPanel = New Panel()
        amountBoxPanel.SuspendLayout()
        editTransactionLabelPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' editTransactionLabel
        ' 
        editTransactionLabel.AutoSize = True
        editTransactionLabel.Font = New Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        editTransactionLabel.Location = New Point(12, 8)
        editTransactionLabel.Name = "editTransactionLabel"
        editTransactionLabel.Size = New Size(209, 37)
        editTransactionLabel.TabIndex = 1
        editTransactionLabel.Text = "Edit Transaction"
        ' 
        ' typeLabel
        ' 
        typeLabel.AutoSize = True
        typeLabel.BackColor = SystemColors.Window
        typeLabel.FlatStyle = FlatStyle.Flat
        typeLabel.Font = New Font("Roboto Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        typeLabel.Location = New Point(60, 98)
        typeLabel.Name = "typeLabel"
        typeLabel.Padding = New Padding(10, 5, 10, 5)
        typeLabel.Size = New Size(100, 38)
        typeLabel.TabIndex = 2
        typeLabel.Text = "Income"
        typeLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' categoryBox
        ' 
        categoryBox.DropDownStyle = ComboBoxStyle.DropDownList
        categoryBox.FlatStyle = FlatStyle.Flat
        categoryBox.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        categoryBox.FormattingEnabled = True
        categoryBox.Location = New Point(76, 196)
        categoryBox.Name = "categoryBox"
        categoryBox.Size = New Size(204, 32)
        categoryBox.TabIndex = 3
        ' 
        ' amountBox
        ' 
        amountBox.BorderStyle = BorderStyle.None
        amountBox.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        amountBox.Location = New Point(12, 8)
        amountBox.Name = "amountBox"
        amountBox.PlaceholderText = "Amount"
        amountBox.Size = New Size(180, 25)
        amountBox.TabIndex = 4
        ' 
        ' datePicker
        ' 
        datePicker.CustomFormat = "yyyy-MM-dd"
        datePicker.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        datePicker.Format = DateTimePickerFormat.Custom
        datePicker.Location = New Point(76, 240)
        datePicker.Name = "datePicker"
        datePicker.Size = New Size(204, 32)
        datePicker.TabIndex = 5
        ' 
        ' saveButton
        ' 
        saveButton.BackColor = SystemColors.Window
        saveButton.FlatAppearance.BorderColor = SystemColors.Window
        saveButton.FlatAppearance.BorderSize = 0
        saveButton.FlatStyle = FlatStyle.Flat
        saveButton.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        saveButton.Location = New Point(52, 299)
        saveButton.Name = "saveButton"
        saveButton.Size = New Size(121, 39)
        saveButton.TabIndex = 6
        saveButton.Text = "Save"
        saveButton.UseVisualStyleBackColor = False
        ' 
        ' cancelButton
        ' 
        cancelButton.BackColor = SystemColors.Window
        cancelButton.FlatAppearance.BorderColor = SystemColors.Window
        cancelButton.FlatAppearance.BorderSize = 0
        cancelButton.FlatStyle = FlatStyle.Flat
        cancelButton.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cancelButton.Location = New Point(183, 299)
        cancelButton.Name = "cancelButton"
        cancelButton.Size = New Size(121, 39)
        cancelButton.TabIndex = 7
        cancelButton.Text = "Cancel"
        cancelButton.UseVisualStyleBackColor = False
        ' 
        ' amountBoxPanel
        ' 
        amountBoxPanel.BackColor = SystemColors.Window
        amountBoxPanel.Controls.Add(amountBox)
        amountBoxPanel.Location = New Point(76, 144)
        amountBoxPanel.Name = "amountBoxPanel"
        amountBoxPanel.Size = New Size(204, 41)
        amountBoxPanel.TabIndex = 8
        ' 
        ' editTransactionLabelPanel
        ' 
        editTransactionLabelPanel.BackColor = SystemColors.Window
        editTransactionLabelPanel.Controls.Add(editTransactionLabel)
        editTransactionLabelPanel.Location = New Point(60, 26)
        editTransactionLabelPanel.Name = "editTransactionLabelPanel"
        editTransactionLabelPanel.Size = New Size(233, 52)
        editTransactionLabelPanel.TabIndex = 9
        ' 
        ' EditTransactionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(98), CByte(129), CByte(181))
        ClientSize = New Size(359, 363)
        Controls.Add(editTransactionLabelPanel)
        Controls.Add(typeLabel)
        Controls.Add(cancelButton)
        Controls.Add(saveButton)
        Controls.Add(datePicker)
        Controls.Add(categoryBox)
        Controls.Add(amountBoxPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "EditTransactionForm"
        Text = "EditTransactionForm"
        amountBoxPanel.ResumeLayout(False)
        amountBoxPanel.PerformLayout()
        editTransactionLabelPanel.ResumeLayout(False)
        editTransactionLabelPanel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents editTransactionLabel As Label
    Friend WithEvents typeLabel As Label
    Friend WithEvents categoryBox As ComboBox
    Friend WithEvents amountBox As TextBox
    Friend WithEvents datePicker As DateTimePicker
    Friend WithEvents saveButton As Button
    Friend WithEvents cancelButton As Button
    Friend WithEvents amountBoxPanel As Panel
    Friend WithEvents editTransactionLabelPanel As Panel
End Class
