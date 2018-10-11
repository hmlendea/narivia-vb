Public Class Form_Play

    Private Sub Form_Editor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form_NewGame.Hide()
        Me.Show()
        Me.Focus()

        LoadMap()

        IsRunning = True
        ' Initialize graphics object

        'Graphics = Me.CreateGraphics
        'BackBuffer = New Bitmap(Me.Width, Me.Height)

        'StartGameLoop()

        If GraphicsInitialize(GameScreen) = False Then
            IsRunning = False
            End
        End If

        GameLoop()
    End Sub

    Private Sub Form_Editor_Unload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        IsRunning = False
        End
    End Sub

    Private Sub GameScreen_MouseEnter(sender As Object, e As System.EventArgs) Handles GameScreen.MouseEnter
        If GameCursor Then Windows.Forms.Cursor.Hide()
    End Sub

    Private Sub GameScreen_MouseLeave(sender As Object, e As System.EventArgs) Handles GameScreen.MouseLeave
        If GameCursor Then Windows.Forms.Cursor.Show()
    End Sub

    Private Sub GameScreen_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles GameScreen.MouseMove
        MouseX = CInt(Math.Floor(e.X / TileSize))
        MouseY = CInt(Math.Floor(e.Y / TileSize))

        Label_PlayerFaction_Name.Text = "Faction: " & Faction_Name(Faction_Player)
        Label_PlayerFaction_ArmySize.Text = "Army Size: " & Faction_Details(Faction_Player, 1)

        Label_SelectedRegion_Region.Text = "Region: " & Region_Details(Map(MouseX, MouseY), 0)
        Label_SelectedRegion_Faction.Text = "Faction: " & Faction_Name(CInt(Region_Details(Map(MouseX, MouseY), 2)))
        Label_SelectedRegion_ArmySize.Text = "Army Size: " & Faction_Details(CInt(Region_Details(Map(MouseX, MouseY), 2)), 1)
    End Sub

    Private Sub GameScreen_Click(sender As System.Object, e As System.EventArgs) Handles GameScreen.Click
        TextBox_TurnReport.Text = ""

        If RadioButton_Attack.Checked Then
            Attack_Region(Faction_Player, MouseX, MouseY)

            If OK = True Then
                For i = 1 To FactionsNumber
                    If i <> Faction_Player And Faction_Details(i, 0) = 1 Then

                        For j = 0 To Regions
                            If Region_Details(j, 3) = i And Region_Details(j, 2) <> i Then
                                For X = 0 To MapWidth
                                    For Y = 0 To MapHeight
                                        If Region_Details(Map(X, Y), 3) = i And Region_Details(Map(X, Y), 2) <> i And OK = False Then
                                            Attack_Region(i, X, Y)
                                            OK = True
                                            Exit For
                                        End If
                                        If OK = True Then Exit For
                                    Next
                                    If OK = True Then Exit For
                                Next
                            End If
                        Next

                        Do While Not OK
                            Attack_Region(i, Random(2, MapWidth - 2), Random(2, MapHeight - 2))
                        Loop
                        OK = False
                    End If
                                    Next

                GrowArmies()
                UnprotectAllRegions()

                Turn += 1
                Label_Turn.Text = "Turn: " & CStr(Turn)
            End If

        ElseIf RadioButton_Info.Checked Then
            MsgBox("Faction: " & Faction_Name(CInt(Region_Details(Map(MouseX, MouseY), 2))) & vbNewLine & "Region: " & Region_Details(Map(MouseX, MouseY), 0) & vbNewLine & "Faction's Army Size: " & Faction_Details(CInt(Region_Details(Map(MouseX, MouseY), 2)), 1) & vbNewLine & "Is this faction living? " & Faction_Details(Region_Details(Map(MouseX, MouseY), 2), 0))
        End If

        TextBox_TurnReport.SelectionStart = Len(TextBox_TurnReport.Text)
        TextBox_TurnReport.SelectionLength = 0
        TextBox_TurnReport.ScrollToCaret()
    End Sub

    Private Sub CheckBox_GameCursor_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox_GameCursor.CheckedChanged
        If CheckBox_GameCursor.Checked Then
            GameCursor = True
        Else
            GameCursor = False
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MsgBox("BATA-TE YSMIR")
    End Sub
End Class