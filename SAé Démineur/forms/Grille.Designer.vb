<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grille
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Grille))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ReplayButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PauseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(44, 39)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(533, 480)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 60
        '
        'ReplayButton
        '
        Me.ReplayButton.BackgroundImage = CType(resources.GetObject("ReplayButton.BackgroundImage"), System.Drawing.Image)
        Me.ReplayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ReplayButton.Location = New System.Drawing.Point(604, 359)
        Me.ReplayButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ReplayButton.Name = "ReplayButton"
        Me.ReplayButton.Size = New System.Drawing.Size(44, 39)
        Me.ReplayButton.TabIndex = 75
        Me.ReplayButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.BackgroundImage = CType(resources.GetObject("ExitButton.BackgroundImage"), System.Drawing.Image)
        Me.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ExitButton.Location = New System.Drawing.Point(604, 260)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(44, 39)
        Me.ExitButton.TabIndex = 74
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PauseButton
        '
        Me.PauseButton.BackgroundImage = CType(resources.GetObject("PauseButton.BackgroundImage"), System.Drawing.Image)
        Me.PauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PauseButton.Location = New System.Drawing.Point(604, 160)
        Me.PauseButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PauseButton.Name = "PauseButton"
        Me.PauseButton.Size = New System.Drawing.Size(44, 39)
        Me.PauseButton.TabIndex = 73
        Me.PauseButton.UseVisualStyleBackColor = True
        '
        'Grille
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 555)
        Me.Controls.Add(Me.ReplayButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PauseButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Grille"
        Me.Text = "Grille"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PauseButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ReplayButton As Button
End Class
