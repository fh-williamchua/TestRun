Public Class Form1

    Private _counter As Integer = 0
    Private Sub btnConcat_Click(sender As Object, e As EventArgs) Handles btnConcat.Click
        _counter += 1
        txtResult.Text = txtResult.Text & _counter.ToString()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtResult.Text = String.Empty

        Dim sTest As String
        txtResult.Text = sTest
    End Sub
End Class
