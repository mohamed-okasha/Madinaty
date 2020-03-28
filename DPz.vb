Imports System.IO
Public Class DPz

    Public Image As New BitmapImage
    Public PName As String
    Public Pdata As String
    Dim bs As Boolean = False
    Dim be As Boolean = False
    Public Sub openFile(ByVal PathFileName As String)
        If Dir$(PathFileName) = "" Then MsgBox("للأسف الملف الخاص بهذا العنصر غير موجود .. جرب إعادة تصطيب البرنامج من جديد") : Exit Sub
        Dim Fs As New FileStream(PathFileName, FileMode.Open, FileAccess.Read)
        Dim iimage As New BitmapImage
        Dim ByteFile(Fs.Length) As Byte
        Dim Byteimage() As Byte
        Dim s As String
        Dim st() As String


        Fs.Read(ByteFile, 0, Fs.Length)
        s = Text.Encoding.Default.GetChars(ByteFile)
        st = Split(s, "<image>", -1, CompareMethod.Text)

        Byteimage = Text.Encoding.Default.GetBytes(st(1))

        '   MsgBox(Mid(st(1), Len(st(1)) - 10, 10) & "}")
        ' MsgBox(Text.Encoding.ASCII.GetChars(ByteImg))

        Dim k As New MemoryStream()

        k.Write(Byteimage, 0, Byteimage.Length)
        k.Seek(0, SeekOrigin.Begin)

        '   If bs = False Then
        'image.BeginInit()
        '    bs = True

        '   End If

        iimage.BeginInit()
        iimage.StreamSource = k
        iimage.EndInit()

        image = iimage
        '    If be = False Then
        'image.EndInit()
        '      be = True

        '    End If

        st = Split(s, "<pname>", -1, CompareMethod.Text)
        ' image2.StreamSource
        PName = st(1)

        st = Split(s, "<pdata>", -1, CompareMethod.Text)
        ' image2.StreamSource
        Pdata = st(1)

    End Sub

End Class
