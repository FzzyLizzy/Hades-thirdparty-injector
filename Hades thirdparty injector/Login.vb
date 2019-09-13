Public Class Login
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim filePath As String = LocalAppData + "\Hades CFG.ini"
    Dim lines() As String = System.IO.File.ReadAllLines(filePath)
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles FlowLayoutPanel1.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles FlowLayoutPanel1.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles FlowLayoutPanel1.MouseUp
        drag = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
        Settings.Show()
    End Sub

    Private Sub UpdateM_Click(sender As Object, e As EventArgs) Handles UpdateM.Click
        If System.IO.File.Exists(LocalAppData + "\Hades CFG.ini") Then
            lines(1) = "Username=" + UsernameBox.Text
            System.IO.File.WriteAllLines(filePath, lines)
            lines(2) = "Password=" + PasswordBox.Text
            System.IO.File.WriteAllLines(filePath, lines)
        Else
            MessageBox.Show("save login data failed")
        End If
        Settings.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuMaterialTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles PasswordBox.OnValueChanged
        PasswordBox.isPassword = True
    End Sub
End Class