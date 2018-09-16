Imports System.Runtime.InteropServices

Public Class ColorPickerCursor

    <DllImport("user32.dll", EntryPoint:="CreateIconIndirect")> _
    Private Shared Function CreateIconIndirect(ByVal iconInfo As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Public Shared Function DestroyIcon(ByVal handle As IntPtr) As Boolean
    End Function

    <DllImport("gdi32.dll")> _
    Public Shared Function DeleteObject(ByVal hObject As IntPtr) As Boolean
    End Function

    Private Structure IconInfo
        Public fIcon As Boolean
        Public xHotspot As Int32
        Public yHotspot As Int32
        Public hbmMask As IntPtr
        Public hbmColor As IntPtr
    End Structure

    Public Shared Function ImageToCursor(ByVal img As Bitmap, ByVal xHotspot As Integer, ByVal yHotspot As Integer) As Cursor
        'Setup the Cursors IconInfo
        Dim tmp As New IconInfo
        tmp.xHotspot = xHotspot
        tmp.yHotspot = yHotspot
        tmp.fIcon = False
        tmp.hbmMask = img.GetHbitmap
        tmp.hbmColor = img.GetHbitmap

        'Create the Pointer for the Cursor Icon
        Dim pnt As IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(tmp))
        Marshal.StructureToPtr(tmp, pnt, True)
        Dim curPtr As IntPtr = CreateIconIndirect(pnt)

        'Clean Up
        DestroyIcon(pnt)
        DeleteObject(tmp.hbmMask)
        DeleteObject(tmp.hbmColor)

        Return New Cursor(curPtr)
        DeleteObject(curPtr)

        tmp = Nothing
        pnt = Nothing
        curPtr = Nothing
    End Function
    Dim zoomValue As Integer = 5
    Private Function CreateZoomSpot(ByVal screenshot As Image, ByVal x As Integer, ByVal y As Integer, ByVal color As Color) As Image
        Dim blankImage As Image = Nothing
        Dim g As Graphics = Graphics.FromImage(blankImage)
        g.InterpolationMode = Drawing2D.InterpolationMode.NearestNeighbor

        'Draw zoom...
        Dim rec As New Rectangle(x - zoomValue, y - zoomValue, screenshot.Width / (zoomValue / 2), screenshot.Height / (zoomValue / 2))
        g.DrawImage(screenshot, New Rectangle(0, 0, screenshot.Width, screenshot.Height), rec, GraphicsUnit.Pixel)

        'Draw spot...
        Dim pen As New Pen(color, 1)
        g.DrawRectangle(pen, New Rectangle(11, 11, 3, 3))

        Return blankImage
        g.Dispose()
        g.Flush()
        g = Nothing
        blankImage.Dispose()
        blankImage = Nothing
        screenshot.Dispose()
        screenshot = Nothing
        rec = Nothing
        pen = Nothing
    End Function
    Public Function GenerateColorPickerCursor(ByVal prevColor As Color, ByVal currentPixel As Color, ByVal screenshot As Image, ByVal x As Integer, ByVal y As Integer) As Cursor
        Dim resultCursor As Cursor = Nothing
        Dim bmp As New Bitmap(192, 192, Imaging.PixelFormat.Format32bppArgb)
        Dim g As Graphics = Graphics.FromImage(bmp)

        'For testing.. Grid lines...
        'g.DrawRectangle(New Pen(Color.Red, 1), New Rectangle(0, 0, 47, 47))
        'g.DrawLine(New Pen(Color.Red, 1), 0, 16, 48, 16)
        'g.DrawLine(New Pen(Color.Red, 1), 0, 32, 48, 32)
        'g.DrawLine(New Pen(Color.Red, 1), 16, 0, 16, 48)
        'g.DrawLine(New Pen(Color.Red, 1), 32, 0, 32, 48)

        Dim pos As New Point()
        If x >= 0 And y >= 48 Then
            pos = New Point(51, 46)
            resultCursor = ImageToCursor(My.Resources.pipette, pos.X, pos.Y)
            '--Left Bottom--
            'Draw current pixel...
            g.DrawRectangle(New Pen(Color.Black, 1), New Rectangle(53, 3, 12, 12))
            g.FillRectangle(New SolidBrush(prevColor), New Rectangle(54, 4, 11, 11))

            'Draw current selected pixel...
            g.DrawRectangle(New Pen(Color.Black, 1), New Rectangle(53, 18, 12, 12))
            g.FillRectangle(New SolidBrush(currentPixel), New Rectangle(54, 19, 11, 11))

            'Draw zoomer, with current pixel selection...
            g.DrawRectangle(New Pen(Color.Black, 1), New Rectangle(68, 3, 27, 27))
            g.DrawImage(CreateZoomSpot(screenshot, x, y, Color.Red), New Rectangle(69, 4, 26, 26))

        ElseIf (x >= 0 And x < screenshot.Width - 48) And y <= 48 Then
            pos = New Point(64, 32)
            resultCursor = ImageToCursor(My.Resources.pipette_upsidedown, pos.X, pos.Y)
            '--Right Top--
            'Draw current pixel...
            g.DrawRectangle(New Pen(Color.Black, 1), New Rectangle(53, 67, 12, 12))
            g.FillRectangle(New SolidBrush(prevColor), New Rectangle(54, 68, 11, 11))

            'Draw current selected pixel...
            g.DrawRectangle(New Pen(Color.Black, 1), New Rectangle(53, 52, 12, 12))
            g.FillRectangle(New SolidBrush(currentPixel), New Rectangle(54, 53, 11, 11))

            'Draw zoomer, with current pixel selection...
            g.DrawRectangle(New Pen(Color.Black, 1), New Rectangle(23, 52, 27, 27))
            g.DrawImage(CreateZoomSpot(screenshot, x, y, Color.Red), New Rectangle(24, 53, 26, 26))

        End If

        resultCursor.Draw(g, New Rectangle(42, 24, resultCursor.Size.Width, resultCursor.Size.Height))

        Return ImageToCursor(bmp, pos.X, pos.Y)
        g.Dispose()
        g.Flush()
        bmp.Dispose()
        resultCursor.Dispose()
        screenshot.Dispose()
        g = Nothing
        bmp = Nothing
        resultCursor = Nothing
        screenshot = Nothing
        pos = Nothing

    End Function
End Class