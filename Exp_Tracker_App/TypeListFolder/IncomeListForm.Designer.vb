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
        CType(incomeDataView, ComponentModel.ISupportInitialize).BeginInit()
        incomeDataViewPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' searchBox
        ' 
        searchBox.Location = New Point(39, 39)
        searchBox.Name = "searchBox"
        searchBox.PlaceholderText = "Search category"
        searchBox.Size = New Size(295, 27)
        searchBox.TabIndex = 0
        ' 
        ' incomeListLabel
        ' 
        incomeListLabel.AutoSize = True
        incomeListLabel.Location = New Point(660, 42)
        incomeListLabel.Name = "incomeListLabel"
        incomeListLabel.Size = New Size(96, 20)
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
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New Padding(10)
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        incomeDataView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        incomeDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
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
        closeButton.Location = New Point(643, 384)
        closeButton.Name = "closeButton"
        closeButton.Size = New Size(113, 37)
        closeButton.TabIndex = 3
        closeButton.Text = "Close"
        closeButton.UseVisualStyleBackColor = True
        ' 
        ' incomeDataViewPanel
        ' 
        incomeDataViewPanel.Controls.Add(incomeDataView)
        incomeDataViewPanel.Location = New Point(39, 97)
        incomeDataViewPanel.Name = "incomeDataViewPanel"
        incomeDataViewPanel.Size = New Size(717, 260)
        incomeDataViewPanel.TabIndex = 4
        ' 
        ' IncomeListForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(closeButton)
        Controls.Add(incomeListLabel)
        Controls.Add(searchBox)
        Controls.Add(incomeDataViewPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "IncomeListForm"
        Text = "IncomeListForm"
        CType(incomeDataView, ComponentModel.ISupportInitialize).EndInit()
        incomeDataViewPanel.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents searchBox As TextBox
    Friend WithEvents incomeListLabel As Label
    Friend WithEvents incomeDataView As DataGridView
    Friend WithEvents closeButton As Button
    Friend WithEvents incomeDataViewPanel As Panel
End Class
