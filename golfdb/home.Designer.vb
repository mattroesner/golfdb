<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Me.login_btn = New System.Windows.Forms.Button()
        Me.signup_btn = New System.Windows.Forms.Button()
        Me.welcome_lbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'login_btn
        '
        Me.login_btn.Location = New System.Drawing.Point(646, 222)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(94, 37)
        Me.login_btn.TabIndex = 0
        Me.login_btn.Text = "Login"
        Me.login_btn.UseVisualStyleBackColor = True
        '
        'signup_btn
        '
        Me.signup_btn.Location = New System.Drawing.Point(748, 222)
        Me.signup_btn.Name = "signup_btn"
        Me.signup_btn.Size = New System.Drawing.Size(94, 37)
        Me.signup_btn.TabIndex = 1
        Me.signup_btn.Text = "Sign Up"
        Me.signup_btn.UseVisualStyleBackColor = True
        '
        'welcome_lbl
        '
        Me.welcome_lbl.AutoSize = True
        Me.welcome_lbl.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.welcome_lbl.Location = New System.Drawing.Point(646, 76)
        Me.welcome_lbl.Name = "welcome_lbl"
        Me.welcome_lbl.Size = New System.Drawing.Size(196, 54)
        Me.welcome_lbl.TabIndex = 2
        Me.welcome_lbl.Text = "Welcome!"
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1552, 644)
        Me.Controls.Add(Me.welcome_lbl)
        Me.Controls.Add(Me.signup_btn)
        Me.Controls.Add(Me.login_btn)
        Me.Name = "home"
        Me.Text = "home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents login_btn As Button
    Friend WithEvents signup_btn As Button
    Friend WithEvents welcome_lbl As Label
End Class
