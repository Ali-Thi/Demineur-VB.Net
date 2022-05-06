Module Jeu
    Private nbRangees As Integer = 8
    Private nbMines As Integer = 10
    Private grille(nbRangees - 1, nbRangees - 1) As Integer
    Private casesDecouvertes(nbRangees - 1, nbRangees - 1) As Boolean

    Public Sub MakeProblem()
        For i As Integer = 0 To nbRangees - 1
            For j As Integer = 0 To nbRangees - 1
                grille(i, j) = 0
                casesDecouvertes(i, j) = False
            Next
        Next
        VBMath.Randomize()
        Dim xAleatoire As Integer = CInt(VBMath.Rnd() * (nbRangees - 1))
        Dim yAleatoire As Integer = CInt(VBMath.Rnd() * (nbRangees - 1))
        For i As Integer = 0 To nbMines - 1
            Do While grille(xAleatoire, yAleatoire) = -1
                xAleatoire = CInt(VBMath.Rnd() * (nbRangees - 1))
                yAleatoire = CInt(VBMath.Rnd() * (nbRangees - 1))
            Loop
            grille(xAleatoire, yAleatoire) = -1
            For Each j As Integer In {xAleatoire - 1, xAleatoire, xAleatoire + 1}
                For Each k As Integer In {yAleatoire - 1, yAleatoire, yAleatoire + 1}
                    If (j >= 0 And k >= 0 And j < nbRangees And k < nbRangees And (j <> k Or j <> xAleatoire Or k <> yAleatoire)) Then
                        If (grille(j, k) >= 0) Then
                            grille(j, k) += 1
                        End If
                    End If
                Next
            Next
        Next
    End Sub

    Public Function boutonClick(indexBouton As Integer) As Integer()
        Dim x As Integer = indexBouton \ nbRangees
        Dim y As Integer = indexBouton Mod nbRangees
        Dim retour() As Integer = {0, indexBouton}
        If (0 <= indexBouton < nbRangees * nbRangees) Then
            If (Not casesDecouvertes(x, y)) Then
                casesDecouvertes(x, y) = True

                If (grille(x, y) < 0) Then
                    retour(0) = 1
                    For i As Integer = 0 To nbRangees - 1
                        For j As Integer = 0 To nbRangees - 1
                            If (grille(i, j) < 0 And i * nbRangees + j <> indexBouton) Then
                                ReDim Preserve retour(retour.Length)
                                retour(retour.Length - 1) = i * nbRangees + j
                                casesDecouvertes(x, y) = True
                            End If
                        Next
                    Next
                ElseIf (grille(x, y) = 0) Then
                    Dim retourRecursif() As Integer
                    For Each i As Integer In {x - 1, x, x + 1}
                        For Each j As Integer In {y - 1, y, y + 1}
                            If (j >= 0 And i >= 0 And j < nbRangees And i < nbRangees And Not (j = y And i = x)) Then
                                If (Not casesDecouvertes(i, j)) Then
                                    retourRecursif = boutonClick(i * nbRangees + j)
                                    If (retourRecursif IsNot Nothing) Then
                                        For k As Integer = 1 To retourRecursif.Length - 1
                                            ReDim Preserve retour(retour.Length)
                                            retour(retour.Length - 1) = (retourRecursif(k))
                                        Next
                                    End If
                                End If
                            End If
                        Next
                    Next
                End If
            End If
        End If
        Return retour
    End Function

    Private Function getXFromIndex(index As Integer)
        Return index \ nbRangees
    End Function

    Private Function getYFromIndex(index As Integer)
        Return index Mod nbRangees
    End Function

    Public Function getNbRangees() As Integer
        Return nbRangees
    End Function

    Public Function getNbMines() As Integer
        Return nbMines
    End Function

    Public Function getGrilleI(index As Integer) As Integer
        Return grille(getXFromIndex(index), getYFromIndex(index))
    End Function

    Public Function getCaseEstDecouvert(index As Integer) As Integer
        Return casesDecouvertes(getXFromIndex(index), getYFromIndex(index))
    End Function

End Module
