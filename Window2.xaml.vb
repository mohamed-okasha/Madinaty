Imports System.Windows.Media.Animation
Partial Public Class Window2








    Private Sub Image4_ImageFailed(ByVal sender As System.Object, ByVal e As System.Windows.ExceptionRoutedEventArgs) Handles Image4.ImageFailed

    End Sub



    Private Sub Image4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Image4.MouseDown
        Me.Image5.Source = New BitmapImage(New Uri("pack://application:,,,/pl1.jpg"))
        Image5.Visibility = Windows.Visibility.Visible

    End Sub

    Private Sub Label4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Label4.MouseDown
        Image5.Visibility = Windows.Visibility.Hidden

    End Sub




    Private Sub Image3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Image3.MouseDown
        Me.Image5.Source = New BitmapImage(New Uri("pack://application:,,,/pl2.jpg"))
        Image5.Visibility = Windows.Visibility.Visible
    End Sub


    Private Sub Image2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Image2.MouseDown
        Me.Image5.Source = New BitmapImage(New Uri("pack://application:,,,/pl3.jpg"))
        Image5.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Image5_ImageFailed(ByVal sender As System.Object, ByVal e As System.Windows.ExceptionRoutedEventArgs) Handles Image5.ImageFailed

    End Sub

    Private Sub Image5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Image5.MouseDown
        'Label6.ContentTemplate.Resources = Resources.Keys
        '   Call animWHLT(Mouse.GetPosition)
        Call animWHLT()
    End Sub
    Private Sub animWHLT()
        Dim dblAnim As New DoubleAnimation()
        dblAnim.From = 0.1
        dblAnim.[To] = 1
        Label6.BeginAnimation(Label.OpacityProperty, dblAnim)
    End Sub
End Class
