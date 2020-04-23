<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aimbot
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
        Me.chest = New System.Windows.Forms.RadioButton()
        Me.head = New System.Windows.Forms.RadioButton()
        Me.aim_check = New System.Windows.Forms.CheckBox()
        Me.enable_aimbot = New System.Windows.Forms.CheckBox()
        Me.close_button = New System.Windows.Forms.Button()
        Me.aim_predict_check = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'chest
        '
        Me.chest.AutoSize = True
        Me.chest.Checked = True
        Me.chest.Location = New System.Drawing.Point(33, 77)
        Me.chest.Name = "chest"
        Me.chest.Size = New System.Drawing.Size(52, 17)
        Me.chest.TabIndex = 27
        Me.chest.TabStop = True
        Me.chest.Text = "Chest"
        Me.chest.UseVisualStyleBackColor = True
        '
        'head
        '
        Me.head.AutoSize = True
        Me.head.Location = New System.Drawing.Point(33, 61)
        Me.head.Name = "head"
        Me.head.Size = New System.Drawing.Size(51, 17)
        Me.head.TabIndex = 26
        Me.head.TabStop = True
        Me.head.Text = "Head"
        Me.head.UseVisualStyleBackColor = True
        '
        'aim_check
        '
        Me.aim_check.AutoSize = True
        Me.aim_check.Enabled = False
        Me.aim_check.Location = New System.Drawing.Point(33, 29)
        Me.aim_check.Name = "aim_check"
        Me.aim_check.Size = New System.Drawing.Size(77, 17)
        Me.aim_check.TabIndex = 25
        Me.aim_check.Text = "Aim Check"
        Me.aim_check.UseVisualStyleBackColor = True
        '
        'enable_aimbot
        '
        Me.enable_aimbot.AutoSize = True
        Me.enable_aimbot.Location = New System.Drawing.Point(12, 12)
        Me.enable_aimbot.Name = "enable_aimbot"
        Me.enable_aimbot.Size = New System.Drawing.Size(138, 17)
        Me.enable_aimbot.TabIndex = 24
        Me.enable_aimbot.Text = "Enable Aimbot On Lock"
        Me.enable_aimbot.UseVisualStyleBackColor = True
        '
        'close_button
        '
        Me.close_button.Location = New System.Drawing.Point(192, 71)
        Me.close_button.Name = "close_button"
        Me.close_button.Size = New System.Drawing.Size(75, 23)
        Me.close_button.TabIndex = 28
        Me.close_button.Text = "Close"
        Me.close_button.UseVisualStyleBackColor = True
        '
        'aim_predict_check
        '
        Me.aim_predict_check.AutoSize = True
        Me.aim_predict_check.Enabled = False
        Me.aim_predict_check.Location = New System.Drawing.Point(33, 46)
        Me.aim_predict_check.Name = "aim_predict_check"
        Me.aim_predict_check.Size = New System.Drawing.Size(93, 17)
        Me.aim_predict_check.TabIndex = 29
        Me.aim_predict_check.Text = "Aim Prediction"
        Me.aim_predict_check.UseVisualStyleBackColor = True
        '
        'aimbot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 96)
        Me.Controls.Add(Me.aim_predict_check)
        Me.Controls.Add(Me.close_button)
        Me.Controls.Add(Me.chest)
        Me.Controls.Add(Me.head)
        Me.Controls.Add(Me.aim_check)
        Me.Controls.Add(Me.enable_aimbot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "aimbot"
        Me.Padding = New System.Windows.Forms.Padding(9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aimbot Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chest As System.Windows.Forms.RadioButton
    Friend WithEvents head As System.Windows.Forms.RadioButton
    Friend WithEvents aim_check As System.Windows.Forms.CheckBox
    Friend WithEvents enable_aimbot As System.Windows.Forms.CheckBox
    Friend WithEvents close_button As System.Windows.Forms.Button
    Friend WithEvents aim_predict_check As System.Windows.Forms.CheckBox

End Class
