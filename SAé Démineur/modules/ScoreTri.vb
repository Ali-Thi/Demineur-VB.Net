Module ScoreTri


    Public Function triJoueur(listJoueur() As Joueur)
        Dim J As Joueur
        For i As Integer = 0 To listJoueur.Length - 1
            If getJoueur(i).prenom < getJoueur(i + 1).prenom Then
                J = getJoueur(i)
                listJoueur(i) = listJoueur(i + 1)
                listJoueur(i + 1) = J
            ElseIf getJoueur(i).nbCasesDecouvertes < getJoueur(i + 1).nbCasesDecouvertes Then
                J = getJoueur(i)
                listJoueur(i) = listJoueur(i + 1)
                listJoueur(i + 1) = J
            End If
        Next
    End Function
End Module
