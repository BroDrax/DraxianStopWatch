<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Hotkeys_Window
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hotkeys_Window))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.List_Start = New System.Windows.Forms.ComboBox()
        Me.List_Stop = New System.Windows.Forms.ComboBox()
        Me.List_Reset = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(40, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Stop:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(39, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Start:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(69, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 34)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(37, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 39)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Hotkeys"
        '
        'List_Start
        '
        Me.List_Start.BackColor = System.Drawing.Color.Black
        Me.List_Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List_Start.ForeColor = System.Drawing.Color.Lime
        Me.List_Start.FormattingEnabled = True
        Me.List_Start.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F11", "F12", "-", "=", "\", "[", "]", ";", "'", ",", ".", "/", "`", "Delete", "Backspace", "Tab", "Enter", "Shift", "Control", "Caps Lock", "Esc", "Spacebar", "Page Up", "Page Down", "End", "Home", "Up", "Down", "Left", "Right", "NUM 0", "NUM 1", "NUM 2", "NUM 3", "NUM 4", "NUM 5", "NUM 6", "NUM 7", "NUM 8", "NUM 9", "NUM /", "NUM *", "NUM -", "NUM +", "NUM ."})
        Me.List_Start.Location = New System.Drawing.Point(99, 75)
        Me.List_Start.Name = "List_Start"
        Me.List_Start.Size = New System.Drawing.Size(70, 32)
        Me.List_Start.TabIndex = 10
        '
        'List_Stop
        '
        Me.List_Stop.BackColor = System.Drawing.Color.Black
        Me.List_Stop.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List_Stop.ForeColor = System.Drawing.Color.Lime
        Me.List_Stop.FormattingEnabled = True
        Me.List_Stop.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F11", "F12", "-", "=", "\", "[", "]", ";", "'", ",", ".", "/", "`", "Delete", "Backspace", "Tab", "Enter", "Shift", "Control", "Caps Lock", "Esc", "Spacebar", "Page Up", "Page Down", "End", "Home", "Up", "Down", "Left", "Right", "NUM 0", "NUM 1", "NUM 2", "NUM 3", "NUM 4", "NUM 5", "NUM 6", "NUM 7", "NUM 8", "NUM 9", "NUM /", "NUM *", "NUM -", "NUM +", "NUM ."})
        Me.List_Stop.Location = New System.Drawing.Point(99, 113)
        Me.List_Stop.Name = "List_Stop"
        Me.List_Stop.Size = New System.Drawing.Size(70, 32)
        Me.List_Stop.TabIndex = 11
        '
        'List_Reset
        '
        Me.List_Reset.BackColor = System.Drawing.Color.Black
        Me.List_Reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List_Reset.ForeColor = System.Drawing.Color.Lime
        Me.List_Reset.FormattingEnabled = True
        Me.List_Reset.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F11", "F12", "-", "=", "\", "[", "]", ";", "'", ",", ".", "/", "`", "Delete", "Backspace", "Tab", "Enter", "Shift", "Control", "Caps Lock", "Esc", "Spacebar", "Page Up", "Page Down", "End", "Home", "Up", "Down", "Left", "Right", "NUM 0", "NUM 1", "NUM 2", "NUM 3", "NUM 4", "NUM 5", "NUM 6", "NUM 7", "NUM 8", "NUM 9", "NUM /", "NUM *", "NUM -", "NUM +", "NUM ."})
        Me.List_Reset.Location = New System.Drawing.Point(99, 151)
        Me.List_Reset.Name = "List_Reset"
        Me.List_Reset.Size = New System.Drawing.Size(70, 32)
        Me.List_Reset.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(28, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Reset:"
        '
        'Hotkeys_Window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.RecordingTimer.My.Resources.Resources.DSWBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(230, 261)
        Me.Controls.Add(Me.List_Reset)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.List_Stop)
        Me.Controls.Add(Me.List_Start)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.ForeColor = System.Drawing.Color.Lime
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Hotkeys_Window"
        Me.Text = "Hotkeys_Window"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents List_Start As ComboBox
    Friend WithEvents List_Stop As ComboBox
    Friend WithEvents List_Reset As ComboBox
    Friend WithEvents Label1 As Label
End Class
