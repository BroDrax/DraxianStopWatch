Public Class Form1
    Private stopwatch As New Stopwatch
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim elapsed As TimeSpan = Me.stopwatch.Elapsed
        Label1.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}",
    Math.Floor(elapsed.TotalHours),
    elapsed.Minutes, elapsed.Seconds,
    elapsed.Milliseconds)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
        Me.stopwatch.Start()
        Button4.Enabled = False
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Stop()
        Me.stopwatch.Stop()
        Button4.Enabled = True
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.stopwatch.Reset()
        Label1.Text = "00:00:00:00"
        ListBox1.Items.Clear()
    End Sub
    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Add(ListBox1.Items.Count + 1 & " " & Label1.Text)
    End Sub

End Class
