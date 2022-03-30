Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim boy, kilo, sonuc As Single
        boy = Val(TextBox1.Text)
        kilo = Val(TextBox2.Text)
        sonuc = kilo / (boy / 100) ^ 2
        MsgBox("VKİ niz " & Math.Round(sonuc, 3))

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = TimeOfDay
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
