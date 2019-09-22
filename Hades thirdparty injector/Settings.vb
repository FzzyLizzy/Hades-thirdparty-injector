Imports System.ComponentModel

Public Class Settings
    Public Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.IO.File.Exists(BinFolder + "\Menu.bin") Then
            Menu_Bin = My.Computer.FileSystem.ReadAllText(BinFolder + "\Menu.bin")
        End If
        Auto_inject.Checked = My.Settings.Auto_inject
        On_Steam.Checked = My.Settings.Steam
        Close_after.Checked = My.Settings.Close_After
        Beta_switch.Checked = My.Settings.Beta
        injector_version_txt.Text = "Injector version: " + JVersion
        If My.Settings.Beta = True Then
            injector_version_txt.Text = "Injector version: " + JVersion + "-Beta"
        End If
        Label1.Text = "Menu version: " + Menu_Bin
        BetaLoader()
        GTA_location()
        hades_installed()
        get_username()
    End Sub
    Public Sub BetaLoader()
        Dim V As Boolean = My.Settings.Beta
        HWID_Button.Visible = V
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
                            InstallLocation = InstallLocation.Replace(",0", "").Replace("""", "")
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
        If System.IO.File.Exists(BinFolder + "\" + DllFIle) Then
            Hades_ins_txt.Text = "Hades installed: Yes"
        Else
            Hades_ins_txt.Text = "Hades installed: No"
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
        If System.IO.File.Exists(LocalAppData + "\Hades CFG.ini") Then
            Dim Counter As String = System.IO.File.ReadAllLines(LocalAppData + "\Hades CFG.ini")(1)
            Counter = Counter.Remove(0, 9)
            If Not Counter = "" Then
                Login_TXT.Text = "Logged in as: " + Counter
            Else
                Login_TXT.Text = "Logged in as: None"
                ReLogin_button.Text = "Login Hades"
            End If

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

    Private Sub Beta_switch_CheckedChanged(sender As Object, e As EventArgs) Handles Beta_switch.CheckedChanged
        If Beta_switch.Checked = True Then
            My.Settings.Beta = True
            injector_version_txt.Text = "Injector version: " + JVersion + "-Beta"
        Else
            My.Settings.Beta = False
            injector_version_txt.Text = "Injector version: " + JVersion
        End If
        BetaLoader()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles ReLogin_button.Click
        Dim SecondForm As New Login
        My.Settings.Save()
        SecondForm.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton2_Click_1(sender As Object, e As EventArgs) Handles HWID_Button.Click
        Hades_site.Navigate("https://hadesgta.com/forum/index.php?license/selfreset")
    End Sub
    Private Sub Hades_site_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles Hades_site.DocumentCompleted
        If System.IO.File.Exists(LocalAppData + "\Hades CFG.ini") Then
            Try
                Dim Counter1 As String = System.IO.File.ReadAllLines(LocalAppData + "\Hades CFG.ini")(1)
                Dim Counter2 As String = System.IO.File.ReadAllLines(LocalAppData + "\Hades CFG.ini")(2)
                Counter1 = Counter1.Remove(0, 9)
                Counter2 = Counter2.Remove(0, 9)
                Hades_site.Document.GetElementById("login").SetAttribute("value", Counter1)
                Hades_site.Document.GetElementById("password").SetAttribute("value", Counter2)
                Hades_site.Document.GetElementById("remember").InvokeMember("click")
                Hades_site.Document.GetElementById("password").Focus()
                System.Windows.Forms.SendKeys.Send("{ENTER}")
            Catch ex As Exception
            End Try
        End If
    End Sub
End Class