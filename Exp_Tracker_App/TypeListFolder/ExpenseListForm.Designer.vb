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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        closeButton = New Button()
        expenseDataView = New DataGridView()
        expenseListLabel = New Label()
        searchBox = New TextBox()
        expenseDataViewPanel = New Panel()
        searchBoxPanel = New Panel()
        expenseListLabelPanel = New Panel()
        CType(expenseDataView, ComponentModel.ISupportInitialize).BeginInit()
        expenseDataViewPanel.SuspendLayout()
        searchBoxPanel.SuspendLayout()
        expenseListLabelPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' closeButton
        ' 
        closeButton.BackColor = SystemColors.Window
        closeButton.FlatAppearance.BorderColor = SystemColors.Window
        closeButton.FlatAppearance.BorderSize = 0
        closeButton.FlatStyle = FlatStyle.Flat
        closeButton.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        closeButton.Location = New Point(612, 372)
        closeButton.Name = "closeButton"
        closeButton.Size = New Size(144, 44)
        closeButton.TabIndex = 7
        closeButton.Text = "Close"
        closeButton.UseVisualStyleBackColor = False
        ' 
        ' expenseDataView
        ' 
        expenseDataView.AllowUserToAddRows = False
        expenseDataView.AllowUserToDeleteRows = False
        expenseDataView.AllowUserToResizeColumns = False
        expenseDataView.AllowUserToResizeRows = False
        expenseDataView.BackgroundColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        expenseDataView.BorderStyle = BorderStyle.None
        expenseDataView.CellBorderStyle = DataGridViewCellBorderStyle.None
        expenseDataView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.DarkRed
        DataGridViewCellStyle1.Font = New Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.Padding = New Padding(10)
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        expenseDataView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        expenseDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.Firebrick
        DataGridViewCellStyle2.Font = New Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.IndianRed
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        expenseDataView.DefaultCellStyle = DataGridViewCellStyle2
        expenseDataView.EditMode = DataGridViewEditMode.EditProgrammatically
        expenseDataView.EnableHeadersVisualStyles = False
        expenseDataView.Location = New Point(0, 0)
        expenseDataView.MultiSelect = False
        expenseDataView.Name = "expenseDataView"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        expenseDataView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        expenseDataView.RowHeadersVisible = False
        expenseDataView.RowHeadersWidth = 51
        expenseDataView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        expenseDataView.RowsDefaultCellStyle = DataGridViewCellStyle4
        expenseDataView.ScrollBars = ScrollBars.None
        expenseDataView.Size = New Size(717, 260)
        expenseDataView.TabIndex = 6
        ' 
        ' expenseListLabel
        ' 
        expenseListLabel.AutoSize = True
        expenseListLabel.Font = New Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        expenseListLabel.Location = New Point(20, 10)
        expenseListLabel.Name = "expenseListLabel"
        expenseListLabel.Size = New Size(192, 37)
        expenseListLabel.TabIndex = 5
        expenseListLabel.Text = "EXPENSE LIST"
        ' 
        ' searchBox
        ' 
        searchBox.BorderStyle = BorderStyle.None
        searchBox.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchBox.Location = New Point(12, 10)
        searchBox.Name = "searchBox"
        searchBox.PlaceholderText = "Search category"
        searchBox.Size = New Size(295, 25)
        searchBox.TabIndex = 4
        ' 
        ' expenseDataViewPanel
        ' 
        expenseDataViewPanel.Controls.Add(expenseDataView)
        expenseDataViewPanel.Location = New Point(39, 105)
        expenseDataViewPanel.Name = "expenseDataViewPanel"
        expenseDataViewPanel.Size = New Size(717, 260)
        expenseDataViewPanel.TabIndex = 8
        ' 
        ' searchBoxPanel
        ' 
        searchBoxPanel.BackColor = SystemColors.Window
        searchBoxPanel.Controls.Add(searchBox)
        searchBoxPanel.Location = New Point(42, 48)
        searchBoxPanel.Name = "searchBoxPanel"
        searchBoxPanel.Size = New Size(317, 45)
        searchBoxPanel.TabIndex = 9
        ' 
        ' expenseListLabelPanel
        ' 
        expenseListLabelPanel.BackColor = SystemColors.Window
        expenseListLabelPanel.Controls.Add(expenseListLabel)
        expenseListLabelPanel.Location = New Point(526, 40)
        expenseListLabelPanel.Name = "expenseListLabelPanel"
        expenseListLabelPanel.Size = New Size(233, 57)
        expenseListLabelPanel.TabIndex = 10
        ' 
        ' ExpenseListForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(141), CByte(188), CByte(199))
        ClientSize = New Size(800, 450)
        Controls.Add(expenseListLabelPanel)
        Controls.Add(closeButton)
        Controls.Add(expenseDataViewPanel)
        Controls.Add(searchBoxPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "ExpenseListForm"
        Text = "ExpenseListForm"
        CType(expenseDataView, ComponentModel.ISupportInitialize).EndInit()
        expenseDataViewPanel.ResumeLayout(False)
        searchBoxPanel.ResumeLayout(False)
        searchBoxPanel.PerformLayout()
        expenseListLabelPanel.ResumeLayout(False)
        expenseListLabelPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents closeButton As Button
    Friend WithEvents expenseDataView As DataGridView
    Friend WithEvents expenseListLabel As Label
    Friend WithEvents searchBox As TextBox
    Friend WithEvents expenseDataViewPanel As Panel
    Friend WithEvents searchBoxPanel As Panel
    Friend WithEvents expenseListLabelPanel As Panel
End Class
