<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.login_lbl = New System.Windows.Forms.Label()
        Me.user_lbl = New System.Windows.Forms.Label()
        Me.pass_lbl = New System.Windows.Forms.Label()
        Me.user_txt = New System.Windows.Forms.TextBox()
        Me.pass_txt = New System.Windows.Forms.TextBox()
        Me.login_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'login_lbl
        '
        Me.login_lbl.AutoSize = True
        Me.login_lbl.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.login_lbl.Location = New System.Drawing.Point(304, 9)
        Me.login_lbl.Name = "login_lbl"
        Me.login_lbl.Size = New System.Drawing.Size(122, 54)
        Me.login_lbl.TabIndex = 0
        Me.login_lbl.Text = "Login"
        '
        'user_lbl
        '
        Me.user_lbl.AutoSize = True
        Me.user_lbl.Location = New System.Drawing.Point(331, 94)
        Me.user_lbl.Name = "user_lbl"
        Me.user_lbl.Size = New System.Drawing.Size(60, 15)
        Me.user_lbl.TabIndex = 1
        Me.user_lbl.Text = "Username"
        '
        'pass_lbl
        '
        Me.pass_lbl.AutoSize = True
        Me.pass_lbl.Location = New System.Drawing.Point(334, 162)
        Me.pass_lbl.Name = "pass_lbl"
        Me.pass_lbl.Size = New System.Drawing.Size(57, 15)
        Me.pass_lbl.TabIndex = 2
        Me.pass_lbl.Text = "Password"
        '
        'user_txt
        '
        Me.user_txt.Location = New System.Drawing.Point(314, 112)
        Me.user_txt.Name = "user_txt"
        Me.user_txt.Size = New System.Drawing.Size(100, 23)
        Me.user_txt.TabIndex = 3
        '
        'pass_txt
        '
        Me.pass_txt.Location = New System.Drawing.Point(314, 180)
        Me.pass_txt.Name = "pass_txt"
        Me.pass_txt.Size = New System.Drawing.Size(100, 23)
        Me.pass_txt.TabIndex = 4
        '
        'login_btn
        '
        Me.login_btn.Location = New System.Drawing.Point(314, 248)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(100, 23)
        Me.login_btn.TabIndex = 5
        Me.login_btn.Text = "Login"
        Me.login_btn.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.login_btn)
        Me.Controls.Add(Me.pass_txt)
        Me.Controls.Add(Me.user_txt)
        Me.Controls.Add(Me.pass_lbl)
        Me.Controls.Add(Me.user_lbl)
        Me.Controls.Add(Me.login_lbl)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents login_lbl As Label
    Friend WithEvents user_lbl As Label
    Friend WithEvents pass_lbl As Label
    Friend WithEvents user_txt As TextBox
    Friend WithEvents pass_txt As TextBox
    Friend WithEvents login_btn As Button
End Class
