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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.settings_button = New System.Windows.Forms.PictureBox()
        Me.Update_Button = New System.Windows.Forms.PictureBox()
        Me.StartGTAV_Button = New System.Windows.Forms.PictureBox()
        Me.Website_Button = New System.Windows.Forms.PictureBox()
        Me.Inject_button = New System.Windows.Forms.PictureBox()
        Me.Hades_logo = New System.Windows.Forms.PictureBox()
        Me.Core_Error = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.settings_button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Update_Button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartGTAV_Button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Website_Button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inject_button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hades_logo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.BackgroundImage = Global.Hades.My.Resources.Resources.X
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(431, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'settings_button
        '
        Me.settings_button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.settings_button.BackgroundImage = Global.Hades.My.Resources.Resources.settings
        Me.settings_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.settings_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.settings_button.Location = New System.Drawing.Point(14, 265)
        Me.settings_button.Name = "settings_button"
        Me.settings_button.Size = New System.Drawing.Size(193, 59)
        Me.settings_button.TabIndex = 8
        Me.settings_button.TabStop = False
        '
        'Update_Button
        '
        Me.Update_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Update_Button.BackgroundImage = Global.Hades.My.Resources.Resources.Update
        Me.Update_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Update_Button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Update_Button.Location = New System.Drawing.Point(13, 181)
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
        Me.StartGTAV_Button.Location = New System.Drawing.Point(268, 265)
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
        Me.Website_Button.Location = New System.Drawing.Point(13, 181)
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
        Me.Inject_button.Location = New System.Drawing.Point(268, 181)
        Me.Inject_button.Name = "Inject_button"
        Me.Inject_button.Size = New System.Drawing.Size(193, 59)
        Me.Inject_button.TabIndex = 0
        Me.Inject_button.TabStop = False
        '
        'Hades_logo
        '
        Me.Hades_logo.BackgroundImage = Global.Hades.My.Resources.Resources.BackGround
        Me.Hades_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Hades_logo.Location = New System.Drawing.Point(14, -1)
        Me.Hades_logo.Name = "Hades_logo"
        Me.Hades_logo.Size = New System.Drawing.Size(449, 176)
        Me.Hades_logo.TabIndex = 3
        Me.Hades_logo.TabStop = False
        '
        'Core_Error
        '
        Me.Core_Error.Dock = System.Windows.Forms.DockStyle.Top
        Me.Core_Error.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Core_Error.ForeColor = System.Drawing.Color.Red
        Me.Core_Error.Location = New System.Drawing.Point(0, 0)
        Me.Core_Error.Name = "Core_Error"
        Me.Core_Error.Size = New System.Drawing.Size(475, 16)
        Me.Core_Error.TabIndex = 11
        Me.Core_Error.Text = "Warning"
        Me.Core_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Core_Error.Visible = False
        '
        'Main
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(475, 336)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Core_Error)
        Me.Controls.Add(Me.settings_button)
        Me.Controls.Add(Me.Update_Button)
        Me.Controls.Add(Me.StartGTAV_Button)
        Me.Controls.Add(Me.Website_Button)
        Me.Controls.Add(Me.Inject_button)
        Me.Controls.Add(Me.Hades_logo)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.Text = "Hades menu"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.settings_button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Update_Button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartGTAV_Button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Website_Button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inject_button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hades_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Inject_button As PictureBox
    Friend WithEvents Website_Button As PictureBox
    Friend WithEvents StartGTAV_Button As PictureBox
    Friend WithEvents Hades_logo As PictureBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Auto_inject_Timer As Timer
    Friend WithEvents Update_Button As PictureBox
    Friend WithEvents settings_button As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Core_Error As Label
End Class
