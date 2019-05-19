<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.Auto_inject = New System.Windows.Forms.CheckBox()
        Me.On_Steam = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Hades_ins_txt = New System.Windows.Forms.Label()
        Me.injector_version_txt = New System.Windows.Forms.Label()
        Me.GTA_location_txt = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.GroupBox1.Controls.Add(Me.On_Steam)
        Me.GroupBox1.Controls.Add(Me.Auto_inject)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 73)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Injector Settings"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Hades_ins_txt)
        Me.GroupBox2.Controls.Add(Me.injector_version_txt)
        Me.GroupBox2.Controls.Add(Me.GTA_location_txt)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(406, 94)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Information"
        '
        'Hades_ins_txt
        '
        Me.Hades_ins_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Hades_ins_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hades_ins_txt.Location = New System.Drawing.Point(6, 39)
        Me.Hades_ins_txt.Name = "Hades_ins_txt"
        Me.Hades_ins_txt.Size = New System.Drawing.Size(394, 23)
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
        Me.injector_version_txt.Size = New System.Drawing.Size(394, 23)
        Me.injector_version_txt.TabIndex = 1
        Me.injector_version_txt.Text = "Injector version:"
        Me.injector_version_txt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GTA_location_txt
        '
        Me.GTA_location_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GTA_location_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GTA_location_txt.Location = New System.Drawing.Point(6, 62)
        Me.GTA_location_txt.Name = "GTA_location_txt"
        Me.GTA_location_txt.Size = New System.Drawing.Size(394, 23)
        Me.GTA_location_txt.TabIndex = 0
        Me.GTA_location_txt.Text = "GTA location:"
        Me.GTA_location_txt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(430, 197)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(446, 236)
        Me.Name = "Settings"
        Me.Text = "Settings & Info"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Auto_inject As CheckBox
    Friend WithEvents On_Steam As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GTA_location_txt As Label
    Friend WithEvents injector_version_txt As Label
    Friend WithEvents Hades_ins_txt As Label
End Class
