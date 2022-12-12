<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class register_forum
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.username_lbl = New System.Windows.Forms.Label()
        Me.pass_lbl = New System.Windows.Forms.Label()
        Me.username_txt = New System.Windows.Forms.TextBox()
        Me.pass_txt = New System.Windows.Forms.TextBox()
        Me.signup_btn = New System.Windows.Forms.Button()
        Me.first_lbl = New System.Windows.Forms.Label()
        Me.last_lbl = New System.Windows.Forms.Label()
        Me.phone_lbl = New System.Windows.Forms.Label()
        Me.email_lbl = New System.Windows.Forms.Label()
        Me.street_lbl = New System.Windows.Forms.Label()
        Me.city_lbl = New System.Windows.Forms.Label()
        Me.state_lbl = New System.Windows.Forms.Label()
        Me.zip_lbl = New System.Windows.Forms.Label()
        Me.first_txt = New System.Windows.Forms.TextBox()
        Me.last_txt = New System.Windows.Forms.TextBox()
        Me.phone_txt = New System.Windows.Forms.TextBox()
        Me.email_txt = New System.Windows.Forms.TextBox()
        Me.street_txt = New System.Windows.Forms.TextBox()
        Me.city_txt = New System.Windows.Forms.TextBox()
        Me.state_txt = New System.Windows.Forms.TextBox()
        Me.zip_txt = New System.Windows.Forms.TextBox()
        Me.welcome_lbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'username_lbl
        '
        Me.username_lbl.AutoSize = True
        Me.username_lbl.Location = New System.Drawing.Point(386, 421)
        Me.username_lbl.Name = "username_lbl"
        Me.username_lbl.Size = New System.Drawing.Size(60, 15)
        Me.username_lbl.TabIndex = 0
        Me.username_lbl.Text = "Username"
        '
        'pass_lbl
        '
        Me.pass_lbl.AutoSize = True
        Me.pass_lbl.Location = New System.Drawing.Point(389, 489)
        Me.pass_lbl.Name = "pass_lbl"
        Me.pass_lbl.Size = New System.Drawing.Size(57, 15)
        Me.pass_lbl.TabIndex = 1
        Me.pass_lbl.Text = "Password"
        '
        'username_txt
        '
        Me.username_txt.Location = New System.Drawing.Point(358, 451)
        Me.username_txt.Name = "username_txt"
        Me.username_txt.Size = New System.Drawing.Size(131, 23)
        Me.username_txt.TabIndex = 2
        '
        'pass_txt
        '
        Me.pass_txt.Location = New System.Drawing.Point(358, 516)
        Me.pass_txt.Name = "pass_txt"
        Me.pass_txt.Size = New System.Drawing.Size(131, 23)
        Me.pass_txt.TabIndex = 3
        '
        'signup_btn
        '
        Me.signup_btn.BackColor = System.Drawing.SystemColors.ControlDark
        Me.signup_btn.Location = New System.Drawing.Point(358, 587)
        Me.signup_btn.Name = "signup_btn"
        Me.signup_btn.Size = New System.Drawing.Size(131, 30)
        Me.signup_btn.TabIndex = 4
        Me.signup_btn.Text = "Sign Up"
        Me.signup_btn.UseVisualStyleBackColor = False
        '
        'first_lbl
        '
        Me.first_lbl.AutoSize = True
        Me.first_lbl.Location = New System.Drawing.Point(386, 129)
        Me.first_lbl.Name = "first_lbl"
        Me.first_lbl.Size = New System.Drawing.Size(64, 15)
        Me.first_lbl.TabIndex = 5
        Me.first_lbl.Text = "First Name"
        '
        'last_lbl
        '
        Me.last_lbl.AutoSize = True
        Me.last_lbl.Location = New System.Drawing.Point(386, 184)
        Me.last_lbl.Name = "last_lbl"
        Me.last_lbl.Size = New System.Drawing.Size(63, 15)
        Me.last_lbl.TabIndex = 6
        Me.last_lbl.Text = "Last Name"
        '
        'phone_lbl
        '
        Me.phone_lbl.AutoSize = True
        Me.phone_lbl.Location = New System.Drawing.Point(389, 239)
        Me.phone_lbl.Name = "phone_lbl"
        Me.phone_lbl.Size = New System.Drawing.Size(41, 15)
        Me.phone_lbl.TabIndex = 7
        Me.phone_lbl.Text = "Phone"
        '
        'email_lbl
        '
        Me.email_lbl.AutoSize = True
        Me.email_lbl.Location = New System.Drawing.Point(389, 297)
        Me.email_lbl.Name = "email_lbl"
        Me.email_lbl.Size = New System.Drawing.Size(41, 15)
        Me.email_lbl.TabIndex = 8
        Me.email_lbl.Text = "E-mail"
        '
        'street_lbl
        '
        Me.street_lbl.AutoSize = True
        Me.street_lbl.Location = New System.Drawing.Point(73, 358)
        Me.street_lbl.Name = "street_lbl"
        Me.street_lbl.Size = New System.Drawing.Size(37, 15)
        Me.street_lbl.TabIndex = 9
        Me.street_lbl.Text = "Street"
        '
        'city_lbl
        '
        Me.city_lbl.AutoSize = True
        Me.city_lbl.Location = New System.Drawing.Point(336, 358)
        Me.city_lbl.Name = "city_lbl"
        Me.city_lbl.Size = New System.Drawing.Size(28, 15)
        Me.city_lbl.TabIndex = 10
        Me.city_lbl.Text = "City"
        '
        'state_lbl
        '
        Me.state_lbl.AutoSize = True
        Me.state_lbl.Location = New System.Drawing.Point(550, 358)
        Me.state_lbl.Name = "state_lbl"
        Me.state_lbl.Size = New System.Drawing.Size(33, 15)
        Me.state_lbl.TabIndex = 11
        Me.state_lbl.Text = "State"
        '
        'zip_lbl
        '
        Me.zip_lbl.AutoSize = True
        Me.zip_lbl.Location = New System.Drawing.Point(686, 358)
        Me.zip_lbl.Name = "zip_lbl"
        Me.zip_lbl.Size = New System.Drawing.Size(55, 15)
        Me.zip_lbl.TabIndex = 12
        Me.zip_lbl.Text = "Zip Code"
        '
        'first_txt
        '
        Me.first_txt.Location = New System.Drawing.Point(358, 147)
        Me.first_txt.Name = "first_txt"
        Me.first_txt.Size = New System.Drawing.Size(100, 23)
        Me.first_txt.TabIndex = 13
        '
        'last_txt
        '
        Me.last_txt.Location = New System.Drawing.Point(358, 202)
        Me.last_txt.Name = "last_txt"
        Me.last_txt.Size = New System.Drawing.Size(100, 23)
        Me.last_txt.TabIndex = 14
        '
        'phone_txt
        '
        Me.phone_txt.Location = New System.Drawing.Point(358, 257)
        Me.phone_txt.Name = "phone_txt"
        Me.phone_txt.Size = New System.Drawing.Size(100, 23)
        Me.phone_txt.TabIndex = 15
        '
        'email_txt
        '
        Me.email_txt.Location = New System.Drawing.Point(358, 315)
        Me.email_txt.Name = "email_txt"
        Me.email_txt.Size = New System.Drawing.Size(100, 23)
        Me.email_txt.TabIndex = 16
        '
        'street_txt
        '
        Me.street_txt.Location = New System.Drawing.Point(73, 376)
        Me.street_txt.Name = "street_txt"
        Me.street_txt.Size = New System.Drawing.Size(215, 23)
        Me.street_txt.TabIndex = 17
        '
        'city_txt
        '
        Me.city_txt.Location = New System.Drawing.Point(336, 376)
        Me.city_txt.Name = "city_txt"
        Me.city_txt.Size = New System.Drawing.Size(165, 23)
        Me.city_txt.TabIndex = 18
        '
        'state_txt
        '
        Me.state_txt.Location = New System.Drawing.Point(550, 376)
        Me.state_txt.Name = "state_txt"
        Me.state_txt.Size = New System.Drawing.Size(108, 23)
        Me.state_txt.TabIndex = 19
        '
        'zip_txt
        '
        Me.zip_txt.Location = New System.Drawing.Point(686, 376)
        Me.zip_txt.Name = "zip_txt"
        Me.zip_txt.Size = New System.Drawing.Size(115, 23)
        Me.zip_txt.TabIndex = 20
        '
        'welcome_lbl
        '
        Me.welcome_lbl.AutoSize = True
        Me.welcome_lbl.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.welcome_lbl.Location = New System.Drawing.Point(228, 24)
        Me.welcome_lbl.Name = "welcome_lbl"
        Me.welcome_lbl.Size = New System.Drawing.Size(387, 46)
        Me.welcome_lbl.TabIndex = 21
        Me.welcome_lbl.Text = "Welcome! Sign Up Here!"
        '
        'register_forum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(882, 657)
        Me.Controls.Add(Me.welcome_lbl)
        Me.Controls.Add(Me.zip_txt)
        Me.Controls.Add(Me.state_txt)
        Me.Controls.Add(Me.city_txt)
        Me.Controls.Add(Me.street_txt)
        Me.Controls.Add(Me.email_txt)
        Me.Controls.Add(Me.phone_txt)
        Me.Controls.Add(Me.last_txt)
        Me.Controls.Add(Me.first_txt)
        Me.Controls.Add(Me.zip_lbl)
        Me.Controls.Add(Me.state_lbl)
        Me.Controls.Add(Me.city_lbl)
        Me.Controls.Add(Me.street_lbl)
        Me.Controls.Add(Me.email_lbl)
        Me.Controls.Add(Me.phone_lbl)
        Me.Controls.Add(Me.last_lbl)
        Me.Controls.Add(Me.first_lbl)
        Me.Controls.Add(Me.signup_btn)
        Me.Controls.Add(Me.pass_txt)
        Me.Controls.Add(Me.username_txt)
        Me.Controls.Add(Me.pass_lbl)
        Me.Controls.Add(Me.username_lbl)
        Me.Name = "register_forum"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents username_lbl As Label
    Friend WithEvents pass_lbl As Label
    Friend WithEvents username_txt As TextBox
    Friend WithEvents pass_txt As TextBox
    Friend WithEvents signup_btn As Button
    Friend WithEvents first_lbl As Label
    Friend WithEvents last_lbl As Label
    Friend WithEvents phone_lbl As Label
    Friend WithEvents email_lbl As Label
    Friend WithEvents street_lbl As Label
    Friend WithEvents city_lbl As Label
    Friend WithEvents state_lbl As Label
    Friend WithEvents zip_lbl As Label
    Friend WithEvents first_txt As TextBox
    Friend WithEvents last_txt As TextBox
    Friend WithEvents phone_txt As TextBox
    Friend WithEvents email_txt As TextBox
    Friend WithEvents street_txt As TextBox
    Friend WithEvents city_txt As TextBox
    Friend WithEvents state_txt As TextBox
    Friend WithEvents zip_txt As TextBox
    Friend WithEvents welcome_lbl As Label
End Class
