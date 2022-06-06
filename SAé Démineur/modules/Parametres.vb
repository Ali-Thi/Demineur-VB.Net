Imports System.IO
Module Parametres

    Private nbRangees As Integer
    Private nbMines As Integer
    Private tempsImpartis As Integer
    Private avecChrono As Boolean
    Private scoresPath As String

    Public Sub Init()
        Try
            Dim file As New StreamReader("Options.txt")
            nbRangees = file.ReadLine()
            nbMines = file.ReadLine()
            tempsImpartis = file.ReadLine()
            avecChrono = file.ReadLine()
            scoresPath = file.ReadLine()
            file.Close()
        Catch ex As Exception
            nbRangees = 8
            nbMines = 8
            tempsImpartis = 60
            avecChrono = True
            scoresPath = ""
        End Try
    End Sub

    Public Sub SaveOptions()
        Dim file As New StreamWriter("Options.txt")
        file.WriteLine(nbRangees)
        file.WriteLine(nbMines)
        file.WriteLine(tempsImpartis)
        file.WriteLine(avecChrono)
        file.WriteLine(scoresPath)
        file.Close()
    End Sub

    Public Function GetNbRangees() As Integer
        Return nbRangees
    End Function

    Public Function GetNbMines() As Integer
        Return nbMines
    End Function

    Public Function GetTempsImpartis() As Integer
        Return tempsImpartis
    End Function

    Public Function GetAvecChrono() As Boolean
        Return avecChrono
    End Function

    Public Function GetScoresPath() As String
        Return scoresPath
    End Function

    Public Sub SetNbRangees(i As Integer)
        nbRangees = i
    End Sub

    Public Sub SetNbMines(i As Integer)
        nbMines = i
    End Sub

    Public Sub SetTempsImpartis(i As Integer)
        tempsImpartis = i
    End Sub

    Public Sub SetAvecChrono(i As Boolean)
        avecChrono = i
    End Sub

    Public Sub SetScoresPath(i As String)
        scoresPath = i
    End Sub

End Module
