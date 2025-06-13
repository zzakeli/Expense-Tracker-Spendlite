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
        CType(savingsDataView, ComponentModel.ISupportInitialize).BeginInit()
        savingsDataViewPanel.SuspendLayout()
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
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New Padding(10)
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        savingsDataView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        savingsDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
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
        savingsListLabel.Location = New Point(663, 37)
        savingsListLabel.Name = "savingsListLabel"
        savingsListLabel.Size = New Size(99, 20)
        savingsListLabel.TabIndex = 5
        savingsListLabel.Text = "SAVINGS LIST"
        ' 
        ' searchBox
        ' 
        searchBox.Location = New Point(42, 34)
        searchBox.Name = "searchBox"
        searchBox.PlaceholderText = "Search"
        searchBox.Size = New Size(295, 27)
        searchBox.TabIndex = 4
        ' 
        ' savingsDataViewPanel
        ' 
        savingsDataViewPanel.Controls.Add(savingsDataView)
        savingsDataViewPanel.Location = New Point(42, 92)
        savingsDataViewPanel.Name = "savingsDataViewPanel"
        savingsDataViewPanel.Size = New Size(717, 260)
        savingsDataViewPanel.TabIndex = 8
        ' 
        ' SavingsListForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(closeButton)
        Controls.Add(savingsListLabel)
        Controls.Add(searchBox)
        Controls.Add(savingsDataViewPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "SavingsListForm"
        Text = "SavingsListForm"
        CType(savingsDataView, ComponentModel.ISupportInitialize).EndInit()
        savingsDataViewPanel.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents closeButton As Button
    Friend WithEvents savingsDataView As DataGridView
    Friend WithEvents savingsListLabel As Label
    Friend WithEvents searchBox As TextBox
    Friend WithEvents savingsDataViewPanel As Panel
End Class
