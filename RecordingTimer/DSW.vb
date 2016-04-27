Public Class DSW
    Private stopwatch As New Stopwatch
    Private Declare Function GetKeyPress Lib "user32" Alias "GetAsyncKeyState" (ByVal key As Integer) As Integer
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Integer) As Short
    Public Episode_Length As Integer
    Public IsStarted As Boolean

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim elapsed As TimeSpan = Me.stopwatch.Elapsed
        Label1.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}",
    Math.Floor(elapsed.TotalHours),
    elapsed.Minutes, elapsed.Seconds,
    elapsed.Milliseconds)
        Overlay.Label1.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}",
    Math.Floor(elapsed.TotalHours),
    elapsed.Minutes, elapsed.Seconds,
    elapsed.Milliseconds)
        If Episode_Length = 0 Then
            Label1.ForeColor = Color.Lime
            Overlay.Label1.ForeColor = Color.Lime
        ElseIf elapsed.Minutes >= Episode_Length And elapsed.Seconds >= 0 Then
            Label1.ForeColor = Color.Red
            Overlay.Label1.ForeColor = Color.Red
        ElseIf Episode_Length = 60 And elapsed.Minutes = 59 And elapsed.Seconds = 59 Then
            Label1.ForeColor = Color.Red
            Overlay.Label1.ForeColor = Color.Red
        Else
            Label1.ForeColor = Color.Lime
            Overlay.Label1.ForeColor = Color.Lime
        End If
    End Sub
    Private Sub Button_Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Start.Click
        Timer1.Start()
        Me.stopwatch.Start()
        IsStarted = True
        Button_Reset.Enabled = False
    End Sub
    Private Sub Button_Stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Stop.Click
        Timer1.Stop()
        Me.stopwatch.Stop()
        IsStarted = False
        Button_Reset.Enabled = True
    End Sub
    Private Sub Button_Reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Reset.Click
        Me.stopwatch.Reset()
        Label1.Text = "00:00:00:000"
        Label1.ForeColor = Color.Lime
        Overlay.Label1.Text = "00:00:00:000"
        Overlay.Label1.ForeColor = Color.Lime
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If GlobalVariables.HotkeyIsEnabled Then
            If GetAsyncKeyState(GlobalVariables.Hotkey_Start) Then
                Button_Start.PerformClick()
            End If
            If GetAsyncKeyState(GlobalVariables.Hotkey_Stop) Then
                Button_Stop.PerformClick()
            End If
            If GetAsyncKeyState(GlobalVariables.Hotkey_Reset) Then
                Button_Reset.PerformClick()
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim Selection As String
        Selection = ComboBox1.Text
        Select Case Selection
            Case "None"
                Episode_Length = 0
            Case "1 Minute"
                Episode_Length = 1
            Case "5 Minutes"
                Episode_Length = 5
            Case "10 Minutes"
                Episode_Length = 10
            Case "15 Minutes"
                Episode_Length = 15
            Case "20 Minutes"
                Episode_Length = 20
            Case "25 Minutes"
                Episode_Length = 25
            Case "30 Minutes"
                Episode_Length = 30
            Case "35 Minutes"
                Episode_Length = 35
            Case "40 Minutes"
                Episode_Length = 40
            Case "45 Minutes"
                Episode_Length = 45
            Case "50 Minutes"
                Episode_Length = 50
            Case "55 Minutes"
                Episode_Length = 55
            Case "1 Hour"
                Episode_Length = 60

        End Select
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ComboBox1.Enabled = False
        ElseIf CheckBox1.Checked = False Then
            ComboBox1.Enabled = True
        End If
    End Sub

    Private Sub DSW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 5
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            Me.TopMost = True
        ElseIf CheckBox2.Checked = False Then
            Me.TopMost = False
        End If
    End Sub

    Private Sub Button_Settings_Click(sender As Object, e As EventArgs) Handles Button_Settings.Click
        DSW_Settings.Show()
    End Sub
End Class

Public Module GlobalVariables
    Public ShowOverlay As Boolean = False
    Public OverlayLock As Boolean = False
    Public HotkeyIsEnabled As Boolean = True
    Public Hotkey_Start As Integer = 120
    Public Hotkey_Stop As Integer = 119
    Public Hotkey_Reset As Integer = 118
    Public HotKey_Start_Raw As String = "F9"
    Public Hotkey_Stop_Raw As String = "F8"
    Public Hotkey_Reset_Raw As String = "F7"

End Module
