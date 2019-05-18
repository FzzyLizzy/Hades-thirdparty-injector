Imports System.ComponentModel

Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Auto_inject.Checked = My.Settings.Auto_inject
        On_Steam.Checked = My.Settings.Steam
        injector_version_txt.Text = "Injector version: " + JVersion
        GTA_location()
        hades_installed()
    End Sub
    Private Sub Settings_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
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
    Private Sub On_Steam_CheckBox(sender As Object, e As EventArgs)
        If On_Steam.Checked = True Then
            My.Settings.Steam = True
        Else
            My.Settings.Steam = False
        End If
    End Sub
    Public Sub GTA_location()
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
    End Sub
    Public Sub hades_installed()
        If System.IO.File.Exists("bin\Hades.dll") Then
            Hades_ins_txt.Text = "Hades installed: Yes"
        Else
            Hades_ins_txt.Text = "Hades installed: No"
        End If
    End Sub
End Class