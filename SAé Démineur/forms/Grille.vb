Public Class Grille

    Private tempsInitial As Integer
    Private tempsRestant As Integer
    Private labelTimer As New Label

    Private nbRangees As Integer
    Private couleurBoutonInitial As Color = Color.DarkGray
    Private couleurBoutonClique As Color = Color.LightGray
    Private couleurBoutonExplosion As Color = Color.Red

    Private Sub Form_Load() Handles Me.Load
        Jeu.MakeProblem()
        nbRangees = Jeu.getNbRangees()

        Dim tailleBouton As Integer = GroupBox1.Width \ nbRangees

        Dim posXOrigin As Integer = 0
        Dim posYOrigin As Integer = 0
        Dim posX As Integer = posXOrigin
        Dim posY As Integer = posYOrigin

        GroupBox1.Size = New Drawing.Size(nbRangees * tailleBouton, nbRangees * tailleBouton)

        If Parametres.getAvecChrono() Then
            tempsInitial = Parametres.getTempsImpartis()
            tempsRestant = tempsInitial
            Dim labelNomDuJoueur As New Label
            Dim labelTempsRestant As New Label
            Me.Controls.Add(labelNomDuJoueur)
            Me.Controls.Add(labelTempsRestant)
            Me.Controls.Add(labelTimer)
            With labelTempsRestant
                .Text = "Temps restant : "
                .AutoSize = True
                .Location = New Point(Me.Width \ 2 - labelTempsRestant.Width \ 2, 10)
            End With
            With labelNomDuJoueur
                .Text = "Nom du joueur"
                .AutoSize = True
                .Location = New Point(Me.Width \ 2 - labelTempsRestant.Width \ 2 - labelNomDuJoueur.Width, 10)
            End With
            With labelTimer
                .Text = tempsRestant
                .AutoSize = True
                .Location = New Point(Me.Width \ 2 + labelTempsRestant.Width \ 2, 10)
            End With
            With Timer1
                .Interval = 1000
                .Start()
            End With
        End If

        PauseButton.BackgroundImage = New Bitmap(PauseButton.BackgroundImage, PauseButton.Size)
        ExitButton.BackgroundImage = New Bitmap(ExitButton.BackgroundImage, ExitButton.Size)
        ReplayButton.BackgroundImage = New Bitmap(ReplayButton.BackgroundImage, ReplayButton.Size)

        'Me.Size = New Drawing.Size(GroupBox1.Width + 10 * espacement, GroupBox1.Width + 10 * espacement)

        For i As Integer = 0 To nbRangees - 1
            posX = posXOrigin
            posY = tailleBouton * i
            For j As Integer = 0 To nbRangees - 1
                posX = tailleBouton * j
                Dim btn As New Button

                GroupBox1.Controls.Add(btn)

                AddHandler btn.Click, AddressOf Button_Click

                With btn
                    .Name = "Button" & Str(i * nbRangees + j + 1)
                    .Size = New Drawing.Size(tailleBouton, tailleBouton)
                    .Location = New Point(posX, posY)
                    .BackColor = couleurBoutonInitial
                End With
            Next
        Next
    End Sub

    Private Sub Button_Click(sender As Button, e As MouseEventArgs)
        Console.WriteLine(e.Button)
        If e.Button = MouseButtons.Left Then
            Dim casesADecouvrir() As Integer = Jeu.boutonClick(GroupBox1.Controls.IndexOf(sender))
            If (casesADecouvrir IsNot Nothing) Then
                If (casesADecouvrir(0) = 0) Then
                    For i As Integer = 1 To casesADecouvrir.Length - 1
                        With GroupBox1.Controls(casesADecouvrir(i))
                            If (Jeu.getGrilleI(casesADecouvrir(i)) > 0) Then
                                .Text = Jeu.getGrilleI(casesADecouvrir(i))
                            End If
                            .Font = New Font(.Font.FontFamily, .Width \ 2, FontStyle.Bold, .Font.Unit)
                            .BackColor = couleurBoutonClique
                            .Enabled = False
                        End With
                    Next
                Else
                    sender.BackColor = couleurBoutonExplosion
                    For i As Integer = 1 To casesADecouvrir.Length - 1
                        With GroupBox1.Controls(casesADecouvrir(i))
                            .Text = "B"
                            .Font = New Font(.Font.FontFamily, .Width \ 2, FontStyle.Bold, .Font.Unit)
                        End With
                    Next
                    Game_End()
                End If
            End If
        ElseIf e.Button = MouseButtons.Right Then
            Console.WriteLine(0)
            If (sender.BackgroundImage Is Nothing) Then
                Console.WriteLine(1)
                sender.BackgroundImage = New Bitmap(My.Resources.drapeau, sender.Size)
            Else
                Console.WriteLine(2)
                sender.BackgroundImage = Nothing
            End If
        End If
        Game_Is_Win()
    End Sub

    Private Sub Game_End() Handles ExitButton.Click
        Me.Enabled = False
        Timer1.Stop()
        Dim nbCasesDecouvertes As Integer = 0
        For Each btn As Button In GroupBox1.Controls
            If (btn.BackColor = couleurBoutonClique Or btn.BackColor = couleurBoutonExplosion) Then
                nbCasesDecouvertes += 1
            End If
        Next

        Dim message As String
        If Parametres.getAvecChrono() Then
            message = "Vous avez découvert" & Str(nbCasesDecouvertes) & " cases en" & Str(tempsInitial - tempsRestant) & " secondes."
        Else
            message = "Partie teminée."
        End If

        If (MsgBox(message, MsgBoxStyle.OkOnly, "Partie terminée") = MsgBoxResult.Ok) Then
            Enregistrement.Enregistrer(Trim(StrConv(Accueil.ComboBox1.Text, vbProperCase)), nbCasesDecouvertes, tempsInitial - tempsRestant)
            Accueil.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tempsRestant -= 1
        labelTimer.Text = tempsRestant
        If (tempsRestant <= 0) Then
            Timer1.Stop()
            Game_End()
        End If
    End Sub

    Private Sub Game_Is_Win()
        Dim isWin As Boolean = True
        For Each btn As Button In GroupBox1.Controls
            If (btn.BackColor = couleurBoutonInitial And Jeu.getGrilleI(GroupBox1.Controls.IndexOf(btn)) >= 0) Then
                isWin = False
            End If
        Next

        If (isWin) Then
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
        Form_Load()
    End Sub

    Private Sub Quit() Handles Me.Closed
        Accueil.Show()
    End Sub
End Class