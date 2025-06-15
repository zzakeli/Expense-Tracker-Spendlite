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
        amountBoxPanel = New Panel()
        addTransactionLabelPanel = New Panel()
        addTransactionLabelPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' addTrasactionLabel
        ' 
        addTrasactionLabel.AutoSize = True
        addTrasactionLabel.Font = New Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        addTrasactionLabel.Location = New Point(9, 10)
        addTrasactionLabel.Name = "addTrasactionLabel"
        addTrasactionLabel.Size = New Size(253, 37)
        addTrasactionLabel.TabIndex = 0
        addTrasactionLabel.Text = "ADD TRANSACTION"
        ' 
        ' typeComboBox
        ' 
        typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        typeComboBox.FlatStyle = FlatStyle.Flat
        typeComboBox.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        typeComboBox.FormattingEnabled = True
        typeComboBox.Items.AddRange(New Object() {"Income", "Expense", "Savings"})
        typeComboBox.Location = New Point(50, 118)
        typeComboBox.Name = "typeComboBox"
        typeComboBox.Size = New Size(133, 32)
        typeComboBox.TabIndex = 1
        ' 
        ' amountBox
        ' 
        amountBox.BorderStyle = BorderStyle.None
        amountBox.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        amountBox.Location = New Point(78, 180)
        amountBox.Name = "amountBox"
        amountBox.PlaceholderText = "Amount"
        amountBox.Size = New Size(213, 25)
        amountBox.TabIndex = 2
        ' 
        ' categoryComboBox
        ' 
        categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        categoryComboBox.FlatStyle = FlatStyle.Flat
        categoryComboBox.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        categoryComboBox.FormattingEnabled = True
        categoryComboBox.Location = New Point(65, 232)
        categoryComboBox.Name = "categoryComboBox"
        categoryComboBox.Size = New Size(241, 32)
        categoryComboBox.TabIndex = 3
        ' 
        ' datePicker
        ' 
        datePicker.CalendarFont = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        datePicker.CustomFormat = "yyyy-MM-dd"
        datePicker.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        datePicker.Format = DateTimePickerFormat.Custom
        datePicker.Location = New Point(65, 281)
        datePicker.Name = "datePicker"
        datePicker.Size = New Size(241, 32)
        datePicker.TabIndex = 4
        ' 
        ' addButton
        ' 
        addButton.BackColor = SystemColors.Window
        addButton.FlatAppearance.BorderColor = SystemColors.Window
        addButton.FlatAppearance.BorderSize = 0
        addButton.FlatStyle = FlatStyle.Flat
        addButton.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        addButton.Location = New Point(50, 361)
        addButton.Name = "addButton"
        addButton.Size = New Size(121, 39)
        addButton.TabIndex = 5
        addButton.Text = "Add"
        addButton.UseVisualStyleBackColor = False
        ' 
        ' cancelButton
        ' 
        cancelButton.BackColor = SystemColors.Window
        cancelButton.FlatAppearance.BorderColor = SystemColors.Window
        cancelButton.FlatAppearance.BorderSize = 0
        cancelButton.FlatStyle = FlatStyle.Flat
        cancelButton.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cancelButton.Location = New Point(202, 361)
        cancelButton.Name = "cancelButton"
        cancelButton.Size = New Size(121, 39)
        cancelButton.TabIndex = 6
        cancelButton.Text = "Cancel"
        cancelButton.UseVisualStyleBackColor = False
        ' 
        ' amountBoxPanel
        ' 
        amountBoxPanel.BackColor = SystemColors.Window
        amountBoxPanel.Location = New Point(65, 170)
        amountBoxPanel.Name = "amountBoxPanel"
        amountBoxPanel.Size = New Size(241, 44)
        amountBoxPanel.TabIndex = 7
        ' 
        ' addTransactionLabelPanel
        ' 
        addTransactionLabelPanel.BackColor = SystemColors.Window
        addTransactionLabelPanel.Controls.Add(addTrasactionLabel)
        addTransactionLabelPanel.Location = New Point(50, 32)
        addTransactionLabelPanel.Name = "addTransactionLabelPanel"
        addTransactionLabelPanel.Size = New Size(273, 57)
        addTransactionLabelPanel.TabIndex = 8
        ' 
        ' AddTransaction
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(98), CByte(129), CByte(181))
        ClientSize = New Size(374, 441)
        Controls.Add(addTransactionLabelPanel)
        Controls.Add(cancelButton)
        Controls.Add(addButton)
        Controls.Add(datePicker)
        Controls.Add(categoryComboBox)
        Controls.Add(amountBox)
        Controls.Add(typeComboBox)
        Controls.Add(amountBoxPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "AddTransaction"
        Text = "AddTransaction"
        addTransactionLabelPanel.ResumeLayout(False)
        addTransactionLabelPanel.PerformLayout()
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
    Friend WithEvents amountBoxPanel As Panel
    Friend WithEvents addTransactionLabelPanel As Panel
End Class
