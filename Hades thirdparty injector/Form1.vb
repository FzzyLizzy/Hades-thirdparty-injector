﻿Public Class Form1
    Dim DllFIle As String = "Hades.dll"
    Dim p() As Process
    'TODO: Download menu dll from this program (only if loging in to forum is a opsion)
    'TODO: display cuttent en new version in program
    'TODO: auto inject dll in to game after x sec
    'TODO: Clean code
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On_Steam.Checked = My.Settings.Steam
    End Sub
    Public Sub CheckGTAV_Running()
        p = Process.GetProcessesByName("GTA5")
        If p.Count > 0 Then
            Inject()
        Else
            Start_GTAV()
        End If
    End Sub
    Public Sub Start_GTAV()
        If My.Settings.Steam = True Then
            Process.Start("steam://rungameid/271590")
        Else
            If My.Settings.Toggle_GTA = False Then
                Dim uninstallNode As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\WOW6432Node\Microsoft\Windows\CurrentVersion\Uninstall\")
                For Each subKeyName As String In uninstallNode.GetSubKeyNames

                    Dim subKey As Microsoft.Win32.RegistryKey = uninstallNode.OpenSubKey(subKeyName)
                    Dim displayName As String = subKey.GetValue("DisplayName")
                    Dim InstallLocation As String = subKey.GetValue("InstallLocation")
                    If Not displayName Is Nothing Then

                        If displayName.Contains("Grand Theft Auto V") Then
                            My.Settings.GTA_folder = InstallLocation
                        End If
                    End If
                Next
                If System.IO.File.Exists(My.Settings.GTA_folder + "/PlayGTAV.exe") Then
                    Process.Start(My.Settings.GTA_folder + "/PlayGTAV.exe")
                Else
                    MessageBox.Show("Cannot find Grand Theft Auto V")
                End If
            End If
        End If
    End Sub
    Public Sub Inject()
        If System.IO.File.Exists("bin\" + DllFIle) Then
            If System.IO.File.Exists("bin\core.exe") Then
                Process.Start("bin\core.exe", "--process-name GTA5.exe --inject " + DllFIle)
            End If
        Else
            MessageBox.Show("cannot find :" + DllFIle)
            Process.Start("https://hadesgta.com/forum/index.php?forums/15/")
        End If
    End Sub
    Private Sub On_Steam_CheckBox(sender As Object, e As EventArgs) Handles On_Steam.CheckedChanged
        If On_Steam.Checked = True Then
            My.Settings.Steam = True
        Else
            My.Settings.Steam = False
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        CheckGTAV_Running()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Start_GTAV()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start("https://hadesgta.com/")
    End Sub
End Class
