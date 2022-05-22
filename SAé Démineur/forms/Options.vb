Public Class Options

    Private Sub Form_Load() Handles Me.Load

        CheckBox1.Checked = Parametres.getAvecChrono()

        NbCasesScrollBar.Value = Parametres.getNbRangees()
        NbCases.Text = NbCasesScrollBar.Value
        NbMinesScrollBar.Value = Parametres.getNbMines()
        NbMines.Text = NbMinesScrollBar.Value
        TempsImpartisScrollBar.Value = Parametres.getTempsImpartis()
        TempsImpartis.Text = TempsImpartisScrollBar.Value

        If Not CheckBox1.Checked Then
            Label3.Visible = False
            TempsImpartisScrollBar.Visible = False
            TempsImpartis.Visible = False
        End If

        ScoresPath.Text = Parametres.getScoresPath()

        NbCasesScrollBar.Minimum = 3
        NbCasesScrollBar.Maximum = 18
        NbCases.Enabled = False

        NbMinesScrollBar.Minimum = 1
        NbMinesScrollBar.Maximum = (NbCasesScrollBar.Value * NbCasesScrollBar.Value) - 1
        NbMines.Enabled = False

        TempsImpartisScrollBar.Minimum = 60
        TempsImpartisScrollBar.Maximum = TempsImpartisScrollBar.Minimum * 5
        TempsImpartis.Enabled = False
    End Sub

    Private Sub Valider(sender As Object, e As EventArgs) Handles Button1.Click
        Parametres.setNbRangees(NbCasesScrollBar.Value)
        Parametres.setNbMines(NbMinesScrollBar.Value)
        Parametres.setTempsImpartis(TempsImpartisScrollBar.Value)
        Parametres.setAvecChrono(CheckBox1.Checked)
        Parametres.setScoresPath(ScoresPath.Text)

        Me.Close()
    End Sub

    Private Sub Annuler(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Quit() Handles Me.Closed
        Accueil.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Label3.Visible = True
            TempsImpartisScrollBar.Visible = True
            TempsImpartis.Visible = True
        Else
            Label3.Visible = False
            TempsImpartisScrollBar.Visible = False
            TempsImpartis.Visible = False
        End If
    End Sub

    Private Sub NbCasesScrollBar_Scroll(sender As Object, e As EventArgs) Handles NbCasesScrollBar.ValueChanged
        If CInt(NbCases.Text) <> sender.Value Then
            NbCases.Text = sender.Value
            NbMinesScrollBar.Maximum = (NbCasesScrollBar.Value * NbCasesScrollBar.Value) - 1
            If CInt(NbMines.Text) > NbMinesScrollBar.Maximum Then
                NbMines.Text = NbMinesScrollBar.Maximum
            End If
        End If
    End Sub

    Private Sub NbMinesScrollBar_Scroll(sender As Object, e As EventArgs) Handles NbMinesScrollBar.ValueChanged
        If CInt(NbMines.Text) <> sender.Value Then
            NbMines.Text = sender.Value
        End If
    End Sub

    Private Sub TempsImpartisScrollBar_Scroll(sender As Object, e As EventArgs) Handles TempsImpartisScrollBar.ValueChanged
        If CInt(TempsImpartis.Text) <> sender.Value Then
            TempsImpartis.Text = sender.Value
        End If
    End Sub

    Private Sub NbCases_TextChanged(sender As Object, e As EventArgs)
        If NbCasesScrollBar.Value <> CInt(NbCases.Text) Then
            NbCasesScrollBar.Value = CInt(NbCases.Text)
        End If
    End Sub

    Private Sub NbMines_TextChanged(sender As Object, e As EventArgs)
        If NbMinesScrollBar.Value <> CInt(NbMines.Text) Then
            NbMinesScrollBar.Value = CInt(NbMines.Text)
        End If
    End Sub

    Private Sub TempsImpartis_TextChanged(sender As Object, e As EventArgs)
        If TempsImpartisScrollBar.Value <> CInt(TempsImpartis.Text) Then
            TempsImpartisScrollBar.Value = CInt(TempsImpartis.Text)
        End If
    End Sub
End Class