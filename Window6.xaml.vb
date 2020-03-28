Imports System.IO
Imports System.Windows.Media.Animation
Partial Public Class Window6
    Dim x(), spath As String
    Private Sub fclicklabel()
        Dim dblAnim As New DoubleAnimation
        

        dblAnim.From = 1
        dblAnim.[To] = 0

        Image2.BeginAnimation(Image.OpacityProperty, dblAnim)
        Label1.BeginAnimation(Label.OpacityProperty, dblAnim)
        Label2.BeginAnimation(Label.OpacityProperty, dblAnim)
        Label3.BeginAnimation(Label.OpacityProperty, dblAnim)
        Label4.BeginAnimation(Label.OpacityProperty, dblAnim)
        Label5.BeginAnimation(Label.OpacityProperty, dblAnim)
        Label6.BeginAnimation(Label.OpacityProperty, dblAnim)
        Label7.BeginAnimation(Label.OpacityProperty, dblAnim)
        Label8.BeginAnimation(Label.OpacityProperty, dblAnim)
        Button2.BeginAnimation(Button.OpacityProperty, dblAnim)
        dblAnim.From = 0
        dblAnim.[To] = 1
        TextBox1.BeginAnimation(TextBox.OpacityProperty, dblAnim)
        TextBox1.Visibility = Windows.Visibility.Visible
        Button1.BeginAnimation(Button.OpacityProperty, dblAnim)
    End Sub

    Private Sub bclicklabel()
        Dim dblAnim As New DoubleAnimation


        dblAnim.From = 0
        dblAnim.[To] = 1

        Image2.BeginAnimation(Image.OpacityProperty, dblAnim)
        Label1.BeginAnimation(Label.OpacityProperty, dblAnim)
        Label2.BeginAnimation(Label.OpacityProperty, dblAnim)
        Label3.BeginAnimation(Label.OpacityProperty, dblAnim)
        Label4.BeginAnimation(Label.OpacityProperty, dblAnim)
        Label5.BeginAnimation(Label.OpacityProperty, dblAnim)
        Label6.BeginAnimation(Label.OpacityProperty, dblAnim)
        Label7.BeginAnimation(Label.OpacityProperty, dblAnim)
        Label8.BeginAnimation(Label.OpacityProperty, dblAnim)
        Button2.BeginAnimation(Button.OpacityProperty, dblAnim)
        dblAnim.From = 1
        dblAnim.[To] = 0
        TextBox1.BeginAnimation(TextBox.OpacityProperty, dblAnim)
        TextBox1.Visibility = Windows.Visibility.Hidden
        Button1.BeginAnimation(Button.OpacityProperty, dblAnim)
    End Sub

    Private Sub Window6_Loaded(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs) Handles Me.Loaded

     
        spath = appPath & "Dpz\D1\"

        

    End Sub
    Sub showDpz(ByVal sName As String)

        If Dir$(spath & sName & ".dpz") <> "" Then
            Dim d As New DPz
            d.openFile(spath & sName & ".dpz")
            TextBox1.Text = d.Pdata
        End If
    End Sub

    Private Sub Image2_ImageFailed(ByVal sender As System.Object, ByVal e As System.Windows.ExceptionRoutedEventArgs)

    End Sub

    Private Sub Label9_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Label9.MouseDown
        Me.Hide()

    End Sub

    Private Sub Label1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Label1.MouseDown
        


        Call fclicklabel()

        Call showDpz(Label1.Content)

    End Sub

    Private Sub Label2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Label2.MouseDown
        Call showDpz(Label2.Content)
        Call fclicklabel()

    End Sub

    Private Sub Label3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Label3.MouseDown
        Call showDpz(Label3.Content)
        Call fclicklabel()
    End Sub

    Private Sub Label4_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Label4.MouseDown
        Call showDpz(Label4.Content)
        Call fclicklabel()
    End Sub

    Private Sub Label5_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Label5.MouseDown
        Call showDpz(Label5.Content)
        Call fclicklabel()
    End Sub

    Private Sub Label6_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Label6.MouseDown
        Call showDpz(Label6.Content)
        Call fclicklabel()
    End Sub

    Private Sub Label7_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Label7.MouseDown
        Call showDpz(Label7.Content)
        Call fclicklabel()
    End Sub





    Private Sub Label8_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles Label8.MouseDown
        Call showDpz(Label8.Content)
        Call fclicklabel()
    End Sub

    Private Sub Image1_ImageFailed(ByVal sender As System.Object, ByVal e As System.Windows.ExceptionRoutedEventArgs) Handles Image1.ImageFailed

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.TextChangedEventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles Button1.Click
        Call bclicklabel()
    End Sub
End Class
