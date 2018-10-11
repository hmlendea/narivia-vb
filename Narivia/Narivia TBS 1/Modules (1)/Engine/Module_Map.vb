Imports System.IO

Module Module_Map
    Public World As New Drawing.Bitmap(WorldDataFolder & "map.PNG")

    Public MapWidth As Integer = World.Width
    Public MapHeight As Integer = World.Height

    Public TileSize As Integer = 5
    Dim MaxFactions As Integer = 32

    Public FactionsNumber As Integer

    Public MapResolutionWidth As Integer = MapWidth * TileSize
    Public MapResolutionHeight As Integer = MapHeight * TileSize

    Public Map(MapWidth, MapHeight) As Integer

    Public Region_Details(128, 4) As String
    Public Faction_Details(MaxFactions, 3) As Integer

    '=============='
    '===' Region_Details
    'Layer 0: Name
    'Layer 1: Color (Hexacode)
    'Layer 2: Faction
    'Layer 3: Original owner Faction
    'Layer 4: Is Protected? (1 for True, 0 for False)
    '=============='
    '===' Faction_Details
    'Layer 0: Is Active? (1 for True, 0 for False)
    'Layer 1: Army Size

    Public Regions As Integer

    Public Faction_Name(32) As String

    Public MouseX As Integer
    Public MouseY As Integer

    Public Sub LoadMap()
        Try
            Dim StreamReader As New StreamReader(WorldDataFolder & "regions.PROPERTIES")

            Dim Result As String = ""

            Dim i As Integer = 0

            Do While (StreamReader.Peek <> -1)
                For a = 1 To 3
                    Dim Line As String = StreamReader.ReadLine

                    Dim RegionName As String = ("Region" & CStr(i) & "_Name").ToLower
                    Dim RegionColor As String = ("Region" & CStr(i) & "_Color").ToLower
                    Dim RegionFaction As String = ("Region" & CStr(i) & "_Faction").ToLower

                    If Line.ToLower.StartsWith(RegionName & "=") Then
                        Region_Details(i, 0) = Line.Substring(RegionName.Length + 1)
                    ElseIf Line.ToLower.StartsWith(RegionColor & "=") Then
                        Region_Details(i, 1) = Line.Substring(RegionColor.Length + 1)
                    ElseIf Line.ToLower.StartsWith(RegionFaction & "=") Then
                        Region_Details(i, 2) = CInt(Line.Substring(RegionFaction.Length + 1))
                        Region_Details(i, 3) = CInt(Line.Substring(RegionFaction.Length + 1))
                    End If
                    Regions = i
                Next
                i += 1
            Loop

            StreamReader.Close()
            StreamReader.Dispose()


            '''''''''''READ MAP_FACTIONS

            StreamReader = New IO.StreamReader(WorldDataFolder & "factions.PROPERTIES")

            i = 0
            Dim FactionName As String

            Do While (StreamReader.Peek <> -1)
                Dim Line As String = StreamReader.ReadLine

                FactionName = ("Faction" & CStr(i) & "_Name").ToLower

                If Line.ToLower.StartsWith(FactionName & "=") Then
                    Faction_Name(i) = Line.Substring(FactionName.Length + 1)
                    FactionsNumber = i
                End If
                i += 1
            Loop

            StreamReader.Close()
            StreamReader.Dispose()


            '''''''''''READ MAP_WORLD

            For X = 0 To MapWidth - 1
                For Y = 0 To MapHeight - 1
                    Dim Color As String = Hex(World.GetPixel(X, Y).ToArgb).ToString
                    For i = 0 To Region_Details.GetUpperBound(0)
                        If Color = Region_Details(i, 1) Then
                            Map(X, Y) = i
                        End If
                    Next
                Next
            Next
        Catch ErrorOpeningFile As Exception
            MsgBox("error")
        End Try

        ' SET FACTIONS AS ACTIVE and SET FACTIONS' ARMY SIZE
        For i = 1 To FactionsNumber
            Faction_Details(i, 0) = 1
            Faction_Details(i, 1) = 300
        Next
    End Sub
End Module
