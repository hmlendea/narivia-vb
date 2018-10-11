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
        TurnReport_Log_Battles.Text = ""
        TurnReport_Log_Recruitments.Text = ""

        If Action_Button_Attack.Checked Then
            If Faction_Details(Faction_Player, 1) >= MinimumTroopsToAttack Then
                Attack_Region(Faction_Player, Map(MouseX, MouseY))
            Else
                OK = True
                TurnReport_Log_Battles.Text += Faction_Name(Faction_Player) & " (ID " & Faction_Player & ")" & " did not attacked anything" & vbNewLine
            End If

        If OK = True Then
            OK = False
            For Faction = 1 To FactionsNumber
                If Faction <> Faction_Player And Faction_Details(Faction, 0) = 1 Then

                    If Faction_Details(Faction, 1) >= MinimumTroopsToAttack Then

                        If 1 = 2 Then
                            For j = 0 To Regions
                                If Region_Details(j, 3) = Faction Then
                                    If Region_Details(j, 2) <> Faction And OK = False Then
                                        Attack_Region(Faction, j)
                                        OK = True
                                    End If
                                End If
                            Next
                        End If

                        Do While Not OK
                            Attack_Region(Faction, Random(1, Regions))
                        Loop

                        OK = False
                    Else
                        TurnReport_Log_Battles.Text += Faction_Name(Faction) & " (ID " & Faction & ")" & " did not attacked anything" & vbNewLine
                        OK = True

                    End If
                End If
            Next

            GrowArmies()
            UnprotectAllRegions()

            Turn += 1
            Label_Turn.Text = "Turn: " & CStr(Turn)
        End If

        ElseIf Action_Button_SendSpy.Checked Then
        MsgBox("Faction: " & Faction_Name(CInt(Region_Details(Map(MouseX, MouseY), 2))) & vbNewLine _
               & "Region: " & Region_Details(Map(MouseX, MouseY), 0) & vbNewLine & _
               "Faction's Army Size: " & Faction_Details(CInt(Region_Details(Map(MouseX, MouseY), 2)), 1) & vbNewLine & _
               "Is this faction living? " & Faction_Details(Region_Details(Map(MouseX, MouseY), 2), 0) _
               , MsgBoxStyle.Information, "Espionage Report")
        End If

        TurnReport_Log_Battles.SelectionStart = Len(TurnReport_Log_Battles.Text)
        TurnReport_Log_Battles.SelectionLength = 0
        TurnReport_Log_Battles.ScrollToCaret()

        TurnReport_Log_Recruitments.SelectionStart = Len(TurnReport_Log_Recruitments.Text)
        TurnReport_Log_Recruitments.SelectionLength = 0
        TurnReport_Log_Recruitments.ScrollToCaret()
    End Sub

    Private Sub CheckBox_GameCursor_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox_GameCursor.CheckedChanged
        If CheckBox_GameCursor.Checked Then
            GameCursor = True
        Else
            GameCursor = False
        End If
    End Sub

    Private Sub Button_GameRules_Click(sender As System.Object, e As System.EventArgs) Handles Button_GameRules.Click
        MsgBox("Healing rate: " & HealingRate & vbNewLine _
               & "Army Growth rate: " & GrowthRateMin & " -> " & GrowthRateMax & vbNewLine _
               & "Extra Troops per Region: " & GrowthRateRegionsBonus & vbNewLine _
               & "Invader luck: " & Luck_Invader_Min & " -> " & Luck_Invader_Max & vbNewLine _
               & "Defender luck: " & Luck_Defender_Min & " -> " & Luck_Defender_Max & vbNewLine _
               & "Minimum Troops to attack: " & MinimumTroopsToAttack _
               , MsgBoxStyle.Information, "Game Rules")
    End Sub
End Class