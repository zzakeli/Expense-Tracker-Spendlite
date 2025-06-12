Public Class WeekForm
    Private dashboard As Dashboard

    Public Sub New(dashboard As Dashboard)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.dashboard = dashboard
    End Sub
    Private Sub WeekForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim year As Integer = DateTime.Now.Year
        Dim firstDayOfYear As Date = New Date(year, 1, 1)

        ' Adjust to the first Monday of the year
        Dim currentWeekStart As Date = firstDayOfYear
        While currentWeekStart.DayOfWeek <> DayOfWeek.Monday
            currentWeekStart = currentWeekStart.AddDays(1)
        End While

        ' Fill weeks
        Dim weekNum As Integer = 1
        While currentWeekStart.Year = year
            Dim weekEnd As Date = currentWeekStart.AddDays(6)
            If weekEnd.Year > year Then weekEnd = New Date(year, 12, 31)

            weekComboBox.Items.Add($"Week {weekNum} - {currentWeekStart:MM/dd} - {weekEnd:MM/dd}")
            currentWeekStart = currentWeekStart.AddDays(7)
            weekNum += 1
        End While

        weekComboBox.SelectedIndex = 0
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Visible = False
    End Sub

    Private Sub okayButton_Click(sender As Object, e As EventArgs) Handles okayButton.Click
        dashboard.prepareQueryThenRefresh()
        Me.Visible = False
    End Sub
End Class