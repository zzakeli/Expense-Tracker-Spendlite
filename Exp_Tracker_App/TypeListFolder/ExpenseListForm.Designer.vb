<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExpenseListForm
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
        closeButton = New Button()
        expenseDataView = New DataGridView()
        expenseListLabel = New Label()
        searchBox = New TextBox()
        CType(expenseDataView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' closeButton
        ' 
        closeButton.Location = New Point(646, 379)
        closeButton.Name = "closeButton"
        closeButton.Size = New Size(113, 37)
        closeButton.TabIndex = 7
        closeButton.Text = "Close"
        closeButton.UseVisualStyleBackColor = True
        ' 
        ' expenseDataView
        ' 
        expenseDataView.AllowUserToAddRows = False
        expenseDataView.AllowUserToDeleteRows = False
        expenseDataView.AllowUserToResizeColumns = False
        expenseDataView.AllowUserToResizeRows = False
        expenseDataView.BackgroundColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        expenseDataView.ColumnHeadersHeight = 29
        expenseDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        expenseDataView.EditMode = DataGridViewEditMode.EditProgrammatically
        expenseDataView.Location = New Point(42, 92)
        expenseDataView.MultiSelect = False
        expenseDataView.Name = "expenseDataView"
        expenseDataView.RowHeadersVisible = False
        expenseDataView.RowHeadersWidth = 51
        expenseDataView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        expenseDataView.ScrollBars = ScrollBars.None
        expenseDataView.Size = New Size(717, 260)
        expenseDataView.TabIndex = 6
        ' 
        ' expenseListLabel
        ' 
        expenseListLabel.AutoSize = True
        expenseListLabel.Location = New Point(663, 37)
        expenseListLabel.Name = "expenseListLabel"
        expenseListLabel.Size = New Size(100, 20)
        expenseListLabel.TabIndex = 5
        expenseListLabel.Text = "EXPENSE LIST"
        ' 
        ' searchBox
        ' 
        searchBox.Location = New Point(42, 34)
        searchBox.Name = "searchBox"
        searchBox.PlaceholderText = "Search category"
        searchBox.Size = New Size(295, 27)
        searchBox.TabIndex = 4
        ' 
        ' ExpenseListForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(closeButton)
        Controls.Add(expenseDataView)
        Controls.Add(expenseListLabel)
        Controls.Add(searchBox)
        FormBorderStyle = FormBorderStyle.None
        Name = "ExpenseListForm"
        Text = "ExpenseListForm"
        CType(expenseDataView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents closeButton As Button
    Friend WithEvents expenseDataView As DataGridView
    Friend WithEvents expenseListLabel As Label
    Friend WithEvents searchBox As TextBox
End Class
