<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdvancedRandomColorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdvancedRandomColorForm))
        Me.grayChk = New System.Windows.Forms.CheckBox()
        Me.generateButton = New System.Windows.Forms.Button()
        Me.colorPanel = New System.Windows.Forms.Panel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.selectButton = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.simpleTab = New System.Windows.Forms.TabPage()
        Me.hsvPnl = New System.Windows.Forms.Panel()
        Me.satChk = New System.Windows.Forms.CheckBox()
        Me.valueChk = New System.Windows.Forms.CheckBox()
        Me.rgbPnl = New System.Windows.Forms.Panel()
        Me.redChk = New System.Windows.Forms.CheckBox()
        Me.greenChk = New System.Windows.Forms.CheckBox()
        Me.blueChk = New System.Windows.Forms.CheckBox()
        Me.advancedTab = New System.Windows.Forms.TabPage()
        Me.Arrow1 = New System.Windows.Forms.Label()
        Me.redLabel = New System.Windows.Forms.Label()
        Me.toOne = New System.Windows.Forms.TextBox()
        Me.fromOne = New System.Windows.Forms.TextBox()
        Me.advPanel = New System.Windows.Forms.Panel()
        Me.blueLabel = New System.Windows.Forms.Label()
        Me.greenLabel = New System.Windows.Forms.Label()
        Me.Arrow3 = New System.Windows.Forms.Label()
        Me.Arrow2 = New System.Windows.Forms.Label()
        Me.toThree = New System.Windows.Forms.TextBox()
        Me.fromThree = New System.Windows.Forms.TextBox()
        Me.toTwo = New System.Windows.Forms.TextBox()
        Me.fromTwo = New System.Windows.Forms.TextBox()
        Me.websafeChk = New System.Windows.Forms.CheckBox()
        Me.rgbRadio = New System.Windows.Forms.RadioButton()
        Me.hsvRadio = New System.Windows.Forms.RadioButton()
        Me.outputLabel = New System.Windows.Forms.Label()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.simpleTab.SuspendLayout()
        Me.hsvPnl.SuspendLayout()
        Me.rgbPnl.SuspendLayout()
        Me.advancedTab.SuspendLayout()
        Me.advPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'grayChk
        '
        Me.grayChk.AutoSize = True
        Me.grayChk.Location = New System.Drawing.Point(229, 69)
        Me.grayChk.Name = "grayChk"
        Me.grayChk.Size = New System.Drawing.Size(73, 17)
        Me.grayChk.TabIndex = 3
        Me.grayChk.Text = "Grayscale"
        Me.grayChk.UseVisualStyleBackColor = True
        '
        'generateButton
        '
        Me.generateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.generateButton.Location = New System.Drawing.Point(325, 117)
        Me.generateButton.Name = "generateButton"
        Me.generateButton.Size = New System.Drawing.Size(75, 23)
        Me.generateButton.TabIndex = 5
        Me.generateButton.Text = "Generate"
        Me.generateButton.UseVisualStyleBackColor = True
        '
        'colorPanel
        '
        Me.colorPanel.Location = New System.Drawing.Point(344, 42)
        Me.colorPanel.Name = "colorPanel"
        Me.colorPanel.Size = New System.Drawing.Size(56, 56)
        Me.colorPanel.TabIndex = 0
        '
        'selectButton
        '
        Me.selectButton.Enabled = False
        Me.selectButton.Location = New System.Drawing.Point(195, 117)
        Me.selectButton.Name = "selectButton"
        Me.selectButton.Size = New System.Drawing.Size(124, 23)
        Me.selectButton.TabIndex = 6
        Me.selectButton.Text = "Select and close"
        Me.selectButton.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.simpleTab)
        Me.TabControl1.Controls.Add(Me.advancedTab)
        Me.TabControl1.Location = New System.Drawing.Point(8, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(215, 100)
        Me.TabControl1.TabIndex = 8
        '
        'simpleTab
        '
        Me.simpleTab.Controls.Add(Me.hsvPnl)
        Me.simpleTab.Controls.Add(Me.rgbPnl)
        Me.simpleTab.Location = New System.Drawing.Point(4, 22)
        Me.simpleTab.Name = "simpleTab"
        Me.simpleTab.Padding = New System.Windows.Forms.Padding(3)
        Me.simpleTab.Size = New System.Drawing.Size(207, 74)
        Me.simpleTab.TabIndex = 0
        Me.simpleTab.Text = "Simple"
        Me.simpleTab.UseVisualStyleBackColor = True
        '
        'hsvPnl
        '
        Me.hsvPnl.Controls.Add(Me.satChk)
        Me.hsvPnl.Controls.Add(Me.valueChk)
        Me.hsvPnl.Enabled = False
        Me.hsvPnl.Location = New System.Drawing.Point(103, 5)
        Me.hsvPnl.Name = "hsvPnl"
        Me.hsvPnl.Size = New System.Drawing.Size(91, 63)
        Me.hsvPnl.TabIndex = 10
        '
        'satChk
        '
        Me.satChk.AutoSize = True
        Me.satChk.Location = New System.Drawing.Point(0, 0)
        Me.satChk.Name = "satChk"
        Me.satChk.Size = New System.Drawing.Size(97, 17)
        Me.satChk.TabIndex = 0
        Me.satChk.Text = "High saturation"
        Me.satChk.UseVisualStyleBackColor = True
        '
        'valueChk
        '
        Me.valueChk.AutoSize = True
        Me.valueChk.Location = New System.Drawing.Point(0, 23)
        Me.valueChk.Name = "valueChk"
        Me.valueChk.Size = New System.Drawing.Size(77, 17)
        Me.valueChk.TabIndex = 1
        Me.valueChk.Text = "High value"
        Me.valueChk.UseVisualStyleBackColor = True
        '
        'rgbPnl
        '
        Me.rgbPnl.Controls.Add(Me.redChk)
        Me.rgbPnl.Controls.Add(Me.greenChk)
        Me.rgbPnl.Controls.Add(Me.blueChk)
        Me.rgbPnl.Location = New System.Drawing.Point(6, 5)
        Me.rgbPnl.Name = "rgbPnl"
        Me.rgbPnl.Size = New System.Drawing.Size(91, 63)
        Me.rgbPnl.TabIndex = 10
        '
        'redChk
        '
        Me.redChk.AutoSize = True
        Me.redChk.Location = New System.Drawing.Point(0, 0)
        Me.redChk.Name = "redChk"
        Me.redChk.Size = New System.Drawing.Size(66, 17)
        Me.redChk.TabIndex = 0
        Me.redChk.Text = "High red"
        Me.redChk.UseVisualStyleBackColor = True
        '
        'greenChk
        '
        Me.greenChk.AutoSize = True
        Me.greenChk.Location = New System.Drawing.Point(0, 23)
        Me.greenChk.Name = "greenChk"
        Me.greenChk.Size = New System.Drawing.Size(78, 17)
        Me.greenChk.TabIndex = 1
        Me.greenChk.Text = "High green"
        Me.greenChk.UseVisualStyleBackColor = True
        '
        'blueChk
        '
        Me.blueChk.AutoSize = True
        Me.blueChk.Location = New System.Drawing.Point(0, 46)
        Me.blueChk.Name = "blueChk"
        Me.blueChk.Size = New System.Drawing.Size(71, 17)
        Me.blueChk.TabIndex = 2
        Me.blueChk.Text = "High blue"
        Me.blueChk.UseVisualStyleBackColor = True
        '
        'advancedTab
        '
        Me.advancedTab.Controls.Add(Me.Arrow1)
        Me.advancedTab.Controls.Add(Me.redLabel)
        Me.advancedTab.Controls.Add(Me.toOne)
        Me.advancedTab.Controls.Add(Me.fromOne)
        Me.advancedTab.Controls.Add(Me.advPanel)
        Me.advancedTab.Location = New System.Drawing.Point(4, 22)
        Me.advancedTab.Name = "advancedTab"
        Me.advancedTab.Padding = New System.Windows.Forms.Padding(3)
        Me.advancedTab.Size = New System.Drawing.Size(207, 74)
        Me.advancedTab.TabIndex = 1
        Me.advancedTab.Text = "Advanced"
        Me.advancedTab.UseVisualStyleBackColor = True
        '
        'Arrow1
        '
        Me.Arrow1.AutoSize = True
        Me.Arrow1.Location = New System.Drawing.Point(79, 7)
        Me.Arrow1.Name = "Arrow1"
        Me.Arrow1.Size = New System.Drawing.Size(19, 13)
        Me.Arrow1.TabIndex = 0
        Me.Arrow1.Text = ">>"
        '
        'redLabel
        '
        Me.redLabel.AutoSize = True
        Me.redLabel.Location = New System.Drawing.Point(6, 9)
        Me.redLabel.Name = "redLabel"
        Me.redLabel.Size = New System.Drawing.Size(15, 13)
        Me.redLabel.TabIndex = 0
        Me.redLabel.Text = "R"
        '
        'toOne
        '
        Me.toOne.Location = New System.Drawing.Point(104, 4)
        Me.toOne.MaxLength = 3
        Me.toOne.Name = "toOne"
        Me.toOne.Size = New System.Drawing.Size(47, 20)
        Me.toOne.TabIndex = 1
        Me.toOne.Text = "255"
        '
        'fromOne
        '
        Me.fromOne.Location = New System.Drawing.Point(26, 4)
        Me.fromOne.MaxLength = 3
        Me.fromOne.Name = "fromOne"
        Me.fromOne.Size = New System.Drawing.Size(47, 20)
        Me.fromOne.TabIndex = 0
        Me.fromOne.Text = "0"
        '
        'advPanel
        '
        Me.advPanel.Controls.Add(Me.blueLabel)
        Me.advPanel.Controls.Add(Me.greenLabel)
        Me.advPanel.Controls.Add(Me.Arrow3)
        Me.advPanel.Controls.Add(Me.Arrow2)
        Me.advPanel.Controls.Add(Me.toThree)
        Me.advPanel.Controls.Add(Me.fromThree)
        Me.advPanel.Controls.Add(Me.toTwo)
        Me.advPanel.Controls.Add(Me.fromTwo)
        Me.advPanel.Location = New System.Drawing.Point(1, 23)
        Me.advPanel.Name = "advPanel"
        Me.advPanel.Size = New System.Drawing.Size(159, 51)
        Me.advPanel.TabIndex = 2
        '
        'blueLabel
        '
        Me.blueLabel.AutoSize = True
        Me.blueLabel.Location = New System.Drawing.Point(5, 30)
        Me.blueLabel.Name = "blueLabel"
        Me.blueLabel.Size = New System.Drawing.Size(14, 13)
        Me.blueLabel.TabIndex = 0
        Me.blueLabel.Text = "B"
        '
        'greenLabel
        '
        Me.greenLabel.AutoSize = True
        Me.greenLabel.Location = New System.Drawing.Point(5, 7)
        Me.greenLabel.Name = "greenLabel"
        Me.greenLabel.Size = New System.Drawing.Size(15, 13)
        Me.greenLabel.TabIndex = 0
        Me.greenLabel.Text = "G"
        '
        'Arrow3
        '
        Me.Arrow3.AutoSize = True
        Me.Arrow3.Location = New System.Drawing.Point(78, 30)
        Me.Arrow3.Name = "Arrow3"
        Me.Arrow3.Size = New System.Drawing.Size(19, 13)
        Me.Arrow3.TabIndex = 0
        Me.Arrow3.Text = ">>"
        '
        'Arrow2
        '
        Me.Arrow2.AutoSize = True
        Me.Arrow2.Location = New System.Drawing.Point(78, 7)
        Me.Arrow2.Name = "Arrow2"
        Me.Arrow2.Size = New System.Drawing.Size(19, 13)
        Me.Arrow2.TabIndex = 0
        Me.Arrow2.Text = ">>"
        '
        'toThree
        '
        Me.toThree.Location = New System.Drawing.Point(103, 27)
        Me.toThree.MaxLength = 3
        Me.toThree.Name = "toThree"
        Me.toThree.Size = New System.Drawing.Size(47, 20)
        Me.toThree.TabIndex = 5
        Me.toThree.Text = "255"
        '
        'fromThree
        '
        Me.fromThree.Location = New System.Drawing.Point(25, 27)
        Me.fromThree.MaxLength = 3
        Me.fromThree.Name = "fromThree"
        Me.fromThree.Size = New System.Drawing.Size(47, 20)
        Me.fromThree.TabIndex = 4
        Me.fromThree.Text = "0"
        '
        'toTwo
        '
        Me.toTwo.Location = New System.Drawing.Point(103, 4)
        Me.toTwo.MaxLength = 3
        Me.toTwo.Name = "toTwo"
        Me.toTwo.Size = New System.Drawing.Size(47, 20)
        Me.toTwo.TabIndex = 3
        Me.toTwo.Text = "255"
        '
        'fromTwo
        '
        Me.fromTwo.Location = New System.Drawing.Point(25, 4)
        Me.fromTwo.MaxLength = 3
        Me.fromTwo.Name = "fromTwo"
        Me.fromTwo.Size = New System.Drawing.Size(47, 20)
        Me.fromTwo.TabIndex = 2
        Me.fromTwo.Text = "0"
        '
        'websafeChk
        '
        Me.websafeChk.AutoSize = True
        Me.websafeChk.Location = New System.Drawing.Point(229, 88)
        Me.websafeChk.Name = "websafeChk"
        Me.websafeChk.Size = New System.Drawing.Size(69, 17)
        Me.websafeChk.TabIndex = 4
        Me.websafeChk.Text = "Websafe"
        Me.websafeChk.UseVisualStyleBackColor = True
        '
        'rgbRadio
        '
        Me.rgbRadio.AutoSize = True
        Me.rgbRadio.Checked = True
        Me.rgbRadio.Location = New System.Drawing.Point(229, 29)
        Me.rgbRadio.Name = "rgbRadio"
        Me.rgbRadio.Size = New System.Drawing.Size(48, 17)
        Me.rgbRadio.TabIndex = 1
        Me.rgbRadio.TabStop = True
        Me.rgbRadio.Text = "RGB"
        Me.rgbRadio.UseVisualStyleBackColor = True
        '
        'hsvRadio
        '
        Me.hsvRadio.AutoSize = True
        Me.hsvRadio.Location = New System.Drawing.Point(229, 49)
        Me.hsvRadio.Name = "hsvRadio"
        Me.hsvRadio.Size = New System.Drawing.Size(47, 17)
        Me.hsvRadio.TabIndex = 2
        Me.hsvRadio.Text = "HSV"
        Me.hsvRadio.UseVisualStyleBackColor = True
        '
        'outputLabel
        '
        Me.outputLabel.Location = New System.Drawing.Point(344, 25)
        Me.outputLabel.Name = "outputLabel"
        Me.outputLabel.Size = New System.Drawing.Size(56, 17)
        Me.outputLabel.TabIndex = 0
        Me.outputLabel.Text = "Output:"
        Me.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cancelBtn
        '
        Me.cancelBtn.Location = New System.Drawing.Point(122, 117)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(67, 23)
        Me.cancelBtn.TabIndex = 9
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'AdvancedRandomColorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 149)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.colorPanel)
        Me.Controls.Add(Me.outputLabel)
        Me.Controls.Add(Me.hsvRadio)
        Me.Controls.Add(Me.rgbRadio)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.selectButton)
        Me.Controls.Add(Me.generateButton)
        Me.Controls.Add(Me.websafeChk)
        Me.Controls.Add(Me.grayChk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AdvancedRandomColorForm"
        Me.Text = "Advanced random color"
        Me.TabControl1.ResumeLayout(False)
        Me.simpleTab.ResumeLayout(False)
        Me.hsvPnl.ResumeLayout(False)
        Me.hsvPnl.PerformLayout()
        Me.rgbPnl.ResumeLayout(False)
        Me.rgbPnl.PerformLayout()
        Me.advancedTab.ResumeLayout(False)
        Me.advancedTab.PerformLayout()
        Me.advPanel.ResumeLayout(False)
        Me.advPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grayChk As System.Windows.Forms.CheckBox
    Friend WithEvents generateButton As System.Windows.Forms.Button
    Friend WithEvents colorPanel As System.Windows.Forms.Panel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents selectButton As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents simpleTab As System.Windows.Forms.TabPage
    Friend WithEvents rgbPnl As System.Windows.Forms.Panel
    Friend WithEvents redChk As System.Windows.Forms.CheckBox
    Friend WithEvents greenChk As System.Windows.Forms.CheckBox
    Friend WithEvents blueChk As System.Windows.Forms.CheckBox
    Friend WithEvents advancedTab As System.Windows.Forms.TabPage
    Friend WithEvents websafeChk As System.Windows.Forms.CheckBox
    Friend WithEvents hsvPnl As System.Windows.Forms.Panel
    Friend WithEvents satChk As System.Windows.Forms.CheckBox
    Friend WithEvents valueChk As System.Windows.Forms.CheckBox
    Friend WithEvents rgbRadio As System.Windows.Forms.RadioButton
    Friend WithEvents hsvRadio As System.Windows.Forms.RadioButton
    Friend WithEvents outputLabel As System.Windows.Forms.Label
    Friend WithEvents Arrow1 As System.Windows.Forms.Label
    Friend WithEvents redLabel As System.Windows.Forms.Label
    Friend WithEvents toOne As System.Windows.Forms.TextBox
    Friend WithEvents fromOne As System.Windows.Forms.TextBox
    Friend WithEvents advPanel As System.Windows.Forms.Panel
    Friend WithEvents blueLabel As System.Windows.Forms.Label
    Friend WithEvents greenLabel As System.Windows.Forms.Label
    Friend WithEvents Arrow3 As System.Windows.Forms.Label
    Friend WithEvents Arrow2 As System.Windows.Forms.Label
    Friend WithEvents toThree As System.Windows.Forms.TextBox
    Friend WithEvents fromThree As System.Windows.Forms.TextBox
    Friend WithEvents toTwo As System.Windows.Forms.TextBox
    Friend WithEvents fromTwo As System.Windows.Forms.TextBox
    Friend WithEvents cancelBtn As System.Windows.Forms.Button
End Class
