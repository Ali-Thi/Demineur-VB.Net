Public Class Grille

    Private tempsInitial As Integer = 60
    Private tempsRestant As Integer = tempsInitial
    Private labelTimer As New Label

    Private Sub Form_Load() Handles Me.Load
        Dim nbRangees As Integer = Jeu.getNbRangees()

        Dim tailleBouton As Integer = 50
        Dim espacement As Integer = 10

        Dim posXOrigin As Integer = espacement
        Dim posYOrigin As Integer = espacement
        Dim posX As Integer = posXOrigin
        Dim posY As Integer = posYOrigin

        GroupBox1.Size = New Drawing.Size((nbRangees * tailleBouton) + ((nbRangees - 1) * espacement) + 2 * espacement, (nbRangees * tailleBouton) + ((nbRangees - 1) * espacement) + 2 * espacement)
        GroupBox1.Location = New Point(5 * espacement, 5 * espacement)

        Dim labelNomDuJoueur As New Label
        Dim labelTempsRestant As New Label
        Me.Controls.Add(labelNomDuJoueur)
        Me.Controls.Add(labelTempsRestant)
        Me.Controls.Add(labelTimer)
        With labelTempsRestant
            .Text = "Temps restant : "
            .AutoSize = True
            .Location = New Point(Me.Width / 2 - labelTempsRestant.Width / 2, espacement)
        End With
        With labelNomDuJoueur
            .Text = "Nom du joueur"
            .AutoSize = True
            .Location = New Point(Me.Width / 2 - labelTempsRestant.Width / 2 - labelNomDuJoueur.Width, espacement)
        End With
        With labelTimer
            .Text = tempsRestant
            .AutoSize = True
            .Location = New Point(Me.Width / 2 + labelTempsRestant.Width / 2, espacement)
        End With

        Me.Size = New Drawing.Size(GroupBox1.Width + 10 * espacement, GroupBox1.Width + 10 * espacement)

        For i As Integer = 0 To nbRangees - 1
            posX = posXOrigin
            posY = (tailleBouton + espacement) * i + espacement
            For j As Integer = 0 To nbRangees - 1
                posX = (tailleBouton + espacement) * j + espacement
                Dim btn As New Button
                Dim lbl As New Label

                GroupBox1.Controls.Add(lbl)
                GroupBox1.Controls.Add(btn)

                AddHandler btn.Click, AddressOf Button_Click

                With btn
                    .Name = "Button" & Str(i * nbRangees + j + 1)
                    .Size = New Drawing.Size(tailleBouton, tailleBouton)
                    .Location = New Point(posX, posY)
                End With

                With lbl
                    .Hide()
                    '.Name = "Label" & Str(i * nbRangees + j + 1)
                    If (Jeu.getGrilleI(i, j) <> 0) Then
                        .Text = Jeu.getGrilleI(i, j)
                    End If
                    .Font = New Font(lbl.Font.FontFamily, tailleBouton / 2, FontStyle.Bold, lbl.Font.Unit)
                    .TextAlign = ContentAlignment.MiddleCenter
                    .Size = btn.Size
                    .Location = New Point(btn.Left + tailleBouton / 2 - .Width / 2, btn.Top + tailleBouton / 2 - .Height / 2)
                End With
            Next
        Next

        With Timer1
            .Interval = 1000
            .Start()
        End With
    End Sub

    Private Sub Button_Click(sender As Button, e As EventArgs)
        For Each lbl In GroupBox1.Controls
            If TypeOf (lbl) Is Label Then
                If (lbl.Location.X >= sender.Location.X And lbl.Location.X <= sender.Location.X + sender.Width And lbl.Location.Y >= sender.Location.Y And lbl.Location.Y <= sender.Location.Y + sender.Height And lbl.Text <> "") Then
                    If (CInt(lbl.Text) < 0) Then
                        sender.BackColor = Color.Red
                        Game_End()
                    End If
                    sender.Hide()
                    lbl.Show()
                End If
            End If

        Next
    End Sub

    Private Sub Game_End()
        Me.Enabled = False
        Dim nbCaseDecouverte As Integer = 0
        For Each btn In GroupBox1.Controls
            If (TypeOf (btn) Is Button And Not btn.Visible) Then
                nbCaseDecouverte += 1
            End If
        Next
        If (MsgBox("Vous avez découvert" & Str(nbCaseDecouverte) & " cases en" & Str(tempsInitial - tempsRestant) & " secondes.", MsgBoxStyle.OkOnly, "Partie terminée") = MsgBoxResult.Ok) Then
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
End Class