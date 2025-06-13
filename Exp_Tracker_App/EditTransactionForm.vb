Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class EditTransactionForm
    Private connector As New DatabaseConnector
    Private incomeListForm As IncomeListForm
    Private expenseListForm As ExpenseListForm
    Private savingsListForm As SavingsListForm
    Private id As Integer
    Private dashboard As Dashboard

    Public Sub New(incomeListForm As IncomeListForm, dashboard As Dashboard)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.incomeListForm = incomeListForm
        Me.dashboard = dashboard
    End Sub

    Public Sub New(expenseListForm As ExpenseListForm, dashboard As Dashboard)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.expenseListForm = expenseListForm
        Me.dashboard = dashboard
    End Sub

    Public Sub New(savingsListForm As SavingsListForm, dashboard As Dashboard)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.savingsListForm = savingsListForm
        Me.dashboard = dashboard
    End Sub
    Private Sub EditTransactionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        curveCorners()
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

    Public Sub setID(id As Integer)
        Me.id = id
    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        If (typeLabel.Text.ToString() = "Income") Then
            Try
                connector.connect.Open()
                Dim deleteQuery As String = "UPDATE income SET category_id = @category_id, amount = @amount, category_date = @category_date WHERE income_id = @income_id;"
                Dim cmd As New MySqlCommand(deleteQuery, connector.connect)
                Dim categoryID As Integer = 0

                Select Case categoryBox.SelectedItem.ToString()
                    Case "Salary"
                        categoryID = 1
                    Case "Allowance"
                        categoryID = 2
                    Case "Business Income"
                        categoryID = 3
                    Case "Investment Income"
                        categoryID = 4
                    Case "Other Income"
                        categoryID = 5
                End Select


                cmd.Parameters.AddWithValue("@category_id", categoryID)
                cmd.Parameters.AddWithValue("@amount", amountBox.Text.ToString())
                cmd.Parameters.AddWithValue("@category_date", datePicker.Text.ToString())
                cmd.Parameters.AddWithValue("@income_id", id)
                cmd.ExecuteNonQuery()
                connector.connect.Close()

                MessageBox.Show("Income record updated.")
                Me.Visible = False
                dashboard.loadIncomeListForm()
                dashboard.prepareQueryThenRefresh()
            Catch ex As MySqlException
                connector.connect.Close()
                'MessageBox.Show("Failed to update record: " & ex.Message)
            End Try
        ElseIf (typeLabel.Text.ToString = "Expense") Then
            Try
                connector.connect.Open()
                Dim deleteQuery As String = "UPDATE expense SET category_id = @category_id, amount = @amount, category_date = @category_date WHERE expense_id = @expense_id;"
                Dim cmd As New MySqlCommand(deleteQuery, connector.connect)
                Dim categoryID As Integer = 0

                Select Case categoryBox.SelectedItem.ToString()
                    Case "Rent"
                        categoryID = 6
                    Case "Utilities"
                        categoryID = 7
                    Case "Groceries"
                        categoryID = 8
                    Case "Transportation"
                        categoryID = 9
                    Case "Education"
                        categoryID = 10
                    Case "Health"
                        categoryID = 11
                    Case "Dining out"
                        categoryID = 12
                    Case "Pet"
                        categoryID = 13
                    Case "Shopping"
                        categoryID = 14
                End Select

                cmd.Parameters.AddWithValue("@category_id", categoryID)
                cmd.Parameters.AddWithValue("@amount", amountBox.Text.ToString())
                cmd.Parameters.AddWithValue("@category_date", datePicker.Text.ToString())
                cmd.Parameters.AddWithValue("@expense_id", id)
                cmd.ExecuteNonQuery()
                connector.connect.Close()

                MessageBox.Show("Expense record updated.")
                Me.Visible = False
                dashboard.loadExpenseListForm()
                dashboard.prepareQueryThenRefresh()
            Catch ex As MySqlException
                connector.connect.Close()
                'MessageBox.Show("Failed to update record: " & ex.Message)
            End Try
        ElseIf (typeLabel.Text.ToString = "Savings") Then
            Try
                connector.connect.Open()
                Dim deleteQuery As String = "UPDATE savings SET category_id = @category_id, amount = @amount, category_date = @category_date WHERE savings_id = @savings_id;"
                Dim cmd As New MySqlCommand(deleteQuery, connector.connect)
                Dim categoryID As Integer = 0

                Select Case categoryBox.SelectedItem.ToString()
                    Case "Emergency Fund"
                        categoryID = 15
                    Case "Retirement Savings"
                        categoryID = 16
                    Case "Travel Savings"
                        categoryID = 17
                    Case "Education Savings"
                        categoryID = 18
                    Case "Other Savings"
                        categoryID = 19
                End Select

                cmd.Parameters.AddWithValue("@category_id", categoryID)
                cmd.Parameters.AddWithValue("@amount", amountBox.Text.ToString())
                cmd.Parameters.AddWithValue("@category_date", datePicker.Text.ToString())
                cmd.Parameters.AddWithValue("@savings_id", id)
                cmd.ExecuteNonQuery()
                connector.connect.Close()

                MessageBox.Show("Savings record updated.")
                Me.Visible = False
                dashboard.loadSavingsListForm()
                dashboard.prepareQueryThenRefresh()
            Catch ex As MySqlException
                connector.connect.Close()
                'MessageBox.Show("Failed to update record: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Visible = False
    End Sub
End Class