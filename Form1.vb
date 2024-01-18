Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firstnumber As Double
        Dim secondnumber As Double

        firstnumber = Val(TextBox1.Text)
        secondnumber = Val(TextBox2.Text)

        If firstnumber > secondnumber Then
            TextBox3.Text = firstnumber
        Else
            TextBox3.Text = secondnumber
        End If
    End Sub
End Class
