Imports System.Drawing

Public Class Form_MainMenu

    Private Sub Button_NewGame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_NewGame.Click
        Form_NewGame.Show()
        Me.Hide()
    End Sub

End Class
