Imports VB = Microsoft.VisualBasic

Public Class VisualizerForm
    Public DATA_VALIDATED As Boolean = False

    Public SecretCode As Queue(Of Keys)
    Private LastKeyStroke As Double = 0

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If (VB.Timer - LastKeyStroke) > 1D Then SecretCode.Clear()
        LastKeyStroke = VB.Timer
        SecretCode.Enqueue(keyData)
        EasterEggCipher.Scan(SecretCode)

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Public Sub New()
        Control.CheckForIllegalCrossThreadCalls = True
        ' This call is required by the designer.
        InitializeComponent()
        ' .Add any initialization after the InitializeComponent() call.
        SecretCode = New Queue(Of Keys)

        StylePalette.Import(Themes.UserInterface.RoyalBlue)
    End Sub

    Private Sub VisualizerForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Not FormsManager.Messages Is Nothing AndAlso Not FormsManager.Messages.Visible Then MessagesPanel.Visible = Not Me.Width < 700
        If Not PanelManager.Battery Is Nothing Then PanelManager.Battery.Visible = Not Me.Width < 440
        If Me.Width < 980 Then
            Me.BottomBarLayoutManager.ColumnStyles(2).SizeType = SizeType.Absolute
            Me.BottomBarLayoutManager.ColumnStyles(2).Width = 0
        Else
            Me.BottomBarLayoutManager.ColumnStyles(2).SizeType = SizeType.Percent
            Me.BottomBarLayoutManager.ColumnStyles(2).Width = 50%
        End If

        If Me.Height < 500 Then
            BatteryIcon.Visible = False
            BatteryPanel.SetRow(BatteryBarOutterBorder, 0)
            BatteryPanel.SetRowSpan(BatteryBarOutterBorder, 3)
        Else
            BatteryIcon.Visible = True
            BatteryPanel.SetRow(BatteryBarOutterBorder, 1)
            BatteryPanel.SetRowSpan(BatteryBarOutterBorder, 1)
        End If
        'MessagesPopupBtn.Visible = Me.Width < 700
    End Sub

    Private Sub VisualizerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelManager.VideoOutput = Me.VideoOutputPanel
        PanelManager.Messages = Me.MessagesContent
        PanelManager.Battery = Me.BatteryPanel
        FormsManager.MainForm = Me
        FormsManager.Messages = New MessagesPopup()
        FormsManager.Stopwatch = New StopwatchPopup()
    End Sub

    Private Sub VisualizerForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'DATA_VALIDATED = True

        FormsManager.Startup = New SetupForm()
        FormsManager.Startup.BringToFront()
        FormsManager.Startup.Select()
        FormsManager.Startup.ShowDialog()
        IntercomApiManager.StartAPI()

        If DATA_VALIDATED Then
            Me.Visible = True
            Me.Opacity = 1
            Me.ShowInTaskbar = True
            Me.WindowState = FormWindowState.Normal
            My.Computer.Audio.Play(My.Resources.Startup, AudioPlayMode.Background)
        Else
            Me.Close()
        End If
    End Sub

    Private Sub VisualizerForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If DATA_VALIDATED Then
            My.Computer.Audio.Play(My.Resources._Exit, AudioPlayMode.Background)
            If KryptonMessageBox.Show("Voulez-vous vraiment quitter ?", "Quitter ?", MessageBoxButtons.YesNo).ToString = "Yes" Then
                e.Cancel = True
                While IntercomApiManager.APIState()
                    IntercomApiManager.StopAPI()
                    Tools.Wait(0.25)
                End While
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub MenuPopupBtn_Click(sender As Object, e As EventArgs) Handles MenuPopupBtn.Click
        Select Case Me.MenuCommandsPanel.Visible
            Case True
                MenuCommandsPanel.Visible = False
                StopwatchPanel.Visible = True
                BottomBarLayoutManager.SetRowSpan(LeftBottomColumn, 1)
            Case False
                MenuCommandsPanel.Visible = True
                StopwatchPanel.Visible = False
                BottomBarLayoutManager.SetRowSpan(LeftBottomColumn, 3)
        End Select
    End Sub

    Private Sub MessagesPopupBtn_Click(sender As Object, e As EventArgs) Handles MessagesPopupBtn.Click
        MessagesController.SetState(PanelToggleArguments.Toggle)
    End Sub

    Private Sub StopwatchPopupBtn_Click(sender As Object, e As EventArgs) Handles StopwatchPopupBtn.Click
        StopwatchController.SetState(PanelToggleArguments.Toggle)
    End Sub
End Class