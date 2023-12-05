Public Class frmSettings
    Dim mouse_move As System.Drawing.Point

    Private Sub frmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        roundCorners(Me)
        If frmStudInf.lblchecker.BackColor = Color.Black Then
            optDark.Checked = True
            pnltitleB.BackColor = Color.FromArgb(43, 55, 61)
            pnlMain.BackColor = Color.FromArgb(32, 33, 36)
            Me.BackColor = Color.FromArgb(68, 87, 96)
            lblModes.ForeColor = Color.White
            lblTitleB.ForeColor = Color.White
            optDark.ForeColor = Color.White
            optLight.ForeColor = Color.White
            btnApply.ForeColor = Color.FromArgb(32, 33, 36)
            btnApply.BackColor = Color.FromArgb(138, 180, 248)
        Else
            optLight.Checked = True
            pnltitleB.BackColor = Color.FromArgb(231, 234, 237)
            pnlMain.BackColor = Color.FromArgb(255, 255, 255)
            Me.BackColor = Color.FromArgb(255, 255, 255)
            lblModes.ForeColor = Color.FromArgb(108, 111, 113)
            lblTitleB.ForeColor = Color.FromArgb(108, 111, 113)
            optDark.ForeColor = Color.FromArgb(39, 39, 39)
            optLight.ForeColor = Color.FromArgb(39, 39, 39)
            btnApply.ForeColor = Color.FromArgb(255, 255, 255)
            btnApply.BackColor = Color.FromArgb(66, 133, 244)
        End If

    End Sub

    Private Sub btnCloseMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseMain.Click
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

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        If optLight.Checked = True Then

            'Student Form'
            frmStudInf.pnltitleB.BackColor = Color.FromArgb(231, 234, 237)
            frmStudInf.pnlMain.BackColor = Color.FromArgb(255, 255, 255)
            frmStudInf.pnlInfo.BackColor = Color.FromArgb(255, 255, 255)
            frmStudInf.BackColor = Color.FromArgb(255, 255, 255)
            frmStudInf.txtAdd.BackColor = Color.FromArgb(255, 255, 255)
            frmStudInf.txtAge.BackColor = Color.FromArgb(255, 255, 255)
            frmStudInf.txtGen.BackColor = Color.FromArgb(255, 255, 255)
            frmStudInf.txtGN.BackColor = Color.FromArgb(255, 255, 255)
            frmStudInf.txtGr.BackColor = Color.FromArgb(255, 255, 255)
            frmStudInf.txtHob.BackColor = Color.FromArgb(255, 255, 255)
            frmStudInf.txtLang.BackColor = Color.FromArgb(255, 255, 255)
            frmStudInf.txtLN.BackColor = Color.FromArgb(255, 255, 255)
            frmStudInf.txtMail.BackColor = Color.FromArgb(255, 255, 255)
            frmStudInf.txtMN.BackColor = Color.FromArgb(255, 255, 255)
            frmStudInf.txtMoNo.BackColor = Color.FromArgb(255, 255, 255)
            frmStudInf.txtNat.BackColor = Color.FromArgb(255, 255, 255)
            frmStudInf.txtSec.BackColor = Color.FromArgb(255, 255, 255)
            frmStudInf.txtSpec.BackColor = Color.FromArgb(255, 255, 255)
            frmStudInf.txtAdd.ForeColor = Color.FromArgb(39, 39, 39)
            frmStudInf.txtAge.ForeColor = Color.FromArgb(39, 39, 39)
            frmStudInf.txtGen.ForeColor = Color.FromArgb(39, 39, 39)
            frmStudInf.txtGN.ForeColor = Color.FromArgb(39, 39, 39)
            frmStudInf.txtGr.ForeColor = Color.FromArgb(39, 39, 39)
            frmStudInf.txtHob.ForeColor = Color.FromArgb(39, 39, 39)
            frmStudInf.txtLang.ForeColor = Color.FromArgb(39, 39, 39)
            frmStudInf.txtLN.ForeColor = Color.FromArgb(39, 39, 39)
            frmStudInf.txtMail.ForeColor = Color.FromArgb(39, 39, 39)
            frmStudInf.txtMN.ForeColor = Color.FromArgb(39, 39, 39)
            frmStudInf.txtMoNo.ForeColor = Color.FromArgb(39, 39, 39)
            frmStudInf.txtNat.ForeColor = Color.FromArgb(39, 39, 39)
            frmStudInf.txtSec.ForeColor = Color.FromArgb(39, 39, 39)
            frmStudInf.txtSpec.ForeColor = Color.FromArgb(39, 39, 39)
            frmStudInf.btnSub.BackColor = Color.FromArgb(66, 133, 244)
            frmStudInf.btnSub.ForeColor = Color.FromArgb(255, 255, 255)
            frmStudInf.picIcon1.Visible = False
            frmStudInf.picIcon2.Visible = True
            frmStudInf.lblTitleB.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInf.lblStudInfoEdi.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInf.lblAdd.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInf.lblAge.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInf.lblGen.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInf.lblGN.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInf.lblGr.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInf.lblHob.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInf.lblInfoSec.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInf.lblLang.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInf.lblLN.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInf.lblMail.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInf.lblMemInfo.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInf.lblMemInfoN1.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInf.lblMemInfoN2.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInf.lblMemInfoN3.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInf.lblMemInfoN4.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInf.lblMN.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInf.lblMoNo.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInf.lblNat.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInf.lblSec.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInf.lblSpec.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInf.lblErrMes1.ForeColor = Color.FromArgb(26, 13, 171)
            frmStudInf.lblErrMes2.ForeColor = Color.FromArgb(26, 13, 171)
            frmStudInf.btnSettings.ForeColor = Color.FromArgb(255, 255, 255)
            frmStudInf.btnInfo.ForeColor = Color.FromArgb(255, 255, 255)
            frmStudInf.lblchecker.BackColor = Color.White

            'Student Form Final'
            frmStudInfFnl.pnltitleB.BackColor = Color.FromArgb(231, 234, 237)
            frmStudInfFnl.pnlMain.BackColor = Color.FromArgb(255, 255, 255)
            frmStudInfFnl.BackColor = Color.FromArgb(255, 255, 255)
            frmStudInfFnl.lblAdd.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInfFnl.lblAge.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInfFnl.lblFnlAdd.ForeColor = Color.FromArgb(39, 39, 39)
            frmStudInfFnl.lblFnlAge.ForeColor = Color.FromArgb(39, 39, 39)
            frmStudInfFnl.lblFnlGen.ForeColor = Color.FromArgb(39, 39, 39)
            frmStudInfFnl.lblFnlGN.ForeColor = Color.FromArgb(39, 39, 39)
            frmStudInfFnl.lblFnlGr.ForeColor = Color.FromArgb(39, 39, 39)
            frmStudInfFnl.lblFnlHob.ForeColor = Color.FromArgb(39, 39, 39)
            frmStudInfFnl.lblFnlLang.ForeColor = Color.FromArgb(39, 39, 39)
            frmStudInfFnl.lblFnlLN.ForeColor = Color.FromArgb(39, 39, 39)
            frmStudInfFnl.lblFnlMail.ForeColor = Color.FromArgb(39, 39, 39)
            frmStudInfFnl.lblFnlMoNo.ForeColor = Color.FromArgb(39, 39, 39)
            frmStudInfFnl.lblFnlMN.ForeColor = Color.FromArgb(39, 39, 39)
            frmStudInfFnl.lblFnlNat.ForeColor = Color.FromArgb(39, 39, 39)
            frmStudInfFnl.lblFnlSec.ForeColor = Color.FromArgb(39, 39, 39)
            frmStudInfFnl.lblFnlSpec.ForeColor = Color.FromArgb(39, 39, 39)
            frmStudInfFnl.lblGen.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInfFnl.lblGN.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInfFnl.lblGr.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInfFnl.lblHob.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInfFnl.lblLang.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInfFnl.lblLN.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInfFnl.lblMail.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInfFnl.lblMN.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInfFnl.lblMoNo.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInfFnl.lblNat.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInfFnl.lblSec.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInfFnl.lblSpec.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInfFnl.lblStudInfoEdi.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInfFnl.lblTitleB.ForeColor = Color.FromArgb(108, 111, 113)
            frmStudInfFnl.btnEdit.ForeColor = Color.FromArgb(255, 255, 255)
            frmStudInfFnl.btnEdit.BackColor = Color.FromArgb(66, 133, 244)
            frmStudInfFnl.picIcon2.Visible = True
            frmStudInfFnl.picIcon1.Visible = False

        ElseIf optDark.Checked = True Then

            'Student Form'
            frmStudInf.pnltitleB.BackColor = Color.FromArgb(43, 55, 61)
            frmStudInf.pnlMain.BackColor = Color.FromArgb(32, 33, 36)
            frmStudInf.pnlInfo.BackColor = Color.FromArgb(45, 46, 48)
            frmStudInf.BackColor = Color.FromArgb(68, 87, 96)
            frmStudInf.txtAdd.BackColor = Color.FromArgb(48, 49, 52)
            frmStudInf.txtAge.BackColor = Color.FromArgb(48, 49, 52)
            frmStudInf.txtGen.BackColor = Color.FromArgb(48, 49, 52)
            frmStudInf.txtGN.BackColor = Color.FromArgb(48, 49, 52)
            frmStudInf.txtGr.BackColor = Color.FromArgb(48, 49, 52)
            frmStudInf.txtHob.BackColor = Color.FromArgb(48, 49, 52)
            frmStudInf.txtLang.BackColor = Color.FromArgb(48, 49, 52)
            frmStudInf.txtLN.BackColor = Color.FromArgb(48, 49, 52)
            frmStudInf.txtMail.BackColor = Color.FromArgb(48, 49, 52)
            frmStudInf.txtMN.BackColor = Color.FromArgb(48, 49, 52)
            frmStudInf.txtMoNo.BackColor = Color.FromArgb(48, 49, 52)
            frmStudInf.txtNat.BackColor = Color.FromArgb(48, 49, 52)
            frmStudInf.txtSec.BackColor = Color.FromArgb(48, 49, 52)
            frmStudInf.txtSpec.BackColor = Color.FromArgb(48, 49, 52)
            frmStudInf.txtAdd.ForeColor = Color.White
            frmStudInf.txtAge.ForeColor = Color.White
            frmStudInf.txtGen.ForeColor = Color.White
            frmStudInf.txtGN.ForeColor = Color.White
            frmStudInf.txtGr.ForeColor = Color.White
            frmStudInf.txtHob.ForeColor = Color.White
            frmStudInf.txtLang.ForeColor = Color.White
            frmStudInf.txtLN.ForeColor = Color.White
            frmStudInf.txtMail.ForeColor = Color.White
            frmStudInf.txtMN.ForeColor = Color.White
            frmStudInf.txtMoNo.ForeColor = Color.White
            frmStudInf.txtNat.ForeColor = Color.White
            frmStudInf.txtSec.ForeColor = Color.White
            frmStudInf.txtSpec.ForeColor = Color.White
            frmStudInf.btnSub.BackColor = Color.FromArgb(138, 180, 248)
            frmStudInf.btnSub.ForeColor = Color.FromArgb(32, 33, 36)
            frmStudInf.picIcon1.Visible = True
            frmStudInf.picIcon2.Visible = False
            frmStudInf.lblTitleB.ForeColor = Color.White
            frmStudInf.lblStudInfoEdi.ForeColor = Color.White
            frmStudInf.lblAdd.ForeColor = Color.White
            frmStudInf.lblAge.ForeColor = Color.White
            frmStudInf.lblGen.ForeColor = Color.White
            frmStudInf.lblGN.ForeColor = Color.White
            frmStudInf.lblGr.ForeColor = Color.White
            frmStudInf.lblHob.ForeColor = Color.White
            frmStudInf.lblInfoSec.ForeColor = Color.White
            frmStudInf.lblLang.ForeColor = Color.White
            frmStudInf.lblLN.ForeColor = Color.White
            frmStudInf.lblMail.ForeColor = Color.White
            frmStudInf.lblMemInfo.ForeColor = Color.White
            frmStudInf.lblMemInfoN1.ForeColor = Color.White
            frmStudInf.lblMemInfoN2.ForeColor = Color.White
            frmStudInf.lblMemInfoN3.ForeColor = Color.White
            frmStudInf.lblMemInfoN4.ForeColor = Color.White
            frmStudInf.lblMN.ForeColor = Color.White
            frmStudInf.lblMoNo.ForeColor = Color.White
            frmStudInf.lblNat.ForeColor = Color.White
            frmStudInf.lblSec.ForeColor = Color.White
            frmStudInf.lblSpec.ForeColor = Color.White
            frmStudInf.lblErrMes1.ForeColor = Color.FromArgb(138, 180, 248)
            frmStudInf.lblErrMes2.ForeColor = Color.FromArgb(138, 180, 248)
            frmStudInf.btnSettings.ForeColor = Color.FromArgb(68, 87, 96)
            frmStudInf.btnInfo.ForeColor = Color.FromArgb(68, 87, 96)
            frmStudInf.lblchecker.BackColor = Color.Black

            'Student Form Final'
            frmStudInfFnl.pnltitleB.BackColor = Color.FromArgb(43, 55, 61)
            frmStudInfFnl.pnlMain.BackColor = Color.FromArgb(32, 33, 36)
            frmStudInfFnl.BackColor = Color.FromArgb(68, 87, 96)
            frmStudInfFnl.lblAdd.ForeColor = Color.FromArgb(180, 180, 180)
            frmStudInfFnl.lblAge.ForeColor = Color.FromArgb(180, 180, 180)
            frmStudInfFnl.lblFnlAdd.ForeColor = Color.White
            frmStudInfFnl.lblFnlAge.ForeColor = Color.White
            frmStudInfFnl.lblFnlGen.ForeColor = Color.White
            frmStudInfFnl.lblFnlGN.ForeColor = Color.White
            frmStudInfFnl.lblFnlGr.ForeColor = Color.White
            frmStudInfFnl.lblFnlHob.ForeColor = Color.White
            frmStudInfFnl.lblFnlLang.ForeColor = Color.White
            frmStudInfFnl.lblFnlLN.ForeColor = Color.White
            frmStudInfFnl.lblFnlMail.ForeColor = Color.White
            frmStudInfFnl.lblFnlMN.ForeColor = Color.White
            frmStudInfFnl.lblFnlMoNo.ForeColor = Color.White
            frmStudInfFnl.lblFnlNat.ForeColor = Color.White
            frmStudInfFnl.lblFnlSec.ForeColor = Color.White
            frmStudInfFnl.lblFnlSpec.ForeColor = Color.White
            frmStudInfFnl.lblGen.ForeColor = Color.FromArgb(180, 180, 180)
            frmStudInfFnl.lblGN.ForeColor = Color.FromArgb(180, 180, 180)
            frmStudInfFnl.lblGr.ForeColor = Color.FromArgb(180, 180, 180)
            frmStudInfFnl.lblHob.ForeColor = Color.FromArgb(180, 180, 180)
            frmStudInfFnl.lblLang.ForeColor = Color.FromArgb(180, 180, 180)
            frmStudInfFnl.lblLN.ForeColor = Color.FromArgb(180, 180, 180)
            frmStudInfFnl.lblMail.ForeColor = Color.FromArgb(180, 180, 180)
            frmStudInfFnl.lblMN.ForeColor = Color.FromArgb(180, 180, 180)
            frmStudInfFnl.lblMoNo.ForeColor = Color.FromArgb(180, 180, 180)
            frmStudInfFnl.lblNat.ForeColor = Color.FromArgb(180, 180, 180)
            frmStudInfFnl.lblSec.ForeColor = Color.FromArgb(180, 180, 180)
            frmStudInfFnl.lblSpec.ForeColor = Color.FromArgb(180, 180, 180)
            frmStudInfFnl.lblStudInfoEdi.ForeColor = Color.White
            frmStudInfFnl.lblTitleB.ForeColor = Color.White
            frmStudInfFnl.btnEdit.ForeColor = Color.FromArgb(32, 33, 36)
            frmStudInfFnl.btnEdit.BackColor = Color.FromArgb(138, 180, 248)
            frmStudInfFnl.picIcon2.Visible = False
            frmStudInfFnl.picIcon1.Visible = True

        End If
        Me.Close()
    End Sub

    Private Sub optLight_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optLight.CheckedChanged
        picShow1.Visible = False
        picShow2.Visible = True
    End Sub

    Private Sub optDark_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optDark.CheckedChanged
        picShow1.Visible = True
        picShow2.Visible = False
    End Sub
End Class