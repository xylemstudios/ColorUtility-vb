Imports System.Text.RegularExpressions
Imports System.Runtime.InteropServices
Imports ColorUtility.ColorManager

#Region " Bugs, updates and shit "
'  PLANNED IDEAS:
'  Better color picker << class, to finish, v2.0 probs
'  CMYK color picker << to do v1.8 ~ v2.0 probs
'  On click of the color panel -> open new form with a list of changeable colors << v1.6 ~ v2.0 not sure, probs later
'  Alpha support << To do v1.6~2.0 probs later
'  Custom sliders << To do, implemented in 1.7-1.9 maybe? probs soon :D
'  Color swatchs << NEXT!! :D Compatibility: Photoshop, MCSkin3D

'  1.72 Major update (build 1337!)
'  Personal note: removed 512x icon, replaced with 128x
'  NEW >> Language provider :)
'  NEW >> Awesome color manager! :)
'  NEW >> HSV colorsliders :D::D::D:D:D::D:D:D:D
'  NEW >> added option to copy code after select in pickerdropper
'  RMV >> Advanced grayscale color tool removed, since HSV is there (saturation component)
'  IMP >> Color picker improved, will not start gathering color until user clicks + will get color on click up
'  IMP >> Color picker now can be exited with a right click
'  IMP >> Version number is now obtained through code :D
'  IMP >> Added delete with key in combiner form
'  FIX >> Color picker rightclick
'  FIX >> Language UI bug (combobox)
'  FIX >> Grayscale color filter now uses value HSV and not luma, big fix
'  CLN >> Code cleaned out completely
'  FIX >> Color picker doesn't handle 2 or more clicks at same time and bugs, completely fixed ;D
'  DEV >> Minor textbox empty text fixed :D
'  DEV >> changed control names for better management

'  1.60 SemiMajor update
'  NEW >> To websafe color button added :)
'  NEW >> "Get all colors in an image" in Other tools
'  NEW >> Added a rightclick menu to the color box for other color formats :D
'!!FIX >> Fixed the color picker taking too much mem
'  FIX >> Grayscale color in random color
'  CLN >> Cleaned out the code a lot (:D)
'  FIX >> Made adv. rand. color code better x)
'  FIX >> No more flashes on color picker

'  1.53 Major update
'  FIX >> Color picker cursor now doesn't reset
'  UPD >> Intensify color filter improved (PSc improvement too)
'  NEW >> Color tools
'  DEV >> Building var in settings removed, made better :)
'  FIX >> Removed txt.keypress and stuff to make keyboard shortcuts available :D
'  FIX >> Color picker now uses less memory

'  1.48
'  NEW >> Hex and Dec txtbox now goes red (Color.Tomato) when the value is incorrect
'  NEW >> Intensify color filter (beta)
'  DEV >> Pipette cursor now dimmed directly in form1, no re-generation
'  FIX >> Color picker now crashes less because the cursor is not set everytime the background changes, big fix
'  FIX >> Reduced memory usage by 60% (color picker)
'  FIX >> Language bug in XP for < v.3.5 net framework

'  1.42
'  FIX >> Norwegian detection
'  FIX >> Reduced memory usage
'  FIX >> Big TextBox1 FIX!!!!
'  FIX >> Color picker doesn't use too much memory
'  NEW >> Credits added

'  1.30 Major update
'  NEW >> Norwegian, French and Spanish support.
'  NEW >> Random color added
'  DEV >> Added "Form1.Focus()" so the window still has same colors
'  FIX >> Optimized the color picker again
'  FIX >> My.Settings not saving fixed
'  BUG >> Color picker uses a lot of memory if idle.
#End Region
Public Class Form1
#Region " Variables, structures and enums"
    Dim clrChanger As New ColorChanger
    Dim colorTyping As Boolean = False
    Public pipetteCursor As Cursor = ColorPickerCursor.ImageToCursor(My.Resources.pipette, 9, 22)
    Dim rgbTyping As Boolean = False
    Dim hsvTyping As Boolean = False
    Dim rgbPicClicking As Boolean = False
    Dim hsvPicClicking As Boolean = False
    Public WithEvents colormanager As New ColorManager
    Public WithEvents languageProvider As LanguageProvider
    Public colorPickerIsOn As Boolean = False
    Dim b As Boolean = False
    Dim prevColor As Object 'object cause can be HSVColor or RGBColor, depending on color space we're working in.
    Enum ColorFilters
        Grayscale
        Negative
        Sepia
        Brighter
        Darker
        Intensify
        RedOnly
        GreenOnly
        BlueOnly
        RGBShuffle
    End Enum
    Dim lang_hoverfilter As String
    Dim lang_hovertool As String
#End Region
#Region " Functions "
    Public Function isValidHexColorCode(ByVal hexColorCode As String) As Boolean
        Return If(hexColorCode = "", False, New Regex("^\#([a-fA-F0-9]{6}|[a-fA-F0-9]{3})$").IsMatch(hexColorCode))
    End Function
    Public Shared Function MakeGradient(ByVal StartColor As Color, ByVal EndColor As Color, ByVal width As Integer, ByVal height As Integer, Optional ByVal LinearGradientMode As Drawing2D.LinearGradientMode = Drawing2D.LinearGradientMode.Horizontal) As Image
        Dim resultImage As New Bitmap(width, height, Imaging.PixelFormat.Format32bppArgb)
        Dim g As Graphics = Graphics.FromImage(resultImage)
        g.SmoothingMode = Drawing2D.SmoothingMode.HighSpeed
        g.InterpolationMode = Drawing2D.InterpolationMode.Low
        g.CompositingQuality = Drawing2D.CompositingQuality.HighSpeed
        g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighSpeed
        g.FillRectangle(New Drawing2D.LinearGradientBrush(New Rectangle(New Point(0, 0), New Size(width, height)), StartColor, EndColor, LinearGradientMode), New Rectangle(New Point(0, 0), New Size(width, height)))
        Return resultImage
    End Function
    Public Function ClippedColor(ByVal r As Integer, ByVal g As Integer, ByVal b As Integer) As Color
        Return Color.FromArgb(If(r < 0, 0, If(r > 255, 255, r)), If(g < 0, 0, If(g > 255, 255, g)), If(b < 0, 0, If(b > 255, 255, b)))
    End Function
    Public Function ApplyColorFilter(ByVal _color As Color, ByVal filter As ColorFilters) As Color
        Select Case filter
            Case ColorFilters.Grayscale
                Dim luma As Integer = New RGBColor(_color.R, _color.G, _color.B).ToHSVColor().V / 100 * 255
                Return Color.FromArgb(luma, luma, luma)
            Case ColorFilters.Negative
                Return Color.FromArgb(255 - _color.R, 255 - _color.G, 255 - _color.B)
            Case ColorFilters.Sepia
                Dim outR = (_color.R * 0.393) + (_color.G * 0.769) + (_color.B * 0.189)
                Dim outG = (_color.R * 0.349) + (_color.G * 0.686) + (_color.B * 0.168)
                Dim outB = (_color.R * 0.272) + (_color.G * 0.534) + (_color.B * 0.131)
                Return ClippedColor(outR, outG, outB)
            Case ColorFilters.Brighter
                Return ClippedColor(_color.R + 20, _color.G + 20, _color.B + 20)
            Case ColorFilters.Darker
                Return ClippedColor(_color.R - 20, _color.G - 20, _color.B - 20)
            Case ColorFilters.Intensify
                Dim outR As Short = _color.R
                Dim outG As Short = _color.G
                Dim outB As Short = _color.B
                If outR = outG And outR = outB Then ''grayscale
                    If outR >= 126 Then 'brighter
                        Return ApplyColorFilter(Color.FromArgb(_color.R, _color.G, _color.B), ColorFilters.Brighter)
                    Else 'darker
                        Return ApplyColorFilter(Color.FromArgb(_color.R, _color.G, _color.B), ColorFilters.Darker)
                    End If
                Else 'not grayscale
                    Select Case Math.Max(Math.Max(outR, outG), outB)
                        Case outR
                            If outR = outG Or outR = outB Then GoTo except
                            outR += 20
                            outG += 3 + Math.Round(outR / 255 * 5)
                            outB += 2 + Math.Round(outR / 255 * 5)
                        Case outG
                            If outG = outR Or outG = outB Then GoTo except
                            outG += 20
                            outR += 2 + Math.Round(outG / 255 * 5)
                            outB += 3 + Math.Round(outG / 255 * 5)
                        Case outB
                            If outB = outR Or outB = outG Then GoTo except
                            outB += 20
                            outR += 2 + Math.Round(outB / 255 * 5)
                            outG += 3 + Math.Round(outB / 255 * 5)

                    End Select
                    Return ClippedColor(outR, outG, outB)
except:
                    If outR = outG Then
                        outR += 20
                        outG += 20
                        outB += 3 + Math.Round(outR / 255 * 5)
                        Return ClippedColor(outR, outG, outB)
                    ElseIf outR = outB Then
                        outR += 20
                        outB += 20
                        outG += 3 + Math.Round(outB / 255 * 5)
                        Return ClippedColor(outR, outG, outB)
                    ElseIf outB = outG Then
                        outB += 20
                        outG += 20
                        outR += 3 + Math.Round(outG / 255 * 5)
                        Return ClippedColor(outR, outG, outB)
                    End If
                End If
            Case ColorFilters.RedOnly
                Return Color.FromArgb(_color.R, 0, 0)
            Case ColorFilters.GreenOnly
                Return Color.FromArgb(0, _color.G, 0)
            Case ColorFilters.BlueOnly
                Return Color.FromArgb(0, 0, _color.B)
            Case ColorFilters.RGBShuffle
                Return Color.FromArgb(_color.B, _color.R, _color.G)
            Case Else
                Return Nothing
        End Select
    End Function
#End Region
#Region " Subs "
#Region " RGB Color Picker "
    Private Sub bar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles red_bar.Scroll, green_bar.Scroll, blue_bar.Scroll
        colormanager.RGB = New RGBColor(red_bar.Value, green_bar.Value, blue_bar.Value)
    End Sub
    Private Sub txt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles blue_txt.GotFocus, red_txt.GotFocus, green_txt.GotFocus
        rgbTyping = True
    End Sub
    Private Sub txt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles blue_txt.LostFocus, red_txt.LostFocus, green_txt.LostFocus
        rgbTyping = False
    End Sub
    Private Sub txt_TextChanged(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles red_txt.TextChanged, green_txt.TextChanged, blue_txt.TextChanged
        Try
            If rgbTyping Then
                If sender.Text <> "" And IsNumeric(sender.Text) And isCompatibleNumeric(sender.Text) Then
                    If sender.Text <= 255 And sender.Text >= 0 Then
                        sender.BackColor = SystemColors.Window
                        If Not red_txt.BackColor = Color.Tomato And Not green_txt.BackColor = Color.Tomato And Not blue_txt.BackColor = Color.Tomato Then _
                            colormanager.RGB = New RGBColor(red_txt.Text, green_txt.Text, blue_txt.Text)
                    Else
                        sender.BackColor = Color.Tomato
                    End If
                Else
                    sender.BackColor = Color.Tomato
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub pic_MouseDown(ByVal sender As PictureBox, ByVal e As System.Windows.Forms.MouseEventArgs) Handles red_pic.MouseDown, green_pic.MouseDown, blue_pic.MouseDown
        sender.Focus()
        If e.Button = Windows.Forms.MouseButtons.Left Then
            rgbPicClicking = True
            Dim v As Byte = Math.Round(e.X / red_pic.Image.Width * 255)
            If v < 0 Then v = 0 : If v > 255 Then v = 255
            If sender Is red_pic Then
                red_bar.Value = v
            ElseIf sender Is green_pic Then
                green_bar.Value = v
            ElseIf sender Is blue_pic Then
                blue_bar.Value = v
            End If
            colormanager.RGB = New RGBColor(red_bar.Value, green_bar.Value, blue_bar.Value)
        End If
    End Sub
    Private Sub pic_MouseMove(ByVal sender As PictureBox, ByVal e As System.Windows.Forms.MouseEventArgs) Handles red_pic.MouseMove, green_pic.MouseMove, blue_pic.MouseMove
        If rgbPicClicking And e.Button = Windows.Forms.MouseButtons.Left Then
            Dim v As Byte
            Dim x As Integer = e.X
            Try
                If x < 0 Then x = 0 : If x > sender.Width Then x = sender.Width
                v = Math.Round(x / red_pic.Image.Width * 255)
                If v < 0 Then v = 0 : If v > 255 Then v = 255
            Catch ex As Exception
                v = If(e.X < 0, 0, 255)
            End Try
            If sender Is red_pic Then
                red_bar.Value = v
            ElseIf sender Is green_pic Then
                green_bar.Value = v
            ElseIf sender Is blue_pic Then
                blue_bar.Value = v
            End If
            colormanager.RGB = New RGBColor(red_bar.Value, green_bar.Value, blue_bar.Value)
        End If
    End Sub
    Private Sub pic_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles red_pic.MouseUp, green_pic.MouseUp, blue_pic.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then rgbPicClicking = False
    End Sub
#End Region ''cleaned
#Region " HSV Color Picker "
    Private Sub hsvbar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hue_bar.Scroll, saturation_bar.Scroll, value_bar.Scroll
        colormanager.HSV = New HSVColor(hue_bar.Value, saturation_bar.Value, value_bar.Value, 255)
    End Sub
    Private Sub hsvtxt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles hue_txt.GotFocus, saturation_txt.GotFocus, value_txt.GotFocus
        hsvTyping = True
    End Sub
    Private Sub hsvtxt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles hue_txt.LostFocus, saturation_txt.LostFocus, value_txt.LostFocus
        hsvTyping = False
    End Sub
    Private Sub hsvtxt_TextChanged(ByVal sender As TextBox, ByVal e As System.EventArgs) Handles hue_txt.TextChanged, saturation_txt.TextChanged, value_txt.TextChanged
        Try
            If hsvTyping Then
                Dim max As Integer = If(sender Is hue_txt, 360, 100)
                If sender.Text <> "" And IsNumeric(sender.Text) And isCompatibleNumeric(sender.Text) Then
                    If sender.Text <= max And sender.Text >= 0 Then
                        sender.BackColor = SystemColors.Window
                        If Not hue_txt.BackColor = Color.Tomato And Not saturation_txt.BackColor = Color.Tomato And Not value_txt.BackColor = Color.Tomato Then _
                            colormanager.HSV = New HSVColor(hue_txt.Text, saturation_txt.Text, value_txt.Text, 255)
                    Else
                        sender.BackColor = Color.Tomato
                    End If
                Else
                    sender.BackColor = Color.Tomato
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub hsvpic_MouseDown(ByVal sender As PictureBox, ByVal e As System.Windows.Forms.MouseEventArgs) Handles hue_pic.MouseDown, saturation_pic.MouseDown, value_pic.MouseDown
        sender.Focus()
        If e.Button = Windows.Forms.MouseButtons.Left Then
            hsvPicClicking = True
            Dim m As Integer = If(sender Is hue_pic, 360, 100)
            Dim v As Integer = Math.Round(e.X / red_pic.Image.Width * m)
            If v < 0 Then v = 0 : If v > m Then v = m
            If sender Is hue_pic Then
                hue_bar.Value = v
            ElseIf sender Is saturation_pic Then
                saturation_bar.Value = v
            ElseIf sender Is value_pic Then
                value_bar.Value = v
            End If
            colormanager.HSV = New HSVColor(hue_bar.Value, saturation_bar.Value, value_bar.Value, 255)
        End If
    End Sub
    Private Sub hsvpic_MouseMove(ByVal sender As PictureBox, ByVal e As System.Windows.Forms.MouseEventArgs) Handles hue_pic.MouseMove, saturation_pic.MouseMove, value_pic.MouseMove
        If hsvPicClicking And e.Button = Windows.Forms.MouseButtons.Left Then
            Dim v As Integer
            Dim x As Integer = e.X
            Dim m As Integer = If(sender Is hue_pic, 360, 100)

            If x < 0 Then x = 0 : If x > sender.Width Then x = sender.Width
            v = Math.Round(x / red_pic.Image.Width * m)
            If v < 0 Then v = 0 : If v > m Then v = m
            If sender Is hue_pic Then
                hue_bar.Value = If(v > m, m, If(v < 0, 0, v))
            ElseIf sender Is saturation_pic Then
                saturation_bar.Value = If(v > m, m, If(v < 0, 0, v))
            ElseIf sender Is value_pic Then
                value_bar.Value = If(v > m, m, If(v < 0, 0, v))
            End If
            colormanager.HSV = New HSVColor(hue_bar.Value, saturation_bar.Value, value_bar.Value, 255)
        End If
    End Sub
    Private Sub hsvpic_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles hue_pic.MouseUp, saturation_pic.MouseUp, value_pic.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then hsvPicClicking = False
    End Sub
#End Region
#Region " Filters "
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f_grayBtn.Click
        colormanager.RGB = ApplyColorFilter(colorPanel.BackColor, ColorFilters.Grayscale)
    End Sub
    Private Sub Button2_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles f_grayBtn.MouseEnter
        filterDesc.Text = lang("FILTER_DESC", "GRAYSCALE")
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f_negativeBtn.Click
        colormanager.RGB = ApplyColorFilter(colormanager.RGB, ColorFilters.Negative)
    End Sub
    Private Sub Button3_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles f_negativeBtn.MouseEnter
        filterDesc.Text = lang("FILTER_DESC", "NEGATIVE")
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f_sepiaBtn.Click
        colormanager.RGB = ApplyColorFilter(colormanager.RGB, ColorFilters.Sepia)
    End Sub
    Private Sub Button4_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles f_sepiaBtn.MouseEnter
        filterDesc.Text = lang("FILTER_DESC", "SEPIA")
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f_brighterBtn.Click
        colormanager.RGB = ApplyColorFilter(colormanager.RGB, ColorFilters.Brighter)
    End Sub
    Private Sub Button5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles f_brighterBtn.MouseEnter
        filterDesc.Text = lang("FILTER_DESC", "BRIGHTER")
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f_darkerBtn.Click
        colormanager.RGB = ApplyColorFilter(colormanager.RGB, ColorFilters.Darker)
    End Sub
    Private Sub Button6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles f_darkerBtn.MouseEnter
        filterDesc.Text = lang("FILTER_DESC", "DARKER")
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f_intensifyBtn.Click
        colormanager.RGB = ApplyColorFilter(colormanager.RGB, ColorFilters.Intensify)
    End Sub
    Private Sub Button9_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles f_intensifyBtn.MouseEnter
        filterDesc.Text = lang("FILTER_DESC", "INTENSIFY")
    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f_redBtn.Click
        colormanager.RGB = ApplyColorFilter(colormanager.RGB, ColorFilters.RedOnly)
    End Sub
    Private Sub Button11_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles f_redBtn.MouseEnter
        filterDesc.Text = lang("FILTER_DESC", "REDONLY")
    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f_greenBtn.Click
        colormanager.RGB = ApplyColorFilter(colormanager.RGB, ColorFilters.GreenOnly)
    End Sub
    Private Sub Button12_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles f_greenBtn.MouseEnter
        filterDesc.Text = lang("FILTER_DESC", "GREENONLY")
    End Sub
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f_blueBtn.Click
        colormanager.RGB = ApplyColorFilter(colormanager.RGB, ColorFilters.BlueOnly)
    End Sub
    Private Sub Button13_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles f_blueBtn.MouseEnter
        filterDesc.Text = lang("FILTER_DESC", "BLUEONLY")
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f_rgbShuffleBtn.Click
        colormanager.RGB = ApplyColorFilter(colormanager.RGB, ColorFilters.RGBShuffle)
    End Sub
    Private Sub Button1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f_rgbShuffleBtn.MouseEnter
        filterDesc.Text = lang("FILTER_DESC", "RGBSHUFFLE")
    End Sub
    Private Sub Panel2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles filtersPanel.MouseLeave
        filterDesc.Text = lang_hoverfilter
    End Sub
#End Region ''cleaned
#Region " Other tools "
    'combiner
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t_combinerBtn.Click
        ColorCombinerForm.Show()
        ColorCombinerForm.BringToFront()
    End Sub
    Private Sub Button15_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles t_combinerBtn.MouseEnter
        toolDesc.Text = lang("TOOL_DESC", "COMBINER")
    End Sub
    'advanced random color
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t_randomBtn.Click
        AdvancedRandomColorForm.Show()
        AdvancedRandomColorForm.BringToFront()
        InitializeLanguage()
    End Sub
    Private Sub Button10_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles t_randomBtn.MouseEnter
        toolDesc.Text = lang("TOOL_DESC", "ADVANCEDRANDOM")
    End Sub
    'get all colors in an image
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t_colorsImageBtn.Click
        GetImageColorForm.Show()
        GetImageColorForm.BringToFront()
        InitializeLanguage()
    End Sub
    Private Sub Button8_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles t_colorsImageBtn.MouseEnter
        toolDesc.Text = lang("TOOL_DESC", "ALLCOLORSIMAGE")
    End Sub
    Private Sub Panel3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles tool_panel.MouseLeave
        toolDesc.Text = lang_hovertool
    End Sub
#End Region ''cleaned
#Region " Dec-Code Textbox "
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles decTxt.TextChanged
        Try
            If IsNumeric(decTxt.Text) And isCompatibleNumeric(decTxt.Text) Then
                If (decTxt.Focused) Then
                    colormanager.RGB = clrChanger.DecToColor(decTxt.Text)
                    decTxt.BackColor = SystemColors.Window
                End If
            Else
                decTxt.BackColor = Color.Tomato
            End If
        Catch ex As ArgumentOutOfRangeException
            decTxt.BackColor = Color.Tomato
        End Try
    End Sub
#End Region ''cleaned
#Region " Hex-Code Textbox "
    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles hexTxt.GotFocus
        colorTyping = True
    End Sub
    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles hexTxt.LostFocus
        colorTyping = False
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hexTxt.TextChanged
        Dim dcolor = hexTxt.Text.Replace("#", "")
        If isValidHexColorCode("#" & dcolor) Then
            If dcolor.Length = 3 Then
                Dim fcolor As String = ""
                For Each c As String In dcolor
                    fcolor &= c & c
                Next
                dcolor = fcolor : fcolor = Nothing
            ElseIf dcolor.Length = 6 Then : Else
                GoTo txt1No
            End If
            decTxt.Text = clrChanger.HexToDec("#" & dcolor)
            If Not dcolor = "" And isValidHexColorCode("#" & dcolor) Then
                If colorTyping Then
                    colormanager.RGB = ColorTranslator.FromHtml("#" & dcolor)
                    hexTxt.BackColor = SystemColors.Window
                End If
            Else
                GoTo txt1no
            End If
        Else
txt1No:
            hexTxt.BackColor = Color.Tomato
        End If
    End Sub
#End Region ''cleaned
#Region " On screen color picker "
    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colorPickerBtn.Click
        Try
            Form2.Show()
            Form2.prevColor = colormanager.RGB
            Form2.firstColor = colormanager.RGB
            colorPickerIsOn = True
        Catch ex As Exception
        End Try
    End Sub
#End Region ''cleaned
#Region " Application Settings "
#Region " Language "
    Function getLanguageRessource(ByVal s As String) As String
        Select Case My.Settings.language
            Case "fr"
                Return My.Resources.lang_Français
            Case "es"
                Return My.Resources.lang_Spanish
            Case "en"
                Return My.Resources.lang_English
            Case "nb"
                Return My.Resources.lang_Norwegian
            Case Else
                Return Nothing
        End Select
    End Function
    Function returnLongLangString(ByVal s As String)
        Select Case My.Settings.language
            Case "fr"
                Return "Français"
            Case "es"
                Return "Español"
            Case "en"
                Return "English"
            Case "nb"
                Return "Norsk"
            Case Else
                Return Nothing
        End Select
    End Function
    Function returnShortLangString(ByVal s As String)
        Select Case langCombo.SelectedItem
            Case "Français"
                Return "fr"
            Case "Español"
                Return "es"
            Case "English"
                Return "en"
            Case "Norsk"
                Return "nb"
            Case Else
                Return Nothing
        End Select
    End Function
    Private Sub InitializeLanguage(Optional ByVal open As Boolean = True)
        Dim setagain = (toolDesc.Text = lang_hovertool Or filterDesc.Text = lang_hoverfilter)
        If open Then languageProvider.OpenFile(getLanguageRessource(My.Settings.language))
        langCombo.SelectedItem = returnLongLangString(My.Settings.language)
        toolDesc.Text = lang_hovertool
        filterDesc.Text = lang_hoverfilter
        langSet.Enabled = False
    End Sub
    Private Sub updateLang()
        rgbTab.Text = lang("RGB")
        r_label.Text = lang("RGB", "R")
        g_label.Text = lang("RGB", "G")
        b_label.Text = lang("RGB", "B")

        hsvTab.Text = lang("HSV")
        h_label.Text = lang("HSV", "H")
        s_label.Text = lang("HSV", "S")
        v_label.Text = lang("HSV", "V")

        filtersTab.Text = lang("FILTERS")
        f_grayBtn.Text = lang("FILTERS", "GRAYSCALE")
        f_negativeBtn.Text = lang("FILTERS", "NEGATIVE")
        f_sepiaBtn.Text = lang("FILTERS", "SEPIA")
        f_brighterBtn.Text = lang("FILTERS", "BRIGHTER")
        f_darkerBtn.Text = lang("FILTERS", "DARKER")
        f_intensifyBtn.Text = lang("FILTERS", "INTENSIFY")
        f_redBtn.Text = lang("FILTERS", "REDONLY")
        f_greenBtn.Text = lang("FILTERS", "GREENONLY")
        f_blueBtn.Text = lang("FILTERS", "BLUEONLY")
        f_rgbShuffleBtn.Text = lang("FILTERS", "RGBSHUFFLE")

        filterLabel.Text = lang("FILTER_DESC")

        'Other tools
        othertoolsTab.Text = lang("TOOLS")
        t_combinerBtn.Text = lang("TOOLS", "COMBINER")
        t_randomBtn.Text = lang("TOOLS", "ADVANCEDRANDOM")
        t_colorsImageBtn.Text = lang("TOOLS", "ALLCOLORSIMAGE")

        toolLabel.Text = lang("TOOL_DESC")

        'DO NOT REMOVE THESE VARIABLES :P
        lang_hoverfilter = lang("FILTERS", "HOVER")
        lang_hovertool = lang("TOOLS", "HOVER")

        settingsTab.Text = lang("SETTINGS")
        speedLabel.Text = lang("SETTINGS", "SPEED")
        speedChk.Text = lang("SETTINGS", "OPTIMIZE")
        spaceLabel.Text = lang("SETTINGS", "SPACES")
        rgbChk.Text = lang("RGB")
        hsvChk.Text = lang("HSV")
        langLabel.Text = lang("SETTINGS", "LANGUAGE")
        langSet.Text = lang("SETTINGS", "LANGUAGESET")
        clipLabel.Text = lang("SETTINGS", "CLIPBOARD")
        clipChk.Text = lang("SETTINGS", "CLIP_COPY")

        creditsTab.Text = lang("CREDITS")
        credCodeLabel.Text = lang("CREDITS", "CODED")
        credNorskLabel.Text = lang("CREDITS", "NORWEGIAN")
        WebsitePopup.ToolTipTitle = lang("CREDITS", "WEBSITE")

        InfoPopup.ToolTipTitle = lang("INFO")
        InfoPopup.SetToolTip(colorPickerBtn, lang("INFO", "PICKER"))
        InfoPopup.SetToolTip(randomColorBtn, lang("INFO", "RANDOM"))
        InfoPopup.SetToolTip(webColorBtn, lang("INFO", "WEBSAFE"))
        InfoPopup.SetToolTip(colorPanel, lang("INFO", "COLOR_RIGHTCLICK"))
        InfoPopup.SetToolTip(speedChk, lang("INFO", "SPEED"))
        InfoPopup.SetToolTip(clipChk, lang("INFO", "CLIPBOARD_HEX"))

        CopyVBNetColorFromArgbToolStripMenuItem.Text = lang("FORMATS", "VBNET")
        CopyHexForVBToolStripMenuItem.Text = lang("FORMATS", "VBHEX")
        CopyForCSSToolStripMenuItem.Text = lang("FORMATS", "CSS")
        CopyForWinFormsToolStripMenuItem.Text = lang("FORMATS", "WINFORMS")
        CopyHexToolStripMenuItem.Text = lang("FORMATS", "HEX")
        CopyHSVToolStripMenuItem.Text = lang("FORMATS", "HSV")
    End Sub
    Private Sub languageProvider_LanguageUpdated() Handles languageProvider.LanguageUpdated
        updateLang()
        ColorCombinerForm.updateLang()
        Debug.Print("colorcombiner")
        AdvancedRandomColorForm.updateLang()
        Debug.Print("advanced")
        GetImageColorForm.updateLang()
        Debug.Print("getimage")
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles langSet.Click
        My.Settings.language = returnShortLangString(langCombo.SelectedItem)
        InitializeLanguage()
        langSet.Enabled = False
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles langCombo.SelectedIndexChanged
        langSet.Enabled = returnShortLangString(langCombo.SelectedItem.ToString) <> My.Settings.language
    End Sub
#End Region ''cleaned
#Region " Speed "
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles speedChk.CheckedChanged
        My.Settings.optimizeSpeed = speedChk.Checked
    End Sub
#End Region
#Region " Clipboard "
    Private Sub clipChk_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles clipChk.CheckedChanged
        My.Settings.clipCopy = clipChk.Checked
    End Sub
#End Region
#Region " Color types "
    Private Sub HideTabPage(ByVal tp As TabPage)
        If TabControl1.TabPages.Contains(tp) Then TabControl1.TabPages.Remove(tp)
    End Sub
    Private Sub ShowTabPage(ByVal tp As TabPage)
        ShowTabPage(tp, TabControl1.TabPages.Count)
    End Sub
    Private Sub ShowTabPage(ByVal tp As TabPage, ByVal index As Integer)
        If TabControl1.TabPages.Contains(tp) Then Return
        InsertTabPage(tp, index)
    End Sub
    Private Sub InsertTabPage(ByVal [tabpage] As TabPage, ByVal [index] As Integer)
        If [index] < 0 Or [index] > TabControl1.TabCount Then
            Throw New ArgumentException("Index out of Range.")
        End If
        TabControl1.TabPages.Add([tabpage])
        If [index] < TabControl1.TabCount - 1 Then
            Do While TabControl1.TabPages.IndexOf([tabpage]) <> [index]
                SwapTabPages([tabpage], (TabControl1.TabPages(TabControl1.TabPages.IndexOf([tabpage]) - 1)))
            Loop
        End If
    End Sub
    Private Sub SwapTabPages(ByVal tp1 As TabPage, ByVal tp2 As TabPage)
        If TabControl1.TabPages.Contains(tp1) = False Or TabControl1.TabPages.Contains(tp2) = False Then
            Throw New ArgumentException("TabPages must be in the TabCotrols TabPageCollection.")
        End If
        Dim Index1 As Integer = TabControl1.TabPages.IndexOf(tp1)
        Dim Index2 As Integer = TabControl1.TabPages.IndexOf(tp2)
        TabControl1.TabPages(Index1) = tp2
        TabControl1.TabPages(Index2) = tp1
    End Sub
    Private Sub CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgbChk.CheckedChanged, hsvChk.CheckedChanged
        If TabControl1.SelectedTab IsNot settingsTab Then Exit Sub
        My.Settings.useRGB = rgbChk.Checked
        My.Settings.useHSV = hsvChk.Checked
        My.Settings.Save()
        rgbChk.Enabled = hsvChk.Checked
        hsvChk.Enabled = rgbChk.Checked
        If My.Settings.useRGB Then
            ShowTabPage(rgbTab, 0)
        Else
            HideTabPage(rgbTab)
        End If
        If My.Settings.useHSV Then
            ShowTabPage(hsvTab, If(TabControl1.TabPages.Contains(rgbTab), 1, 0))
        Else
            HideTabPage(hsvTab)
        End If
        TabControl1.SelectedTab = settingsTab
        sender.focus()
    End Sub
#End Region
#End Region ''cleaned
#Region " Other "
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Save()
        End
    End Sub
    Private Function getHexWithoutHash(ByVal s As String)
        If s.StartsWith("#") And s.Split("#").Length = 1 And s.Length = 7 And isValidHexColorCode(s) Then Return s.Remove(0, 1)
        If s.Length = 6 And isValidHexColorCode("#" & s) Then Return s
        Return String.Empty
    End Function
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        'load settings
        speedChk.Checked = My.Settings.optimizeSpeed
        rgbChk.Checked = My.Settings.useRGB
        If Not My.Settings.useRGB Then HideTabPage(rgbTab)
        hsvChk.Checked = My.Settings.useHSV
        If Not My.Settings.useHSV Then HideTabPage(hsvTab)
        'clipChk.Checked = My.Settings.clipCopy

        If My.Settings.firstTime Then
            Try
                My.Settings.language = System.Globalization.CultureInfo.InstalledUICulture.TwoLetterISOLanguageName
                My.Settings.firstTime = False
            Catch ex As Exception
            End Try
        End If
        languageProvider = New LanguageProvider()
        InitializeLanguage()
        Form2.Cursor = pipetteCursor

        credVersionLabel.Text = "v" & My.Application.Info.Version.ToString(2) & ", Build " & My.Application.Info.Version.Build

        filterDesc.Text = lang_hoverfilter
        toolDesc.Text = lang_hovertool

        Dim clipTxt = getHexWithoutHash(Clipboard.GetText)
        colormanager.RGB = If(clipTxt = Nothing, ColorTranslator.FromHtml("#000000"), ColorTranslator.FromHtml("#" & clipTxt))
        clipTxt = Nothing
    End Sub
    Private Sub colormanager_ColorChanged() Handles colormanager.ColorChanged
        updateRGB()
        updateHSV()

        'reset backcolors
        hue_txt.BackColor = SystemColors.Window
        saturation_txt.BackColor = SystemColors.Window
        value_txt.BackColor = SystemColors.Window
        red_txt.BackColor = SystemColors.Window
        green_txt.BackColor = SystemColors.Window
        blue_txt.BackColor = SystemColors.Window

        Dim _c As Color = colormanager.RGB
        'gradients
        saturation_pic.Image = _
        MakeGradient(New HSVColor(hue_txt.Text, 0, value_txt.Text), New HSVColor(hue_txt.Text, 100, value_txt.Text), 167, 10)
        value_pic.Image = _
        MakeGradient(Color.Black, New HSVColor(hue_txt.Text, saturation_txt.Text, 100), 167, 10)

        red_pic.Image = _
        MakeGradient(Color.FromArgb(0, _c.G, _c.B), Color.FromArgb(255, _c.G, _c.B), 167, 10)
        green_pic.Image = _
        MakeGradient(Color.FromArgb(_c.R, 0, _c.B), Color.FromArgb(_c.R, 255, _c.B), 167, 10)
        blue_pic.Image = _
        MakeGradient(Color.FromArgb(_c.R, _c.G, 0), Color.FromArgb(_c.R, _c.G, 255), 167, 10)

        colorPanel.BackColor = _c

        'filter and tools update
        f_grayBtn.Enabled = Not (_c.R = _c.B And _c.R = _c.G)
        f_brighterBtn.Enabled = Not (_c.R = 255 And _c.B = 255 And _c.G = 255)
        f_darkerBtn.Enabled = Not (_c.R = 0 And _c.B = 0 And _c.G = 0)
        f_intensifyBtn.Enabled = Not (_c.R = 255 Or _c.B = 255 Or _c.G = 255 Or (_c.R = 0 And _c.B = 0 And _c.G = 0))
        f_redBtn.Enabled = _c.R > 0 And (_c.B > 0 Or _c.G > 0)
        f_greenBtn.Enabled = _c.G > 0 And (_c.B > 0 Or _c.R > 0)
        f_blueBtn.Enabled = _c.B > 0 And (_c.R > 0 Or _c.G > 0)
        f_rgbShuffleBtn.Enabled = f_grayBtn.Enabled
        Dim sepiaTest As Color = ApplyColorFilter(_c, ColorFilters.Sepia)
        f_sepiaBtn.Enabled = sepiaTest <> _c
        'websafe update
        webColorBtn.Enabled = Not clrChanger.isWebsafeColor(_c)
        webColorBtn.Image = If(webColorBtn.Enabled, My.Resources.websafecoloricon, My.Resources.websafecoloricongray)
        hexTxt.Text = clrChanger.ToHtml(_c).Replace("#", "")
    End Sub
    Private Sub updateRGB()
        Dim rgb As RGBColor = colormanager.RGB
        red_txt.Text = rgb.R : red_bar.Value = rgb.R
        green_txt.Text = rgb.G : green_bar.Value = rgb.G
        blue_txt.Text = rgb.B : blue_bar.Value = rgb.B
    End Sub
    Private Sub updateHSV()
        Dim hsv As HSVColor = colormanager.HSV
        hue_txt.Text = hsv.H : hue_bar.Value = hsv.H
        saturation_txt.Text = hsv.S : saturation_bar.Value = hsv.S
        value_txt.Text = hsv.V : value_bar.Value = hsv.V
    End Sub
    Private Sub Panel1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles colorPanel.DragDrop
        colormanager.RGB = ColorTranslator.FromHtml(e.Data.GetData(DataFormats.Text))
    End Sub
    Private Sub Panel1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles colorPanel.DragEnter
        If (e.Data.GetDataPresent(DataFormats.Text) And isValidHexColorCode(e.Data.GetData(DataFormats.Text))) Then e.Effect = DragDropEffects.Copy
    End Sub
    Private Sub Panel1_GiveFeedback(ByVal sender As Object, ByVal e As System.Windows.Forms.GiveFeedbackEventArgs) Handles colorPanel.GiveFeedback
        e.UseDefaultCursors = False
        Cursor.Current = If((e.Effect And DragDropEffects.Copy) = DragDropEffects.Copy, New ColorCursor().CreateColorCursor(colormanager.RGB), System.Windows.Forms.Cursors.No)
    End Sub
    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles colorPanel.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then colorPanel.DoDragDrop(clrChanger.ToHtml(colorPanel.BackColor), DragDropEffects.Copy)
    End Sub
    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles colorPanel.Paint
        e.Graphics.DrawRectangle(New Pen(New SolidBrush(ApplyColorFilter(colormanager.RGB, ColorFilters.Negative)), 1), 0, 0, colorPanel.Width - 1, colorPanel.Height - 1)
    End Sub
    Private Sub randomColorBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles randomColorBtn.Click
        Dim n As New Random
        colormanager.RGB = Color.FromArgb(n.Next(0, 255), n.Next(0, 255), n.Next(0, 255))
        n = Nothing
    End Sub
    Private Sub webColorBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles webColorBtn.Click
        colormanager.RGB = clrChanger.WebsafeColor(colorPanel.BackColor)
    End Sub
    ''linking
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xylemLogo.Click
        Process.Start("http://xylemstudios.com")
    End Sub
    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles credCodeNameLabel.Click
        Process.Start("http://xylemstudios.com")
    End Sub
    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles credNorskNameLabel.Click
        Process.Start("http://triki-tech.com")
    End Sub
#End Region ''cleaned
#Region " Copy contextmenustrip "
    Private Sub CopyVBNetColorFromArgbToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyVBNetColorFromArgbToolStripMenuItem.Click
        Clipboard.SetText("Color.FromArgb(" & colormanager.RGB.R & ", " & colormanager.RGB.G & ", " & colormanager.RGB.B & ")")
    End Sub
    Private Sub CopyHexForVB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyHexForVBToolStripMenuItem.Click
        Clipboard.SetText("&H00" & Hex(colormanager.RGB.B) & Hex(colormanager.RGB.G) & Hex(colormanager.RGB.R))
    End Sub
    Private Sub CopyForWinFormsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyForWinFormsToolStripMenuItem.Click
        Clipboard.SetText(colormanager.RGB.R & "; " & colormanager.RGB.G & "; " & colormanager.RGB.B)
    End Sub
    Private Sub CopyForCSSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyForCSSToolStripMenuItem.Click
        Clipboard.SetText("rgb(" & colormanager.RGB.R & ", " & colormanager.RGB.G & ", " & colormanager.RGB.B & ")")
    End Sub
    Private Sub CopyHexToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyHexToolStripMenuItem.Click
        Clipboard.SetText("0x" & Hex(colormanager.RGB.B) & Hex(colormanager.RGB.G) & Hex(colormanager.RGB.R))
    End Sub
    Private Sub CopyHSVToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyHSVToolStripMenuItem.Click
        Clipboard.SetText("hsv(" & colormanager.HSV.H & ", " & colormanager.HSV.S & ", " & colormanager.HSV.V & ")")
    End Sub
#End Region ''cleaned
#End Region
End Class