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
        Me.On_Steam = New System.Windows.Forms.CheckBox()
        Me.Auto_inject = New System.Windows.Forms.CheckBox()
        Me.Auto_inject_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Update_Button = New System.Windows.Forms.PictureBox()
        Me.StartGTAV_Button = New System.Windows.Forms.PictureBox()
        Me.Website_Button = New System.Windows.Forms.PictureBox()
        Me.Inject_button = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Version_txt = New System.Windows.Forms.Label()
        CType(Me.Update_Button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartGTAV_Button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Website_Button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inject_button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.ShowNewFolderButton = False
        '
        'On_Steam
        '
        Me.On_Steam.AutoSize = True
        Me.On_Steam.ForeColor = System.Drawing.Color.White
        Me.On_Steam.Location = New System.Drawing.Point(3, 26)
        Me.On_Steam.Name = "On_Steam"
        Me.On_Steam.Size = New System.Drawing.Size(73, 17)
        Me.On_Steam.TabIndex = 4
        Me.On_Steam.Text = "On Steam"
        Me.On_Steam.UseVisualStyleBackColor = True
        '
        'Auto_inject
        '
        Me.Auto_inject.AutoSize = True
        Me.Auto_inject.ForeColor = System.Drawing.Color.White
        Me.Auto_inject.Location = New System.Drawing.Point(3, 49)
        Me.Auto_inject.Name = "Auto_inject"
        Me.Auto_inject.Size = New System.Drawing.Size(76, 17)
        Me.Auto_inject.TabIndex = 5
        Me.Auto_inject.Text = "Auto inject"
        Me.Auto_inject.UseVisualStyleBackColor = True
        '
        'Auto_inject_Timer
        '
        Me.Auto_inject_Timer.Interval = 1000
        '
        'Update_Button
        '
        Me.Update_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Update_Button.BackgroundImage = Global.Hades.My.Resources.Resources.Update
        Me.Update_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Update_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Update_Button.Location = New System.Drawing.Point(524, 151)
        Me.Update_Button.Name = "Update_Button"
        Me.Update_Button.Size = New System.Drawing.Size(193, 59)
        Me.Update_Button.TabIndex = 6
        Me.Update_Button.TabStop = False
        Me.Update_Button.Visible = False
        '
        'StartGTAV_Button
        '
        Me.StartGTAV_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StartGTAV_Button.BackgroundImage = Global.Hades.My.Resources.Resources.Start_GTAV
        Me.StartGTAV_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.StartGTAV_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StartGTAV_Button.Location = New System.Drawing.Point(268, 151)
        Me.StartGTAV_Button.Name = "StartGTAV_Button"
        Me.StartGTAV_Button.Size = New System.Drawing.Size(193, 59)
        Me.StartGTAV_Button.TabIndex = 2
        Me.StartGTAV_Button.TabStop = False
        '
        'Website_Button
        '
        Me.Website_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Website_Button.BackgroundImage = Global.Hades.My.Resources.Resources.Website
        Me.Website_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Website_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Website_Button.Location = New System.Drawing.Point(524, 151)
        Me.Website_Button.Name = "Website_Button"
        Me.Website_Button.Size = New System.Drawing.Size(193, 59)
        Me.Website_Button.TabIndex = 1
        Me.Website_Button.TabStop = False
        '
        'Inject_button
        '
        Me.Inject_button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Inject_button.BackgroundImage = Global.Hades.My.Resources.Resources.Inject
        Me.Inject_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Inject_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Inject_button.Location = New System.Drawing.Point(12, 151)
        Me.Inject_button.Name = "Inject_button"
        Me.Inject_button.Size = New System.Drawing.Size(193, 59)
        Me.Inject_button.TabIndex = 0
        Me.Inject_button.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.Hades.My.Resources.Resources.BackGround
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(12, -56)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(705, 238)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'Version_txt
        '
        Me.Version_txt.ForeColor = System.Drawing.Color.White
        Me.Version_txt.Location = New System.Drawing.Point(0, 0)
        Me.Version_txt.Name = "Version_txt"
        Me.Version_txt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Version_txt.Size = New System.Drawing.Size(79, 23)
        Me.Version_txt.TabIndex = 7
        Me.Version_txt.Text = "$_Version"
        Me.Version_txt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Main
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuText
        Me.ClientSize = New System.Drawing.Size(730, 222)
        Me.Controls.Add(Me.Update_Button)
        Me.Controls.Add(Me.Auto_inject)
        Me.Controls.Add(Me.On_Steam)
        Me.Controls.Add(Me.StartGTAV_Button)
        Me.Controls.Add(Me.Website_Button)
        Me.Controls.Add(Me.Inject_button)
        Me.Controls.Add(Me.Version_txt)
        Me.Controls.Add(Me.PictureBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(746, 261)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(746, 261)
        Me.Name = "Main"
        Me.Text = "Hades menu"
        CType(Me.Update_Button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartGTAV_Button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Website_Button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inject_button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Inject_button As PictureBox
    Friend WithEvents Website_Button As PictureBox
    Friend WithEvents StartGTAV_Button As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents On_Steam As CheckBox
    Friend WithEvents Auto_inject As CheckBox
    Friend WithEvents Auto_inject_Timer As Timer
    Friend WithEvents Update_Button As PictureBox
    Friend WithEvents Version_txt As Label
End Class
