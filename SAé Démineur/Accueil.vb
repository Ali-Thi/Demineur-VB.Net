Public Class Accueil
    Private Sub Quitter(sender As Object, e As EventArgs) Handles Button2.Click
        If (MsgBox("Voulez-vous quitter l'application ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            Close()
        End If
    End Sub

    Private Sub Jouer(sender As Object, e As EventArgs) Handles Button1.Click
        Dim peutLancer As Boolean = True
        If (ComboBox1.Text.Length < 3) Then
            Label1.ForeColor = Color.Red
            Label2.Visible = True
            peutLancer = False
        End If

        If peutLancer Then
            Me.Hide()
            If Not ComboBox1.Items.Contains(ComboBox1.Text) Then
                ComboBox1.Items.Add(ComboBox1.Text)
            End If
            Jeu.MakeProblem()
            Grille.Show()
        End If
    End Sub

    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each nom As String In Enregistrement.getNomsJoueur()
            If Not nom Is Nothing Then
                ComboBox1.Items.Add(nom)
            End If
        Next
    End Sub

    Private Sub Accueil_Close() Handles Me.Closed
        Enregistrement.ajoutJoueur()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Score.Show()
    End Sub


End Class
