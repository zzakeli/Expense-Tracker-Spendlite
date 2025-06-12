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
        closeButton = New Button()
        savingsDataView = New DataGridView()
        savingsListLabel = New Label()
        searchBox = New TextBox()
        CType(savingsDataView, ComponentModel.ISupportInitialize).BeginInit()
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
        savingsDataView.ColumnHeadersHeight = 29
        savingsDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        savingsDataView.EditMode = DataGridViewEditMode.EditProgrammatically
        savingsDataView.Location = New Point(42, 92)
        savingsDataView.MultiSelect = False
        savingsDataView.Name = "savingsDataView"
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
        ' SavingsListForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(closeButton)
        Controls.Add(savingsDataView)
        Controls.Add(savingsListLabel)
        Controls.Add(searchBox)
        FormBorderStyle = FormBorderStyle.None
        Name = "SavingsListForm"
        Text = "SavingsListForm"
        CType(savingsDataView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents closeButton As Button
    Friend WithEvents savingsDataView As DataGridView
    Friend WithEvents savingsListLabel As Label
    Friend WithEvents searchBox As TextBox
End Class
