Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Net.WebClient.DownloadFile
Imports System.Runtime
Public Class Main
    Dim Auto_inject_count As String
    Dim newestMenu As String
    Dim p() As Process
    'TODO: Download menu dll from this program (only if loging in to forum is a opsion)
    'TODO: display cuttent en new version in program
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateJ.Visible = False
        UpdateM.Visible = False
        Try
            CheckForUpdates()
            Setup()
            loadLog()
            Core_check()
            Check_MenuU()
        Catch ex As Exception
            MessageBox.Show("The server is not responding. Try again later")
        End Try
    End Sub
    Public Sub CheckForUpdates()
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://raw.githubusercontent.com/DeadlyKltten/Hades-thirdparty-injector/master/Release/Version.bin")
        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim newestversion As String = sr.ReadToEnd()
        If newestversion = JVersion Then
        Else
            UpdateJ.Visible = True
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
                            InstallLocation = InstallLocation.Replace(",0", "").Replace("""", "")
                            My.Settings.GTA_Folder = InstallLocation + "\PlayGTAV.exe"
                            MessageBox.Show(My.Settings.GTA_Folder)
                        End If
                    End If
                Next
                If System.IO.File.Exists(My.Settings.GTA_Folder) Then
                    Process.Start(My.Settings.GTA_Folder)
                Else
                    MessageBox.Show("ERROR
Grand Theft Auto V Not found")
                End If
            Else
                If System.IO.File.Exists(My.Settings.Custom_GTA_Folder) Then
                    Process.Start(My.Settings.Custom_GTA_Folder)
                Else
                    MessageBox.Show("ERROR
Grand Theft Auto V Not found")
                End If
            End If
        End If
    End Sub
    Public Sub Inject()
        If System.IO.File.Exists(BinFolder + "\" + DllFIle) Then
            If System.IO.File.Exists(BinFolder + "\core.exe") Then
                Process.Start(BinFolder + "\core.exe", "--process-name GTA5.exe --inject " + DllFIle)
                If My.Settings.Close_After = True Then
                    End
                End If
            End If
        Else
            MessageBox.Show("cannot find :" + DllFIle)
            Process.Start("https://hadesgta.com/forum/index.php?forums/15/")
        End If
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
            If System.IO.File.Exists(BinFolder + "\" + DllFIle) Then
                My.Computer.FileSystem.DeleteFile(strPath + "\" + DllFIle)
            End If
            My.Computer.FileSystem.MoveFile(p, BinFolder + "\" + DllFIle)
            MessageBox.Show("Menu successfully installed")
        End If
    End Sub

    Private Sub Main_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
    End Sub
    Public Sub check_updateFile()
        If System.IO.File.Exists("Hades-Injector.Update") Then
            Process.Start("cmd", "/c move Hades-Injector.Update Hades-Injector.exe && start Hades-Injector.exe")
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
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub
    Public Sub Core_check()
        If Not System.IO.File.Exists(BinFolder + "\core.exe") Then
            Download_core()
        End If
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles UpdateJ.Click
        Dim remoteUri As String = "https://github.com/DeadlyKltten/Hades-thirdparty-injector/raw/master/Release/Hades-Injector.exe"
        Dim fileName As String = "Hades-Injector.Update"
        Using client As New WebClient()
            client.DownloadFile(remoteUri, fileName)
        End Using
        If System.IO.File.Exists("Hades-Injector.Update") Then
            Process.Start("cmd", "/c move Hades-Injector.Update Hades-Injector.exe && start Hades-Injector.exe")
            End
        Else
            check_updateFile()
        End If
    End Sub

    Private Sub Website_Click(sender As Object, e As EventArgs) Handles Website.Click
        Process.Start("https://hadesgta.com/forum/index.php")
    End Sub

    Private Sub Settings_Click(sender As Object, e As EventArgs) Handles settings.Click
        Dim SecondForm As New Settings
        My.Settings.Save()
        SecondForm.Show()
        Me.Hide()
    End Sub
    Private Sub Inject_B_Click(sender As Object, e As EventArgs) Handles Inject_B.Click
        Inject()
    End Sub

    Private Sub StartGTAV_Click(sender As Object, e As EventArgs) Handles StartGTAV.Click
        Start_GTAV()
    End Sub
    Public Sub loadLog()
        Dim inStream As StreamReader
        Dim webRequest As WebRequest
        Dim webresponse As WebResponse
        webRequest = WebRequest.Create("https://raw.githubusercontent.com/DeadlyKltten/Hades-thirdparty-injector/master/Menu/log.bin")
        webresponse = webRequest.GetResponse()
        inStream = New StreamReader(webresponse.GetResponseStream())
        RichTextBox1.Text = inStream.ReadToEnd()
    End Sub
    Public Sub Check_MenuU()
        If Not System.IO.File.Exists(BinFolder + "\Menu.bin") Then
            My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/DeadlyKltten/Hades-thirdparty-injector/master/0.bin", BinFolder + "\Menu.bin")
            UpdateM.Text = "Install Menu"
            UpdateM.Visible = True
        Else
            Menu_Bin = My.Computer.FileSystem.ReadAllText(BinFolder + "\Menu.bin")
            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("https://raw.githubusercontent.com/DeadlyKltten/Hades-thirdparty-injector/master/Menu/Version.bin")
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
            newestMenu = sr.ReadToEnd()
            If newestMenu = Menu_Bin Then

            Else
                UpdateM.Visible = True
            End If
        End If
    End Sub
    Public Sub Update_Menu()
        My.Computer.FileSystem.DeleteFile(BinFolder + "\Menu.bin")
        My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/DeadlyKltten/Hades-thirdparty-injector/master/Menu/Version.bin", BinFolder + "\Menu.bin")
        If System.IO.File.Exists(BinFolder + "\Hades.dll") Then
            My.Computer.FileSystem.DeleteFile(BinFolder + "\Hades.dll")
        End If
        My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/DeadlyKltten/Hades-thirdparty-injector/master/Menu/Hades.dll", BinFolder + "\Hades.dll")
        UpdateM.Visible = False
        If Not newestMenu = "" Then
            MessageBox.Show("Updated to " + newestMenu)
        End If
    End Sub

    Public Sub Setup()
        If System.IO.Directory.Exists(BinFolder) Then
        Else
            System.IO.Directory.CreateDirectory(BinFolder)
        End If
        If My.Settings.Big_Form = True Then
            Me.Size = New Size(1653, 460)
        End If
        If My.Settings.Beta = True Then
            BetaLoader()
        End If
    End Sub
    Public Sub Download_core()
        Dim remoteUri As String = "https://github.com/DeadlyKltten/Hades-thirdparty-injector/raw/master/Release/core.exe"
        Dim fileName As String = BinFolder + "\core.exe"
        Using client As New WebClient()
            client.DownloadFile(remoteUri, fileName)
        End Using
    End Sub
    Private Sub UpdateM_Click(sender As Object, e As EventArgs) Handles UpdateM.Click
        Update_Menu()
    End Sub
    Dim bigForm As Boolean
    Public Sub switchsize() Handles MyBase.DoubleClick
        bigForm = My.Settings.Big_Form
        If bigForm = False Then
            bigForm = True
            My.Settings.Big_Form = True
            Me.Size = New Size(1653, 460)
        Else
            bigForm = False
            My.Settings.Big_Form = False
            Me.Size = New Size(804, 339)
        End If
        My.Settings.Save()
    End Sub
    Public Sub BetaLoader()

    End Sub
End Class
