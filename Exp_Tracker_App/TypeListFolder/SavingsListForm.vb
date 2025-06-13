Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class SavingsListForm

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
        Me.Visible = False
    End Sub

    Private Sub loadRowData(savingsID As Integer)
        Try
            connector.connect.Open()
            connector.query = "SELECT * FROM savings WHERE savings_id = " & savingsID & ";"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader

            While connector.reader.Read
                Dim categoryID As Integer = Convert.ToInt32(connector.reader("category_id"))

                If (categoryID = 15) Then
                    editTransactionForm.categoryBox.SelectedItem = "Emergency Fund"
                ElseIf (categoryID = 16) Then
                    editTransactionForm.categoryBox.SelectedItem = "Retirement Savings"
                ElseIf (categoryID = 17) Then
                    editTransactionForm.categoryBox.SelectedItem = "Travel Savings"
                ElseIf (categoryID = 18) Then
                    editTransactionForm.categoryBox.SelectedItem = "Education Savings"
                ElseIf (categoryID = 19) Then
                    editTransactionForm.categoryBox.SelectedItem = "Other Savings"
                End If

                editTransactionForm.amountBox.Text = connector.reader("amount").ToString()
                editTransactionForm.datePicker.Value = Convert.ToDateTime(connector.reader("category_date"))
            End While
            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
        End Try
    End Sub

    Private Sub savingsDataView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles savingsDataView.CellContentClick
        If e.ColumnIndex = savingsDataView.Columns("Edit").Index AndAlso e.RowIndex >= 0 Then
            Dim savingsID As Integer = Convert.ToInt32(savingsDataView.Rows(e.RowIndex).Cells("savings_id").Value)
            editTransactionForm.setID(savingsID)

            Dim categories = {
                "Emergency Fund", "Retirement Savings", "Travel Savings",
                "Education Savings", "Other Savings"
            }

            editTransactionForm.typeLabel.Text = "Savings"
            editTransactionForm.categoryBox.Items.Clear()
            editTransactionForm.categoryBox.Items.AddRange(categories)
            loadRowData(savingsID)
            editTransactionForm.Visible = True
        End If

        If e.ColumnIndex = savingsDataView.Columns("Delete").Index AndAlso e.RowIndex >= 0 Then
            Dim confirmDelete = MessageBox.Show("Are you sure you want to delete this savings record?", "Confirm Delete", MessageBoxButtons.YesNo)

            If confirmDelete = DialogResult.Yes Then
                Dim savingsID As Integer = Convert.ToInt32(savingsDataView.Rows(e.RowIndex).Cells("savings_id").Value)

                Try
                    connector.connect.Open()
                    Dim deleteQuery As String = "DELETE FROM savings WHERE savings_id = @id"
                    Dim cmd As New MySqlCommand(deleteQuery, connector.connect)
                    cmd.Parameters.AddWithValue("@id", savingsID)
                    cmd.ExecuteNonQuery()
                    connector.connect.Close()

                    MessageBox.Show("Savings record deleted.")
                    ' Refresh list
                    dashboard.loadSavingsListForm()
                    dashboard.prepareQueryThenRefresh()
                Catch ex As Exception
                    connector.connect.Close()
                    MessageBox.Show("Failed to delete record: " & ex.Message)
                End Try
            End If
        End If
    End Sub


    Private Sub SavingsListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        curveCorners()
        RoundPanelCorners(savingsDataViewPanel, 25)
        makeETFChild()
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
            dashboard.loadSavingsListForm()
            Exit Sub
        End If
        Try
            Dim userID As Integer = dashboard.getUserID()
            Dim categoryID As Integer
            Dim selectedItem As String = dashboard.periodMenu.SelectedItem.ToString()
            Dim savingsQuery As String = ""

            Select Case searchText
                Case "emergency fund"
                    categoryID = 15
                Case "retirement savings"
                    categoryID = 16
                Case "travel savings"
                    categoryID = 17
                Case "education savings"
                    categoryID = 18
                Case "other savings"
                    categoryID = 19
                Case Else
                    categoryID = 0 ' Default case if no match found
            End Select

            If (selectedItem = "Day") Then
                Dim day As String = dayForm.dayPicker.Text
                savingsQuery = "SELECT savings.savings_id, category.category_name AS category, amount AS Amount, category_date AS 'Date Added'
                        FROM savings LEFT JOIN category ON category.category_id = savings.category_id 
                        WHERE savings.user_id = " & userID & " AND savings.category_date = '" & day & "' 
                        AND savings.category_id = " & categoryID & " ORDER BY savings.category_date;"

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

                savingsQuery = "SELECT savings.savings_id, category.category_name AS category, amount AS Amount, category_date AS 'Date Added'
                        FROM savings LEFT JOIN category ON category.category_id = savings.category_id 
                        WHERE savings.user_id = " & userID & " AND savings.category_date BETWEEN '" & weekStart & "' AND '" & weekEnd & "' 
                        AND savings.category_id = " & categoryID & " ORDER BY savings.category_date;"

            ElseIf (selectedItem = "Month") Then
                Dim month As String = monthForm.monthPicker.Value.ToString("MM")
                Dim year As String = monthForm.monthPicker.Value.ToString("yyyy")

                savingsQuery = "SELECT savings.savings_id, category.category_name AS category, amount AS Amount, category_date AS 'Date Added' 
                        FROM savings LEFT JOIN category ON category.category_id = savings.category_id 
                        WHERE savings.user_id = " & userID & " AND MONTH(savings.category_date) = " & month & " 
                        AND YEAR(savings.category_date) = " & year & " 
                        AND savings.category_id = " & categoryID & " ORDER BY savings.category_date;"

            ElseIf (selectedItem = "Year") Then
                Dim year As String = yearForm.yearPicker.Text
                savingsQuery = "SELECT savings.savings_id, category.category_name AS category, amount AS Amount, category_date AS 'Date Added' 
                        FROM savings LEFT JOIN category ON category.category_id = savings.category_id 
                        WHERE savings.user_id = " & userID & " AND YEAR(savings.category_date) = " & year & " 
                        AND savings.category_id = " & categoryID & " ORDER BY savings.category_date;"
            End If

            Dim dataTable As New DataTable
            connector.connect.Open()
            connector.command.Connection = connector.connect
            connector.command.CommandText = savingsQuery
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(dataTable)
            connector.connect.Close()

            savingsDataView.DataSource = dataTable

            If savingsDataView.Columns.Contains("savings_id") Then
                savingsDataView.Columns("savings_id").Visible = False
            End If

            If Not savingsDataView.Columns.Contains("Edit") Then
                Dim editButton As New DataGridViewButtonColumn()
                editButton.Name = "Edit"
                editButton.HeaderText = "Edit"
                editButton.Text = "Edit"
                editButton.UseColumnTextForButtonValue = True
                savingsDataView.Columns.Add(editButton)
            End If

            ' Add Delete button column if not already added
            If Not savingsDataView.Columns.Contains("Delete") Then
                Dim deleteButton As New DataGridViewButtonColumn()
                deleteButton.Name = "Delete"
                deleteButton.HeaderText = "Delete"
                deleteButton.Text = "Delete"
                deleteButton.UseColumnTextForButtonValue = True
                savingsDataView.Columns.Add(deleteButton)
            End If
            For i As Integer = 1 To 4
                savingsDataView.Columns(i).Width = 148
            Next
            savingsDataView.RowTemplate.Height = 50
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Error in searching savings category.")
        End Try
    End Sub

    Private Sub savingsDataView_MouseWheel(sender As Object, e As MouseEventArgs) Handles savingsDataView.MouseWheel
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