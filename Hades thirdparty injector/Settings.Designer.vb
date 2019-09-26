<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.Auto_inject = New System.Windows.Forms.CheckBox()
        Me.On_Steam = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Beta_switch = New System.Windows.Forms.CheckBox()
        Me.Close_after = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Hades_site = New System.Windows.Forms.WebBrowser()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Login_TXT = New System.Windows.Forms.Label()
        Me.Hades_ins_txt = New System.Windows.Forms.Label()
        Me.injector_version_txt = New System.Windows.Forms.Label()
        Me.GTA_location_txt = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BunifuFlatButton1 = New ns1.BunifuFlatButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ReLogin_button = New ns1.BunifuFlatButton()
        Me.HWID_Button = New ns1.BunifuFlatButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Auto_inject
        '
        Me.Auto_inject.AutoSize = True
        Me.Auto_inject.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Auto_inject.ForeColor = System.Drawing.Color.White
        Me.Auto_inject.Location = New System.Drawing.Point(6, 45)
        Me.Auto_inject.Name = "Auto_inject"
        Me.Auto_inject.Size = New System.Drawing.Size(88, 20)
        Me.Auto_inject.TabIndex = 6
        Me.Auto_inject.Text = "Auto inject"
        Me.Auto_inject.UseVisualStyleBackColor = True
        '
        'On_Steam
        '
        Me.On_Steam.AutoSize = True
        Me.On_Steam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.On_Steam.ForeColor = System.Drawing.Color.White
        Me.On_Steam.Location = New System.Drawing.Point(6, 19)
        Me.On_Steam.Name = "On_Steam"
        Me.On_Steam.Size = New System.Drawing.Size(118, 20)
        Me.On_Steam.TabIndex = 7
        Me.On_Steam.Text = "Steam Version "
        Me.On_Steam.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.Beta_switch)
        Me.GroupBox1.Controls.Add(Me.Close_after)
        Me.GroupBox1.Controls.Add(Me.On_Steam)
        Me.GroupBox1.Controls.Add(Me.Auto_inject)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(3, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(564, 129)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Injector Settings"
        '
        'Beta_switch
        '
        Me.Beta_switch.AutoSize = True
        Me.Beta_switch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Beta_switch.ForeColor = System.Drawing.Color.White
        Me.Beta_switch.Location = New System.Drawing.Point(6, 97)
        Me.Beta_switch.Name = "Beta_switch"
        Me.Beta_switch.Size = New System.Drawing.Size(146, 20)
        Me.Beta_switch.TabIndex = 9
        Me.Beta_switch.Text = "Enable injector beta"
        Me.Beta_switch.UseVisualStyleBackColor = True
        '
        'Close_after
        '
        Me.Close_after.AutoSize = True
        Me.Close_after.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Close_after.ForeColor = System.Drawing.Color.White
        Me.Close_after.Location = New System.Drawing.Point(6, 71)
        Me.Close_after.Name = "Close_after"
        Me.Close_after.Size = New System.Drawing.Size(143, 20)
        Me.Close_after.TabIndex = 8
        Me.Close_after.Text = "Close after injection"
        Me.Close_after.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(148, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Unstable version"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Hades_site)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Login_TXT)
        Me.GroupBox2.Controls.Add(Me.Hades_ins_txt)
        Me.GroupBox2.Controls.Add(Me.injector_version_txt)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(3, 167)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(564, 137)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Information"
        '
        'Hades_site
        '
        Me.Hades_site.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Hades_site.Location = New System.Drawing.Point(111, 10)
        Me.Hades_site.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Hades_site.Name = "Hades_site"
        Me.Hades_site.ScriptErrorsSuppressed = True
        Me.Hades_site.Size = New System.Drawing.Size(447, 121)
        Me.Hades_site.TabIndex = 11
        Me.Hades_site.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(552, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Menu version:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Login_TXT
        '
        Me.Login_TXT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Login_TXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_TXT.Location = New System.Drawing.Point(6, 103)
        Me.Login_TXT.Name = "Login_TXT"
        Me.Login_TXT.Size = New System.Drawing.Size(552, 29)
        Me.Login_TXT.TabIndex = 3
        Me.Login_TXT.Text = "Logged in as:"
        Me.Login_TXT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Hades_ins_txt
        '
        Me.Hades_ins_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Hades_ins_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hades_ins_txt.Location = New System.Drawing.Point(6, 74)
        Me.Hades_ins_txt.Name = "Hades_ins_txt"
        Me.Hades_ins_txt.Size = New System.Drawing.Size(552, 29)
        Me.Hades_ins_txt.TabIndex = 2
        Me.Hades_ins_txt.Text = "Hades installed:"
        Me.Hades_ins_txt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'injector_version_txt
        '
        Me.injector_version_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.injector_version_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.injector_version_txt.Location = New System.Drawing.Point(6, 16)
        Me.injector_version_txt.Name = "injector_version_txt"
        Me.injector_version_txt.Size = New System.Drawing.Size(552, 29)
        Me.injector_version_txt.TabIndex = 1
        Me.injector_version_txt.Text = "Injector version:"
        Me.injector_version_txt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GTA_location_txt
        '
        Me.GTA_location_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GTA_location_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GTA_location_txt.Location = New System.Drawing.Point(6, 16)
        Me.GTA_location_txt.Name = "GTA_location_txt"
        Me.GTA_location_txt.Size = New System.Drawing.Size(552, 29)
        Me.GTA_location_txt.TabIndex = 0
        Me.GTA_location_txt.Text = "GTA location:"
        Me.GTA_location_txt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.GTA_location_txt)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(3, 307)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(564, 54)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Locations"
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Wrong GTAV path?"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = False
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(8, 525)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(181, 48)
        Me.BunifuFlatButton1.TabIndex = 15
        Me.BunifuFlatButton1.Text = "Wrong GTAV path?"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(3, 364)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(564, 153)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Changelog"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.Black
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(6, 15)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(552, 130)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "splash screen finally works" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "==BETA==" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "start of Content downloader"
        '
        'ReLogin_button
        '
        Me.ReLogin_button.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.ReLogin_button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReLogin_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.ReLogin_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ReLogin_button.BorderRadius = 0
        Me.ReLogin_button.ButtonText = "Relogin Hades"
        Me.ReLogin_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ReLogin_button.DisabledColor = System.Drawing.Color.Gray
        Me.ReLogin_button.Iconcolor = System.Drawing.Color.Transparent
        Me.ReLogin_button.Iconimage = Nothing
        Me.ReLogin_button.Iconimage_right = Nothing
        Me.ReLogin_button.Iconimage_right_Selected = Nothing
        Me.ReLogin_button.Iconimage_Selected = Nothing
        Me.ReLogin_button.IconMarginLeft = 0
        Me.ReLogin_button.IconMarginRight = 0
        Me.ReLogin_button.IconRightVisible = False
        Me.ReLogin_button.IconRightZoom = 0R
        Me.ReLogin_button.IconVisible = True
        Me.ReLogin_button.IconZoom = 90.0R
        Me.ReLogin_button.IsTab = False
        Me.ReLogin_button.Location = New System.Drawing.Point(382, 525)
        Me.ReLogin_button.Name = "ReLogin_button"
        Me.ReLogin_button.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.ReLogin_button.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.ReLogin_button.OnHoverTextColor = System.Drawing.Color.White
        Me.ReLogin_button.selected = False
        Me.ReLogin_button.Size = New System.Drawing.Size(181, 48)
        Me.ReLogin_button.TabIndex = 16
        Me.ReLogin_button.Text = "Relogin Hades"
        Me.ReLogin_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ReLogin_button.Textcolor = System.Drawing.Color.White
        Me.ReLogin_button.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'HWID_Button
        '
        Me.HWID_Button.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.HWID_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HWID_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.HWID_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HWID_Button.BorderRadius = 0
        Me.HWID_Button.ButtonText = "License HWID Reset"
        Me.HWID_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HWID_Button.DisabledColor = System.Drawing.Color.Gray
        Me.HWID_Button.Iconcolor = System.Drawing.Color.Transparent
        Me.HWID_Button.Iconimage = Nothing
        Me.HWID_Button.Iconimage_right = Nothing
        Me.HWID_Button.Iconimage_right_Selected = Nothing
        Me.HWID_Button.Iconimage_Selected = Nothing
        Me.HWID_Button.IconMarginLeft = 0
        Me.HWID_Button.IconMarginRight = 0
        Me.HWID_Button.IconRightVisible = False
        Me.HWID_Button.IconRightZoom = 0R
        Me.HWID_Button.IconVisible = True
        Me.HWID_Button.IconZoom = 90.0R
        Me.HWID_Button.IsTab = False
        Me.HWID_Button.Location = New System.Drawing.Point(195, 525)
        Me.HWID_Button.Name = "HWID_Button"
        Me.HWID_Button.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.HWID_Button.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.HWID_Button.OnHoverTextColor = System.Drawing.Color.White
        Me.HWID_Button.selected = False
        Me.HWID_Button.Size = New System.Drawing.Size(181, 48)
        Me.HWID_Button.TabIndex = 17
        Me.HWID_Button.Text = "License HWID Reset"
        Me.HWID_Button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HWID_Button.Textcolor = System.Drawing.Color.White
        Me.HWID_Button.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox2.BackgroundImage = Global.Hades.My.Resources.Resources.X
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(542, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(572, 30)
        Me.FlowLayoutPanel1.TabIndex = 20
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(572, 580)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.HWID_Button)
        Me.Controls.Add(Me.ReLogin_button)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(572, 552)
        Me.Name = "Settings"
        Me.Text = "Settings & Info"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Auto_inject As CheckBox
    Friend WithEvents On_Steam As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GTA_location_txt As Label
    Friend WithEvents injector_version_txt As Label
    Friend WithEvents Hades_ins_txt As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Close_after As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Login_TXT As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuFlatButton1 As ns1.BunifuFlatButton
    Friend WithEvents Beta_switch As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ReLogin_button As ns1.BunifuFlatButton
    Friend WithEvents Hades_site As WebBrowser
    Friend WithEvents HWID_Button As ns1.BunifuFlatButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
