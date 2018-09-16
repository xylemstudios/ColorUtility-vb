<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColorCombinerForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ColorCombinerForm))
        Me.colorList = New System.Windows.Forms.ListView()
        Me.imgLst = New System.Windows.Forms.ImageList(Me.components)
        Me.separatorPanel = New System.Windows.Forms.Panel()
        Me.addButton = New System.Windows.Forms.Button()
        Me.removeButton = New System.Windows.Forms.Button()
        Me.resultLabel = New System.Windows.Forms.Label()
        Me.colorPanel = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.selectButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'colorList
        '
        Me.colorList.AllowDrop = True
        Me.colorList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.colorList.HideSelection = False
        Me.colorList.Location = New System.Drawing.Point(12, 12)
        Me.colorList.Name = "colorList"
        Me.colorList.Size = New System.Drawing.Size(303, 128)
        Me.colorList.SmallImageList = Me.imgLst
        Me.colorList.TabIndex = 0
        Me.colorList.UseCompatibleStateImageBehavior = False
        Me.colorList.View = System.Windows.Forms.View.SmallIcon
        '
        'imgLst
        '
        Me.imgLst.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.imgLst.ImageSize = New System.Drawing.Size(16, 16)
        Me.imgLst.TransparentColor = System.Drawing.Color.Transparent
        '
        'separatorPanel
        '
        Me.separatorPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.separatorPanel.BackColor = System.Drawing.Color.DarkGray
        Me.separatorPanel.Location = New System.Drawing.Point(-35, 146)
        Me.separatorPanel.Name = "separatorPanel"
        Me.separatorPanel.Size = New System.Drawing.Size(550, 1)
        Me.separatorPanel.TabIndex = 1
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(321, 12)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(125, 37)
        Me.addButton.TabIndex = 2
        Me.addButton.Text = "Add from ColorUtility"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'removeButton
        '
        Me.removeButton.Location = New System.Drawing.Point(321, 55)
        Me.removeButton.Name = "removeButton"
        Me.removeButton.Size = New System.Drawing.Size(125, 23)
        Me.removeButton.TabIndex = 3
        Me.removeButton.Text = "Remove selected"
        Me.removeButton.UseVisualStyleBackColor = True
        '
        'resultLabel
        '
        Me.resultLabel.AutoSize = True
        Me.resultLabel.Location = New System.Drawing.Point(38, 161)
        Me.resultLabel.Name = "resultLabel"
        Me.resultLabel.Size = New System.Drawing.Size(37, 13)
        Me.resultLabel.TabIndex = 4
        Me.resultLabel.Text = "Result"
        '
        'colorPanel
        '
        Me.colorPanel.Location = New System.Drawing.Point(12, 157)
        Me.colorPanel.Name = "colorPanel"
        Me.colorPanel.Size = New System.Drawing.Size(20, 20)
        Me.colorPanel.TabIndex = 15
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'cancelBtn
        '
        Me.cancelBtn.Location = New System.Drawing.Point(232, 156)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(67, 23)
        Me.cancelBtn.TabIndex = 17
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'selectButton
        '
        Me.selectButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectButton.Location = New System.Drawing.Point(305, 156)
        Me.selectButton.Name = "selectButton"
        Me.selectButton.Size = New System.Drawing.Size(141, 23)
        Me.selectButton.TabIndex = 16
        Me.selectButton.Text = "Select and close"
        Me.selectButton.UseVisualStyleBackColor = True
        '
        'ColorCombinerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 187)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.selectButton)
        Me.Controls.Add(Me.colorPanel)
        Me.Controls.Add(Me.resultLabel)
        Me.Controls.Add(Me.removeButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.separatorPanel)
        Me.Controls.Add(Me.colorList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(464, 215)
        Me.Name = "ColorCombinerForm"
        Me.Text = "Color combiner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents colorList As System.Windows.Forms.ListView
    Friend WithEvents separatorPanel As System.Windows.Forms.Panel
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents removeButton As System.Windows.Forms.Button
    Friend WithEvents resultLabel As System.Windows.Forms.Label
    Friend WithEvents colorPanel As System.Windows.Forms.Panel
    Friend WithEvents imgLst As System.Windows.Forms.ImageList
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend Shadows WithEvents cancelBtn As System.Windows.Forms.Button
    Friend WithEvents selectButton As System.Windows.Forms.Button
End Class
