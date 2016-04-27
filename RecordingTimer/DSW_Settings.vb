Public Class DSW_Settings

    Private Sub Opacity_Slider_Scroll(sender As Object, e As EventArgs) Handles Opacity_Slider.Scroll
        DSW.Opacity = (Opacity_Slider.Value / 100)
        Opacity_Label.Text = Opacity_Slider.Value
    End Sub

    Private Sub DSW_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = DSW.Location
        Opacity_Label.Text = Opacity_Slider.Value
        If GlobalVariables.ShowOverlay = False Then
            CheckBox_OverlayLock.Enabled = False
            Overlay_Opacity_Slider.Enabled = False
            Overlay_Opacity_Label.Enabled = False
            Overlay_Opacity.Enabled = False
            Button_Overlay.Text = "Enable Overlay"
        ElseIf GlobalVariables.ShowOverlay Then
            Button_Overlay.Text = "Disable Overlay"
            CheckBox_OverlayLock.Enabled = True
            Overlay_Opacity_Slider.Enabled = True
            Overlay_Opacity_Label.Enabled = True
            Overlay_Opacity.Enabled = True
            If GlobalVariables.OverlayLock Then
                CheckBox_OverlayLock.Checked = True
            End If
        End If
        If GlobalVariables.HotkeyIsEnabled Then
            Button_ShowHotkeys.Enabled = True
            Button_EnableHotkeys.Text = "Disable Hotkeys"
        ElseIf GlobalVariables.HotkeyIsEnabled = False Then
            Button_ShowHotkeys.Enabled = False
            Button_EnableHotkeys.Text = "Enable Hotkeys"
        End If
    End Sub

    Private Sub Button_Overlay_Click(sender As Object, e As EventArgs) Handles Button_Overlay.Click
        If ShowOverlay Then
            Overlay.Close()
            ShowOverlay = False
            CheckBox_OverlayLock.CheckState = False
            CheckBox_OverlayLock.Enabled = False
            Overlay_Opacity_Slider.Enabled = False
            Overlay_Opacity_Label.Enabled = False
            Overlay_Opacity.Enabled = False
            Button_Overlay.Text = "Enable Overlay"
        ElseIf ShowOverlay = False Then
            Overlay.Show()
            ShowOverlay = True
            CheckBox_OverlayLock.Enabled = True
            Overlay_Opacity_Slider.Enabled = True
            Overlay_Opacity_Label.Enabled = True
            Overlay_Opacity.Enabled = True
            Button_Overlay.Text = "Disable Overlay"
        End If
    End Sub
    Private Sub CheckBox_OverlayLock_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_OverlayLock.CheckedChanged
        If CheckBox_OverlayLock.Checked Then
            Overlay.ControlBox = False
            GlobalVariables.OverlayLock = True
        ElseIf CheckBox_OverlayLock.Checked = False Then
            Overlay.ControlBox = True
            GlobalVariables.OverlayLock = False
        End If
    End Sub

    Private Sub Overlay_Opacity_Slider_Scroll(sender As Object, e As EventArgs) Handles Overlay_Opacity_Slider.Scroll
        Overlay.Opacity = (Overlay_Opacity_Slider.Value / 100)
        Overlay_Opacity_Label.Text = Overlay_Opacity_Slider.Value
    End Sub

    Private Sub Button_EnableHotkeys_Click(sender As Object, e As EventArgs) Handles Button_EnableHotkeys.Click
        If GlobalVariables.HotkeyIsEnabled Then
            GlobalVariables.HotkeyIsEnabled = False
            Button_ShowHotkeys.Enabled = False
            Button_EnableHotkeys.Text = "Enable Hotkeys"
        Else
            GlobalVariables.HotkeyIsEnabled = True
            Button_ShowHotkeys.Enabled = True
            Button_EnableHotkeys.Text = "Disable Hotkeys"
        End If
    End Sub

    Private Sub Button_ShowHotkeys_Click(sender As Object, e As EventArgs) Handles Button_ShowHotkeys.Click
        Hotkeys_Window.Show()
    End Sub
End Class