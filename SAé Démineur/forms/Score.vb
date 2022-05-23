Public Class Score

    'Private Sub Score_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'If Enregistrement.getNbJoueur() > 0 Then
    'For i As Integer = 0 To Enregistrement.getNbJoueur() - 1
    ' Dim j As Joueur = Enregistrement.getJoueur(i)
    ' Nom.Items.Add(j.prenom)
    'caseDecouv.Items.Add(j.nbCasesDecouvertes)
    'nbParti.Items.Add(j.nbParti)
    'temps.Items.Add(j.temps)
    'ComboBox1.Items.Add(j.prenom)
    'Next
    'End If
    ' End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Accueil.Show()
    End Sub

    Private Sub Nom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Nom.SelectedIndexChanged, nbParti.SelectedIndexChanged, caseDecouv.SelectedIndexChanged, temps.SelectedIndexChanged
        Nom.SelectedIndex = sender.SelectedIndex
        caseDecouv.SelectedIndex = sender.SelectedIndex
        nbParti.SelectedIndex = sender.SelectedIndex
        temps.SelectedIndex = sender.SelectedIndex

        ComboBox1.Text = Nom.SelectedItem


    End Sub

    Private Sub Quit() Handles Me.Closed
        Accueil.Show()
    End Sub

    Private Sub Score_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Nom.Items.Clear()
        Nom.Sorted() = True

        caseDecouv.Items.Clear()
        caseDecouv.Sorted() = True

        nbParti.Items.Clear()
        nbParti.Sorted() = True

        temps.Items.Clear()
        temps.Sorted() = True

        ComboBox1.Items.Clear()
        ComboBox1.Sorted() = True




        If Enregistrement.getNbJoueur() > 0 Then
            For i As Integer = 0 To Enregistrement.getNbJoueur() - 1
                Dim j As Joueur = Enregistrement.getJoueur(i)
                Nom.Items.Add(j.prenom)
                caseDecouv.Items.Add(j.nbCasesDecouvertes)
                nbParti.Items.Add(j.nbParti)
                temps.Items.Add(j.temps)
                ComboBox1.Items.Add(j.prenom)
            Next
        End If
    End Sub

    Private Sub ScoreTri_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class