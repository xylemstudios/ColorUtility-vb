<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GetImageColorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GetImageColorForm))
        Me.pathTxt = New System.Windows.Forms.TextBox()
        Me.pathLabel = New System.Windows.Forms.Label()
        Me.pathButton = New System.Windows.Forms.Button()
        Me.startButton = New System.Windows.Forms.Button()
        Me.selectButton = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.statusLabel = New System.Windows.Forms.Label()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.progressLabel = New System.Windows.Forms.Label()
        Me.searchTxt = New System.Windows.Forms.TextBox()
        Me.htmlRadio = New System.Windows.Forms.RadioButton()
        Me.rgbRadio = New System.Windows.Forms.RadioButton()
        Me.separatorPic = New System.Windows.Forms.PictureBox()
        Me.ListView1 = New ColorUtility.UnBuggyListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.separatorPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pathTxt
        '
        Me.pathTxt.Location = New System.Drawing.Point(12, 27)
        Me.pathTxt.Name = "pathTxt"
        Me.pathTxt.Size = New System.Drawing.Size(391, 20)
        Me.pathTxt.TabIndex = 0
        '
        'pathLabel
        '
        Me.pathLabel.AutoSize = True
        Me.pathLabel.Location = New System.Drawing.Point(12, 9)
        Me.pathLabel.Name = "pathLabel"
        Me.pathLabel.Size = New System.Drawing.Size(63, 13)
        Me.pathLabel.TabIndex = 0
        Me.pathLabel.Text = "Image path:"
        '
        'pathButton
        '
        Me.pathButton.Location = New System.Drawing.Point(409, 27)
        Me.pathButton.Name = "pathButton"
        Me.pathButton.Size = New System.Drawing.Size(26, 20)
        Me.pathButton.TabIndex = 1
        Me.pathButton.Text = "..."
        Me.pathButton.UseVisualStyleBackColor = True
        '
        'startButton
        '
        Me.startButton.Enabled = False
        Me.startButton.Location = New System.Drawing.Point(331, 53)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(104, 32)
        Me.startButton.TabIndex = 2
        Me.startButton.Tag = "s"
        Me.startButton.Text = "Start"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'selectButton
        '
        Me.selectButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.selectButton.Enabled = False
        Me.selectButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectButton.Location = New System.Drawing.Point(317, 254)
        Me.selectButton.Name = "selectButton"
        Me.selectButton.Size = New System.Drawing.Size(118, 24)
        Me.selectButton.TabIndex = 4
        Me.selectButton.Text = "Select color"
        Me.selectButton.UseVisualStyleBackColor = True
        '
        'closeButton
        '
        Me.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.closeButton.Location = New System.Drawing.Point(230, 254)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(81, 24)
        Me.closeButton.TabIndex = 5
        Me.closeButton.Text = "Close"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'statusLabel
        '
        Me.statusLabel.Location = New System.Drawing.Point(12, 53)
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(313, 13)
        Me.statusLabel.TabIndex = 0
        Me.statusLabel.Text = "Idle."
        '
        'BackgroundWorker2
        '
        Me.BackgroundWorker2.WorkerSupportsCancellation = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 91)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(423, 14)
        Me.ProgressBar1.TabIndex = 0
        '
        'progressLabel
        '
        Me.progressLabel.Location = New System.Drawing.Point(12, 72)
        Me.progressLabel.Name = "progressLabel"
        Me.progressLabel.Size = New System.Drawing.Size(313, 13)
        Me.progressLabel.TabIndex = 0
        '
        'searchTxt
        '
        Me.searchTxt.ForeColor = System.Drawing.Color.DarkGray
        Me.searchTxt.Location = New System.Drawing.Point(12, 118)
        Me.searchTxt.Name = "searchTxt"
        Me.searchTxt.Size = New System.Drawing.Size(280, 20)
        Me.searchTxt.TabIndex = 11
        Me.searchTxt.Text = "Search..."
        Me.searchTxt.Visible = False
        '
        'htmlRadio
        '
        Me.htmlRadio.AutoSize = True
        Me.htmlRadio.Checked = True
        Me.htmlRadio.Location = New System.Drawing.Point(299, 119)
        Me.htmlRadio.Name = "htmlRadio"
        Me.htmlRadio.Size = New System.Drawing.Size(83, 17)
        Me.htmlRadio.TabIndex = 12
        Me.htmlRadio.TabStop = True
        Me.htmlRadio.Text = "HTML Code"
        Me.htmlRadio.UseVisualStyleBackColor = True
        Me.htmlRadio.Visible = False
        '
        'rgbRadio
        '
        Me.rgbRadio.AutoSize = True
        Me.rgbRadio.Location = New System.Drawing.Point(388, 119)
        Me.rgbRadio.Name = "rgbRadio"
        Me.rgbRadio.Size = New System.Drawing.Size(48, 17)
        Me.rgbRadio.TabIndex = 12
        Me.rgbRadio.Text = "RGB"
        Me.rgbRadio.UseVisualStyleBackColor = True
        Me.rgbRadio.Visible = False
        '
        'separatorPic
        '
        Me.separatorPic.BackColor = System.Drawing.Color.Gray
        Me.separatorPic.Location = New System.Drawing.Point(-10, 111)
        Me.separatorPic.Name = "separatorPic"
        Me.separatorPic.Size = New System.Drawing.Size(473, 1)
        Me.separatorPic.TabIndex = 13
        Me.separatorPic.TabStop = False
        '
        'ListView1
        '
        Me.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.LabelWrap = False
        Me.ListView1.Location = New System.Drawing.Point(12, 118)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(423, 130)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "HTML Code"
        Me.ColumnHeader1.Width = 199
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Red"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Green"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Blue"
        '
        'GetImageColorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 283)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.separatorPic)
        Me.Controls.Add(Me.rgbRadio)
        Me.Controls.Add(Me.htmlRadio)
        Me.Controls.Add(Me.searchTxt)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.progressLabel)
        Me.Controls.Add(Me.statusLabel)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.selectButton)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.pathButton)
        Me.Controls.Add(Me.pathLabel)
        Me.Controls.Add(Me.pathTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "GetImageColorForm"
        Me.Text = "Get all colors in an image"
        CType(Me.separatorPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pathTxt As System.Windows.Forms.TextBox
    Friend WithEvents pathLabel As System.Windows.Forms.Label
    Friend WithEvents pathButton As System.Windows.Forms.Button
    Friend WithEvents startButton As System.Windows.Forms.Button
    Friend WithEvents selectButton As System.Windows.Forms.Button
    Friend WithEvents closeButton As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ListView1 As ColorUtility.UnBuggyListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents statusLabel As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents progressLabel As System.Windows.Forms.Label
    Friend WithEvents searchTxt As System.Windows.Forms.TextBox
    Friend WithEvents htmlRadio As System.Windows.Forms.RadioButton
    Friend WithEvents rgbRadio As System.Windows.Forms.RadioButton
    Friend WithEvents separatorPic As System.Windows.Forms.PictureBox
End Class
