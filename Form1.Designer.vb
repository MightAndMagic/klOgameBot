<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class klOgameBot
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Werbung = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.UsernameBox = New System.Windows.Forms.TextBox()
        Me.PasswortBox = New System.Windows.Forms.TextBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswortLabel = New System.Windows.Forms.Label()
        Me.MetallLabel = New System.Windows.Forms.Label()
        Me.MetallCounter = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Werbung
        '
        Me.Werbung.AutoSize = True
        Me.Werbung.Location = New System.Drawing.Point(73, 113)
        Me.Werbung.Name = "Werbung"
        Me.Werbung.Size = New System.Drawing.Size(167, 13)
        Me.Werbung.TabIndex = 0
        Me.Werbung.Text = "Hier könnte ihre Werbung stehen!"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(393, 20)
        Me.TextBox1.TabIndex = 1
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(15, 64)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(274, 46)
        Me.LoginButton.TabIndex = 1
        Me.LoginButton.Text = "Einloggen!"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'UsernameBox
        '
        Me.UsernameBox.Location = New System.Drawing.Point(76, 12)
        Me.UsernameBox.Name = "UsernameBox"
        Me.UsernameBox.Size = New System.Drawing.Size(213, 20)
        Me.UsernameBox.TabIndex = 2
        Me.UsernameBox.Text = "Epinephrine"
        '
        'PasswortBox
        '
        Me.PasswortBox.Location = New System.Drawing.Point(76, 38)
        Me.PasswortBox.Name = "PasswortBox"
        Me.PasswortBox.Size = New System.Drawing.Size(213, 20)
        Me.PasswortBox.TabIndex = 3
        Me.PasswortBox.Text = "yourpasswordhere"
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Location = New System.Drawing.Point(12, 15)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(58, 13)
        Me.UsernameLabel.TabIndex = 4
        Me.UsernameLabel.Text = "Username:"
        '
        'PasswortLabel
        '
        Me.PasswortLabel.AutoSize = True
        Me.PasswortLabel.Location = New System.Drawing.Point(12, 41)
        Me.PasswortLabel.Name = "PasswortLabel"
        Me.PasswortLabel.Size = New System.Drawing.Size(53, 13)
        Me.PasswortLabel.TabIndex = 5
        Me.PasswortLabel.Text = "Passwort:"
        '
        'MetallLabel
        '
        Me.MetallLabel.AutoSize = True
        Me.MetallLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetallLabel.Location = New System.Drawing.Point(10, 126)
        Me.MetallLabel.Name = "MetallLabel"
        Me.MetallLabel.Size = New System.Drawing.Size(76, 25)
        Me.MetallLabel.TabIndex = 6
        Me.MetallLabel.Text = "Metall:"
        '
        'MetallCounter
        '
        Me.MetallCounter.AutoSize = True
        Me.MetallCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetallCounter.Location = New System.Drawing.Point(92, 126)
        Me.MetallCounter.Name = "MetallCounter"
        Me.MetallCounter.Size = New System.Drawing.Size(32, 25)
        Me.MetallCounter.TabIndex = 7
        Me.MetallCounter.Text = "-/-"
        '
        'klOgameBot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(301, 373)
        Me.Controls.Add(Me.MetallCounter)
        Me.Controls.Add(Me.MetallLabel)
        Me.Controls.Add(Me.PasswortLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.PasswortBox)
        Me.Controls.Add(Me.UsernameBox)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.Werbung)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "klOgameBot"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "klOgameBot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Werbung As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LoginButton As System.Windows.Forms.Button
    Friend WithEvents UsernameBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswortBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswortLabel As System.Windows.Forms.Label
    Friend WithEvents MetallLabel As System.Windows.Forms.Label
    Friend WithEvents MetallCounter As System.Windows.Forms.Label

End Class
