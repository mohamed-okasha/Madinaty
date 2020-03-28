Partial Public Class Window9
    Dim S As New DPz
    Dim sPath As String

    Private Sub Image1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Image1.MouseDown
        Me.Hide()
        Dim win1 As New Window1
        win1.Show()

    End Sub


    Sub showDpz(ByVal sName As String)

        If Dir$(spath & sName & ".dpz") <> "" Then

            S.openFile(sPath & sName & ".dpz")
            TextBox1.Text = S.Pdata
            Image3.Source = S.image
            G__SHOW.Visibility = Windows.Visibility.Visible
            plan_1.Visibility = Windows.Visibility.Hidden
            Label13.Visibility = Windows.Visibility.Visible
            Label6.Content = S.PName
        End If
    End Sub

    Private Sub Image2_ImageFailed(ByVal sender As System.Object, ByVal e As System.Windows.ExceptionRoutedEventArgs) Handles Image2.ImageFailed

    End Sub

    Private Sub Window9_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles Me.Loaded
        sPath = appPath & "Plan\"
    End Sub

    Private Sub Label13_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Label13.MouseDown
        G__SHOW.Visibility = Windows.Visibility.Hidden
        plan_1.Visibility = Windows.Visibility.Visible
    End Sub

    Private Sub Label12_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Label12.MouseDown
        Call showDpz(Label12.Content)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.TextChangedEventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Image3_ImageFailed(ByVal sender As System.Object, ByVal e As System.Windows.ExceptionRoutedEventArgs) Handles Image3.ImageFailed

    End Sub

    Private Sub Image1_ImageFailed(ByVal sender As System.Object, ByVal e As System.Windows.ExceptionRoutedEventArgs) Handles Image1.ImageFailed

    End Sub

    Private Sub Label2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Label2.MouseDown
        Me.Hide()
    End Sub
End Class

