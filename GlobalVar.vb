Module GlobalVar
    Dim k() As String = Split(Application.ResourceAssembly.Location, "\", -1, CompareMethod.Text)
    Dim l As Integer = Len(k(UBound(k)))
    Public appPath As String = Mid(Application.ResourceAssembly.Location, 1, Len(Application.ResourceAssembly.Location) - l)
End Module
