Imports System.ComponentModel
Imports System.IO
Imports System.Runtime
Public Class Main
    Dim DllFIle As String = "Hades.dll"
    Dim Auto_inject_count As String
    Dim p() As Process
    'TODO: Download menu dll from this program (only if loging in to forum is a opsion)
    'TODO: display cuttent en new version in program
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CheckForUpdates()
        Catch ex As Exception
        End Try
        If My.Settings.Auto_inject = True Then
            Inject_button.Visible = False
        Else
            Inject_button.Visible = True
        End If
    End Sub
    Public Sub CheckForUpdates()
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://raw.githubusercontent.com/DeadlyKltten/Hades-thirdparty-injector/master/Release/Version.bin")
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim newestversion As String = sr.ReadToEnd()
        If newestversion = JVersion Then
        Else
            Update_Button.Visible = True
        End If
    End Sub
    Public Sub Start_GTAV()
        If My.Settings.Auto_inject = True Then
            Auto_inject_Timer.Start()
        End If
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
                    MessageBox.Show("ERROR
Grand Theft Auto V Not found")
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
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Inject_button.Click
        Inject()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles StartGTAV_Button.Click
        Start_GTAV()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles Website_Button.Click
        Process.Start("https://hadesgta.com/forum/index.php")
    End Sub

    Private Sub Auto_inject_Timer_Tick(sender As Object, e As EventArgs) Handles Auto_inject_Timer.Tick
        p = Process.GetProcessesByName("GTA5")
        If p.Count > 0 Then
            Auto_inject_count = Auto_inject_count + 1
        End If

        If Auto_inject_count = 30 Then
            Inject()
            Auto_inject_Timer.Stop()
            End
        End If
    End Sub
    Private Sub Main_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub Main_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Dim strPath As String = Directory.GetCurrentDirectory()
        Dim p As String = e.Data.GetData(DataFormats.FileDrop)(0)
        Dim extension As String = Path.GetExtension(p)
        If extension = ".dll" Then
            If System.IO.File.Exists(strPath + "\bin\" + DllFIle) Then
                My.Computer.FileSystem.DeleteFile(strPath + "\bin\" + DllFIle)
            End If
            My.Computer.FileSystem.MoveFile(p, strPath + "\bin\" + DllFIle)
            MessageBox.Show("Menu successfully installed")
        End If
    End Sub

    Private Sub settings_button_Click(sender As Object, e As EventArgs) Handles settings_button.Click
        Dim SecondForm As New Settings
        My.Settings.Save()
        SecondForm.Show()
        Me.Hide()
    End Sub

    Private Sub Main_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
    End Sub
End Class
