Public Class Hotkeys_Window
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Hotkeys_Window_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = DSW_Settings.Location
        List_Start.Text = GlobalVariables.HotKey_Start_Raw
        List_Stop.Text = GlobalVariables.Hotkey_Stop_Raw
        List_Reset.Text = GlobalVariables.Hotkey_Reset_Raw
    End Sub


    Private Sub List_Start_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List_Start.SelectedIndexChanged
        GlobalVariables.HotKey_Start_Raw = List_Start.Text
        Dim Temp_Hotkey As Integer
        Select Case GlobalVariables.HotKey_Start_Raw
            Case "A"
                Temp_Hotkey = 65
            Case "B"
                Temp_Hotkey = 66
            Case "C"
                Temp_Hotkey = 67
            Case "D"
                Temp_Hotkey = 68
            Case "E"
                Temp_Hotkey = 69
            Case "F"
                Temp_Hotkey = 70
            Case "G"
                Temp_Hotkey = 71
            Case "H"
                Temp_Hotkey = 72
            Case "I"
                Temp_Hotkey = 73
            Case "J"
                Temp_Hotkey = 74
            Case "K"
                Temp_Hotkey = 75
            Case "L"
                Temp_Hotkey = 76
            Case "M"
                Temp_Hotkey = 77
            Case "N"
                Temp_Hotkey = 78
            Case "O"
                Temp_Hotkey = 79
            Case "P"
                Temp_Hotkey = 80
            Case "Q"
                Temp_Hotkey = 81
            Case "R"
                Temp_Hotkey = 82
            Case "S"
                Temp_Hotkey = 83
            Case "T"
                Temp_Hotkey = 84
            Case "U"
                Temp_Hotkey = 85
            Case "V"
                Temp_Hotkey = 86
            Case "W"
                Temp_Hotkey = 87
            Case "X"
                Temp_Hotkey = 88
            Case "Y"
                Temp_Hotkey = 89
            Case "Z"
                Temp_Hotkey = 90
            Case "0"
                Temp_Hotkey = 48
            Case "1"
                Temp_Hotkey = 49
            Case "2"
                Temp_Hotkey = 50
            Case "3"
                Temp_Hotkey = 51
            Case "4"
                Temp_Hotkey = 52
            Case "5"
                Temp_Hotkey = 53
            Case "6"
                Temp_Hotkey = 54
            Case "7"
                Temp_Hotkey = 55
            Case "8"
                Temp_Hotkey = 56
            Case "9"
                Temp_Hotkey = 57
            Case "F1"
                Temp_Hotkey = 112
            Case "F2"
                Temp_Hotkey = 113
            Case "F3"
                Temp_Hotkey = 114
            Case "F4"
                Temp_Hotkey = 115
            Case "F5"
                Temp_Hotkey = 116
            Case "F6"
                Temp_Hotkey = 117
            Case "F7"
                Temp_Hotkey = 118
            Case "F8"
                Temp_Hotkey = 119
            Case "F9"
                Temp_Hotkey = 120
            Case "F11"
                Temp_Hotkey = 122
            Case "F12"
                Temp_Hotkey = 123
            Case "-"
                Temp_Hotkey = 189
            Case "="
                Temp_Hotkey = 187
            Case "\"
                Temp_Hotkey = 220
            Case "["
                Temp_Hotkey = 219
            Case "]"
                Temp_Hotkey = 221
            Case ";"
                Temp_Hotkey = 186
            Case "'"
                Temp_Hotkey = 222
            Case ","
                Temp_Hotkey = 188
            Case "."
                Temp_Hotkey = 190
            Case "/"
                Temp_Hotkey = 191
            Case "Delete"
                Temp_Hotkey = 46
            Case "Backspace"
                Temp_Hotkey = 8
            Case "Tab"
                Temp_Hotkey = 9
            Case "Enter"
                Temp_Hotkey = 13
            Case "Shift"
                Temp_Hotkey = 16
            Case "Control"
                Temp_Hotkey = 17
            Case "Caps Lock"
                Temp_Hotkey = 20
            Case "Esc"
                Temp_Hotkey = 27
            Case "Spacebar"
                Temp_Hotkey = 32
            Case "Page Up"
                Temp_Hotkey = 33
            Case "Page Down"
                Temp_Hotkey = 34
            Case "End"
                Temp_Hotkey = 35
            Case "Home"
                Temp_Hotkey = 36
            Case "Up"
                Temp_Hotkey = 37
            Case "Down"
                Temp_Hotkey = 38
            Case "Left"
                Temp_Hotkey = 39
            Case "Right"
                Temp_Hotkey = 40
            Case "Num 0"
                Temp_Hotkey = 96
            Case "Num 1"
                Temp_Hotkey = 97
            Case "Num 2"
                Temp_Hotkey = 98
            Case "Num 3"
                Temp_Hotkey = 99
            Case "Num 4"
                Temp_Hotkey = 100
            Case "Num 5"
                Temp_Hotkey = 101
            Case "Num 6"
                Temp_Hotkey = 102
            Case "Num 7"
                Temp_Hotkey = 103
            Case "Num 8"
                Temp_Hotkey = 104
            Case "Num 9"
                Temp_Hotkey = 105
            Case "Num /"
                Temp_Hotkey = 111
            Case "Num *"
                Temp_Hotkey = 106
            Case "Num -"
                Temp_Hotkey = 109
            Case "Num +"
                Temp_Hotkey = 107
            Case "Num ."
                Temp_Hotkey = 110

        End Select
        GlobalVariables.Hotkey_Start = Temp_Hotkey

    End Sub

    Private Sub List_Stop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List_Stop.SelectedIndexChanged
        GlobalVariables.Hotkey_Stop_Raw = List_Stop.Text
        Dim Temp_Hotkey As Integer
        Select Case GlobalVariables.Hotkey_Stop_Raw
            Case "A"
                Temp_Hotkey = 65
            Case "B"
                Temp_Hotkey = 66
            Case "C"
                Temp_Hotkey = 67
            Case "D"
                Temp_Hotkey = 68
            Case "E"
                Temp_Hotkey = 69
            Case "F"
                Temp_Hotkey = 70
            Case "G"
                Temp_Hotkey = 71
            Case "H"
                Temp_Hotkey = 72
            Case "I"
                Temp_Hotkey = 73
            Case "J"
                Temp_Hotkey = 74
            Case "K"
                Temp_Hotkey = 75
            Case "L"
                Temp_Hotkey = 76
            Case "M"
                Temp_Hotkey = 77
            Case "N"
                Temp_Hotkey = 78
            Case "O"
                Temp_Hotkey = 79
            Case "P"
                Temp_Hotkey = 80
            Case "Q"
                Temp_Hotkey = 81
            Case "R"
                Temp_Hotkey = 82
            Case "S"
                Temp_Hotkey = 83
            Case "T"
                Temp_Hotkey = 84
            Case "U"
                Temp_Hotkey = 85
            Case "V"
                Temp_Hotkey = 86
            Case "W"
                Temp_Hotkey = 87
            Case "X"
                Temp_Hotkey = 88
            Case "Y"
                Temp_Hotkey = 89
            Case "Z"
                Temp_Hotkey = 90
            Case "0"
                Temp_Hotkey = 48
            Case "1"
                Temp_Hotkey = 49
            Case "2"
                Temp_Hotkey = 50
            Case "3"
                Temp_Hotkey = 51
            Case "4"
                Temp_Hotkey = 52
            Case "5"
                Temp_Hotkey = 53
            Case "6"
                Temp_Hotkey = 54
            Case "7"
                Temp_Hotkey = 55
            Case "8"
                Temp_Hotkey = 56
            Case "9"
                Temp_Hotkey = 57
            Case "F1"
                Temp_Hotkey = 112
            Case "F2"
                Temp_Hotkey = 113
            Case "F3"
                Temp_Hotkey = 114
            Case "F4"
                Temp_Hotkey = 115
            Case "F5"
                Temp_Hotkey = 116
            Case "F6"
                Temp_Hotkey = 117
            Case "F7"
                Temp_Hotkey = 118
            Case "F8"
                Temp_Hotkey = 119
            Case "F9"
                Temp_Hotkey = 120
            Case "F11"
                Temp_Hotkey = 122
            Case "F12"
                Temp_Hotkey = 123
            Case "-"
                Temp_Hotkey = 189
            Case "="
                Temp_Hotkey = 187
            Case "\"
                Temp_Hotkey = 220
            Case "["
                Temp_Hotkey = 219
            Case "]"
                Temp_Hotkey = 221
            Case ";"
                Temp_Hotkey = 186
            Case "'"
                Temp_Hotkey = 222
            Case ","
                Temp_Hotkey = 188
            Case "."
                Temp_Hotkey = 190
            Case "/"
                Temp_Hotkey = 191
            Case "Delete"
                Temp_Hotkey = 46
            Case "Backspace"
                Temp_Hotkey = 8
            Case "Tab"
                Temp_Hotkey = 9
            Case "Enter"
                Temp_Hotkey = 13
            Case "Shift"
                Temp_Hotkey = 16
            Case "Control"
                Temp_Hotkey = 17
            Case "Caps Lock"
                Temp_Hotkey = 20
            Case "Esc"
                Temp_Hotkey = 27
            Case "Spacebar"
                Temp_Hotkey = 32
            Case "Page Up"
                Temp_Hotkey = 33
            Case "Page Down"
                Temp_Hotkey = 34
            Case "End"
                Temp_Hotkey = 35
            Case "Home"
                Temp_Hotkey = 36
            Case "Up"
                Temp_Hotkey = 37
            Case "Down"
                Temp_Hotkey = 38
            Case "Left"
                Temp_Hotkey = 39
            Case "Right"
                Temp_Hotkey = 40
            Case "Num 0"
                Temp_Hotkey = 96
            Case "Num 1"
                Temp_Hotkey = 97
            Case "Num 2"
                Temp_Hotkey = 98
            Case "Num 3"
                Temp_Hotkey = 99
            Case "Num 4"
                Temp_Hotkey = 100
            Case "Num 5"
                Temp_Hotkey = 101
            Case "Num 6"
                Temp_Hotkey = 102
            Case "Num 7"
                Temp_Hotkey = 103
            Case "Num 8"
                Temp_Hotkey = 104
            Case "Num 9"
                Temp_Hotkey = 105
            Case "Num /"
                Temp_Hotkey = 111
            Case "Num *"
                Temp_Hotkey = 106
            Case "Num -"
                Temp_Hotkey = 109
            Case "Num +"
                Temp_Hotkey = 107
            Case "Num ."
                Temp_Hotkey = 110

        End Select
        GlobalVariables.Hotkey_Stop = Temp_Hotkey
    End Sub

    Private Sub List_Reset_SelectedIndexChanged(sender As Object, e As EventArgs) Handles List_Reset.SelectedIndexChanged
        GlobalVariables.Hotkey_Reset_Raw = List_Reset.Text
        Dim Temp_Hotkey As Integer
        Select Case GlobalVariables.Hotkey_Reset_Raw
            Case "A"
                Temp_Hotkey = 65
            Case "B"
                Temp_Hotkey = 66
            Case "C"
                Temp_Hotkey = 67
            Case "D"
                Temp_Hotkey = 68
            Case "E"
                Temp_Hotkey = 69
            Case "F"
                Temp_Hotkey = 70
            Case "G"
                Temp_Hotkey = 71
            Case "H"
                Temp_Hotkey = 72
            Case "I"
                Temp_Hotkey = 73
            Case "J"
                Temp_Hotkey = 74
            Case "K"
                Temp_Hotkey = 75
            Case "L"
                Temp_Hotkey = 76
            Case "M"
                Temp_Hotkey = 77
            Case "N"
                Temp_Hotkey = 78
            Case "O"
                Temp_Hotkey = 79
            Case "P"
                Temp_Hotkey = 80
            Case "Q"
                Temp_Hotkey = 81
            Case "R"
                Temp_Hotkey = 82
            Case "S"
                Temp_Hotkey = 83
            Case "T"
                Temp_Hotkey = 84
            Case "U"
                Temp_Hotkey = 85
            Case "V"
                Temp_Hotkey = 86
            Case "W"
                Temp_Hotkey = 87
            Case "X"
                Temp_Hotkey = 88
            Case "Y"
                Temp_Hotkey = 89
            Case "Z"
                Temp_Hotkey = 90
            Case "0"
                Temp_Hotkey = 48
            Case "1"
                Temp_Hotkey = 49
            Case "2"
                Temp_Hotkey = 50
            Case "3"
                Temp_Hotkey = 51
            Case "4"
                Temp_Hotkey = 52
            Case "5"
                Temp_Hotkey = 53
            Case "6"
                Temp_Hotkey = 54
            Case "7"
                Temp_Hotkey = 55
            Case "8"
                Temp_Hotkey = 56
            Case "9"
                Temp_Hotkey = 57
            Case "F1"
                Temp_Hotkey = 112
            Case "F2"
                Temp_Hotkey = 113
            Case "F3"
                Temp_Hotkey = 114
            Case "F4"
                Temp_Hotkey = 115
            Case "F5"
                Temp_Hotkey = 116
            Case "F6"
                Temp_Hotkey = 117
            Case "F7"
                Temp_Hotkey = 118
            Case "F8"
                Temp_Hotkey = 119
            Case "F9"
                Temp_Hotkey = 120
            Case "F11"
                Temp_Hotkey = 122
            Case "F12"
                Temp_Hotkey = 123
            Case "-"
                Temp_Hotkey = 189
            Case "="
                Temp_Hotkey = 187
            Case "\"
                Temp_Hotkey = 220
            Case "["
                Temp_Hotkey = 219
            Case "]"
                Temp_Hotkey = 221
            Case ";"
                Temp_Hotkey = 186
            Case "'"
                Temp_Hotkey = 222
            Case ","
                Temp_Hotkey = 188
            Case "."
                Temp_Hotkey = 190
            Case "/"
                Temp_Hotkey = 191
            Case "Delete"
                Temp_Hotkey = 46
            Case "Backspace"
                Temp_Hotkey = 8
            Case "Tab"
                Temp_Hotkey = 9
            Case "Enter"
                Temp_Hotkey = 13
            Case "Shift"
                Temp_Hotkey = 16
            Case "Control"
                Temp_Hotkey = 17
            Case "Caps Lock"
                Temp_Hotkey = 20
            Case "Esc"
                Temp_Hotkey = 27
            Case "Spacebar"
                Temp_Hotkey = 32
            Case "Page Up"
                Temp_Hotkey = 33
            Case "Page Down"
                Temp_Hotkey = 34
            Case "End"
                Temp_Hotkey = 35
            Case "Home"
                Temp_Hotkey = 36
            Case "Up"
                Temp_Hotkey = 37
            Case "Down"
                Temp_Hotkey = 38
            Case "Left"
                Temp_Hotkey = 39
            Case "Right"
                Temp_Hotkey = 40
            Case "Num 0"
                Temp_Hotkey = 96
            Case "Num 1"
                Temp_Hotkey = 97
            Case "Num 2"
                Temp_Hotkey = 98
            Case "Num 3"
                Temp_Hotkey = 99
            Case "Num 4"
                Temp_Hotkey = 100
            Case "Num 5"
                Temp_Hotkey = 101
            Case "Num 6"
                Temp_Hotkey = 102
            Case "Num 7"
                Temp_Hotkey = 103
            Case "Num 8"
                Temp_Hotkey = 104
            Case "Num 9"
                Temp_Hotkey = 105
            Case "Num /"
                Temp_Hotkey = 111
            Case "Num *"
                Temp_Hotkey = 106
            Case "Num -"
                Temp_Hotkey = 109
            Case "Num +"
                Temp_Hotkey = 107
            Case "Num ."
                Temp_Hotkey = 110

        End Select
        GlobalVariables.Hotkey_Reset = Temp_Hotkey
    End Sub

End Class