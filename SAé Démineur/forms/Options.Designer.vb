<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.TempsImpartis = New System.Windows.Forms.TextBox()
        Me.NbMines = New System.Windows.Forms.TextBox()
        Me.NbCases = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TempsImpartisScrollBar = New System.Windows.Forms.HScrollBar()
        Me.NbMinesScrollBar = New System.Windows.Forms.HScrollBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NbCasesScrollBar = New System.Windows.Forms.HScrollBar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ScoresPath = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.TempsImpartis)
        Me.GroupBox1.Controls.Add(Me.NbMines)
        Me.GroupBox1.Controls.Add(Me.NbCases)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TempsImpartisScrollBar)
        Me.GroupBox1.Controls.Add(Me.NbMinesScrollBar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.NbCasesScrollBar)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 326)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Jeu"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(187, 48)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(113, 24)
        Me.CheckBox2.TabIndex = 11
        Me.CheckBox2.Text = "Dark Mode"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'TempsImpartis
        '
        Me.TempsImpartis.Location = New System.Drawing.Point(426, 252)
        Me.TempsImpartis.Name = "TempsImpartis"
        Me.TempsImpartis.Size = New System.Drawing.Size(46, 26)
        Me.TempsImpartis.TabIndex = 10
        Me.TempsImpartis.Text = "0"
        '
        'NbMines
        '
        Me.NbMines.Location = New System.Drawing.Point(426, 182)
        Me.NbMines.Name = "NbMines"
        Me.NbMines.Size = New System.Drawing.Size(46, 26)
        Me.NbMines.TabIndex = 9
        Me.NbMines.Text = "0"
        '
        'NbCases
        '
        Me.NbCases.Location = New System.Drawing.Point(426, 112)
        Me.NbCases.Name = "NbCases"
        Me.NbCases.Size = New System.Drawing.Size(46, 26)
        Me.NbCases.TabIndex = 8
        Me.NbCases.Text = "0"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(26, 48)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(128, 24)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Chronométré"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Temps impartis :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombres de mines :"
        '
        'TempsImpartisScrollBar
        '
        Me.TempsImpartisScrollBar.Location = New System.Drawing.Point(202, 252)
        Me.TempsImpartisScrollBar.Name = "TempsImpartisScrollBar"
        Me.TempsImpartisScrollBar.Size = New System.Drawing.Size(191, 26)
        Me.TempsImpartisScrollBar.TabIndex = 4
        '
        'NbMinesScrollBar
        '
        Me.NbMinesScrollBar.Location = New System.Drawing.Point(202, 182)
        Me.NbMinesScrollBar.Name = "NbMinesScrollBar"
        Me.NbMinesScrollBar.Size = New System.Drawing.Size(191, 26)
        Me.NbMinesScrollBar.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombres de cases :"
        '
        'NbCasesScrollBar
        '
        Me.NbCasesScrollBar.LargeChange = 5
        Me.NbCasesScrollBar.Location = New System.Drawing.Point(202, 112)
        Me.NbCasesScrollBar.Maximum = 28
        Me.NbCasesScrollBar.Minimum = 3
        Me.NbCasesScrollBar.Name = "NbCasesScrollBar"
        Me.NbCasesScrollBar.Size = New System.Drawing.Size(191, 26)
        Me.NbCasesScrollBar.TabIndex = 1
        Me.NbCasesScrollBar.Value = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ScoresPath)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(40, 410)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(490, 132)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sauvegarde"
        '
        'ScoresPath
        '
        Me.ScoresPath.Location = New System.Drawing.Point(106, 80)
        Me.ScoresPath.Name = "ScoresPath"
        Me.ScoresPath.Size = New System.Drawing.Size(287, 26)
        Me.ScoresPath.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(291, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Chemin pour la sauvegarde des scores :"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(31, 596)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(249, 86)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Annuler"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(293, 596)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(249, 86)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Valider"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 726)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Options"
        Me.Text = "Options"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NbCasesScrollBar As HScrollBar
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TempsImpartisScrollBar As HScrollBar
    Friend WithEvents NbMinesScrollBar As HScrollBar
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents TempsImpartis As TextBox
    Friend WithEvents NbMines As TextBox
    Friend WithEvents NbCases As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ScoresPath As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
