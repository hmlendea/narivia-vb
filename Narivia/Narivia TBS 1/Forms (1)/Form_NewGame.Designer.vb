<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_NewGame
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
        Me.Button_Play = New System.Windows.Forms.Button()
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.ComboBox_Faction = New System.Windows.Forms.ComboBox()
        Me.Label_Faction = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button_Play
        '
        Me.Button_Play.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Play.Location = New System.Drawing.Point(37, 74)
        Me.Button_Play.Name = "Button_Play"
        Me.Button_Play.Size = New System.Drawing.Size(254, 32)
        Me.Button_Play.TabIndex = 3
        Me.Button_Play.Text = "Play"
        Me.Button_Play.UseVisualStyleBackColor = True
        '
        'Label_Title
        '
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Title.Location = New System.Drawing.Point(54, 9)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(212, 42)
        Me.Label_Title.TabIndex = 2
        Me.Label_Title.Text = "New Game"
        '
        'ComboBox_Faction
        '
        Me.ComboBox_Faction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Faction.FormattingEnabled = True
        Me.ComboBox_Faction.Items.AddRange(New Object() {"Alpalet", "Mah Rodah", "Caravenna", "Viristia", "Meuristia", "Befteria", "Ne Quin Arid", "Fatima", "Optimia", "Impera", "Impimia", "Faladai", "Daria"})
        Me.ComboBox_Faction.Location = New System.Drawing.Point(85, 112)
        Me.ComboBox_Faction.Name = "ComboBox_Faction"
        Me.ComboBox_Faction.Size = New System.Drawing.Size(206, 21)
        Me.ComboBox_Faction.TabIndex = 4
        '
        'Label_Faction
        '
        Me.Label_Faction.AutoSize = True
        Me.Label_Faction.Location = New System.Drawing.Point(34, 115)
        Me.Label_Faction.Name = "Label_Faction"
        Me.Label_Faction.Size = New System.Drawing.Size(45, 13)
        Me.Label_Faction.TabIndex = 5
        Me.Label_Faction.Text = "Faction:"
        '
        'Form_NewGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 320)
        Me.Controls.Add(Me.Label_Faction)
        Me.Controls.Add(Me.ComboBox_Faction)
        Me.Controls.Add(Me.Button_Play)
        Me.Controls.Add(Me.Label_Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form_NewGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_Play As System.Windows.Forms.Button
    Friend WithEvents Label_Title As System.Windows.Forms.Label
    Friend WithEvents ComboBox_Faction As System.Windows.Forms.ComboBox
    Friend WithEvents Label_Faction As System.Windows.Forms.Label
End Class
