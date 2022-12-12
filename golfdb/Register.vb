Public Class register_forum
    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim a As Integer = 0
    Private Sub signup_btn_Click(sender As Object, e As EventArgs) Handles signup_btn.Click
        If Not username_txt.Text = "" Then
            a += 1
        End If
        If Not pass_txt.Text = "" Then
            a += 1
        End If
        If Not first_txt.Text = "" Then
            a += 1
        End If
        If Not last_txt.Text = "" Then
            a += 1
        End If
        If Not phone_txt.Text = "" Then
            a += 1
        End If
        If Not email_txt.Text = "" Then
            a += 1
        End If
        If Not street_txt.Text = "" Then
            a += 1
        End If
        If Not city_txt.Text = "" Then
            a += 1
        End If
        If Not street_txt.Text = "" Then
            a += 1
        End If
        If Not state_txt.Text = "" Then
            a += 1
        End If
        If Not zip_txt.Text = "" Then
            a += 1
        End If
        If a = 11 Then
            My.Settings.Username = username_txt.Text
            My.Settings.Password = pass_txt.Text
            My.Settings.Firstname = first_txt.Text
            My.Settings.Lastname = last_txt.Text
            My.Settings.Phone = phone_txt.Text
            My.Settings.Email = email_txt.Text
            My.Settings.Street = street_txt.Text
            My.Settings.State = state_txt.Text
            My.Settings.Zip = zip_txt.Text
            My.Settings.Save()
            MsgBox("Youre all signed up!")
            Login.Show()
        Else
            MsgBox("please fill in all fields", MsgBoxStyle.Exclamation)
        End If

    End Sub
End Class
