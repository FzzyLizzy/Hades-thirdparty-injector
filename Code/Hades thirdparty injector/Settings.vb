Imports System.ComponentModel

Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Auto_inject.Checked = My.Settings.Auto_inject
        On_Steam.Checked = My.Settings.Steam
        Close_after.Checked = My.Settings.Close_After
        injector_version_txt.Text = "Injector version: " + JVersion
        Label1.Text = "Menu version: " + Menu_Bin
        GTA_location()
        hades_installed()
        get_username()
    End Sub
    Private Sub Settings_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.Save()
        Dim SecondForm As New Main
        My.Settings.Save()
        SecondForm.Show()
    End Sub
    Private Sub Auto_inject_CheckedChanged(sender As Object, e As EventArgs) Handles Auto_inject.CheckedChanged
        If Auto_inject.Checked = True Then
            My.Settings.Auto_inject = True
        Else
            My.Settings.Auto_inject = False
        End If
    End Sub
    Public Sub GTA_location()
        If My.Settings.Steam = True Then
            GTA_location_txt.Text = "GTA location: Steam library"
        Else
            If My.Settings.Toggle_GTA = False Then
                Dim uninstallNode As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\")
                For Each subKeyName As String In uninstallNode.GetSubKeyNames

                    Dim subKey As Microsoft.Win32.RegistryKey = uninstallNode.OpenSubKey(subKeyName)
                    Dim displayName As String = subKey.GetValue("DisplayName")
                    Dim InstallLocation As String = subKey.GetValue("InstallLocation")
                    If Not displayName Is Nothing Then

                        If displayName.Contains("Grand Theft Auto V") Then
                            GTA_location_txt.Text = "GTA location: " + InstallLocation
                        End If
                    End If
                Next
            Else
                GTA_location_txt.Text = "GTA location: " + My.Settings.Custom_GTA_Folder.Replace("\PlayGTAV.exe", "")
            End If
        End If

    End Sub
    Public Sub hades_installed()
        If System.IO.File.Exists("bin\" + DllFIle) Then
            Hades_ins_txt.Text = "Hades installed: Yes"
            Hades_location_txt.Text = "Hades location: " + strPath + "\bin\" + DllFIle
        Else
            Hades_ins_txt.Text = "Hades installed: No"
            Hades_location_txt.Text = "Hades location: "
        End If
    End Sub

    Private Sub On_Steam_CheckedChanged(sender As Object, e As EventArgs) Handles On_Steam.CheckedChanged
        If On_Steam.Checked = True Then
            My.Settings.Steam = True
            GTA_location()
        Else
            My.Settings.Steam = False
            GTA_location()
        End If
    End Sub

    Private Sub Close_after_CheckedChanged(sender As Object, e As EventArgs) Handles Close_after.CheckedChanged
        If Close_after.Checked = True Then
            My.Settings.Close_After = True
        Else
            My.Settings.Close_After = False
        End If
    End Sub
    Public Sub get_username()
        Dim LocalAppData As String = Environment.ExpandEnvironmentVariables("%AppData% \Hades")
        If System.IO.File.Exists(LocalAppData + "\Hades CFG.ini") Then
            Dim Counter As String = System.IO.File.ReadAllLines(LocalAppData + "\Hades CFG.ini")(1)
            Counter = Counter.Remove(0, 9)
            Login_TXT.Text = "Logged in as: " + Counter
        Else
            Login_TXT.Text = "Logged in as: None"
        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim filepath As New OpenFileDialog
        filepath.Title = "Select playGTAV.exe"
        filepath.Filter = "exe | PlayGTAV.exe"
        If filepath.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Settings.Toggle_GTA = "True"
            My.Settings.Custom_GTA_Folder = filepath.FileName
        End If
    End Sub
End Class