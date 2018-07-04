Public Class Form2
    Private m As New Menu
    Private Sub Panel_WA_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel_WA.Paint
        'InitForm()
    End Sub

    Function getPanel(ByVal m As Menu)
        Me.m = m
        Return Panel_WA
    End Function

    Private Sub InitForm()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        m.Panel_WA.Controls.Clear()
    End Sub
End Class