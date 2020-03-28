Imports System.Windows.Media.Animation
Partial Public Class Window3



 
    Private Sub Window3_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles Me.Loaded
        Dim k() As String = Split(Application.ResourceAssembly.Location, "\", -1, CompareMethod.Text)
        Dim l As Integer = Len(k(UBound(k)))
        Dim sPath As String

        sPath = Mid(Application.ResourceAssembly.Location, 1, Len(Application.ResourceAssembly.Location) - l) & "Au\"

        My.Computer.Audio.Play(sPath & "Au_start.wav", AudioPlayMode.Background)
        Dim dblAnim As New DoubleAnimation()
        dblAnim.RepeatBehavior = New RepeatBehavior(4)
        dblAnim.From = 0.5
        dblAnim.[To] = 0

        Label1.BeginAnimation(Label.OpacityProperty, dblAnim)


       
    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button3.Click
        Dim window4 As New Window1
        window4.Show()
        Me.Hide()
    End Sub

    Private Sub Image1_ImageFailed(ByVal sender As System.Object, ByVal e As System.Windows.ExceptionRoutedEventArgs) Handles Image1.ImageFailed

    End Sub
End Class
