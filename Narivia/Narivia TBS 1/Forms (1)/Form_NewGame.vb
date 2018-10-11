Imports System.Drawing

Public Class Form_NewGame

    Private Sub Button_Play_Click(sender As System.Object, e As System.EventArgs) Handles Button_Play.Click
        If ComboBox_Faction.Text <> "" Then
            Dim PanelSize As Integer = TileSize * 64

            Form_Play.Width = MapResolutionWidth + 6 + PanelSize
            Form_Play.Height = MapResolutionHeight + 28
            Form_Play.GameScreen.Width = MapResolutionWidth
            Form_Play.GameScreen.Height = MapResolutionHeight
            Form_Play.Panel.Width = PanelSize
            Form_Play.Panel.Height = MapResolutionHeight

            Form_Play.TextBox_TurnReport.Width = PanelSize
            Form_Play.TextBox_TurnReport.Height = Form_Play.GameScreen.Height - Form_Play.TextBox_TurnReport.Location.Y

            'Form_Play.Panel.Image = Image.FromFile("Data\Images\Panel.PNG")
            Form_Play.Panel.Location = New Point(MapResolutionWidth, Form_Play.Panel.Location.Y)

            'Form_Play.CheckBox_Debug.Location = New Point(MapResolutionWidth + 6, Form_Play.CheckBox_Debug.Location.Y)
            'Form_Play.CheckBox_GameCursor.Location = New Point(MapResolutionWidth + 6, Form_Play.CheckBox_GameCursor.Location.Y)
            'Form_Play.GroupBox_Actions.Location = New Point(MapResolutionWidth + 6, Form_Play.GroupBox_Actions.Location.Y)
            'Form_Play.GroupBox_PlayerFaction.Location = New Point(MapResolutionWidth + 6, Form_Play.GroupBox_PlayerFaction.Location.Y)
            'Form_Play.GroupBox_SelectedRegion.Location = New Point(MapResolutionWidth + 6, Form_Play.GroupBox_SelectedRegion.Location.Y)
            'Form_Play.Button1.Location = New Point(MapResolutionWidth + 6, Form_Play.Button1.Location.Y)
            'Form_Play.Label_Log.Location = New Point(MapResolutionWidth + 6, Form_Play.Label_Log.Location.Y)
            'Form_Play.TextBox_Log.Location = New Point(MapResolutionWidth, Form_Play.TextBox_Log.Location.Y)

            Form_Play.Show()
            Me.Hide()
        Else
            MsgBox("Please select a faction first!", vbCritical, "No faction selected")
        End If
        
    End Sub

    Private Sub Form_NewGame_Closing(sender As System.Object, e As System.EventArgs) Handles MyBase.Closing
        Form_MainMenu.Show()
        Me.Close()
    End Sub

    Private Sub ComboBox_Faction_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox_Faction.SelectedIndexChanged
        Faction_Player = ComboBox_Faction.SelectedIndex + 1
    End Sub
End Class