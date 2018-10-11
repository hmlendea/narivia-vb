<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_MainMenu
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
        Me.Label_Title = New System.Windows.Forms.Label()
        Me.Button_NewGame = New System.Windows.Forms.Button()
        Me.Label_Version = New System.Windows.Forms.Label()
        Me.Label_MadeBy = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label_Title
        '
        Me.Label_Title.AutoSize = True
        Me.Label_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Title.Location = New System.Drawing.Point(30, 9)
        Me.Label_Title.Name = "Label_Title"
        Me.Label_Title.Size = New System.Drawing.Size(261, 42)
        Me.Label_Title.TabIndex = 0
        Me.Label_Title.Text = "Narivia TBS 1"
        '
        'Button_NewGame
        '
        Me.Button_NewGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_NewGame.Location = New System.Drawing.Point(37, 74)
        Me.Button_NewGame.Name = "Button_NewGame"
        Me.Button_NewGame.Size = New System.Drawing.Size(254, 32)
        Me.Button_NewGame.TabIndex = 1
        Me.Button_NewGame.Text = "New Game"
        Me.Button_NewGame.UseVisualStyleBackColor = True
        '
        'Label_Version
        '
        Me.Label_Version.AutoSize = True
        Me.Label_Version.Location = New System.Drawing.Point(12, 298)
        Me.Label_Version.Name = "Label_Version"
        Me.Label_Version.Size = New System.Drawing.Size(108, 13)
        Me.Label_Version.TabIndex = 3
        Me.Label_Version.Text = "Version: WIP1211.02"
        '
        'Label_MadeBy
        '
        Me.Label_MadeBy.AutoSize = True
        Me.Label_MadeBy.Location = New System.Drawing.Point(223, 285)
        Me.Label_MadeBy.Name = "Label_MadeBy"
        Me.Label_MadeBy.Size = New System.Drawing.Size(85, 26)
        Me.Label_MadeBy.TabIndex = 4
        Me.Label_MadeBy.Text = "Made by" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mlendea Horatiu"
        Me.Label_MadeBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form_MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 320)
        Me.Controls.Add(Me.Label_MadeBy)
        Me.Controls.Add(Me.Label_Version)
        Me.Controls.Add(Me.Button_NewGame)
        Me.Controls.Add(Me.Label_Title)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form_MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Narivia TBS 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_Title As System.Windows.Forms.Label
    Friend WithEvents Button_NewGame As System.Windows.Forms.Button
    Friend WithEvents Label_Version As System.Windows.Forms.Label
    Friend WithEvents Label_MadeBy As System.Windows.Forms.Label

End Class
