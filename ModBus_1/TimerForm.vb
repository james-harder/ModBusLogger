Public Class TimerForm

    'Event that is called by timer
    Private Sub OnIntervalElapsed()

        Dim intDisplay As Integer
        Integer.TryParse(lblDisplay.Text, intDisplay)

        Dim intInterval As Integer
        Integer.TryParse(txtInterval.Text, intInterval)

        Dim newValue As Integer = intDisplay + intInterval

        lblDisplay.Text = newValue.ToString()

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim btnMe As Button = sender
        If btnMe.Text = "Start Timer" Then

            btnMe.Text = "Stop Timer"
            lblDisplay.Text = txtStart.Text

            tmrTestTimer.Interval = 1000
            tmrTestTimer.Start()

        Else

            btnMe.Text = "Start Timer"

            tmrTestTimer.Stop()

        End If

    End Sub

    Private Sub TimerEventProcessor(sender As Object, e As EventArgs) Handles tmrTestTimer.Tick

        OnIntervalElapsed()

    End Sub
End Class