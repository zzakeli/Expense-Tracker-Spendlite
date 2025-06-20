﻿Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient
Imports System.IO
Imports OxyPlot
Imports OxyPlot.Series
Imports OxyPlot.WindowsForms

Public Class Dashboard
    Private connector As New DatabaseConnector

    Private userID As Integer
    Private plotView As PlotView
    Private dayForm As New DayForm(Me)
    Private weekForm As New WeekForm(Me)
    Private monthForm As MonthForm
    Private yearForm As New YearForm(Me)
    Private incomeListForm As IncomeListForm
    Private expenseListForm As ExpenseListForm
    Private savingsListForm As SavingsListForm
    Private startingForm As StartingForm
    Private addTransaction As AddTransaction

    Public Sub New(startingForm As StartingForm, plotView As PlotView)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.startingForm = startingForm
        Me.plotView = plotView
    End Sub

    Public Sub setMonthForm(monthForm As MonthForm)
        Me.monthForm = monthForm
        Me.addTransaction = New AddTransaction(Me, dayForm, weekForm, monthForm, yearForm)
        Me.incomeListForm = New IncomeListForm(Me, dayForm, weekForm, monthForm, yearForm)
        Me.expenseListForm = New ExpenseListForm(Me, dayForm, weekForm, monthForm, yearForm)
        Me.savingsListForm = New SavingsListForm(Me, dayForm, weekForm, monthForm, yearForm)
    End Sub

    Public Sub setUserID(userID As Integer)
        Me.userID = userID
    End Sub

    Public Function getUserID()
        Return userID
    End Function


    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        curveCorners()
        RoundPanelCorners(chartContainer, 40)
        RoundPanelCorners(typeContainer, 40)
        RoundPanelCorners(netBalanceContainer, 30)
        RoundPanelCorners(incomeContainer, 25)
        RoundPanelCorners(expenseContainer, 25)
        RoundPanelCorners(savingsContainer, 25)
        RoundPanelCorners(incomeListContainer, 20)
        RoundPanelCorners(expenseListContainer, 20)
        RoundPanelCorners(savingsListContainer, 20)
        RoundPanelCorners(profileTab, 10)
        roundControlCorners(periodMenu, 20)
        roundControlCorners(transactionButton, 20)
        roundControlCorners(exportButton, 20)
        roundControlCorners(logoutButton, 20)
        makeATChild()
        makeDFChild()
        makeWFChild()
        makeMFChild()
        makeYFChild()
        makeELFChild()
        makeILFChild()
        makeSLFChild()
    End Sub

    Public Sub UpdateLabelAlignLeft(lbl As Label, newText As String)
        Dim oldWidth As Integer = lbl.Width
        lbl.Text = newText
        lbl.AutoSize = True
        lbl.Update()
        Dim newWidth As Integer = lbl.Width
        Dim widthChange As Integer = newWidth - oldWidth

        lbl.Left += widthChange
    End Sub

    Private Sub roundControlCorners(ctrl As Control, radius As Integer)
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(ctrl.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(ctrl.Width - radius, ctrl.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, ctrl.Height - radius, radius, radius, 90, 90)
        path.CloseAllFigures()
        ctrl.Region = New Region(path)
    End Sub

    Private Sub curveCorners()
        Dim radius As Integer = 50
        Dim bounds As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim path As New GraphicsPath()

        ' Top-left curve
        path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90)
        ' Top edge
        path.AddLine(bounds.X + radius, bounds.Y, bounds.Right - radius, bounds.Y)
        ' Top-right curve
        path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90)
        ' Right edge
        path.AddLine(bounds.Right, bounds.Y + radius, bounds.Right, bounds.Bottom - radius)
        ' Bottom-right curve
        path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90)
        ' Bottom edge
        path.AddLine(bounds.Right - radius, bounds.Bottom, bounds.X + radius, bounds.Bottom)
        ' Bottom-left curve
        path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90)
        ' Left edge
        path.AddLine(bounds.X, bounds.Bottom - radius, bounds.X, bounds.Y + radius)

        path.CloseFigure()
        Me.Region = New Region(path)
    End Sub

    Public Sub prepareQueryThenRefresh()
        Dim userIncomeQuery As String = ""
        Dim userExpenseQuery As String = ""
        Dim userSavingsQuery As String = ""
        Dim userIncomeListQuery As String = ""
        Dim userExpenseListQuery As String = ""
        Dim userSavingsListQuery As String = ""
        Dim chartQuery As String = ""

        If (periodMenu.SelectedItem = "Day") Then
            Dim day As String = dayForm.dayPicker.Text

            userIncomeQuery = "SELECT SUM(amount) AS total_income FROM income 
                                WHERE user_id = " & userID & " AND category_date = '" & day & "';"

            userExpenseQuery = "SELECT SUM(amount) AS total_expense FROM expense 
                                WHERE user_id = " & userID & " AND category_date = '" & day & "';"

            userSavingsQuery = "SELECT SUM(amount) AS total_savings FROM savings 
                                WHERE user_id = " & userID & " AND category_date = '" & day & "';"

            userIncomeListQuery = "SELECT DISTINCT CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS category_name FROM category 
                                LEFT JOIN income ON category.category_id = income.category_id 
                                WHERE user_id = " & userID & " AND income.category_date = '" & day & "';"

            userExpenseListQuery = "SELECT DISTINCT CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS category_name FROM category 
                                LEFT JOIN expense ON category.category_id = expense.category_id 
                                WHERE user_id = " & userID & " AND expense.category_date = '" & day & "';"

            userSavingsListQuery = "SELECT DISTINCT CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS category_name FROM category 
                                LEFT JOIN savings ON category.category_id = savings.category_id 
                                WHERE user_id = " & userID & " AND savings.category_date = '" & day & "';"

            chartQuery = "SELECT CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS category_name, 
                                SUM(net_balance.amount) AS total_amount, 
                                MAX(net_balance.category_date) AS latest_date 
                                FROM category 
                                RIGHT JOIN (
                                SELECT category_id, amount, category_date FROM income 
                                WHERE user_id = " & userID & " AND category_date = '" & day & "'
                                UNION ALL 
                                SELECT category_id, amount, category_date FROM expense 
                                WHERE user_id = " & userID & " AND category_date = '" & day & "'
                                UNION ALL 
                                SELECT category_id, amount, category_date FROM savings 
                                WHERE user_id = " & userID & " AND category_date = '" & day & "'
                                ) AS net_balance ON category.category_id = net_balance.category_id
                                GROUP BY category.category_name;"

        ElseIf (periodMenu.SelectedItem = "Week") Then
            Dim weekString As String = weekForm.weekComboBox.SelectedItem.ToString()
            Dim currentYear As String = Date.Now.Year.ToString()

            ' Extract the dates using Split
            Dim parts() As String = weekString.Split("-"c)
            Dim startDateString As String = parts(0).Trim() & "/" & currentYear
            Dim endDateString As String = parts(1).Trim() & "/" & currentYear

            ' Convert to actual Date objects
            Dim startDate As Date = Date.ParseExact(startDateString, "MM/dd/yyyy", Nothing)
            Dim endDate As Date = Date.ParseExact(endDateString, "MM/dd/yyyy", Nothing)

            Dim weekStart As String = startDate.ToString("yyyy-MM-dd")
            Dim weekEnd As String = endDate.ToString("yyyy-MM-dd")

            userIncomeQuery = "SELECT SUM(amount) AS total_income FROM income 
                                WHERE user_id = " & userID & " AND 
                                category_date BETWEEN '" & weekStart & "' AND '" & weekEnd & "';"

            userExpenseQuery = "SELECT SUM(amount) AS total_expense FROM expense 
                                WHERE user_id = " & userID & " AND 
                                category_date BETWEEN '" & weekStart & "' AND '" & weekEnd & "';"

            userSavingsQuery = "SELECT SUM(amount) AS total_savings FROM savings 
                                WHERE user_id = " & userID & " AND 
                                category_date BETWEEN '" & weekStart & "' AND '" & weekEnd & "';"

            userIncomeListQuery = "SELECT DISTINCT CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS category_name FROM category 
                                LEFT JOIN income ON category.category_id = income.category_id 
                                WHERE user_id = " & userID & " AND 
                                income.category_date BETWEEN '" & weekStart & "' AND '" & weekEnd & "';"

            userExpenseListQuery = "SELECT DISTINCT CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS category_name FROM category 
                                LEFT JOIN expense ON category.category_id = expense.category_id 
                                WHERE user_id = " & userID & " AND 
                                expense.category_date BETWEEN '" & weekStart & "' AND '" & weekEnd & "';"

            userSavingsListQuery = "SELECT DISTINCT CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS category_name FROM category 
                                LEFT JOIN savings ON category.category_id = savings.category_id 
                                WHERE user_id = " & userID & " AND 
                                savings.category_date BETWEEN '" & weekStart & "' AND '" & weekEnd & "';"

            chartQuery = "SELECT CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS category_name, 
                                SUM(net_balance.amount) AS total_amount, 
                                MAX(net_balance.category_date) AS latest_date 
                                FROM category 
                                RIGHT JOIN (
                                SELECT category_id, amount, category_date FROM income 
                                WHERE user_id = " & userID & " AND category_date BETWEEN '" & weekStart & "' AND '" & weekEnd & "'
                                UNION ALL 
                                SELECT category_id, amount, category_date FROM expense 
                                WHERE user_id = " & userID & " AND category_date BETWEEN '" & weekStart & "' AND '" & weekEnd & "'
                                UNION ALL 
                                SELECT category_id, amount, category_date FROM savings 
                                WHERE user_id = " & userID & " AND category_date BETWEEN '" & weekStart & "' AND '" & weekEnd & "'
                                ) AS net_balance ON category.category_id = net_balance.category_id
                                GROUP BY category.category_name;"

        ElseIf (periodMenu.SelectedItem = "Month") Then
            Dim month As String = monthForm.monthPicker.Value.ToString("MM")
            Dim year As String = monthForm.monthPicker.Value.ToString("yyyy")

            userIncomeQuery = "SELECT SUM(amount) AS total_income FROM income 
                                WHERE user_id = " & userID & " AND 
                                MONTH(category_date) = " & month & " 
                                AND YEAR(category_date) = " & year & ";"

            userExpenseQuery = "SELECT SUM(amount) AS total_expense FROM expense 
                                WHERE user_id = " & userID & " AND 
                                MONTH(category_date) = " & month & " 
                                AND YEAR(category_date) = " & year & ";"

            userSavingsQuery = "SELECT SUM(amount) AS total_savings FROM savings 
                                WHERE user_id = " & userID & " AND 
                                MONTH(category_date) = " & month & " 
                                AND YEAR(category_date) = " & year & ";"

            userIncomeListQuery = "SELECT DISTINCT CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS category_name FROM category 
                                LEFT JOIN income ON category.category_id = income.category_id 
                                WHERE user_id = " & userID & " AND 
                                MONTH(income.category_date) = " & month & " AND 
                                YEAR(income.category_date) = " & year & ";"

            userExpenseListQuery = "SELECT DISTINCT CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS category_name FROM category 
                                LEFT JOIN expense ON category.category_id = expense.category_id 
                                WHERE user_id = " & userID & " AND 
                                MONTH(expense.category_date) = " & month & " AND 
                                YEAR(expense.category_date) = " & year & ";"

            userSavingsListQuery = "SELECT DISTINCT CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS category_name FROM category 
                                LEFT JOIN savings ON category.category_id = savings.category_id 
                                WHERE user_id = " & userID & " AND 
                                MONTH(savings.category_date) = " & month & " AND 
                                YEAR(savings.category_date) = " & year & ";"

            chartQuery = "SELECT CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS category_name, 
                                SUM(net_balance.amount) AS total_amount, 
                                MAX(net_balance.category_date) AS latest_date 
                                FROM category 
                                RIGHT JOIN (
                                SELECT category_id, amount, category_date FROM income 
                                WHERE user_id = " & userID & " AND MONTH(category_date) = " & month & " AND YEAR(category_date) = " & year & "
                                UNION ALL 
                                SELECT category_id, amount, category_date FROM expense 
                                WHERE user_id = " & userID & " AND MONTH(category_date) = " & month & " AND YEAR(category_date) = " & year & "
                                UNION ALL 
                                SELECT category_id, amount, category_date FROM savings 
                                WHERE user_id = " & userID & " AND MONTH(category_date) = " & month & " AND YEAR(category_date) = " & year & "
                                ) AS net_balance ON category.category_id = net_balance.category_id
                                GROUP BY category.category_name;"

        ElseIf (periodMenu.SelectedItem = "Year") Then
            Dim year As String = yearForm.yearPicker.Text

            userIncomeQuery = "SELECT SUM(amount) AS total_income FROM income 
                                WHERE user_id = " & userID & " AND YEAR(category_date) = " & year & ";"

            userExpenseQuery = "SELECT SUM(amount) AS total_expense FROM expense 
                                WHERE user_id = " & userID & " AND YEAR(category_date) = " & year & ";"

            userSavingsQuery = "SELECT SUM(amount) AS total_savings FROM savings 
                                WHERE user_id = " & userID & " AND YEAR(category_date) = " & year & ";"

            userIncomeListQuery = "SELECT DISTINCT CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS category_name FROM category 
                                LEFT JOIN income ON category.category_id = income.category_id 
                                WHERE user_id = " & userID & " AND YEAR(income.category_date) = " & year & ";"

            userExpenseListQuery = "SELECT DISTINCT CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS category_name FROM category 
                                LEFT JOIN expense ON category.category_id = expense.category_id 
                                WHERE user_id = " & userID & " AND YEAR(expense.category_date) = " & year & ";"

            userSavingsListQuery = "SELECT DISTINCT CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS category_name FROM category 
                                LEFT JOIN savings ON category.category_id = savings.category_id 
                                WHERE user_id = " & userID & " AND YEAR(savings.category_date) = " & year & ";"

            chartQuery = "SELECT CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS category_name, 
                                SUM(net_balance.amount) AS total_amount, 
                                MAX(net_balance.category_date) AS latest_date 
                                FROM category 
                                RIGHT JOIN (
                                SELECT category_id, amount, category_date FROM income 
                                WHERE user_id = " & userID & " AND YEAR(category_date) = " & year & "
                                UNION ALL 
                                SELECT category_id, amount, category_date FROM expense 
                                WHERE user_id = " & userID & " AND YEAR(category_date) = " & year & "
                                UNION ALL 
                                SELECT category_id, amount, category_date FROM savings 
                                WHERE user_id = " & userID & " AND YEAR(category_date) = " & year & "
                                ) AS net_balance ON category.category_id = net_balance.category_id
                                GROUP BY category.category_name;"
        End If

        refreshDashboard(userIncomeQuery, userExpenseQuery,
                                   userSavingsQuery, userIncomeListQuery,
                                   userExpenseListQuery, userSavingsListQuery, chartQuery)
    End Sub

    Public Sub refreshDashboard(userIncomeQuery As String, userExpenseQuery As String, userSavingsQuery As String,
                                userIncomeListQuery As String, userExpenseListQuery As String, userSavingsListQuery As String,
                                chartQuery As String)

        Dim userIncome As Integer = loadUserIncome(userIncomeQuery)
        Dim userExpense As Double = loadUserExpense(userExpenseQuery)
        Dim userSavings As Double = loadUserSavings(userSavingsQuery)
        Dim userNetBalance As Double = loadUserNetBalance(userIncome, userExpense, userSavings)

        loadUserIncomeList(userIncomeListQuery)
        loadUserExpenseList(userExpenseListQuery)
        loadUserSavingsList(userSavingsListQuery)

        loadChart(chartQuery)

        setUpUserDashboard(userNetBalance, userIncome, userExpense, userSavings)
    End Sub

    Private Sub setUpUserDashboard(userNetBalance As Double, userIncome As Double, userExpense As Double, userSavings As Double)
        netBalanceValue.Text = "P " & userNetBalance.ToString("F2")
        incomeValue.Text = "P " & userIncome.ToString("F2")
        expenseValue.Text = "P " & userExpense.ToString("F2")
        savingsValue.Text = "P " & userSavings.ToString("F2")

        CenterLabelInPanel(netBalanceValue, netBalanceValueContainer)
        CenterLabelInPanel(incomeValue, incomeValueContainer)
        CenterLabelInPanel(expenseValue, expenseValueContainer)
        CenterLabelInPanel(savingsValue, savingsValueContainer)
    End Sub

    Private Sub CenterLabelInPanel(lbl As Label, pnl As Panel)
        lbl.Location = New Point(
        (pnl.Width - lbl.Width) \ 2,
        (pnl.Height - lbl.Height) \ 2
    )
    End Sub

    Private Sub loadChart(chartQuery As String)
        ' Create PlotView and add it to chartContainer
        plotView = New PlotView()

        ' Make plot fill the panel
        plotView.Dock = DockStyle.Fill
        chartContainer.Controls.Clear()
        chartContainer.Controls.Add(plotView)

        ' Create a PlotModel
        Dim plotModel As New PlotModel With {
            .Title = "Financial Breakdown",
            .TitleFont = "Roboto Condensed",
            .TitleFontSize = 26,
            .TitleColor = OxyColors.SteelBlue
        }

        ' Create PieSeries and add slices
        Dim pieSeries As New PieSeries() With {
            .Diameter = 0.88,
            .StrokeThickness = 2.5,
            .Stroke = OxyColors.White,
            .InsideLabelPosition = 0.8,
            .AngleSpan = 360,
            .StartAngle = 0,
            .OutsideLabelFormat = Nothing,
            .InsideLabelFormat = "{1}\n{2:0.#}%".Replace("\n", Environment.NewLine),
            .FontSize = 10,
            .Font = "Roboto Condensed"
        }

        Try
            Dim monthNow As String = Date.Now.Month.ToString()
            Dim yearNow As String = Date.Now.Year.ToString()
            connector.connect.Open()
            connector.query = chartQuery
            'connector.query = "SELECT category.category_name, 
            '                    SUM(net_balance.amount) AS total_amount, 
            '                    MAX(net_balance.category_date) AS latest_date 
            '                    FROM category 
            '                    RIGHT JOIN (
            '                    SELECT category_id, amount, category_date FROM income 
            '                    WHERE user_id = " & userID & " AND MONTH(category_date) = " & monthNow & " AND YEAR(category_date) = " & yearNow & "
            '                    UNION ALL 
            '                    SELECT category_id, amount, category_date FROM expense 
            '                    WHERE user_id = " & userID & " AND MONTH(category_date) = " & monthNow & " AND YEAR(category_date) = " & yearNow & "
            '                    UNION ALL 
            '                    SELECT category_id, amount, category_date FROM savings 
            '                    WHERE user_id = " & userID & " AND MONTH(category_date) = " & monthNow & " AND YEAR(category_date) = " & yearNow & "
            '                    ) AS net_balance ON category.category_id = net_balance.category_id
            '                    GROUP BY category.category_name;"

            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader

            Dim incomeCategory() = {"Salary", "Allowance", "Business income", "Investment income", "Other income"}
            Dim expenseCategory() = {"Rent", "Utilities", "Groceries", "Transportation", "Education", "Health", "Dining out", "Pet", "Shopping"}
            Dim savingsCategory() = {"Emergency fund", "Retirement savings", "Travel savings", "Education savings", "Other savings"}
            While connector.reader.Read
                Dim category As String = connector.reader("category_name").ToString()
                Dim amount As Double = Double.Parse(connector.reader("total_amount").ToString())
                'Dim categoryDate As DateTime = DateTime.Parse(connector.reader("category_date").ToString())

                If (incomeCategory.Contains(category)) Then
                    pieSeries.Slices.Add(New PieSlice(category, amount) With {.Fill = OxyColors.LightGreen})
                ElseIf (expenseCategory.Contains(category)) Then
                    pieSeries.Slices.Add(New PieSlice(category, amount) With {.Fill = OxyColors.Pink})
                ElseIf (savingsCategory.Contains(category)) Then
                    pieSeries.Slices.Add(New PieSlice(category, amount) With {.Fill = OxyColors.LightYellow})
                End If
            End While

            If pieSeries.Slices.Count = 0 Then
                pieSeries.Slices.Add(New PieSlice("No Data", 1) With {
                                     .Fill = OxyColor.FromAColor(50, OxyColors.Gray),
                                     .IsExploded = False
                })
            End If


            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Error in database from getting income chart.")
        End Try

        ' Add the PieSeries to PlotModel
        plotModel.Series.Add(pieSeries)

        ' Assign PlotModel to PlotView
        plotView.Model = plotModel
    End Sub

    Private Sub loadUserSavingsList(userSavingsListQuery As String)
        Try
            Dim monthNow As String = Date.Now.Month.ToString()
            Dim yearNow As String = Date.Now.Year.ToString()
            Dim dataTable As New DataTable
            connector.connect.Open()
            connector.query = userSavingsListQuery
            'connector.query = "SELECT DISTINCT category.category_name FROM category 
            '                    LEFT JOIN savings ON category.category_id = savings.category_id 
            '                    WHERE user_id = " & userID & " AND 
            '                    MONTH(savings.category_date) = " & monthNow & " AND 
            '                    YEAR(savings.category_date) = " & yearNow & ";"

            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(dataTable)
            savingsListData.DataSource = dataTable
            connector.command.ExecuteNonQuery()

            savingsListData.Columns(0).Width = savingsListData.ClientSize.Width
            savingsListData.RowTemplate.Height = 50

            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Error in database from refreshing user savings list.")
        End Try
    End Sub

    Private Sub loadUserExpenseList(userExpenseListQuery As String)
        Try
            Dim monthNow As String = Date.Now.Month.ToString()
            Dim yearNow As String = Date.Now.Year.ToString()
            Dim dataTable As New DataTable
            connector.connect.Open()
            connector.query = userExpenseListQuery
            'connector.query = "SELECT DISTINCT category.category_name FROM category 
            '                    LEFT JOIN expense ON category.category_id = expense.category_id 
            '                    WHERE user_id = " & userID & " AND 
            '                    MONTH(expense.category_date) = " & monthNow & " AND 
            '                    YEAR(expense.category_date) = " & yearNow & ";"

            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(dataTable)
            expenseListData.DataSource = dataTable
            connector.command.ExecuteNonQuery()

            expenseListData.Columns(0).Width = expenseListData.ClientSize.Width
            expenseListData.RowTemplate.Height = 50

            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Error in database from refreshing user expense list.")
        End Try
    End Sub

    Private Sub loadUserIncomeList(userIncomeListQuery As String)
        Try
            Dim monthNow As String = Date.Now.Month.ToString()
            Dim yearNow As String = Date.Now.Year.ToString()
            Dim dataTable As New DataTable
            connector.connect.Open()
            connector.query = userIncomeListQuery
            'connector.query = "SELECT DISTINCT category.category_name FROM category 
            '                    LEFT JOIN income ON category.category_id = income.category_id 
            '                    WHERE user_id = " & userID & " AND 
            '                    MONTH(income.category_date) = " & monthNow & " AND 
            '                    YEAR(income.category_date) = " & yearNow & ";"

            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(dataTable)
            incomeListData.DataSource = dataTable
            connector.command.ExecuteNonQuery()

            incomeListData.Columns(0).Width = incomeListData.ClientSize.Width
            incomeListData.RowTemplate.Height = 50

            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Error in database from refreshing user income list.")
        End Try
    End Sub

    Private Function loadUserNetBalance(userIncome As Double, userExpense As Double, userSavings As Double) As Double
        Return userIncome - userExpense - userSavings
    End Function

    Private Function loadUserSavings(userSavingsQuery As String)
        Try
            Dim savings As Double = 0
            Dim monthNow As String = Date.Now.Month.ToString()
            Dim yearNow As String = Date.Now.Year.ToString()
            connector.connect.Open()
            connector.query = userSavingsQuery
            'connector.query = "SELECT SUM(amount) AS total_savings FROM savings 
            '                    WHERE user_id = " & userID & " AND 
            '                    MONTH(category_date) = " & monthNow & " 
            '                    AND YEAR(category_date) = " & yearNow & ";"

            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader

            While connector.reader.Read
                If (String.IsNullOrEmpty(connector.reader("total_savings").ToString())) Then
                    savings = 0
                Else
                    savings = Double.Parse(connector.reader("total_savings").ToString())
                End If
            End While

            connector.connect.Close()

            Return savings
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Error in database from refreshing user savings.")
        End Try

        ' Return 0 if there is an error
        Return 0
    End Function

    Private Function loadUserExpense(userExpenseQuery As String)
        Try
            Dim expense As Double = 0
            Dim monthNow As String = Date.Now.Month.ToString()
            Dim yearNow As String = Date.Now.Year.ToString()
            connector.connect.Open()
            connector.query = userExpenseQuery
            'connector.query = "SELECT SUM(amount) AS total_expense FROM expense 
            '                    WHERE user_id = " & userID & " AND 
            '                    MONTH(category_date) = " & monthNow & " 
            '                    AND YEAR(category_date) = " & yearNow & ";"

            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader

            While connector.reader.Read
                If (String.IsNullOrEmpty(connector.reader("total_expense").ToString())) Then
                    expense = 0
                Else
                    expense = Double.Parse(connector.reader("total_expense").ToString())
                End If
            End While

            connector.connect.Close()

            Return expense
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Error in database from refreshing user expense.")
        End Try

        ' Return 0 if there is an error
        Return 0
    End Function

    Private Function loadUserIncome(userIncomeQuery As String)
        Try
            Dim income As Double = 0
            Dim monthNow As String = Date.Now.Month.ToString()
            Dim yearNow As String = Date.Now.Year.ToString()
            connector.connect.Open()
            connector.query = userIncomeQuery
            'connector.query = "SELECT SUM(amount) AS total_income FROM income 
            '                    WHERE user_id = " & userID & " AND 
            '                    MONTH(category_date) = " & monthNow & " 
            '                    AND YEAR(category_date) = " & yearNow & ";"

            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader

            While connector.reader.Read
                If (String.IsNullOrEmpty(connector.reader("total_income").ToString())) Then
                    income = 0
                Else
                    income = Double.Parse(connector.reader("total_income").ToString())
                End If
            End While

            connector.connect.Close()

            Return income
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Error in database from refreshing user income.")
        End Try

        ' Return 0 if there is an error
        Return 0
    End Function

    Private Sub incomeListData_MouseWheel(sender As Object, e As MouseEventArgs) Handles incomeListData.MouseWheel
        Dim dgv As DataGridView = DirectCast(sender, DataGridView)

        ' Positive delta scrolls up, negative delta scrolls down
        If e.Delta > 0 Then
            If dgv.FirstDisplayedScrollingRowIndex > 0 Then
                dgv.FirstDisplayedScrollingRowIndex -= 1
            End If
        ElseIf e.Delta < 0 Then
            If dgv.FirstDisplayedScrollingRowIndex < dgv.RowCount - 1 Then
                dgv.FirstDisplayedScrollingRowIndex += 1
            End If
        End If
    End Sub

    Private Sub expenseListData_MouseWheel(sender As Object, e As MouseEventArgs) Handles expenseListData.MouseWheel
        Dim dgv As DataGridView = DirectCast(sender, DataGridView)

        ' Positive delta scrolls up, negative delta scrolls down
        If e.Delta > 0 Then
            If dgv.FirstDisplayedScrollingRowIndex > 0 Then
                dgv.FirstDisplayedScrollingRowIndex -= 1
            End If
        ElseIf e.Delta < 0 Then
            If dgv.FirstDisplayedScrollingRowIndex < dgv.RowCount - 1 Then
                dgv.FirstDisplayedScrollingRowIndex += 1
            End If
        End If
    End Sub

    Private Sub savingsListData_MouseWheel(sender As Object, e As MouseEventArgs) Handles savingsListData.MouseWheel
        Dim dgv = DirectCast(sender, DataGridView)

        ' Positive delta scrolls up, negative delta scrolls down
        If e.Delta > 0 Then
            If dgv.FirstDisplayedScrollingRowIndex > 0 Then
                dgv.FirstDisplayedScrollingRowIndex -= 1
            End If
        ElseIf e.Delta < 0 Then
            If dgv.FirstDisplayedScrollingRowIndex < dgv.RowCount - 1 Then
                dgv.FirstDisplayedScrollingRowIndex += 1
            End If
        End If
    End Sub

    Private Sub Dashboard_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        profileTab.Visible = False
    End Sub

    Private Sub transactionButton_Click(sender As Object, e As EventArgs) Handles transactionButton.Click
        closeWindows()
        addTransaction.typeComboBox.Text = "Income"
        addTransaction.Visible = True
    End Sub

    Private Sub makeATChild()
        addTransaction.TopLevel = False
        addTransaction.Parent = Me
        CenterAT()
        addTransaction.BringToFront()
    End Sub

    'Periods
    Private Sub makeDFChild()
        dayForm.TopLevel = False
        dayForm.Parent = Me
        CenterDF()
        dayForm.BringToFront()
    End Sub

    Private Sub makeWFChild()
        weekForm.TopLevel = False
        weekForm.Parent = Me
        CenterWF()
        weekForm.BringToFront()
    End Sub

    Private Sub makeMFChild()
        monthForm.TopLevel = False
        monthForm.Parent = Me
        CenterMF()
        monthForm.BringToFront()
    End Sub

    Private Sub makeYFChild()
        yearForm.TopLevel = False
        yearForm.Parent = Me
        CenterYF()
        yearForm.BringToFront()
    End Sub

    'Type List
    Private Sub makeELFChild()
        expenseListForm.TopLevel = False
        expenseListForm.Parent = Me
        CenterELF()
        expenseListForm.BringToFront()
    End Sub

    Private Sub makeILFChild()
        incomeListForm.TopLevel = False
        incomeListForm.Parent = Me
        CenterILF()
        incomeListForm.BringToFront()
    End Sub

    Private Sub makeSLFChild()
        savingsListForm.TopLevel = False
        savingsListForm.Parent = Me
        CenterSLF()
        savingsListForm.BringToFront()
    End Sub

    Private Sub CenterAT()
        Dim x As Integer = (Me.ClientSize.Width - addTransaction.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - addTransaction.Height) \ 2
        addTransaction.Location = New Point(x, y)
    End Sub

    'Periods
    Private Sub CenterDF()
        Dim x As Integer = (Me.ClientSize.Width - dayForm.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - dayForm.Height) \ 2
        dayForm.Location = New Point(x, y)
    End Sub

    Private Sub CenterWF()
        Dim x As Integer = (Me.ClientSize.Width - weekForm.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - weekForm.Height) \ 2
        weekForm.Location = New Point(x, y)
    End Sub

    Private Sub CenterMF()
        Dim x As Integer = (Me.ClientSize.Width - monthForm.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - monthForm.Height) \ 2
        monthForm.Location = New Point(x, y)
    End Sub

    Private Sub CenterYF()
        Dim x As Integer = (Me.ClientSize.Width - yearForm.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - yearForm.Height) \ 2
        yearForm.Location = New Point(x, y)
    End Sub

    'Type List
    Private Sub CenterELF()
        Dim x As Integer = (Me.ClientSize.Width - expenseListForm.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - expenseListForm.Height) \ 2
        expenseListForm.Location = New Point(x, y)
    End Sub

    Private Sub CenterILF()
        Dim x As Integer = (Me.ClientSize.Width - incomeListForm.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - incomeListForm.Height) \ 2
        incomeListForm.Location = New Point(x, y)
    End Sub

    Private Sub CenterSLF()
        Dim x As Integer = (Me.ClientSize.Width - savingsListForm.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - savingsListForm.Height) \ 2
        savingsListForm.Location = New Point(x, y)
    End Sub

    Private Sub periodMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles periodMenu.SelectedIndexChanged
        closeWindows()
        Dim selectedItem = periodMenu.SelectedItem.ToString()

        If (selectedItem = "Day") Then
            dayForm.Visible = True
        ElseIf (selectedItem = "Week") Then
            weekForm.Visible = True
        ElseIf (selectedItem = "Month") Then
            monthForm.Visible = True
        ElseIf (selectedItem = "Year") Then
            yearForm.Visible = True
        End If
    End Sub

    Public Sub loadSavingsListForm()
        Dim selectedItem As String = periodMenu.SelectedItem.ToString()
        Dim savingsQuery As String = ""

        If (selectedItem = "Day") Then
            Dim day As String = dayForm.dayPicker.Text
            savingsQuery = "SELECT savings.savings_id, CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS Category, amount AS Amount, category_date AS 'Date Added'
                        FROM savings LEFT JOIN category ON category.category_id = savings.category_id 
                        WHERE savings.user_id = " & userID & " AND savings.category_date = '" & day & "' 
                        ORDER BY savings.category_date;"

        ElseIf (selectedItem = "Week") Then
            Dim weekString As String = weekForm.weekComboBox.SelectedItem.ToString()
            Dim currentYear As String = Date.Now.Year.ToString()

            Dim parts() As String = weekString.Split("-"c)
            Dim startDateString As String = parts(0).Trim() & "/" & currentYear
            Dim endDateString As String = parts(1).Trim() & "/" & currentYear

            Dim startDate As Date = Date.ParseExact(startDateString, "MM/dd/yyyy", Nothing)
            Dim endDate As Date = Date.ParseExact(endDateString, "MM/dd/yyyy", Nothing)

            Dim weekStart As String = startDate.ToString("yyyy-MM-dd")
            Dim weekEnd As String = endDate.ToString("yyyy-MM-dd")

            savingsQuery = "SELECT savings.savings_id, CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS Category, amount AS Amount, category_date AS 'Date Added'
                        FROM savings LEFT JOIN category ON category.category_id = savings.category_id 
                        WHERE savings.user_id = " & userID & " AND savings.category_date BETWEEN '" & weekStart & "' AND '" & weekEnd & "' 
                        ORDER BY savings.category_date;"

        ElseIf (selectedItem = "Month") Then
            Dim month As String = monthForm.monthPicker.Value.ToString("MM")
            Dim year As String = monthForm.monthPicker.Value.ToString("yyyy")

            savingsQuery = "SELECT savings.savings_id, CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS Category, amount AS Amount, category_date AS 'Date Added' 
                        FROM savings LEFT JOIN category ON category.category_id = savings.category_id 
                        WHERE savings.user_id = " & userID & " AND MONTH(savings.category_date) = " & month & " 
                        AND YEAR(savings.category_date) = " & year & " 
                        ORDER BY savings.category_date;"

        ElseIf (selectedItem = "Year") Then
            Dim year As String = yearForm.yearPicker.Text
            savingsQuery = "SELECT savings.savings_id, CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS Category, amount AS Amount, category_date AS 'Date Added' 
                        FROM savings LEFT JOIN category ON category.category_id = savings.category_id 
                        WHERE savings.user_id = " & userID & " AND YEAR(savings.category_date) = " & year & " 
                        ORDER BY savings.category_date;"
        End If

        Try
            Dim dataTable As New DataTable
            connector.connect.Open()
            connector.command.Connection = connector.connect
            connector.command.CommandText = savingsQuery
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(dataTable)
            connector.connect.Close()

            savingsListForm.savingsDataView.DataSource = dataTable

            If savingsListForm.savingsDataView.Columns.Contains("savings_id") Then
                savingsListForm.savingsDataView.Columns("savings_id").Visible = False
            End If

            If Not savingsListForm.savingsDataView.Columns.Contains("Edit") Then
                Dim editButton As New DataGridViewButtonColumn()
                editButton.Name = "Edit"
                editButton.HeaderText = "Edit"
                editButton.Text = "Edit"
                editButton.UseColumnTextForButtonValue = True
                savingsListForm.savingsDataView.Columns.Add(editButton)
            End If

            ' Add Delete button column if not already added
            If Not savingsListForm.savingsDataView.Columns.Contains("Remove") Then
                Dim deleteButton As New DataGridViewButtonColumn()
                deleteButton.Name = "Remove"
                deleteButton.HeaderText = "Remove"
                deleteButton.Text = "Remove"
                deleteButton.UseColumnTextForButtonValue = True
                savingsListForm.savingsDataView.Columns.Add(deleteButton)
            End If
            For i As Integer = 1 To 4
                savingsListForm.savingsDataView.Columns(i).Width = 148
            Next
            savingsListForm.savingsDataView.RowTemplate.Height = 50

        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Error in database from loading savings list form.")
        End Try
    End Sub

    Public Sub loadExpenseListForm()
        Dim selectedItem As String = periodMenu.SelectedItem.ToString()
        Dim expenseQuery As String = ""

        If (selectedItem = "Day") Then
            Dim day As String = dayForm.dayPicker.Text
            expenseQuery = "SELECT expense.expense_id, CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS Category, amount AS Amount, category_date AS 'Date Added'
                        FROM expense LEFT JOIN category ON category.category_id = expense.category_id 
                        WHERE expense.user_id = " & userID & " AND expense.category_date = '" & day & "' 
                        ORDER BY expense.category_date;"

        ElseIf (selectedItem = "Week") Then
            Dim weekString As String = weekForm.weekComboBox.SelectedItem.ToString()
            Dim currentYear As String = Date.Now.Year.ToString()

            Dim parts() As String = weekString.Split("-"c)
            Dim startDateString As String = parts(0).Trim() & "/" & currentYear
            Dim endDateString As String = parts(1).Trim() & "/" & currentYear

            Dim startDate As Date = Date.ParseExact(startDateString, "MM/dd/yyyy", Nothing)
            Dim endDate As Date = Date.ParseExact(endDateString, "MM/dd/yyyy", Nothing)

            Dim weekStart As String = startDate.ToString("yyyy-MM-dd")
            Dim weekEnd As String = endDate.ToString("yyyy-MM-dd")

            expenseQuery = "SELECT expense.expense_id, CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS Category, amount AS Amount, category_date AS 'Date Added'
                        FROM expense LEFT JOIN category ON category.category_id = expense.category_id 
                        WHERE expense.user_id = " & userID & " AND expense.category_date BETWEEN '" & weekStart & "' AND '" & weekEnd & "' 
                        ORDER BY expense.category_date;"

        ElseIf (selectedItem = "Month") Then
            Dim month As String = monthForm.monthPicker.Value.ToString("MM")
            Dim year As String = monthForm.monthPicker.Value.ToString("yyyy")

            expenseQuery = "SELECT expense.expense_id, CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS Category, amount AS Amount, category_date AS 'Date Added' 
                        FROM expense LEFT JOIN category ON category.category_id = expense.category_id 
                        WHERE expense.user_id = " & userID & " AND MONTH(expense.category_date) = " & month & " 
                        AND YEAR(expense.category_date) = " & year & " 
                        ORDER BY expense.category_date;"

        ElseIf (selectedItem = "Year") Then
            Dim year As String = yearForm.yearPicker.Text
            expenseQuery = "SELECT expense.expense_id, CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS Category, amount AS Amount, category_date AS 'Date Added' 
                        FROM expense LEFT JOIN category ON category.category_id = expense.category_id 
                        WHERE expense.user_id = " & userID & " AND YEAR(expense.category_date) = " & year & " 
                        ORDER BY expense.category_date;"
        End If

        Try
            Dim dataTable As New DataTable
            connector.connect.Open()
            connector.command.Connection = connector.connect
            connector.command.CommandText = expenseQuery
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(dataTable)
            connector.connect.Close()

            expenseListForm.expenseDataView.DataSource = dataTable

            If expenseListForm.expenseDataView.Columns.Contains("expense_id") Then
                expenseListForm.expenseDataView.Columns("expense_id").Visible = False
            End If

            If Not expenseListForm.expenseDataView.Columns.Contains("Edit") Then
                Dim editButton As New DataGridViewButtonColumn()
                editButton.Name = "Edit"
                editButton.HeaderText = "Edit"
                editButton.Text = "Edit"
                editButton.UseColumnTextForButtonValue = True
                expenseListForm.expenseDataView.Columns.Add(editButton)
            End If

            ' Add Delete button column if not already added
            If Not expenseListForm.expenseDataView.Columns.Contains("Remove") Then
                Dim deleteButton As New DataGridViewButtonColumn()
                deleteButton.Name = "Remove"
                deleteButton.HeaderText = "Remove"
                deleteButton.Text = "Remove"
                deleteButton.UseColumnTextForButtonValue = True
                expenseListForm.expenseDataView.Columns.Add(deleteButton)
            End If
            For i As Integer = 1 To 4
                expenseListForm.expenseDataView.Columns(i).Width = 148
            Next
            expenseListForm.expenseDataView.RowTemplate.Height = 50

        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Error in database from loading expense list form.")
        End Try
    End Sub

    Public Sub loadIncomeListForm()
        Dim selectedItem As String = periodMenu.SelectedItem.ToString()
        Dim incomeQuery As String = ""

        If (selectedItem = "Day") Then
            Dim day As String = dayForm.dayPicker.Text
            incomeQuery = "SELECT income.income_id, CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS Category, amount AS Amount, category_date AS 'Date Added'
                        FROM income LEFT JOIN category ON category.category_id = income.category_id 
                        WHERE income.user_id = " & userID & " AND income.category_date = '" & day & "' 
                        ORDER BY income.category_date;"

        ElseIf (selectedItem = "Week") Then
            Dim weekString As String = weekForm.weekComboBox.SelectedItem.ToString()
            Dim currentYear As String = Date.Now.Year.ToString()

            Dim parts() As String = weekString.Split("-"c)
            Dim startDateString As String = parts(0).Trim() & "/" & currentYear
            Dim endDateString As String = parts(1).Trim() & "/" & currentYear

            Dim startDate As Date = Date.ParseExact(startDateString, "MM/dd/yyyy", Nothing)
            Dim endDate As Date = Date.ParseExact(endDateString, "MM/dd/yyyy", Nothing)

            Dim weekStart As String = startDate.ToString("yyyy-MM-dd")
            Dim weekEnd As String = endDate.ToString("yyyy-MM-dd")

            incomeQuery = "SELECT income.income_id, CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS Category, amount AS Amount, category_date AS 'Date Added'
                        FROM income LEFT JOIN category ON category.category_id = income.category_id 
                        WHERE income.user_id = " & userID & " AND income.category_date BETWEEN '" & weekStart & "' AND '" & weekEnd & "' 
                        ORDER BY income.category_date;"

        ElseIf (selectedItem = "Month") Then
            Dim month As String = monthForm.monthPicker.Value.ToString("MM")
            Dim year As String = monthForm.monthPicker.Value.ToString("yyyy")

            incomeQuery = "SELECT income.income_id, CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS Category, amount AS Amount, category_date AS 'Date Added' 
                        FROM income LEFT JOIN category ON category.category_id = income.category_id 
                        WHERE income.user_id = " & userID & " AND MONTH(income.category_date) = " & month & " 
                        AND YEAR(income.category_date) = " & year & " 
                        ORDER BY income.category_date;"

        ElseIf (selectedItem = "Year") Then
            Dim year As String = yearForm.yearPicker.Text
            incomeQuery = "SELECT income.income_id, CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS Category, amount AS Amount, category_date AS 'Date Added' 
                        FROM income LEFT JOIN category ON category.category_id = income.category_id 
                        WHERE income.user_id = " & userID & " AND YEAR(income.category_date) = " & year & " 
                        ORDER BY income.category_date;"
        End If

        Try
            Dim dataTable As New DataTable
            connector.connect.Open()
            connector.command.Connection = connector.connect
            connector.command.CommandText = incomeQuery
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(dataTable)
            connector.connect.Close()

            incomeListForm.incomeDataView.DataSource = dataTable

            If incomeListForm.incomeDataView.Columns.Contains("income_id") Then
                incomeListForm.incomeDataView.Columns("income_id").Visible = False
            End If

            If Not incomeListForm.incomeDataView.Columns.Contains("Edit") Then
                Dim editButton As New DataGridViewButtonColumn()
                editButton.Name = "Edit"
                editButton.HeaderText = "Edit"
                editButton.Text = "Edit"
                editButton.UseColumnTextForButtonValue = True
                incomeListForm.incomeDataView.Columns.Add(editButton)
            End If

            ' Add Delete button column if not already added
            If Not incomeListForm.incomeDataView.Columns.Contains("Remove") Then
                Dim deleteButton As New DataGridViewButtonColumn()
                deleteButton.Name = "Remove"
                deleteButton.HeaderText = "Remove"
                deleteButton.Text = "Remove"
                deleteButton.UseColumnTextForButtonValue = True
                incomeListForm.incomeDataView.Columns.Add(deleteButton)
            End If
            For i As Integer = 1 To 4
                incomeListForm.incomeDataView.Columns(i).Width = 148
            Next
            incomeListForm.incomeDataView.RowTemplate.Height = 50

        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Error in database from loading income list form.")
        End Try
    End Sub

    Private Sub incomeListLabel_Click(sender As Object, e As EventArgs) Handles incomeListLabel.Click
        closeWindows()
        If (Not incomeListForm.Visible) Then
            loadIncomeListForm()
            incomeListForm.Visible = True
        Else
            incomeListForm.Visible = False
        End If
    End Sub

    Private Sub expenseListLabel_Click(sender As Object, e As EventArgs) Handles expenseListLabel.Click
        closeWindows()
        If (Not expenseListForm.Visible) Then
            loadExpenseListForm()
            expenseListForm.Visible = True
        Else
            expenseListForm.Visible = False
        End If
    End Sub

    Private Sub savingsListLabel_Click(sender As Object, e As EventArgs) Handles savingsListLabel.Click
        closeWindows()
        If (Not savingsListForm.Visible) Then
            loadSavingsListForm()
            savingsListForm.Visible = True
        Else
            savingsListForm.Visible = False
        End If
    End Sub

    Private Sub profile_Click(sender As Object, e As EventArgs) Handles profile.Click
        'closeWindows()
        If (Not profileTab.Visible) Then
            profileTab.Visible = True
        Else
            profileTab.Visible = False
        End If
    End Sub

    Private Sub logoutButton_Click(sender As Object, e As EventArgs) Handles logoutButton.Click
        Me.Visible = False
        startingForm.Visible = True
        usernameLabel.Text = ""
        usernameLabel.Location = New Point(1172, 33)
        'set everything default
        setDefault()
    End Sub

    Private Sub setDefault()
        'Reset all forms to default state
        addTransaction.Visible = False
        dayForm.Visible = False
        weekForm.Visible = False
        monthForm.Visible = False
        yearForm.Visible = False
        incomeListForm.Visible = False
        expenseListForm.Visible = False
        savingsListForm.Visible = False

        'Reset fields from login
        startingForm.usernameLoginBox.Text = ""
        startingForm.passwordLoginBox.Text = ""

        startingForm.usernameLoginBox.BackColor = Color.White
        startingForm.passwordLoginBox.BackColor = Color.White

        startingForm.usernameLogInBoxPanel.BackColor = Color.White
        startingForm.passwordLogInBoxPanel.BackColor = Color.White

        startingForm.disappearingPassLogInLabel.Visible = True

        'Reset the period menu to default selection
        periodMenu.Text = "Month"
        monthForm.Visible = False

        'Hide profile tab if visible
        profileTab.Visible = False
    End Sub

    Private Sub closeWindows()
        'Close all child forms
        addTransaction.Visible = False
        dayForm.Visible = False
        weekForm.Visible = False
        monthForm.Visible = False
        yearForm.Visible = False
        incomeListForm.Visible = False
        expenseListForm.Visible = False
        savingsListForm.Visible = False

        'Hide the profile tab
        profileTab.Visible = False
    End Sub

    Private Sub mainPanel_Click(sender As Object, e As EventArgs) Handles mainPanel.Click
        profileTab.Visible = False
    End Sub

    Private Sub chartContainer_Click(sender As Object, e As EventArgs) Handles chartContainer.Click
        profileTab.Visible = False
    End Sub

    Private Sub mainPanel_Paint(sender As Object, e As PaintEventArgs) Handles mainPanel.Paint

    End Sub

    Private Sub RoundPanelCorners(p As Panel, radius As Integer)
        Dim path As New GraphicsPath()
        Dim rect As Rectangle = p.ClientRectangle

        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90)
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90)
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90)
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90)
        path.CloseAllFigures()

        p.Region = New Region(path)
    End Sub

    Private Sub exportButton_Click(sender As Object, e As EventArgs) Handles exportButton.Click

        'SELECT type.type_name, category.category_name, income.amount, income.category_date
        'FROM income
        'LEFT JOIN category ON income.category_id = category.category_id
        'LEFT JOIN type ON category.type_id = type.type_id
        'UNION ALL
        'SELECT type.type_name, category.category_name, expense.amount, expense.category_date
        'FROM expense
        'LEFT JOIN category ON expense.category_id = category.category_id
        'LEFT JOIN type ON category.type_id = type.type_id
        'UNION ALL
        'SELECT type.type_name, category.category_name, savings.amount, savings.category_date
        'FROM savings
        'LEFT JOIN category ON savings.category_id = category.category_id
        'LEFT JOIN type ON category.type_id = type.type_id;

        Dim dataGridView As New DataGridView

        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "CSV files (*.csv)|*.csv"
        saveFileDialog.Title = "Save as CSV"

        'userID = getUserID(username)
        Dim query As String = ""

        If (periodMenu.Text = "Day") Then
            Dim day As String = dayForm.dayPicker.Text.ToString()
            query = "SELECT type.type_name, category.category_name, income.amount, income.category_date 
                     FROM income 
                     LEFT JOIN category ON income.category_id = category.category_id 
                     LEFT JOIN type ON category.type_id = type.type_id 
                     WHERE income.user_id = " & userID & " AND income.category_date = '" & day & "' 
                     UNION ALL 
                     SELECT type.type_name, category.category_name, expense.amount, expense.category_date 
                     FROM expense 
                     LEFT JOIN category ON expense.category_id = category.category_id 
                     LEFT JOIN type ON category.type_id = type.type_id 
                     WHERE expense.user_id = " & userID & " AND expense.category_date = '" & day & "' 
                     UNION ALL 
                     SELECT type.type_name, category.category_name, savings.amount, savings.category_date 
                     FROM savings 
                     LEFT JOIN category ON savings.category_id = category.category_id 
                     LEFT JOIN type ON category.type_id = type.type_id 
                     WHERE savings.user_id = " & userID & " AND savings.category_date = '" & day & "';"

        ElseIf (periodMenu.Text = "Week") Then
            Dim weekString As String = weekForm.weekComboBox.SelectedItem.ToString()
            Dim currentYear As String = Date.Now.Year.ToString()

            Dim parts() As String = weekString.Split("-"c)
            Dim startDateString As String = parts(0).Trim() & "/" & currentYear
            Dim endDateString As String = parts(1).Trim() & "/" & currentYear

            Dim startDate As Date = Date.ParseExact(startDateString, "MM/dd/yyyy", Nothing)
            Dim endDate As Date = Date.ParseExact(endDateString, "MM/dd/yyyy", Nothing)

            Dim weekStart As String = startDate.ToString("yyyy-MM-dd")
            Dim weekEnd As String = endDate.ToString("yyyy-MM-dd")

            query = "SELECT type.type_name, category.category_name, income.amount, income.category_date 
                     FROM income 
                     LEFT JOIN category ON income.category_id = category.category_id 
                     LEFT JOIN type ON category.type_id = type.type_id 
                     WHERE income.user_id = " & userID & " AND income.category_date BETWEEN '" & weekStart & "' AND '" & weekEnd & "' 
                     UNION ALL 
                     SELECT type.type_name, category.category_name, expense.amount, expense.category_date 
                     FROM expense 
                     LEFT JOIN category ON expense.category_id = category.category_id 
                     LEFT JOIN type ON category.type_id = type.type_id 
                     WHERE expense.user_id = " & userID & " AND expense.category_date BETWEEN '" & weekStart & "' AND '" & weekEnd & "' 
                     UNION ALL 
                     SELECT type.type_name, category.category_name, savings.amount, savings.category_date 
                     FROM savings 
                     LEFT JOIN category ON savings.category_id = category.category_id 
                     LEFT JOIN type ON category.type_id = type.type_id 
                     WHERE savings.user_id = " & userID & " AND savings.category_date BETWEEN '" & weekStart & "' AND '" & weekEnd & "';"

        ElseIf (periodMenu.Text = "Month") Then
            Dim month As String = monthForm.monthPicker.Value.ToString("MM")
            Dim year As String = monthForm.monthPicker.Value.ToString("yyyy")

            query = "SELECT type.type_name, category.category_name, income.amount, income.category_date 
                     FROM income 
                     LEFT JOIN category ON income.category_id = category.category_id 
                     LEFT JOIN type ON category.type_id = type.type_id 
                     WHERE income.user_id = " & userID & " AND MONTH(income.category_date) = " & month & " AND YEAR(income.category_date) = " & year & " 
                     UNION ALL 
                     SELECT type.type_name, category.category_name, expense.amount, expense.category_date 
                     FROM expense 
                     LEFT JOIN category ON expense.category_id = category.category_id 
                     LEFT JOIN type ON category.type_id = type.type_id 
                     WHERE expense.user_id = " & userID & " AND MONTH(expense.category_date) = " & month & " AND YEAR(expense.category_date) = " & year & " 
                     UNION ALL 
                     SELECT type.type_name, category.category_name, savings.amount, savings.category_date 
                     FROM savings 
                     LEFT JOIN category ON savings.category_id = category.category_id 
                     LEFT JOIN type ON category.type_id = type.type_id 
                     WHERE savings.user_id = " & userID & " AND MONTH(savings.category_date) = " & month & " AND YEAR(savings.category_date) = " & year & ";"

        ElseIf (periodMenu.Text = "Year") Then
            Dim year As String = yearForm.yearPicker.Text

            query = "SELECT type.type_name, category.category_name, income.amount, income.category_date 
                     FROM income 
                     LEFT JOIN category ON income.category_id = category.category_id 
                     LEFT JOIN type ON category.type_id = type.type_id 
                     WHERE income.user_id = " & userID & " AND YEAR(income.category_date) = " & year & " 
                     UNION ALL 
                     SELECT type.type_name, category.category_name, expense.amount, expense.category_date 
                     FROM expense 
                     LEFT JOIN category ON expense.category_id = category.category_id 
                     LEFT JOIN type ON category.type_id = type.type_id 
                     WHERE expense.user_id = " & userID & " AND YEAR(expense.category_date) = " & year & " 
                     UNION ALL 
                     SELECT type.type_name, category.category_name, savings.amount, savings.category_date 
                     FROM savings 
                     LEFT JOIN category ON savings.category_id = category.category_id 
                     LEFT JOIN type ON category.type_id = type.type_id 
                     WHERE savings.user_id = " & userID & " AND YEAR(savings.category_date) = " & year & ";"

        End If

        Dim dataTable As New DataTable
        Try
            connector.connect.Open()
            connector.command.Connection = connector.connect
            connector.command.CommandText = query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(dataTable)
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
        End Try

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            exportToCSV(dataTable, saveFileDialog.FileName)
        End If

    End Sub

    Private Sub exportToCSV(dt As DataTable, filePath As String)
        Try
            Using writer As New StreamWriter(filePath)

                For i As Integer = 0 To dt.Columns.Count - 1
                    writer.Write(dt.Columns(i).ColumnName)
                    If i < dt.Columns.Count - 1 Then writer.Write(",")
                Next
                writer.WriteLine()

                For Each row As DataRow In dt.Rows
                    For i As Integer = 0 To dt.Columns.Count - 1
                        Dim value As String

                        If TypeOf row(i) Is DateTime Then
                            value = CType(row(i), DateTime).ToString("MM/dd/yyyy")
                        Else
                            value = row(i).ToString()
                        End If

                        writer.Write("""" & value.Replace("""", """""") & """")
                        If i < dt.Columns.Count - 1 Then writer.Write(",")
                    Next
                    writer.WriteLine()
                Next
            End Using

            MessageBox.Show("CSV exported successfully.")

        Catch ex As Exception
            MessageBox.Show("Export failed: " & ex.Message)
        End Try
    End Sub


End Class