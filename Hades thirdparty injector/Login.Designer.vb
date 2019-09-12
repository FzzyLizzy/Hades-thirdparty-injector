<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.UpdateM = New ns1.BunifuFlatButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PasswordBox = New ns1.BunifuMaterialTextbox()
        Me.UsernameBox = New ns1.BunifuMaterialTextbox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(410, 36)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'UpdateM
        '
        Me.UpdateM.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.UpdateM.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.UpdateM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UpdateM.BorderRadius = 0
        Me.UpdateM.ButtonText = "Login"
        Me.UpdateM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateM.DisabledColor = System.Drawing.Color.Gray
        Me.UpdateM.Iconcolor = System.Drawing.Color.Transparent
        Me.UpdateM.Iconimage = Nothing
        Me.UpdateM.Iconimage_right = Nothing
        Me.UpdateM.Iconimage_right_Selected = Nothing
        Me.UpdateM.Iconimage_Selected = Nothing
        Me.UpdateM.IconMarginLeft = 0
        Me.UpdateM.IconMarginRight = 0
        Me.UpdateM.IconRightVisible = False
        Me.UpdateM.IconRightZoom = 0R
        Me.UpdateM.IconVisible = True
        Me.UpdateM.IconZoom = 90.0R
        Me.UpdateM.IsTab = False
        Me.UpdateM.Location = New System.Drawing.Point(11, 154)
        Me.UpdateM.Name = "UpdateM"
        Me.UpdateM.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.UpdateM.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.UpdateM.OnHoverTextColor = System.Drawing.Color.White
        Me.UpdateM.selected = False
        Me.UpdateM.Size = New System.Drawing.Size(386, 48)
        Me.UpdateM.TabIndex = 18
        Me.UpdateM.Text = "Login"
        Me.UpdateM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UpdateM.Textcolor = System.Drawing.Color.White
        Me.UpdateM.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox2.BackgroundImage = Global.Hades.My.Resources.Resources.X
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(369, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(47, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'PasswordBox
        '
        Me.PasswordBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.PasswordBox.ForeColor = System.Drawing.Color.White
        Me.PasswordBox.HintForeColor = System.Drawing.Color.White
        Me.PasswordBox.HintText = "Password"
        Me.PasswordBox.isPassword = True
        Me.PasswordBox.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.PasswordBox.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.PasswordBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.PasswordBox.LineThickness = 3
        Me.PasswordBox.Location = New System.Drawing.Point(12, 99)
        Me.PasswordBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PasswordBox.Name = "PasswordBox"
        Me.PasswordBox.Size = New System.Drawing.Size(385, 44)
        Me.PasswordBox.TabIndex = 20
        Me.PasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'UsernameBox
        '
        Me.UsernameBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UsernameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.UsernameBox.ForeColor = System.Drawing.Color.White
        Me.UsernameBox.HintForeColor = System.Drawing.Color.White
        Me.UsernameBox.HintText = "Username"
        Me.UsernameBox.isPassword = False
        Me.UsernameBox.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.UsernameBox.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.UsernameBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.UsernameBox.LineThickness = 3
        Me.UsernameBox.Location = New System.Drawing.Point(12, 47)
        Me.UsernameBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UsernameBox.Name = "UsernameBox"
        Me.UsernameBox.Size = New System.Drawing.Size(385, 44)
        Me.UsernameBox.TabIndex = 21
        Me.UsernameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(410, 217)
        Me.Controls.Add(Me.UsernameBox)
        Me.Controls.Add(Me.PasswordBox)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.UpdateM)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents UpdateM As ns1.BunifuFlatButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PasswordBox As ns1.BunifuMaterialTextbox
    Friend WithEvents UsernameBox As ns1.BunifuMaterialTextbox
End Class
