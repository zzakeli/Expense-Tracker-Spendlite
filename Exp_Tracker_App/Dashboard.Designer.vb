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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        savingsContainer = New Panel()
        savingsValueContainer = New Panel()
        savingsValue = New Label()
        savingsLabel = New Label()
        expenseContainer = New Panel()
        expenseLabel = New Label()
        expenseValueContainer = New Panel()
        expenseValue = New Label()
        incomeContainer = New Panel()
        incomeLabel = New Label()
        incomeValueContainer = New Panel()
        incomeValue = New Label()
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
        savingsContainer.SuspendLayout()
        savingsValueContainer.SuspendLayout()
        expenseContainer.SuspendLayout()
        expenseValueContainer.SuspendLayout()
        incomeContainer.SuspendLayout()
        incomeValueContainer.SuspendLayout()
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
        mainPanel.Font = New Font("Segoe UI", 22F)
        mainPanel.Location = New Point(52, 40)
        mainPanel.Name = "mainPanel"
        mainPanel.Size = New Size(1159, 672)
        mainPanel.TabIndex = 0
        ' 
        ' expenseListContainer
        ' 
        expenseListContainer.BackColor = SystemColors.Control
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
        expenseListData.BackgroundColor = Color.LightCoral
        expenseListData.BorderStyle = BorderStyle.None
        expenseListData.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = Color.Red
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 10F)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        expenseListData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        expenseListData.ColumnHeadersHeight = 29
        expenseListData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        expenseListData.ColumnHeadersVisible = False
        expenseListData.Location = New Point(0, 47)
        expenseListData.MinimumSize = New Size(182, 164)
        expenseListData.MultiSelect = False
        expenseListData.Name = "expenseListData"
        expenseListData.ReadOnly = True
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.Lime
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 22F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        expenseListData.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        expenseListData.RowHeadersVisible = False
        expenseListData.RowHeadersWidth = 164
        expenseListData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = Color.LightCoral
        DataGridViewCellStyle3.Font = New Font("Roboto Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        DataGridViewCellStyle3.SelectionForeColor = Color.Black
        expenseListData.RowsDefaultCellStyle = DataGridViewCellStyle3
        expenseListData.ScrollBars = ScrollBars.None
        expenseListData.SelectionMode = DataGridViewSelectionMode.CellSelect
        expenseListData.Size = New Size(182, 164)
        expenseListData.TabIndex = 2
        ' 
        ' expenseListLabel
        ' 
        expenseListLabel.AutoSize = True
        expenseListLabel.Font = New Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        expenseListLabel.Location = New Point(22, 9)
        expenseListLabel.Name = "expenseListLabel"
        expenseListLabel.Size = New Size(137, 30)
        expenseListLabel.TabIndex = 2
        expenseListLabel.Text = "Expense List"
        ' 
        ' savingsListContainer
        ' 
        savingsListContainer.BackColor = SystemColors.Control
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
        savingsListData.BackgroundColor = Color.Khaki
        savingsListData.BorderStyle = BorderStyle.None
        savingsListData.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = Color.Yellow
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 10F)
        DataGridViewCellStyle4.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        savingsListData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        savingsListData.ColumnHeadersHeight = 29
        savingsListData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        savingsListData.ColumnHeadersVisible = False
        savingsListData.Location = New Point(0, 47)
        savingsListData.MinimumSize = New Size(182, 164)
        savingsListData.MultiSelect = False
        savingsListData.Name = "savingsListData"
        savingsListData.ReadOnly = True
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = Color.Lime
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 22F)
        DataGridViewCellStyle5.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        savingsListData.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        savingsListData.RowHeadersVisible = False
        savingsListData.RowHeadersWidth = 164
        savingsListData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = Color.Khaki
        DataGridViewCellStyle6.Font = New Font("Roboto Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = Color.Black
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DataGridViewCellStyle6.SelectionForeColor = Color.Black
        savingsListData.RowsDefaultCellStyle = DataGridViewCellStyle6
        savingsListData.ScrollBars = ScrollBars.None
        savingsListData.SelectionMode = DataGridViewSelectionMode.CellSelect
        savingsListData.Size = New Size(182, 164)
        savingsListData.TabIndex = 3
        ' 
        ' savingsListLabel
        ' 
        savingsListLabel.AutoSize = True
        savingsListLabel.Font = New Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        savingsListLabel.Location = New Point(25, 9)
        savingsListLabel.Name = "savingsListLabel"
        savingsListLabel.Size = New Size(132, 30)
        savingsListLabel.TabIndex = 3
        savingsListLabel.Text = "Savings List"
        ' 
        ' incomeListContainer
        ' 
        incomeListContainer.BackColor = SystemColors.Control
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
        incomeListLabel.Font = New Font("Roboto Condensed", 15F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        incomeListLabel.Location = New Point(26, 9)
        incomeListLabel.Name = "incomeListLabel"
        incomeListLabel.Size = New Size(129, 30)
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
        incomeListData.BackgroundColor = Color.PaleGreen
        incomeListData.BorderStyle = BorderStyle.None
        incomeListData.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = Color.Lime
        DataGridViewCellStyle7.Font = New Font("Segoe UI", 10F)
        DataGridViewCellStyle7.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        incomeListData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        incomeListData.ColumnHeadersHeight = 29
        incomeListData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        incomeListData.ColumnHeadersVisible = False
        incomeListData.Location = New Point(0, 47)
        incomeListData.MinimumSize = New Size(182, 164)
        incomeListData.MultiSelect = False
        incomeListData.Name = "incomeListData"
        incomeListData.ReadOnly = True
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = Color.Lime
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle8.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        incomeListData.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        incomeListData.RowHeadersVisible = False
        incomeListData.RowHeadersWidth = 164
        incomeListData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = Color.PaleGreen
        DataGridViewCellStyle9.Font = New Font("Roboto Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle9.ForeColor = Color.Black
        DataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        DataGridViewCellStyle9.SelectionForeColor = Color.Black
        incomeListData.RowsDefaultCellStyle = DataGridViewCellStyle9
        incomeListData.ScrollBars = ScrollBars.None
        incomeListData.SelectionMode = DataGridViewSelectionMode.CellSelect
        incomeListData.Size = New Size(182, 164)
        incomeListData.TabIndex = 0
        ' 
        ' typeContainer
        ' 
        typeContainer.BackColor = SystemColors.Control
        typeContainer.Controls.Add(savingsContainer)
        typeContainer.Controls.Add(expenseContainer)
        typeContainer.Controls.Add(incomeContainer)
        typeContainer.Location = New Point(3, 144)
        typeContainer.Name = "typeContainer"
        typeContainer.Size = New Size(574, 300)
        typeContainer.TabIndex = 4
        ' 
        ' savingsContainer
        ' 
        savingsContainer.BackColor = SystemColors.ButtonHighlight
        savingsContainer.Controls.Add(savingsValueContainer)
        savingsContainer.Controls.Add(savingsLabel)
        savingsContainer.Location = New Point(37, 202)
        savingsContainer.Name = "savingsContainer"
        savingsContainer.Size = New Size(495, 68)
        savingsContainer.TabIndex = 8
        ' 
        ' savingsValueContainer
        ' 
        savingsValueContainer.BackColor = Color.Khaki
        savingsValueContainer.Controls.Add(savingsValue)
        savingsValueContainer.Location = New Point(243, 0)
        savingsValueContainer.Name = "savingsValueContainer"
        savingsValueContainer.Size = New Size(252, 68)
        savingsValueContainer.TabIndex = 9
        ' 
        ' savingsValue
        ' 
        savingsValue.AutoSize = True
        savingsValue.Font = New Font("Roboto Condensed", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        savingsValue.Location = New Point(46, 14)
        savingsValue.Name = "savingsValue"
        savingsValue.Size = New Size(156, 41)
        savingsValue.TabIndex = 3
        savingsValue.Text = "P 2000.00"
        ' 
        ' savingsLabel
        ' 
        savingsLabel.AutoSize = True
        savingsLabel.Font = New Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        savingsLabel.Location = New Point(60, 16)
        savingsLabel.Name = "savingsLabel"
        savingsLabel.Size = New Size(127, 37)
        savingsLabel.TabIndex = 2
        savingsLabel.Text = "SAVINGS"
        ' 
        ' expenseContainer
        ' 
        expenseContainer.BackColor = SystemColors.ButtonHighlight
        expenseContainer.Controls.Add(expenseLabel)
        expenseContainer.Controls.Add(expenseValueContainer)
        expenseContainer.Location = New Point(37, 114)
        expenseContainer.Name = "expenseContainer"
        expenseContainer.Size = New Size(495, 68)
        expenseContainer.TabIndex = 6
        ' 
        ' expenseLabel
        ' 
        expenseLabel.AutoSize = True
        expenseLabel.Font = New Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        expenseLabel.Location = New Point(60, 16)
        expenseLabel.Name = "expenseLabel"
        expenseLabel.Size = New Size(131, 37)
        expenseLabel.TabIndex = 2
        expenseLabel.Text = "EXPENSE"
        ' 
        ' expenseValueContainer
        ' 
        expenseValueContainer.BackColor = Color.LightCoral
        expenseValueContainer.Controls.Add(expenseValue)
        expenseValueContainer.Location = New Point(243, 0)
        expenseValueContainer.Name = "expenseValueContainer"
        expenseValueContainer.Size = New Size(252, 68)
        expenseValueContainer.TabIndex = 7
        ' 
        ' expenseValue
        ' 
        expenseValue.AutoSize = True
        expenseValue.Font = New Font("Roboto Condensed", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        expenseValue.Location = New Point(46, 14)
        expenseValue.Name = "expenseValue"
        expenseValue.Size = New Size(156, 41)
        expenseValue.TabIndex = 3
        expenseValue.Text = "P 3000.00"
        ' 
        ' incomeContainer
        ' 
        incomeContainer.BackColor = SystemColors.ButtonHighlight
        incomeContainer.Controls.Add(incomeLabel)
        incomeContainer.Controls.Add(incomeValueContainer)
        incomeContainer.Location = New Point(37, 27)
        incomeContainer.Name = "incomeContainer"
        incomeContainer.Size = New Size(495, 68)
        incomeContainer.TabIndex = 4
        ' 
        ' incomeLabel
        ' 
        incomeLabel.AutoSize = True
        incomeLabel.Font = New Font("Roboto Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        incomeLabel.Location = New Point(60, 16)
        incomeLabel.Name = "incomeLabel"
        incomeLabel.Size = New Size(117, 37)
        incomeLabel.TabIndex = 2
        incomeLabel.Text = "INCOME"
        ' 
        ' incomeValueContainer
        ' 
        incomeValueContainer.BackColor = Color.PaleGreen
        incomeValueContainer.Controls.Add(incomeValue)
        incomeValueContainer.Location = New Point(243, 0)
        incomeValueContainer.Name = "incomeValueContainer"
        incomeValueContainer.Size = New Size(252, 68)
        incomeValueContainer.TabIndex = 5
        ' 
        ' incomeValue
        ' 
        incomeValue.AutoSize = True
        incomeValue.Font = New Font("Roboto Condensed", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        incomeValue.Location = New Point(46, 14)
        incomeValue.Name = "incomeValue"
        incomeValue.Size = New Size(156, 41)
        incomeValue.TabIndex = 3
        incomeValue.Text = "P 7000.00"
        ' 
        ' netBalanceContainer
        ' 
        netBalanceContainer.BackColor = SystemColors.ButtonHighlight
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
        netBalanceLabel.Font = New Font("Roboto Condensed", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        netBalanceLabel.Location = New Point(25, 16)
        netBalanceLabel.Name = "netBalanceLabel"
        netBalanceLabel.Size = New Size(228, 44)
        netBalanceLabel.TabIndex = 1
        netBalanceLabel.Text = "NET BALANCE"
        ' 
        ' netBalanceValueContainer
        ' 
        netBalanceValueContainer.BackColor = Color.LightBlue
        netBalanceValueContainer.Controls.Add(netBalanceValue)
        netBalanceValueContainer.Location = New Point(280, 0)
        netBalanceValueContainer.Name = "netBalanceValueContainer"
        netBalanceValueContainer.Size = New Size(294, 75)
        netBalanceValueContainer.TabIndex = 0
        ' 
        ' netBalanceValue
        ' 
        netBalanceValue.AutoSize = True
        netBalanceValue.Font = New Font("Roboto Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        netBalanceValue.Location = New Point(48, 14)
        netBalanceValue.Name = "netBalanceValue"
        netBalanceValue.Size = New Size(182, 48)
        netBalanceValue.TabIndex = 2
        netBalanceValue.Text = "P 2000.00"
        ' 
        ' chartContainer
        ' 
        chartContainer.BackColor = SystemColors.Control
        chartContainer.Location = New Point(611, 53)
        chartContainer.Name = "chartContainer"
        chartContainer.Size = New Size(545, 616)
        chartContainer.TabIndex = 2
        ' 
        ' periodMenu
        ' 
        periodMenu.AllowDrop = True
        periodMenu.DropDownStyle = ComboBoxStyle.DropDownList
        periodMenu.Font = New Font("Roboto Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        periodMenu.FormattingEnabled = True
        periodMenu.Items.AddRange(New Object() {"Day", "Week", "Month", "Year"})
        periodMenu.Location = New Point(611, 11)
        periodMenu.Name = "periodMenu"
        periodMenu.Size = New Size(151, 36)
        periodMenu.TabIndex = 1
        ' 
        ' transactionButton
        ' 
        transactionButton.Font = New Font("Roboto Condensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        transactionButton.Location = New Point(2, 2)
        transactionButton.Name = "transactionButton"
        transactionButton.Size = New Size(160, 45)
        transactionButton.TabIndex = 0
        transactionButton.Text = "Transactions"
        transactionButton.UseVisualStyleBackColor = True
        ' 
        ' profile
        ' 
        profile.Image = My.Resources.Resources.admin_profile
        profile.Location = New Point(1177, 17)
        profile.Name = "profile"
        profile.Size = New Size(60, 60)
        profile.SizeMode = PictureBoxSizeMode.StretchImage
        profile.TabIndex = 1
        profile.TabStop = False
        ' 
        ' profileTab
        ' 
        profileTab.BackColor = Color.WhiteSmoke
        profileTab.Controls.Add(logoutButton)
        profileTab.Controls.Add(exportButton)
        profileTab.Location = New Point(1064, 46)
        profileTab.Name = "profileTab"
        profileTab.Size = New Size(143, 81)
        profileTab.TabIndex = 2
        profileTab.Visible = False
        ' 
        ' logoutButton
        ' 
        logoutButton.Font = New Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        logoutButton.Location = New Point(7, 41)
        logoutButton.Name = "logoutButton"
        logoutButton.Size = New Size(128, 35)
        logoutButton.TabIndex = 1
        logoutButton.Text = "Logout"
        logoutButton.UseVisualStyleBackColor = True
        ' 
        ' exportButton
        ' 
        exportButton.Font = New Font("Roboto Condensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
        BackColor = Color.FromArgb(CByte(107), CByte(163), CByte(202))
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
        savingsContainer.ResumeLayout(False)
        savingsContainer.PerformLayout()
        savingsValueContainer.ResumeLayout(False)
        savingsValueContainer.PerformLayout()
        expenseContainer.ResumeLayout(False)
        expenseContainer.PerformLayout()
        expenseValueContainer.ResumeLayout(False)
        expenseValueContainer.PerformLayout()
        incomeContainer.ResumeLayout(False)
        incomeContainer.PerformLayout()
        incomeValueContainer.ResumeLayout(False)
        incomeValueContainer.PerformLayout()
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
