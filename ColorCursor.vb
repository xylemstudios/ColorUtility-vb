Imports System.Runtime.InteropServices

Public Class ColorCursor

    Dim _curColor As Color = Color.White

    Private Structure IconInfo
        Public fIcon As Boolean
        Public xHotspot As Int32
        Public yHotspot As Int32
        Public hbmMask As IntPtr
        Public hbmColor As IntPtr
    End Structure

    <DllImport("user32.dll", EntryPoint:="CreateIconIndirect")> _
    Private Shared Function CreateIconIndirect(ByVal iconInfo As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Public Shared Function DestroyIcon(ByVal handle As IntPtr) As Boolean
    End Function

    <DllImport("gdi32.dll")> _
    Public Shared Function DeleteObject(ByVal hObject As IntPtr) As Boolean
    End Function

    Public Function CreateColorCursor(ByVal c As Color) As Cursor
        _curColor = c
        Dim negColor As Color = Color.FromArgb(255 - _curColor.R, 255 - _curColor.G, 255 - _curColor.B)
        Dim rCursor As New Cursor(New IO.MemoryStream(My.Resources.copy))
        Dim bmp As New Bitmap(32, 32, Imaging.PixelFormat.Format32bppArgb)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

            'Fill the color...
            g.FillRectangle(New SolidBrush(_curColor), New Rectangle(16, 0, 15, 15))

            'Draw the bordercolor...
            g.DrawRectangle(New Pen(negColor, 1), New Rectangle(16, 0, 15, 15))

            rCursor.Draw(g, New Rectangle(0, 0, 32, 32))
        End Using

        'Setup the Cursors IconInfo
        Dim tmp As New IconInfo
        tmp.xHotspot = 0
        tmp.yHotspot = 0
        tmp.fIcon = False
        tmp.hbmMask = bmp.GetHbitmap()
        tmp.hbmColor = bmp.GetHbitmap()

        'Create the Pointer for the Cursor Icon
        Dim pnt As IntPtr = Marshal.AllocHGlobal(Marshal.SizeOf(tmp))
        Marshal.StructureToPtr(tmp, pnt, True)
        Dim curPtr As IntPtr = CreateIconIndirect(pnt)

        'Clean Up
        DestroyIcon(pnt)
        DeleteObject(tmp.hbmMask)
        DeleteObject(tmp.hbmColor)
        bmp.Dispose()
        rCursor.Dispose()
        Return New Cursor(curPtr)
    End Function

End Class