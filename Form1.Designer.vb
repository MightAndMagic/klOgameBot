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
        Me.DeuteriumLabel = New System.Windows.Forms.Label()
        Me.DeuteriumCounter = New System.Windows.Forms.Label()
        Me.KristalLabel = New System.Windows.Forms.Label()
        Me.KristallCounter = New System.Windows.Forms.Label()
        Me.EnergieLabel = New System.Windows.Forms.Label()
        Me.EnergieCounter = New System.Windows.Forms.Label()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.imBauLabel = New System.Windows.Forms.Label()
        Me.imBauText = New System.Windows.Forms.Label()
        Me.inForschungLabel = New System.Windows.Forms.Label()
        Me.inForschungText = New System.Windows.Forms.Label()
        Me.inSchiffswerftLabel = New System.Windows.Forms.Label()
        Me.inSchiffswerftText = New System.Windows.Forms.Label()
        Me.MetallLevelLabel = New System.Windows.Forms.Label()
        Me.KristallLevelLabel = New System.Windows.Forms.Label()
        Me.DeuteriumLevelLabel = New System.Windows.Forms.Label()
        Me.SolarkraftwerkLevelLabel = New System.Windows.Forms.Label()
        Me.RoboterfabrikLevelLabel = New System.Windows.Forms.Label()
        Me.RaumschiffwerftLevelLabel = New System.Windows.Forms.Label()
        Me.MetallLevelText = New System.Windows.Forms.Label()
        Me.KristallLevelText = New System.Windows.Forms.Label()
        Me.DeuteriumLevelText = New System.Windows.Forms.Label()
        Me.SolarkraftwerkLevelText = New System.Windows.Forms.Label()
        Me.RoboterfabrikLevelText = New System.Windows.Forms.Label()
        Me.RaumschiffwerftLevelText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Werbung
        '
        Me.Werbung.AutoSize = True
        Me.Werbung.Location = New System.Drawing.Point(238, 351)
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
        Me.LoginButton.Location = New System.Drawing.Point(14, 64)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(233, 46)
        Me.LoginButton.TabIndex = 1
        Me.LoginButton.Text = "Einloggen!"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'UsernameBox
        '
        Me.UsernameBox.Location = New System.Drawing.Point(76, 12)
        Me.UsernameBox.Name = "UsernameBox"
        Me.UsernameBox.Size = New System.Drawing.Size(172, 20)
        Me.UsernameBox.TabIndex = 2
        Me.UsernameBox.Text = "Epinephrine"
        '
        'PasswortBox
        '
        Me.PasswortBox.Location = New System.Drawing.Point(76, 38)
        Me.PasswortBox.Name = "PasswortBox"
        Me.PasswortBox.Size = New System.Drawing.Size(172, 20)
        Me.PasswortBox.TabIndex = 3
        Me.PasswortBox.Text = "passwort"
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
        Me.MetallLabel.Location = New System.Drawing.Point(254, 12)
        Me.MetallLabel.Name = "MetallLabel"
        Me.MetallLabel.Size = New System.Drawing.Size(76, 25)
        Me.MetallLabel.TabIndex = 6
        Me.MetallLabel.Text = "Metall:"
        '
        'MetallCounter
        '
        Me.MetallCounter.AutoSize = True
        Me.MetallCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetallCounter.Location = New System.Drawing.Point(336, 12)
        Me.MetallCounter.Name = "MetallCounter"
        Me.MetallCounter.Size = New System.Drawing.Size(32, 25)
        Me.MetallCounter.TabIndex = 7
        Me.MetallCounter.Text = "-/-"
        '
        'DeuteriumLabel
        '
        Me.DeuteriumLabel.AutoSize = True
        Me.DeuteriumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.DeuteriumLabel.Location = New System.Drawing.Point(424, 12)
        Me.DeuteriumLabel.Name = "DeuteriumLabel"
        Me.DeuteriumLabel.Size = New System.Drawing.Size(116, 25)
        Me.DeuteriumLabel.TabIndex = 6
        Me.DeuteriumLabel.Text = "Deuterium:"
        '
        'DeuteriumCounter
        '
        Me.DeuteriumCounter.AutoSize = True
        Me.DeuteriumCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeuteriumCounter.Location = New System.Drawing.Point(546, 12)
        Me.DeuteriumCounter.Name = "DeuteriumCounter"
        Me.DeuteriumCounter.Size = New System.Drawing.Size(32, 25)
        Me.DeuteriumCounter.TabIndex = 7
        Me.DeuteriumCounter.Text = "-/-"
        '
        'KristalLabel
        '
        Me.KristalLabel.AutoSize = True
        Me.KristalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KristalLabel.Location = New System.Drawing.Point(254, 38)
        Me.KristalLabel.Name = "KristalLabel"
        Me.KristalLabel.Size = New System.Drawing.Size(83, 25)
        Me.KristalLabel.TabIndex = 6
        Me.KristalLabel.Text = "Kristall:"
        '
        'KristallCounter
        '
        Me.KristallCounter.AutoSize = True
        Me.KristallCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KristallCounter.Location = New System.Drawing.Point(336, 38)
        Me.KristallCounter.Name = "KristallCounter"
        Me.KristallCounter.Size = New System.Drawing.Size(32, 25)
        Me.KristallCounter.TabIndex = 7
        Me.KristallCounter.Text = "-/-"
        '
        'EnergieLabel
        '
        Me.EnergieLabel.AutoSize = True
        Me.EnergieLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnergieLabel.Location = New System.Drawing.Point(424, 38)
        Me.EnergieLabel.Name = "EnergieLabel"
        Me.EnergieLabel.Size = New System.Drawing.Size(92, 25)
        Me.EnergieLabel.TabIndex = 6
        Me.EnergieLabel.Text = "Energie:"
        '
        'EnergieCounter
        '
        Me.EnergieCounter.AutoSize = True
        Me.EnergieCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnergieCounter.Location = New System.Drawing.Point(546, 38)
        Me.EnergieCounter.Name = "EnergieCounter"
        Me.EnergieCounter.Size = New System.Drawing.Size(32, 25)
        Me.EnergieCounter.TabIndex = 7
        Me.EnergieCounter.Text = "-/-"
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(259, 64)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(366, 46)
        Me.RefreshButton.TabIndex = 1
        Me.RefreshButton.Text = "Aktualisieren"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'imBauLabel
        '
        Me.imBauLabel.AutoSize = True
        Me.imBauLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imBauLabel.Location = New System.Drawing.Point(12, 113)
        Me.imBauLabel.Name = "imBauLabel"
        Me.imBauLabel.Size = New System.Drawing.Size(64, 20)
        Me.imBauLabel.TabIndex = 8
        Me.imBauLabel.Text = "Im Bau:"
        '
        'imBauText
        '
        Me.imBauText.AutoSize = True
        Me.imBauText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imBauText.Location = New System.Drawing.Point(107, 113)
        Me.imBauText.Name = "imBauText"
        Me.imBauText.Size = New System.Drawing.Size(23, 20)
        Me.imBauText.TabIndex = 9
        Me.imBauText.Text = "-/-"
        '
        'inForschungLabel
        '
        Me.inForschungLabel.AutoSize = True
        Me.inForschungLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inForschungLabel.Location = New System.Drawing.Point(12, 133)
        Me.inForschungLabel.Name = "inForschungLabel"
        Me.inForschungLabel.Size = New System.Drawing.Size(89, 20)
        Me.inForschungLabel.TabIndex = 8
        Me.inForschungLabel.Text = "Forschung:"
        '
        'inForschungText
        '
        Me.inForschungText.AutoSize = True
        Me.inForschungText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inForschungText.Location = New System.Drawing.Point(107, 133)
        Me.inForschungText.Name = "inForschungText"
        Me.inForschungText.Size = New System.Drawing.Size(23, 20)
        Me.inForschungText.TabIndex = 9
        Me.inForschungText.Text = "-/-"
        '
        'inSchiffswerftLabel
        '
        Me.inSchiffswerftLabel.AutoSize = True
        Me.inSchiffswerftLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inSchiffswerftLabel.Location = New System.Drawing.Point(11, 153)
        Me.inSchiffswerftLabel.Name = "inSchiffswerftLabel"
        Me.inSchiffswerftLabel.Size = New System.Drawing.Size(97, 20)
        Me.inSchiffswerftLabel.TabIndex = 8
        Me.inSchiffswerftLabel.Text = "Schiffswerft:"
        '
        'inSchiffswerftText
        '
        Me.inSchiffswerftText.AutoSize = True
        Me.inSchiffswerftText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inSchiffswerftText.Location = New System.Drawing.Point(106, 153)
        Me.inSchiffswerftText.Name = "inSchiffswerftText"
        Me.inSchiffswerftText.Size = New System.Drawing.Size(23, 20)
        Me.inSchiffswerftText.TabIndex = 9
        Me.inSchiffswerftText.Text = "-/-"
        '
        'MetallLevelLabel
        '
        Me.MetallLevelLabel.AutoSize = True
        Me.MetallLevelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetallLevelLabel.Location = New System.Drawing.Point(255, 113)
        Me.MetallLevelLabel.Name = "MetallLevelLabel"
        Me.MetallLevelLabel.Size = New System.Drawing.Size(89, 20)
        Me.MetallLevelLabel.TabIndex = 8
        Me.MetallLevelLabel.Text = "Metallmine:"
        '
        'KristallLevelLabel
        '
        Me.KristallLevelLabel.AutoSize = True
        Me.KristallLevelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KristallLevelLabel.Location = New System.Drawing.Point(255, 133)
        Me.KristallLevelLabel.Name = "KristallLevelLabel"
        Me.KristallLevelLabel.Size = New System.Drawing.Size(93, 20)
        Me.KristallLevelLabel.TabIndex = 8
        Me.KristallLevelLabel.Text = "Kristallmine:"
        '
        'DeuteriumLevelLabel
        '
        Me.DeuteriumLevelLabel.AutoSize = True
        Me.DeuteriumLevelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeuteriumLevelLabel.Location = New System.Drawing.Point(254, 153)
        Me.DeuteriumLevelLabel.Name = "DeuteriumLevelLabel"
        Me.DeuteriumLevelLabel.Size = New System.Drawing.Size(99, 20)
        Me.DeuteriumLevelLabel.TabIndex = 8
        Me.DeuteriumLevelLabel.Text = "Deuteriums.:"
        '
        'SolarkraftwerkLevelLabel
        '
        Me.SolarkraftwerkLevelLabel.AutoSize = True
        Me.SolarkraftwerkLevelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SolarkraftwerkLevelLabel.Location = New System.Drawing.Point(425, 113)
        Me.SolarkraftwerkLevelLabel.Name = "SolarkraftwerkLevelLabel"
        Me.SolarkraftwerkLevelLabel.Size = New System.Drawing.Size(110, 20)
        Me.SolarkraftwerkLevelLabel.TabIndex = 8
        Me.SolarkraftwerkLevelLabel.Text = "Solarkrafwerk:"
        '
        'RoboterfabrikLevelLabel
        '
        Me.RoboterfabrikLevelLabel.AutoSize = True
        Me.RoboterfabrikLevelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoboterfabrikLevelLabel.Location = New System.Drawing.Point(425, 133)
        Me.RoboterfabrikLevelLabel.Name = "RoboterfabrikLevelLabel"
        Me.RoboterfabrikLevelLabel.Size = New System.Drawing.Size(110, 20)
        Me.RoboterfabrikLevelLabel.TabIndex = 8
        Me.RoboterfabrikLevelLabel.Text = "Roboterfabrik:"
        '
        'RaumschiffwerftLevelLabel
        '
        Me.RaumschiffwerftLevelLabel.AutoSize = True
        Me.RaumschiffwerftLevelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RaumschiffwerftLevelLabel.Location = New System.Drawing.Point(424, 153)
        Me.RaumschiffwerftLevelLabel.Name = "RaumschiffwerftLevelLabel"
        Me.RaumschiffwerftLevelLabel.Size = New System.Drawing.Size(129, 20)
        Me.RaumschiffwerftLevelLabel.TabIndex = 8
        Me.RaumschiffwerftLevelLabel.Text = "Raumschiffwerft:"
        '
        'MetallLevelText
        '
        Me.MetallLevelText.AutoSize = True
        Me.MetallLevelText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetallLevelText.Location = New System.Drawing.Point(360, 113)
        Me.MetallLevelText.Name = "MetallLevelText"
        Me.MetallLevelText.Size = New System.Drawing.Size(23, 20)
        Me.MetallLevelText.TabIndex = 9
        Me.MetallLevelText.Text = "-/-"
        '
        'KristallLevelText
        '
        Me.KristallLevelText.AutoSize = True
        Me.KristallLevelText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KristallLevelText.Location = New System.Drawing.Point(360, 133)
        Me.KristallLevelText.Name = "KristallLevelText"
        Me.KristallLevelText.Size = New System.Drawing.Size(23, 20)
        Me.KristallLevelText.TabIndex = 9
        Me.KristallLevelText.Text = "-/-"
        '
        'DeuteriumLevelText
        '
        Me.DeuteriumLevelText.AutoSize = True
        Me.DeuteriumLevelText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeuteriumLevelText.Location = New System.Drawing.Point(360, 153)
        Me.DeuteriumLevelText.Name = "DeuteriumLevelText"
        Me.DeuteriumLevelText.Size = New System.Drawing.Size(23, 20)
        Me.DeuteriumLevelText.TabIndex = 9
        Me.DeuteriumLevelText.Text = "-/-"
        '
        'SolarkraftwerkLevelText
        '
        Me.SolarkraftwerkLevelText.AutoSize = True
        Me.SolarkraftwerkLevelText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SolarkraftwerkLevelText.Location = New System.Drawing.Point(560, 113)
        Me.SolarkraftwerkLevelText.Name = "SolarkraftwerkLevelText"
        Me.SolarkraftwerkLevelText.Size = New System.Drawing.Size(23, 20)
        Me.SolarkraftwerkLevelText.TabIndex = 9
        Me.SolarkraftwerkLevelText.Text = "-/-"
        '
        'RoboterfabrikLevelText
        '
        Me.RoboterfabrikLevelText.AutoSize = True
        Me.RoboterfabrikLevelText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoboterfabrikLevelText.Location = New System.Drawing.Point(560, 133)
        Me.RoboterfabrikLevelText.Name = "RoboterfabrikLevelText"
        Me.RoboterfabrikLevelText.Size = New System.Drawing.Size(23, 20)
        Me.RoboterfabrikLevelText.TabIndex = 9
        Me.RoboterfabrikLevelText.Text = "-/-"
        '
        'RaumschiffwerftLevelText
        '
        Me.RaumschiffwerftLevelText.AutoSize = True
        Me.RaumschiffwerftLevelText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RaumschiffwerftLevelText.Location = New System.Drawing.Point(560, 153)
        Me.RaumschiffwerftLevelText.Name = "RaumschiffwerftLevelText"
        Me.RaumschiffwerftLevelText.Size = New System.Drawing.Size(23, 20)
        Me.RaumschiffwerftLevelText.TabIndex = 9
        Me.RaumschiffwerftLevelText.Text = "-/-"
        '
        'klOgameBot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(637, 373)
        Me.Controls.Add(Me.RaumschiffwerftLevelText)
        Me.Controls.Add(Me.RoboterfabrikLevelText)
        Me.Controls.Add(Me.DeuteriumLevelText)
        Me.Controls.Add(Me.KristallLevelText)
        Me.Controls.Add(Me.SolarkraftwerkLevelText)
        Me.Controls.Add(Me.inSchiffswerftText)
        Me.Controls.Add(Me.MetallLevelText)
        Me.Controls.Add(Me.inForschungText)
        Me.Controls.Add(Me.imBauText)
        Me.Controls.Add(Me.RaumschiffwerftLevelLabel)
        Me.Controls.Add(Me.DeuteriumLevelLabel)
        Me.Controls.Add(Me.inSchiffswerftLabel)
        Me.Controls.Add(Me.RoboterfabrikLevelLabel)
        Me.Controls.Add(Me.KristallLevelLabel)
        Me.Controls.Add(Me.SolarkraftwerkLevelLabel)
        Me.Controls.Add(Me.MetallLevelLabel)
        Me.Controls.Add(Me.inForschungLabel)
        Me.Controls.Add(Me.imBauLabel)
        Me.Controls.Add(Me.EnergieCounter)
        Me.Controls.Add(Me.KristallCounter)
        Me.Controls.Add(Me.DeuteriumCounter)
        Me.Controls.Add(Me.EnergieLabel)
        Me.Controls.Add(Me.KristalLabel)
        Me.Controls.Add(Me.DeuteriumLabel)
        Me.Controls.Add(Me.MetallLabel)
        Me.Controls.Add(Me.PasswortLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.PasswortBox)
        Me.Controls.Add(Me.UsernameBox)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.Werbung)
        Me.Controls.Add(Me.MetallCounter)
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
    Friend WithEvents DeuteriumLabel As System.Windows.Forms.Label
    Friend WithEvents DeuteriumCounter As System.Windows.Forms.Label
    Friend WithEvents KristalLabel As System.Windows.Forms.Label
    Friend WithEvents KristallCounter As System.Windows.Forms.Label
    Friend WithEvents EnergieLabel As System.Windows.Forms.Label
    Friend WithEvents EnergieCounter As System.Windows.Forms.Label
    Friend WithEvents RefreshButton As System.Windows.Forms.Button
    Friend WithEvents imBauLabel As System.Windows.Forms.Label
    Friend WithEvents imBauText As System.Windows.Forms.Label
    Friend WithEvents inForschungLabel As System.Windows.Forms.Label
    Friend WithEvents inForschungText As System.Windows.Forms.Label
    Friend WithEvents inSchiffswerftLabel As System.Windows.Forms.Label
    Friend WithEvents inSchiffswerftText As System.Windows.Forms.Label
    Friend WithEvents MetallLevelLabel As System.Windows.Forms.Label
    Friend WithEvents KristallLevelLabel As System.Windows.Forms.Label
    Friend WithEvents DeuteriumLevelLabel As System.Windows.Forms.Label
    Friend WithEvents SolarkraftwerkLevelLabel As System.Windows.Forms.Label
    Friend WithEvents RoboterfabrikLevelLabel As System.Windows.Forms.Label
    Friend WithEvents RaumschiffwerftLevelLabel As System.Windows.Forms.Label
    Friend WithEvents MetallLevelText As System.Windows.Forms.Label
    Friend WithEvents KristallLevelText As System.Windows.Forms.Label
    Friend WithEvents DeuteriumLevelText As System.Windows.Forms.Label
    Friend WithEvents SolarkraftwerkLevelText As System.Windows.Forms.Label
    Friend WithEvents RoboterfabrikLevelText As System.Windows.Forms.Label
    Friend WithEvents RaumschiffwerftLevelText As System.Windows.Forms.Label

End Class
