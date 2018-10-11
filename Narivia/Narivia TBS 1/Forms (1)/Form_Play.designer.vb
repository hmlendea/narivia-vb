<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox_Debug = New System.Windows.Forms.CheckBox()
        Me.GroupBox_Actions = New System.Windows.Forms.GroupBox()
        Me.RadioButton_Info = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Attack = New System.Windows.Forms.RadioButton()
        Me.CheckBox_GameCursor = New System.Windows.Forms.CheckBox()
        Me.TextBox_TurnReport = New System.Windows.Forms.TextBox()
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
        CType(Me.GameScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Actions.SuspendLayout()
        Me.GroupBox_SelectedRegion.SuspendLayout()
        Me.GroupBox_PlayerFaction.SuspendLayout()
        Me.Panel.SuspendLayout()
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 60)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "PUSH ME PUSH ME PUSH ME"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.GroupBox_Actions.Controls.Add(Me.RadioButton_Info)
        Me.GroupBox_Actions.Controls.Add(Me.RadioButton_Attack)
        Me.GroupBox_Actions.Location = New System.Drawing.Point(6, 77)
        Me.GroupBox_Actions.Name = "GroupBox_Actions"
        Me.GroupBox_Actions.Size = New System.Drawing.Size(142, 41)
        Me.GroupBox_Actions.TabIndex = 3
        Me.GroupBox_Actions.TabStop = False
        Me.GroupBox_Actions.Text = "Actions"
        '
        'RadioButton_Info
        '
        Me.RadioButton_Info.AutoSize = True
        Me.RadioButton_Info.Location = New System.Drawing.Point(68, 19)
        Me.RadioButton_Info.Name = "RadioButton_Info"
        Me.RadioButton_Info.Size = New System.Drawing.Size(63, 17)
        Me.RadioButton_Info.TabIndex = 1
        Me.RadioButton_Info.Text = "Get Info"
        Me.RadioButton_Info.UseVisualStyleBackColor = True
        '
        'RadioButton_Attack
        '
        Me.RadioButton_Attack.AutoSize = True
        Me.RadioButton_Attack.Checked = True
        Me.RadioButton_Attack.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton_Attack.Name = "RadioButton_Attack"
        Me.RadioButton_Attack.Size = New System.Drawing.Size(56, 17)
        Me.RadioButton_Attack.TabIndex = 0
        Me.RadioButton_Attack.TabStop = True
        Me.RadioButton_Attack.Text = "Attack"
        Me.RadioButton_Attack.UseVisualStyleBackColor = True
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
        'TextBox_TurnReport
        '
        Me.TextBox_TurnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_TurnReport.Location = New System.Drawing.Point(3, 287)
        Me.TextBox_TurnReport.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBox_TurnReport.Multiline = True
        Me.TextBox_TurnReport.Name = "TextBox_TurnReport"
        Me.TextBox_TurnReport.ReadOnly = True
        Me.TextBox_TurnReport.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox_TurnReport.Size = New System.Drawing.Size(314, 353)
        Me.TextBox_TurnReport.TabIndex = 6
        Me.TextBox_TurnReport.WordWrap = False
        '
        'Label_TurnReport
        '
        Me.Label_TurnReport.AutoSize = True
        Me.Label_TurnReport.Location = New System.Drawing.Point(0, 274)
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
        Me.Panel.Controls.Add(Me.Label_TurnReport)
        Me.Panel.Controls.Add(Me.GroupBox_SelectedRegion)
        Me.Panel.Controls.Add(Me.TextBox_TurnReport)
        Me.Panel.Controls.Add(Me.GroupBox_PlayerFaction)
        Me.Panel.Controls.Add(Me.Label_Turn)
        Me.Panel.Controls.Add(Me.Button1)
        Me.Panel.Controls.Add(Me.GroupBox_Actions)
        Me.Panel.Controls.Add(Me.CheckBox_GameCursor)
        Me.Panel.Controls.Add(Me.CheckBox_Debug)
        Me.Panel.Location = New System.Drawing.Point(640, 0)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(320, 640)
        Me.Panel.TabIndex = 11
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
        Me.Text = "Narivia TBS 1 - Play"
        CType(Me.GameScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Actions.ResumeLayout(False)
        Me.GroupBox_Actions.PerformLayout()
        Me.GroupBox_SelectedRegion.ResumeLayout(False)
        Me.GroupBox_SelectedRegion.PerformLayout()
        Me.GroupBox_PlayerFaction.ResumeLayout(False)
        Me.GroupBox_PlayerFaction.PerformLayout()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GameScreen As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox_Debug As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox_Actions As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_Attack As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox_GameCursor As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox_TurnReport As System.Windows.Forms.TextBox
    Friend WithEvents Label_TurnReport As System.Windows.Forms.Label
    Friend WithEvents RadioButton_Info As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox_SelectedRegion As System.Windows.Forms.GroupBox
    Friend WithEvents Label_SelectedRegion_ArmySize As System.Windows.Forms.Label
    Friend WithEvents Label_SelectedRegion_Region As System.Windows.Forms.Label
    Friend WithEvents Label_SelectedRegion_Faction As System.Windows.Forms.Label
    Friend WithEvents GroupBox_PlayerFaction As System.Windows.Forms.GroupBox
    Friend WithEvents Label_PlayerFaction_ArmySize As System.Windows.Forms.Label
    Friend WithEvents Label_PlayerFaction_Name As System.Windows.Forms.Label
    Friend WithEvents Label_Turn As System.Windows.Forms.Label
    Friend WithEvents Panel As System.Windows.Forms.Panel
End Class
