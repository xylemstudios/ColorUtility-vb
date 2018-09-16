Module SharedFunctions
    Public Function isCompatibleNumeric(ByVal s As String)
        Return Not (s.Contains(".") Or s.Contains(",") Or s.Contains("+") Or s.Contains("-") Or s.StartsWith(".") Or s.StartsWith(",") Or s.StartsWith("+") Or s.StartsWith("-"))
    End Function
End Module
