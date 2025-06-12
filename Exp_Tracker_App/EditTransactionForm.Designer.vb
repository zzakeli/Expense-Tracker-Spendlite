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
        SuspendLayout()
        ' 
        ' editTransactionLabel
        ' 
        editTransactionLabel.AutoSize = True
        editTransactionLabel.Location = New Point(102, 29)
        editTransactionLabel.Name = "editTransactionLabel"
        editTransactionLabel.Size = New Size(114, 20)
        editTransactionLabel.TabIndex = 1
        editTransactionLabel.Text = "Edit Transaction"
        ' 
        ' typeLabel
        ' 
        typeLabel.AutoSize = True
        typeLabel.Location = New Point(49, 67)
        typeLabel.Name = "typeLabel"
        typeLabel.Size = New Size(0, 20)
        typeLabel.TabIndex = 2
        ' 
        ' categoryBox
        ' 
        categoryBox.DropDownStyle = ComboBoxStyle.DropDownList
        categoryBox.FormattingEnabled = True
        categoryBox.Location = New Point(84, 127)
        categoryBox.Name = "categoryBox"
        categoryBox.Size = New Size(151, 28)
        categoryBox.TabIndex = 3
        ' 
        ' amountBox
        ' 
        amountBox.Location = New Point(84, 94)
        amountBox.Name = "amountBox"
        amountBox.PlaceholderText = "Amount"
        amountBox.Size = New Size(151, 27)
        amountBox.TabIndex = 4
        ' 
        ' datePicker
        ' 
        datePicker.CustomFormat = "yyyy-MM-dd"
        datePicker.Format = DateTimePickerFormat.Custom
        datePicker.Location = New Point(84, 161)
        datePicker.Name = "datePicker"
        datePicker.Size = New Size(151, 27)
        datePicker.TabIndex = 5
        ' 
        ' saveButton
        ' 
        saveButton.Location = New Point(49, 206)
        saveButton.Name = "saveButton"
        saveButton.Size = New Size(94, 29)
        saveButton.TabIndex = 6
        saveButton.Text = "Save"
        saveButton.UseVisualStyleBackColor = True
        ' 
        ' cancelButton
        ' 
        cancelButton.Location = New Point(164, 206)
        cancelButton.Name = "cancelButton"
        cancelButton.Size = New Size(94, 29)
        cancelButton.TabIndex = 7
        cancelButton.Text = "Cancel"
        cancelButton.UseVisualStyleBackColor = True
        ' 
        ' EditTransactionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(326, 268)
        Controls.Add(cancelButton)
        Controls.Add(saveButton)
        Controls.Add(datePicker)
        Controls.Add(amountBox)
        Controls.Add(categoryBox)
        Controls.Add(typeLabel)
        Controls.Add(editTransactionLabel)
        FormBorderStyle = FormBorderStyle.None
        Name = "EditTransactionForm"
        Text = "EditTransactionForm"
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
End Class
