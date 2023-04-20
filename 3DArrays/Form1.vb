Public Class Form1

    Dim array(2, 3, 2) As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 2
            For j As Integer = 0 To 3
                For k As Integer = 0 To 2
                    array(i, j, k) = (i * 100) + (j * 10) + k
                    ListBox1.Items.Add(array(i, j, k))
                Next
            Next
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        array(1, 2, 1) = 9999

        ListBox1.Items.Clear()

        For i As Integer = 0 To 2
            For j As Integer = 0 To 3
                For k As Integer = 0 To 2
                    ListBox1.Items.Add(array(i, j, k))
                Next
            Next
        Next

    End Sub
End Class
