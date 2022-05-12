Module Enregistrement
    Structure joueur
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
        Do Until EOF(listJ)
            nextLine = LineInput(listJ)
        Loop
        Return listJoueur
    End Function
End Module
