<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings_window
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Browse = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.playsounds = New System.Windows.Forms.CheckBox()
        Me.disablehotkeys = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.windowed = New System.Windows.Forms.CheckBox()
        Me.fixaudio = New System.Windows.Forms.CheckBox()
        Me.skiplogos = New System.Windows.Forms.CheckBox()
        Me.Close1 = New System.Windows.Forms.Button()
        Me.Save1 = New System.Windows.Forms.Button()
        Me.Launch = New System.Windows.Forms.Button()
        Me.steam = New System.Windows.Forms.CheckBox()
        Me.customdir = New System.Windows.Forms.RadioButton()
        Me.x64 = New System.Windows.Forms.RadioButton()
        Me.x86 = New System.Windows.Forms.RadioButton()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.set_teleport_key = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Browse
        '
        Me.Browse.Enabled = False
        Me.Browse.Location = New System.Drawing.Point(2, 191)
        Me.Browse.Name = "Browse"
        Me.Browse.Size = New System.Drawing.Size(75, 23)
        Me.Browse.TabIndex = 28
        Me.Browse.Text = "Browse"
        Me.Browse.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.playsounds)
        Me.Panel2.Controls.Add(Me.disablehotkeys)
        Me.Panel2.Location = New System.Drawing.Point(301, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(112, 125)
        Me.Panel2.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Other Settings"
        '
        'playsounds
        '
        Me.playsounds.AutoSize = True
        Me.playsounds.Location = New System.Drawing.Point(3, 20)
        Me.playsounds.Name = "playsounds"
        Me.playsounds.Size = New System.Drawing.Size(85, 17)
        Me.playsounds.TabIndex = 5
        Me.playsounds.Text = "Play Sounds"
        Me.playsounds.UseVisualStyleBackColor = True
        '
        'disablehotkeys
        '
        Me.disablehotkeys.AutoSize = True
        Me.disablehotkeys.Location = New System.Drawing.Point(3, 43)
        Me.disablehotkeys.Name = "disablehotkeys"
        Me.disablehotkeys.Size = New System.Drawing.Size(103, 17)
        Me.disablehotkeys.TabIndex = 6
        Me.disablehotkeys.Text = "Disable Hotkeys"
        Me.disablehotkeys.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.windowed)
        Me.Panel1.Controls.Add(Me.fixaudio)
        Me.Panel1.Controls.Add(Me.skiplogos)
        Me.Panel1.Location = New System.Drawing.Point(129, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(166, 125)
        Me.Panel1.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Launching Parameters"
        '
        'windowed
        '
        Me.windowed.AutoSize = True
        Me.windowed.Location = New System.Drawing.Point(3, 23)
        Me.windowed.Name = "windowed"
        Me.windowed.Size = New System.Drawing.Size(107, 17)
        Me.windowed.TabIndex = 10
        Me.windowed.Text = "Windowed Mode"
        Me.windowed.UseVisualStyleBackColor = True
        '
        'fixaudio
        '
        Me.fixaudio.AutoSize = True
        Me.fixaudio.Location = New System.Drawing.Point(3, 46)
        Me.fixaudio.Name = "fixaudio"
        Me.fixaudio.Size = New System.Drawing.Size(117, 17)
        Me.fixaudio.TabIndex = 11
        Me.fixaudio.Text = "Fix Audio Stuttering"
        Me.fixaudio.UseVisualStyleBackColor = True
        '
        'skiplogos
        '
        Me.skiplogos.AutoSize = True
        Me.skiplogos.Location = New System.Drawing.Point(3, 69)
        Me.skiplogos.Name = "skiplogos"
        Me.skiplogos.Size = New System.Drawing.Size(116, 17)
        Me.skiplogos.TabIndex = 12
        Me.skiplogos.Text = "Skip Startup Logos"
        Me.skiplogos.UseVisualStyleBackColor = True
        '
        'Close1
        '
        Me.Close1.Location = New System.Drawing.Point(329, 191)
        Me.Close1.Name = "Close1"
        Me.Close1.Size = New System.Drawing.Size(75, 23)
        Me.Close1.TabIndex = 25
        Me.Close1.Text = "Close"
        Me.Close1.UseVisualStyleBackColor = True
        '
        'Save1
        '
        Me.Save1.Location = New System.Drawing.Point(81, 191)
        Me.Save1.Name = "Save1"
        Me.Save1.Size = New System.Drawing.Size(75, 23)
        Me.Save1.TabIndex = 24
        Me.Save1.Text = "Save"
        Me.Save1.UseVisualStyleBackColor = True
        '
        'Launch
        '
        Me.Launch.Location = New System.Drawing.Point(248, 191)
        Me.Launch.Name = "Launch"
        Me.Launch.Size = New System.Drawing.Size(75, 23)
        Me.Launch.TabIndex = 23
        Me.Launch.Text = "Launch"
        Me.Launch.UseVisualStyleBackColor = True
        '
        'steam
        '
        Me.steam.AutoSize = True
        Me.steam.Location = New System.Drawing.Point(10, 155)
        Me.steam.Name = "steam"
        Me.steam.Size = New System.Drawing.Size(56, 17)
        Me.steam.TabIndex = 22
        Me.steam.Text = "Steam"
        Me.steam.UseVisualStyleBackColor = True
        '
        'customdir
        '
        Me.customdir.AutoSize = True
        Me.customdir.Location = New System.Drawing.Point(10, 132)
        Me.customdir.Name = "customdir"
        Me.customdir.Size = New System.Drawing.Size(105, 17)
        Me.customdir.TabIndex = 21
        Me.customdir.TabStop = True
        Me.customdir.Text = "Custom Directory"
        Me.customdir.UseVisualStyleBackColor = True
        '
        'x64
        '
        Me.x64.AutoSize = True
        Me.x64.Location = New System.Drawing.Point(10, 108)
        Me.x64.Name = "x64"
        Me.x64.Size = New System.Drawing.Size(42, 17)
        Me.x64.TabIndex = 20
        Me.x64.TabStop = True
        Me.x64.Text = "x64"
        Me.x64.UseVisualStyleBackColor = True
        '
        'x86
        '
        Me.x86.AutoSize = True
        Me.x86.Location = New System.Drawing.Point(10, 84)
        Me.x86.Name = "x86"
        Me.x86.Size = New System.Drawing.Size(42, 17)
        Me.x86.TabIndex = 19
        Me.x86.TabStop = True
        Me.x86.Text = "x86"
        Me.x86.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(123, 78)
        Me.RichTextBox1.TabIndex = 18
        Me.RichTextBox1.TabStop = False
        Me.RichTextBox1.Text = ""
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'set_teleport_key
        '
        Me.set_teleport_key.Location = New System.Drawing.Point(248, 162)
        Me.set_teleport_key.Name = "set_teleport_key"
        Me.set_teleport_key.Size = New System.Drawing.Size(156, 23)
        Me.set_teleport_key.TabIndex = 29
        Me.set_teleport_key.Text = "Set Teleport Key"
        Me.set_teleport_key.UseVisualStyleBackColor = True
        '
        'settings_window
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 218)
        Me.Controls.Add(Me.set_teleport_key)
        Me.Controls.Add(Me.Browse)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Close1)
        Me.Controls.Add(Me.Save1)
        Me.Controls.Add(Me.Launch)
        Me.Controls.Add(Me.steam)
        Me.Controls.Add(Me.customdir)
        Me.Controls.Add(Me.x64)
        Me.Controls.Add(Me.x86)
        Me.Controls.Add(Me.RichTextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "settings_window"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Browse As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents playsounds As System.Windows.Forms.CheckBox
    Friend WithEvents disablehotkeys As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents windowed As System.Windows.Forms.CheckBox
    Friend WithEvents fixaudio As System.Windows.Forms.CheckBox
    Friend WithEvents skiplogos As System.Windows.Forms.CheckBox
    Friend WithEvents Close1 As System.Windows.Forms.Button
    Friend WithEvents Save1 As System.Windows.Forms.Button
    Friend WithEvents Launch As System.Windows.Forms.Button
    Friend WithEvents steam As System.Windows.Forms.CheckBox
    Friend WithEvents customdir As System.Windows.Forms.RadioButton
    Friend WithEvents x64 As System.Windows.Forms.RadioButton
    Friend WithEvents x86 As System.Windows.Forms.RadioButton
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents set_teleport_key As System.Windows.Forms.Button

End Class
