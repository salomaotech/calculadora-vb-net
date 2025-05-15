' Criador: salomao@taimber.com
' https://github.com/salomaotech

Public Class frmCalculadora

    Dim antes As String
    Dim depois As String
    Dim sinal As String
    Dim saldo As Double

    Private Sub calcular(ByVal a As Double, ByVal b As Double)

        If sinal <> "" And antes <> "" And depois <> "" Then

            Select Case sinal

                Case "+"
                    saldo = a + b

                Case "-"
                    saldo = a - b

                Case "*"
                    saldo = a * b

                Case "/"
                    saldo = a / b

            End Select

            TextBox1.Text = saldo
            antes = saldo
            depois = ""
            sinal = ""

        End If

    End Sub

    Private Sub addValor(ByVal valor)

        If sinal = "" Then

            antes = antes + valor

        Else

            depois = depois + valor

        End If

        TextBox1.Text = antes + sinal + depois

    End Sub

    Private Sub addSinal(ByVal sinalP)

        If antes <> "" And sinal = "" Then

            sinal = sinalP

        End If

        TextBox1.Text = antes + sinal + depois

    End Sub

    Private Sub limpar()

        antes = ""
        sinal = ""
        depois = ""
        TextBox1.Text = ""

    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        addValor("0")
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        addValor("1")
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        addValor("2")
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        addValor("3")
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        addValor("4")
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        addValor("5")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        addValor("6")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        addValor("7")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        addValor("8")
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        addValor("9")
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click

        Try

            calcular(antes, depois)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        addSinal("+")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        addSinal("-")

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        addSinal("*")

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        addSinal("/")

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click

        limpar()

    End Sub

End Class
