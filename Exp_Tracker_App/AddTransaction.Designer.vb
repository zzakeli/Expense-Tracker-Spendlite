<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTransaction
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
        addTrasactionLabel = New Label()
        typeComboBox = New ComboBox()
        amountBox = New TextBox()
        categoryComboBox = New ComboBox()
        datePicker = New DateTimePicker()
        addButton = New Button()
        cancelButton = New Button()
        SuspendLayout()
        ' 
        ' addTrasactionLabel
        ' 
        addTrasactionLabel.AutoSize = True
        addTrasactionLabel.Location = New Point(127, 29)
        addTrasactionLabel.Name = "addTrasactionLabel"
        addTrasactionLabel.Size = New Size(144, 20)
        addTrasactionLabel.TabIndex = 0
        addTrasactionLabel.Text = "ADD TRANSACTION"
        ' 
        ' typeComboBox
        ' 
        typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        typeComboBox.FormattingEnabled = True
        typeComboBox.Items.AddRange(New Object() {"Income", "Expense", "Savings"})
        typeComboBox.Location = New Point(45, 85)
        typeComboBox.Name = "typeComboBox"
        typeComboBox.Size = New Size(133, 28)
        typeComboBox.TabIndex = 1
        ' 
        ' amountBox
        ' 
        amountBox.Location = New Point(85, 144)
        amountBox.Name = "amountBox"
        amountBox.PlaceholderText = "Amount"
        amountBox.Size = New Size(213, 27)
        amountBox.TabIndex = 2
        ' 
        ' categoryComboBox
        ' 
        categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        categoryComboBox.FormattingEnabled = True
        categoryComboBox.Location = New Point(85, 199)
        categoryComboBox.Name = "categoryComboBox"
        categoryComboBox.Size = New Size(213, 28)
        categoryComboBox.TabIndex = 3
        ' 
        ' datePicker
        ' 
        datePicker.CustomFormat = "yyyy-MM-dd"
        datePicker.Format = DateTimePickerFormat.Custom
        datePicker.Location = New Point(85, 263)
        datePicker.Name = "datePicker"
        datePicker.Size = New Size(213, 27)
        datePicker.TabIndex = 4
        ' 
        ' addButton
        ' 
        addButton.Location = New Point(85, 352)
        addButton.Name = "addButton"
        addButton.Size = New Size(94, 29)
        addButton.TabIndex = 5
        addButton.Text = "Add"
        addButton.UseVisualStyleBackColor = True
        ' 
        ' cancelButton
        ' 
        cancelButton.Location = New Point(204, 352)
        cancelButton.Name = "cancelButton"
        cancelButton.Size = New Size(94, 29)
        cancelButton.TabIndex = 6
        cancelButton.Text = "Cancel"
        cancelButton.UseVisualStyleBackColor = True
        ' 
        ' AddTransaction
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        ClientSize = New Size(408, 450)
        Controls.Add(cancelButton)
        Controls.Add(addButton)
        Controls.Add(datePicker)
        Controls.Add(categoryComboBox)
        Controls.Add(amountBox)
        Controls.Add(typeComboBox)
        Controls.Add(addTrasactionLabel)
        FormBorderStyle = FormBorderStyle.None
        Name = "AddTransaction"
        Text = "AddTransaction"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents addTrasactionLabel As Label
    Friend WithEvents typeComboBox As ComboBox
    Friend WithEvents amountBox As TextBox
    Friend WithEvents categoryComboBox As ComboBox
    Friend WithEvents datePicker As DateTimePicker
    Friend WithEvents addButton As Button
    Friend WithEvents cancelButton As Button
End Class
