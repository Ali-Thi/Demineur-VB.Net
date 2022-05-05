Public Class Accueil
    Private Sub Quitter(sender As Object, e As EventArgs) Handles Button2.Click
        If (MsgBox("Voulez-vous quitter l'application ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            Close()
        End If
    End Sub

    Private Sub Jouer(sender As Object, e As EventArgs) Handles Button1.Click
        Dim peutLancer As Boolean = True
        If (ComboBox1.Text.Length < 3) Then
            Label1.ForeColor = Color.Red
            Label2.Visible = True
            peutLancer = False
        End If

        If peutLancer Then
            Me.Hide()
            Jeu.MakeProblem()
            Grille.Show()
        End If
    End Sub
End Class
