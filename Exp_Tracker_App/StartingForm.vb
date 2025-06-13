Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient
Imports OxyPlot
Imports OxyPlot.Series
Imports OxyPlot.WindowsForms

Public Class StartingForm
    Private connector As New DatabaseConnector

    Private userID As Integer
    Private plotView As PlotView
    Private mailer As New Mail
    Private verifyOTPForm As VerifyOTPForm
    Private targetX As Integer = 0

    Private dashboard As Dashboard
    Private monthForm As MonthForm

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dashboard = New Dashboard(Me, plotView)
        monthForm = New MonthForm(dashboard)
        dashboard.setMonthForm(monthForm)
    End Sub

    Private Sub switchToLoginButton_Click(sender As Object, e As EventArgs) Handles switchToLoginButton.Click
        targetX = 0
        Timer1.Start()
        switchToLoginButton.Visible = False
        switchToSignUpButton.Visible = True
        switchLabel.Text = "Don't have an account yet?"

        usernameSignUpBox.Visible = False
        emailSignUpBox.Visible = False
        passwordSignUpBox.Visible = False
        confirmPasswordSignUpBox.Visible = False
        signUpButton.Visible = False

        usernameLoginBox.Visible = True
        passwordLoginBox.Visible = True
        forgotPassword.Visible = True
        loginButton.Visible = True
    End Sub
    Private Sub switchToSignUpButton_Click(sender As Object, e As EventArgs) Handles switchToSignUpButton.Click
        targetX = 435
        Timer1.Start()
        switchToLoginButton.Visible = True
        switchToSignUpButton.Visible = False
        switchLabel.Text = "Already have an account?"

        usernameSignUpBox.Visible = True
        emailSignUpBox.Visible = True
        passwordSignUpBox.Visible = True
        confirmPasswordSignUpBox.Visible = True
        signUpButton.Visible = True

        usernameLoginBox.Visible = False
        passwordLoginBox.Visible = False
        forgotPassword.Visible = False
        loginButton.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If slideContainer.Left > targetX Then
            slideContainer.Left -= 30
            If slideContainer.Left <= targetX Then
                slideContainer.Left = targetX
                Timer1.Stop()
            End If

        ElseIf slideContainer.Left < targetX Then
            slideContainer.Left += 30
            If slideContainer.Left >= targetX Then
                slideContainer.Left = targetX
                Timer1.Stop()
            End If
        End If
    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click
        Dim username = usernameLoginBox.Text.Trim()
        Dim password = passwordLoginBox.Text.Trim()

        If (username = "" Or password = "") Then
            If (username = "") Then
                usernameLoginBox.BackColor = Color.LightPink
                MessageBox.Show("Please fill out the username field.")
                Exit Sub
            End If
            If (password = "") Then
                passwordLoginBox.BackColor = Color.LightPink
                MessageBox.Show("Please fill out the password field.")
                Exit Sub
            End If
        End If
        Try
            Dim userCount = 0
            connector.connect.Open()
            connector.query = "SELECT COUNT(*) AS num_of_user FROM user WHERE username = '" & username & "' AND password = '" & password & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader

            While connector.reader.Read
                userCount = Integer.Parse(connector.reader("num_of_user").ToString())
            End While

            'closing the connection before loading the user data.
            connector.connect.Close()

            If (userCount = 1) Then
                Me.Visible = False

                loadUserData(username)

                dashboard.periodMenu.Text = "Month"
                monthForm.Visible = False
                dashboard.Visible = True
            Else
                MessageBox.Show("Account does not exists.")
            End If
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Database error from login.")
        End Try
    End Sub

    Private Function getUserID(username As String)
        Dim localUserID As Integer = 0
        Try
            connector.connect.Open()
            connector.query = "SELECT user_id FROM user WHERE username = '" & username & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader

            While connector.reader.Read
                localUserID = Integer.Parse(connector.reader("user_id").ToString())
            End While

            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Error in database from getting user ID.")
        End Try

        Return localUserID
    End Function

    Private Sub loadUserData(username As String)
        userID = getUserID(username)
        Dim userIncome As Integer = loadUserIncome()
        Dim userExpense As Double = loadUserExpense()
        Dim userSavings As Double = loadUserSavings()
        Dim userNetBalance As Double = loadUserNetBalance(userIncome, userExpense, userSavings)

        dashboard.setUserID(userID)
        loadUserIncomeList()
        loadUserExpenseList()
        loadUserSavingsList()

        loadChart()

        setUpUserDashboard(userNetBalance, userIncome, userExpense, userSavings)
    End Sub

    Private Sub loadChart()
        ' Create PlotView and add it to chartContainer
        plotView = New PlotView()

        ' Make plot fill the panel
        plotView.Dock = DockStyle.Fill
        dashboard.chartContainer.Controls.Add(plotView)

        ' Create a PlotModel
        Dim plotModel As New PlotModel With {.Title = "Finance Pie Chart"}

        ' Create PieSeries and add slices
        Dim pieSeries As New PieSeries() With {
            .StrokeThickness = 2.0,
            .InsideLabelPosition = 0.8,
            .AngleSpan = 360,
            .StartAngle = 0,
            .OutsideLabelFormat = Nothing,
            .InsideLabelFormat = "{1}\n{2:0.#}%".Replace("\n", Environment.NewLine)
        }

        Try
            Dim monthNow As String = Date.Now.Month.ToString()
            Dim yearNow As String = Date.Now.Year.ToString()
            connector.connect.Open()
            connector.query = "SELECT category.category_name, 
                                SUM(net_balance.amount) AS total_amount, 
                                MAX(net_balance.category_date) AS latest_date 
                                FROM category 
                                RIGHT JOIN (
                                SELECT category_id, amount, category_date FROM income 
                                WHERE user_id = " & userID & " AND MONTH(category_date) = " & monthNow & " AND YEAR(category_date) = " & yearNow & "
                                UNION ALL 
                                SELECT category_id, amount, category_date FROM expense 
                                WHERE user_id = " & userID & " AND MONTH(category_date) = " & monthNow & " AND YEAR(category_date) = " & yearNow & "
                                UNION ALL 
                                SELECT category_id, amount, category_date FROM savings 
                                WHERE user_id = " & userID & " AND MONTH(category_date) = " & monthNow & " AND YEAR(category_date) = " & yearNow & "
                                ) AS net_balance ON category.category_id = net_balance.category_id
                                GROUP BY category.category_name"

            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader

            Dim incomeCategory() = {"salary", "allowance", "business income", "investment income", "other income"}
            Dim expenseCategory() = {"rent", "utilities", "groceries", "transportation", "education", "health", "dining out", "pet", "shopping"}
            Dim savingsCategory() = {"emergency fund", "retirement savings", "travel savings", "education savings", "other savings"}
            While connector.reader.Read
                Dim category As String = connector.reader("category_name").ToString()
                Dim amount As Double = Double.Parse(connector.reader("total_amount").ToString())
                'Dim categoryDate As DateTime = DateTime.Parse(connector.reader("category_date").ToString())

                If (incomeCategory.Contains(category)) Then
                    pieSeries.Slices.Add(New PieSlice(category, amount) With {.Fill = OxyColors.LimeGreen})
                ElseIf (expenseCategory.Contains(category)) Then
                    pieSeries.Slices.Add(New PieSlice(category, amount) With {.Fill = OxyColors.Pink})
                ElseIf (savingsCategory.Contains(category)) Then
                    pieSeries.Slices.Add(New PieSlice(category, amount) With {.Fill = OxyColors.Yellow})
                End If
            End While

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

    Private Sub loadUserIncomeList()
        Try
            Dim monthNow As String = Date.Now.Month.ToString()
            Dim yearNow As String = Date.Now.Year.ToString()
            Dim dataTable As New DataTable
            connector.connect.Open()
            connector.query = "SELECT DISTINCT category.category_name FROM category 
                                LEFT JOIN income ON category.category_id = income.category_id 
                                WHERE user_id = " & userID & " AND 
                                MONTH(income.category_date) = " & monthNow & " AND 
                                YEAR(income.category_date) = " & yearNow & ";"

            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(dataTable)
            dashboard.incomeListData.DataSource = dataTable
            connector.command.ExecuteNonQuery()

            dashboard.incomeListData.Columns(0).Width = dashboard.incomeListData.ClientSize.Width
            dashboard.incomeListData.RowTemplate.Height = 50

            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Error in database from loading user income list.")
        End Try
    End Sub

    Private Sub loadUserExpenseList()
        Try
            Dim monthNow As String = Date.Now.Month.ToString()
            Dim yearNow As String = Date.Now.Year.ToString()
            Dim dataTable As New DataTable
            connector.connect.Open()
            connector.query = "SELECT DISTINCT category.category_name FROM category 
                                LEFT JOIN expense ON category.category_id = expense.category_id 
                                WHERE user_id = " & userID & " AND 
                                MONTH(expense.category_date) = " & monthNow & " AND 
                                YEAR(expense.category_date) = " & yearNow & ";"

            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(dataTable)
            dashboard.expenseListData.DataSource = dataTable
            connector.command.ExecuteNonQuery()

            dashboard.expenseListData.Columns(0).Width = dashboard.expenseListData.ClientSize.Width
            dashboard.expenseListData.RowTemplate.Height = 50

            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Error in database from loading user expense list.")
        End Try
    End Sub

    Private Sub loadUserSavingsList()
        Try
            Dim monthNow As String = Date.Now.Month.ToString()
            Dim yearNow As String = Date.Now.Year.ToString()
            Dim dataTable As New DataTable
            connector.connect.Open()
            connector.query = "SELECT DISTINCT category.category_name FROM category 
                                LEFT JOIN savings ON category.category_id = savings.category_id 
                                WHERE user_id = " & userID & " AND 
                                MONTH(savings.category_date) = " & monthNow & " AND 
                                YEAR(savings.category_date) = " & yearNow & ";"

            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.dataAdapter.SelectCommand = connector.command
            connector.dataAdapter.Fill(dataTable)
            dashboard.savingsListData.DataSource = dataTable
            connector.command.ExecuteNonQuery()

            dashboard.savingsListData.Columns(0).Width = dashboard.savingsListData.ClientSize.Width
            dashboard.savingsListData.RowTemplate.Height = 50

            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Error in database from loading user savings list.")
        End Try
    End Sub

    Private Sub setUpUserDashboard(userNetBalance As Double, userIncome As Double, userExpense As Double, userSavings As Double)
        dashboard.netBalanceValue.Text = "P " & userNetBalance.ToString()
        dashboard.incomeValue.Text = "P " & userIncome.ToString()
        dashboard.expenseValue.Text = "P " & userExpense.ToString()
        dashboard.savingsValue.Text = "P " & userSavings.ToString()
    End Sub

    Private Function loadUserNetBalance(userIncome As Double, userExpense As Double, userSavings As Double)
        Return userIncome - userExpense - userSavings
    End Function

    Private Function loadUserIncome()
        Try
            Dim income As Double = 0
            Dim monthNow As String = Date.Now.Month.ToString()
            Dim yearNow As String = Date.Now.Year.ToString()
            connector.connect.Open()
            connector.query = "SELECT SUM(amount) AS total_income FROM income 
                                WHERE user_id = " & userID & " AND 
                                MONTH(category_date) = " & monthNow & " 
                                AND YEAR(category_date) = " & yearNow & ";"

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
            MessageBox.Show("Error in database from loading user income.")
        End Try

        ' Return 0 if there is an error
        Return 0
    End Function

    Private Function loadUserExpense()
        Try
            Dim expense As Double = 0
            Dim monthNow As String = Date.Now.Month.ToString()
            Dim yearNow As String = Date.Now.Year.ToString()
            connector.connect.Open()
            connector.query = "SELECT SUM(amount) AS total_expense FROM expense 
                                WHERE user_id = " & userID & " AND 
                                MONTH(category_date) = " & monthNow & " 
                                AND YEAR(category_date) = " & yearNow & ";"

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
            MessageBox.Show("Error in database from loading user expense.")
        End Try

        ' Return 0 if there is an error
        Return 0
    End Function

    Private Function loadUserSavings()
        Try
            Dim savings As Double = 0
            Dim monthNow As String = Date.Now.Month.ToString()
            Dim yearNow As String = Date.Now.Year.ToString()
            connector.connect.Open()
            connector.query = "SELECT SUM(amount) AS total_savings FROM savings 
                                WHERE user_id = " & userID & " AND 
                                MONTH(category_date) = " & monthNow & " 
                                AND YEAR(category_date) = " & yearNow & ";"

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
            MessageBox.Show("Error in database from loading user savings.")
        End Try

        ' Return 0 if there is an error
        Return 0
    End Function

    Private Sub StartingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        curveCorners()
        verifyOTPForm = New VerifyOTPForm(usernameSignUpBox, emailSignUpBox, passwordSignUpBox,
                                               confirmPasswordSignUpBox, usernameTextNotifier,
                                               emailTextNotifier, passwordTextNotifier,
                                               confirmPasswordTextNotifier, signUpButton, mailer)
        makeVOTPFChild()
    End Sub

    Private Sub curveCorners()
        Dim radius As Integer = 50 ' change this value to increase/decrease the curve
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

    Private Sub makeVOTPFChild()
        verifyOTPForm.TopLevel = False
        verifyOTPForm.Parent = Me
        CenterVOTPF()
        verifyOTPForm.BringToFront()
    End Sub

    Private Sub CenterVOTPF()
        Dim x As Integer = ((Me.ClientSize.Width \ 2) - verifyOTPForm.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - verifyOTPForm.Height) \ 2
        verifyOTPForm.Location = New Point(x, y)
    End Sub

    'Remove this before finalization
    Private Sub terminateButton_Click(sender As Object, e As EventArgs) Handles terminateButton.Click
        End
    End Sub

    Private Sub signUpButton_Click(sender As Object, e As EventArgs) Handles signUpButton.Click
        validateUsername()
        validateEmail()
        validatePassword()
        validateConfirmPassword()

        If usernameTextNotifier.Text = "" AndAlso
            emailTextNotifier.Text = "" AndAlso
            passwordTextNotifier.Text = "" AndAlso
            confirmPasswordTextNotifier.Text = "" Then

            mailer.mailMe(emailSignUpBox.Text.Trim())

            verifyOTP()
        Else
            MessageBox.Show("Please correct the highlighted fields before signing up.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub verifyOTP()
        hideSignUpFieldsAndNotifiersAndButton()

        verifyOTPForm.Visible = True
    End Sub

    Private Sub hideSignUpFieldsAndNotifiersAndButton()
        usernameSignUpBox.Visible = False
        emailSignUpBox.Visible = False
        passwordSignUpBox.Visible = False
        confirmPasswordSignUpBox.Visible = False

        usernameTextNotifier.Visible = False
        emailTextNotifier.Visible = False
        passwordTextNotifier.Visible = False
        confirmPasswordTextNotifier.Visible = False

        signUpButton.Visible = False
    End Sub



    Private Sub usernameSignUpBox_TextChanged(sender As Object, e As EventArgs) Handles usernameSignUpBox.TextChanged
        validateUsername()
    End Sub

    Private Sub emailSignUpBox_TextChanged(sender As Object, e As EventArgs) Handles emailSignUpBox.TextChanged
        validateEmail()
    End Sub

    Private Sub passwordSignUpBox_TextChanged(sender As Object, e As EventArgs) Handles passwordSignUpBox.TextChanged
        validatePassword()
    End Sub

    Private Sub confirmPasswordSignUpBox_TextChanged(sender As Object, e As EventArgs) Handles confirmPasswordSignUpBox.TextChanged
        validateConfirmPassword()
    End Sub

    Private Sub validateUsername()
        Dim username As String = usernameSignUpBox.Text.Trim()

        If String.IsNullOrEmpty(username) Then
            showValidationError("Username cannot be empty.", usernameSignUpBox, usernameTextNotifier)
            Exit Sub
        End If

        If Not System.Text.RegularExpressions.Regex.IsMatch(username, "^[a-zA-Z0-9]+$") Then
            usernameSignUpBox.Text = System.Text.RegularExpressions.Regex.Replace(username, "[^a-zA-Z0-9]", "")
            usernameSignUpBox.SelectionStart = usernameSignUpBox.Text.Length
            usernameSignUpBox.SelectionLength = 0
            showValidationError("Username must only contain letters and numbers.", usernameSignUpBox, usernameTextNotifier)
            Exit Sub
        End If

        If Not (System.Text.RegularExpressions.Regex.IsMatch(username, "[a-zA-Z]") AndAlso System.Text.RegularExpressions.Regex.IsMatch(username, "[0-9]")) Then
            showValidationError("Username must include both letters and numbers.", usernameSignUpBox, usernameTextNotifier)
            Exit Sub
        End If

        If username.Length < 6 Then
            showValidationError("Username must be at least 6 characters long.", usernameSignUpBox, usernameTextNotifier)
            Exit Sub
        End If

        If username.Length > 20 Then
            usernameSignUpBox.Text = username.Substring(0, 20)
            usernameSignUpBox.SelectionStart = usernameSignUpBox.Text.Length
            usernameSignUpBox.SelectionLength = 0
        End If

        Try
            Dim userCount = 0
            connector.connect.Open()
            connector.query = "SELECT COUNT(*) AS num_existing_name FROM user WHERE username = '" & username & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader

            While connector.reader.Read
                userCount = Integer.Parse(connector.reader("num_existing_name").ToString())
            End While

            If (userCount > 0) Then
                showValidationError("Username already exists.", usernameSignUpBox, usernameTextNotifier)
                connector.connect.Close()
                Exit Sub
            End If

            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Error in database from username.")
        End Try

        showValidationSuccess(usernameSignUpBox, usernameTextNotifier)
    End Sub

    Private Sub validateEmail()
        Dim email As String = emailSignUpBox.Text.Trim()

        If String.IsNullOrEmpty(email) Then
            showValidationError("Email cannot be empty.", emailSignUpBox, emailTextNotifier)
            Exit Sub
        End If

        If Not System.Text.RegularExpressions.Regex.IsMatch(email, "^[^@\s]+@[^@\s]+\.[^@\s]+$") Then
            showValidationError("Invalid email format.", emailSignUpBox, emailTextNotifier)
            Exit Sub
        End If

        Try
            Dim emailCount = 0
            connector.connect.Open()
            connector.query = "SELECT COUNT(*) AS num_existing_email FROM user WHERE email = '" & email & "';"
            connector.command.Connection = connector.connect
            connector.command.CommandText = connector.query
            connector.reader = connector.command.ExecuteReader

            While connector.reader.Read
                emailCount = Integer.Parse(connector.reader("num_existing_email").ToString())
            End While

            If (emailCount > 0) Then
                showValidationError("Email is already taken.", emailSignUpBox, emailTextNotifier)
                connector.connect.Close()
                Exit Sub
            End If

            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Error in database from email.")
        End Try

        showValidationSuccess(emailSignUpBox, emailTextNotifier)
    End Sub

    Private Sub validatePassword()
        Dim password As String = passwordSignUpBox.Text.Trim()

        If String.IsNullOrEmpty(password) Then
            showValidationError("Password cannot be empty.", passwordSignUpBox, passwordTextNotifier)
            Exit Sub
        End If

        If password.Length < 8 Then
            showValidationError("Password must be at least 8 characters long.", passwordSignUpBox, passwordTextNotifier)
            Exit Sub
        End If

        If Not System.Text.RegularExpressions.Regex.IsMatch(password, "[a-z]") OrElse Not System.Text.RegularExpressions.Regex.IsMatch(password, "[A-Z]") OrElse Not System.Text.RegularExpressions.Regex.IsMatch(password, "[0-9]") Then
            showValidationError("Password must include at least one lowercase letter, one uppercase letter, and one number.", passwordSignUpBox, passwordTextNotifier)
            Exit Sub
        End If

        showValidationSuccess(passwordSignUpBox, passwordTextNotifier)
    End Sub

    Private Sub validateConfirmPassword()
        Dim confirmPassword = confirmPasswordSignUpBox.Text.Trim()

        If String.IsNullOrEmpty(confirmPassword) Then
            showValidationError("Password cannot be empty.", confirmPasswordSignUpBox, confirmPasswordTextNotifier)
            Exit Sub
        End If

        If (Not passwordSignUpBox.Text = confirmPasswordSignUpBox.Text) Then
            showValidationError("Password does not match.", confirmPasswordSignUpBox, confirmPasswordTextNotifier)
            Exit Sub
        End If

        showValidationSuccess(confirmPasswordSignUpBox, confirmPasswordTextNotifier)
    End Sub

    'reusing this methods
    Private Sub showValidationError(message As String, textBox As TextBox, notifier As Label)
        notifier.Text = message
        notifier.ForeColor = Color.Red
        textBox.BackColor = Color.LightPink
    End Sub

    Private Sub showValidationSuccess(textBox As TextBox, notifier As Label)
        notifier.Text = ""
        textBox.BackColor = Color.LightGreen
    End Sub

    'reusing this methods 
    'different params
    Private Sub showValidationError(message As String, textBox As MaskedTextBox, notifier As Label)
        notifier.Text = message
        notifier.ForeColor = Color.Red
        textBox.BackColor = Color.LightPink
    End Sub

    Private Sub showValidationSuccess(textBox As MaskedTextBox, notifier As Label)
        notifier.Text = ""
        textBox.BackColor = Color.LightGreen
    End Sub

    Private Sub usernameLoginBox_TextChanged(sender As Object, e As EventArgs) Handles usernameLoginBox.TextChanged
        If (usernameLoginBox.Text = "") Then
            usernameLoginBox.BackColor = Color.LightPink
        Else
            usernameLoginBox.BackColor = Color.White
        End If
    End Sub

    Private Sub passwordLoginBox_TextChanged(sender As Object, e As EventArgs) Handles passwordLoginBox.TextChanged
        If (passwordLoginBox.Text = "") Then
            passwordLoginBox.BackColor = Color.LightPink
        Else
            passwordLoginBox.BackColor = Color.White
        End If
    End Sub
End Class
