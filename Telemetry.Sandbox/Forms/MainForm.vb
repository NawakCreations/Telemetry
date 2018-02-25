Public Class MainForm
    Public DATA_VALIDATED As Boolean = False

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StylePalette.Import(Themes.UserInterface.Crimson)
        Globals.MainForm = Me
        Call New SetupForm().Show()
        If DATA_VALIDATED Then
            API.Init(True)
        Else
            Me.Close()
        End If
    End Sub

    Private Sub BatteryBtn_Click(sender As Object, e As EventArgs) Handles BatteryBtn.Click
        If API.Init(True) Then
            API.Instance.SetBattery(CDbl(BatteryUD.Value))
        End If
    End Sub

    Private Sub PingBtn_Click(sender As Object, e As EventArgs) Handles PingBtn.Click
        If API.Init(True) Then
            API.Instance.SetPing(CInt(PingUD.Value))
        End If
    End Sub

    Private Sub SpeedBtn_Click(sender As Object, e As EventArgs) Handles SpeedBtn.Click
        If API.Init(True) Then
            API.Instance.SetSpeed(CDbl(SpeedUD.Value))
        End If
    End Sub
End Class