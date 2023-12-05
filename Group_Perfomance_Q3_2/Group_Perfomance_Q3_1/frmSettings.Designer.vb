<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.lblTitleB = New System.Windows.Forms.Label()
        Me.pnltitleB = New System.Windows.Forms.Panel()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.optDark = New System.Windows.Forms.RadioButton()
        Me.optLight = New System.Windows.Forms.RadioButton()
        Me.lblModes = New System.Windows.Forms.Label()
        Me.picShow2 = New System.Windows.Forms.PictureBox()
        Me.picShow1 = New System.Windows.Forms.PictureBox()
        Me.picIcon = New System.Windows.Forms.PictureBox()
        Me.btnCloseMain = New System.Windows.Forms.Button()
        Me.pnltitleB.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.picShow2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitleB
        '
        Me.lblTitleB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleB.ForeColor = System.Drawing.Color.White
        Me.lblTitleB.Location = New System.Drawing.Point(27, 0)
        Me.lblTitleB.Name = "lblTitleB"
        Me.lblTitleB.Size = New System.Drawing.Size(144, 24)
        Me.lblTitleB.TabIndex = 1
        Me.lblTitleB.Text = "Settings"
        Me.lblTitleB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnltitleB
        '
        Me.pnltitleB.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.pnltitleB.Controls.Add(Me.lblTitleB)
        Me.pnltitleB.Controls.Add(Me.picIcon)
        Me.pnltitleB.Controls.Add(Me.btnCloseMain)
        Me.pnltitleB.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnltitleB.Location = New System.Drawing.Point(0, 0)
        Me.pnltitleB.Name = "pnltitleB"
        Me.pnltitleB.Size = New System.Drawing.Size(537, 25)
        Me.pnltitleB.TabIndex = 5
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMain.Controls.Add(Me.picShow2)
        Me.pnlMain.Controls.Add(Me.btnApply)
        Me.pnlMain.Controls.Add(Me.optDark)
        Me.pnlMain.Controls.Add(Me.optLight)
        Me.pnlMain.Controls.Add(Me.picShow1)
        Me.pnlMain.Controls.Add(Me.lblModes)
        Me.pnlMain.Location = New System.Drawing.Point(2, 25)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(522, 351)
        Me.pnlMain.TabIndex = 7
        '
        'btnApply
        '
        Me.btnApply.BackColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApply.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnApply.Location = New System.Drawing.Point(443, 320)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(70, 26)
        Me.btnApply.TabIndex = 7
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = False
        '
        'optDark
        '
        Me.optDark.AutoSize = True
        Me.optDark.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.optDark.ForeColor = System.Drawing.Color.White
        Me.optDark.Location = New System.Drawing.Point(265, 22)
        Me.optDark.Name = "optDark"
        Me.optDark.Size = New System.Drawing.Size(179, 22)
        Me.optDark.TabIndex = 6
        Me.optDark.Text = "Dark Mode (Default)"
        Me.optDark.UseVisualStyleBackColor = True
        '
        'optLight
        '
        Me.optLight.AutoSize = True
        Me.optLight.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.optLight.ForeColor = System.Drawing.Color.White
        Me.optLight.Location = New System.Drawing.Point(30, 22)
        Me.optLight.Name = "optLight"
        Me.optLight.Size = New System.Drawing.Size(109, 22)
        Me.optLight.TabIndex = 5
        Me.optLight.Text = "Light Mode"
        Me.optLight.UseVisualStyleBackColor = True
        '
        'lblModes
        '
        Me.lblModes.AutoSize = True
        Me.lblModes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModes.ForeColor = System.Drawing.Color.White
        Me.lblModes.Location = New System.Drawing.Point(3, 3)
        Me.lblModes.Name = "lblModes"
        Me.lblModes.Size = New System.Drawing.Size(59, 16)
        Me.lblModes.TabIndex = 3
        Me.lblModes.Text = "Modes:"
        '
        'picShow2
        '
        Me.picShow2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picShow2.Image = Global.Group_Perfomance_Q3_1.My.Resources.Resources.capture_544_
        Me.picShow2.Location = New System.Drawing.Point(13, 54)
        Me.picShow2.Name = "picShow2"
        Me.picShow2.Size = New System.Drawing.Size(500, 260)
        Me.picShow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShow2.TabIndex = 8
        Me.picShow2.TabStop = False
        Me.picShow2.Visible = False
        '
        'picShow1
        '
        Me.picShow1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picShow1.Image = Global.Group_Perfomance_Q3_1.My.Resources.Resources.capture_543_
        Me.picShow1.Location = New System.Drawing.Point(13, 54)
        Me.picShow1.Name = "picShow1"
        Me.picShow1.Size = New System.Drawing.Size(500, 260)
        Me.picShow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShow1.TabIndex = 4
        Me.picShow1.TabStop = False
        '
        'picIcon
        '
        Me.picIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picIcon.Image = Global.Group_Perfomance_Q3_1.My.Resources.Resources.PngItem_3705594
        Me.picIcon.Location = New System.Drawing.Point(2, 1)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Size = New System.Drawing.Size(23, 23)
        Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIcon.TabIndex = 1
        Me.picIcon.TabStop = False
        '
        'btnCloseMain
        '
        Me.btnCloseMain.BackgroundImage = Global.Group_Perfomance_Q3_1.My.Resources.Resources.x
        Me.btnCloseMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCloseMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseMain.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnCloseMain.Location = New System.Drawing.Point(479, 1)
        Me.btnCloseMain.Name = "btnCloseMain"
        Me.btnCloseMain.Size = New System.Drawing.Size(46, 23)
        Me.btnCloseMain.TabIndex = 1
        Me.btnCloseMain.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(526, 378)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnltitleB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.Text = "Settings"
        Me.pnltitleB.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlMain.PerformLayout()
        CType(Me.picShow2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCloseMain As System.Windows.Forms.Button
    Friend WithEvents picIcon As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitleB As System.Windows.Forms.Label
    Friend WithEvents pnltitleB As System.Windows.Forms.Panel
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents lblModes As System.Windows.Forms.Label
    Friend WithEvents optLight As System.Windows.Forms.RadioButton
    Friend WithEvents optDark As System.Windows.Forms.RadioButton
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents picShow2 As System.Windows.Forms.PictureBox
    Friend WithEvents picShow1 As System.Windows.Forms.PictureBox
End Class
