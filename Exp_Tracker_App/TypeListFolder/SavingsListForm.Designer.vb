<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SavingsListForm
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
        closeButton = New Button()
        savingsDataView = New DataGridView()
        savingsListLabel = New Label()
        searchBox = New TextBox()
        savingsDataViewPanel = New Panel()
        searchBoxPanel = New Panel()
        savingsListLabelPanel = New Panel()
        CType(savingsDataView, ComponentModel.ISupportInitialize).BeginInit()
        savingsDataViewPanel.SuspendLayout()
        searchBoxPanel.SuspendLayout()
        savingsListLabelPanel.SuspendLayout()
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
        ' savingsDataView
        ' 
        savingsDataView.AllowUserToAddRows = False
        savingsDataView.AllowUserToDeleteRows = False
        savingsDataView.AllowUserToResizeColumns = False
        savingsDataView.AllowUserToResizeRows = False
        savingsDataView.BackgroundColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        savingsDataView.BorderStyle = BorderStyle.None
        savingsDataView.CellBorderStyle = DataGridViewCellBorderStyle.None
        savingsDataView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(140), CByte(136), CByte(45))
        DataGridViewCellStyle1.Font = New Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.Padding = New Padding(10)
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        savingsDataView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        savingsDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(176), CByte(172), CByte(93))
        DataGridViewCellStyle2.Font = New Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(201), CByte(197), CByte(115))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        savingsDataView.DefaultCellStyle = DataGridViewCellStyle2
        savingsDataView.EditMode = DataGridViewEditMode.EditProgrammatically
        savingsDataView.EnableHeadersVisualStyles = False
        savingsDataView.Location = New Point(0, 0)
        savingsDataView.MultiSelect = False
        savingsDataView.Name = "savingsDataView"
        savingsDataView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        savingsDataView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        savingsDataView.RowHeadersVisible = False
        savingsDataView.RowHeadersWidth = 51
        savingsDataView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        savingsDataView.ScrollBars = ScrollBars.None
        savingsDataView.Size = New Size(717, 260)
        savingsDataView.TabIndex = 6
        ' 
        ' savingsListLabel
        ' 
        savingsListLabel.AutoSize = True
        savingsListLabel.Font = New Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        savingsListLabel.Location = New Point(21, 10)
        savingsListLabel.Name = "savingsListLabel"
        savingsListLabel.Size = New Size(188, 37)
        savingsListLabel.TabIndex = 5
        savingsListLabel.Text = "SAVINGS LIST"
        ' 
        ' searchBox
        ' 
        searchBox.BorderStyle = BorderStyle.None
        searchBox.Font = New Font("Roboto Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchBox.Location = New Point(16, 10)
        searchBox.Name = "searchBox"
        searchBox.PlaceholderText = "Search category"
        searchBox.Size = New Size(282, 25)
        searchBox.TabIndex = 4
        ' 
        ' savingsDataViewPanel
        ' 
        savingsDataViewPanel.Controls.Add(savingsDataView)
        savingsDataViewPanel.Location = New Point(39, 105)
        savingsDataViewPanel.Name = "savingsDataViewPanel"
        savingsDataViewPanel.Size = New Size(717, 260)
        savingsDataViewPanel.TabIndex = 8
        ' 
        ' searchBoxPanel
        ' 
        searchBoxPanel.BackColor = SystemColors.Window
        searchBoxPanel.Controls.Add(searchBox)
        searchBoxPanel.Location = New Point(39, 47)
        searchBoxPanel.Name = "searchBoxPanel"
        searchBoxPanel.Size = New Size(317, 45)
        searchBoxPanel.TabIndex = 9
        ' 
        ' savingsListLabelPanel
        ' 
        savingsListLabelPanel.BackColor = SystemColors.Window
        savingsListLabelPanel.Controls.Add(savingsListLabel)
        savingsListLabelPanel.Location = New Point(523, 39)
        savingsListLabelPanel.Name = "savingsListLabelPanel"
        savingsListLabelPanel.Size = New Size(233, 57)
        savingsListLabelPanel.TabIndex = 10
        ' 
        ' SavingsListForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(141), CByte(188), CByte(199))
        ClientSize = New Size(800, 450)
        Controls.Add(savingsListLabelPanel)
        Controls.Add(searchBoxPanel)
        Controls.Add(closeButton)
        Controls.Add(savingsDataViewPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "SavingsListForm"
        Text = "SavingsListForm"
        CType(savingsDataView, ComponentModel.ISupportInitialize).EndInit()
        savingsDataViewPanel.ResumeLayout(False)
        searchBoxPanel.ResumeLayout(False)
        searchBoxPanel.PerformLayout()
        savingsListLabelPanel.ResumeLayout(False)
        savingsListLabelPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents closeButton As Button
    Friend WithEvents savingsDataView As DataGridView
    Friend WithEvents savingsListLabel As Label
    Friend WithEvents searchBox As TextBox
    Friend WithEvents savingsDataViewPanel As Panel
    Friend WithEvents searchBoxPanel As Panel
    Friend WithEvents savingsListLabelPanel As Panel
End Class
