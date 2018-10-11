Imports System.Windows.Forms

Module Module_BaseEngine
    Public WorldDataFolder As String = "Data\World\"
    Public IsRunning As Boolean = False
    Public GameCursor As Boolean = False
    Public OK As Boolean

    Public Function Random(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Number As Integer = (Max - Min) * Rnd() + Min
        Return Number
    End Function

    Public Sub GameLoop()
        Do While IsRunning
            Application.DoEvents()

            DrawGraphics()

            CountFPS()
        Loop
    End Sub

End Module
