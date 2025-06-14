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
        editTransactionLabel.Font = New Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        editTransactionLabel.Location = New Point(74, 29)
        editTransactionLabel.Name = "editTransactionLabel"
        editTransactionLabel.Size = New Size(209, 37)
        editTransactionLabel.TabIndex = 1
        editTransactionLabel.Text = "Edit Transaction"
        ' 
        ' typeLabel
        ' 
        typeLabel.AutoSize = True
        typeLabel.Font = New Font("Roboto Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        typeLabel.Location = New Point(142, 75)
        typeLabel.Name = "typeLabel"
        typeLabel.Size = New Size(55, 28)
        typeLabel.TabIndex = 2
        typeLabel.Text = "Type"
        ' 
        ' categoryBox
        ' 
        categoryBox.DropDownStyle = ComboBoxStyle.DropDownList
        categoryBox.FlatStyle = FlatStyle.Flat
        categoryBox.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        categoryBox.FormattingEnabled = True
        categoryBox.Location = New Point(87, 158)
        categoryBox.Name = "categoryBox"
        categoryBox.Size = New Size(180, 32)
        categoryBox.TabIndex = 3
        ' 
        ' amountBox
        ' 
        amountBox.BorderStyle = BorderStyle.None
        amountBox.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        amountBox.Location = New Point(87, 120)
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
        datePicker.Location = New Point(87, 202)
        datePicker.Name = "datePicker"
        datePicker.Size = New Size(180, 32)
        datePicker.TabIndex = 5
        ' 
        ' saveButton
        ' 
        saveButton.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        saveButton.Location = New Point(50, 261)
        saveButton.Name = "saveButton"
        saveButton.Size = New Size(121, 39)
        saveButton.TabIndex = 6
        saveButton.Text = "Save"
        saveButton.UseVisualStyleBackColor = True
        ' 
        ' cancelButton
        ' 
        cancelButton.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cancelButton.Location = New Point(181, 261)
        cancelButton.Name = "cancelButton"
        cancelButton.Size = New Size(121, 39)
        cancelButton.TabIndex = 7
        cancelButton.Text = "Cancel"
        cancelButton.UseVisualStyleBackColor = True
        ' 
        ' EditTransactionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(141), CByte(188), CByte(199))
        ClientSize = New Size(359, 363)
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
