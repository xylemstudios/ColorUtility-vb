Public Class ColorManager
    Enum ColorSpace
        RGB = 0
        HSV = 1
    End Enum

    Public Structure RGBColor
        Public R As Byte
        Public G As Byte
        Public B As Byte
        Public A As Byte
        Public Shared Widening Operator CType(ByVal c As RGBColor) As Color
            Return c.ToColor()
        End Operator
        Public Shared Widening Operator CType(ByVal c As RGBColor) As HSVColor
            Return c.ToHSVColor()
        End Operator
        Public Shared Widening Operator CType(ByVal c As Color) As RGBColor
            Return New RGBColor(c.R, c.G, c.B, c.A)
        End Operator
        Sub New(ByVal red As Byte, ByVal green As Byte, ByVal blue As Byte, ByVal alpha As Byte)
            R = red
            G = green
            B = blue
            A = alpha
        End Sub
        Sub New(ByVal red As Byte, ByVal green As Byte, ByVal blue As Byte)
            R = red
            G = green
            B = blue
            A = 255
        End Sub
        '(to)
        Public Function ToColor() As Color
            Return Color.FromArgb(A, R, G, B)
        End Function
        Public Function ToHSVColor() As HSVColor
            Return RGBtoHSV(R, G, B, A)
        End Function
        Public Overrides Function ToString() As String
            Return "RGBA(" & R & ", " & G & ", " & B & ", " & A & ")"
        End Function
    End Structure
    Public Structure HSVColor
        Public H As Short
        Public S As Byte
        Public V As Byte
        Public A As Byte
        Public Shared Widening Operator CType(ByVal c As HSVColor) As Color
            Return c.ToColor()
        End Operator
        Public Shared Widening Operator CType(ByVal c As HSVColor) As RGBColor
            Return c.ToRGBColor()
        End Operator
        Public Shared Widening Operator CType(ByVal c As Color) As HSVColor
            Return RGBtoHSV(c)
        End Operator
        Sub New(ByVal hue As Short, ByVal saturation As Byte, ByVal value As Byte, ByVal alpha As Byte)
            H = hue
            S = saturation
            V = value
            A = alpha
        End Sub
        Sub New(ByVal hue As Short, ByVal saturation As Byte, ByVal value As Byte)
            H = hue
            S = saturation
            V = value
            A = 255
        End Sub
        '(to)
        Public Function ToColor() As Color
            Return HSVtoRGB(H, S, V, A)
        End Function
        Public Function ToRGBColor() As RGBColor
            Dim c = HSVtoRGB(H, S, V, A)
            Return New RGBColor(c.R, c.G, c.B, c.A)
        End Function
        Public Overrides Function ToString() As String
            Return "HSVA(" & H & "º, " & S & "%, " & V & "%, " & A & ")"
        End Function
    End Structure

    Public Shared Function RGBtoHSV(ByVal c As Color) As HSVColor
        Return RGBtoHSV(c.R, c.G, c.B, c.A)
    End Function
    Public Shared Function RGBtoHSV(ByVal r As Byte, ByVal g As Byte, ByVal b As Byte, ByVal a As Byte) As HSVColor
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
        Return New HSVColor(h, s, v, a)
    End Function
    Public Shared Function HSVtoRGB(ByVal c As HSVColor) As Color
        Return HSVtoRGB(c.H, c.S, c.V, c.A)
    End Function
    Public Shared Function HSVtoRGB(ByVal h As Short, ByVal s As Byte, ByVal v As Byte, ByVal a As Byte) As Color
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

    Dim _colorspace As ColorSpace
    Dim _rgb As RGBColor
    Dim _hsv As HSVColor
    Public Event ColorChanged()
    Public Event BeforeColorChange(ByVal prev As Object)
    Public Sub New()
        _colorspace = ColorSpace.RGB
        _rgb = New RGBColor(0, 0, 0, 255)
        _hsv = _rgb.ToHSVColor()
    End Sub

    Public Property CurrentSpace As ColorSpace
        Get
            Return _colorspace
        End Get
        Set(ByVal value As ColorSpace)
            _colorspace = value
        End Set
    End Property
    Public Property RGB As RGBColor
        Get
            Return _rgb
        End Get
        Set(ByVal value As RGBColor)
            RaiseEvent BeforeColorChange(value)
            _rgb = value
            _hsv = value.ToHSVColor
            _colorspace = ColorSpace.RGB
            RaiseEvent ColorChanged()
        End Set
    End Property
    Public Property HSV As HSVColor
        Get
            Return _hsv
        End Get
        Set(ByVal value As HSVColor)
            RaiseEvent BeforeColorChange(value)
            _hsv = value
            _rgb = value.ToRGBColor
            _colorspace = ColorSpace.HSV
            RaiseEvent ColorChanged()
        End Set
    End Property
End Class
