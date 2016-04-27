<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DSW_Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DSW_Settings))
        Me.Opacity_Slider = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Opacity_Label = New System.Windows.Forms.Label()
        Me.Button_Overlay = New System.Windows.Forms.Button()
        Me.CheckBox_OverlayLock = New System.Windows.Forms.CheckBox()
        Me.Overlay_Opacity_Label = New System.Windows.Forms.Label()
        Me.Overlay_Opacity = New System.Windows.Forms.Label()
        Me.Overlay_Opacity_Slider = New System.Windows.Forms.TrackBar()
        Me.Button_EnableHotkeys = New System.Windows.Forms.Button()
        Me.Button_ShowHotkeys = New System.Windows.Forms.Button()
        CType(Me.Opacity_Slider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Overlay_Opacity_Slider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Opacity_Slider
        '
        Me.Opacity_Slider.BackColor = System.Drawing.Color.Black
        Me.Opacity_Slider.LargeChange = 20
        Me.Opacity_Slider.Location = New System.Drawing.Point(233, 75)
        Me.Opacity_Slider.Maximum = 100
        Me.Opacity_Slider.Name = "Opacity_Slider"
        Me.Opacity_Slider.Size = New System.Drawing.Size(142, 45)
        Me.Opacity_Slider.TabIndex = 0
        Me.Opacity_Slider.TickFrequency = 10
        Me.Opacity_Slider.Value = 100
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Opacity"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 37)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Settings"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Opacity_Label
        '
        Me.Opacity_Label.AutoSize = True
        Me.Opacity_Label.BackColor = System.Drawing.Color.Transparent
        Me.Opacity_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opacity_Label.Location = New System.Drawing.Point(177, 80)
        Me.Opacity_Label.Name = "Opacity_Label"
        Me.Opacity_Label.Size = New System.Drawing.Size(50, 20)
        Me.Opacity_Label.TabIndex = 3
        Me.Opacity_Label.Text = "100%"
        '
        'Button_Overlay
        '
        Me.Button_Overlay.BackColor = System.Drawing.Color.Black
        Me.Button_Overlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Overlay.ForeColor = System.Drawing.Color.Lime
        Me.Button_Overlay.Location = New System.Drawing.Point(111, 197)
        Me.Button_Overlay.Name = "Button_Overlay"
        Me.Button_Overlay.Size = New System.Drawing.Size(174, 45)
        Me.Button_Overlay.TabIndex = 12
        Me.Button_Overlay.Text = "Enable Overlay"
        Me.Button_Overlay.UseVisualStyleBackColor = False
        '
        'CheckBox_OverlayLock
        '
        Me.CheckBox_OverlayLock.AutoSize = True
        Me.CheckBox_OverlayLock.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_OverlayLock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_OverlayLock.ForeColor = System.Drawing.Color.Lime
        Me.CheckBox_OverlayLock.Location = New System.Drawing.Point(17, 258)
        Me.CheckBox_OverlayLock.Name = "CheckBox_OverlayLock"
        Me.CheckBox_OverlayLock.Size = New System.Drawing.Size(118, 24)
        Me.CheckBox_OverlayLock.TabIndex = 14
        Me.CheckBox_OverlayLock.Text = "Lock Overlay"
        Me.CheckBox_OverlayLock.UseVisualStyleBackColor = False
        '
        'Overlay_Opacity_Label
        '
        Me.Overlay_Opacity_Label.AutoSize = True
        Me.Overlay_Opacity_Label.BackColor = System.Drawing.Color.Transparent
        Me.Overlay_Opacity_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Overlay_Opacity_Label.Location = New System.Drawing.Point(177, 298)
        Me.Overlay_Opacity_Label.Name = "Overlay_Opacity_Label"
        Me.Overlay_Opacity_Label.Size = New System.Drawing.Size(50, 20)
        Me.Overlay_Opacity_Label.TabIndex = 17
        Me.Overlay_Opacity_Label.Text = "100%"
        '
        'Overlay_Opacity
        '
        Me.Overlay_Opacity.AutoSize = True
        Me.Overlay_Opacity.BackColor = System.Drawing.Color.Transparent
        Me.Overlay_Opacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Overlay_Opacity.Location = New System.Drawing.Point(12, 293)
        Me.Overlay_Opacity.Name = "Overlay_Opacity"
        Me.Overlay_Opacity.Size = New System.Drawing.Size(85, 25)
        Me.Overlay_Opacity.TabIndex = 16
        Me.Overlay_Opacity.Text = "Opacity"
        '
        'Overlay_Opacity_Slider
        '
        Me.Overlay_Opacity_Slider.BackColor = System.Drawing.Color.Black
        Me.Overlay_Opacity_Slider.LargeChange = 20
        Me.Overlay_Opacity_Slider.Location = New System.Drawing.Point(233, 293)
        Me.Overlay_Opacity_Slider.Maximum = 100
        Me.Overlay_Opacity_Slider.Name = "Overlay_Opacity_Slider"
        Me.Overlay_Opacity_Slider.Size = New System.Drawing.Size(142, 45)
        Me.Overlay_Opacity_Slider.TabIndex = 15
        Me.Overlay_Opacity_Slider.TickFrequency = 10
        Me.Overlay_Opacity_Slider.Value = 100
        '
        'Button_EnableHotkeys
        '
        Me.Button_EnableHotkeys.BackColor = System.Drawing.Color.Black
        Me.Button_EnableHotkeys.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_EnableHotkeys.ForeColor = System.Drawing.Color.Lime
        Me.Button_EnableHotkeys.Location = New System.Drawing.Point(17, 128)
        Me.Button_EnableHotkeys.Name = "Button_EnableHotkeys"
        Me.Button_EnableHotkeys.Size = New System.Drawing.Size(158, 45)
        Me.Button_EnableHotkeys.TabIndex = 18
        Me.Button_EnableHotkeys.Text = "Disable Hotkeys"
        Me.Button_EnableHotkeys.UseVisualStyleBackColor = False
        '
        'Button_ShowHotkeys
        '
        Me.Button_ShowHotkeys.BackColor = System.Drawing.Color.Black
        Me.Button_ShowHotkeys.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_ShowHotkeys.ForeColor = System.Drawing.Color.Lime
        Me.Button_ShowHotkeys.Location = New System.Drawing.Point(217, 128)
        Me.Button_ShowHotkeys.Name = "Button_ShowHotkeys"
        Me.Button_ShowHotkeys.Size = New System.Drawing.Size(158, 45)
        Me.Button_ShowHotkeys.TabIndex = 19
        Me.Button_ShowHotkeys.Text = "Show Hotkeys"
        Me.Button_ShowHotkeys.UseVisualStyleBackColor = False
        '
        'DSW_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.RecordingTimer.My.Resources.Resources.DSWBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(402, 398)
        Me.Controls.Add(Me.Button_ShowHotkeys)
        Me.Controls.Add(Me.Button_EnableHotkeys)
        Me.Controls.Add(Me.Overlay_Opacity_Label)
        Me.Controls.Add(Me.Overlay_Opacity)
        Me.Controls.Add(Me.Overlay_Opacity_Slider)
        Me.Controls.Add(Me.CheckBox_OverlayLock)
        Me.Controls.Add(Me.Button_Overlay)
        Me.Controls.Add(Me.Opacity_Label)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Opacity_Slider)
        Me.ForeColor = System.Drawing.Color.Lime
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DSW_Settings"
        Me.Text = "DSW_Settings"
        CType(Me.Opacity_Slider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Overlay_Opacity_Slider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Opacity_Slider As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Opacity_Label As Label
    Friend WithEvents Button_Overlay As Button
    Friend WithEvents CheckBox_OverlayLock As CheckBox
    Friend WithEvents Overlay_Opacity_Label As Label
    Friend WithEvents Overlay_Opacity As Label
    Friend WithEvents Overlay_Opacity_Slider As TrackBar
    Friend WithEvents Button_EnableHotkeys As Button
    Friend WithEvents Button_ShowHotkeys As Button
End Class
