Module ScoreTri

    Public Function TriJoueur(listJoueur) As Enregistrement.Joueur()
        For Each j As Joueur In listJoueur
            Console.WriteLine(j.prenom)
        Next
        Console.WriteLine()
        If Not listJoueur Is Nothing Then
            If listJoueur.Length = 1 Then
                Return listJoueur
            Else
                Dim tab1() As Enregistrement.Joueur
                Dim tab2() As Enregistrement.Joueur
                If listJoueur.Length Mod 2 = 0 Then
                    ReDim tab1(listJoueur.Length / 2 - 1)
                    ReDim tab2(listJoueur.Length / 2 - 1)
                Else
                    ReDim tab1(listJoueur.Length \ 2 - 1)
                    ReDim tab2(listJoueur.Length \ 2)
                End If

                For i As Integer = 0 To listJoueur.Length - 1
                    If i < tab1.Length Then
                        tab1(i) = listJoueur(i)
                    Else
                        tab2(i - tab1.Length) = listJoueur(i)
                    End If
                Next

                tab1 = TriJoueur(tab1)
                tab2 = TriJoueur(tab2)

                Dim tabTrie(listJoueur.Length - 1) As Enregistrement.Joueur
                Dim idx1 As Integer = 0
                Dim idx2 As Integer = 0

                For i As Integer = 0 To tabTrie.Length - 1
                    If idx1 < tab1.Length And idx2 < tab2.Length Then
                        If (tab1(idx1).meilleurNbCasesDecouvertes > tab2(idx2).meilleurNbCasesDecouvertes) Or (tab1(idx1).meilleurNbCasesDecouvertes = tab2(idx2).meilleurNbCasesDecouvertes And tab1(idx1).meilleurTemps < tab2(idx2).meilleurTemps) Then
                            tabTrie(i) = tab1(idx1)
                            idx1 += 1
                        Else
                            tabTrie(i) = tab2(idx2)
                            idx2 += 1
                        End If
                    Else
                        If idx1 >= tab1.Length Then
                            tabTrie(i) = tab2(idx2)
                            idx2 += 1
                        Else
                            tabTrie(i) = tab1(idx1)
                            idx1 += 1
                        End If
                    End If
                Next

                Return tabTrie
            End If
        End If
    End Function
End Module
