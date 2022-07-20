Public Class Form1



    Public Function existe_dig(n As Integer, dig As Integer) As Boolean
        Dim ban As Boolean
        Dim d As Integer
        ban = False

        While n > 0 And ban = False

            d = n Mod 10
            n = n \ 10

            If d = dig Then
                ban = True

            End If


        End While

        Return ban

    End Function


    Private Sub PREGUNTA1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PREGUNTA1ToolStripMenuItem.Click
        TextBox2.Text = existe_dig(TextBox1.Text, TextBox2.Text)
    End Sub



End Class
