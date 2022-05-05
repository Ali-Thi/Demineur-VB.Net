Module Jeu
    Private nbRangees As Integer = 8
    Private nbMines As Integer = 10
    Private grille(nbRangees - 1, nbRangees - 1) As Integer

    Public Sub MakeProblem()
        VBMath.Randomize()
        Dim xAleatoire As Integer = CInt(VBMath.Rnd() * (nbRangees - 1))
        Dim yAleatoire As Integer = CInt(VBMath.Rnd() * (nbRangees - 1))
        For i As Integer = 0 To nbMines
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

    Public Function getNbRangees() As Integer
        Return nbRangees
    End Function

    Public Function getGrilleI(i As Integer, j As Integer) As Integer
        Return grille(i, j)
    End Function

End Module
