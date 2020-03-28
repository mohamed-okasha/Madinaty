Imports System.Windows.Media.Animation
Partial Public Class Window8

    Dim sPath As String
  

   
    Private Sub MediaElement1_MediaEnded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles MediaElement1.MediaEnded
        Call endShow()

    End Sub

    Private Sub MediaElement1_MediaOpened(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MediaElement1.MediaOpened

    End Sub

   
    Private Sub endShow()



        Dim dblAnim As New DoubleAnimation


        dblAnim.From = 0
        dblAnim.[To] = 1



        dblAnim.Duration = New Duration(TimeSpan.FromSeconds(3))
        Image1.BeginAnimation(Image.OpacityProperty, dblAnim)

        Image2.BeginAnimation(Image.OpacityProperty, dblAnim)
      
        Image3.BeginAnimation(Image.OpacityProperty, dblAnim)
       
        Label1.BeginAnimation(Label.OpacityProperty, dblAnim)

        MediaElement1.Visibility = Windows.Visibility.Hidden

        Image4.Opacity = 1

        dblAnim.From = 1
        dblAnim.[To] = 0
        '    Image5.BeginAnimation(Image.OpacityProperty, dblAnim)
    End Sub

    Private Sub Window8_DragEnter(ByVal sender As Object, ByVal e As System.Windows.DragEventArgs) Handles Me.DragEnter

    End Sub

    Private Sub Window8_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles Me.Loaded
        Dim dblAnim As New DoubleAnimation


        dblAnim.From = 0
        dblAnim.[To] = 1

        dblAnim.RepeatBehavior = New RepeatBehavior(3)
        '  Image5.BeginAnimation(Image.OpacityProperty, dblAnim)
        MediaElement1.LoadedBehavior = MediaState.Play
    End Sub

    Private Sub Image2_ImageFailed(ByVal sender As System.Object, ByVal e As System.Windows.ExceptionRoutedEventArgs) Handles Image2.ImageFailed

    End Sub

    Private Sub Label2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Label2.MouseDown
        Me.Hide()
       
    End Sub

    Private Sub Image1_ImageFailed(ByVal sender As System.Object, ByVal e As System.Windows.ExceptionRoutedEventArgs) Handles Image1.ImageFailed
       
    End Sub

    Private Sub Image1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Image1.MouseDown
        Dim win6 As New Window9
        win6.Show()

    End Sub

    Private Sub Image4_ImageFailed(ByVal sender As System.Object, ByVal e As System.Windows.ExceptionRoutedEventArgs) Handles Image4.ImageFailed

    End Sub

    Private Sub MediaElement1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles MediaElement1.MouseDown
        MediaElement1.LoadedBehavior = MediaState.Pause
        Call endShow()
    End Sub
End Class
