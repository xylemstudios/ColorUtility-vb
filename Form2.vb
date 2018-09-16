Imports System.Drawing.Imaging
Public Class Form2
    Dim p As System.Diagnostics.Process
    Dim _Bounds As Rectangle
    Public firstColor As Color
    Public prevColor As Color
    Dim clicked As Boolean = False
    Dim cancel As Boolean = False
    Dim revert As Boolean = False
    Dim curColor As Color
    Private Sub UpdateCursor()
        Dim pos As Point = Cursor.Position
        Me.Cursor = New ColorPickerCursor().GenerateColorPickerCursor(prevColor, curColor, Me.BackgroundImage, pos.X, pos.Y)
    End Sub
    Private Sub Form2_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Timer1.Enabled = False
        Form1.colorPickerIsOn = False
        GC.Collect()
        Me.Dispose()
    End Sub
    Private Sub Form2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Try
            'new cursor  Me.Cursor = New ColorPickerCursor().GenerateColorPickerCursor(prevColor, pixelColor, Me.BackgroundImage, e.X, e.Y)
            If e.Button = Windows.Forms.MouseButtons.Left And Not cancel Then
                If Not clicked Then clicked = True
                If prevColor <> curColor Then Form1.colormanager.RGB = curColor
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Form2_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        Try
            If e.Button = MouseButtons.Left And Not (e.Button = Windows.Forms.MouseButtons.Middle Or e.Button = Windows.Forms.MouseButtons.Middle Or e.Button = Windows.Forms.MouseButtons.Right Or e.Button = Windows.Forms.MouseButtons.XButton1 Or e.Button = Windows.Forms.MouseButtons.XButton2) Then
                clicked = False
                Using bmp As New Bitmap(1, 1, PixelFormat.Format24bppRgb)
                    Using g As Graphics = Graphics.FromImage(bmp)
                        g.CopyFromScreen(Windows.Forms.Cursor.Position.X, Windows.Forms.Cursor.Position.Y, 0, 0, New Size(1, 1), CopyPixelOperation.SourceCopy)
                        g.Dispose()
                    End Using
                    prevColor = curColor
                    curColor = bmp.GetPixel(0, 0)
                    If prevColor <> curColor Then Form1.colormanager.RGB = curColor
                    Clipboard.SetText(ColorTranslator.ToHtml(curColor))
                    bmp.Dispose()
                End Using

                p.PriorityClass = ProcessPriorityClass.Normal

                Me.Dispose()
                Me.Close()
            End If
            If e.Button = MouseButtons.Right Then
                If curColor <> firstColor And clicked Then
                    Me.TopMost = False
                    Me.Hide()
                    cancel = True
                    revert = (MsgBox(lang("PICKER", "COLORCHANGED"), MsgBoxStyle.Information + MsgBoxStyle.YesNo, lang("INFO")) = MsgBoxResult.Yes)
                End If
                If revert Then Form1.colormanager.RGB = firstColor
                Me.Close()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Form2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Try
            If Not clicked Then
                If e.Button = MouseButtons.Left And Not (e.Button = Windows.Forms.MouseButtons.Middle Or e.Button = Windows.Forms.MouseButtons.Middle Or e.Button = Windows.Forms.MouseButtons.Right Or e.Button = Windows.Forms.MouseButtons.XButton1 Or e.Button = Windows.Forms.MouseButtons.XButton2) Then
                    clicked = True
                    Form1.colormanager.RGB = curColor
                    Me.TransparencyKey = Color.Silver
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = If(My.Settings.optimizeSpeed, 10, 5)
        Me.Opacity = 0.01
        p = System.Diagnostics.Process.GetCurrentProcess
        p.PriorityClass = ProcessPriorityClass.BelowNormal
        Me.Cursor = Form1.pipetteCursor

        For Each s As Screen In Screen.AllScreens
            _Bounds.Width += s.Bounds.Width
            _Bounds.Height += s.Bounds.Height
        Next
        Me.Location = New Point(0, 0)
        Me.Size = _Bounds.Size
        Me.WindowState = FormWindowState.Normal
        Me.TopMost = True
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            Form1.Focus()
            If clicked And Not cancel Then
                Using bmp As New Bitmap(1, 1, PixelFormat.Format24bppRgb)
                    Using g As Graphics = Graphics.FromImage(bmp)
                        g.CopyFromScreen(Windows.Forms.Cursor.Position.X, Windows.Forms.Cursor.Position.Y, 0, 0, New Size(1, 1), CopyPixelOperation.SourceCopy)
                    End Using
                    prevColor = curColor
                    curColor = bmp.GetPixel(0, 0)
                    If prevColor <> curColor Then Form1.colormanager.RGB = curColor
                End Using
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class
