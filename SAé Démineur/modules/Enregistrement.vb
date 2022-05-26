Imports System.IO

Module Enregistrement

    Structure Joueur
        Dim prenom As String
        Dim nbCasesDecouvertes As Integer
        Dim nbParti As Integer
        Dim temps As Integer
        Dim meilleurNbCasesDecouvertes As Integer
        Dim meilleurTemps As Integer
    End Structure

    Private listJoueur As Joueur()

    Public Sub Enregistrer()
        If Not listJoueur Is Nothing Then
            Dim file As New StreamWriter(Parametres.getScoresPath() + "Enregistrement.txt")
            file.WriteLine(listJoueur.Length)
            For Each joueur As Joueur In listJoueur
                file.WriteLine(joueur.prenom)
                file.WriteLine(joueur.nbCasesDecouvertes)
                file.WriteLine(joueur.nbParti)
                file.WriteLine(joueur.temps)
                file.WriteLine(joueur.meilleurNbCasesDecouvertes)
                file.WriteLine(joueur.meilleurTemps)
            Next
            file.Close()
        End If
    End Sub


    Public Sub AjoutResultatPartie(_prenom As String, _nbCasesDecouvertes As Integer, _temps As Integer)
        Dim joueurExiste As Boolean = False
        If listJoueur Is Nothing Then
            ReDim listJoueur(0)
        End If

        For i As Integer = 0 To listJoueur.Length - 1
            If listJoueur(i).prenom = _prenom Then
                With listJoueur(i)
                    .nbCasesDecouvertes += _nbCasesDecouvertes
                    .nbParti += 1
                    .temps += _temps
                    If _nbCasesDecouvertes > listJoueur(i).meilleurNbCasesDecouvertes Then
                        .meilleurNbCasesDecouvertes = _nbCasesDecouvertes
                        .meilleurTemps = _temps
                    End If
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
                .meilleurNbCasesDecouvertes = _nbCasesDecouvertes
                .meilleurTemps = _temps
            End With


            If Not listJoueur(0).prenom Is Nothing Then
                ReDim Preserve listJoueur(listJoueur.Length)
            End If
            listJoueur(listJoueur.Length - 1) = joueur
        End If
    End Sub

    Public Function getNomsJoueur() As String()
        If Not listJoueur Is Nothing Then
            Dim nomsJoueurs(listJoueur.Length - 1) As String
            For i As Integer = 0 To listJoueur.Length - 1
                nomsJoueurs(i) = listJoueur(i).prenom
            Next
            Return nomsJoueurs
        End If
    End Function

    Public Function getListJoueur() As Joueur()
        If Not listJoueur Is Nothing Then
            Return listJoueur.Clone()
        End If
    End Function

    Public Function getNbJoueur() As Integer
        If listJoueur Is Nothing Then
            Return 0
        Else
            Return listJoueur.Length
        End If
    End Function

    Public Sub Main()
        Try
            Dim file As New StreamReader(Parametres.getScoresPath() + "Enregistrement.txt")
            ReDim listJoueur(file.ReadLine() - 1)
            For i As Integer = 0 To listJoueur.Length - 1
                Dim joueur As Joueur
                With joueur
                    .prenom = file.ReadLine()
                    .nbCasesDecouvertes = file.ReadLine()
                    .nbParti = file.ReadLine()
                    .temps = file.ReadLine()
                    .meilleurNbCasesDecouvertes = file.ReadLine()
                    .meilleurTemps = file.ReadLine()
                End With
                listJoueur(i) = joueur
            Next
            file.Close()
        Catch ex As FileNotFoundException

        End Try
        Application.Run(Accueil)
    End Sub
End Module
