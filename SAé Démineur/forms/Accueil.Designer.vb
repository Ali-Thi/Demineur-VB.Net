<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.LeaveButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ScoreButton = New System.Windows.Forms.Button()
        Me.OptionsButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(284, 172)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(343, 28)
        Me.ComboBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nom"
        '
        'PlayButton
        '
        Me.PlayButton.Location = New System.Drawing.Point(546, 289)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(249, 86)
        Me.PlayButton.TabIndex = 2
        Me.PlayButton.Text = "Jouer"
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'LeaveButton
        '
        Me.LeaveButton.Location = New System.Drawing.Point(16, 289)
        Me.LeaveButton.Name = "LeaveButton"
        Me.LeaveButton.Size = New System.Drawing.Size(249, 86)
        Me.LeaveButton.TabIndex = 3
        Me.LeaveButton.Text = "Quitter"
        Me.LeaveButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(270, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(365, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Le nom doit être composé d'au moins 3 caractères"
        Me.Label2.Visible = False
        '
        'ScoreButton
        '
        Me.ScoreButton.Location = New System.Drawing.Point(284, 289)
        Me.ScoreButton.Name = "ScoreButton"
        Me.ScoreButton.Size = New System.Drawing.Size(249, 86)
        Me.ScoreButton.TabIndex = 5
        Me.ScoreButton.Text = "Score"
        Me.ScoreButton.UseVisualStyleBackColor = True
        '
        'OptionsButton
        '
        Me.OptionsButton.Location = New System.Drawing.Point(16, 406)
        Me.OptionsButton.Name = "OptionsButton"
        Me.OptionsButton.Size = New System.Drawing.Size(83, 31)
        Me.OptionsButton.TabIndex = 6
        Me.OptionsButton.Text = "Options"
        Me.OptionsButton.UseVisualStyleBackColor = True
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 449)
        Me.Controls.Add(Me.OptionsButton)
        Me.Controls.Add(Me.ScoreButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LeaveButton)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Accueil"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PlayButton As Button
    Friend WithEvents LeaveButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ScoreButton As Button
    Friend WithEvents OptionsButton As Button
End Class
