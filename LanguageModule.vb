Module LanguageModule
    Public Function lang(ByVal s As String) As String
        Return Form1.languageProvider.GetKey(s)
    End Function
    Public Function lang(ByVal g As String, ByVal s As String) As String
        Return Form1.languageProvider.GetKey(g, s)
    End Function
End Module
