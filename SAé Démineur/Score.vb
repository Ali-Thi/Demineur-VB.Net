Public Class Score


    Private Sub Score_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        For i As Integer = 0 To Enregistrement.getIdxj()
            'Dim j As Joueur = Enregistrement.getJoueur(i)
            Dim j As Joueur = New Joueur With {.prenom = "seb", .temps = 10, .nbParti = 1, .nbCasesDecouvertes = 10}
            Nom.Items.Add(j.prenom)
            caseDecouv.Items.Add(j.nbCasesDecouvertes)
            nbParti.Items.Add(j.nbParti)
            temps.Items.Add(j.temps)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Accueil.Show()
    End Sub

    Private Sub Nom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Nom.SelectedIndexChanged, nbParti.SelectedIndexChanged, caseDecouv.SelectedIndexChanged, temps.SelectedIndexChanged
        Nom.SelectedIndex = sender.SelectedIndex
        caseDecouv.SelectedIndex = sender.SelectedIndex
        nbParti.SelectedIndex = sender.SelectedIndex
        temps.SelectedIndex = sender.SelectedIndex

    End Sub



    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged

    End Sub
End Class