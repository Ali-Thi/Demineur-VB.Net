Imports System.IO
Public Class Options

    Private Sub Form_Load() Handles Me.Load

        NbCasesScrollBar.Minimum = 3
        NbCasesScrollBar.Maximum = 18
        'NbCasesScrollBar.SmallChange = 1
        'NbCasesScrollBar.LargeChange = 5

        NbMinesScrollBar.Minimum = 1
        NbMinesScrollBar.Maximum = (NbCasesScrollBar.Value * NbCasesScrollBar.Value) - 1
        'NbMinesScrollBar.SmallChange = NbCasesScrollBar.SmallChange
        'NbMinesScrollBar.LargeChange = NbCasesScrollBar.LargeChange

        TempsImpartisScrollBar.Minimum = 60
        TempsImpartisScrollBar.Maximum = TempsImpartisScrollBar.Minimum * 5
        'TempsImpartisScrollBar.SmallChange = NbCasesScrollBar.SmallChange
        'TempsImpartisScrollBar.LargeChange = NbCasesScrollBar.LargeChange

        Try
            Dim file As New StreamReader("Options.txt")

            CheckBox1.Checked = file.ReadLine()
            CheckBox2.Checked = file.ReadLine()

            NbCasesScrollBar.Value = file.ReadLine()
            NbMinesScrollBar.Value = file.ReadLine()
            TempsImpartisScrollBar.Value = file.ReadLine()

            If Not CheckBox1.Checked Then
                Label3.Visible = False
                TempsImpartisScrollBar.Visible = False
                TempsImpartis.Visible = False
            End If

            ScoresPath.Text = file.ReadLine()

            file.Close()
        Catch ex As FileNotFoundException
            NbCases.Text = 8
            NbMines.Text = 8
            TempsImpartis.Text = 60

            CheckBox1.Checked = True
            CheckBox1.CheckState = CheckState.Checked
            CheckBox2.Checked = False
        End Try
    End Sub

    Private Sub Valider(sender As Object, e As EventArgs) Handles Button1.Click
        Dim file As New StreamWriter("Options.txt")
        With file
            .WriteLine(CheckBox1.Checked)
            .WriteLine(CheckBox2.Checked)

            .WriteLine(NbCasesScrollBar.Value)
            .WriteLine(NbMinesScrollBar.Value)
            .WriteLine(TempsImpartisScrollBar.Value)

            .WriteLine(ScoresPath.Text)
        End With
        file.Close()
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

    Private Sub NbCases_TextChanged(sender As Object, e As EventArgs) Handles NbCases.TextChanged
        If NbCasesScrollBar.Value <> CInt(NbCases.Text) Then
            NbCasesScrollBar.Value = CInt(NbCases.Text)
        End If
    End Sub

    Private Sub NbMines_TextChanged(sender As Object, e As EventArgs) Handles NbMines.TextChanged
        If NbMinesScrollBar.Value <> CInt(NbMines.Text) Then
            NbMinesScrollBar.Value = CInt(NbMines.Text)
        End If
    End Sub

    Private Sub TempsImpartis_TextChanged(sender As Object, e As EventArgs) Handles TempsImpartis.TextChanged
        If TempsImpartisScrollBar.Value <> CInt(TempsImpartis.Text) Then
            TempsImpartisScrollBar.Value = CInt(TempsImpartis.Text)
        End If
    End Sub
End Class