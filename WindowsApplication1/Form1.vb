Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MyBase.BackColor = Color.Aqua Then
            MyBase.BackColor = Color.Pink
        Else : MyBase.BackColor = Color.Aqua
        End If
    End Sub
End Class

