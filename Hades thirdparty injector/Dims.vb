Imports System.IO

Module Dims
    Public DllFIle As String = "Hades.dll"
    Public JVersion As String = "0.0"
    Public Menu_Bin As String
    Public strPath As String = Directory.GetCurrentDirectory()
    Public LocalAppData As String = Environment.ExpandEnvironmentVariables("%AppData% \Hades")
    Public BinFolder As String = Environment.ExpandEnvironmentVariables("%AppData% \Hades\injector")
End Module
