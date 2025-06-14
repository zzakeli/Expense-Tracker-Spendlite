<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IncomeListForm
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
        searchBox = New TextBox()
        incomeListLabel = New Label()
        incomeDataView = New DataGridView()
        closeButton = New Button()
        incomeDataViewPanel = New Panel()
        searchBoxPanel = New Panel()
        incomeListLabelPanel = New Panel()
        CType(incomeDataView, ComponentModel.ISupportInitialize).BeginInit()
        incomeDataViewPanel.SuspendLayout()
        searchBoxPanel.SuspendLayout()
        incomeListLabelPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' searchBox
        ' 
        searchBox.BorderStyle = BorderStyle.None
        searchBox.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchBox.Location = New Point(11, 10)
        searchBox.Name = "searchBox"
        searchBox.PlaceholderText = "Search category"
        searchBox.Size = New Size(295, 25)
        searchBox.TabIndex = 0
        ' 
        ' incomeListLabel
        ' 
        incomeListLabel.AutoSize = True
        incomeListLabel.Font = New Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        incomeListLabel.Location = New Point(27, 10)
        incomeListLabel.Name = "incomeListLabel"
        incomeListLabel.Size = New Size(178, 37)
        incomeListLabel.TabIndex = 1
        incomeListLabel.Text = "INCOME LIST"
        ' 
        ' incomeDataView
        ' 
        incomeDataView.AllowUserToAddRows = False
        incomeDataView.AllowUserToDeleteRows = False
        incomeDataView.AllowUserToResizeColumns = False
        incomeDataView.AllowUserToResizeRows = False
        incomeDataView.BackgroundColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        incomeDataView.BorderStyle = BorderStyle.None
        incomeDataView.CellBorderStyle = DataGridViewCellBorderStyle.None
        incomeDataView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.DarkGreen
        DataGridViewCellStyle1.Font = New Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.Padding = New Padding(10)
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        incomeDataView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        incomeDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.Green
        DataGridViewCellStyle2.Font = New Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.ForestGreen
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        incomeDataView.DefaultCellStyle = DataGridViewCellStyle2
        incomeDataView.EditMode = DataGridViewEditMode.EditProgrammatically
        incomeDataView.EnableHeadersVisualStyles = False
        incomeDataView.Location = New Point(0, 0)
        incomeDataView.MultiSelect = False
        incomeDataView.Name = "incomeDataView"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        incomeDataView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        incomeDataView.RowHeadersVisible = False
        incomeDataView.RowHeadersWidth = 51
        incomeDataView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        incomeDataView.RowsDefaultCellStyle = DataGridViewCellStyle4
        incomeDataView.ScrollBars = ScrollBars.None
        incomeDataView.Size = New Size(717, 260)
        incomeDataView.TabIndex = 2
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
        closeButton.TabIndex = 3
        closeButton.Text = "Close"
        closeButton.UseVisualStyleBackColor = False
        ' 
        ' incomeDataViewPanel
        ' 
        incomeDataViewPanel.Controls.Add(incomeDataView)
        incomeDataViewPanel.Location = New Point(39, 105)
        incomeDataViewPanel.Name = "incomeDataViewPanel"
        incomeDataViewPanel.Size = New Size(717, 260)
        incomeDataViewPanel.TabIndex = 4
        ' 
        ' searchBoxPanel
        ' 
        searchBoxPanel.BackColor = SystemColors.Window
        searchBoxPanel.Controls.Add(searchBox)
        searchBoxPanel.Location = New Point(42, 48)
        searchBoxPanel.Name = "searchBoxPanel"
        searchBoxPanel.Size = New Size(317, 45)
        searchBoxPanel.TabIndex = 5
        ' 
        ' incomeListLabelPanel
        ' 
        incomeListLabelPanel.BackColor = SystemColors.Window
        incomeListLabelPanel.Controls.Add(incomeListLabel)
        incomeListLabelPanel.Location = New Point(526, 40)
        incomeListLabelPanel.Name = "incomeListLabelPanel"
        incomeListLabelPanel.Size = New Size(233, 57)
        incomeListLabelPanel.TabIndex = 6
        ' 
        ' IncomeListForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(141), CByte(188), CByte(199))
        ClientSize = New Size(800, 450)
        Controls.Add(incomeListLabelPanel)
        Controls.Add(searchBoxPanel)
        Controls.Add(closeButton)
        Controls.Add(incomeDataViewPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "IncomeListForm"
        Text = "IncomeListForm"
        CType(incomeDataView, ComponentModel.ISupportInitialize).EndInit()
        incomeDataViewPanel.ResumeLayout(False)
        searchBoxPanel.ResumeLayout(False)
        searchBoxPanel.PerformLayout()
        incomeListLabelPanel.ResumeLayout(False)
        incomeListLabelPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents searchBox As TextBox
    Friend WithEvents incomeListLabel As Label
    Friend WithEvents incomeDataView As DataGridView
    Friend WithEvents closeButton As Button
    Friend WithEvents incomeDataViewPanel As Panel
    Friend WithEvents searchBoxPanel As Panel
    Friend WithEvents incomeListLabelPanel As Panel
End Class
