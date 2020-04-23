<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hacks
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.close_hacks = New System.Windows.Forms.Button()
        Me.regen = New System.Windows.Forms.NumericUpDown()
        Me.regen_health = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Infinite_Stamina = New System.Windows.Forms.CheckBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Super_Jump = New System.Windows.Forms.CheckBox()
        Me.Unlimited_Jump = New System.Windows.Forms.CheckBox()
        Me.No_Fall_Damage = New System.Windows.Forms.CheckBox()
        Me.Continuous_Points = New System.Windows.Forms.CheckBox()
        Me.Instant_Respawn = New System.Windows.Forms.CheckBox()
        Me.Infinite_Health = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.No_Spread = New System.Windows.Forms.CheckBox()
        Me.No_Overheat = New System.Windows.Forms.CheckBox()
        Me.Rapid_Fire = New System.Windows.Forms.CheckBox()
        Me.Infinite_Ammo = New System.Windows.Forms.CheckBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.regen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(275, 234)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.close_hacks)
        Me.TabPage1.Controls.Add(Me.regen)
        Me.TabPage1.Controls.Add(Me.regen_health)
        Me.TabPage1.Controls.Add(Me.NumericUpDown2)
        Me.TabPage1.Controls.Add(Me.Infinite_Stamina)
        Me.TabPage1.Controls.Add(Me.NumericUpDown1)
        Me.TabPage1.Controls.Add(Me.Super_Jump)
        Me.TabPage1.Controls.Add(Me.Unlimited_Jump)
        Me.TabPage1.Controls.Add(Me.No_Fall_Damage)
        Me.TabPage1.Controls.Add(Me.Continuous_Points)
        Me.TabPage1.Controls.Add(Me.Instant_Respawn)
        Me.TabPage1.Controls.Add(Me.Infinite_Health)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(267, 208)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Player Hacks"
        '
        'close_hacks
        '
        Me.close_hacks.Location = New System.Drawing.Point(189, 179)
        Me.close_hacks.Name = "close_hacks"
        Me.close_hacks.Size = New System.Drawing.Size(75, 23)
        Me.close_hacks.TabIndex = 18
        Me.close_hacks.Text = "Close"
        Me.close_hacks.UseVisualStyleBackColor = True
        '
        'regen
        '
        Me.regen.Enabled = False
        Me.regen.Location = New System.Drawing.Point(101, 170)
        Me.regen.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.regen.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.regen.Name = "regen"
        Me.regen.ReadOnly = True
        Me.regen.Size = New System.Drawing.Size(39, 20)
        Me.regen.TabIndex = 17
        Me.regen.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'regen_health
        '
        Me.regen_health.AutoSize = True
        Me.regen_health.Location = New System.Drawing.Point(3, 173)
        Me.regen_health.Name = "regen_health"
        Me.regen_health.Size = New System.Drawing.Size(92, 17)
        Me.regen_health.TabIndex = 16
        Me.regen_health.Text = "Regen Health"
        Me.regen_health.UseVisualStyleBackColor = True
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Enabled = False
        Me.NumericUpDown2.Location = New System.Drawing.Point(120, 53)
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.ReadOnly = True
        Me.NumericUpDown2.Size = New System.Drawing.Size(40, 20)
        Me.NumericUpDown2.TabIndex = 15
        Me.NumericUpDown2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Infinite_Stamina
        '
        Me.Infinite_Stamina.AutoSize = True
        Me.Infinite_Stamina.Location = New System.Drawing.Point(3, 149)
        Me.Infinite_Stamina.Name = "Infinite_Stamina"
        Me.Infinite_Stamina.Size = New System.Drawing.Size(98, 17)
        Me.Infinite_Stamina.TabIndex = 14
        Me.Infinite_Stamina.Text = "Infinite Stamina"
        Me.Infinite_Stamina.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Enabled = False
        Me.NumericUpDown1.Location = New System.Drawing.Point(91, 124)
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.ReadOnly = True
        Me.NumericUpDown1.Size = New System.Drawing.Size(40, 20)
        Me.NumericUpDown1.TabIndex = 13
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Super_Jump
        '
        Me.Super_Jump.AutoSize = True
        Me.Super_Jump.Location = New System.Drawing.Point(3, 125)
        Me.Super_Jump.Name = "Super_Jump"
        Me.Super_Jump.Size = New System.Drawing.Size(82, 17)
        Me.Super_Jump.TabIndex = 11
        Me.Super_Jump.Text = "Super Jump"
        Me.Super_Jump.UseVisualStyleBackColor = True
        '
        'Unlimited_Jump
        '
        Me.Unlimited_Jump.AutoSize = True
        Me.Unlimited_Jump.Location = New System.Drawing.Point(3, 101)
        Me.Unlimited_Jump.Name = "Unlimited_Jump"
        Me.Unlimited_Jump.Size = New System.Drawing.Size(97, 17)
        Me.Unlimited_Jump.TabIndex = 10
        Me.Unlimited_Jump.Text = "Unlimited Jump"
        Me.Unlimited_Jump.UseVisualStyleBackColor = True
        '
        'No_Fall_Damage
        '
        Me.No_Fall_Damage.AutoSize = True
        Me.No_Fall_Damage.Location = New System.Drawing.Point(3, 77)
        Me.No_Fall_Damage.Name = "No_Fall_Damage"
        Me.No_Fall_Damage.Size = New System.Drawing.Size(102, 17)
        Me.No_Fall_Damage.TabIndex = 9
        Me.No_Fall_Damage.Text = "No Fall Damage"
        Me.No_Fall_Damage.UseVisualStyleBackColor = True
        '
        'Continuous_Points
        '
        Me.Continuous_Points.AutoSize = True
        Me.Continuous_Points.Location = New System.Drawing.Point(3, 53)
        Me.Continuous_Points.Name = "Continuous_Points"
        Me.Continuous_Points.Size = New System.Drawing.Size(111, 17)
        Me.Continuous_Points.TabIndex = 8
        Me.Continuous_Points.Text = "Continuous Points"
        Me.Continuous_Points.UseVisualStyleBackColor = True
        '
        'Instant_Respawn
        '
        Me.Instant_Respawn.AutoSize = True
        Me.Instant_Respawn.Location = New System.Drawing.Point(3, 29)
        Me.Instant_Respawn.Name = "Instant_Respawn"
        Me.Instant_Respawn.Size = New System.Drawing.Size(106, 17)
        Me.Instant_Respawn.TabIndex = 7
        Me.Instant_Respawn.Text = "Instant Respawn"
        Me.Instant_Respawn.UseVisualStyleBackColor = True
        '
        'Infinite_Health
        '
        Me.Infinite_Health.AutoSize = True
        Me.Infinite_Health.Location = New System.Drawing.Point(3, 6)
        Me.Infinite_Health.Name = "Infinite_Health"
        Me.Infinite_Health.Size = New System.Drawing.Size(91, 17)
        Me.Infinite_Health.TabIndex = 5
        Me.Infinite_Health.Text = "Infinite Health"
        Me.Infinite_Health.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.No_Spread)
        Me.TabPage2.Controls.Add(Me.No_Overheat)
        Me.TabPage2.Controls.Add(Me.Rapid_Fire)
        Me.TabPage2.Controls.Add(Me.Infinite_Ammo)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(267, 208)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Weapon Hacks"
        '
        'No_Spread
        '
        Me.No_Spread.AutoSize = True
        Me.No_Spread.Location = New System.Drawing.Point(3, 77)
        Me.No_Spread.Name = "No_Spread"
        Me.No_Spread.Size = New System.Drawing.Size(77, 17)
        Me.No_Spread.TabIndex = 10
        Me.No_Spread.Text = "No Spread"
        Me.No_Spread.UseVisualStyleBackColor = True
        '
        'No_Overheat
        '
        Me.No_Overheat.AutoSize = True
        Me.No_Overheat.Location = New System.Drawing.Point(3, 53)
        Me.No_Overheat.Name = "No_Overheat"
        Me.No_Overheat.Size = New System.Drawing.Size(87, 17)
        Me.No_Overheat.TabIndex = 9
        Me.No_Overheat.Text = "No Overheat"
        Me.No_Overheat.UseVisualStyleBackColor = True
        '
        'Rapid_Fire
        '
        Me.Rapid_Fire.AutoSize = True
        Me.Rapid_Fire.Location = New System.Drawing.Point(3, 6)
        Me.Rapid_Fire.Name = "Rapid_Fire"
        Me.Rapid_Fire.Size = New System.Drawing.Size(74, 17)
        Me.Rapid_Fire.TabIndex = 7
        Me.Rapid_Fire.Text = "Rapid Fire"
        Me.Rapid_Fire.UseVisualStyleBackColor = True
        '
        'Infinite_Ammo
        '
        Me.Infinite_Ammo.AutoSize = True
        Me.Infinite_Ammo.Location = New System.Drawing.Point(3, 29)
        Me.Infinite_Ammo.Name = "Infinite_Ammo"
        Me.Infinite_Ammo.Size = New System.Drawing.Size(89, 17)
        Me.Infinite_Ammo.TabIndex = 8
        Me.Infinite_Ammo.Text = "Infinite Ammo"
        Me.Infinite_Ammo.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.TextBox2)
        Me.TabPage3.Controls.Add(Me.TextBox1)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(267, 208)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Map Hacks"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 66)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "New Map Ceiling Height"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current Map Ceiling Height"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10
        '
        'Hacks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 231)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Hacks"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hacks"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.regen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Infinite_Stamina As System.Windows.Forms.CheckBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Super_Jump As System.Windows.Forms.CheckBox
    Friend WithEvents Unlimited_Jump As System.Windows.Forms.CheckBox
    Friend WithEvents No_Fall_Damage As System.Windows.Forms.CheckBox
    Friend WithEvents Continuous_Points As System.Windows.Forms.CheckBox
    Friend WithEvents Instant_Respawn As System.Windows.Forms.CheckBox
    Friend WithEvents Infinite_Health As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents No_Spread As System.Windows.Forms.CheckBox
    Friend WithEvents No_Overheat As System.Windows.Forms.CheckBox
    Friend WithEvents Rapid_Fire As System.Windows.Forms.CheckBox
    Friend WithEvents Infinite_Ammo As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents regen_health As System.Windows.Forms.CheckBox
    Friend WithEvents regen As System.Windows.Forms.NumericUpDown
    Friend WithEvents close_hacks As System.Windows.Forms.Button

End Class
