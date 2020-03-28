Class Window1 

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs)
        Me.Image1.Source = New BitmapImage(New Uri("pack://application:,,,/Pic1.jpg"))

    End Sub

    Private Sub Image1_ImageFailed(ByVal sender As System.Object, ByVal e As System.Windows.ExceptionRoutedEventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button1.Click
        Dim windowsy As New Window2
        windowsy.Show()


    End Sub

    Private Sub Image1_ImageFailed_1(ByVal sender As System.Object, ByVal e As System.Windows.ExceptionRoutedEventArgs) Handles Image1.ImageFailed

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button3.Click
        Dim win4 As New Window4
        win4.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button2.Click
        Dim win5 As New Window5
        win5.Show()
        'MsgBox(Application.GetContentStream(New Uri("pack://application:,,,/ok.txt")).Stream.CanRead)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button4.Click
        Dim win6 As New Window6
        win6.Show()
    End Sub
End Class
