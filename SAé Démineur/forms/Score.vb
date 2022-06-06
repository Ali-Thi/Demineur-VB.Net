Imports System.IO

Public Class Score

    Private listOrdered As Integer = 1
    Private listJoueur() As Enregistrement.Joueur

    Private Sub Score_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        listJoueur = ScoreTri.TriJoueur(Enregistrement.getListJoueur())

        If Not listJoueur Is Nothing Then
            For Each j As Enregistrement.Joueur In listJoueur
                Nom.Items.Add(j.prenom)
                BestNbCasesDecouv.Items.Add(j.meilleurNbCasesDecouvertes)
                BestTemps.Items.Add(j.meilleurTemps)
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

    Private Sub Nom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Nom.SelectedIndexChanged, BestNbCasesDecouv.SelectedIndexChanged, BestTemps.SelectedIndexChanged
        Nom.SelectedIndex = sender.SelectedIndex
        BestNbCasesDecouv.SelectedIndex = sender.SelectedIndex
        BestTemps.SelectedIndex = sender.SelectedIndex

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

    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        For Each item In Nom.Items
            If item = ComboBox1.Text Then
                Nom.SelectedIndex = Nom.Items.IndexOf(ComboBox1.Text)
                Exit For
            End If
        Next
    End Sub

    Private Sub Tri(sender As Object, e As EventArgs) Handles Button1.Click
        If sender.Text = "Ordre croissant" Then
            sender.Text = "Ordre décroissant"
        Else
            sender.Text = "Ordre croissant"
        End If
        Dim items() As Object = Nom.Items.Cast(Of Object).Reverse.ToArray
        Nom.Items.Clear()
        Nom.Items.AddRange(items)

        items = BestNbCasesDecouv.Items.Cast(Of Object).Reverse.ToArray
        BestNbCasesDecouv.Items.Clear()
        BestNbCasesDecouv.Items.AddRange(items)

        items = BestTemps.Items.Cast(Of Object).Reverse.ToArray
        BestTemps.Items.Clear()
        BestTemps.Items.AddRange(items)
    End Sub
End Class