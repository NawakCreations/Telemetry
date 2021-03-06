<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VisualizerForm
    'Inherits System.Windows.Forms.Form
    Inherits DesktopWindow

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
        Me.components = New System.ComponentModel.Container()
        Me.VideoOutputHeader = New System.Windows.Forms.Label()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.VideoOutputPanel = New System.Windows.Forms.Panel()
        Me.VideoOutput = New System.Windows.Forms.PictureBox()
        Me.VideoOutputStatus = New System.Windows.Forms.Panel()
        Me.DistancePanel = New System.Windows.Forms.TableLayoutPanel()
        Me.DistanceLabel = New System.Windows.Forms.Label()
        Me.SpeedPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.SpeedLabel = New System.Windows.Forms.Label()
        Me.VideoOutputHeaderPanel = New System.Windows.Forms.Panel()
        Me.PingPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.PingLabel = New System.Windows.Forms.Label()
        Me.PingIcon = New System.Windows.Forms.PictureBox()
        Me.BatteryPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.BatteryBarOutterBorder = New System.Windows.Forms.Panel()
        Me.BatteryBarInnerBorder = New System.Windows.Forms.Panel()
        Me.BatteryBarResizer = New System.Windows.Forms.TableLayoutPanel()
        Me.BatteryBarProgress = New System.Windows.Forms.Panel()
        Me.BatteryIcon = New System.Windows.Forms.PictureBox()
        Me.MessagesPanel = New System.Windows.Forms.Panel()
        Me.MessagesContent = New System.Windows.Forms.FlowLayoutPanel()
        Me.BatterieFaible = New Telemetry.Reusable.Notification()
        Me.Ralentir = New Telemetry.Reusable.Notification()
        Me.SignalFaible = New Telemetry.Reusable.Notification()
        Me.MessagesPopupTransmittedLbl = New System.Windows.Forms.Label()
        Me.MessagesHeader = New System.Windows.Forms.Label()
        Me.BottomPanel = New System.Windows.Forms.Panel()
        Me.BottomBarLayoutManager = New System.Windows.Forms.TableLayoutPanel()
        Me.LeftBottomColumn = New System.Windows.Forms.Panel()
        Me.MenuCommandsPanel = New System.Windows.Forms.Panel()
        Me.StopwatchPopupBtn = New System.Windows.Forms.Button()
        Me.MessagesPopupBtn = New System.Windows.Forms.Button()
        Me.MenuPopupBtn = New System.Windows.Forms.Button()
        Me.StopwatchPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.StopwatchIcon = New System.Windows.Forms.PictureBox()
        Me.StopwatchLabel = New System.Windows.Forms.Label()
        Me.TaskDialog = New ProgressDialogs.ProgressDialog(Me.components)
        Me.StyleManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.StylePalette = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.MainPanel.SuspendLayout()
        Me.VideoOutputPanel.SuspendLayout()
        CType(Me.VideoOutput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VideoOutputStatus.SuspendLayout()
        Me.DistancePanel.SuspendLayout()
        Me.SpeedPanel.SuspendLayout()
        Me.VideoOutputHeaderPanel.SuspendLayout()
        Me.PingPanel.SuspendLayout()
        CType(Me.PingIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BatteryPanel.SuspendLayout()
        Me.BatteryBarOutterBorder.SuspendLayout()
        Me.BatteryBarInnerBorder.SuspendLayout()
        Me.BatteryBarResizer.SuspendLayout()
        CType(Me.BatteryIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MessagesPanel.SuspendLayout()
        Me.MessagesContent.SuspendLayout()
        Me.BottomPanel.SuspendLayout()
        Me.BottomBarLayoutManager.SuspendLayout()
        Me.LeftBottomColumn.SuspendLayout()
        Me.MenuCommandsPanel.SuspendLayout()
        Me.StopwatchPanel.SuspendLayout()
        CType(Me.StopwatchIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormPinBtn
        '
        Me.FormPinBtn.Visible = True
        '
        'VideoOutputHeader
        '
        Me.VideoOutputHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VideoOutputHeader.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VideoOutputHeader.ForeColor = System.Drawing.Color.LightGray
        Me.VideoOutputHeader.Location = New System.Drawing.Point(0, 0)
        Me.VideoOutputHeader.Name = "VideoOutputHeader"
        Me.VideoOutputHeader.Size = New System.Drawing.Size(575, 37)
        Me.VideoOutputHeader.TabIndex = 1
        Me.VideoOutputHeader.Text = "SIGNAL VIDEO"
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.Gray
        Me.MainPanel.Controls.Add(Me.VideoOutputPanel)
        Me.MainPanel.Controls.Add(Me.BatteryPanel)
        Me.MainPanel.Controls.Add(Me.MessagesPanel)
        Me.MainPanel.Controls.Add(Me.BottomPanel)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Padding = New System.Windows.Forms.Padding(24)
        Me.MainPanel.Size = New System.Drawing.Size(1053, 518)
        Me.MainPanel.TabIndex = 2
        '
        'VideoOutputPanel
        '
        Me.VideoOutputPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.VideoOutputPanel.Controls.Add(Me.VideoOutput)
        Me.VideoOutputPanel.Controls.Add(Me.VideoOutputStatus)
        Me.VideoOutputPanel.Controls.Add(Me.VideoOutputHeaderPanel)
        Me.VideoOutputPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VideoOutputPanel.Location = New System.Drawing.Point(280, 24)
        Me.VideoOutputPanel.Margin = New System.Windows.Forms.Padding(8)
        Me.VideoOutputPanel.Name = "VideoOutputPanel"
        Me.VideoOutputPanel.Size = New System.Drawing.Size(701, 406)
        Me.VideoOutputPanel.TabIndex = 1
        '
        'VideoOutput
        '
        Me.VideoOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.VideoOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VideoOutput.Image = Global.Telemetry.My.Resources.Resources.animated_loader
        Me.VideoOutput.Location = New System.Drawing.Point(0, 37)
        Me.VideoOutput.Name = "VideoOutput"
        Me.VideoOutput.Size = New System.Drawing.Size(701, 332)
        Me.VideoOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.VideoOutput.TabIndex = 0
        Me.VideoOutput.TabStop = False
        '
        'VideoOutputStatus
        '
        Me.VideoOutputStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.VideoOutputStatus.Controls.Add(Me.DistancePanel)
        Me.VideoOutputStatus.Controls.Add(Me.SpeedPanel)
        Me.VideoOutputStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.VideoOutputStatus.Location = New System.Drawing.Point(0, 369)
        Me.VideoOutputStatus.Name = "VideoOutputStatus"
        Me.VideoOutputStatus.Size = New System.Drawing.Size(701, 37)
        Me.VideoOutputStatus.TabIndex = 3
        '
        'DistancePanel
        '
        Me.DistancePanel.AutoSize = True
        Me.DistancePanel.ColumnCount = 2
        Me.DistancePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DistancePanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.DistancePanel.Controls.Add(Me.DistanceLabel, 0, 0)
        Me.DistancePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.DistancePanel.Location = New System.Drawing.Point(0, 0)
        Me.DistancePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.DistancePanel.Name = "DistancePanel"
        Me.DistancePanel.RowCount = 1
        Me.DistancePanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DistancePanel.Size = New System.Drawing.Size(117, 37)
        Me.DistancePanel.TabIndex = 4
        '
        'DistanceLabel
        '
        Me.DistanceLabel.AutoSize = True
        Me.DistanceLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DistanceLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DistanceLabel.ForeColor = System.Drawing.Color.White
        Me.DistanceLabel.Location = New System.Drawing.Point(3, 0)
        Me.DistanceLabel.Name = "DistanceLabel"
        Me.DistanceLabel.Size = New System.Drawing.Size(74, 37)
        Me.DistanceLabel.TabIndex = 4
        Me.DistanceLabel.Text = "134 m"
        Me.DistanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SpeedPanel
        '
        Me.SpeedPanel.AutoSize = True
        Me.SpeedPanel.ColumnCount = 2
        Me.SpeedPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.SpeedPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.SpeedPanel.Controls.Add(Me.SpeedLabel, 1, 0)
        Me.SpeedPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.SpeedPanel.Location = New System.Drawing.Point(553, 0)
        Me.SpeedPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.SpeedPanel.Name = "SpeedPanel"
        Me.SpeedPanel.RowCount = 1
        Me.SpeedPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.SpeedPanel.Size = New System.Drawing.Size(148, 37)
        Me.SpeedPanel.TabIndex = 3
        '
        'SpeedLabel
        '
        Me.SpeedLabel.AutoSize = True
        Me.SpeedLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpeedLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpeedLabel.ForeColor = System.Drawing.Color.White
        Me.SpeedLabel.Location = New System.Drawing.Point(40, 0)
        Me.SpeedLabel.Name = "SpeedLabel"
        Me.SpeedLabel.Size = New System.Drawing.Size(105, 37)
        Me.SpeedLabel.TabIndex = 4
        Me.SpeedLabel.Text = "3.6 KM/h"
        Me.SpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VideoOutputHeaderPanel
        '
        Me.VideoOutputHeaderPanel.Controls.Add(Me.VideoOutputHeader)
        Me.VideoOutputHeaderPanel.Controls.Add(Me.PingPanel)
        Me.VideoOutputHeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.VideoOutputHeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.VideoOutputHeaderPanel.Name = "VideoOutputHeaderPanel"
        Me.VideoOutputHeaderPanel.Size = New System.Drawing.Size(701, 37)
        Me.VideoOutputHeaderPanel.TabIndex = 2
        '
        'PingPanel
        '
        Me.PingPanel.AutoSize = True
        Me.PingPanel.ColumnCount = 2
        Me.PingPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.PingPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PingPanel.Controls.Add(Me.PingLabel, 1, 0)
        Me.PingPanel.Controls.Add(Me.PingIcon, 0, 0)
        Me.PingPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.PingPanel.Location = New System.Drawing.Point(575, 0)
        Me.PingPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.PingPanel.Name = "PingPanel"
        Me.PingPanel.RowCount = 1
        Me.PingPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PingPanel.Size = New System.Drawing.Size(126, 37)
        Me.PingPanel.TabIndex = 2
        '
        'PingLabel
        '
        Me.PingLabel.AutoSize = True
        Me.PingLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PingLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PingLabel.ForeColor = System.Drawing.Color.White
        Me.PingLabel.Location = New System.Drawing.Point(40, 0)
        Me.PingLabel.Name = "PingLabel"
        Me.PingLabel.Size = New System.Drawing.Size(83, 37)
        Me.PingLabel.TabIndex = 4
        Me.PingLabel.Text = "145 ms"
        Me.PingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PingIcon
        '
        Me.PingIcon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PingIcon.Image = Global.Telemetry.My.Resources.Resources.Signal
        Me.PingIcon.Location = New System.Drawing.Point(4, 4)
        Me.PingIcon.Margin = New System.Windows.Forms.Padding(4)
        Me.PingIcon.Name = "PingIcon"
        Me.PingIcon.Size = New System.Drawing.Size(29, 29)
        Me.PingIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PingIcon.TabIndex = 0
        Me.PingIcon.TabStop = False
        '
        'BatteryPanel
        '
        Me.BatteryPanel.BackColor = System.Drawing.Color.RoyalBlue
        Me.BatteryPanel.ColumnCount = 1
        Me.BatteryPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.BatteryPanel.Controls.Add(Me.BatteryBarOutterBorder, 0, 1)
        Me.BatteryPanel.Controls.Add(Me.BatteryIcon, 0, 2)
        Me.BatteryPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.BatteryPanel.Location = New System.Drawing.Point(981, 24)
        Me.BatteryPanel.Name = "BatteryPanel"
        Me.BatteryPanel.RowCount = 3
        Me.BatteryPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.BatteryPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.BatteryPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.BatteryPanel.Size = New System.Drawing.Size(48, 406)
        Me.BatteryPanel.TabIndex = 4
        '
        'BatteryBarOutterBorder
        '
        Me.BatteryBarOutterBorder.BackColor = System.Drawing.Color.White
        Me.BatteryBarOutterBorder.Controls.Add(Me.BatteryBarInnerBorder)
        Me.BatteryBarOutterBorder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BatteryBarOutterBorder.Location = New System.Drawing.Point(4, 41)
        Me.BatteryBarOutterBorder.Margin = New System.Windows.Forms.Padding(4)
        Me.BatteryBarOutterBorder.Name = "BatteryBarOutterBorder"
        Me.BatteryBarOutterBorder.Padding = New System.Windows.Forms.Padding(4)
        Me.BatteryBarOutterBorder.Size = New System.Drawing.Size(40, 313)
        Me.BatteryBarOutterBorder.TabIndex = 1
        '
        'BatteryBarInnerBorder
        '
        Me.BatteryBarInnerBorder.BackColor = System.Drawing.Color.RoyalBlue
        Me.BatteryBarInnerBorder.Controls.Add(Me.BatteryBarResizer)
        Me.BatteryBarInnerBorder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BatteryBarInnerBorder.Location = New System.Drawing.Point(4, 4)
        Me.BatteryBarInnerBorder.Margin = New System.Windows.Forms.Padding(0)
        Me.BatteryBarInnerBorder.Name = "BatteryBarInnerBorder"
        Me.BatteryBarInnerBorder.Padding = New System.Windows.Forms.Padding(4)
        Me.BatteryBarInnerBorder.Size = New System.Drawing.Size(32, 305)
        Me.BatteryBarInnerBorder.TabIndex = 0
        '
        'BatteryBarResizer
        '
        Me.BatteryBarResizer.BackColor = System.Drawing.Color.RoyalBlue
        Me.BatteryBarResizer.ColumnCount = 1
        Me.BatteryBarResizer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.BatteryBarResizer.Controls.Add(Me.BatteryBarProgress, 0, 1)
        Me.BatteryBarResizer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BatteryBarResizer.Location = New System.Drawing.Point(4, 4)
        Me.BatteryBarResizer.Name = "BatteryBarResizer"
        Me.BatteryBarResizer.RowCount = 2
        Me.BatteryBarResizer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.BatteryBarResizer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.BatteryBarResizer.Size = New System.Drawing.Size(24, 297)
        Me.BatteryBarResizer.TabIndex = 0
        '
        'BatteryBarProgress
        '
        Me.BatteryBarProgress.BackColor = System.Drawing.Color.White
        Me.BatteryBarProgress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BatteryBarProgress.Location = New System.Drawing.Point(0, 148)
        Me.BatteryBarProgress.Margin = New System.Windows.Forms.Padding(0)
        Me.BatteryBarProgress.Name = "BatteryBarProgress"
        Me.BatteryBarProgress.Size = New System.Drawing.Size(24, 149)
        Me.BatteryBarProgress.TabIndex = 0
        '
        'BatteryIcon
        '
        Me.BatteryIcon.Image = Global.Telemetry.My.Resources.Resources.Energy
        Me.BatteryIcon.Location = New System.Drawing.Point(8, 366)
        Me.BatteryIcon.Margin = New System.Windows.Forms.Padding(8)
        Me.BatteryIcon.Name = "BatteryIcon"
        Me.BatteryIcon.Size = New System.Drawing.Size(32, 32)
        Me.BatteryIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BatteryIcon.TabIndex = 0
        Me.BatteryIcon.TabStop = False
        '
        'MessagesPanel
        '
        Me.MessagesPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MessagesPanel.Controls.Add(Me.MessagesContent)
        Me.MessagesPanel.Controls.Add(Me.MessagesPopupTransmittedLbl)
        Me.MessagesPanel.Controls.Add(Me.MessagesHeader)
        Me.MessagesPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.MessagesPanel.Location = New System.Drawing.Point(24, 24)
        Me.MessagesPanel.Margin = New System.Windows.Forms.Padding(8)
        Me.MessagesPanel.Name = "MessagesPanel"
        Me.MessagesPanel.Size = New System.Drawing.Size(256, 406)
        Me.MessagesPanel.TabIndex = 2
        '
        'MessagesContent
        '
        Me.MessagesContent.AutoScroll = True
        Me.MessagesContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MessagesContent.Controls.Add(Me.BatterieFaible)
        Me.MessagesContent.Controls.Add(Me.Ralentir)
        Me.MessagesContent.Controls.Add(Me.SignalFaible)
        Me.MessagesContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessagesContent.Location = New System.Drawing.Point(0, 37)
        Me.MessagesContent.Margin = New System.Windows.Forms.Padding(0)
        Me.MessagesContent.Name = "MessagesContent"
        Me.MessagesContent.Padding = New System.Windows.Forms.Padding(0, 16, 0, 32)
        Me.MessagesContent.Size = New System.Drawing.Size(256, 369)
        Me.MessagesContent.TabIndex = 4
        '
        'BatterieFaible
        '
        Me.BatterieFaible.AutoSize = True
        Me.BatterieFaible.BackColor = System.Drawing.Color.RoyalBlue
        Me.BatterieFaible.Location = New System.Drawing.Point(8, 20)
        Me.BatterieFaible.Margin = New System.Windows.Forms.Padding(8, 4, 0, 4)
        Me.BatterieFaible.MaximumSize = New System.Drawing.Size(224, 0)
        Me.BatterieFaible.Message = "Certaines fonctions peuvent" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "être interrompues à cause " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "du manque d'énergie." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "El" &
    "les reprendront quand" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "la charge sera suffisante."
        Me.BatterieFaible.MinimumSize = New System.Drawing.Size(224, 100)
        Me.BatterieFaible.Name = "BatterieFaible"
        Me.BatterieFaible.Size = New System.Drawing.Size(224, 141)
        Me.BatterieFaible.TabIndex = 8
        Me.BatterieFaible.Title = "BATTERIE FAIBLE"
        '
        'Ralentir
        '
        Me.Ralentir.AutoSize = True
        Me.Ralentir.BackColor = System.Drawing.Color.RoyalBlue
        Me.Ralentir.Location = New System.Drawing.Point(8, 169)
        Me.Ralentir.Margin = New System.Windows.Forms.Padding(8, 4, 0, 4)
        Me.Ralentir.MaximumSize = New System.Drawing.Size(224, 0)
        Me.Ralentir.Message = "Les capteurs de la voiture " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ont détecté un obstacle qui" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "approche rapidement, il" &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "serait préférable de ralentir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "pour l'éviter."
        Me.Ralentir.MinimumSize = New System.Drawing.Size(224, 100)
        Me.Ralentir.Name = "Ralentir"
        Me.Ralentir.Size = New System.Drawing.Size(224, 141)
        Me.Ralentir.TabIndex = 7
        Me.Ralentir.Title = "RALENTIR"
        '
        'SignalFaible
        '
        Me.SignalFaible.AutoSize = True
        Me.SignalFaible.BackColor = System.Drawing.Color.RoyalBlue
        Me.SignalFaible.Location = New System.Drawing.Point(8, 318)
        Me.SignalFaible.Margin = New System.Windows.Forms.Padding(8, 4, 0, 4)
        Me.SignalFaible.MaximumSize = New System.Drawing.Size(224, 0)
        Me.SignalFaible.Message = "Certaines fonctions peuvent" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "être interrompues à cause " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "du manque de signal." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "El" &
    "les reprendront quand" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ce dernier sera rétabli."
        Me.SignalFaible.MinimumSize = New System.Drawing.Size(224, 100)
        Me.SignalFaible.Name = "SignalFaible"
        Me.SignalFaible.Size = New System.Drawing.Size(224, 141)
        Me.SignalFaible.TabIndex = 6
        Me.SignalFaible.Title = "SIGNAL FAIBLE"
        '
        'MessagesPopupTransmittedLbl
        '
        Me.MessagesPopupTransmittedLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessagesPopupTransmittedLbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessagesPopupTransmittedLbl.Location = New System.Drawing.Point(0, 37)
        Me.MessagesPopupTransmittedLbl.Name = "MessagesPopupTransmittedLbl"
        Me.MessagesPopupTransmittedLbl.Size = New System.Drawing.Size(256, 369)
        Me.MessagesPopupTransmittedLbl.TabIndex = 3
        Me.MessagesPopupTransmittedLbl.Text = "Le contenu à été transmis dans la fenêtre popup." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fermez la fenêtre popup pour " &
    "revenir à un affichage classique" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.MessagesPopupTransmittedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MessagesHeader
        '
        Me.MessagesHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.MessagesHeader.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessagesHeader.ForeColor = System.Drawing.Color.DimGray
        Me.MessagesHeader.Location = New System.Drawing.Point(0, 0)
        Me.MessagesHeader.Name = "MessagesHeader"
        Me.MessagesHeader.Size = New System.Drawing.Size(256, 37)
        Me.MessagesHeader.TabIndex = 1
        Me.MessagesHeader.Text = "MESSAGES"
        '
        'BottomPanel
        '
        Me.BottomPanel.Controls.Add(Me.BottomBarLayoutManager)
        Me.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomPanel.Location = New System.Drawing.Point(24, 430)
        Me.BottomPanel.Margin = New System.Windows.Forms.Padding(8)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        Me.BottomPanel.Size = New System.Drawing.Size(1005, 64)
        Me.BottomPanel.TabIndex = 3
        '
        'BottomBarLayoutManager
        '
        Me.BottomBarLayoutManager.BackColor = System.Drawing.Color.DimGray
        Me.BottomBarLayoutManager.ColumnCount = 3
        Me.BottomBarLayoutManager.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.BottomBarLayoutManager.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 271.0!))
        Me.BottomBarLayoutManager.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.BottomBarLayoutManager.Controls.Add(Me.LeftBottomColumn, 0, 0)
        Me.BottomBarLayoutManager.Controls.Add(Me.StopwatchPanel, 1, 0)
        Me.BottomBarLayoutManager.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BottomBarLayoutManager.Location = New System.Drawing.Point(0, 4)
        Me.BottomBarLayoutManager.Name = "BottomBarLayoutManager"
        Me.BottomBarLayoutManager.RowCount = 1
        Me.BottomBarLayoutManager.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.BottomBarLayoutManager.Size = New System.Drawing.Size(1005, 56)
        Me.BottomBarLayoutManager.TabIndex = 2
        '
        'LeftBottomColumn
        '
        Me.LeftBottomColumn.AutoSize = True
        Me.LeftBottomColumn.Controls.Add(Me.MenuCommandsPanel)
        Me.LeftBottomColumn.Controls.Add(Me.MenuPopupBtn)
        Me.LeftBottomColumn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LeftBottomColumn.Location = New System.Drawing.Point(3, 3)
        Me.LeftBottomColumn.Name = "LeftBottomColumn"
        Me.LeftBottomColumn.Padding = New System.Windows.Forms.Padding(6)
        Me.LeftBottomColumn.Size = New System.Drawing.Size(361, 50)
        Me.LeftBottomColumn.TabIndex = 3
        '
        'MenuCommandsPanel
        '
        Me.MenuCommandsPanel.AutoSize = True
        Me.MenuCommandsPanel.Controls.Add(Me.StopwatchPopupBtn)
        Me.MenuCommandsPanel.Controls.Add(Me.MessagesPopupBtn)
        Me.MenuCommandsPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuCommandsPanel.Location = New System.Drawing.Point(92, 6)
        Me.MenuCommandsPanel.Name = "MenuCommandsPanel"
        Me.MenuCommandsPanel.Size = New System.Drawing.Size(314, 38)
        Me.MenuCommandsPanel.TabIndex = 4
        Me.MenuCommandsPanel.Visible = False
        '
        'StopwatchPopupBtn
        '
        Me.StopwatchPopupBtn.AutoSize = True
        Me.StopwatchPopupBtn.BackColor = System.Drawing.Color.DimGray
        Me.StopwatchPopupBtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.StopwatchPopupBtn.FlatAppearance.BorderSize = 0
        Me.StopwatchPopupBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StopwatchPopupBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.StopwatchPopupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StopwatchPopupBtn.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.StopwatchPopupBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.StopwatchPopupBtn.Location = New System.Drawing.Point(131, 0)
        Me.StopwatchPopupBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.StopwatchPopupBtn.Name = "StopwatchPopupBtn"
        Me.StopwatchPopupBtn.Size = New System.Drawing.Size(183, 38)
        Me.StopwatchPopupBtn.TabIndex = 4
        Me.StopwatchPopupBtn.Text = "CHRONOMETRE"
        Me.StopwatchPopupBtn.UseVisualStyleBackColor = False
        '
        'MessagesPopupBtn
        '
        Me.MessagesPopupBtn.AutoSize = True
        Me.MessagesPopupBtn.BackColor = System.Drawing.Color.DimGray
        Me.MessagesPopupBtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.MessagesPopupBtn.FlatAppearance.BorderSize = 0
        Me.MessagesPopupBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MessagesPopupBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.MessagesPopupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MessagesPopupBtn.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.MessagesPopupBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MessagesPopupBtn.Location = New System.Drawing.Point(0, 0)
        Me.MessagesPopupBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.MessagesPopupBtn.Name = "MessagesPopupBtn"
        Me.MessagesPopupBtn.Size = New System.Drawing.Size(131, 38)
        Me.MessagesPopupBtn.TabIndex = 3
        Me.MessagesPopupBtn.Text = "MESSAGES"
        Me.MessagesPopupBtn.UseVisualStyleBackColor = False
        '
        'MenuPopupBtn
        '
        Me.MenuPopupBtn.AutoSize = True
        Me.MenuPopupBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MenuPopupBtn.BackColor = System.Drawing.Color.DimGray
        Me.MenuPopupBtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuPopupBtn.FlatAppearance.BorderSize = 0
        Me.MenuPopupBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuPopupBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.MenuPopupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MenuPopupBtn.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold)
        Me.MenuPopupBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MenuPopupBtn.Location = New System.Drawing.Point(6, 6)
        Me.MenuPopupBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.MenuPopupBtn.Name = "MenuPopupBtn"
        Me.MenuPopupBtn.Size = New System.Drawing.Size(86, 38)
        Me.MenuPopupBtn.TabIndex = 3
        Me.MenuPopupBtn.Text = "MENU"
        Me.MenuPopupBtn.UseVisualStyleBackColor = False
        '
        'StopwatchPanel
        '
        Me.StopwatchPanel.ColumnCount = 2
        Me.StopwatchPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.StopwatchPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.StopwatchPanel.Controls.Add(Me.StopwatchIcon, 0, 0)
        Me.StopwatchPanel.Controls.Add(Me.StopwatchLabel, 1, 0)
        Me.StopwatchPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StopwatchPanel.Location = New System.Drawing.Point(367, 0)
        Me.StopwatchPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.StopwatchPanel.Name = "StopwatchPanel"
        Me.StopwatchPanel.RowCount = 1
        Me.StopwatchPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.StopwatchPanel.Size = New System.Drawing.Size(271, 56)
        Me.StopwatchPanel.TabIndex = 2
        '
        'StopwatchIcon
        '
        Me.StopwatchIcon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StopwatchIcon.Image = Global.Telemetry.My.Resources.Resources.Stopwatch
        Me.StopwatchIcon.Location = New System.Drawing.Point(2, 2)
        Me.StopwatchIcon.Margin = New System.Windows.Forms.Padding(2)
        Me.StopwatchIcon.Name = "StopwatchIcon"
        Me.StopwatchIcon.Size = New System.Drawing.Size(52, 52)
        Me.StopwatchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.StopwatchIcon.TabIndex = 0
        Me.StopwatchIcon.TabStop = False
        '
        'StopwatchLabel
        '
        Me.StopwatchLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StopwatchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopwatchLabel.ForeColor = System.Drawing.Color.White
        Me.StopwatchLabel.Location = New System.Drawing.Point(56, 0)
        Me.StopwatchLabel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 4)
        Me.StopwatchLabel.Name = "StopwatchLabel"
        Me.StopwatchLabel.Size = New System.Drawing.Size(215, 52)
        Me.StopwatchLabel.TabIndex = 1
        Me.StopwatchLabel.Text = "00:01:27.87"
        Me.StopwatchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TaskDialog
        '
        Me.TaskDialog.AutoClose = False
        Me.TaskDialog.CancelButton = False
        Me.TaskDialog.CancelMessage = ""
        Me.TaskDialog.CompactPaths = True
        Me.TaskDialog.Marquee = True
        Me.TaskDialog.Modal = True
        Me.TaskDialog.ShowTimeRemaining = False
        Me.TaskDialog.Title = "Démarrage du serveur interne ..."
        '
        'StyleManager
        '
        Me.StyleManager.GlobalPalette = Me.StylePalette
        Me.StyleManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Custom
        '
        'VisualizerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 518)
        Me.Controls.Add(Me.MainPanel)
        Me.FormPin = True
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(664, 480)
        Me.Name = "VisualizerForm"
        Me.Opacity = 0R
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Télémétrie [Fenêtre principale]"
        Me.MainPanel.ResumeLayout(False)
        Me.VideoOutputPanel.ResumeLayout(False)
        CType(Me.VideoOutput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VideoOutputStatus.ResumeLayout(False)
        Me.VideoOutputStatus.PerformLayout()
        Me.DistancePanel.ResumeLayout(False)
        Me.DistancePanel.PerformLayout()
        Me.SpeedPanel.ResumeLayout(False)
        Me.SpeedPanel.PerformLayout()
        Me.VideoOutputHeaderPanel.ResumeLayout(False)
        Me.VideoOutputHeaderPanel.PerformLayout()
        Me.PingPanel.ResumeLayout(False)
        Me.PingPanel.PerformLayout()
        CType(Me.PingIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BatteryPanel.ResumeLayout(False)
        Me.BatteryBarOutterBorder.ResumeLayout(False)
        Me.BatteryBarInnerBorder.ResumeLayout(False)
        Me.BatteryBarResizer.ResumeLayout(False)
        CType(Me.BatteryIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MessagesPanel.ResumeLayout(False)
        Me.MessagesContent.ResumeLayout(False)
        Me.MessagesContent.PerformLayout()
        Me.BottomPanel.ResumeLayout(False)
        Me.BottomBarLayoutManager.ResumeLayout(False)
        Me.BottomBarLayoutManager.PerformLayout()
        Me.LeftBottomColumn.ResumeLayout(False)
        Me.LeftBottomColumn.PerformLayout()
        Me.MenuCommandsPanel.ResumeLayout(False)
        Me.MenuCommandsPanel.PerformLayout()
        Me.StopwatchPanel.ResumeLayout(False)
        CType(Me.StopwatchIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents VideoOutput As PictureBox
    Friend WithEvents VideoOutputHeader As Label
    Friend WithEvents MainPanel As Panel
    Friend WithEvents VideoOutputPanel As Panel
    Friend WithEvents MessagesPanel As Panel
    Friend WithEvents MessagesHeader As Label
    Friend WithEvents VideoOutputHeaderPanel As Panel
    Friend WithEvents PingPanel As TableLayoutPanel
    Friend WithEvents PingIcon As PictureBox
    Friend WithEvents PingLabel As Label
    Friend WithEvents BottomPanel As Panel
    Friend WithEvents MessagesPopupTransmittedLbl As Label
    Friend WithEvents MessagesContent As FlowLayoutPanel
    Friend WithEvents BatteryPanel As TableLayoutPanel
    Friend WithEvents BatteryIcon As PictureBox
    Friend WithEvents BatteryBarOutterBorder As Panel
    Friend WithEvents BatteryBarInnerBorder As Panel
    Friend WithEvents BatteryBarResizer As TableLayoutPanel
    Friend WithEvents BatteryBarProgress As Panel
    Friend WithEvents BottomBarLayoutManager As TableLayoutPanel
    Friend WithEvents StopwatchPanel As TableLayoutPanel
    Friend WithEvents StopwatchIcon As PictureBox
    Friend WithEvents LeftBottomColumn As Panel
    Friend WithEvents StopwatchLabel As Label
    Friend WithEvents VideoOutputStatus As Panel
    Friend WithEvents DistancePanel As TableLayoutPanel
    Friend WithEvents DistanceLabel As Label
    Friend WithEvents SpeedPanel As TableLayoutPanel
    Friend WithEvents SpeedLabel As Label
    Friend WithEvents MenuPopupBtn As Button
    Friend WithEvents MenuCommandsPanel As Panel
    Friend WithEvents StopwatchPopupBtn As Button
    Friend WithEvents MessagesPopupBtn As Button
    Friend WithEvents TaskDialog As ProgressDialogs.ProgressDialog
    Friend WithEvents StyleManager As KryptonManager
    Friend WithEvents StylePalette As KryptonPalette
    Friend WithEvents SignalFaible As Notification
    Friend WithEvents Ralentir As Notification
    Friend WithEvents BatterieFaible As Notification
End Class
