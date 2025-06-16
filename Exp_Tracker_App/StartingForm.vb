Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient
Imports OxyPlot
Imports OxyPlot.Legends
Imports OxyPlot.Series
Imports OxyPlot.WindowsForms

Public Class StartingForm
    Private connector As New DatabaseConnector

    Private userID As Integer
    Private plotView As PlotView
    Private mailer As New Mail
    Private verifyOTPForm As VerifyOTPForm
    Private targetX As Integer = 0
    Private forgotPasswordForm As ForgotPasswordForm
    Private forgotPasswordOTPForm As ForgotPasswordOTPForm
    Private passwordResetForm As PasswordResetForm
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
        usernameSignUpBoxPanel.Visible = False

        emailSignUpBox.Visible = False
        emailSignUpBoxPanel.Visible = False

        passwordSignUpBox.Visible = False
        passwordSignUpBoxPanel.Visible = False

        confirmPasswordSignUpBox.Visible = False
        confirmPasswordSignUpBoxPanel.Visible = False
        signUpButton.Visible = False

        usernameTextNotifier.Visible = False
        emailTextNotifier.Visible = False
        passwordTextNotifier.Visible = False
        confirmPasswordTextNotifier.Visible = False

        usernameTextNotifier.Text = ""
        emailTextNotifier.Text = ""
        passwordTextNotifier.Text = ""
        confirmPasswordTextNotifier.Text = ""

        usernameSignUpBox.Text = ""
        emailSignUpBox.Text = ""
        passwordSignUpBox.Text = ""
        confirmPasswordSignUpBox.Text = ""

        disappearingPassSignUpLabel.Visible = True
        disappearingConfirmPassSignUpLabel.Visible = True

        usernameSignUpBox.BackColor = Color.White
        emailSignUpBox.BackColor = Color.White
        passwordSignUpBox.BackColor = Color.White
        confirmPasswordSignUpBox.BackColor = Color.White

        usernameSignUpBoxPanel.BackColor = Color.White
        emailSignUpBoxPanel.BackColor = Color.White
        passwordSignUpBoxPanel.BackColor = Color.White
        confirmPasswordSignUpBoxPanel.BackColor = Color.White

        usernameLoginBox.Visible = True
        passwordLoginBox.Visible = True

        usernameLogInBoxPanel.Visible = True
        passwordLogInBoxPanel.Visible = True

        forgotPassword.Visible = True
        loginButton.Visible = True

        exitButton.BackColor = Color.Transparent
    End Sub
    Private Sub switchToSignUpButton_Click(sender As Object, e As EventArgs) Handles switchToSignUpButton.Click
        targetX = 435
        Timer1.Start()
        switchToLoginButton.Visible = True
        switchToSignUpButton.Visible = False
        switchLabel.Text = "Already have an account?"

        usernameSignUpBox.Visible = True
        usernameSignUpBoxPanel.Visible = True

        emailSignUpBox.Visible = True
        emailSignUpBoxPanel.Visible = True

        passwordSignUpBox.Visible = True
        passwordSignUpBoxPanel.Visible = True

        confirmPasswordSignUpBox.Visible = True
        confirmPasswordSignUpBoxPanel.Visible = True

        signUpButton.Visible = True

        usernameTextNotifier.Visible = True
        emailTextNotifier.Visible = True
        passwordTextNotifier.Visible = True
        confirmPasswordTextNotifier.Visible = True

        usernameTextNotifier.Text = ""
        emailTextNotifier.Text = ""
        passwordTextNotifier.Text = ""
        confirmPasswordTextNotifier.Text = ""

        usernameLoginBox.Visible = False
        passwordLoginBox.Visible = False

        usernameLoginBox.Text = ""
        passwordLoginBox.Text = ""

        usernameLoginBox.BackColor = Color.White
        passwordLoginBox.BackColor = Color.White

        usernameLogInBoxPanel.BackColor = Color.White
        passwordLogInBoxPanel.BackColor = Color.White

        usernameLogInBoxPanel.Visible = False
        passwordLogInBoxPanel.Visible = False

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
                exitButton.BackColor = Color.FromArgb(54, 116, 181)
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
                usernameLogInBoxPanel.BackColor = Color.LightPink
                MessageBox.Show("Please fill out the username field.")
                Exit Sub
            End If
            If (password = "") Then
                passwordLoginBox.BackColor = Color.LightPink
                passwordLogInBoxPanel.BackColor = Color.LightPink
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
        dashboard.usernameLabel.Text = ""
        dashboard.usernameLabel.Location = New Point(1172, 33)
        dashboard.UpdateLabelAlignLeft(dashboard.usernameLabel, username)
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
        dashboard.chartContainer.Controls.Clear()
        dashboard.chartContainer.Controls.Add(plotView)

        ' Create a PlotModel
        Dim plotModel As New PlotModel With {
            .Title = "Financial Breakdown",
            .TitleFont = "Roboto Condensed",
            .TitleFontSize = 26,
            .TitleColor = OxyColors.SteelBlue
        }

        'Dim legend As New Legend() With {
        '    .LegendPosition = LegendPosition.RightTop,
        '    .LegendOrientation = LegendOrientation.Vertical,
        '    .LegendBorderThickness = 0,
        '    .FontSize = 12
        '}

        'plotModel.Legends.Add(legend)

        'Dim pieSeries As New PieSeries() With {
        '    .Diameter = 0.6,
        '    .StrokeThickness = 1.0,
        '    .InsideLabelFormat = Nothing,
        '    .OutsideLabelFormat = Nothing,
        '    .LegendFormat = "{1}" ' This tells OxyPlot to use the slice label in the legend
        '}


        'Create PieSeries and add slices
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
            connector.query = "SELECT CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS category_name, 
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

    Private Sub loadUserIncomeList()
        Try
            Dim monthNow As String = Date.Now.Month.ToString()
            Dim yearNow As String = Date.Now.Year.ToString()
            Dim dataTable As New DataTable
            connector.connect.Open()
            connector.query = "SELECT DISTINCT CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS category_name FROM category 
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
            connector.query = "SELECT DISTINCT CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS category_name FROM category 
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
            connector.query = "SELECT DISTINCT CONCAT(UCASE(LEFT(category.category_name, 1)), LCASE(SUBSTRING(category.category_name, 2))) AS category_name FROM category 
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
        dashboard.netBalanceValue.Text = "P " & userNetBalance.ToString("F2")
        dashboard.incomeValue.Text = "P " & userIncome.ToString("F2")
        dashboard.expenseValue.Text = "P " & userExpense.ToString("F2")
        dashboard.savingsValue.Text = "P " & userSavings.ToString("F2")

        CenterLabelInPanel(dashboard.netBalanceValue, dashboard.netBalanceValueContainer)
        CenterLabelInPanel(dashboard.incomeValue, dashboard.incomeValueContainer)
        CenterLabelInPanel(dashboard.expenseValue, dashboard.expenseValueContainer)
        CenterLabelInPanel(dashboard.savingsValue, dashboard.savingsValueContainer)
    End Sub

    Private Sub CenterLabelInPanel(label As Label, panel As Panel)
        label.Left = (panel.Width - label.Width) / 2
        label.Top = (panel.Height - label.Height) / 2
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
        roundControlCorners(usernameSignUpBoxPanel, 12)
        roundControlCorners(emailSignUpBoxPanel, 12)
        roundControlCorners(passwordSignUpBoxPanel, 12)
        roundControlCorners(confirmPasswordSignUpBoxPanel, 12)
        roundControlCorners(usernameLogInBoxPanel, 12)
        roundControlCorners(passwordLogInBoxPanel, 12)
        roundControlCorners(signUpButton, 40)
        roundControlCorners(loginButton, 40)
        roundControlCorners(switchToSignUpButton, 40)
        roundControlCorners(switchToLoginButton, 40)
        verifyOTPForm = New VerifyOTPForm(usernameSignUpBox, emailSignUpBox, passwordSignUpBox,
                                               confirmPasswordSignUpBox, usernameTextNotifier,
                                               emailTextNotifier, passwordTextNotifier,
                                               confirmPasswordTextNotifier, signUpButton, mailer,
                                               usernameSignUpBoxPanel, emailSignUpBoxPanel,
                                               passwordSignUpBoxPanel, confirmPasswordSignUpBoxPanel, switchToLoginButton)
        passwordResetForm = New PasswordResetForm
        forgotPasswordOTPForm = New ForgotPasswordOTPForm(mailer, passwordResetForm)
        forgotPasswordForm = New ForgotPasswordForm(forgotPasswordOTPForm, mailer)
        makeVOTPFChild()
        makeFPFChild()
        makeFPOTPFChild()
        makePRFChild()
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

    Private Sub makeFPOTPFChild()
        forgotPasswordOTPForm.TopLevel = False
        forgotPasswordOTPForm.Parent = Me
        CenterFPOTPF()
        forgotPasswordOTPForm.BringToFront()
    End Sub

    Private Sub CenterFPOTPF()
        Dim x As Integer = ((Me.ClientSize.Width) - forgotPasswordOTPForm.Width)
        Dim y As Integer = (Me.ClientSize.Height - forgotPasswordOTPForm.Height) \ 2
        forgotPasswordOTPForm.Location = New Point(x - 60, y)
    End Sub

    Private Sub makeFPFChild()
        forgotPasswordForm.TopLevel = False
        forgotPasswordForm.Parent = Me
        CenterFPF()
        forgotPasswordForm.BringToFront()
    End Sub

    Private Sub CenterFPF()
        Dim x As Integer = ((Me.ClientSize.Width) - forgotPasswordForm.Width)
        Dim y As Integer = (Me.ClientSize.Height - forgotPasswordForm.Height) \ 2
        forgotPasswordForm.Location = New Point(x - 60, y)
    End Sub

    Private Sub makePRFChild()
        passwordResetForm.TopLevel = False
        passwordResetForm.Parent = Me
        CenterPRF()
        passwordResetForm.BringToFront()
    End Sub

    Private Sub CenterPRF()
        Dim x As Integer = ((Me.ClientSize.Width) - passwordResetForm.Width)
        Dim y As Integer = (Me.ClientSize.Height - passwordResetForm.Height) \ 2
        passwordResetForm.Location = New Point(x - 60, y)
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

            switchToLoginButton.Enabled = False

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
        usernameSignUpBoxPanel.Visible = False

        emailSignUpBox.Visible = False
        emailSignUpBoxPanel.Visible = False

        passwordSignUpBox.Visible = False
        passwordSignUpBoxPanel.Visible = False

        confirmPasswordSignUpBox.Visible = False
        confirmPasswordSignUpBoxPanel.Visible = False

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
            showValidationError("Username cannot be empty.", usernameSignUpBox, usernameTextNotifier, usernameSignUpBoxPanel)
            Exit Sub
        End If

        If Not System.Text.RegularExpressions.Regex.IsMatch(username, "^[a-zA-Z0-9]+$") Then
            usernameSignUpBox.Text = System.Text.RegularExpressions.Regex.Replace(username, "[^a-zA-Z0-9]", "")
            usernameSignUpBox.SelectionStart = usernameSignUpBox.Text.Length
            usernameSignUpBox.SelectionLength = 0
            showValidationError("Username must only contain letters and numbers.", usernameSignUpBox, usernameTextNotifier, usernameSignUpBoxPanel)
            Exit Sub
        End If

        If Not (System.Text.RegularExpressions.Regex.IsMatch(username, "[a-zA-Z]") AndAlso System.Text.RegularExpressions.Regex.IsMatch(username, "[0-9]")) Then
            showValidationError("Username must include both letters and numbers.", usernameSignUpBox, usernameTextNotifier, usernameSignUpBoxPanel)
            Exit Sub
        End If

        If username.Length < 6 Then
            showValidationError("Username must be at least 6 characters long.", usernameSignUpBox, usernameTextNotifier, usernameSignUpBoxPanel)
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
                showValidationError("Username already exists.", usernameSignUpBox, usernameTextNotifier, usernameSignUpBoxPanel)
                connector.connect.Close()
                Exit Sub
            End If

            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Error in database from username.")
        End Try

        showValidationSuccess(usernameSignUpBox, usernameTextNotifier, usernameSignUpBoxPanel)
    End Sub

    Private Sub validateEmail()
        Dim email As String = emailSignUpBox.Text.Trim()

        If String.IsNullOrEmpty(email) Then
            showValidationError("Email cannot be empty.", emailSignUpBox, emailTextNotifier, emailSignUpBoxPanel)
            Exit Sub
        End If

        If Not System.Text.RegularExpressions.Regex.IsMatch(email, "^[^@\s]+@[^@\s]+\.[^@\s]+$") Then
            showValidationError("Invalid email format.", emailSignUpBox, emailTextNotifier, emailSignUpBoxPanel)
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
                showValidationError("Email is already taken.", emailSignUpBox, emailTextNotifier, emailSignUpBoxPanel)
                connector.connect.Close()
                Exit Sub
            End If

            connector.connect.Close()
        Catch ex As MySqlException
            connector.connect.Close()
            MessageBox.Show("Error in database from email.")
        End Try

        showValidationSuccess(emailSignUpBox, emailTextNotifier, emailSignUpBoxPanel)
    End Sub

    Private Sub validatePassword()
        Dim password As String = passwordSignUpBox.Text

        If String.IsNullOrEmpty(password) Then
            showValidationError("Password cannot be empty.", passwordSignUpBox, passwordTextNotifier, passwordSignUpBoxPanel)
            Exit Sub
        End If

        If password.Length < 8 Then
            showValidationError("Password must be at least 8 characters long.", passwordSignUpBox, passwordTextNotifier, passwordSignUpBoxPanel)
            Exit Sub
        End If

        If Not System.Text.RegularExpressions.Regex.IsMatch(password, "[a-z]") OrElse Not System.Text.RegularExpressions.Regex.IsMatch(password, "[A-Z]") OrElse Not System.Text.RegularExpressions.Regex.IsMatch(password, "[0-9]") Then
            showValidationError("Include 1 lowercase, uppercase letter, and 1 number.", passwordSignUpBox, passwordTextNotifier, passwordSignUpBoxPanel)
            Exit Sub
        End If

        showValidationSuccess(passwordSignUpBox, passwordTextNotifier, passwordSignUpBoxPanel)
    End Sub

    Private Sub validateConfirmPassword()
        Dim confirmPassword = confirmPasswordSignUpBox.Text

        If String.IsNullOrEmpty(confirmPassword) Then
            showValidationError("Password cannot be empty.", confirmPasswordSignUpBox, confirmPasswordTextNotifier, confirmPasswordSignUpBoxPanel)
            Exit Sub
        End If

        If (Not passwordSignUpBox.Text = confirmPasswordSignUpBox.Text) Then
            showValidationError("Password does not match.", confirmPasswordSignUpBox, confirmPasswordTextNotifier, confirmPasswordSignUpBoxPanel)
            Exit Sub
        End If

        showValidationSuccess(confirmPasswordSignUpBox, confirmPasswordTextNotifier, confirmPasswordSignUpBoxPanel)
    End Sub

    'reusing this methods
    Private Sub showValidationError(message As String, textBox As TextBox, notifier As Label, panel As Panel)
        notifier.Text = message
        notifier.ForeColor = Color.Red
        textBox.BackColor = Color.LightPink
        panel.BackColor = Color.LightPink
    End Sub

    Private Sub showValidationSuccess(textBox As TextBox, notifier As Label, panel As Panel)
        notifier.Text = ""
        textBox.BackColor = Color.LightGreen
        panel.BackColor = Color.LightGreen
    End Sub

    'reusing this methods 
    'different params
    Private Sub showValidationError(message As String, textBox As MaskedTextBox, notifier As Label, panel As Panel)
        notifier.Text = message
        notifier.ForeColor = Color.Red
        textBox.BackColor = Color.LightPink
        panel.BackColor = Color.LightPink
    End Sub

    Private Sub showValidationSuccess(textBox As MaskedTextBox, notifier As Label, panel As Panel)
        notifier.Text = ""
        textBox.BackColor = Color.LightGreen
        panel.BackColor = Color.LightGreen
    End Sub

    Private Sub usernameLoginBox_TextChanged(sender As Object, e As EventArgs) Handles usernameLoginBox.TextChanged
        If usernameLoginBox.Text = "" Then
            usernameLoginBox.BackColor = Color.LightPink
            usernameLogInBoxPanel.BackColor = Color.LightPink
        Else
            usernameLoginBox.BackColor = Color.White
            usernameLogInBoxPanel.BackColor = Color.White
        End If
    End Sub

    Private Sub passwordLoginBox_TextChanged(sender As Object, e As EventArgs) Handles passwordLoginBox.TextChanged
        If (passwordLoginBox.Text = "") Then
            passwordLoginBox.BackColor = Color.LightPink
            passwordLogInBoxPanel.BackColor = Color.LightPink
        Else
            passwordLoginBox.BackColor = Color.White
            passwordLogInBoxPanel.BackColor = Color.White
        End If
    End Sub

    Private Sub disappearingPassSignUpLabel_Click(sender As Object, e As EventArgs) Handles disappearingPassSignUpLabel.Click
        disappearingPassSignUpLabel.Visible = False
        passwordSignUpBox.Focus()
    End Sub

    Private Sub passwordSignUpBox_Enter(sender As Object, e As EventArgs) Handles passwordSignUpBox.Enter
        disappearingPassSignUpLabel.Visible = False
    End Sub

    Private Sub passwordSignUpBox_Leave(sender As Object, e As EventArgs) Handles passwordSignUpBox.Leave
        If String.IsNullOrWhiteSpace(passwordSignUpBox.Text) Then
            disappearingPassSignUpLabel.Visible = True
        End If
    End Sub

    Private Sub disappearingConfirmPassLabel_Click(sender As Object, e As EventArgs) Handles disappearingConfirmPassSignUpLabel.Click
        disappearingConfirmPassSignUpLabel.Visible = False
        confirmPasswordSignUpBox.Focus()
    End Sub

    Private Sub confirmPasswordSignUpBox_Enter(sender As Object, e As EventArgs) Handles confirmPasswordSignUpBox.Enter
        disappearingConfirmPassSignUpLabel.Visible = False
    End Sub

    Private Sub confirmPasswordSignUpBox_Leave(sender As Object, e As EventArgs) Handles confirmPasswordSignUpBox.Leave
        If String.IsNullOrWhiteSpace(confirmPasswordSignUpBox.Text) Then
            disappearingConfirmPassSignUpLabel.Visible = True
        End If
    End Sub

    Private Sub disappearingPassLogInLabel_Click(sender As Object, e As EventArgs) Handles disappearingPassLogInLabel.Click
        disappearingPassLogInLabel.Visible = False
        passwordLoginBox.Focus()
    End Sub

    Private Sub passwordLoginBox_Enter(sender As Object, e As EventArgs) Handles passwordLoginBox.Enter
        disappearingPassLogInLabel.Visible = False
    End Sub

    Private Sub passwordLoginBox_Leave(sender As Object, e As EventArgs) Handles passwordLoginBox.Leave
        If String.IsNullOrWhiteSpace(passwordLoginBox.Text) Then
            disappearingPassLogInLabel.Visible = True
        End If
    End Sub

    Private Sub forgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles forgotPassword.LinkClicked
        forgotPasswordForm.Visible = True
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        End
    End Sub
End Class
