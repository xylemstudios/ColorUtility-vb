Public Class ColorCombinerForm
    Private Function createColorBitmap(ByVal c As Color) As Image
        Dim bmp As New Bitmap(16, 16, Imaging.PixelFormat.Format32bppArgb)
        Dim g As Graphics = Graphics.FromImage(bmp)
        g.FillRectangle(New SolidBrush(c), New Rectangle(0, 0, bmp.Width, bmp.Height))
        g.DrawRectangle(New Pen(Form1.ApplyColorFilter(c, Form1.ColorFilters.Negative)), New Rectangle(0, 0, bmp.Width - 1, bmp.Height - 1))
        Return bmp
    End Function
    Private Sub Panel2_Paint(ByVal sender As Panel, ByVal e As System.Windows.Forms.PaintEventArgs) Handles colorPanel.Paint
        Dim _PenBorder As New Pen(New SolidBrush(Form1.ApplyColorFilter(sender.BackColor, Form1.ColorFilters.Negative)), 1)
        e.Graphics.DrawRectangle(_PenBorder, 0, 0, sender.Width - 1, sender.Height - 1)
        _PenBorder.Dispose()
        e.Graphics.Dispose()
        _PenBorder = Nothing
    End Sub
    Private Sub refreshColor()
        If colorList.Items.Count > 0 Then
            Dim outR As Integer
            Dim outG As Integer
            Dim outB As Integer
            For Each item As ListViewItem In colorList.Items
                outR += DirectCast(item.Tag, Color).R
                outG += DirectCast(item.Tag, Color).G
                outB += DirectCast(item.Tag, Color).B
            Next
            outR = Math.Round(outR / colorList.Items.Count)
            outG = Math.Round(outG / colorList.Items.Count)
            outB = Math.Round(outB / colorList.Items.Count)
            colorPanel.BackColor = Color.FromArgb(outR, outG, outB)
        Else
            colorPanel.BackColor = SystemColors.Control
        End If

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addButton.Click
        Dim selectedColor As Color = Form1.colorPanel.BackColor
        If Not imgLst.Images.ContainsKey(ColorTranslator.ToHtml(selectedColor)) Then imgLst.Images.Add(ColorTranslator.ToHtml(selectedColor), createColorBitmap(selectedColor))
        Dim item As New ListViewItem(ColorTranslator.ToHtml(selectedColor))
        item.ImageKey = ColorTranslator.ToHtml(selectedColor)
        item.Tag = selectedColor
        colorList.Items.Add(item)
        refreshColor()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeButton.Click
LoopBegin:
        For Each i In colorList.SelectedIndices
            colorList.Items.RemoveAt(i)
            GoTo LoopBegin
        Next
        refreshColor()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        removeButton.Enabled = colorList.SelectedIndices.Count <> 0
        selectButton.Enabled = colorList.Items.Count <> 0
    End Sub
    Private Sub ColorCombinerForm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        addButton.PerformClick()
        updateLang()
    End Sub

    Private Sub ListView1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles colorList.DragDrop
        Dim selectedColor As Color = ColorTranslator.FromHtml(e.Data.GetData(DataFormats.Text))
        If Not imgLst.Images.ContainsKey(ColorTranslator.ToHtml(selectedColor)) Then imgLst.Images.Add(ColorTranslator.ToHtml(selectedColor), createColorBitmap(selectedColor))
        Dim item As New ListViewItem(ColorTranslator.ToHtml(selectedColor))
        item.ImageKey = ColorTranslator.ToHtml(selectedColor)
        item.Tag = selectedColor
        colorList.Items.Add(item)
        refreshColor()
    End Sub
    Private Sub ListView1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles colorList.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Text) And Form1.isValidHexColorCode(e.Data.GetData(DataFormats.Text))) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelBtn.Click
        Me.Close()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectButton.Click
        Form1.colormanager.RGB = colorPanel.BackColor
        Me.Close()
    End Sub
    Public Sub updateLang()
        Text = lang("TOOL_COMBINER")
        addButton.Text = lang("TOOL_COMBINER", "ADD")
        removeButton.Text = lang("TOOL_COMBINER", "REMOVE")
        cancelBtn.Text = lang("COMMON", "CANCEL")
        selectButton.Text = lang("COMMON", "SELECTANDCLOSE")
        resultLabel.Text = lang("COMMON", "OUTPUT")
    End Sub

    Private Sub ListView1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles colorList.KeyDown
        If e.KeyCode = Keys.Delete Then removeButton.PerformClick()
    End Sub

    Private Sub ColorCombinerForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class