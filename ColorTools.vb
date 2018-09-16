Public Class ColorTools
    Structure HSVColor
        Public Hue As Integer
        Public Saturation As Integer
        Public Value As Integer
        Sub New(ByVal h As Integer, ByVal s As Integer, ByVal v As Integer)
            Hue = h
            Saturation = s
            Value = v
        End Sub
        Public Overrides Function ToString() As String
            Return "HSV(" & Hue & "º, " & Saturation & "%, " & Value & "%)"
        End Function
        Public Function ToColor() As Color
            Return HSVtoRGB(Me)
        End Function
    End Structure
    Public Shared Function RGBtoHSV(ByVal c As Color) As HSVColor
        Return RGBtoHSV(c.R, c.G, c.B)
    End Function
    Public Shared Function RGBtoHSV(ByVal r As Byte, ByVal g As Byte, ByVal b As Byte) As HSVColor
        'init variables
        Dim h, s, v As Double
        ' R,G,B ∈ [0, 1]
        Dim red As Double = r / 255
        Dim green As Double = g / 255
        Dim blue As Double = b / 255
        'other variables
        Dim max As Double = Math.Max(Math.Max(red, green), blue)
        Dim min As Double = Math.Min(Math.Min(red, green), blue)
        Dim chroma As Double = max - min
        'CALCULATION OF HUE
        Select Case max
            Case min
                h = 0
            Case red
                h = (60 * (green - blue) / chroma + 360) Mod 360
            Case green
                h = 60 * (blue - red) / chroma + 120
            Case blue
                h = 60 * (red - green) / chroma + 240
        End Select
        'CALCULATION OF SATURATION
        s = If(max = 0, 0, 1 - (min / max))
        'CALCULATION OF VALUE
        v = max

        'V,S is a %
        v = Math.Round(v * 100)
        s = Math.Round(s * 100)
        h = Math.Round(h)
        Return New HSVColor(h, s, v)
    End Function
    Public Shared Function HSVtoRGB(ByVal c As HSVColor) As Color
        Return HSVtoRGB(c.Hue, c.Saturation, c.Value)
    End Function
    Public Shared Function HSVtoRGB(ByVal h As Integer, ByVal s As Integer, ByVal v As Integer) As Color
        Dim r, g, b As Double
        Dim hue As Double = h
        If hue >= 360 Then hue = hue - 360
        Dim sat As Double = s / 100
        Dim val As Double = v / 100
        'variables and calculation
        Dim tempT = Math.Floor((hue / 60) Mod 6)
        Dim f As Double = hue / 60 - tempT
        Dim l As Double = val * (1 - sat)
        Dim m As Double = val * (1 - f * sat)
        Dim n As Double = val * (1 - (1 - f) * sat)

        Select Case tempT
            Case 0
                r = val : g = n : b = l
            Case 1
                r = m : g = val : b = l
            Case 2
                r = l : g = val : b = n
            Case 3
                r = l : g = m : b = val
            Case 4
                r = n : g = l : b = val
            Case 5
                r = val : g = l : b = m
        End Select

        r = Math.Round(r * 255)
        g = Math.Round(g * 255)
        b = Math.Round(b * 255)

        Return Color.FromArgb(r, g, b)
    End Function
End Class
