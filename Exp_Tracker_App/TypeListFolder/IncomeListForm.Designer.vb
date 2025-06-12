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
        searchBox = New TextBox()
        incomeListLabel = New Label()
        incomeDataView = New DataGridView()
        closeButton = New Button()
        CType(incomeDataView, ComponentModel.ISupportInitialize).BeginInit()
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
        incomeDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        incomeDataView.EditMode = DataGridViewEditMode.EditProgrammatically
        incomeDataView.Location = New Point(39, 97)
        incomeDataView.MultiSelect = False
        incomeDataView.Name = "incomeDataView"
        incomeDataView.RowHeadersVisible = False
        incomeDataView.RowHeadersWidth = 51
        incomeDataView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
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
        ' IncomeListForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(closeButton)
        Controls.Add(incomeDataView)
        Controls.Add(incomeListLabel)
        Controls.Add(searchBox)
        FormBorderStyle = FormBorderStyle.None
        Name = "IncomeListForm"
        Text = "IncomeListForm"
        CType(incomeDataView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents searchBox As TextBox
    Friend WithEvents incomeListLabel As Label
    Friend WithEvents incomeDataView As DataGridView
    Friend WithEvents closeButton As Button
End Class
