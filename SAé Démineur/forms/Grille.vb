Public Class Grille

    Private tempsInitial As Integer
    Private tempsRestant As Integer
    Private labelTimer As New Label
    Private avecChrono As Boolean

    Private nbRangees As Integer
    Private couleurBoutonInitial As Color = Color.DarkGray
    Private couleurBoutonClique As Color = Color.LightGray
    Private couleurBoutonExplosion As Color = Color.Red

    Private Sub Form_Load() Handles Me.Load
        avecChrono = Parametres.GetAvecChrono()
        Jeu.MakeProblem()
        nbRangees = Jeu.GetNbRangees()

        Dim tailleBouton As Integer = GroupBox1.Width \ nbRangees

        Dim posXOrigin As Integer = 0
        Dim posYOrigin As Integer = 0
        Dim posX As Integer = posXOrigin
        Dim posY As Integer = posYOrigin

        GroupBox1.Size = New Drawing.Size(nbRangees * tailleBouton, nbRangees * tailleBouton)

        PauseButton.BackgroundImage = New Bitmap(PauseButton.BackgroundImage, New Drawing.Size(PauseButton.Width * 0.9, PauseButton.Height * 0.9))
        ExitButton.BackgroundImage = New Bitmap(ExitButton.BackgroundImage, New Drawing.Size(ExitButton.Width * 0.9, ExitButton.Height * 0.9))
        ReplayButton.BackgroundImage = New Bitmap(ReplayButton.BackgroundImage, New Drawing.Size(ReplayButton.Width * 0.9, ReplayButton.Height * 0.9))

        For i As Integer = 0 To nbRangees - 1
            posX = posXOrigin
            posY = tailleBouton * i
            For j As Integer = 0 To nbRangees - 1
                posX = tailleBouton * j
                Dim btn As New Button

                GroupBox1.Controls.Add(btn)

                AddHandler btn.MouseUp, AddressOf Button_Click

                With btn
                    .Name = "Button" & Str(i * nbRangees + j + 1)
                    .Size = New Drawing.Size(tailleBouton, tailleBouton)
                    .Location = New Point(posX, posY)
                    .BackColor = couleurBoutonInitial
                End With
            Next
        Next


        Dim labelNomDuJoueur As New Label
        Me.Controls.Add(labelTimer)
        Me.Controls.Add(labelNomDuJoueur)
        With labelNomDuJoueur
            .Text = Accueil.ComboBox1.Text
            .AutoSize = True
        End With

        If avecChrono Then
            tempsInitial = Parametres.GetTempsImpartis()
            tempsRestant = tempsInitial
            Dim labelTempsRestant As New Label
            Me.Controls.Add(labelTempsRestant)

            labelNomDuJoueur.Location = New Point(Me.Width \ 2 - labelTempsRestant.Width \ 2 - labelNomDuJoueur.Width, 10)
            With labelTempsRestant
                .Text = "Temps restant : "
                .AutoSize = True
                .Location = New Point(Me.Width \ 2 - labelTempsRestant.Width \ 2, 10)
            End With
            With labelTimer
                .Text = tempsRestant
                .AutoSize = True
                .Location = New Point(Me.Width \ 2 + labelTempsRestant.Width \ 2, 10)
            End With
        Else
            tempsRestant = 0
            labelNomDuJoueur.Location = New Point(Me.Width \ 2 - labelNomDuJoueur.Width, 10)
            With labelTimer
                .Text = tempsRestant
                .AutoSize = True
                .Location = New Point(Me.Width \ 2 + labelNomDuJoueur.Width, 10)
            End With
        End If
        With Timer1
            .Interval = 1000
            .Start()
        End With
    End Sub

    Private Sub Button_Click(sender As Button, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Dim casesADecouvrir() As Integer = Jeu.BoutonClick(GroupBox1.Controls.IndexOf(sender))
            If (casesADecouvrir IsNot Nothing) Then
                If (casesADecouvrir(0) = 0) Then
                    For i As Integer = 1 To casesADecouvrir.Length - 1
                        With GroupBox1.Controls(casesADecouvrir(i))
                            If (Jeu.GetGrilleI(casesADecouvrir(i)) > 0) Then
                                .Text = Jeu.GetGrilleI(casesADecouvrir(i))
                            End If
                            .Font = New Font(.Font.FontFamily, .Width \ 2, FontStyle.Bold, .Font.Unit)
                            .BackColor = couleurBoutonClique
                            .Enabled = False
                            .BackgroundImage = Nothing
                        End With
                    Next
                    Game_Is_Win()
                Else
                    sender.BackColor = couleurBoutonExplosion
                    For i As Integer = 1 To casesADecouvrir.Length - 1
                        With GroupBox1.Controls(casesADecouvrir(i))
                            .BackgroundImage = New Bitmap(My.Resources.bombe, .Size)
                        End With
                    Next
                    Game_End()
                End If
            End If
        ElseIf e.Button = MouseButtons.Right Then
            If (sender.BackgroundImage Is Nothing) Then
                sender.BackgroundImage = New Bitmap(My.Resources.drapeau, sender.Size)
            Else
                sender.BackgroundImage = Nothing
            End If
        End If
    End Sub

    Private Sub Game_End()
        Me.Enabled = False
        Timer1.Stop()
        Dim nbCasesDecouvertes As Integer = 0
        For Each btn As Button In GroupBox1.Controls
            If (btn.BackColor = couleurBoutonClique Or btn.BackColor = couleurBoutonExplosion) Then
                nbCasesDecouvertes += 1
            End If
        Next

        Dim message As String
        If avecChrono Then
            message = "Vous avez découvert" & Str(nbCasesDecouvertes) & " cases en" & Str(tempsInitial - tempsRestant) & " secondes."
        Else
            message = "Vous avez découvert" & Str(nbCasesDecouvertes) & " cases en" & Str(tempsRestant) & " secondes."
        End If

        If (MsgBox(message, MsgBoxStyle.OkOnly, "Partie terminée") = MsgBoxResult.Ok) Then
            If avecChrono Then
                Enregistrement.AjoutResultatPartie(Trim(StrConv(Accueil.ComboBox1.Text, vbProperCase)), nbCasesDecouvertes, tempsInitial - tempsRestant)
            Else
                Enregistrement.AjoutResultatPartie(Trim(StrConv(Accueil.ComboBox1.Text, vbProperCase)), nbCasesDecouvertes, tempsRestant)
            End If
            Accueil.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If avecChrono Then
            tempsRestant -= 1
            labelTimer.Text = tempsRestant
            If (tempsRestant <= 0) Then
                Game_End()
            End If
        Else
            tempsRestant += 1
            labelTimer.Text = tempsRestant
        End If
    End Sub

    Private Sub Game_Is_Win()
        Dim isWin As Boolean = True
        For Each btn As Button In GroupBox1.Controls
            If (btn.BackColor = couleurBoutonInitial And Jeu.GetGrilleI(GroupBox1.Controls.IndexOf(btn)) >= 0) Then
                isWin = False
            End If
        Next

        If (isWin Or tempsRestant <= 0) Then
            Game_End()
        End If
    End Sub

    Private Sub Pause(sender As Object, e As EventArgs) Handles PauseButton.Click
        If (GroupBox1.Enabled) Then
            GroupBox1.Enabled = False
            Timer1.Stop()
        Else
            GroupBox1.Enabled = True
            Timer1.Start()
        End If
    End Sub

    Private Sub ReplayButton_Click(sender As Object, e As EventArgs) Handles ReplayButton.Click
        GroupBox1.Controls.Clear()
        For Each lbl In Me.Controls
            If TypeOf (lbl) Is Label Then
                Me.Controls.Remove(lbl)
            End If
        Next
        Form_Load()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub Quit() Handles Me.Closed
        Accueil.Show()
    End Sub


End Class