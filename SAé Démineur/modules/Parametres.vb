Imports System.IO
Module Parametres

    Private nbRangees As Integer = 8
    Private nbMines As Integer = 8
    Private tempsImpartis As Integer = 60
    Private avecChrono As Boolean = True
    Private scoresPath As String = ""

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

    Public Function getNbRangees() As Integer
        Return nbRangees
    End Function

    Public Function getNbMines() As Integer
        Return nbMines
    End Function

    Public Function getTempsImpartis() As Integer
        Return tempsImpartis
    End Function

    Public Function getAvecChrono() As Boolean
        Return avecChrono
    End Function

    Public Function getScoresPath() As String
        Return scoresPath
    End Function

    Public Function setNbRangees(i As Integer)
        nbRangees = i
    End Function

    Public Function setNbMines(i As Integer)
        nbMines = i
    End Function

    Public Function setTempsImpartis(i As Integer)
        tempsImpartis = i
    End Function

    Public Function setAvecChrono(i As Boolean)
        avecChrono = i
    End Function

    Public Function setScoresPath(i As String)
        scoresPath = i
    End Function

End Module
