Public Class AdvancedRandomColorForm
    Dim valid As Boolean = True
    Dim mode As Byte = 0 '0 simple, 1 advanced
    Private Sub Panel1_BackColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles colorPanel.BackColorChanged
        selectButton.Enabled = colorPanel.BackColor <> Nothing
        colorPanel.Invalidate()
    End Sub
    Private Sub Panel4_Paint(ByVal sender As Panel, ByVal e As System.Windows.Forms.PaintEventArgs) Handles colorPanel.Paint
        Dim _PenBorder As New Pen(New SolidBrush(Form1.ApplyColorFilter(colorPanel.BackColor, Form1.ColorFilters.Negative)), 1)
        e.Graphics.DrawRectangle(_PenBorder, 0, 0, sender.Width - 1, sender.Height - 1)
        _PenBorder.Dispose()
        e.Graphics.Dispose()
        _PenBorder = Nothing
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles generateButton.Click
        Dim n As New Random
        If rgbRadio.Checked Then
            Dim c As Color
            'rgb
            If TabControl1.SelectedTab Is simpleTab Then
                'simple
                If grayChk.Checked Then
                    Dim val As Byte = n.Next(0, 255) : c = Color.FromArgb(val, val, val)
                Else
                    Dim r As Byte = n.Next(If(redChk.Checked, 127, 0), 255)
                    Dim g As Byte = n.Next(If(greenChk.Checked, 127, 0), 255)
                    Dim b As Byte = n.Next(If(blueChk.Checked, 127, 0), 255)
                    c = Color.FromArgb(r, g, b)
                End If
            Else
                'advanced
                If grayChk.Checked Then
                    Dim val As Byte = n.Next(fromOne.Text, toOne.Text) : c = Color.FromArgb(val, val, val)
                Else
                    Dim r As Byte = n.Next(fromOne.Text, toOne.Text)
                    Dim g As Byte = n.Next(fromTwo.Text, toTwo.Text)
                    Dim b As Byte = n.Next(fromThree.Text, toThree.Text)
                    c = Color.FromArgb(r, g, b)
                End If
            End If
            'convert to websafe and show
            If websafeChk.Checked Then c = New ColorChanger().WebsafeColor(c)
            colorPanel.BackColor = c
        Else
            Dim c As ColorManager.HSVColor
            Dim rgb As Color = Nothing
            'hsv
            If TabControl1.SelectedTab Is simpleTab Then
                'simple
                If grayChk.Checked Then
                    Dim val As Byte = n.Next(0, 255) : rgb = Color.FromArgb(val, val, val)
                Else
                    Dim h As Short = n.Next(0, 360)
                    Dim s As Byte = n.Next(If(satChk.Checked, 50, 0), 100)
                    Dim v As Byte = n.Next(If(valueChk.Checked, 50, 0), 100)
                    c = New ColorManager.HSVColor(h, s, v, 255)
                End If
            Else
                'advanced
                If grayChk.Checked Then
                    Dim val As Byte = n.Next(fromOne.Text, toOne.Text) : rgb = Color.FromArgb(val, val, val)
                Else
                    Dim h As Short = n.Next(fromOne.Text, toOne.Text)
                    Dim s As Byte = n.Next(fromTwo.Text, toTwo.Text)
                    Dim v As Byte = n.Next(fromThree.Text, toThree.Text)
                    c = New ColorManager.HSVColor(h, s, v, 255)
                End If
            End If
            If rgb = Nothing Then rgb = c.ToColor
            'convert to websafe and show
            If websafeChk.Checked Then rgb = New ColorChanger().WebsafeColor(rgb)
            colorPanel.BackColor = rgb
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelBtn.Click
        Me.Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectButton.Click
        Form1.colormanager.RGB = colorPanel.BackColor
        Me.Close()
    End Sub
    ''drag-drop
    Private Sub Panel1_GiveFeedback(ByVal sender As Object, ByVal e As System.Windows.Forms.GiveFeedbackEventArgs) Handles colorPanel.GiveFeedback
        e.UseDefaultCursors = False

        If ((e.Effect And DragDropEffects.Copy) = DragDropEffects.Copy) Then
            Cursor.Current = New ColorCursor().CreateColorCursor(colorPanel.BackColor)
        Else
            Cursor.Current = System.Windows.Forms.Cursors.No
        End If
    End Sub
    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles colorPanel.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            colorPanel.DoDragDrop(New ColorChanger().ToHtml(colorPanel.BackColor), DragDropEffects.Copy)
        End If
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgbRadio.CheckedChanged, hsvRadio.CheckedChanged, grayChk.CheckedChanged
        rgbPnl.Enabled = Not grayChk.Checked And rgbRadio.Checked
        hsvPnl.Enabled = Not grayChk.Checked And hsvRadio.Checked
        redLabel.Text = If(grayChk.Checked, lang("HSV", "H"), If(rgbRadio.Checked, lang("RGB", "R"), lang("HSV", "H")))
        greenLabel.Text = If(rgbRadio.Checked, lang("RGB", "G"), lang("HSV", "S"))
        blueLabel.Text = If(rgbRadio.Checked, lang("RGB", "B"), lang("HSV", "V"))
        advPanel.Enabled = Not grayChk.Checked
        mode = TabControl1.SelectedIndex
        txt_TextChanged(fromOne, EventArgs.Empty) : txt_TextChanged(fromTwo, EventArgs.Empty) : txt_TextChanged(fromThree, EventArgs.Empty)
        txt_TextChanged(toOne, EventArgs.Empty) : txt_TextChanged(toTwo, EventArgs.Empty) : txt_TextChanged(toThree, EventArgs.Empty)
    End Sub
    Public Sub updateLang()
        Text = lang("TOOL_ADVRAND")
        outputLabel.Text = lang("COMMON", "OUTPUT")
        generateButton.Text = lang("TOOL_ADVRAND", "GENERATE")
        selectButton.Text = lang("COMMON", "SELECTANDCLOSE")
        cancelBtn.Text = lang("COMMON", "CANCEL")
        rgbRadio.Text = lang("RGB")
        hsvRadio.Text = lang("HSV")
        redChk.Text = lang("TOOL_ADVRAND", "HIGHRED")
        greenChk.Text = lang("TOOL_ADVRAND", "HIGHGREEN")
        blueChk.Text = lang("TOOL_ADVRAND", "HIGHBLUE")
        satChk.Text = lang("TOOL_ADVRAND", "HIGHSATURATION")
        valueChk.Text = lang("TOOL_ADVRAND", "HIGHVALUE")
        grayChk.Text = lang("TOOL_ADVRAND", "GRAYSCALE")
        websafeChk.Text = lang("TOOL_ADVRAND", "WEBSAFE")
        simpleTab.Text = lang("TOOL_ADVRAND", "SIMPLE")
        advancedTab.Text = lang("TOOL_ADVRAND", "ADVANCED")
        redLabel.Text = If(grayChk.Checked, lang("HSV", "H"), If(rgbRadio.Checked, lang("RGB", "R"), lang("HSV", "H")))
        greenLabel.Text = If(rgbRadio.Checked, lang("RGB", "G"), lang("HSV", "S"))
        blueLabel.Text = If(rgbRadio.Checked, lang("RGB", "B"), lang("HSV", "V"))
    End Sub
    Private Sub AdvancedRandomColorForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        updateLang()
    End Sub
    Public Function isCompatibleNumeric(ByVal s As String)
        Return Not (s.Contains(".") Or s.Contains(",") Or s.Contains("+") Or s.Contains("-") Or s.StartsWith(".") Or s.StartsWith(",") Or s.StartsWith("+") Or s.StartsWith("-"))
    End Function
    Public Sub setValid(ByVal v As Boolean)
        valid = v
        generateButton.Enabled = If(mode = 1, valid, True)
    End Sub
    Private Function getValid()
        Return (Not fromOne.BackColor = Color.Tomato And Not fromTwo.BackColor = Color.Tomato _
                And Not fromThree.BackColor = Color.Tomato And Not toOne.BackColor = Color.Tomato _
                And Not toTwo.BackColor = Color.Tomato And Not toThree.BackColor = Color.Tomato _
                And Not fromOne.BackColor = Color.LemonChiffon And Not fromTwo.BackColor = Color.LemonChiffon _
                And Not fromThree.BackColor = Color.LemonChiffon And Not toOne.BackColor = Color.LemonChiffon _
                And Not toTwo.BackColor = Color.LemonChiffon And Not toThree.BackColor = Color.LemonChiffon)
    End Function
    Private Sub txt_TextChanged(sender As System.Object, e As System.EventArgs) Handles fromOne.TextChanged, fromTwo.TextChanged, fromThree.TextChanged, toOne.TextChanged, toTwo.TextChanged, toThree.TextChanged
        Try
            If sender.Text <> "" Then
                Dim max As Integer = If(grayChk.Checked And (sender Is toOne Or sender Is fromOne), 100, If(hsvRadio.Checked, If(sender Is toOne Or sender Is fromOne, 360, 100), 255))
                Dim other As System.Object = If(sender Is fromOne, toOne, If(sender Is fromTwo, toTwo, If(sender Is fromThree, toThree, If(sender Is toOne, fromOne, If(sender Is toTwo, fromTwo, If(sender Is toThree, fromThree, Nothing))))))
                If (sender Is fromOne Or sender Is fromTwo Or sender Is fromThree) Then
                    '' [   ] --> [   ]
                    If IsNumeric(sender.Text) And isCompatibleNumeric(sender.Text) Then
                        If sender.Text <= max And sender.Text >= 0 Then
                            If sender.Text <= CInt(other.Text) Then
                                sender.BackColor = SystemColors.Window
                                If other.BackColor = Color.LemonChiffon Then txt_TextChanged(other, EventArgs.Empty)
                            Else
                                sender.BackColor = Color.LemonChiffon
                            End If
                        Else
                            sender.BackColor = Color.Tomato
                        End If
                    Else
                        sender.BackColor = Color.Tomato
                    End If
                Else
                    '' [   ] <-- [   ]
                    If IsNumeric(sender.Text) And isCompatibleNumeric(sender.Text) Then
                        If sender.Text <= max And sender.Text >= 0 Then
                            If sender.Text >= CInt(other.Text) Then
                                sender.BackColor = SystemColors.Window
                                If other.BackColor = Color.LemonChiffon Then txt_TextChanged(other, EventArgs.Empty)
                            Else
                                sender.BackColor = Color.LemonChiffon
                            End If
                        Else
                            sender.BackColor = Color.Tomato
                        End If
                    Else
                        sender.BackColor = Color.Tomato
                    End If
                End If
            Else
                sender.BackColor = Color.Tomato
            End If
            setValid(getValid)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        mode = TabControl1.SelectedIndex
        generateButton.Enabled = If(mode = 1, valid, True)
    End Sub
End Class