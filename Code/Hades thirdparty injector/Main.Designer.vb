<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Auto_inject_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Core_Error = New System.Windows.Forms.Label()
        Me.UpdateJ = New ns1.BunifuFlatButton()
        Me.Website = New ns1.BunifuFlatButton()
        Me.settings = New ns1.BunifuFlatButton()
        Me.Inject_B = New ns1.BunifuFlatButton()
        Me.StartGTAV = New ns1.BunifuFlatButton()
        Me.UpdateM = New ns1.BunifuFlatButton()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.ShowNewFolderButton = False
        '
        'Auto_inject_Timer
        '
        Me.Auto_inject_Timer.Interval = 1000
        '
        'Core_Error
        '
        Me.Core_Error.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Core_Error.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Core_Error.ForeColor = System.Drawing.Color.Red
        Me.Core_Error.Location = New System.Drawing.Point(0, 323)
        Me.Core_Error.Name = "Core_Error"
        Me.Core_Error.Size = New System.Drawing.Size(804, 16)
        Me.Core_Error.TabIndex = 11
        Me.Core_Error.Text = "Warning"
        Me.Core_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Core_Error.Visible = False
        '
        'UpdateJ
        '
        Me.UpdateJ.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.UpdateJ.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.UpdateJ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UpdateJ.BorderRadius = 0
        Me.UpdateJ.ButtonText = "Update Injector"
        Me.UpdateJ.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateJ.DisabledColor = System.Drawing.Color.Gray
        Me.UpdateJ.Iconcolor = System.Drawing.Color.Transparent
        Me.UpdateJ.Iconimage = Nothing
        Me.UpdateJ.Iconimage_right = Nothing
        Me.UpdateJ.Iconimage_right_Selected = Nothing
        Me.UpdateJ.Iconimage_Selected = Nothing
        Me.UpdateJ.IconMarginLeft = 0
        Me.UpdateJ.IconMarginRight = 0
        Me.UpdateJ.IconRightVisible = False
        Me.UpdateJ.IconRightZoom = 0R
        Me.UpdateJ.IconVisible = True
        Me.UpdateJ.IconZoom = 90.0R
        Me.UpdateJ.IsTab = False
        Me.UpdateJ.Location = New System.Drawing.Point(12, 165)
        Me.UpdateJ.Name = "UpdateJ"
        Me.UpdateJ.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.UpdateJ.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.UpdateJ.OnHoverTextColor = System.Drawing.Color.White
        Me.UpdateJ.selected = False
        Me.UpdateJ.Size = New System.Drawing.Size(392, 48)
        Me.UpdateJ.TabIndex = 12
        Me.UpdateJ.Text = "Update Injector"
        Me.UpdateJ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UpdateJ.Textcolor = System.Drawing.Color.White
        Me.UpdateJ.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Website
        '
        Me.Website.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Website.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Website.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Website.BorderRadius = 0
        Me.Website.ButtonText = "Website"
        Me.Website.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Website.DisabledColor = System.Drawing.Color.Gray
        Me.Website.Iconcolor = System.Drawing.Color.Transparent
        Me.Website.Iconimage = Nothing
        Me.Website.Iconimage_right = Nothing
        Me.Website.Iconimage_right_Selected = Nothing
        Me.Website.Iconimage_Selected = Nothing
        Me.Website.IconMarginLeft = 0
        Me.Website.IconMarginRight = 0
        Me.Website.IconRightVisible = False
        Me.Website.IconRightZoom = 0R
        Me.Website.IconVisible = True
        Me.Website.IconZoom = 90.0R
        Me.Website.IsTab = False
        Me.Website.Location = New System.Drawing.Point(12, 219)
        Me.Website.Name = "Website"
        Me.Website.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Website.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Website.OnHoverTextColor = System.Drawing.Color.White
        Me.Website.selected = False
        Me.Website.Size = New System.Drawing.Size(193, 48)
        Me.Website.TabIndex = 13
        Me.Website.Text = "Website"
        Me.Website.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Website.Textcolor = System.Drawing.Color.White
        Me.Website.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'settings
        '
        Me.settings.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.settings.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.settings.BorderRadius = 0
        Me.settings.ButtonText = "Settings"
        Me.settings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.settings.DisabledColor = System.Drawing.Color.Gray
        Me.settings.Iconcolor = System.Drawing.Color.Transparent
        Me.settings.Iconimage = Nothing
        Me.settings.Iconimage_right = Nothing
        Me.settings.Iconimage_right_Selected = Nothing
        Me.settings.Iconimage_Selected = Nothing
        Me.settings.IconMarginLeft = 0
        Me.settings.IconMarginRight = 0
        Me.settings.IconRightVisible = False
        Me.settings.IconRightZoom = 0R
        Me.settings.IconVisible = True
        Me.settings.IconZoom = 90.0R
        Me.settings.IsTab = False
        Me.settings.Location = New System.Drawing.Point(211, 219)
        Me.settings.Name = "settings"
        Me.settings.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.settings.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.settings.OnHoverTextColor = System.Drawing.Color.White
        Me.settings.selected = False
        Me.settings.Size = New System.Drawing.Size(193, 48)
        Me.settings.TabIndex = 14
        Me.settings.Text = "Settings"
        Me.settings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.settings.Textcolor = System.Drawing.Color.White
        Me.settings.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Inject_B
        '
        Me.Inject_B.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Inject_B.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Inject_B.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Inject_B.BorderRadius = 0
        Me.Inject_B.ButtonText = "Inject"
        Me.Inject_B.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Inject_B.DisabledColor = System.Drawing.Color.Gray
        Me.Inject_B.Iconcolor = System.Drawing.Color.Transparent
        Me.Inject_B.Iconimage = Nothing
        Me.Inject_B.Iconimage_right = Nothing
        Me.Inject_B.Iconimage_right_Selected = Nothing
        Me.Inject_B.Iconimage_Selected = Nothing
        Me.Inject_B.IconMarginLeft = 0
        Me.Inject_B.IconMarginRight = 0
        Me.Inject_B.IconRightVisible = False
        Me.Inject_B.IconRightZoom = 0R
        Me.Inject_B.IconVisible = True
        Me.Inject_B.IconZoom = 90.0R
        Me.Inject_B.IsTab = False
        Me.Inject_B.Location = New System.Drawing.Point(12, 273)
        Me.Inject_B.Name = "Inject_B"
        Me.Inject_B.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Inject_B.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Inject_B.OnHoverTextColor = System.Drawing.Color.White
        Me.Inject_B.selected = False
        Me.Inject_B.Size = New System.Drawing.Size(193, 48)
        Me.Inject_B.TabIndex = 15
        Me.Inject_B.Text = "Inject"
        Me.Inject_B.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Inject_B.Textcolor = System.Drawing.Color.White
        Me.Inject_B.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'StartGTAV
        '
        Me.StartGTAV.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.StartGTAV.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.StartGTAV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StartGTAV.BorderRadius = 0
        Me.StartGTAV.ButtonText = "Start GTAV"
        Me.StartGTAV.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StartGTAV.DisabledColor = System.Drawing.Color.Gray
        Me.StartGTAV.Iconcolor = System.Drawing.Color.Transparent
        Me.StartGTAV.Iconimage = Nothing
        Me.StartGTAV.Iconimage_right = Nothing
        Me.StartGTAV.Iconimage_right_Selected = Nothing
        Me.StartGTAV.Iconimage_Selected = Nothing
        Me.StartGTAV.IconMarginLeft = 0
        Me.StartGTAV.IconMarginRight = 0
        Me.StartGTAV.IconRightVisible = False
        Me.StartGTAV.IconRightZoom = 0R
        Me.StartGTAV.IconVisible = True
        Me.StartGTAV.IconZoom = 90.0R
        Me.StartGTAV.IsTab = False
        Me.StartGTAV.Location = New System.Drawing.Point(211, 273)
        Me.StartGTAV.Name = "StartGTAV"
        Me.StartGTAV.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.StartGTAV.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.StartGTAV.OnHoverTextColor = System.Drawing.Color.White
        Me.StartGTAV.selected = False
        Me.StartGTAV.Size = New System.Drawing.Size(193, 48)
        Me.StartGTAV.TabIndex = 16
        Me.StartGTAV.Text = "Start GTAV"
        Me.StartGTAV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.StartGTAV.Textcolor = System.Drawing.Color.White
        Me.StartGTAV.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'UpdateM
        '
        Me.UpdateM.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.UpdateM.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.UpdateM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.UpdateM.BorderRadius = 0
        Me.UpdateM.ButtonText = "Update Menu"
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
        Me.UpdateM.Location = New System.Drawing.Point(12, 165)
        Me.UpdateM.Name = "UpdateM"
        Me.UpdateM.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.UpdateM.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.UpdateM.OnHoverTextColor = System.Drawing.Color.White
        Me.UpdateM.selected = False
        Me.UpdateM.Size = New System.Drawing.Size(392, 48)
        Me.UpdateM.TabIndex = 17
        Me.UpdateM.Text = "Update Menu"
        Me.UpdateM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.UpdateM.Textcolor = System.Drawing.Color.White
        Me.UpdateM.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.RichTextBox1.ForeColor = System.Drawing.Color.White
        Me.RichTextBox1.Location = New System.Drawing.Point(410, 44)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RichTextBox1.Size = New System.Drawing.Size(382, 276)
        Me.RichTextBox1.TabIndex = 20
        Me.RichTextBox1.Text = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Hades.My.Resources.Resources.BackGround
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(392, 115)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.BackgroundImage = Global.Hades.My.Resources.Resources.X
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(745, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(47, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Main
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(804, 339)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.UpdateM)
        Me.Controls.Add(Me.StartGTAV)
        Me.Controls.Add(Me.Inject_B)
        Me.Controls.Add(Me.settings)
        Me.Controls.Add(Me.Website)
        Me.Controls.Add(Me.UpdateJ)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Core_Error)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.Text = "Hades menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Auto_inject_Timer As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Core_Error As Label
    Friend WithEvents UpdateJ As ns1.BunifuFlatButton
    Friend WithEvents Website As ns1.BunifuFlatButton
    Friend WithEvents settings As ns1.BunifuFlatButton
    Friend WithEvents Inject_B As ns1.BunifuFlatButton
    Friend WithEvents StartGTAV As ns1.BunifuFlatButton
    Friend WithEvents UpdateM As ns1.BunifuFlatButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
