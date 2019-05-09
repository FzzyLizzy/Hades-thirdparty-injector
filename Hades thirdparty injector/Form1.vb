Public Class Form1
    Dim DllFIle As String = "Hades.dll"
    Dim p() As Process
    Public Sub Inject()
        If System.IO.File.Exists(DllFIle) Then
            If System.IO.File.Exists("core.exe") Then
                Process.Start("core.exe", "--process-name GTA5.exe --inject " + DllFIle)
            End If
        Else
            MessageBox.Show("cannot find :" + DllFIle)
            Process.Start("https://hadesgta.com/forum/index.php?forums/15/")
        End If
    End Sub
    Public Sub GTACheck()
        p = Process.GetProcessesByName("GTA5")
        If p.Count > 0 Then
            Inject()
        Else
            MessageBox.Show("start Grand theft auto V manually")
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start("https://hadesgta.com/")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        GTACheck()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If My.Settings.Steam = True Then
            Process.Start("steam://rungameid/271590")
        Else
            If My.Settings.Toggle_GTA = False Then
                MessageBox.Show("select the 'GTA V' folder")
                If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then

                    My.Settings.GTA_folder = FolderBrowserDialog1.SelectedPath
                    My.Settings.Toggle_GTA = True
                    My.Settings.Save()
                    If System.IO.File.Exists(My.Settings.GTA_folder + "/PlayGTAV.exe") Then
                        Process.Start(My.Settings.GTA_folder + "/PlayGTAV.exe")
                    Else
                        My.Settings.Toggle_GTA = False
                        MessageBox.Show("cannot find the GTA v folder")
                    End If
                End If
            Else
                If System.IO.File.Exists(My.Settings.GTA_folder + "/PlayGTAV.exe") Then
                    Process.Start(My.Settings.GTA_folder + "/PlayGTAV.exe")
                Else
                    MessageBox.Show("start Grand theft auto V manually")
                    My.Settings.Toggle_GTA = False
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            My.Settings.Steam = True
        Else
            My.Settings.Steam = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Checked = My.Settings.Steam
    End Sub
End Class
