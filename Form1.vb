Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim indicator As Boolean = True
        Dim username As String = TextBox1.Text
        Dim password As String = TextPassword.Text
        While indicator
            If username = "admin" And password = "admin" Then
                MsgBox("Login Berhasil", vbInformation, "Login")
                indicator = False
                TextBox1.Text = ""
                TextPassword.Text = ""
                Form2.Show()
            Else
                indicator = MsgBox("Username / Password  salah", vbExclamation, "Failed")
                indicator = False
            End If
        End While
    End Sub
    Private Sub btncls_Click(sender As Object, e As EventArgs) Handles btncls.Click
        Me.Close()
    End Sub

    Private Sub btnmax_Click(sender As Object, e As EventArgs) Handles btnmax.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnmin_Click(sender As Object, e As EventArgs) Handles btnmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CheckPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPassword.CheckedChanged
        If CheckPassword.Checked Then
            TextPassword.UseSystemPasswordChar = False
        Else
            TextPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class
