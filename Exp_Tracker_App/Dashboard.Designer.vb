<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As DataGridViewCellStyle = New DataGridViewCellStyle()
        mainPanel = New Panel()
        expenseListContainer = New Panel()
        expenseListData = New DataGridView()
        expenseListLabel = New Label()
        savingsListContainer = New Panel()
        savingsListData = New DataGridView()
        savingsListLabel = New Label()
        incomeListContainer = New Panel()
        incomeListLabel = New Label()
        incomeListData = New DataGridView()
        typeContainer = New Panel()
        savingsValueContainer = New Panel()
        savingsValue = New Label()
        expenseValueContainer = New Panel()
        expenseValue = New Label()
        savingsContainer = New Panel()
        savingsLabel = New Label()
        incomeValueContainer = New Panel()
        incomeValue = New Label()
        expenseContainer = New Panel()
        expenseLabel = New Label()
        incomeContainer = New Panel()
        incomeLabel = New Label()
        netBalanceContainer = New Panel()
        netBalanceLabel = New Label()
        netBalanceValueContainer = New Panel()
        netBalanceValue = New Label()
        chartContainer = New Panel()
        periodMenu = New ComboBox()
        transactionButton = New Button()
        profile = New PictureBox()
        profileTab = New Panel()
        logoutButton = New Button()
        exportButton = New Button()
        mainPanel.SuspendLayout()
        expenseListContainer.SuspendLayout()
        CType(expenseListData, ComponentModel.ISupportInitialize).BeginInit()
        savingsListContainer.SuspendLayout()
        CType(savingsListData, ComponentModel.ISupportInitialize).BeginInit()
        incomeListContainer.SuspendLayout()
        CType(incomeListData, ComponentModel.ISupportInitialize).BeginInit()
        typeContainer.SuspendLayout()
        savingsValueContainer.SuspendLayout()
        expenseValueContainer.SuspendLayout()
        savingsContainer.SuspendLayout()
        incomeValueContainer.SuspendLayout()
        expenseContainer.SuspendLayout()
        incomeContainer.SuspendLayout()
        netBalanceContainer.SuspendLayout()
        netBalanceValueContainer.SuspendLayout()
        CType(profile, ComponentModel.ISupportInitialize).BeginInit()
        profileTab.SuspendLayout()
        SuspendLayout()
        ' 
        ' mainPanel
        ' 
        mainPanel.Controls.Add(expenseListContainer)
        mainPanel.Controls.Add(savingsListContainer)
        mainPanel.Controls.Add(incomeListContainer)
        mainPanel.Controls.Add(typeContainer)
        mainPanel.Controls.Add(netBalanceContainer)
        mainPanel.Controls.Add(chartContainer)
        mainPanel.Controls.Add(periodMenu)
        mainPanel.Controls.Add(transactionButton)
        mainPanel.Font = New Font("Segoe UI", 22.0F)
        mainPanel.Location = New Point(52, 40)
        mainPanel.Name = "mainPanel"
        mainPanel.Size = New Size(1159, 672)
        mainPanel.TabIndex = 0
        ' 
        ' expenseListContainer
        ' 
        expenseListContainer.BackColor = SystemColors.AppWorkspace
        expenseListContainer.Controls.Add(expenseListData)
        expenseListContainer.Controls.Add(expenseListLabel)
        expenseListContainer.Location = New Point(199, 458)
        expenseListContainer.Name = "expenseListContainer"
        expenseListContainer.Size = New Size(182, 211)
        expenseListContainer.TabIndex = 7
        ' 
        ' expenseListData
        ' 
        expenseListData.AllowUserToAddRows = False
        expenseListData.AllowUserToDeleteRows = False
        expenseListData.AllowUserToResizeColumns = False
        expenseListData.AllowUserToResizeRows = False
        expenseListData.BackgroundColor = Color.Red
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = Color.Red
        DataGridViewCellStyle10.Font = New Font("Segoe UI", 10.0F)
        DataGridViewCellStyle10.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        DataGridViewCellStyle10.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle10.WrapMode = DataGridViewTriState.True
        expenseListData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        expenseListData.ColumnHeadersHeight = 29
        expenseListData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        expenseListData.ColumnHeadersVisible = False
        expenseListData.Location = New Point(0, 47)
        expenseListData.MinimumSize = New Size(182, 164)
        expenseListData.MultiSelect = False
        expenseListData.Name = "expenseListData"
        expenseListData.ReadOnly = True
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = Color.Lime
        DataGridViewCellStyle11.Font = New Font("Segoe UI", 22.0F)
        DataGridViewCellStyle11.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        DataGridViewCellStyle11.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle11.WrapMode = DataGridViewTriState.True
        expenseListData.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        expenseListData.RowHeadersVisible = False
        expenseListData.RowHeadersWidth = 164
        expenseListData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = Color.Red
        DataGridViewCellStyle12.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle12.ForeColor = Color.Black
        DataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        DataGridViewCellStyle12.SelectionForeColor = Color.Black
        expenseListData.RowsDefaultCellStyle = DataGridViewCellStyle12
        expenseListData.ScrollBars = ScrollBars.None
        expenseListData.SelectionMode = DataGridViewSelectionMode.CellSelect
        expenseListData.Size = New Size(182, 164)
        expenseListData.TabIndex = 2
        ' 
        ' expenseListLabel
        ' 
        expenseListLabel.AutoSize = True
        expenseListLabel.Font = New Font("Segoe UI", 15.0F)
        expenseListLabel.Location = New Point(16, 6)
        expenseListLabel.Name = "expenseListLabel"
        expenseListLabel.Size = New Size(149, 35)
        expenseListLabel.TabIndex = 2
        expenseListLabel.Text = "Expense List"
        ' 
        ' savingsListContainer
        ' 
        savingsListContainer.BackColor = SystemColors.AppWorkspace
        savingsListContainer.Controls.Add(savingsListData)
        savingsListContainer.Controls.Add(savingsListLabel)
        savingsListContainer.Location = New Point(395, 458)
        savingsListContainer.Name = "savingsListContainer"
        savingsListContainer.Size = New Size(182, 211)
        savingsListContainer.TabIndex = 6
        ' 
        ' savingsListData
        ' 
        savingsListData.AllowUserToAddRows = False
        savingsListData.AllowUserToDeleteRows = False
        savingsListData.AllowUserToResizeColumns = False
        savingsListData.AllowUserToResizeRows = False
        savingsListData.BackgroundColor = Color.Yellow
        DataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = Color.Yellow
        DataGridViewCellStyle13.Font = New Font("Segoe UI", 10.0F)
        DataGridViewCellStyle13.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DataGridViewCellStyle13.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle13.WrapMode = DataGridViewTriState.True
        savingsListData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        savingsListData.ColumnHeadersHeight = 29
        savingsListData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        savingsListData.ColumnHeadersVisible = False
        savingsListData.Location = New Point(0, 47)
        savingsListData.MinimumSize = New Size(182, 164)
        savingsListData.MultiSelect = False
        savingsListData.Name = "savingsListData"
        savingsListData.ReadOnly = True
        DataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = Color.Lime
        DataGridViewCellStyle14.Font = New Font("Segoe UI", 22.0F)
        DataGridViewCellStyle14.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        DataGridViewCellStyle14.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle14.WrapMode = DataGridViewTriState.True
        savingsListData.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        savingsListData.RowHeadersVisible = False
        savingsListData.RowHeadersWidth = 164
        savingsListData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = Color.Yellow
        DataGridViewCellStyle15.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle15.ForeColor = Color.Black
        DataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DataGridViewCellStyle15.SelectionForeColor = Color.Black
        savingsListData.RowsDefaultCellStyle = DataGridViewCellStyle15
        savingsListData.ScrollBars = ScrollBars.None
        savingsListData.SelectionMode = DataGridViewSelectionMode.CellSelect
        savingsListData.Size = New Size(182, 164)
        savingsListData.TabIndex = 3
        ' 
        ' savingsListLabel
        ' 
        savingsListLabel.AutoSize = True
        savingsListLabel.Font = New Font("Segoe UI", 15.0F)
        savingsListLabel.Location = New Point(19, 6)
        savingsListLabel.Name = "savingsListLabel"
        savingsListLabel.Size = New Size(143, 35)
        savingsListLabel.TabIndex = 3
        savingsListLabel.Text = "Savings List"
        ' 
        ' incomeListContainer
        ' 
        incomeListContainer.BackColor = SystemColors.AppWorkspace
        incomeListContainer.Controls.Add(incomeListLabel)
        incomeListContainer.Controls.Add(incomeListData)
        incomeListContainer.Location = New Point(3, 458)
        incomeListContainer.Name = "incomeListContainer"
        incomeListContainer.Size = New Size(182, 211)
        incomeListContainer.TabIndex = 5
        ' 
        ' incomeListLabel
        ' 
        incomeListLabel.AutoSize = True
        incomeListLabel.Font = New Font("Segoe UI", 15.0F)
        incomeListLabel.Location = New Point(19, 6)
        incomeListLabel.Name = "incomeListLabel"
        incomeListLabel.Size = New Size(142, 35)
        incomeListLabel.TabIndex = 1
        incomeListLabel.Text = "Income List"
        incomeListLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' incomeListData
        ' 
        incomeListData.AllowUserToAddRows = False
        incomeListData.AllowUserToDeleteRows = False
        incomeListData.AllowUserToResizeColumns = False
        incomeListData.AllowUserToResizeRows = False
        incomeListData.BackgroundColor = Color.Lime
        DataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.BackColor = Color.Lime
        DataGridViewCellStyle16.Font = New Font("Segoe UI", 10.0F)
        DataGridViewCellStyle16.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle16.SelectionBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        DataGridViewCellStyle16.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle16.WrapMode = DataGridViewTriState.True
        incomeListData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        incomeListData.ColumnHeadersHeight = 29
        incomeListData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        incomeListData.ColumnHeadersVisible = False
        incomeListData.Location = New Point(0, 47)
        incomeListData.MinimumSize = New Size(182, 164)
        incomeListData.MultiSelect = False
        incomeListData.Name = "incomeListData"
        incomeListData.ReadOnly = True
        DataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = Color.Lime
        DataGridViewCellStyle17.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle17.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle17.SelectionBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        DataGridViewCellStyle17.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle17.WrapMode = DataGridViewTriState.True
        incomeListData.RowHeadersDefaultCellStyle = DataGridViewCellStyle17
        incomeListData.RowHeadersVisible = False
        incomeListData.RowHeadersWidth = 164
        incomeListData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.BackColor = Color.Lime
        DataGridViewCellStyle18.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle18.ForeColor = Color.Black
        DataGridViewCellStyle18.SelectionBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        DataGridViewCellStyle18.SelectionForeColor = Color.Black
        incomeListData.RowsDefaultCellStyle = DataGridViewCellStyle18
        incomeListData.ScrollBars = ScrollBars.None
        incomeListData.SelectionMode = DataGridViewSelectionMode.CellSelect
        incomeListData.Size = New Size(182, 164)
        incomeListData.TabIndex = 0
        ' 
        ' typeContainer
        ' 
        typeContainer.BackColor = SystemColors.ControlDarkDark
        typeContainer.Controls.Add(savingsValueContainer)
        typeContainer.Controls.Add(expenseValueContainer)
        typeContainer.Controls.Add(savingsContainer)
        typeContainer.Controls.Add(incomeValueContainer)
        typeContainer.Controls.Add(expenseContainer)
        typeContainer.Controls.Add(incomeContainer)
        typeContainer.Location = New Point(3, 144)
        typeContainer.Name = "typeContainer"
        typeContainer.Size = New Size(574, 300)
        typeContainer.TabIndex = 4
        ' 
        ' savingsValueContainer
        ' 
        savingsValueContainer.BackColor = Color.Yellow
        savingsValueContainer.Controls.Add(savingsValue)
        savingsValueContainer.Location = New Point(280, 202)
        savingsValueContainer.Name = "savingsValueContainer"
        savingsValueContainer.Size = New Size(252, 68)
        savingsValueContainer.TabIndex = 9
        ' 
        ' savingsValue
        ' 
        savingsValue.AutoSize = True
        savingsValue.Font = New Font("Segoe UI", 20.0F)
        savingsValue.Location = New Point(44, 11)
        savingsValue.Name = "savingsValue"
        savingsValue.Size = New Size(163, 46)
        savingsValue.TabIndex = 3
        savingsValue.Text = "P 2000.00"
        ' 
        ' expenseValueContainer
        ' 
        expenseValueContainer.BackColor = Color.Red
        expenseValueContainer.Controls.Add(expenseValue)
        expenseValueContainer.Location = New Point(280, 114)
        expenseValueContainer.Name = "expenseValueContainer"
        expenseValueContainer.Size = New Size(252, 68)
        expenseValueContainer.TabIndex = 7
        ' 
        ' expenseValue
        ' 
        expenseValue.AutoSize = True
        expenseValue.Font = New Font("Segoe UI", 20.0F)
        expenseValue.Location = New Point(44, 11)
        expenseValue.Name = "expenseValue"
        expenseValue.Size = New Size(163, 46)
        expenseValue.TabIndex = 3
        expenseValue.Text = "P 3000.00"
        ' 
        ' savingsContainer
        ' 
        savingsContainer.BackColor = SystemColors.AppWorkspace
        savingsContainer.Controls.Add(savingsLabel)
        savingsContainer.Location = New Point(37, 202)
        savingsContainer.Name = "savingsContainer"
        savingsContainer.Size = New Size(495, 68)
        savingsContainer.TabIndex = 8
        ' 
        ' savingsLabel
        ' 
        savingsLabel.AutoSize = True
        savingsLabel.Font = New Font("Segoe UI", 18.0F)
        savingsLabel.Location = New Point(55, 13)
        savingsLabel.Name = "savingsLabel"
        savingsLabel.Size = New Size(137, 41)
        savingsLabel.TabIndex = 2
        savingsLabel.Text = "SAVINGS"
        ' 
        ' incomeValueContainer
        ' 
        incomeValueContainer.BackColor = Color.Lime
        incomeValueContainer.Controls.Add(incomeValue)
        incomeValueContainer.Location = New Point(280, 27)
        incomeValueContainer.Name = "incomeValueContainer"
        incomeValueContainer.Size = New Size(252, 68)
        incomeValueContainer.TabIndex = 5
        ' 
        ' incomeValue
        ' 
        incomeValue.AutoSize = True
        incomeValue.Font = New Font("Segoe UI", 20.0F)
        incomeValue.Location = New Point(44, 11)
        incomeValue.Name = "incomeValue"
        incomeValue.Size = New Size(163, 46)
        incomeValue.TabIndex = 3
        incomeValue.Text = "P 7000.00"
        ' 
        ' expenseContainer
        ' 
        expenseContainer.BackColor = SystemColors.AppWorkspace
        expenseContainer.Controls.Add(expenseLabel)
        expenseContainer.Location = New Point(37, 114)
        expenseContainer.Name = "expenseContainer"
        expenseContainer.Size = New Size(495, 68)
        expenseContainer.TabIndex = 6
        ' 
        ' expenseLabel
        ' 
        expenseLabel.AutoSize = True
        expenseLabel.Font = New Font("Segoe UI", 18.0F)
        expenseLabel.Location = New Point(55, 13)
        expenseLabel.Name = "expenseLabel"
        expenseLabel.Size = New Size(136, 41)
        expenseLabel.TabIndex = 2
        expenseLabel.Text = "EXPENSE"
        ' 
        ' incomeContainer
        ' 
        incomeContainer.BackColor = SystemColors.AppWorkspace
        incomeContainer.Controls.Add(incomeLabel)
        incomeContainer.Location = New Point(37, 27)
        incomeContainer.Name = "incomeContainer"
        incomeContainer.Size = New Size(495, 68)
        incomeContainer.TabIndex = 4
        ' 
        ' incomeLabel
        ' 
        incomeLabel.AutoSize = True
        incomeLabel.Font = New Font("Segoe UI", 18.0F)
        incomeLabel.Location = New Point(55, 13)
        incomeLabel.Name = "incomeLabel"
        incomeLabel.Size = New Size(131, 41)
        incomeLabel.TabIndex = 2
        incomeLabel.Text = "INCOME"
        ' 
        ' netBalanceContainer
        ' 
        netBalanceContainer.BackColor = SystemColors.AppWorkspace
        netBalanceContainer.Controls.Add(netBalanceLabel)
        netBalanceContainer.Controls.Add(netBalanceValueContainer)
        netBalanceContainer.Location = New Point(3, 53)
        netBalanceContainer.Name = "netBalanceContainer"
        netBalanceContainer.Size = New Size(574, 75)
        netBalanceContainer.TabIndex = 3
        ' 
        ' netBalanceLabel
        ' 
        netBalanceLabel.AutoSize = True
        netBalanceLabel.Font = New Font("Segoe UI", 22.0F)
        netBalanceLabel.Location = New Point(13, 12)
        netBalanceLabel.Name = "netBalanceLabel"
        netBalanceLabel.Size = New Size(255, 50)
        netBalanceLabel.TabIndex = 1
        netBalanceLabel.Text = "NET BALANCE"
        ' 
        ' netBalanceValueContainer
        ' 
        netBalanceValueContainer.BackColor = SystemColors.ActiveCaption
        netBalanceValueContainer.Controls.Add(netBalanceValue)
        netBalanceValueContainer.Location = New Point(280, 0)
        netBalanceValueContainer.Name = "netBalanceValueContainer"
        netBalanceValueContainer.Size = New Size(294, 75)
        netBalanceValueContainer.TabIndex = 0
        ' 
        ' netBalanceValue
        ' 
        netBalanceValue.AutoSize = True
        netBalanceValue.Font = New Font("Segoe UI", 24.0F)
        netBalanceValue.Location = New Point(48, 12)
        netBalanceValue.Name = "netBalanceValue"
        netBalanceValue.Size = New Size(197, 54)
        netBalanceValue.TabIndex = 2
        netBalanceValue.Text = "P 2000.00"
        ' 
        ' chartContainer
        ' 
        chartContainer.BackColor = Color.Transparent
        chartContainer.Location = New Point(611, 53)
        chartContainer.Name = "chartContainer"
        chartContainer.Size = New Size(545, 616)
        chartContainer.TabIndex = 2
        ' 
        ' periodMenu
        ' 
        periodMenu.AllowDrop = True
        periodMenu.DropDownStyle = ComboBoxStyle.DropDownList
        periodMenu.Font = New Font("Segoe UI", 10.0F)
        periodMenu.FormattingEnabled = True
        periodMenu.Items.AddRange(New Object() {"Day", "Week", "Month", "Year"})
        periodMenu.Location = New Point(611, 19)
        periodMenu.Name = "periodMenu"
        periodMenu.Size = New Size(151, 31)
        periodMenu.TabIndex = 1
        ' 
        ' transactionButton
        ' 
        transactionButton.Font = New Font("Segoe UI", 10.0F)
        transactionButton.Location = New Point(2, 2)
        transactionButton.Name = "transactionButton"
        transactionButton.Size = New Size(160, 45)
        transactionButton.TabIndex = 0
        transactionButton.Text = "Transactions"
        transactionButton.UseVisualStyleBackColor = True
        ' 
        ' profile
        ' 
        profile.Image = My.Resources.Resources.profile
        profile.Location = New Point(1151, 12)
        profile.Name = "profile"
        profile.Size = New Size(60, 60)
        profile.SizeMode = PictureBoxSizeMode.StretchImage
        profile.TabIndex = 1
        profile.TabStop = False
        ' 
        ' profileTab
        ' 
        profileTab.Controls.Add(logoutButton)
        profileTab.Controls.Add(exportButton)
        profileTab.Location = New Point(1043, 49)
        profileTab.Name = "profileTab"
        profileTab.Size = New Size(143, 81)
        profileTab.TabIndex = 2
        profileTab.Visible = False
        ' 
        ' logoutButton
        ' 
        logoutButton.Location = New Point(7, 41)
        logoutButton.Name = "logoutButton"
        logoutButton.Size = New Size(128, 35)
        logoutButton.TabIndex = 1
        logoutButton.Text = "Logout"
        logoutButton.UseVisualStyleBackColor = True
        ' 
        ' exportButton
        ' 
        exportButton.Location = New Point(7, 5)
        exportButton.Name = "exportButton"
        exportButton.Size = New Size(128, 35)
        exportButton.TabIndex = 0
        exportButton.Text = "Export"
        exportButton.UseVisualStyleBackColor = True
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1262, 753)
        Controls.Add(profileTab)
        Controls.Add(profile)
        Controls.Add(mainPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        mainPanel.ResumeLayout(False)
        expenseListContainer.ResumeLayout(False)
        expenseListContainer.PerformLayout()
        CType(expenseListData, ComponentModel.ISupportInitialize).EndInit()
        savingsListContainer.ResumeLayout(False)
        savingsListContainer.PerformLayout()
        CType(savingsListData, ComponentModel.ISupportInitialize).EndInit()
        incomeListContainer.ResumeLayout(False)
        incomeListContainer.PerformLayout()
        CType(incomeListData, ComponentModel.ISupportInitialize).EndInit()
        typeContainer.ResumeLayout(False)
        savingsValueContainer.ResumeLayout(False)
        savingsValueContainer.PerformLayout()
        expenseValueContainer.ResumeLayout(False)
        expenseValueContainer.PerformLayout()
        savingsContainer.ResumeLayout(False)
        savingsContainer.PerformLayout()
        incomeValueContainer.ResumeLayout(False)
        incomeValueContainer.PerformLayout()
        expenseContainer.ResumeLayout(False)
        expenseContainer.PerformLayout()
        incomeContainer.ResumeLayout(False)
        incomeContainer.PerformLayout()
        netBalanceContainer.ResumeLayout(False)
        netBalanceContainer.PerformLayout()
        netBalanceValueContainer.ResumeLayout(False)
        netBalanceValueContainer.PerformLayout()
        CType(profile, ComponentModel.ISupportInitialize).EndInit()
        profileTab.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents mainPanel As Panel
    Friend WithEvents transactionButton As Button
    Friend WithEvents periodMenu As ComboBox
    Friend WithEvents chartContainer As Panel
    Friend WithEvents netBalanceContainer As Panel
    Friend WithEvents netBalanceValueContainer As Panel
    Friend WithEvents typeContainer As Panel
    Friend WithEvents netBalanceLabel As Label
    Friend WithEvents netBalanceValue As Label
    Friend WithEvents incomeContainer As Panel
    Friend WithEvents incomeValueContainer As Panel
    Friend WithEvents incomeLabel As Label
    Friend WithEvents incomeValue As Label
    Friend WithEvents savingsValueContainer As Panel
    Friend WithEvents savingsValue As Label
    Friend WithEvents expenseValueContainer As Panel
    Friend WithEvents expenseValue As Label
    Friend WithEvents savingsContainer As Panel
    Friend WithEvents savingsLabel As Label
    Friend WithEvents expenseContainer As Panel
    Friend WithEvents expenseLabel As Label
    Friend WithEvents expenseListContainer As Panel
    Friend WithEvents savingsListContainer As Panel
    Friend WithEvents incomeListContainer As Panel
    Friend WithEvents incomeListData As DataGridView
    Friend WithEvents incomeListLabel As Label
    Friend WithEvents expenseListLabel As Label
    Friend WithEvents savingsListLabel As Label
    Friend WithEvents profile As PictureBox
    Friend WithEvents profileTab As Panel
    Friend WithEvents exportButton As Button
    Friend WithEvents logoutButton As Button
    Friend WithEvents expenseListData As DataGridView
    Friend WithEvents savingsListData As DataGridView
End Class
