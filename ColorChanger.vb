Imports System.Text.RegularExpressions

Public Class ColorChanger
    Private Function HexToDecimalValue(ByVal hexCharacter As String) As Integer
        Select Case hexCharacter
            Case "A"
                Return 10
            Case "B"
                Return 11
            Case "C"
                Return 12
            Case "D"
                Return 13
            Case "E"
                Return 14
            Case "F"
                Return 15
            Case Else
                Return hexCharacter
        End Select
    End Function
    Public Function HexToDec(ByVal R As Byte, ByVal G As Byte, ByVal B As Byte) As Integer
        Dim hex As String = ColorTranslator.ToHtml(Color.FromArgb(R, G, B))
        Dim resultInteger As Integer = 0
        Dim index As Integer = hex.Length
        For Each c As String In hex
            index -= 1
            If Not c = "#" Then
                resultInteger += HexToDecimalValue(c) * 16 ^ index
            End If
        Next
        Return resultInteger
    End Function
    Public Function HexToDec(ByVal hex As String) As Integer
        Dim resultInteger As Integer = 0
        Dim index As Integer = hex.Length
        For Each c As String In hex
            index -= 1
            If Not c = "#" Then
                resultInteger += HexToDecimalValue(c) * 16 ^ index
            End If
        Next
        Return resultInteger
    End Function
    Public Function DecToHex(ByVal decValue As Integer) As String
        If decValue <= 16777215 And decValue >= 0 Then
            Dim R As Byte = Math.Floor(decValue / 65536)
            decValue = decValue - R * 65536
            Dim G As Byte = Math.Floor(decValue / 256)
            decValue = decValue - G * 256
            Dim B As Byte = decValue
            Return ColorTranslator.ToHtml(Color.FromArgb(R, G, B))
        Else
            Throw New ArgumentOutOfRangeException
        End If
    End Function
    Public Function DecToColor(ByVal decValue As Integer) As Color
        If decValue <= 16777215 And decValue >= 0 Then
            Dim R As Byte = Math.Floor(decValue / 65536)
            decValue = decValue - R * 65536
            Dim G As Byte = Math.Floor(decValue / 256)
            decValue = decValue - G * 256
            Dim B As Byte = decValue
            Return Color.FromArgb(R, G, B)
        Else
            Throw New ArgumentOutOfRangeException
        End If
    End Function
    Public Function GrayscaleColor(ByVal value As Byte) As Color
        Return Color.FromArgb(value, value, value)
    End Function
    Public Function isValidHexColorCode(ByVal hexColorCode As String) As Boolean
        Return If(hexColorCode = "", False, New Regex("^\#([a-fA-F0-9]{6}|[a-fA-F0-9]{3})$").IsMatch(hexColorCode))
    End Function
    Public Function ToHtml(ByVal colorObj As System.Drawing.Color) As String
        Return ColorTranslator.ToHtml(Color.FromArgb(colorObj.R, colorObj.G, colorObj.B))
    End Function
    Public Function FixHex(ByVal value As String) As String
        Return If(value.Length = 1, value & value, If(value.Length = 2, value, Nothing))
    End Function
    Public Function WebsafeColorHex(ByVal c As Color) As String
        Dim _step As Short = 51
        Dim result As String = ""
        Dim r, g, b As Byte
        Dim hexColor As String = ToHtml(c)
        hexColor = hexColor.Replace("#", "")
        r = HexToDec(hexColor.Remove(2, 4))
        g = HexToDec(hexColor.Remove(0, 2).Remove(2, 2))
        b = HexToDec(hexColor.Remove(0, 4))
        Dim webSafe As Integer
        webSafe = _step * Math.Round(r / _step)
        result &= (Hex(webSafe)).PadLeft(2, "0")
        webSafe = _step * Math.Round(g / _step)
        result &= (Hex(webSafe)).PadLeft(2, "0")
        webSafe = _step * Math.Round(b / _step)
        result &= (Hex(webSafe)).PadLeft(2, "0")
        Return result
    End Function
    Public Function WebsafeColor(ByVal c As Color) As Color
        Dim _step As Short = 51
        Dim result As String = ""
        Dim r, g, b As Byte
        Dim hexColor As String = ToHtml(c)
        hexColor = hexColor.Replace("#", "")
        r = HexToDec(hexColor.Remove(2, 4))
        g = HexToDec(hexColor.Remove(0, 2).Remove(2, 2))
        b = HexToDec(hexColor.Remove(0, 4))
        Dim webSafe As Integer
        webSafe = _step * Math.Round(r / _step)
        result &= (Hex(webSafe)).PadLeft(2, "0")
        webSafe = _step * Math.Round(g / _step)
        result &= (Hex(webSafe)).PadLeft(2, "0")
        webSafe = _step * Math.Round(b / _step)
        result &= (Hex(webSafe)).PadLeft(2, "0")
        Return ColorTranslator.FromHtml("#" & result)
    End Function
    Public Function isWebsafeColor(ByVal c As Color) As Boolean
        Return (ToHtml(c).Replace("#", "") = WebsafeColorHex(c))
    End Function
End Class