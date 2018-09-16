Public Class LanguageProvider
    'TODO: fix the memory leaks
    Public LanguageFile As String
    Private Entries As New Dictionary(Of String, String)
    Private Info As New Dictionary(Of String, String)(4)

    Event LanguageUpdated()
    Public Sub New()
    End Sub

    Public Sub OpenFile(ByVal langFile As String)
        LoadFile(langFile, True, True)
    End Sub
    Private Function isValidKey(ByVal key As String)
        Return key = "author" Or key = "name" Or key = "shortname" Or key = "contact" Or key = "site"
    End Function

    Private Sub LoadFile(ByVal langFile As String, ByVal readinput As Boolean, ByVal raise As Boolean)
        LanguageFile = langFile
        If readinput Then Read()
        If raise Then RaiseEvent LanguageUpdated()
    End Sub
    Private Sub InitInfo()
        Info.Clear()
        Info.Add("author", "")
        Info.Add("name", "")
        Info.Add("shortname", "")
        Info.Add("contact", "")
        Info.Add("site", "")
    End Sub
    Private Sub Read()
        'Basically, a language file is simple.
        'Everything is case sensitive. So:
        '//comment
        'VARIABLE=Whatever, all chars accepted
        'GROUP:VARIABLE=Also accepted, will parse for that aswell
        '#author=Tags to define languagefile information, not needed.

        Entries.Clear() 'clear dictionary
        InitInfo() 'clear and init vars of info dictionary

        Dim raw() As String = LanguageFile.Split(Environment.NewLine.ToCharArray, System.StringSplitOptions.RemoveEmptyEntries)

        Dim index As Integer
        Dim name As String
        Dim value As String
        For Each s As String In raw
#If CONFIG = "Debug" Then 'show line pased.
            Debug.Print("Parsed line (" & Array.IndexOf(raw, s) & ") - " & s)
#End If
            If s.StartsWith("//") Then Continue For 'just a comment, can be skipped.
            If s.Length = 0 Then Continue For 'blank line
            index = s.IndexOf("=")
            name = s.Remove(index, s.Count - index)
            value = s.Remove(0, index + 1)
            If name.StartsWith("#") And s.Contains("=") Then
                If isValidKey(name.Remove(0, 1)) And value.Length > 0 Then Info(name.Remove(0, 1)) = value
                Continue For
            End If
            If s.Contains("=") Then
                If value.Length > 0 Then Entries.Add(name, value.Replace("\n", Environment.NewLine))
            End If
        Next
        index = Nothing : name = Nothing : value = Nothing : raw = Nothing 'reset the variables, release memory :P
    End Sub
    Private Sub Dispose()
        LanguageFile = Nothing
        Entries = Nothing
        Info = Nothing
    End Sub

    Public Function GetKey(ByVal key As String) As String
        If Entries.ContainsKey(key) Then Return Entries(key)
        Return Nothing
    End Function
    Public Function GetKey(ByVal group As String, ByVal key As String) As String
        If Entries.ContainsKey(group & ":" & key) Then Return Entries(group & ":" & key)
        Return Nothing
    End Function
    Public Function GetInfo(ByVal key As String) As String
        If isValidKey(key) Then Return Info(key)
        Return Nothing
    End Function
End Class