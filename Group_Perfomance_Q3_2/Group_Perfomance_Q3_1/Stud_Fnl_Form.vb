Public Class frmStudInfFnl
    Dim mouse_move As System.Drawing.Point

    Private Sub btnCloseMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseMain.Click
        frmStudInf.Close()
        frmSettings.Close()
        Me.Close()
    End Sub

    Private Sub pnltitleB_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnltitleB.MouseDown
        mouse_move = New Point(-e.X, -e.Y)
    End Sub

    Private Sub pnltitleB_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnltitleB.MouseMove
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Dim mposition As Point
            mposition = Control.MousePosition
            mposition.Offset(mouse_move.X, mouse_move.Y)
            Me.Location = mposition
        End If
    End Sub

    Private Sub roundCorners(ByVal obj As Form)
        obj.FormBorderStyle = FormBorderStyle.None

        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        'top left corner
        DGP.AddArc(New Rectangle(0, 0, 5, 5), 180, 90)
        DGP.AddLine(5, 0, obj.Width - 5, 0)

        'top right corner
        DGP.AddArc(New Rectangle(obj.Width - 5, 0, 5, 5), -90, 90)
        DGP.AddLine(obj.Width, 5, obj.Width, obj.Height - 5)

        'buttom right corner
        DGP.AddArc(New Rectangle(obj.Width - 15, obj.Height - 15, 15, 15), 0, 90)
        DGP.AddLine(obj.Width - 15, obj.Height, 15, obj.Height)

        'buttom left corner
        DGP.AddArc(New Rectangle(0, obj.Height - 15, 15, 15), 90, 90)
        DGP.CloseFigure()

        obj.Region = New Region(DGP)
    End Sub


    Private Sub frmStudInfFnl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        roundCorners(Me)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Me.Hide()
        frmStudInf.Show()
    End Sub

End Class