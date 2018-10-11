Module Module_Game
    Public Faction_Player As Integer
    Public Turn As Integer = 1

    Dim Luck_Invader_Min As Integer = 2
    Dim Luck_Invader_Max As Integer = 4
    Dim Luck_Defender_Min As Integer = 3
    Dim Luck_Defender_Max As Integer = 5
    Dim HealingRate As Short = 0.15
    Dim GrowthRateMin As Integer = 50
    Dim GrowthRateMax As Integer = 150
    Dim GrowthRateRegionsBonus As Integer = 2

    Dim dx() As Integer = {-1, -1, 0, 1, 1, 1, 0, -1, -2, -2, -2, -2, -1, 0, 1, 2, 2, 2, 2, 2, 1, 0, -1, -2}
    Dim dy() As Integer = {0, 1, 1, 1, 0, -1, -1, -1, -1, 0, 1, 2, 2, 2, 2, 2, 1, 0, -1, -2, -2, -2, -2, -2}

    Public Sub Attack_Region(ByVal AttackerFaction As Integer, ByVal X As Integer, ByVal Y As Integer)
        Dim DefenderRegion As Integer = Map(X, Y)
        Dim DefenderFaction As Integer = CInt(Region_Details(DefenderRegion, 2))

        Dim IsProtected As Boolean = False
        If Region_Details(DefenderRegion, 4) = 1 Then IsProtected = True

        If DefenderFaction <> 0 And DefenderFaction <> AttackerFaction And IsProtected = False Then
            If Faction_Details(AttackerFaction, 1) > 0 Then 'If it has an army
                If IsNeighbour(AttackerFaction, DefenderRegion) Then
                    'If it won
                    If Faction_Details(AttackerFaction, 1) * Random(Luck_Invader_Min, Luck_Invader_Max) > Faction_Details(DefenderFaction, 1) * Random(Luck_Defender_Min, Luck_Defender_Max) Then
                        Region_Details(DefenderRegion, 2) = CStr(AttackerFaction)
                        Region_Details(DefenderRegion, 4) = 1

                        Form_Play.TextBox_TurnReport.Text += Faction_Name(AttackerFaction) & " conquered " & Region_Details(DefenderRegion, 0) & " (" & Faction_Name(DefenderFaction) & ")" & vbNewLine
                        CheckForInactiveFactions()



                        Faction_Details(AttackerFaction, 1) -= Faction_Details(DefenderFaction, 1)
                        If Faction_Details(AttackerFaction, 1) < 0 Then Faction_Details(AttackerFaction, 1) = 0

                        Faction_Details(DefenderFaction, 1) = 0

                        OK = True
                    Else 'If it loses
                        Faction_Details(DefenderFaction, 1) -= Faction_Details(AttackerFaction, 1)
                        If Faction_Details(DefenderFaction, 1) < 0 Then
                            Faction_Details(DefenderFaction, 1) = 0
                        Else
                            Faction_Details(DefenderFaction, 1) += Math.Round(Faction_Details(DefenderFaction, 1) * HealingRate)
                        End If

                        Faction_Details(AttackerFaction, 1) = 0

                        OK = True
                    End If
                End If
            Else 'If it does not have an army
                OK = True
            End If
        End If
    End Sub

    Private Sub CheckForInactiveFactions()
        For i = 0 To FactionsNumber
            If Faction_Details(i, 0) = 1 Then
                Faction_Details(i, 0) = 0
                For j = 0 To Regions
                    If CInt(Region_Details(j, 2)) = i Then
                        Faction_Details(i, 0) = 1
                        Exit For
                    End If
                Next
                If Faction_Details(i, 0) = 0 Then Form_Play.TextBox_TurnReport.Text += Faction_Name(i) & " was destroyed" & vbNewLine
            End If
        Next
    End Sub

    Public Sub GrowArmies()
        For i = 1 To FactionsNumber
            Faction_Details(i, 1) += Random(GrowthRateMin, GrowthRateMax)
            For j = 0 To Regions
                If Region_Details(i, 2) = i Then Faction_Details(i, 1) += GrowthRateRegionsBonus
            Next
        Next
       
    End Sub

    Private Function IsNeighbour(ByVal Faction, ByVal Region)
        Dim Neighbour As Boolean = False

        For X = 2 To MapWidth - 2
            For Y = 2 To MapHeight - 2
                If Map(X, Y) = Region Then
                    For i = 0 To 23
                        If CInt(Region_Details(Map(X + dx(i), Y + dy(i)), 2)) = Faction And Neighbour = False Then
                            Neighbour = True
                            Exit For
                        End If
                    Next
                    If Neighbour = True Then Exit For
                End If
            Next
            If Neighbour = True Then Exit For
        Next
        Return Neighbour
    End Function

    Public Sub UnprotectAllRegions()
        For i = 1 To Regions
            Region_Details(i, 4) = 0
        Next
    End Sub
End Module
