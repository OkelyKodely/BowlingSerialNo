Public Class frm1

    Public Sub New()

        InitializeComponent()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nums As New List(Of UInteger)

        Dim v = CInt(TextBox2.Text)

        Dim rd As New Random

        lb1.Items.Clear()

        For k = 0 To CInt(TextBox1.Text) - 1
            Dim j As String = ""
            For i As Integer = 0 To v
                Dim l = rd.Next(10)
                j = j & l
            Next
            lb1.Items.Add(j)
        Next

    End Sub
End Class