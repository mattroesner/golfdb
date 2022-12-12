Public Class Login
    Dim a As Integer = 0
    Private Sub Login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        If user_txt.Text = My.Settings.Username Then
            a += 1
        End If
        If pass_txt.Text = My.Settings.Password Then
            a += 1
        End If
        If a = 2 Then
            MsgBox("Login successful", MsgBoxStyle.Information)
        Else
            MsgBox("Username or Password Not Valid", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class