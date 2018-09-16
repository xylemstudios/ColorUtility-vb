<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.hexLabel = New System.Windows.Forms.Label()
        Me.colorPanel = New System.Windows.Forms.Panel()
        Me.CopyStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyVBNetColorFromArgbToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyForWinFormsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyForCSSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyHexForVBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyHexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyHSVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.hexTxt = New System.Windows.Forms.TextBox()
        Me.copyrightLabel = New System.Windows.Forms.Label()
        Me.InfoPopup = New System.Windows.Forms.ToolTip(Me.components)
        Me.decTxt = New System.Windows.Forms.TextBox()
        Me.decLabel = New System.Windows.Forms.Label()
        Me.WebsitePopup = New System.Windows.Forms.ToolTip(Me.components)
        Me.credCodeNameLabel = New System.Windows.Forms.Label()
        Me.credNorskNameLabel = New System.Windows.Forms.Label()
        Me.helpStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.newUserPopup = New System.Windows.Forms.ToolTip(Me.components)
        Me.creditsTab = New System.Windows.Forms.TabPage()
        Me.credNorskLabel = New System.Windows.Forms.Label()
        Me.credCodeLabel = New System.Windows.Forms.Label()
        Me.credVersionLabel = New System.Windows.Forms.Label()
        Me.credNameLabel = New System.Windows.Forms.Label()
        Me.cuLogo = New System.Windows.Forms.PictureBox()
        Me.settingsTab = New System.Windows.Forms.TabPage()
        Me.clipChk = New System.Windows.Forms.CheckBox()
        Me.clipLabel = New System.Windows.Forms.Label()
        Me.hsvChk = New System.Windows.Forms.CheckBox()
        Me.rgbChk = New System.Windows.Forms.CheckBox()
        Me.langSet = New System.Windows.Forms.Button()
        Me.langCombo = New System.Windows.Forms.ComboBox()
        Me.langLabel = New System.Windows.Forms.Label()
        Me.spaceLabel = New System.Windows.Forms.Label()
        Me.speedLabel = New System.Windows.Forms.Label()
        Me.speedChk = New System.Windows.Forms.CheckBox()
        Me.othertoolsTab = New System.Windows.Forms.TabPage()
        Me.toolDesc = New System.Windows.Forms.Label()
        Me.toolLabel = New System.Windows.Forms.Label()
        Me.tool_panel = New System.Windows.Forms.Panel()
        Me.t_colorsImageBtn = New System.Windows.Forms.Button()
        Me.t_combinerBtn = New System.Windows.Forms.Button()
        Me.t_randomBtn = New System.Windows.Forms.Button()
        Me.filtersTab = New System.Windows.Forms.TabPage()
        Me.filterDesc = New System.Windows.Forms.Label()
        Me.filterLabel = New System.Windows.Forms.Label()
        Me.filtersPanel = New System.Windows.Forms.Panel()
        Me.f_rgbShuffleBtn = New System.Windows.Forms.Button()
        Me.f_intensifyBtn = New System.Windows.Forms.Button()
        Me.f_blueBtn = New System.Windows.Forms.Button()
        Me.f_greenBtn = New System.Windows.Forms.Button()
        Me.f_darkerBtn = New System.Windows.Forms.Button()
        Me.f_redBtn = New System.Windows.Forms.Button()
        Me.f_brighterBtn = New System.Windows.Forms.Button()
        Me.f_sepiaBtn = New System.Windows.Forms.Button()
        Me.f_negativeBtn = New System.Windows.Forms.Button()
        Me.f_grayBtn = New System.Windows.Forms.Button()
        Me.rgbTab = New System.Windows.Forms.TabPage()
        Me.blue_txt = New System.Windows.Forms.TextBox()
        Me.green_txt = New System.Windows.Forms.TextBox()
        Me.red_txt = New System.Windows.Forms.TextBox()
        Me.blue_pic = New System.Windows.Forms.PictureBox()
        Me.green_pic = New System.Windows.Forms.PictureBox()
        Me.green_bar = New System.Windows.Forms.TrackBar()
        Me.red_pic = New System.Windows.Forms.PictureBox()
        Me.red_bar = New System.Windows.Forms.TrackBar()
        Me.b_label = New System.Windows.Forms.Label()
        Me.g_label = New System.Windows.Forms.Label()
        Me.r_label = New System.Windows.Forms.Label()
        Me.blue_bar = New System.Windows.Forms.TrackBar()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.hsvTab = New System.Windows.Forms.TabPage()
        Me.value_txt = New System.Windows.Forms.TextBox()
        Me.saturation_txt = New System.Windows.Forms.TextBox()
        Me.hue_txt = New System.Windows.Forms.TextBox()
        Me.value_pic = New System.Windows.Forms.PictureBox()
        Me.saturation_pic = New System.Windows.Forms.PictureBox()
        Me.saturation_bar = New System.Windows.Forms.TrackBar()
        Me.hue_pic = New System.Windows.Forms.PictureBox()
        Me.hue_bar = New System.Windows.Forms.TrackBar()
        Me.v_label = New System.Windows.Forms.Label()
        Me.s_label = New System.Windows.Forms.Label()
        Me.h_label = New System.Windows.Forms.Label()
        Me.value_bar = New System.Windows.Forms.TrackBar()
        Me.xylemLogo = New System.Windows.Forms.PictureBox()
        Me.webColorBtn = New System.Windows.Forms.Button()
        Me.colorPickerBtn = New System.Windows.Forms.Button()
        Me.randomColorBtn = New System.Windows.Forms.Button()
        Me.CopyStrip.SuspendLayout()
        Me.helpStrip.SuspendLayout()
        Me.creditsTab.SuspendLayout()
        CType(Me.cuLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.settingsTab.SuspendLayout()
        Me.othertoolsTab.SuspendLayout()
        Me.tool_panel.SuspendLayout()
        Me.filtersTab.SuspendLayout()
        Me.filtersPanel.SuspendLayout()
        Me.rgbTab.SuspendLayout()
        CType(Me.blue_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.green_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.green_bar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.red_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.red_bar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.blue_bar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.hsvTab.SuspendLayout()
        CType(Me.value_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.saturation_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.saturation_bar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hue_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hue_bar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.value_bar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xylemLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'hexLabel
        '
        Me.hexLabel.AutoSize = True
        Me.hexLabel.Location = New System.Drawing.Point(281, 101)
        Me.hexLabel.Name = "hexLabel"
        Me.hexLabel.Size = New System.Drawing.Size(14, 13)
        Me.hexLabel.TabIndex = 1
        Me.hexLabel.Text = "#"
        '
        'colorPanel
        '
        Me.colorPanel.AllowDrop = True
        Me.colorPanel.BackColor = System.Drawing.Color.Black
        Me.colorPanel.ContextMenuStrip = Me.CopyStrip
        Me.colorPanel.ForeColor = System.Drawing.SystemColors.GrayText
        Me.colorPanel.Location = New System.Drawing.Point(277, 12)
        Me.colorPanel.Name = "colorPanel"
        Me.colorPanel.Size = New System.Drawing.Size(80, 80)
        Me.colorPanel.TabIndex = 0
        '
        'CopyStrip
        '
        Me.CopyStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyVBNetColorFromArgbToolStripMenuItem, Me.CopyForWinFormsToolStripMenuItem, Me.CopyForCSSToolStripMenuItem, Me.CopyHexForVBToolStripMenuItem, Me.CopyHexToolStripMenuItem, Me.CopyHSVToolStripMenuItem})
        Me.CopyStrip.Name = "ContextMenuStrip1"
        Me.CopyStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.CopyStrip.ShowImageMargin = False
        Me.CopyStrip.Size = New System.Drawing.Size(153, 136)
        '
        'CopyVBNetColorFromArgbToolStripMenuItem
        '
        Me.CopyVBNetColorFromArgbToolStripMenuItem.Name = "CopyVBNetColorFromArgbToolStripMenuItem"
        Me.CopyVBNetColorFromArgbToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CopyVBNetColorFromArgbToolStripMenuItem.Text = "Copy for VB.Net"
        '
        'CopyForWinFormsToolStripMenuItem
        '
        Me.CopyForWinFormsToolStripMenuItem.Name = "CopyForWinFormsToolStripMenuItem"
        Me.CopyForWinFormsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CopyForWinFormsToolStripMenuItem.Text = "Copy for WinForms"
        '
        'CopyForCSSToolStripMenuItem
        '
        Me.CopyForCSSToolStripMenuItem.Name = "CopyForCSSToolStripMenuItem"
        Me.CopyForCSSToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CopyForCSSToolStripMenuItem.Text = "Copy for CSS"
        '
        'CopyHexForVBToolStripMenuItem
        '
        Me.CopyHexForVBToolStripMenuItem.Name = "CopyHexForVBToolStripMenuItem"
        Me.CopyHexForVBToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CopyHexForVBToolStripMenuItem.Text = "Copy Hex for VB"
        '
        'CopyHexToolStripMenuItem
        '
        Me.CopyHexToolStripMenuItem.Name = "CopyHexToolStripMenuItem"
        Me.CopyHexToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CopyHexToolStripMenuItem.Text = "Copy Hex"
        '
        'CopyHSVToolStripMenuItem
        '
        Me.CopyHSVToolStripMenuItem.Name = "CopyHSVToolStripMenuItem"
        Me.CopyHSVToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CopyHSVToolStripMenuItem.Text = "Copy HSV"
        '
        'hexTxt
        '
        Me.hexTxt.BackColor = System.Drawing.SystemColors.Window
        Me.hexTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.hexTxt.Location = New System.Drawing.Point(301, 98)
        Me.hexTxt.MaxLength = 6
        Me.hexTxt.Name = "hexTxt"
        Me.hexTxt.Size = New System.Drawing.Size(56, 20)
        Me.hexTxt.TabIndex = 1
        Me.hexTxt.Text = "000000"
        '
        'copyrightLabel
        '
        Me.copyrightLabel.AutoSize = True
        Me.copyrightLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.copyrightLabel.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.copyrightLabel.Location = New System.Drawing.Point(96, 164)
        Me.copyrightLabel.Name = "copyrightLabel"
        Me.copyrightLabel.Size = New System.Drawing.Size(172, 13)
        Me.copyrightLabel.TabIndex = 0
        Me.copyrightLabel.Text = "© Copyright Xylem Studios 2011"
        '
        'InfoPopup
        '
        Me.InfoPopup.AutomaticDelay = 200
        Me.InfoPopup.AutoPopDelay = 5000
        Me.InfoPopup.InitialDelay = 200
        Me.InfoPopup.ReshowDelay = 100
        Me.InfoPopup.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.InfoPopup.ToolTipTitle = "Information"
        '
        'decTxt
        '
        Me.decTxt.Location = New System.Drawing.Point(301, 124)
        Me.decTxt.MaxLength = 8
        Me.decTxt.Name = "decTxt"
        Me.decTxt.Size = New System.Drawing.Size(56, 20)
        Me.decTxt.TabIndex = 2
        Me.decTxt.Text = "0"
        '
        'decLabel
        '
        Me.decLabel.AutoSize = True
        Me.decLabel.Location = New System.Drawing.Point(275, 127)
        Me.decLabel.Name = "decLabel"
        Me.decLabel.Size = New System.Drawing.Size(27, 13)
        Me.decLabel.TabIndex = 9
        Me.decLabel.Text = "Dec"
        '
        'WebsitePopup
        '
        Me.WebsitePopup.AutomaticDelay = 200
        Me.WebsitePopup.AutoPopDelay = 5000
        Me.WebsitePopup.InitialDelay = 200
        Me.WebsitePopup.ReshowDelay = 100
        Me.WebsitePopup.ToolTipTitle = "Website:"
        '
        'credCodeNameLabel
        '
        Me.credCodeNameLabel.AutoSize = True
        Me.credCodeNameLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.credCodeNameLabel.Location = New System.Drawing.Point(114, 61)
        Me.credCodeNameLabel.Name = "credCodeNameLabel"
        Me.credCodeNameLabel.Size = New System.Drawing.Size(92, 13)
        Me.credCodeNameLabel.TabIndex = 1
        Me.credCodeNameLabel.Text = "Pierre Bondoerffer"
        Me.WebsitePopup.SetToolTip(Me.credCodeNameLabel, "Xylem Studios" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "http://xylemstudios.com/")
        '
        'credNorskNameLabel
        '
        Me.credNorskNameLabel.AutoSize = True
        Me.credNorskNameLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.credNorskNameLabel.Location = New System.Drawing.Point(114, 93)
        Me.credNorskNameLabel.Name = "credNorskNameLabel"
        Me.credNorskNameLabel.Size = New System.Drawing.Size(58, 13)
        Me.credNorskNameLabel.TabIndex = 1
        Me.credNorskNameLabel.Text = "Jonas Triki"
        Me.WebsitePopup.SetToolTip(Me.credNorskNameLabel, "Triki Technologies" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "http://triki-tech.com/")
        '
        'helpStrip
        '
        Me.helpStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.helpStrip.Name = "helpStrip"
        Me.helpStrip.Size = New System.Drawing.Size(119, 26)
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'newUserPopup
        '
        Me.newUserPopup.IsBalloon = True
        Me.newUserPopup.ShowAlways = True
        Me.newUserPopup.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.newUserPopup.ToolTipTitle = "New feature"
        '
        'creditsTab
        '
        Me.creditsTab.Controls.Add(Me.credNorskLabel)
        Me.creditsTab.Controls.Add(Me.credCodeLabel)
        Me.creditsTab.Controls.Add(Me.credNorskNameLabel)
        Me.creditsTab.Controls.Add(Me.credCodeNameLabel)
        Me.creditsTab.Controls.Add(Me.credVersionLabel)
        Me.creditsTab.Controls.Add(Me.credNameLabel)
        Me.creditsTab.Controls.Add(Me.cuLogo)
        Me.creditsTab.Location = New System.Drawing.Point(4, 22)
        Me.creditsTab.Name = "creditsTab"
        Me.creditsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.creditsTab.Size = New System.Drawing.Size(252, 116)
        Me.creditsTab.TabIndex = 3
        Me.creditsTab.Text = "Credits"
        Me.creditsTab.UseVisualStyleBackColor = True
        '
        'credNorskLabel
        '
        Me.credNorskLabel.AutoSize = True
        Me.credNorskLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.credNorskLabel.Location = New System.Drawing.Point(114, 77)
        Me.credNorskLabel.Name = "credNorskLabel"
        Me.credNorskLabel.Size = New System.Drawing.Size(112, 13)
        Me.credNorskLabel.TabIndex = 1
        Me.credNorskLabel.Text = "Norwegian translation:"
        '
        'credCodeLabel
        '
        Me.credCodeLabel.AutoSize = True
        Me.credCodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.credCodeLabel.Location = New System.Drawing.Point(114, 45)
        Me.credCodeLabel.Name = "credCodeLabel"
        Me.credCodeLabel.Size = New System.Drawing.Size(122, 13)
        Me.credCodeLabel.TabIndex = 1
        Me.credCodeLabel.Text = "Coded and designed by:"
        '
        'credVersionLabel
        '
        Me.credVersionLabel.AutoSize = True
        Me.credVersionLabel.Location = New System.Drawing.Point(114, 24)
        Me.credVersionLabel.Name = "credVersionLabel"
        Me.credVersionLabel.Size = New System.Drawing.Size(61, 13)
        Me.credVersionLabel.TabIndex = 1
        Me.credVersionLabel.Text = "[VERSION]"
        '
        'credNameLabel
        '
        Me.credNameLabel.AutoSize = True
        Me.credNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.credNameLabel.Location = New System.Drawing.Point(114, 8)
        Me.credNameLabel.Name = "credNameLabel"
        Me.credNameLabel.Size = New System.Drawing.Size(84, 16)
        Me.credNameLabel.TabIndex = 1
        Me.credNameLabel.Text = "ColorUtility"
        '
        'cuLogo
        '
        Me.cuLogo.Image = CType(resources.GetObject("cuLogo.Image"), System.Drawing.Image)
        Me.cuLogo.Location = New System.Drawing.Point(8, 8)
        Me.cuLogo.Name = "cuLogo"
        Me.cuLogo.Size = New System.Drawing.Size(100, 100)
        Me.cuLogo.TabIndex = 0
        Me.cuLogo.TabStop = False
        '
        'settingsTab
        '
        Me.settingsTab.AutoScroll = True
        Me.settingsTab.Controls.Add(Me.clipChk)
        Me.settingsTab.Controls.Add(Me.clipLabel)
        Me.settingsTab.Controls.Add(Me.hsvChk)
        Me.settingsTab.Controls.Add(Me.rgbChk)
        Me.settingsTab.Controls.Add(Me.langSet)
        Me.settingsTab.Controls.Add(Me.langCombo)
        Me.settingsTab.Controls.Add(Me.langLabel)
        Me.settingsTab.Controls.Add(Me.spaceLabel)
        Me.settingsTab.Controls.Add(Me.speedLabel)
        Me.settingsTab.Controls.Add(Me.speedChk)
        Me.settingsTab.Location = New System.Drawing.Point(4, 22)
        Me.settingsTab.Name = "settingsTab"
        Me.settingsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.settingsTab.Size = New System.Drawing.Size(252, 116)
        Me.settingsTab.TabIndex = 2
        Me.settingsTab.Text = "Settings"
        Me.settingsTab.UseVisualStyleBackColor = True
        '
        'clipChk
        '
        Me.clipChk.AutoSize = True
        Me.clipChk.Location = New System.Drawing.Point(6, 132)
        Me.clipChk.Name = "clipChk"
        Me.clipChk.Size = New System.Drawing.Size(199, 17)
        Me.clipChk.TabIndex = 7
        Me.clipChk.Text = "Copy Hex to clipboard after selection"
        Me.clipChk.UseVisualStyleBackColor = True
        '
        'clipLabel
        '
        Me.clipLabel.AutoSize = True
        Me.clipLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clipLabel.Location = New System.Drawing.Point(6, 116)
        Me.clipLabel.Name = "clipLabel"
        Me.clipLabel.Size = New System.Drawing.Size(88, 13)
        Me.clipLabel.TabIndex = 0
        Me.clipLabel.Text = "Clipboard options"
        '
        'hsvChk
        '
        Me.hsvChk.AutoSize = True
        Me.hsvChk.Location = New System.Drawing.Point(61, 60)
        Me.hsvChk.Name = "hsvChk"
        Me.hsvChk.Size = New System.Drawing.Size(48, 17)
        Me.hsvChk.TabIndex = 5
        Me.hsvChk.Text = "HSV"
        Me.hsvChk.UseVisualStyleBackColor = True
        '
        'rgbChk
        '
        Me.rgbChk.AutoSize = True
        Me.rgbChk.Location = New System.Drawing.Point(6, 60)
        Me.rgbChk.Name = "rgbChk"
        Me.rgbChk.Size = New System.Drawing.Size(49, 17)
        Me.rgbChk.TabIndex = 4
        Me.rgbChk.Text = "RGB"
        Me.rgbChk.UseVisualStyleBackColor = True
        '
        'langSet
        '
        Me.langSet.Location = New System.Drawing.Point(184, 18)
        Me.langSet.Name = "langSet"
        Me.langSet.Size = New System.Drawing.Size(45, 22)
        Me.langSet.TabIndex = 3
        Me.langSet.Text = "Set"
        Me.langSet.UseVisualStyleBackColor = True
        '
        'langCombo
        '
        Me.langCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.langCombo.FormattingEnabled = True
        Me.langCombo.Items.AddRange(New Object() {"English", "Français", "Español", "Norsk"})
        Me.langCombo.Location = New System.Drawing.Point(6, 19)
        Me.langCombo.Name = "langCombo"
        Me.langCombo.Size = New System.Drawing.Size(172, 21)
        Me.langCombo.TabIndex = 2
        '
        'langLabel
        '
        Me.langLabel.AutoSize = True
        Me.langLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.langLabel.Location = New System.Drawing.Point(6, 3)
        Me.langLabel.Name = "langLabel"
        Me.langLabel.Size = New System.Drawing.Size(55, 13)
        Me.langLabel.TabIndex = 0
        Me.langLabel.Text = "Language"
        '
        'spaceLabel
        '
        Me.spaceLabel.AutoSize = True
        Me.spaceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spaceLabel.Location = New System.Drawing.Point(6, 43)
        Me.spaceLabel.Name = "spaceLabel"
        Me.spaceLabel.Size = New System.Drawing.Size(68, 13)
        Me.spaceLabel.TabIndex = 0
        Me.spaceLabel.Text = "Color spaces"
        '
        'speedLabel
        '
        Me.speedLabel.AutoSize = True
        Me.speedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.speedLabel.Location = New System.Drawing.Point(6, 80)
        Me.speedLabel.Name = "speedLabel"
        Me.speedLabel.Size = New System.Drawing.Size(75, 13)
        Me.speedLabel.TabIndex = 0
        Me.speedLabel.Text = "Speed options"
        '
        'speedChk
        '
        Me.speedChk.AutoSize = True
        Me.speedChk.Location = New System.Drawing.Point(6, 96)
        Me.speedChk.Name = "speedChk"
        Me.speedChk.Size = New System.Drawing.Size(189, 17)
        Me.speedChk.TabIndex = 6
        Me.speedChk.Text = "Optimize speed for slow computers"
        Me.speedChk.UseVisualStyleBackColor = True
        '
        'othertoolsTab
        '
        Me.othertoolsTab.Controls.Add(Me.toolDesc)
        Me.othertoolsTab.Controls.Add(Me.toolLabel)
        Me.othertoolsTab.Controls.Add(Me.tool_panel)
        Me.othertoolsTab.Location = New System.Drawing.Point(4, 22)
        Me.othertoolsTab.Name = "othertoolsTab"
        Me.othertoolsTab.Size = New System.Drawing.Size(252, 116)
        Me.othertoolsTab.TabIndex = 4
        Me.othertoolsTab.Text = "Other tools"
        Me.othertoolsTab.UseVisualStyleBackColor = True
        '
        'toolDesc
        '
        Me.toolDesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.toolDesc.Location = New System.Drawing.Point(139, 21)
        Me.toolDesc.Name = "toolDesc"
        Me.toolDesc.Size = New System.Drawing.Size(107, 89)
        Me.toolDesc.TabIndex = 3
        Me.toolDesc.Text = "..."
        '
        'toolLabel
        '
        Me.toolLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.toolLabel.AutoSize = True
        Me.toolLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolLabel.Location = New System.Drawing.Point(139, 6)
        Me.toolLabel.Name = "toolLabel"
        Me.toolLabel.Size = New System.Drawing.Size(98, 13)
        Me.toolLabel.TabIndex = 2
        Me.toolLabel.Text = "Tool description"
        '
        'tool_panel
        '
        Me.tool_panel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tool_panel.AutoScroll = True
        Me.tool_panel.Controls.Add(Me.t_colorsImageBtn)
        Me.tool_panel.Controls.Add(Me.t_combinerBtn)
        Me.tool_panel.Controls.Add(Me.t_randomBtn)
        Me.tool_panel.Location = New System.Drawing.Point(3, 6)
        Me.tool_panel.Name = "tool_panel"
        Me.tool_panel.Size = New System.Drawing.Size(130, 107)
        Me.tool_panel.TabIndex = 1
        '
        't_colorsImageBtn
        '
        Me.t_colorsImageBtn.Location = New System.Drawing.Point(4, 100)
        Me.t_colorsImageBtn.Name = "t_colorsImageBtn"
        Me.t_colorsImageBtn.Size = New System.Drawing.Size(105, 49)
        Me.t_colorsImageBtn.TabIndex = 1
        Me.t_colorsImageBtn.Text = "Get all colors" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in an image"
        Me.t_colorsImageBtn.UseVisualStyleBackColor = True
        '
        't_combinerBtn
        '
        Me.t_combinerBtn.Location = New System.Drawing.Point(4, 4)
        Me.t_combinerBtn.Name = "t_combinerBtn"
        Me.t_combinerBtn.Size = New System.Drawing.Size(105, 42)
        Me.t_combinerBtn.TabIndex = 0
        Me.t_combinerBtn.Text = "Color combiner"
        Me.t_combinerBtn.UseVisualStyleBackColor = True
        '
        't_randomBtn
        '
        Me.t_randomBtn.Location = New System.Drawing.Point(4, 52)
        Me.t_randomBtn.Name = "t_randomBtn"
        Me.t_randomBtn.Size = New System.Drawing.Size(105, 42)
        Me.t_randomBtn.TabIndex = 0
        Me.t_randomBtn.Text = "Advanced" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "random color"
        Me.t_randomBtn.UseVisualStyleBackColor = True
        '
        'filtersTab
        '
        Me.filtersTab.Controls.Add(Me.filterDesc)
        Me.filtersTab.Controls.Add(Me.filterLabel)
        Me.filtersTab.Controls.Add(Me.filtersPanel)
        Me.filtersTab.Location = New System.Drawing.Point(4, 22)
        Me.filtersTab.Name = "filtersTab"
        Me.filtersTab.Padding = New System.Windows.Forms.Padding(3)
        Me.filtersTab.Size = New System.Drawing.Size(252, 116)
        Me.filtersTab.TabIndex = 1
        Me.filtersTab.Text = "Filters"
        Me.filtersTab.UseVisualStyleBackColor = True
        '
        'filterDesc
        '
        Me.filterDesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.filterDesc.Location = New System.Drawing.Point(139, 21)
        Me.filterDesc.Name = "filterDesc"
        Me.filterDesc.Size = New System.Drawing.Size(107, 92)
        Me.filterDesc.TabIndex = 1
        Me.filterDesc.Text = "..."
        '
        'filterLabel
        '
        Me.filterLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.filterLabel.AutoSize = True
        Me.filterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filterLabel.Location = New System.Drawing.Point(139, 6)
        Me.filterLabel.Name = "filterLabel"
        Me.filterLabel.Size = New System.Drawing.Size(101, 13)
        Me.filterLabel.TabIndex = 1
        Me.filterLabel.Text = "Filter description"
        '
        'filtersPanel
        '
        Me.filtersPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.filtersPanel.AutoScroll = True
        Me.filtersPanel.Controls.Add(Me.f_rgbShuffleBtn)
        Me.filtersPanel.Controls.Add(Me.f_intensifyBtn)
        Me.filtersPanel.Controls.Add(Me.f_blueBtn)
        Me.filtersPanel.Controls.Add(Me.f_greenBtn)
        Me.filtersPanel.Controls.Add(Me.f_darkerBtn)
        Me.filtersPanel.Controls.Add(Me.f_redBtn)
        Me.filtersPanel.Controls.Add(Me.f_brighterBtn)
        Me.filtersPanel.Controls.Add(Me.f_sepiaBtn)
        Me.filtersPanel.Controls.Add(Me.f_negativeBtn)
        Me.filtersPanel.Controls.Add(Me.f_grayBtn)
        Me.filtersPanel.Location = New System.Drawing.Point(3, 6)
        Me.filtersPanel.Name = "filtersPanel"
        Me.filtersPanel.Size = New System.Drawing.Size(130, 107)
        Me.filtersPanel.TabIndex = 0
        '
        'f_rgbShuffleBtn
        '
        Me.f_rgbShuffleBtn.Location = New System.Drawing.Point(3, 264)
        Me.f_rgbShuffleBtn.Name = "f_rgbShuffleBtn"
        Me.f_rgbShuffleBtn.Size = New System.Drawing.Size(105, 23)
        Me.f_rgbShuffleBtn.TabIndex = 12
        Me.f_rgbShuffleBtn.Text = "RGB Shuffle"
        Me.f_rgbShuffleBtn.UseVisualStyleBackColor = True
        '
        'f_intensifyBtn
        '
        Me.f_intensifyBtn.Location = New System.Drawing.Point(3, 61)
        Me.f_intensifyBtn.Name = "f_intensifyBtn"
        Me.f_intensifyBtn.Size = New System.Drawing.Size(105, 23)
        Me.f_intensifyBtn.TabIndex = 5
        Me.f_intensifyBtn.Text = "Intensify"
        Me.f_intensifyBtn.UseVisualStyleBackColor = True
        '
        'f_blueBtn
        '
        Me.f_blueBtn.Location = New System.Drawing.Point(3, 235)
        Me.f_blueBtn.Name = "f_blueBtn"
        Me.f_blueBtn.Size = New System.Drawing.Size(105, 23)
        Me.f_blueBtn.TabIndex = 11
        Me.f_blueBtn.Text = "Blue only"
        Me.f_blueBtn.UseVisualStyleBackColor = True
        '
        'f_greenBtn
        '
        Me.f_greenBtn.Location = New System.Drawing.Point(3, 206)
        Me.f_greenBtn.Name = "f_greenBtn"
        Me.f_greenBtn.Size = New System.Drawing.Size(105, 23)
        Me.f_greenBtn.TabIndex = 10
        Me.f_greenBtn.Text = "Green only"
        Me.f_greenBtn.UseVisualStyleBackColor = True
        '
        'f_darkerBtn
        '
        Me.f_darkerBtn.Location = New System.Drawing.Point(3, 148)
        Me.f_darkerBtn.Name = "f_darkerBtn"
        Me.f_darkerBtn.Size = New System.Drawing.Size(105, 23)
        Me.f_darkerBtn.TabIndex = 8
        Me.f_darkerBtn.Text = "Darker"
        Me.f_darkerBtn.UseVisualStyleBackColor = True
        '
        'f_redBtn
        '
        Me.f_redBtn.Location = New System.Drawing.Point(3, 177)
        Me.f_redBtn.Name = "f_redBtn"
        Me.f_redBtn.Size = New System.Drawing.Size(105, 23)
        Me.f_redBtn.TabIndex = 9
        Me.f_redBtn.Text = "Red only"
        Me.f_redBtn.UseVisualStyleBackColor = True
        '
        'f_brighterBtn
        '
        Me.f_brighterBtn.Location = New System.Drawing.Point(3, 119)
        Me.f_brighterBtn.Name = "f_brighterBtn"
        Me.f_brighterBtn.Size = New System.Drawing.Size(105, 23)
        Me.f_brighterBtn.TabIndex = 7
        Me.f_brighterBtn.Text = "Brighter"
        Me.f_brighterBtn.UseVisualStyleBackColor = True
        '
        'f_sepiaBtn
        '
        Me.f_sepiaBtn.Location = New System.Drawing.Point(3, 90)
        Me.f_sepiaBtn.Name = "f_sepiaBtn"
        Me.f_sepiaBtn.Size = New System.Drawing.Size(105, 23)
        Me.f_sepiaBtn.TabIndex = 6
        Me.f_sepiaBtn.Text = "Sepia"
        Me.f_sepiaBtn.UseVisualStyleBackColor = True
        '
        'f_negativeBtn
        '
        Me.f_negativeBtn.Location = New System.Drawing.Point(3, 32)
        Me.f_negativeBtn.Name = "f_negativeBtn"
        Me.f_negativeBtn.Size = New System.Drawing.Size(105, 23)
        Me.f_negativeBtn.TabIndex = 1
        Me.f_negativeBtn.Text = "Negative"
        Me.f_negativeBtn.UseVisualStyleBackColor = True
        '
        'f_grayBtn
        '
        Me.f_grayBtn.Location = New System.Drawing.Point(3, 3)
        Me.f_grayBtn.Name = "f_grayBtn"
        Me.f_grayBtn.Size = New System.Drawing.Size(105, 23)
        Me.f_grayBtn.TabIndex = 0
        Me.f_grayBtn.Text = "Grayscale"
        Me.f_grayBtn.UseVisualStyleBackColor = True
        '
        'rgbTab
        '
        Me.rgbTab.Controls.Add(Me.blue_txt)
        Me.rgbTab.Controls.Add(Me.green_txt)
        Me.rgbTab.Controls.Add(Me.red_txt)
        Me.rgbTab.Controls.Add(Me.blue_pic)
        Me.rgbTab.Controls.Add(Me.green_pic)
        Me.rgbTab.Controls.Add(Me.green_bar)
        Me.rgbTab.Controls.Add(Me.red_pic)
        Me.rgbTab.Controls.Add(Me.red_bar)
        Me.rgbTab.Controls.Add(Me.b_label)
        Me.rgbTab.Controls.Add(Me.g_label)
        Me.rgbTab.Controls.Add(Me.r_label)
        Me.rgbTab.Controls.Add(Me.blue_bar)
        Me.rgbTab.Location = New System.Drawing.Point(4, 22)
        Me.rgbTab.Name = "rgbTab"
        Me.rgbTab.Padding = New System.Windows.Forms.Padding(3)
        Me.rgbTab.Size = New System.Drawing.Size(252, 116)
        Me.rgbTab.TabIndex = 0
        Me.rgbTab.Text = "RGB"
        Me.rgbTab.UseVisualStyleBackColor = True
        '
        'blue_txt
        '
        Me.blue_txt.Location = New System.Drawing.Point(213, 82)
        Me.blue_txt.MaxLength = 3
        Me.blue_txt.Name = "blue_txt"
        Me.blue_txt.Size = New System.Drawing.Size(27, 20)
        Me.blue_txt.TabIndex = 6
        Me.blue_txt.Text = "0"
        '
        'green_txt
        '
        Me.green_txt.Location = New System.Drawing.Point(213, 47)
        Me.green_txt.MaxLength = 3
        Me.green_txt.Name = "green_txt"
        Me.green_txt.Size = New System.Drawing.Size(27, 20)
        Me.green_txt.TabIndex = 4
        Me.green_txt.Text = "0"
        '
        'red_txt
        '
        Me.red_txt.Location = New System.Drawing.Point(213, 14)
        Me.red_txt.MaxLength = 3
        Me.red_txt.Name = "red_txt"
        Me.red_txt.Size = New System.Drawing.Size(27, 20)
        Me.red_txt.TabIndex = 2
        Me.red_txt.Text = "0"
        '
        'blue_pic
        '
        Me.blue_pic.Location = New System.Drawing.Point(36, 81)
        Me.blue_pic.Name = "blue_pic"
        Me.blue_pic.Size = New System.Drawing.Size(168, 10)
        Me.blue_pic.TabIndex = 14
        Me.blue_pic.TabStop = False
        '
        'green_pic
        '
        Me.green_pic.Location = New System.Drawing.Point(36, 44)
        Me.green_pic.Name = "green_pic"
        Me.green_pic.Size = New System.Drawing.Size(168, 10)
        Me.green_pic.TabIndex = 15
        Me.green_pic.TabStop = False
        '
        'green_bar
        '
        Me.green_bar.BackColor = System.Drawing.SystemColors.Window
        Me.green_bar.Location = New System.Drawing.Point(23, 45)
        Me.green_bar.Maximum = 255
        Me.green_bar.Name = "green_bar"
        Me.green_bar.Size = New System.Drawing.Size(194, 45)
        Me.green_bar.SmallChange = 50
        Me.green_bar.TabIndex = 3
        Me.green_bar.TickFrequency = 50
        Me.green_bar.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'red_pic
        '
        Me.red_pic.Location = New System.Drawing.Point(36, 8)
        Me.red_pic.Name = "red_pic"
        Me.red_pic.Size = New System.Drawing.Size(168, 10)
        Me.red_pic.TabIndex = 13
        Me.red_pic.TabStop = False
        '
        'red_bar
        '
        Me.red_bar.BackColor = System.Drawing.SystemColors.Window
        Me.red_bar.Location = New System.Drawing.Point(23, 9)
        Me.red_bar.Maximum = 255
        Me.red_bar.Name = "red_bar"
        Me.red_bar.Size = New System.Drawing.Size(194, 45)
        Me.red_bar.TabIndex = 1
        Me.red_bar.TickFrequency = 50
        Me.red_bar.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'b_label
        '
        Me.b_label.AutoSize = True
        Me.b_label.Location = New System.Drawing.Point(11, 85)
        Me.b_label.Name = "b_label"
        Me.b_label.Size = New System.Drawing.Size(14, 13)
        Me.b_label.TabIndex = 0
        Me.b_label.Text = "B"
        '
        'g_label
        '
        Me.g_label.AutoSize = True
        Me.g_label.Location = New System.Drawing.Point(11, 50)
        Me.g_label.Name = "g_label"
        Me.g_label.Size = New System.Drawing.Size(15, 13)
        Me.g_label.TabIndex = 0
        Me.g_label.Text = "G"
        '
        'r_label
        '
        Me.r_label.AutoSize = True
        Me.r_label.Location = New System.Drawing.Point(11, 17)
        Me.r_label.Name = "r_label"
        Me.r_label.Size = New System.Drawing.Size(15, 13)
        Me.r_label.TabIndex = 0
        Me.r_label.Text = "R"
        '
        'blue_bar
        '
        Me.blue_bar.BackColor = System.Drawing.SystemColors.Window
        Me.blue_bar.Location = New System.Drawing.Point(23, 82)
        Me.blue_bar.Maximum = 255
        Me.blue_bar.Name = "blue_bar"
        Me.blue_bar.Size = New System.Drawing.Size(194, 45)
        Me.blue_bar.SmallChange = 50
        Me.blue_bar.TabIndex = 5
        Me.blue_bar.TickFrequency = 50
        Me.blue_bar.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.rgbTab)
        Me.TabControl1.Controls.Add(Me.hsvTab)
        Me.TabControl1.Controls.Add(Me.filtersTab)
        Me.TabControl1.Controls.Add(Me.othertoolsTab)
        Me.TabControl1.Controls.Add(Me.settingsTab)
        Me.TabControl1.Controls.Add(Me.creditsTab)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(260, 142)
        Me.TabControl1.TabIndex = 6
        '
        'hsvTab
        '
        Me.hsvTab.Controls.Add(Me.value_txt)
        Me.hsvTab.Controls.Add(Me.saturation_txt)
        Me.hsvTab.Controls.Add(Me.hue_txt)
        Me.hsvTab.Controls.Add(Me.value_pic)
        Me.hsvTab.Controls.Add(Me.saturation_pic)
        Me.hsvTab.Controls.Add(Me.saturation_bar)
        Me.hsvTab.Controls.Add(Me.hue_pic)
        Me.hsvTab.Controls.Add(Me.hue_bar)
        Me.hsvTab.Controls.Add(Me.v_label)
        Me.hsvTab.Controls.Add(Me.s_label)
        Me.hsvTab.Controls.Add(Me.h_label)
        Me.hsvTab.Controls.Add(Me.value_bar)
        Me.hsvTab.Location = New System.Drawing.Point(4, 22)
        Me.hsvTab.Name = "hsvTab"
        Me.hsvTab.Padding = New System.Windows.Forms.Padding(3)
        Me.hsvTab.Size = New System.Drawing.Size(252, 116)
        Me.hsvTab.TabIndex = 5
        Me.hsvTab.Text = "HSV"
        Me.hsvTab.UseVisualStyleBackColor = True
        '
        'value_txt
        '
        Me.value_txt.Location = New System.Drawing.Point(213, 82)
        Me.value_txt.MaxLength = 3
        Me.value_txt.Name = "value_txt"
        Me.value_txt.Size = New System.Drawing.Size(27, 20)
        Me.value_txt.TabIndex = 24
        Me.value_txt.Text = "0"
        '
        'saturation_txt
        '
        Me.saturation_txt.Location = New System.Drawing.Point(213, 47)
        Me.saturation_txt.MaxLength = 3
        Me.saturation_txt.Name = "saturation_txt"
        Me.saturation_txt.Size = New System.Drawing.Size(27, 20)
        Me.saturation_txt.TabIndex = 4
        Me.saturation_txt.Text = "0"
        '
        'hue_txt
        '
        Me.hue_txt.Location = New System.Drawing.Point(213, 14)
        Me.hue_txt.MaxLength = 3
        Me.hue_txt.Name = "hue_txt"
        Me.hue_txt.Size = New System.Drawing.Size(27, 20)
        Me.hue_txt.TabIndex = 2
        Me.hue_txt.Text = "0"
        '
        'value_pic
        '
        Me.value_pic.Location = New System.Drawing.Point(36, 81)
        Me.value_pic.Name = "value_pic"
        Me.value_pic.Size = New System.Drawing.Size(168, 10)
        Me.value_pic.TabIndex = 26
        Me.value_pic.TabStop = False
        '
        'saturation_pic
        '
        Me.saturation_pic.Location = New System.Drawing.Point(36, 44)
        Me.saturation_pic.Name = "saturation_pic"
        Me.saturation_pic.Size = New System.Drawing.Size(168, 10)
        Me.saturation_pic.TabIndex = 27
        Me.saturation_pic.TabStop = False
        '
        'saturation_bar
        '
        Me.saturation_bar.BackColor = System.Drawing.SystemColors.Window
        Me.saturation_bar.Location = New System.Drawing.Point(23, 45)
        Me.saturation_bar.Maximum = 100
        Me.saturation_bar.Name = "saturation_bar"
        Me.saturation_bar.Size = New System.Drawing.Size(194, 45)
        Me.saturation_bar.TabIndex = 3
        Me.saturation_bar.TickFrequency = 50
        Me.saturation_bar.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'hue_pic
        '
        Me.hue_pic.Image = Global.ColorUtility.My.Resources.Resources.huegradient
        Me.hue_pic.Location = New System.Drawing.Point(36, 8)
        Me.hue_pic.Name = "hue_pic"
        Me.hue_pic.Size = New System.Drawing.Size(168, 10)
        Me.hue_pic.TabIndex = 25
        Me.hue_pic.TabStop = False
        '
        'hue_bar
        '
        Me.hue_bar.BackColor = System.Drawing.SystemColors.Window
        Me.hue_bar.Location = New System.Drawing.Point(23, 9)
        Me.hue_bar.Maximum = 360
        Me.hue_bar.Name = "hue_bar"
        Me.hue_bar.Size = New System.Drawing.Size(194, 45)
        Me.hue_bar.TabIndex = 1
        Me.hue_bar.TickFrequency = 50
        Me.hue_bar.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'v_label
        '
        Me.v_label.AutoSize = True
        Me.v_label.Location = New System.Drawing.Point(11, 85)
        Me.v_label.Name = "v_label"
        Me.v_label.Size = New System.Drawing.Size(14, 13)
        Me.v_label.TabIndex = 0
        Me.v_label.Text = "V"
        '
        's_label
        '
        Me.s_label.AutoSize = True
        Me.s_label.Location = New System.Drawing.Point(11, 50)
        Me.s_label.Name = "s_label"
        Me.s_label.Size = New System.Drawing.Size(14, 13)
        Me.s_label.TabIndex = 0
        Me.s_label.Text = "S"
        '
        'h_label
        '
        Me.h_label.AutoSize = True
        Me.h_label.Location = New System.Drawing.Point(11, 17)
        Me.h_label.Name = "h_label"
        Me.h_label.Size = New System.Drawing.Size(15, 13)
        Me.h_label.TabIndex = 0
        Me.h_label.Text = "H"
        '
        'value_bar
        '
        Me.value_bar.BackColor = System.Drawing.SystemColors.Window
        Me.value_bar.Location = New System.Drawing.Point(23, 82)
        Me.value_bar.Maximum = 100
        Me.value_bar.Name = "value_bar"
        Me.value_bar.Size = New System.Drawing.Size(194, 45)
        Me.value_bar.TabIndex = 5
        Me.value_bar.TickFrequency = 50
        Me.value_bar.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'xylemLogo
        '
        Me.xylemLogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.xylemLogo.Image = CType(resources.GetObject("xylemLogo.Image"), System.Drawing.Image)
        Me.xylemLogo.Location = New System.Drawing.Point(12, 160)
        Me.xylemLogo.Name = "xylemLogo"
        Me.xylemLogo.Size = New System.Drawing.Size(80, 22)
        Me.xylemLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.xylemLogo.TabIndex = 5
        Me.xylemLogo.TabStop = False
        '
        'webColorBtn
        '
        Me.webColorBtn.Image = CType(resources.GetObject("webColorBtn.Image"), System.Drawing.Image)
        Me.webColorBtn.Location = New System.Drawing.Point(303, 157)
        Me.webColorBtn.Name = "webColorBtn"
        Me.webColorBtn.Size = New System.Drawing.Size(26, 26)
        Me.webColorBtn.TabIndex = 4
        Me.webColorBtn.TabStop = False
        Me.webColorBtn.UseVisualStyleBackColor = True
        '
        'colorPickerBtn
        '
        Me.colorPickerBtn.Image = CType(resources.GetObject("colorPickerBtn.Image"), System.Drawing.Image)
        Me.colorPickerBtn.Location = New System.Drawing.Point(275, 157)
        Me.colorPickerBtn.Name = "colorPickerBtn"
        Me.colorPickerBtn.Size = New System.Drawing.Size(26, 26)
        Me.colorPickerBtn.TabIndex = 3
        Me.colorPickerBtn.UseVisualStyleBackColor = True
        '
        'randomColorBtn
        '
        Me.randomColorBtn.Image = CType(resources.GetObject("randomColorBtn.Image"), System.Drawing.Image)
        Me.randomColorBtn.Location = New System.Drawing.Point(331, 157)
        Me.randomColorBtn.Name = "randomColorBtn"
        Me.randomColorBtn.Size = New System.Drawing.Size(26, 26)
        Me.randomColorBtn.TabIndex = 5
        Me.randomColorBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 188)
        Me.Controls.Add(Me.decTxt)
        Me.Controls.Add(Me.decLabel)
        Me.Controls.Add(Me.copyrightLabel)
        Me.Controls.Add(Me.xylemLogo)
        Me.Controls.Add(Me.hexTxt)
        Me.Controls.Add(Me.colorPanel)
        Me.Controls.Add(Me.hexLabel)
        Me.Controls.Add(Me.webColorBtn)
        Me.Controls.Add(Me.colorPickerBtn)
        Me.Controls.Add(Me.randomColorBtn)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ColorUtility"
        Me.CopyStrip.ResumeLayout(False)
        Me.helpStrip.ResumeLayout(False)
        Me.creditsTab.ResumeLayout(False)
        Me.creditsTab.PerformLayout()
        CType(Me.cuLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.settingsTab.ResumeLayout(False)
        Me.settingsTab.PerformLayout()
        Me.othertoolsTab.ResumeLayout(False)
        Me.othertoolsTab.PerformLayout()
        Me.tool_panel.ResumeLayout(False)
        Me.filtersTab.ResumeLayout(False)
        Me.filtersTab.PerformLayout()
        Me.filtersPanel.ResumeLayout(False)
        Me.rgbTab.ResumeLayout(False)
        Me.rgbTab.PerformLayout()
        CType(Me.blue_pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.green_pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.green_bar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.red_pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.red_bar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.blue_bar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.hsvTab.ResumeLayout(False)
        Me.hsvTab.PerformLayout()
        CType(Me.value_pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.saturation_pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.saturation_bar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hue_pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hue_bar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.value_bar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xylemLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents hexLabel As System.Windows.Forms.Label
    Friend WithEvents colorPanel As System.Windows.Forms.Panel
    Friend WithEvents hexTxt As System.Windows.Forms.TextBox
    Friend WithEvents xylemLogo As System.Windows.Forms.PictureBox
    Friend WithEvents copyrightLabel As System.Windows.Forms.Label
    Friend WithEvents webColorBtn As System.Windows.Forms.Button
    Friend WithEvents randomColorBtn As System.Windows.Forms.Button
    Friend WithEvents InfoPopup As System.Windows.Forms.ToolTip
    Friend WithEvents decTxt As System.Windows.Forms.TextBox
    Friend WithEvents decLabel As System.Windows.Forms.Label
    Friend WithEvents WebsitePopup As System.Windows.Forms.ToolTip
    Friend WithEvents helpStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents newUserPopup As System.Windows.Forms.ToolTip
    Friend WithEvents creditsTab As System.Windows.Forms.TabPage
    Friend WithEvents credNorskLabel As System.Windows.Forms.Label
    Friend WithEvents credCodeLabel As System.Windows.Forms.Label
    Friend WithEvents credNorskNameLabel As System.Windows.Forms.Label
    Friend WithEvents credCodeNameLabel As System.Windows.Forms.Label
    Friend WithEvents credVersionLabel As System.Windows.Forms.Label
    Friend WithEvents credNameLabel As System.Windows.Forms.Label
    Friend WithEvents cuLogo As System.Windows.Forms.PictureBox
    Friend WithEvents settingsTab As System.Windows.Forms.TabPage
    Friend WithEvents langSet As System.Windows.Forms.Button
    Friend WithEvents langCombo As System.Windows.Forms.ComboBox
    Friend WithEvents langLabel As System.Windows.Forms.Label
    Friend WithEvents speedLabel As System.Windows.Forms.Label
    Friend WithEvents speedChk As System.Windows.Forms.CheckBox
    Friend WithEvents othertoolsTab As System.Windows.Forms.TabPage
    Friend WithEvents toolDesc As System.Windows.Forms.Label
    Friend WithEvents toolLabel As System.Windows.Forms.Label
    Friend WithEvents tool_panel As System.Windows.Forms.Panel
    Friend WithEvents t_randomBtn As System.Windows.Forms.Button
    Friend WithEvents t_combinerBtn As System.Windows.Forms.Button
    Friend WithEvents filtersTab As System.Windows.Forms.TabPage
    Friend WithEvents filterDesc As System.Windows.Forms.Label
    Friend WithEvents filterLabel As System.Windows.Forms.Label
    Friend WithEvents filtersPanel As System.Windows.Forms.Panel
    Friend WithEvents f_blueBtn As System.Windows.Forms.Button
    Friend WithEvents f_greenBtn As System.Windows.Forms.Button
    Friend WithEvents f_darkerBtn As System.Windows.Forms.Button
    Friend WithEvents f_redBtn As System.Windows.Forms.Button
    Friend WithEvents f_brighterBtn As System.Windows.Forms.Button
    Friend WithEvents f_sepiaBtn As System.Windows.Forms.Button
    Friend WithEvents f_negativeBtn As System.Windows.Forms.Button
    Friend WithEvents f_grayBtn As System.Windows.Forms.Button
    Friend WithEvents rgbTab As System.Windows.Forms.TabPage
    Friend WithEvents blue_txt As System.Windows.Forms.TextBox
    Friend WithEvents green_txt As System.Windows.Forms.TextBox
    Friend WithEvents red_txt As System.Windows.Forms.TextBox
    Friend WithEvents green_bar As System.Windows.Forms.TrackBar
    Friend WithEvents red_bar As System.Windows.Forms.TrackBar
    Friend WithEvents b_label As System.Windows.Forms.Label
    Friend WithEvents g_label As System.Windows.Forms.Label
    Friend WithEvents r_label As System.Windows.Forms.Label
    Friend WithEvents blue_bar As System.Windows.Forms.TrackBar
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents f_intensifyBtn As System.Windows.Forms.Button
    Friend WithEvents colorPickerBtn As System.Windows.Forms.Button
    Friend WithEvents CopyStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyVBNetColorFromArgbToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyHexForVBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents f_rgbShuffleBtn As System.Windows.Forms.Button
    Friend WithEvents t_colorsImageBtn As System.Windows.Forms.Button
    Friend WithEvents CopyForWinFormsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyForCSSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents blue_pic As System.Windows.Forms.PictureBox
    Friend WithEvents green_pic As System.Windows.Forms.PictureBox
    Friend WithEvents red_pic As System.Windows.Forms.PictureBox
    Friend WithEvents hsvTab As System.Windows.Forms.TabPage
    Friend WithEvents value_txt As System.Windows.Forms.TextBox
    Friend WithEvents saturation_txt As System.Windows.Forms.TextBox
    Friend WithEvents hue_txt As System.Windows.Forms.TextBox
    Friend WithEvents value_pic As System.Windows.Forms.PictureBox
    Friend WithEvents saturation_pic As System.Windows.Forms.PictureBox
    Friend WithEvents saturation_bar As System.Windows.Forms.TrackBar
    Friend WithEvents hue_pic As System.Windows.Forms.PictureBox
    Friend WithEvents hue_bar As System.Windows.Forms.TrackBar
    Friend WithEvents v_label As System.Windows.Forms.Label
    Friend WithEvents s_label As System.Windows.Forms.Label
    Friend WithEvents h_label As System.Windows.Forms.Label
    Friend WithEvents value_bar As System.Windows.Forms.TrackBar
    Friend WithEvents CopyHexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyHSVToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents hsvChk As System.Windows.Forms.CheckBox
    Friend WithEvents rgbChk As System.Windows.Forms.CheckBox
    Friend WithEvents spaceLabel As System.Windows.Forms.Label
    Friend WithEvents clipChk As System.Windows.Forms.CheckBox
    Friend WithEvents clipLabel As System.Windows.Forms.Label

End Class
