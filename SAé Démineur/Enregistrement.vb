Module Enregistrement
    Structure Joueur
        Dim prenom As String
        Dim nbCasesDecouvertes As Integer
        Dim nbParti As Integer
        Dim temps As Integer
    End Structure

    Private numFile As String = FreeFile()
    Private listJoueur(0) As Joueur

    Public Sub ajoutJoueur()
        FileOpen(numFile, "Enregistrement.txt", OpenMode.Output)
        WriteLine(numFile, listJoueur.Length)
        For Each joueur As Joueur In listJoueur
            WriteLine(numFile, joueur.prenom)
            WriteLine(numFile, joueur.nbCasesDecouvertes)
            WriteLine(numFile, joueur.nbParti)
            WriteLine(numFile, joueur.temps)
        Next
        FileClose(numFile)
    End Sub


    Public Sub Enregistrer(_prenom As String, _nbCasesDecouvertes As Integer, _temps As Integer)
        Dim joueurExiste As Boolean = False
        For Each joueur In listJoueur
            If joueur.prenom = _prenom Then
                With joueur
                    .nbCasesDecouvertes += _nbCasesDecouvertes
                    .nbParti += 1
                    .temps += _temps
                End With
                joueurExiste = True
            End If
        Next
        If Not joueurExiste Then
            Dim joueur As Joueur
            With joueur
                .prenom = _prenom
                .nbCasesDecouvertes = _nbCasesDecouvertes
                .nbParti = 1
                .temps = _temps
            End With
        End If
    End Sub

    Public Function getNomsJoueur()
        Dim nomsJoueurs(listJoueur.Length) As String
        For Each joueur In listJoueur
            nomsJoueurs.Append(joueur.prenom)
        Next
        Return nomsJoueurs
    End Function

    Public Sub Main()
        Try
            FileOpen(numFile, "Enregistrement.txt", OpenMode.Input)
            Dim nbJoueurs As Integer = LineInput(numFile)
            ReDim listJoueur(nbJoueurs - 1)
            For i As Integer = 0 To nbJoueurs - 1
                Dim joueur As Joueur
                listJoueur.Append(joueur)
                With joueur
                    .prenom = LineInput(numFile)
                    .nbCasesDecouvertes = LineInput(numFile)
                    .nbParti = LineInput(numFile)
                    .temps = LineInput(numFile)
                End With
            Next
            FileClose(numFile)
        Catch ex As Exception

        End Try
        Application.Run(Accueil)
    End Sub
End Module
