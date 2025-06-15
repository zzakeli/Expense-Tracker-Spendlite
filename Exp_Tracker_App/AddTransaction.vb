Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class AddTransaction
    Private connector As New DatabaseConnector
    Private dashboard As Dashboard
    Private dayForm As DayForm
    Private weekForm As WeekForm
    Private monthForm As MonthForm
    Private yearForm As YearForm

    Public Sub New(dashboard As Dashboard, dayForm As DayForm, weekForm As WeekForm,
                   monthForm As MonthForm, yearForm As YearForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.dashboard = dashboard
        Me.dayForm = dayForm
        Me.weekForm = weekForm
        Me.monthForm = monthForm
        Me.yearForm = yearForm
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Visible = False
    End Sub

    Private Sub typeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles typeComboBox.SelectedIndexChanged
        categoryComboBox.Items.Clear()

        Dim type As String = typeComboBox.SelectedItem.ToString()
        Dim categories() As String = {}
        If (type = "Income") Then
            categories = {
                "Salary", "Allowance", "Business Income",
                "Investment Income", "Other Income"
            }
        ElseIf (type = "Expense") Then
            categories = {
                "Rent", "Utilities", "Groceries",
                "Transportation", "Education", "Health",
                "Dining out", "Pet", "Shopping"
            }
        ElseIf (type = "Savings") Then
            categories = {
                "Emergency Fund", "Retirement Savings",
                "Travel Savings", "Education Savings",
                "Other Savings"
            }
        End If

        categoryComboBox.Items.AddRange(categories)
        categoryComboBox.SelectedIndex = 0
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        Dim num As Double
        If Not Double.TryParse(amountBox.Text, num) Then
            MessageBox.Show("Please enter a valid amount.")
            Exit Sub
        End If

        Dim userID As Integer = dashboard.getUserID()
        Dim type As String = typeComboBox.SelectedItem.ToString()
        Dim amount As Double = Double.Parse(amountBox.Text.ToString())
        Dim category As String = categoryComboBox.SelectedItem.ToString()
        Dim dateValue As Date = datePicker.Value

        If (type = "Income") Then
            insertIncome(userID, amount, category, dateValue)
        ElseIf (type = "Expense") Then
            insertExpense(userID, amount, category, dateValue)
        ElseIf (type = "Savings") Then
            insertSavings(userID, amount, category, dateValue)
        End If

        'Set to default
        typeComboBox.Text = "Income"
        categoryComboBox.Text = "Salary"
        amountBox.Text = ""
        datePicker.Value = Date.Now

        dashboard.prepareQueryThenRefresh()

        Me.Visible = False
    End Sub

    Private Sub insertIncome(userID As Integer, amount As Double, category As String, dateValue As Date)
        Dim incomeCategoryID As Integer = 0

        Select Case category
            Case "Salary"
                incomeCategoryID = 1
            Case "Allowance"
                incomeCategoryID = 2
            Case "Business Income"
                incomeCategoryID = 3
            Case "Investment Income"
                incomeCategoryID = 4
            Case "Other Income"
                incomeCategoryID = 5
        End Select
        Try
            connector.connect.Open()
            connector.query = "INSERT INTO income (user_id, category_id, amount, category_date) VALUES (" & userID & ", " & incomeCategoryID & ", " & amount & ", '" & dateValue.ToString("yyyy-MM-dd") & "');"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Error in database from inserting income: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub insertExpense(userID As Integer, amount As Double, category As String, dateValue As Date)
        Dim expenseCategoryID As Integer = 0

        Select Case category
            Case "Rent"
                expenseCategoryID = 6
            Case "Utilities"
                expenseCategoryID = 7
            Case "Groceries"
                expenseCategoryID = 8
            Case "Transportation"
                expenseCategoryID = 9
            Case "Education"
                expenseCategoryID = 10
            Case "Health"
                expenseCategoryID = 11
            Case "Dining out"
                expenseCategoryID = 12
            Case "Pet"
                expenseCategoryID = 13
            Case "Shopping"
                expenseCategoryID = 14
        End Select
        Try
            connector.connect.Open()
            connector.query = "INSERT INTO expense (user_id, category_id, amount, category_date) VALUES (" & userID & ", " & expenseCategoryID & ", " & amount & ", '" & dateValue.ToString("yyyy-MM-dd") & "');"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Error in database from inserting expense: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub insertSavings(userID As Integer, amount As Double, category As String, dateValue As Date)
        Dim savingsCategoryID As Integer = 0

        Select Case category
            Case "Emergency Fund"
                savingsCategoryID = 15
            Case "Retirement Savings"
                savingsCategoryID = 16
            Case "Travel Savings"
                savingsCategoryID = 17
            Case "Education Savings"
                savingsCategoryID = 18
            Case "Other Savings"
                savingsCategoryID = 19
        End Select
        Try
            connector.connect.Open()
            connector.query = "INSERT INTO savings (user_id, category_id, amount, category_date) VALUES (" & userID & ", " & savingsCategoryID & ", " & amount & ", '" & dateValue.ToString("yyyy-MM-dd") & "');"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.command.ExecuteNonQuery()
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Error in database from inserting savings: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        curveCorners()
        roundControlCorners(addTransactionLabelPanel, 15)
        roundControlCorners(typeComboBox, 15)
        roundControlCorners(amountBoxPanel, 15)
        roundControlCorners(categoryComboBox, 15)
        roundControlCorners(datePicker, 15)
        roundControlCorners(cancelButton, 40)
        roundControlCorners(addButton, 40)
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
End Class