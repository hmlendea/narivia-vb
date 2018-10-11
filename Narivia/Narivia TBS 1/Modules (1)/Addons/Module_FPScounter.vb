Module Module_FPScounter

    Public Second As Integer = TimeOfDay.Second
    Public Frames As Integer = 0
    Public MaxFrames As Integer = 0

    Public Sub CountFPS()
        If IsRunning Then
            If Second = TimeOfDay.Second Then
                Frames += 1
            Else
                MaxFrames = Frames
                Frames = 0
                Second = TimeOfDay.Second
            End If
        End If
    End Sub


End Module
