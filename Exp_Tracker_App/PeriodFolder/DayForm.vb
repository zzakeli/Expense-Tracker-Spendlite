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
    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Visible = False
    End Sub

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
End Class