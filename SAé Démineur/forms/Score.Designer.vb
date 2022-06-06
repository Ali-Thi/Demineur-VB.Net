<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Score
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Nom = New System.Windows.Forms.ListBox()
        Me.BestNbCasesDecouv = New System.Windows.Forms.ListBox()
        Me.BestTemps = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LeaveButton = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DetailButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Nom
        '
        Me.Nom.FormattingEnabled = True
        Me.Nom.ItemHeight = 20
        Me.Nom.Location = New System.Drawing.Point(44, 122)
        Me.Nom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(178, 404)
        Me.Nom.TabIndex = 0
        '
        'BestNbCasesDecouv
        '
        Me.BestNbCasesDecouv.FormattingEnabled = True
        Me.BestNbCasesDecouv.ItemHeight = 20
        Me.BestNbCasesDecouv.Location = New System.Drawing.Point(314, 122)
        Me.BestNbCasesDecouv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BestNbCasesDecouv.Name = "BestNbCasesDecouv"
        Me.BestNbCasesDecouv.Size = New System.Drawing.Size(178, 404)
        Me.BestNbCasesDecouv.TabIndex = 1
        '
        'BestTemps
        '
        Me.BestTemps.FormattingEnabled = True
        Me.BestTemps.ItemHeight = 20
        Me.BestTemps.Location = New System.Drawing.Point(606, 122)
        Me.BestTemps.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BestTemps.Name = "BestTemps"
        Me.BestTemps.Size = New System.Drawing.Size(178, 404)
        Me.BestTemps.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 90)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nom :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(310, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 22)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Meilleur Score :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(602, 90)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Temps :"
        '
        'LeaveButton
        '
        Me.LeaveButton.Location = New System.Drawing.Point(914, 122)
        Me.LeaveButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LeaveButton.Name = "LeaveButton"
        Me.LeaveButton.Size = New System.Drawing.Size(112, 35)
        Me.LeaveButton.TabIndex = 10
        Me.LeaveButton.Text = "Quitter"
        Me.LeaveButton.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(900, 212)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(136, 28)
        Me.ComboBox1.Sorted = True
        Me.ComboBox1.TabIndex = 11
        '
        'DetailButton
        '
        Me.DetailButton.Location = New System.Drawing.Point(926, 282)
        Me.DetailButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DetailButton.Name = "DetailButton"
        Me.DetailButton.Size = New System.Drawing.Size(84, 29)
        Me.DetailButton.TabIndex = 12
        Me.DetailButton.Text = "Détail"
        Me.DetailButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Location = New System.Drawing.Point(860, 351)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(220, 30)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Ordre décroissant"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Score
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DetailButton)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.LeaveButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BestTemps)
        Me.Controls.Add(Me.BestNbCasesDecouv)
        Me.Controls.Add(Me.Nom)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Score"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tableau des scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Nom As ListBox
    Friend WithEvents BestNbCasesDecouv As ListBox
    Friend WithEvents BestTemps As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LeaveButton As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DetailButton As Button
    Friend WithEvents Button1 As Button
End Class
