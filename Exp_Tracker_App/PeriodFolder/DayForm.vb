Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class DayForm

    Private connector As New DatabaseConnector

    Private dashboard As Dashboard

    Public Sub New(dashboard As Dashboard)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.dashboard = dashboard
    End Sub
    'Private Sub cancelButton_Click(sender As Object, e As EventArgs)
    '    Visible = False
    'End Sub

    Private Sub okayButton_Click(sender As Object, e As EventArgs) Handles okayButton.Click
        dashboard.prepareQueryThenRefresh()
        Me.Visible = False



        'Dim userID As Integer = dashboard.getUserID()
        'Dim day As String = dayPicker.Text.ToString()

        'Try
        '    connector.connect.Open()
        '    connector.query = "SELECT category.category_name,SUM(net_balance.amount) 
        '                        AS total_amount,MAX(net_balance.category_date) AS latest_date 
        '                        FROM category RIGHT JOIN (SELECT category_id, amount, category_date 
        '                        FROM income WHERE user_id = " & userID & " AND category_date = '" & day & "' 
        '                        UNION ALL SELECT category_id, amount, category_date FROM expense 
        '                        WHERE user_id = " & userID & " AND category_date = '" & day & "' 
        '                        UNION ALL SELECT category_id, amount, category_date FROM savings 
        '                        WHERE user_id = " & userID & " AND category_date = '" & day & "') AS net_balance 
        '                        ON category.category_id = net_balance.category_id 
        '                        GROUP BY category.category_name;"

        '    connector.command.CommandText = connector.query
        '    connector.command.Connection = connector.connect
        '    connector.reader = connector.command.ExecuteReader

        '    While connector.reader.Read

        '    End While
        '    connector.connect.Close()
        'Catch ex As MySqlException
        '    connector.connect.Close()
        'End Try
    End Sub

    Private Sub DayForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        curveCorners()
        roundControlCorners(selectDayLabelPanel, 15)
        roundControlCorners(dayPicker, 15)
        roundControlCorners(okayButton, 40)
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