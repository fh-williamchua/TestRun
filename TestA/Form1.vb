Public Class Form1

    Private _counter As Integer = 0
    Private Sub btnConcat_Click(sender As Object, e As EventArgs) Handles btnConcat.Click
        _counter += 1
        txtResult.Text = txtResult.Text & _counter.ToString()

        MessageBox.Show(txtResult.Text, "Current Text", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim sTest As String = String.Empty
        txtResult.Text = sTest

        Dim i As Integer = 0
        While i < 1
            _counter += 1
            txtResult.Text = txtResult.Text & _counter.ToString()
            MessageBox.Show(txtResult.Text, "Current Text", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End While
    End Sub
End Class
