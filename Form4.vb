Public Class Form4
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Form1.WebBrowser1.ScriptErrorsSuppressed = True

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Form1.WebBrowser1.ScriptErrorsSuppressed = False

    End Sub
End Class