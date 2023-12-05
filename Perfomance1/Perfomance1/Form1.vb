Public Class Form1

    Private Sub lblname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblname.Click

    End Sub

    Private Sub lbltitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltitle.Click

    End Sub

    Private Sub lbltaught1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltaught1.Click

    End Sub

    Private Sub lbltaught2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltaught2.Click

    End Sub

    Private Sub lbltaught3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltaught3.Click

    End Sub

    Private Sub bntdisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntdisplay.Click
        lbltaught1.Text = "To be resposible"
        lbltaught2.Text = "That life sucks but you have to deal with it"
        lbltaught3.Text = "Always be happy"
        picIU1.Visible = True
        picnewyear.Visible = True
        Me.BackColor = Color.Violet
        bntdisplay.Visible = False
        bntclose.Visible = True
    End Sub

    Private Sub bntclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntclose.Click
        End
    End Sub
End Class
