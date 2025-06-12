Public Class MonthForm
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
    End Sub
End Class