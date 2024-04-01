Public Class LoginForm
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click

        'If String.IsNullOrEmpty(UsernameTextBox.Text) Or String.IsNullOrEmpty(PasswordTextBox.Text) Then
        'MsgBox("Please enter username and password", MsgBoxStyle.Exclamation, "Login to database")
        'Else
        GlobalVariables.UserName = UsernameTextBox.Text
        GlobalVariables.Password = PasswordTextBox.Text
        Form1.Show()
        Me.Hide()
        'End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Close()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class