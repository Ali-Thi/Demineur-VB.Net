Module ScoreTri

    Dim nouvelleListeJ As Joueur()
    Dim idxTab As Integer = 2
    Public Function triJoueur(listejoueur) As Joueur()
        Dim compteur As Integer = 1
        Dim nouvelleliste As Joueur() = {}

        For i As Integer = 0 To Enregistrement.getNbJoueur - 1
            Dim j As Joueur = listejoueur(i)
            If nouvelleliste.Length < compteur Then
                ReDim nouvelleliste(nouvelleliste.Length + idxTab)
            End If
            While compteur < Enregistrement.getNbJoueur
                If j.meilleurNbCasesDecouvertes < listejoueur(compteur).meilleurNbCasesDecouvertes Then
                    nouvelleliste(i) = listejoueur(compteur)
                ElseIf j.meilleurNbCasesDecouvertes > listejoueur(compteur).meilleurNbCasesDecouvertes Then
                    nouvelleliste(i) = j
                End If
                compteur += 1
            End While
        Next
        nouvelleListeJ = nouvelleliste
    End Function

    Public Function getNouvelleListe(j As Integer) As Joueur
        Return nouvelleListeJ(j)
    End Function



End Module
