Public Class Form1

    Private Sub btnentrar_Click(sender As System.Object, e As System.EventArgs) Handles btnentrar.Click
        Dim ven As New frmMenu
        ven.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call inicio()
    End Sub
End Class
