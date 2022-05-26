Imports System.IO

Public Class Score

    Private listJoueur() As Enregistrement.Joueur

    Private Sub Score_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nom.Items.Clear()

        caseDecouv.Items.Clear()

        temps.Items.Clear()

        ComboBox1.Items.Clear()

        listJoueur = ScoreTri.TriJoueur(Enregistrement.getListJoueur())

        If Not listJoueur Is Nothing Then
            For Each j As Enregistrement.Joueur In listJoueur
                Nom.Items.Add(j.prenom)
                caseDecouv.Items.Add(j.meilleurNbCasesDecouvertes)
                temps.Items.Add(j.meilleurTemps)
                ComboBox1.Items.Add(j.prenom)
            Next
        End If
    End Sub

    Private Sub LeaveButton_Click(sender As Object, e As EventArgs) Handles LeaveButton.Click
        Me.Close()
    End Sub

    Private Sub Quit(sender As Object, e As EventArgs) Handles Me.Closed
        Accueil.Show()
    End Sub

    Private Sub Nom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Nom.SelectedIndexChanged, caseDecouv.SelectedIndexChanged, temps.SelectedIndexChanged
        Nom.SelectedIndex = sender.SelectedIndex
        caseDecouv.SelectedIndex = sender.SelectedIndex
        temps.SelectedIndex = sender.SelectedIndex

        ComboBox1.Text = Nom.SelectedItem
    End Sub

    Private Sub DetailButton_Click(sender As Object, e As EventArgs) Handles DetailButton.Click
        For i As Integer = 0 To Enregistrement.getNbJoueur() - 1
            If ComboBox1.SelectedItem = listJoueur(i).prenom Then
                Dim j As Joueur = listJoueur(i)
                MsgBox("Nom :" & j.prenom & vbCrLf &
                       "Meilleur nombre de révélées : " & j.meilleurNbCasesDecouvertes & vbCrLf &
                       "Meilleur temps de partie : " & j.meilleurTemps & vbCrLf &
                       "Nombre de partie(s) jouée(s) :" & j.nbParti & vbCrLf &
                       "Temps de jeu cumulé : " & j.temps)
            End If
        Next
    End Sub
End Class