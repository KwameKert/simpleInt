Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim principle As Integer = CInt(TextBox1.Text)
        Dim rate As Integer = CInt(TextBox2.Text)
        Dim time As Integer = CInt(TextBox3.Text)
        Dim interest As Integer = (principle * rate * time) / 100
        Label6.Text = CStr(interest)

        Dim x As Integer
        Dim Values As String = ""
        For x = 1 To time Step 1
            Values &= "Interest on " & x & " month " & CStr((principle * rate) / 100) & vbCrLf
        Next

        Label7.Text = Values

    End Sub
End Class
