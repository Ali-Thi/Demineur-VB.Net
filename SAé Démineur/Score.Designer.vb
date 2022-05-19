<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Score
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
        Me.Nom = New System.Windows.Forms.ListBox()
        Me.caseDecouv = New System.Windows.Forms.ListBox()
        Me.nbParti = New System.Windows.Forms.ListBox()
        Me.temps = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Nom
        '
        Me.Nom.FormattingEnabled = True
        Me.Nom.Location = New System.Drawing.Point(29, 80)
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(120, 264)
        Me.Nom.TabIndex = 0
        '
        'caseDecouv
        '
        Me.caseDecouv.FormattingEnabled = True
        Me.caseDecouv.Location = New System.Drawing.Point(209, 80)
        Me.caseDecouv.Name = "caseDecouv"
        Me.caseDecouv.Size = New System.Drawing.Size(120, 264)
        Me.caseDecouv.TabIndex = 1
        '
        'nbParti
        '
        Me.nbParti.FormattingEnabled = True
        Me.nbParti.Location = New System.Drawing.Point(389, 80)
        Me.nbParti.Name = "nbParti"
        Me.nbParti.Size = New System.Drawing.Size(120, 264)
        Me.nbParti.TabIndex = 2
        '
        'temps
        '
        Me.temps.FormattingEnabled = True
        Me.temps.Location = New System.Drawing.Point(575, 80)
        Me.temps.Name = "temps"
        Me.temps.Size = New System.Drawing.Size(120, 264)
        Me.temps.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(205, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre Case Découvert"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(409, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nombre Partie"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(613, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Temps"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(307, 378)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(616, 378)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Quitter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Score
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.temps)
        Me.Controls.Add(Me.nbParti)
        Me.Controls.Add(Me.caseDecouv)
        Me.Controls.Add(Me.Nom)
        Me.Name = "Score"
        Me.Text = "Score"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Nom As ListBox
    Friend WithEvents caseDecouv As ListBox
    Friend WithEvents nbParti As ListBox
    Friend WithEvents temps As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
End Class
