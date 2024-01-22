Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim grade As String
        grade = ComboBox1.Text

        Select Case grade
            Case "A"
                TextBox1.Text = "High distinction"
            Case "A-"
                TextBox1.Text = "Distinction"
            Case "B"
                TextBox1.Text = "Credit"
            Case "C"
                TextBox1.Text = "Pass"

            Case "D"
                TextBox1.Text = "Fail"
            Case Else
                TextBox1.Text = "Fail"

        End Select
    End Sub
End Class
