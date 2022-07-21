Public Class Form1
    'pregunta 1

    Public Function Veri_full(n As Integer) As Boolean
        Return ((frec_dig(n, Dig_may(n)) = 3) And (frec_dig(n, Dig_men(n)) = 2)) Or
            ((frec_dig(n, Dig_may(n)) = 2) And (frec_dig(n, Dig_men(n)) = 3))

    End Function
    Public Function Dig_men(n As Integer) As Integer
        Dim dm, d As Integer
        dm = n Mod 10
        n = n \ 10

        While n > 0
            d = n Mod 10
            n = n \ 10

            If d < dm Then
                dm = d
            End If
        End While
        Return dm

    End Function

    Public Function Dig_may(n As Integer) As Integer
        Dim d1, d2 As Integer

        d1 = n Mod 10
        n = n \ 10

        While n > 0
            d2 = n Mod 10
            n = n \ 10

            If d2 > d1 Then
                d1 = d2
            End If
        End While
        Return d1

    End Function
    Private Sub Pregunta1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pregunta1ToolStripMenuItem.Click
        TextBox2.Text = Veri_full(TextBox1.Text)
    End Sub

    'pregunta 2

    Public Function ejercicio2(n As Integer) As Integer
        Dim d, e, nn As Integer

        While n > 0
            d = n Mod 10

            If frec_dig(n, d) = 1 Then

                nn = nn + (d * 10 ^ e)
                e = e + 1

            End If
            n = Elim_todos_num(n, d)

        End While
        Return nn

    End Function


    Public Function frec_dig(n As Integer, dig As Integer) As Integer
        Dim fd, d As Integer
        While n > 0
            d = n Mod 10
            n = n \ 10

            If dig = d Then
                fd = fd + 1

            End If
        End While
        Return fd

    End Function



    Public Function Elim_todos_num(n As Integer, num As Integer) As Integer 'by ANGEL
        Dim nd, d, nn, e As Integer

        nd = Cant_digs(num)
        d = 0
        nn = 0
        e = 0

        While n > 0

            d = n Mod (10 ^ nd)
            n = n \ (10 ^ nd)

            If d <> num Then

                nn = nn + (d * (10 ^ e))
                e = e + nd

            End If
        End While

        Return nn
    End Function

    Public Function Cant_digs(n As Integer) As Integer
        Dim cd, d As Integer
        cd = 0
        If n = 0 Then
            n = 1
        End If
        While n > 0
            d = n Mod 10
            n = n \ 10
            cd = cd + 1
        End While
        Return cd
    End Function



    Private Sub Pregunta2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Pregunta2ToolStripMenuItem.Click
        TextBox2.Text = ejercicio2(TextBox1.Text)
    End Sub
End Class
