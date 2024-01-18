Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a
        a = Val(TextBox1.Text)
        If a Mod 2 = 0 Then
            TextBox2.Text = "even"
        Else
            TextBox1.Text = "odd"
        End If
    End Sub
End Class
