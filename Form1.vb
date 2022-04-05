Public Class Form1
    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        Dim intSum As Integer

        If (Val(txtInput.Text) > 0) Then
            intSum = 0
            For x = 1 To Val(txtInput.Text)
                intSum = intSum + x
            Next x
            lblOutput.Text = "Summation of " & txtInput.Text & " is" & Str(intSum) & "."
        Else
            lblOutput.Text = "Enter a positive integer only."
        End If
    End Sub
End Class
