Public Class Form1

    Private _counter As Integer = 0
    Private Sub btnConcat_Click(sender As Object, e As EventArgs) Handles btnConcat.Click
        _counter += 1
        txtResult.Text = txtResult.Text & _counter.ToString()
    End Sub
End Class
