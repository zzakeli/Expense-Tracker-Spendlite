Imports System.Drawing.Drawing2D

Public Class WeekForm
    Private dashboard As Dashboard

    Public Sub New(dashboard As Dashboard)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.dashboard = dashboard
    End Sub
    Private Sub WeekForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        curveCorners()

        Dim year As Integer = DateTime.Now.Year
        Dim firstDayOfYear As Date = New Date(year, 1, 1)

        ' Adjust to the first Monday of the year
        Dim currentWeekStart As Date = firstDayOfYear
        While currentWeekStart.DayOfWeek <> DayOfWeek.Monday
            currentWeekStart = currentWeekStart.AddDays(1)
        End While

        ' Fill weeks
        While currentWeekStart.Year = year
            Dim weekEnd As Date = currentWeekStart.AddDays(6)
            If weekEnd.Year > year Then weekEnd = New Date(year, 12, 31)

            weekComboBox.Items.Add($"{currentWeekStart:MM/dd} - {weekEnd:MM/dd}")
            currentWeekStart = currentWeekStart.AddDays(7)
        End While

        weekComboBox.SelectedIndex = 0
        roundControlCorners(selectWeekLabelPanel, 15)
        roundControlCorners(weekComboBox, 15)
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

    'Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
    '    Me.Visible = False
    'End Sub

    Private Sub okayButton_Click(sender As Object, e As EventArgs) Handles okayButton.Click
        dashboard.prepareQueryThenRefresh()
        Me.Visible = False
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