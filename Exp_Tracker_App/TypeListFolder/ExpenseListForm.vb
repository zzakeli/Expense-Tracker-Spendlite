﻿Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class ExpenseListForm

    Private connector As New DatabaseConnector

    Private dashboard As Dashboard
    Private editTransactionForm As EditTransactionForm
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
        editTransactionForm = New EditTransactionForm(Me, Me.dashboard)
    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        searchBox.Text = ""
        editTransactionForm.Visible = False
        Me.Visible = False
    End Sub

    Private Sub loadRowData(expenseID As Integer)
        Try
            connector.connect.Open()
            connector.query = "SELECT * FROM expense WHERE expense_id = " & expenseID & ";"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader

            While connector.reader.Read
                Dim categoryID As Integer = Convert.ToInt32(connector.reader("category_id"))

                If (categoryID = 6) Then
                    editTransactionForm.categoryBox.SelectedItem = "Rent"
                ElseIf (categoryID = 7) Then
                    editTransactionForm.categoryBox.SelectedItem = "Utilities"
                ElseIf (categoryID = 8) Then
                    editTransactionForm.categoryBox.SelectedItem = "Groceries"
                ElseIf (categoryID = 9) Then
                    editTransactionForm.categoryBox.SelectedItem = "Transportation"
                ElseIf (categoryID = 10) Then
                    editTransactionForm.categoryBox.SelectedItem = "Education"
                ElseIf (categoryID = 11) Then
                    editTransactionForm.categoryBox.SelectedItem = "Health"
                ElseIf (categoryID = 12) Then
                    editTransactionForm.categoryBox.SelectedItem = "Dining out"
                ElseIf (categoryID = 13) Then
                    editTransactionForm.categoryBox.SelectedItem = "Pet"
                ElseIf (categoryID = 14) Then
                    editTransactionForm.categoryBox.SelectedItem = "Shopping"
                End If

                editTransactionForm.amountBox.Text = connector.reader("amount").ToString()
                editTransactionForm.datePicker.Value = Convert.ToDateTime(connector.reader("category_date"))
            End While
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
        End Try
    End Sub

    Private Sub expenseDataView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles expenseDataView.CellContentClick
        If e.ColumnIndex = expenseDataView.Columns("Edit").Index AndAlso e.RowIndex >= 0 Then
            Dim expenseID As Integer = Convert.ToInt32(expenseDataView.Rows(e.RowIndex).Cells("expense_id").Value)
            editTransactionForm.setID(expenseID)

            Dim categories = {
                "Rent", "Utilities", "Groceries",
                "Transportation", "Education", "Health",
                "Dining out", "Pet", "Shopping"
            }

            editTransactionForm.typeLabel.Text = "Expense"
            editTransactionForm.categoryBox.Items.Clear()
            editTransactionForm.categoryBox.Items.AddRange(categories)
            loadRowData(expenseID)
            editTransactionForm.Visible = True
        End If

        If e.ColumnIndex = expenseDataView.Columns("Remove").Index AndAlso e.RowIndex >= 0 Then
            Dim confirmDelete = MessageBox.Show("Are you sure you want to remove this expense record?", "Confirm Removal", MessageBoxButtons.YesNo)

            If confirmDelete = DialogResult.Yes Then
                Dim expenseID As Integer = Convert.ToInt32(expenseDataView.Rows(e.RowIndex).Cells("expense_id").Value)

                Try
                    connector.connect.Open()
                    Dim deleteQuery As String = "DELETE FROM expense WHERE expense_id = @id"
                    Dim cmd As New MySqlCommand(deleteQuery, connector.connect)
                    cmd.Parameters.AddWithValue("@id", expenseID)
                    cmd.ExecuteNonQuery()
                    connector.connect.Close()

                    MessageBox.Show("Expense record removed.")
                    ' Refresh list
                    dashboard.loadExpenseListForm()
                    dashboard.prepareQueryThenRefresh()
                Catch ex As Exception
                    connector.connect.Close()
                    MessageBox.Show("Failed to remove record: " & ex.Message)
                End Try
            End If
        End If
    End Sub


    Private Sub ExpenseListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        curveCorners()

        RoundPanelCorners(expenseDataViewPanel, 25)
        RoundPanelCorners(searchBoxPanel, 10)
        RoundPanelCorners(expenseListLabelPanel, 20)
        RoundButton(closeButton, 40)
        makeETFChild()
    End Sub

    Private Sub RoundButton(btn As Button, radius As Integer)
        Dim path As New GraphicsPath()
        path.StartFigure()
        path.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)
        path.AddArc(New Rectangle(btn.Width - radius, 0, radius, radius), 270, 90)
        path.AddArc(New Rectangle(btn.Width - radius, btn.Height - radius, radius, radius), 0, 90)
        path.AddArc(New Rectangle(0, btn.Height - radius, radius, radius), 90, 90)
        path.CloseFigure()

        btn.Region = New Region(path)
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

    Private Sub curveCorners()
        Dim radius As Integer = 30
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

    Private Sub makeETFChild()
        editTransactionForm.TopLevel = False
        editTransactionForm.Parent = Me
        CenterETF()
        editTransactionForm.BringToFront()
    End Sub

    Private Sub CenterETF()
        Dim x As Integer = (Me.ClientSize.Width - editTransactionForm.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - editTransactionForm.Height) \ 2
        editTransactionForm.Location = New Point(x, y)
    End Sub

    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        Dim searchText As String = searchBox.Text.Trim().ToLower()
        If (searchText = "") Then
            dashboard.loadExpenseListForm()
            Exit Sub
        End If
        Try
            Dim userID As Integer = dashboard.getUserID()
            Dim categoryID As Integer
            Dim selectedItem As String = dashboard.periodMenu.SelectedItem.ToString()
            Dim expenseQuery As String = ""

            Select Case searchText
                Case "rent"
                    categoryID = 6
                Case "utilities"
                    categoryID = 7
                Case "groceries"
                    categoryID = 8
                Case "transportation"
                    categoryID = 9
                Case "education"
                    categoryID = 10
                Case "health"
                    categoryID = 11
                Case "dining out"
                    categoryID = 12
                Case "pet"
                    categoryID = 13
                Case "shopping"
                    categoryID = 14
                Case Else
                    categoryID = 0 ' Default case if no match found
            End Select

            If (selectedItem = "Day") Then
                Dim day As String = dayForm.dayPicker.Text
                expenseQuery = "SELECT expense.expense_id, CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS category, amount AS Amount, category_date AS 'Date Added'
                        FROM expense LEFT JOIN category ON category.category_id = expense.category_id 
                        WHERE expense.user_id = " & userID & " AND expense.category_date = '" & day & "' 
                        AND expense.category_id = " & categoryID & " ORDER BY expense.category_date;"

            ElseIf (selectedItem = "Week") Then
                Dim weekString As String = weekForm.weekComboBox.SelectedItem.ToString()
                Dim currentYear As String = Date.Now.Year.ToString()

                Dim parts() As String = weekString.Split("-"c)
                Dim startDateString As String = parts(1).Trim() & "/" & currentYear
                Dim endDateString As String = parts(2).Trim() & "/" & currentYear

                Dim startDate As Date = Date.ParseExact(startDateString, "MM/dd/yyyy", Nothing)
                Dim endDate As Date = Date.ParseExact(endDateString, "MM/dd/yyyy", Nothing)

                Dim weekStart As String = startDate.ToString("yyyy-MM-dd")
                Dim weekEnd As String = endDate.ToString("yyyy-MM-dd")

                expenseQuery = "SELECT expense.expense_id, CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS category, amount AS Amount, category_date AS 'Date Added'
                        FROM expense LEFT JOIN category ON category.category_id = expense.category_id 
                        WHERE expense.user_id = " & userID & " AND expense.category_date BETWEEN '" & weekStart & "' AND '" & weekEnd & "' 
                        AND expense.category_id = " & categoryID & " ORDER BY expense.category_date;"

            ElseIf (selectedItem = "Month") Then
                Dim month As String = monthForm.monthPicker.Value.ToString("MM")
                Dim year As String = monthForm.monthPicker.Value.ToString("yyyy")

                expenseQuery = "SELECT expense.expense_id, CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS category, amount AS Amount, category_date AS 'Date Added' 
                        FROM expense LEFT JOIN category ON category.category_id = expense.category_id 
                        WHERE expense.user_id = " & userID & " AND MONTH(expense.category_date) = " & month & " 
                        AND YEAR(expense.category_date) = " & year & " 
                        AND expense.category_id = " & categoryID & " ORDER BY expense.category_date;"

            ElseIf (selectedItem = "Year") Then
                Dim year As String = yearForm.yearPicker.Text
                expenseQuery = "SELECT expense.expense_id, CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS category, amount AS Amount, category_date AS 'Date Added' 
                        FROM expense LEFT JOIN category ON category.category_id = expense.category_id 
                        WHERE expense.user_id = " & userID & " AND YEAR(expense.category_date) = " & year & " 
                        AND expense.category_id = " & categoryID & " ORDER BY expense.category_date;"
            End If

            Dim dataTable As New DataTable
            connector.connect.Open()
            connector.command.Connection = connector.connect
            connector.command.CommandText = expenseQuery
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(dataTable)
            connector.connect.Close()

            expenseDataView.DataSource = dataTable

            If expenseDataView.Columns.Contains("expense_id") Then
                expenseDataView.Columns("expense_id").Visible = False
            End If

            If Not expenseDataView.Columns.Contains("Edit") Then
                Dim editButton As New DataGridViewButtonColumn()
                editButton.Name = "Edit"
                editButton.HeaderText = "Edit"
                editButton.Text = "Edit"
                editButton.UseColumnTextForButtonValue = True
                expenseDataView.Columns.Add(editButton)
            End If

            ' Add Delete button column if not already added
            If Not expenseDataView.Columns.Contains("Remove") Then
                Dim deleteButton As New DataGridViewButtonColumn()
                deleteButton.Name = "Remove"
                deleteButton.HeaderText = "Remove"
                deleteButton.Text = "Remove"
                deleteButton.UseColumnTextForButtonValue = True
                expenseDataView.Columns.Add(deleteButton)
            End If
            For i As Integer = 1 To 4
                expenseDataView.Columns(i).Width = 148
            Next
            expenseDataView.RowTemplate.Height = 50
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Error in searching expense category.")
        End Try
    End Sub

    Private Sub expenseDataView_MouseWheel(sender As Object, e As MouseEventArgs) Handles expenseDataView.MouseWheel
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
End Class