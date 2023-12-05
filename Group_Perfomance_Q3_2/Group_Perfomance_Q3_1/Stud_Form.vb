Public Class frmStudInf
    Dim mouse_move As System.Drawing.Point
    Dim qualifier As Integer

    Private Sub btnCloseMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseMain.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
        frmStudInfFnl.Close()
        frmSettings.Close()
        Me.Close()
    End Sub

    Private Sub pnltitleB_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnltitleB.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub pnltitleB_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnltitleB.MouseDown

    End Sub

    Private Sub pnltitleB_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnltitleB.MouseMove

    End Sub



    Private Sub frmStudInf_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub frmStudInf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        qualifier = 0
    End Sub



    Private Sub btnSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSub.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
        If qualifier = 1 Then
            lblErrMes2.Visible = True
            If txtAdd.Text <> "" And txtAge.Text <> "" And txtGen.Text <> "" And txtGN.Text <> "" And txtGr.Text <> "" And txtHob.Text <> "" And txtLang.Text <> "" And txtLN.Text <> "" And txtMail.Text <> "" And txtMN.Text <> "" And txtMoNo.Text <> "" And txtNat.Text <> "" And txtSec.Text <> "" And txtSpec.Text <> "" Then
                frmStudInfFnl.lblFnlAdd.Text = txtAdd.Text
                frmStudInfFnl.lblFnlAge.Text = txtAge.Text
                frmStudInfFnl.lblFnlGen.Text = txtGen.Text
                frmStudInfFnl.lblFnlGN.Text = txtGN.Text
                frmStudInfFnl.lblFnlGr.Text = txtGr.Text
                frmStudInfFnl.lblFnlHob.Text = txtHob.Text
                frmStudInfFnl.lblFnlLang.Text = txtLang.Text
                frmStudInfFnl.lblFnlLN.Text = txtLN.Text
                frmStudInfFnl.lblFnlMail.Text = txtMail.Text
                frmStudInfFnl.lblFnlMN.Text = txtMN.Text
                frmStudInfFnl.lblFnlMoNo.Text = txtMoNo.Text
                frmStudInfFnl.lblFnlNat.Text = txtNat.Text
                frmStudInfFnl.lblFnlSec.Text = txtSec.Text
                frmStudInfFnl.lblFnlSpec.Text = txtSpec.Text
                lblErrMes2.Visible = False
                Me.Hide()
                frmStudInfFnl.Show()
            End If
        Else
            lblErrMes2.Visible = True
        End If

    End Sub

    Private Sub txtMail_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMail.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub txtMail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMail.TextChanged
        Dim check1 As String
        Dim checkInstr1 As String
        Dim check2 As String
        Dim checkReverse As String
        Dim checkInstr2 As String
        check1 = txtMail.Text
        checkInstr1 = InStr(check1, "@")
        check2 = txtMail.Text
        checkReverse = StrReverse(check2)
        checkInstr2 = InStr(checkReverse, ".")
        If checkInstr1 >= 1 And checkInstr2 >= 1 Then
            lblErrMes1.Visible = False
            qualifier = 1
        Else
            lblErrMes1.Visible = True
            qualifier = 0
        End If
    End Sub

    Private Sub btnInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pnlInfo.Visible = True
        btnClInfo.Visible = True
        btnInfo.Visible = False
    End Sub

    Private Sub btnClInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub lblAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblAdd.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub lblAge_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblAge.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub lblErrMes1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblErrMes1.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub lblErrMes2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblErrMes2.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub


    Private Sub lblGen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblGen.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub lblGN_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblGN.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub lblGr_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblGr.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub lblHob_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblHob.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub lblLang_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblLang.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub lblLN_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblLN.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub lblMail_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblMail.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub lblMN_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblMN.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub lblMoNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblMoNo.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub lblNat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblNat.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub lblSec_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblSec.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub lblSpec_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblSpec.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub lblStudInfoEdi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblStudInfoEdi.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub lblTitleB_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblTitleB.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub picIcon_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picIcon1.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub pnlMain_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlMain.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub txtAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAdd.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub txtAge_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAge.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub txtGen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGen.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub txtGN_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGN.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub txtGr_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGr.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub txtHob_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHob.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub txtLang_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLang.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub txtLN_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLN.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub txtMN_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMN.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub txtMoNo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMoNo.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub txtNat_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNat.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub txtSec_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSec.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub txtSpec_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSpec.Click
        pnlInfo.Visible = False
        btnClInfo.Visible = False
        btnInfo.Visible = True
    End Sub

    Private Sub btnSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettings.Click
        frmSettings.Show()
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged

    End Sub
End Class
