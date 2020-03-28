Imports System.Windows.Media.Animation
Imports System.IO

Partial Public Class Window5
    Dim sLindex As Integer

    Dim sPath As String

    Private Sub Image1_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles Image1.Loaded

        
    End Sub
    Private Sub animWHLT()
        Dim dblAnim As New DoubleAnimation()
        dblAnim.From = 0.05
        dblAnim.[To] = 1

        Label2.BeginAnimation(Label.OpacityProperty, dblAnim)
        Label2.BeginAnimation(Label.OpacityProperty, dblAnim)
        Label3.BeginAnimation(Label.OpacityProperty, dblAnim)
        Label4.BeginAnimation(Label.OpacityProperty, dblAnim)
        Label5.BeginAnimation(Label.OpacityProperty, dblAnim)
        Label6.BeginAnimation(Label.OpacityProperty, dblAnim)
        Label7.BeginAnimation(Label.OpacityProperty, dblAnim)
        Label8.BeginAnimation(Label.OpacityProperty, dblAnim)
        Label9.BeginAnimation(Label.OpacityProperty, dblAnim)

    End Sub


    Private Sub Image2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Image2.MouseDown
        Call animWHLT()
        Call DpDowen()
    End Sub

    Private Sub DpUp()
        Dim Ui As Integer
        Static UFindex, ULindex As Integer

        ULindex = sLindex
        Dim d(7) As String
        For Ui = ULindex To ListBox1.Items.Count - 1

            If UFindex > 7 Then
                ULindex = UFindex
                UFindex = 0
                ' ListBox1.SelectedValue = ULindex

                Exit For
            End If

            d(UFindex) = ListBox1.Items.Item(Ui)
            UFindex = UFindex + 1

        Next
        sLindex = ULindex
        UFindex = 0
        Label2.Content = ""
        Label3.Content = ""
        Label4.Content = ""
        Label5.Content = ""
        Label6.Content = ""
        Label7.Content = ""
        Label8.Content = ""
        Label9.Content = ""
        If d(0) <> "" Then Label2.Content = Mid(d(0), 1, Len(d(0)) - 4)
        If d(1) <> "" Then Label3.Content = Mid(d(1), 1, Len(d(1)) - 4)
        If d(2) <> "" Then Label4.Content = Mid(d(2), 1, Len(d(2)) - 4)
        If d(3) <> "" Then Label5.Content = Mid(d(3), 1, Len(d(3)) - 4)
        If d(4) <> "" Then Label6.Content = Mid(d(4), 1, Len(d(4)) - 4)
        If d(5) <> "" Then Label7.Content = Mid(d(5), 1, Len(d(5)) - 4)
        If d(6) <> "" Then Label8.Content = Mid(d(6), 1, Len(d(6)) - 4)
        If d(7) <> "" Then Label9.Content = Mid(d(7), 1, Len(d(6)) - 4)
    End Sub
    Private Sub DpDowen()
        Dim i As Integer
        Static Findex, Lindex As Integer

        Lindex = sLindex

        Dim d(7) As String

        For i = 0 To Lindex

            If Findex > 7 Then
                Lindex = Findex
                Findex = 0
                Exit For
            End If

            d(Findex) = ListBox1.Items.Item(i)
            Findex = Findex + 1

        Next

        Label2.Content = ""
        Label3.Content = ""
        Label4.Content = ""
        Label5.Content = ""
        Label6.Content = ""
        Label7.Content = ""
        Label8.Content = ""
        Label9.Content = ""
        If d(0) <> "" Then Label2.Content = Mid(d(0), 1, Len(d(0)) - 4)
        If d(1) <> "" Then Label3.Content = Mid(d(1), 1, Len(d(1)) - 4)
        If d(2) <> "" Then Label4.Content = Mid(d(2), 1, Len(d(2)) - 4)
        If d(3) <> "" Then Label5.Content = Mid(d(3), 1, Len(d(3)) - 4)
        If d(4) <> "" Then Label6.Content = Mid(d(4), 1, Len(d(4)) - 4)
        If d(5) <> "" Then Label7.Content = Mid(d(5), 1, Len(d(5)) - 4)
        If d(6) <> "" Then Label8.Content = Mid(d(6), 1, Len(d(6)) - 4)
        If d(7) <> "" Then Label9.Content = Mid(d(7), 1, Len(d(6)) - 4)
    End Sub

  

    Private Sub Image3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs)
       
    End Sub

    

    Private Sub Label1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Label1.MouseDown
        Me.Hide()
    End Sub

    
    Private Sub ClickNameDpz(ByVal sN As String)
        Dim s As New DPz
        s.openFile(sPath & sN & ".dpz")

        ' image2.StreamSource
        Image4.Source = s.image

        TextBox1.Text = (s.PName & vbNewLine & vbNewLine & s.Pdata)
    End Sub

    Private Sub Label2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Label2.MouseDown
        Call ClickNameDpz(Label2.Content)
    End Sub

    Private Sub Label9_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Label9.MouseDown
        Call ClickNameDpz(Label9.Content)
    End Sub

    Private Sub Label3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Label3.MouseDown
        Call ClickNameDpz(Label3.Content)
    End Sub

    Private Sub Label4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Label4.MouseDown
        Call ClickNameDpz(Label4.Content)
    End Sub

    Private Sub Label5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Label5.MouseDown
        Call ClickNameDpz(Label5.Content)
    End Sub

    Private Sub Label6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Label6.MouseDown
        Call ClickNameDpz(Label6.Content)
    End Sub

    Private Sub Label7_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Label7.MouseDown
        Call ClickNameDpz(Label7.Content)
    End Sub

    Private Sub Label8_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Label8.MouseDown
        Call ClickNameDpz(Label8.Content)
    End Sub

    Private Sub Image3_MouseDown1(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Image3.MouseDown
        Call animWHLT()
        Call DpUp()
    End Sub


    Private Sub Window5_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles Me.Loaded

        sPath = appPath & "DPZ\"


        Dim x() As String = Directory.GetFiles(sPath, "*.dpz")

        Dim counter As Integer
        For counter = 0 To UBound(x)
            Dim F() As String = Split(x(counter), "\", -1)
            ListBox1.Items.Add(F(UBound(F)))
        Next
        Call animWHLT()
        Call DpUp()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.TextChangedEventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Image1_ImageFailed(ByVal sender As System.Object, ByVal e As System.Windows.ExceptionRoutedEventArgs) Handles Image1.ImageFailed

    End Sub
End Class
