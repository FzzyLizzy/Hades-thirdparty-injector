Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Net.WebClient.DownloadFile
Imports System.Runtime
Public Class Main
    Dim Auto_inject_count As String
    Dim p() As Process
    'TODO: Download menu dll from this program (only if loging in to forum is a opsion)
    'TODO: display cuttent en new version in program
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            CheckForUpdates()
        Catch ex As Exception
        End Try
        Core_check()
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
                            My.Settings.GTA_Folder = InstallLocation
                        End If
                    End If
                Next
                If System.IO.File.Exists(My.Settings.GTA_Folder + "/PlayGTAV.exe") Then
                    Process.Start(My.Settings.GTA_Folder + "/PlayGTAV.exe")
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
                If My.Settings.Close_After = True Then
                    End
                End If
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
            If My.Settings.Close_After = True Then
                End
            End If
        End If
    End Sub
    Private Sub Main_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub Main_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
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

    Private Sub Update_Button_Click(sender As Object, e As EventArgs) Handles Update_Button.Click
        Dim remoteUri As String = "https://github.com/DeadlyKltten/Hades-thirdparty-injector/raw/master/Release/Hades-Injector.exe"
        Dim fileName As String = "Hades-Injector.Update"
        Using client As New WebClient()
            client.DownloadFile(remoteUri, fileName)
        End Using
        If System.IO.File.Exists("Hades-Injector.Update") Then
            Process.Start("cmd", "/c move Hades-Injector.Update Hades-Injector.exe")
            End
            Else
            check_updateFile()
        End If
    End Sub
    Public Sub check_updateFile()
        If System.IO.File.Exists("Hades-Injector.Update") Then
            Process.Start("cmd", "/c move Hades-Injector.Update Hades-Injector.exe")
            End
        Else
            check_updateFile()
        End If
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        My.Settings.Save()
        End
    End Sub
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Hades_logo.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Hades_logo.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Hades_logo.MouseUp
        drag = False
    End Sub
    Public Sub Core_check()
        If Not System.IO.File.Exists("bin\core.exe") Then
            Core_Error.Visible = True
            Core_Error.Text = "WARNING core not found Injector will not work"
        End If
    End Sub
End Class
