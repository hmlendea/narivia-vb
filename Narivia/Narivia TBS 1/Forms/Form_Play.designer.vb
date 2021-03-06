﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Play
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GameScreen = New System.Windows.Forms.PictureBox()
        Me.Button_GameRules = New System.Windows.Forms.Button()
        Me.CheckBox_Debug = New System.Windows.Forms.CheckBox()
        Me.GroupBox_Actions = New System.Windows.Forms.GroupBox()
        Me.Action_Button_SendSpy = New System.Windows.Forms.RadioButton()
        Me.Action_Button_Attack = New System.Windows.Forms.RadioButton()
        Me.CheckBox_GameCursor = New System.Windows.Forms.CheckBox()
        Me.TurnReport_Log_Battles = New System.Windows.Forms.TextBox()
        Me.Label_TurnReport = New System.Windows.Forms.Label()
        Me.GroupBox_SelectedRegion = New System.Windows.Forms.GroupBox()
        Me.Label_SelectedRegion_ArmySize = New System.Windows.Forms.Label()
        Me.Label_SelectedRegion_Region = New System.Windows.Forms.Label()
        Me.Label_SelectedRegion_Faction = New System.Windows.Forms.Label()
        Me.GroupBox_PlayerFaction = New System.Windows.Forms.GroupBox()
        Me.Label_PlayerFaction_ArmySize = New System.Windows.Forms.Label()
        Me.Label_PlayerFaction_Name = New System.Windows.Forms.Label()
        Me.Label_Turn = New System.Windows.Forms.Label()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TurnReport_Tag_Battles = New System.Windows.Forms.TabPage()
        Me.TurnReport_Tag_Recruitments = New System.Windows.Forms.TabPage()
        Me.TurnReport_Log_Recruitments = New System.Windows.Forms.TextBox()
        CType(Me.GameScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Actions.SuspendLayout()
        Me.GroupBox_SelectedRegion.SuspendLayout()
        Me.GroupBox_PlayerFaction.SuspendLayout()
        Me.Panel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TurnReport_Tag_Battles.SuspendLayout()
        Me.TurnReport_Tag_Recruitments.SuspendLayout()
        Me.SuspendLayout()
        '
        'GameScreen
        '
        Me.GameScreen.Location = New System.Drawing.Point(0, 0)
        Me.GameScreen.Name = "GameScreen"
        Me.GameScreen.Size = New System.Drawing.Size(640, 640)
        Me.GameScreen.TabIndex = 0
        Me.GameScreen.TabStop = False
        '
        'Button_GameRules
        '
        Me.Button_GameRules.Location = New System.Drawing.Point(6, 128)
        Me.Button_GameRules.Name = "Button_GameRules"
        Me.Button_GameRules.Size = New System.Drawing.Size(75, 23)
        Me.Button_GameRules.TabIndex = 1
        Me.Button_GameRules.Text = "Game Rules"
        Me.Button_GameRules.UseVisualStyleBackColor = True
        '
        'CheckBox_Debug
        '
        Me.CheckBox_Debug.AutoSize = True
        Me.CheckBox_Debug.Checked = True
        Me.CheckBox_Debug.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox_Debug.Location = New System.Drawing.Point(6, 6)
        Me.CheckBox_Debug.Name = "CheckBox_Debug"
        Me.CheckBox_Debug.Size = New System.Drawing.Size(88, 17)
        Me.CheckBox_Debug.TabIndex = 2
        Me.CheckBox_Debug.Text = "Show Debug"
        Me.CheckBox_Debug.UseVisualStyleBackColor = True
        '
        'GroupBox_Actions
        '
        Me.GroupBox_Actions.Controls.Add(Me.Action_Button_SendSpy)
        Me.GroupBox_Actions.Controls.Add(Me.Action_Button_Attack)
        Me.GroupBox_Actions.Location = New System.Drawing.Point(6, 77)
        Me.GroupBox_Actions.Name = "GroupBox_Actions"
        Me.GroupBox_Actions.Size = New System.Drawing.Size(142, 41)
        Me.GroupBox_Actions.TabIndex = 3
        Me.GroupBox_Actions.TabStop = False
        Me.GroupBox_Actions.Text = "Actions"
        '
        'Action_Button_SendSpy
        '
        Me.Action_Button_SendSpy.AutoSize = True
        Me.Action_Button_SendSpy.Location = New System.Drawing.Point(68, 19)
        Me.Action_Button_SendSpy.Name = "Action_Button_SendSpy"
        Me.Action_Button_SendSpy.Size = New System.Drawing.Size(71, 17)
        Me.Action_Button_SendSpy.TabIndex = 1
        Me.Action_Button_SendSpy.Text = "Send Spy"
        Me.Action_Button_SendSpy.UseVisualStyleBackColor = True
        '
        'Action_Button_Attack
        '
        Me.Action_Button_Attack.AutoSize = True
        Me.Action_Button_Attack.Checked = True
        Me.Action_Button_Attack.Location = New System.Drawing.Point(6, 19)
        Me.Action_Button_Attack.Name = "Action_Button_Attack"
        Me.Action_Button_Attack.Size = New System.Drawing.Size(56, 17)
        Me.Action_Button_Attack.TabIndex = 0
        Me.Action_Button_Attack.TabStop = True
        Me.Action_Button_Attack.Text = "Attack"
        Me.Action_Button_Attack.UseVisualStyleBackColor = True
        '
        'CheckBox_GameCursor
        '
        Me.CheckBox_GameCursor.AutoSize = True
        Me.CheckBox_GameCursor.Location = New System.Drawing.Point(6, 29)
        Me.CheckBox_GameCursor.Name = "CheckBox_GameCursor"
        Me.CheckBox_GameCursor.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox_GameCursor.TabIndex = 4
        Me.CheckBox_GameCursor.Text = "Game Cursor"
        Me.CheckBox_GameCursor.UseVisualStyleBackColor = True
        '
        'TurnReport_Log_Battles
        '
        Me.TurnReport_Log_Battles.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TurnReport_Log_Battles.Location = New System.Drawing.Point(-4, 0)
        Me.TurnReport_Log_Battles.Margin = New System.Windows.Forms.Padding(0)
        Me.TurnReport_Log_Battles.Multiline = True
        Me.TurnReport_Log_Battles.Name = "TurnReport_Log_Battles"
        Me.TurnReport_Log_Battles.ReadOnly = True
        Me.TurnReport_Log_Battles.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TurnReport_Log_Battles.Size = New System.Drawing.Size(320, 360)
        Me.TurnReport_Log_Battles.TabIndex = 6
        Me.TurnReport_Log_Battles.WordWrap = False
        '
        'Label_TurnReport
        '
        Me.Label_TurnReport.AutoSize = True
        Me.Label_TurnReport.Location = New System.Drawing.Point(0, 243)
        Me.Label_TurnReport.Name = "Label_TurnReport"
        Me.Label_TurnReport.Size = New System.Drawing.Size(90, 13)
        Me.Label_TurnReport.TabIndex = 7
        Me.Label_TurnReport.Text = "Last Turn Report:"
        '
        'GroupBox_SelectedRegion
        '
        Me.GroupBox_SelectedRegion.Controls.Add(Me.Label_SelectedRegion_ArmySize)
        Me.GroupBox_SelectedRegion.Controls.Add(Me.Label_SelectedRegion_Region)
        Me.GroupBox_SelectedRegion.Controls.Add(Me.Label_SelectedRegion_Faction)
        Me.GroupBox_SelectedRegion.Location = New System.Drawing.Point(166, 90)
        Me.GroupBox_SelectedRegion.Name = "GroupBox_SelectedRegion"
        Me.GroupBox_SelectedRegion.Size = New System.Drawing.Size(142, 61)
        Me.GroupBox_SelectedRegion.TabIndex = 8
        Me.GroupBox_SelectedRegion.TabStop = False
        Me.GroupBox_SelectedRegion.Text = "Selected Region"
        '
        'Label_SelectedRegion_ArmySize
        '
        Me.Label_SelectedRegion_ArmySize.AutoSize = True
        Me.Label_SelectedRegion_ArmySize.Location = New System.Drawing.Point(6, 42)
        Me.Label_SelectedRegion_ArmySize.Name = "Label_SelectedRegion_ArmySize"
        Me.Label_SelectedRegion_ArmySize.Size = New System.Drawing.Size(56, 13)
        Me.Label_SelectedRegion_ArmySize.TabIndex = 2
        Me.Label_SelectedRegion_ArmySize.Text = "Army Size:"
        '
        'Label_SelectedRegion_Region
        '
        Me.Label_SelectedRegion_Region.AutoSize = True
        Me.Label_SelectedRegion_Region.Location = New System.Drawing.Point(6, 16)
        Me.Label_SelectedRegion_Region.Name = "Label_SelectedRegion_Region"
        Me.Label_SelectedRegion_Region.Size = New System.Drawing.Size(41, 13)
        Me.Label_SelectedRegion_Region.TabIndex = 1
        Me.Label_SelectedRegion_Region.Text = "Region"
        '
        'Label_SelectedRegion_Faction
        '
        Me.Label_SelectedRegion_Faction.AutoSize = True
        Me.Label_SelectedRegion_Faction.Location = New System.Drawing.Point(6, 29)
        Me.Label_SelectedRegion_Faction.Name = "Label_SelectedRegion_Faction"
        Me.Label_SelectedRegion_Faction.Size = New System.Drawing.Size(45, 13)
        Me.Label_SelectedRegion_Faction.TabIndex = 0
        Me.Label_SelectedRegion_Faction.Text = "Faction:"
        '
        'GroupBox_PlayerFaction
        '
        Me.GroupBox_PlayerFaction.Controls.Add(Me.Label_PlayerFaction_ArmySize)
        Me.GroupBox_PlayerFaction.Controls.Add(Me.Label_PlayerFaction_Name)
        Me.GroupBox_PlayerFaction.Location = New System.Drawing.Point(166, 37)
        Me.GroupBox_PlayerFaction.Name = "GroupBox_PlayerFaction"
        Me.GroupBox_PlayerFaction.Size = New System.Drawing.Size(142, 47)
        Me.GroupBox_PlayerFaction.TabIndex = 9
        Me.GroupBox_PlayerFaction.TabStop = False
        Me.GroupBox_PlayerFaction.Text = "Your Faction"
        '
        'Label_PlayerFaction_ArmySize
        '
        Me.Label_PlayerFaction_ArmySize.AutoSize = True
        Me.Label_PlayerFaction_ArmySize.Location = New System.Drawing.Point(6, 29)
        Me.Label_PlayerFaction_ArmySize.Name = "Label_PlayerFaction_ArmySize"
        Me.Label_PlayerFaction_ArmySize.Size = New System.Drawing.Size(56, 13)
        Me.Label_PlayerFaction_ArmySize.TabIndex = 1
        Me.Label_PlayerFaction_ArmySize.Text = "Army Size:"
        '
        'Label_PlayerFaction_Name
        '
        Me.Label_PlayerFaction_Name.AutoSize = True
        Me.Label_PlayerFaction_Name.Location = New System.Drawing.Point(6, 16)
        Me.Label_PlayerFaction_Name.Name = "Label_PlayerFaction_Name"
        Me.Label_PlayerFaction_Name.Size = New System.Drawing.Size(38, 13)
        Me.Label_PlayerFaction_Name.TabIndex = 0
        Me.Label_PlayerFaction_Name.Text = "Name:"
        '
        'Label_Turn
        '
        Me.Label_Turn.AutoSize = True
        Me.Label_Turn.Location = New System.Drawing.Point(163, 6)
        Me.Label_Turn.Name = "Label_Turn"
        Me.Label_Turn.Size = New System.Drawing.Size(41, 13)
        Me.Label_Turn.TabIndex = 10
        Me.Label_Turn.Text = "Turn: 0"
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.TabControl1)
        Me.Panel.Controls.Add(Me.Button2)
        Me.Panel.Controls.Add(Me.Label_TurnReport)
        Me.Panel.Controls.Add(Me.GroupBox_SelectedRegion)
        Me.Panel.Controls.Add(Me.GroupBox_PlayerFaction)
        Me.Panel.Controls.Add(Me.Label_Turn)
        Me.Panel.Controls.Add(Me.Button_GameRules)
        Me.Panel.Controls.Add(Me.GroupBox_Actions)
        Me.Panel.Controls.Add(Me.CheckBox_GameCursor)
        Me.Panel.Controls.Add(Me.CheckBox_Debug)
        Me.Panel.Location = New System.Drawing.Point(640, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(320, 640)
        Me.Panel.TabIndex = 11
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(87, 128)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TurnReport_Tag_Battles)
        Me.TabControl1.Controls.Add(Me.TurnReport_Tag_Recruitments)
        Me.TabControl1.Location = New System.Drawing.Point(0, 258)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(320, 382)
        Me.TabControl1.TabIndex = 12
        '
        'TurnReport_Tag_Battles
        '
        Me.TurnReport_Tag_Battles.Controls.Add(Me.TurnReport_Log_Battles)
        Me.TurnReport_Tag_Battles.Location = New System.Drawing.Point(4, 22)
        Me.TurnReport_Tag_Battles.Name = "TurnReport_Tag_Battles"
        Me.TurnReport_Tag_Battles.Padding = New System.Windows.Forms.Padding(3)
        Me.TurnReport_Tag_Battles.Size = New System.Drawing.Size(312, 356)
        Me.TurnReport_Tag_Battles.TabIndex = 0
        Me.TurnReport_Tag_Battles.Text = "Battles"
        Me.TurnReport_Tag_Battles.UseVisualStyleBackColor = True
        '
        'TurnReport_Tag_Recruitments
        '
        Me.TurnReport_Tag_Recruitments.Controls.Add(Me.TurnReport_Log_Recruitments)
        Me.TurnReport_Tag_Recruitments.Location = New System.Drawing.Point(4, 22)
        Me.TurnReport_Tag_Recruitments.Name = "TurnReport_Tag_Recruitments"
        Me.TurnReport_Tag_Recruitments.Padding = New System.Windows.Forms.Padding(3)
        Me.TurnReport_Tag_Recruitments.Size = New System.Drawing.Size(312, 356)
        Me.TurnReport_Tag_Recruitments.TabIndex = 1
        Me.TurnReport_Tag_Recruitments.Text = "Recruitments"
        Me.TurnReport_Tag_Recruitments.UseVisualStyleBackColor = True
        '
        'TurnReport_Log_Recruitments
        '
        Me.TurnReport_Log_Recruitments.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TurnReport_Log_Recruitments.Location = New System.Drawing.Point(-4, 0)
        Me.TurnReport_Log_Recruitments.Margin = New System.Windows.Forms.Padding(0)
        Me.TurnReport_Log_Recruitments.Multiline = True
        Me.TurnReport_Log_Recruitments.Name = "TurnReport_Log_Recruitments"
        Me.TurnReport_Log_Recruitments.ReadOnly = True
        Me.TurnReport_Log_Recruitments.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TurnReport_Log_Recruitments.Size = New System.Drawing.Size(320, 360)
        Me.TurnReport_Log_Recruitments.TabIndex = 12
        Me.TurnReport_Log_Recruitments.WordWrap = False
        '
        'Form_Play
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 640)
        Me.Controls.Add(Me.GameScreen)
        Me.Controls.Add(Me.Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form_Play"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Narivia TBS 1 - Map Editor"
        CType(Me.GameScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Actions.ResumeLayout(False)
        Me.GroupBox_Actions.PerformLayout()
        Me.GroupBox_SelectedRegion.ResumeLayout(False)
        Me.GroupBox_SelectedRegion.PerformLayout()
        Me.GroupBox_PlayerFaction.ResumeLayout(False)
        Me.GroupBox_PlayerFaction.PerformLayout()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TurnReport_Tag_Battles.ResumeLayout(False)
        Me.TurnReport_Tag_Battles.PerformLayout()
        Me.TurnReport_Tag_Recruitments.ResumeLayout(False)
        Me.TurnReport_Tag_Recruitments.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GameScreen As System.Windows.Forms.PictureBox
    Friend WithEvents Button_GameRules As System.Windows.Forms.Button
    Friend WithEvents CheckBox_Debug As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox_Actions As System.Windows.Forms.GroupBox
    Friend WithEvents Action_Button_Attack As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox_GameCursor As System.Windows.Forms.CheckBox
    Friend WithEvents TurnReport_Log_Battles As System.Windows.Forms.TextBox
    Friend WithEvents Label_TurnReport As System.Windows.Forms.Label
    Friend WithEvents Action_Button_SendSpy As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox_SelectedRegion As System.Windows.Forms.GroupBox
    Friend WithEvents Label_SelectedRegion_ArmySize As System.Windows.Forms.Label
    Friend WithEvents Label_SelectedRegion_Region As System.Windows.Forms.Label
    Friend WithEvents Label_SelectedRegion_Faction As System.Windows.Forms.Label
    Friend WithEvents GroupBox_PlayerFaction As System.Windows.Forms.GroupBox
    Friend WithEvents Label_PlayerFaction_ArmySize As System.Windows.Forms.Label
    Friend WithEvents Label_PlayerFaction_Name As System.Windows.Forms.Label
    Friend WithEvents Label_Turn As System.Windows.Forms.Label
    Friend WithEvents Panel As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TurnReport_Tag_Battles As System.Windows.Forms.TabPage
    Friend WithEvents TurnReport_Tag_Recruitments As System.Windows.Forms.TabPage
    Friend WithEvents TurnReport_Log_Recruitments As System.Windows.Forms.TextBox
End Class
