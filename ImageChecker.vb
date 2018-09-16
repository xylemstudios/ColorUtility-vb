Imports System.IO

Public Class ImageChecker
    Public Shared Function IsValidImage(ByVal filename As String) As Boolean
        Try : Dim img As System.Drawing.Image = System.Drawing.Image.FromFile(filename)
            img.Dispose()
        Catch generatedExceptionName As OutOfMemoryException : Return False : Exit Function : End Try : Return True
    End Function
    Public Shared Function IsAnimatedGif(ByVal filename As String) As Boolean
        If IsValidImage(filename) Then
            Dim MyImage As System.Drawing.Image = System.Drawing.Image.FromFile(filename)
            Dim FrameDimensions As New System.Drawing.Imaging.FrameDimension(MyImage.FrameDimensionsList(0))
            Dim NumberOfFrames As Integer = MyImage.GetFrameCount(FrameDimensions)
            Return NumberOfFrames > 1
        Else
            Return False
        End If
    End Function
End Class
