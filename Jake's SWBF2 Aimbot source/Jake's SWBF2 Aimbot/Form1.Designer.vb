<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.current_x = New System.Windows.Forms.TextBox()
        Me.current_y = New System.Windows.Forms.TextBox()
        Me.current_z = New System.Windows.Forms.TextBox()
        Me.target_z = New System.Windows.Forms.TextBox()
        Me.target_y = New System.Windows.Forms.TextBox()
        Me.target_x = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.crosshair_z = New System.Windows.Forms.TextBox()
        Me.crosshair_y = New System.Windows.Forms.TextBox()
        Me.crosshair_x = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.close_hack = New System.Windows.Forms.Button()
        Me.hacks_button = New System.Windows.Forms.Button()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.aimbot_button = New System.Windows.Forms.Button()
        Me.settings_button = New System.Windows.Forms.Button()
        Me.teleport = New System.Windows.Forms.Label()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.console_button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Current Y"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Current Z"
        '
        'current_x
        '
        Me.current_x.Location = New System.Drawing.Point(16, 30)
        Me.current_x.Name = "current_x"
        Me.current_x.ReadOnly = True
        Me.current_x.Size = New System.Drawing.Size(100, 20)
        Me.current_x.TabIndex = 3
        '
        'current_y
        '
        Me.current_y.Location = New System.Drawing.Point(16, 70)
        Me.current_y.Name = "current_y"
        Me.current_y.ReadOnly = True
        Me.current_y.Size = New System.Drawing.Size(100, 20)
        Me.current_y.TabIndex = 4
        '
        'current_z
        '
        Me.current_z.Location = New System.Drawing.Point(16, 110)
        Me.current_z.Name = "current_z"
        Me.current_z.ReadOnly = True
        Me.current_z.Size = New System.Drawing.Size(100, 20)
        Me.current_z.TabIndex = 5
        '
        'target_z
        '
        Me.target_z.Location = New System.Drawing.Point(16, 260)
        Me.target_z.Name = "target_z"
        Me.target_z.ReadOnly = True
        Me.target_z.Size = New System.Drawing.Size(100, 20)
        Me.target_z.TabIndex = 11
        '
        'target_y
        '
        Me.target_y.Location = New System.Drawing.Point(16, 220)
        Me.target_y.Name = "target_y"
        Me.target_y.ReadOnly = True
        Me.target_y.Size = New System.Drawing.Size(100, 20)
        Me.target_y.TabIndex = 10
        '
        'target_x
        '
        Me.target_x.Location = New System.Drawing.Point(16, 180)
        Me.target_x.Name = "target_x"
        Me.target_x.ReadOnly = True
        Me.target_x.Size = New System.Drawing.Size(100, 20)
        Me.target_x.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Target's Z"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Target's Y"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Target's X"
        '
        'crosshair_z
        '
        Me.crosshair_z.Location = New System.Drawing.Point(213, 110)
        Me.crosshair_z.Name = "crosshair_z"
        Me.crosshair_z.ReadOnly = True
        Me.crosshair_z.Size = New System.Drawing.Size(100, 20)
        Me.crosshair_z.TabIndex = 17
        '
        'crosshair_y
        '
        Me.crosshair_y.Location = New System.Drawing.Point(213, 70)
        Me.crosshair_y.Name = "crosshair_y"
        Me.crosshair_y.ReadOnly = True
        Me.crosshair_y.Size = New System.Drawing.Size(100, 20)
        Me.crosshair_y.TabIndex = 16
        '
        'crosshair_x
        '
        Me.crosshair_x.Location = New System.Drawing.Point(213, 30)
        Me.crosshair_x.Name = "crosshair_x"
        Me.crosshair_x.ReadOnly = True
        Me.crosshair_x.Size = New System.Drawing.Size(100, 20)
        Me.crosshair_x.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(210, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Crosshair Z"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(210, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Crosshair Y"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(210, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Crosshair X"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1
        '
        'close_hack
        '
        Me.close_hack.Location = New System.Drawing.Point(192, 257)
        Me.close_hack.Name = "close_hack"
        Me.close_hack.Size = New System.Drawing.Size(144, 23)
        Me.close_hack.TabIndex = 20
        Me.close_hack.Text = "Close"
        Me.close_hack.UseVisualStyleBackColor = True
        '
        'hacks_button
        '
        Me.hacks_button.Location = New System.Drawing.Point(192, 228)
        Me.hacks_button.Name = "hacks_button"
        Me.hacks_button.Size = New System.Drawing.Size(69, 23)
        Me.hacks_button.TabIndex = 21
        Me.hacks_button.Text = "Hacks"
        Me.hacks_button.UseVisualStyleBackColor = True
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 200
        '
        'aimbot_button
        '
        Me.aimbot_button.Location = New System.Drawing.Point(192, 199)
        Me.aimbot_button.Name = "aimbot_button"
        Me.aimbot_button.Size = New System.Drawing.Size(144, 23)
        Me.aimbot_button.TabIndex = 22
        Me.aimbot_button.Text = "Aimbot Settings"
        Me.aimbot_button.UseVisualStyleBackColor = True
        '
        'settings_button
        '
        Me.settings_button.Location = New System.Drawing.Point(192, 170)
        Me.settings_button.Name = "settings_button"
        Me.settings_button.Size = New System.Drawing.Size(144, 23)
        Me.settings_button.TabIndex = 23
        Me.settings_button.Text = "Settings"
        Me.settings_button.UseVisualStyleBackColor = True
        '
        'teleport
        '
        Me.teleport.AutoSize = True
        Me.teleport.Location = New System.Drawing.Point(192, 151)
        Me.teleport.Name = "teleport"
        Me.teleport.Size = New System.Drawing.Size(120, 13)
        Me.teleport.TabIndex = 24
        Me.teleport.Text = "Teleport To Crosshair = "
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        Me.Timer4.Interval = 10
        '
        'console_button
        '
        Me.console_button.Location = New System.Drawing.Point(268, 227)
        Me.console_button.Name = "console_button"
        Me.console_button.Size = New System.Drawing.Size(68, 23)
        Me.console_button.TabIndex = 25
        Me.console_button.Text = "Console"
        Me.console_button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 284)
        Me.Controls.Add(Me.console_button)
        Me.Controls.Add(Me.teleport)
        Me.Controls.Add(Me.settings_button)
        Me.Controls.Add(Me.aimbot_button)
        Me.Controls.Add(Me.hacks_button)
        Me.Controls.Add(Me.close_hack)
        Me.Controls.Add(Me.crosshair_z)
        Me.Controls.Add(Me.crosshair_y)
        Me.Controls.Add(Me.crosshair_x)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.target_z)
        Me.Controls.Add(Me.target_y)
        Me.Controls.Add(Me.target_x)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.current_z)
        Me.Controls.Add(Me.current_y)
        Me.Controls.Add(Me.current_x)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jake's SWBF2 Aimbot"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents current_x As System.Windows.Forms.TextBox
    Friend WithEvents current_y As System.Windows.Forms.TextBox
    Friend WithEvents current_z As System.Windows.Forms.TextBox
    Friend WithEvents target_z As System.Windows.Forms.TextBox
    Friend WithEvents target_y As System.Windows.Forms.TextBox
    Friend WithEvents target_x As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents crosshair_z As System.Windows.Forms.TextBox
    Friend WithEvents crosshair_y As System.Windows.Forms.TextBox
    Friend WithEvents crosshair_x As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents close_hack As System.Windows.Forms.Button
    Friend WithEvents hacks_button As System.Windows.Forms.Button
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents aimbot_button As System.Windows.Forms.Button
    Friend WithEvents settings_button As System.Windows.Forms.Button
    Friend WithEvents teleport As System.Windows.Forms.Label
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents console_button As System.Windows.Forms.Button

End Class
