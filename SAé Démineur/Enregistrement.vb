Module Enregistrement
    Structure joueur
        Dim nbj As Integer
        Dim prenom As String
        Dim mine As Integer
        Dim nbParti As Integer
        Dim temps As Integer
    End Structure

    Dim listJ As String = FreeFile()
    Dim listJoueur As joueur()
    Dim idxnbj As Integer = 0

    Sub ajoutj(j As joueur)
        FileOpen(listJ, "Enregistrement.txt", OpenMode.Output)
        WriteLine(listJ, idxnbj)
        WriteLine(listJ, j.prenom)
        WriteLine(listJ, j.mine)
        WriteLine(listJ, j.nbParti)
        WriteLine(listJ, j.temps)
        idxnbj += 1
        FileClose(listJ)
    End Sub


    Public Function getListJ()
        Dim linesFromFile, nextLine As String
        Dim Joueurs As joueur
        linesFromFile = ""
        Dim cmpteur As Integer = 0
        Do Until EOF(listJ)
            nextLine = LineInput(listJ)
            Joueurs.nbj = nextLine
            Joueurs.prenom = nextLine
            Joueurs.mine = nextLine
            Joueurs.nbParti = nextLine
            Joueurs.temps = nextLine
            listJoueur(cmpteur) = Joueurs
            cmpteur += 1
        Loop
        Return listJoueur
    End Function
End Module
