<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
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
        Me.user_lbl = New System.Windows.Forms.Label()
        Me.teetime_btn = New System.Windows.Forms.Button()
        Me.score_btn = New System.Windows.Forms.Button()
        Me.lesson_btn = New System.Windows.Forms.Button()
        Me.event_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'user_lbl
        '
        Me.user_lbl.AutoSize = True
        Me.user_lbl.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.user_lbl.Location = New System.Drawing.Point(1038, 33)
        Me.user_lbl.Name = "user_lbl"
        Me.user_lbl.Size = New System.Drawing.Size(132, 37)
        Me.user_lbl.TabIndex = 0
        Me.user_lbl.Text = "username"
        '
        'teetime_btn
        '
        Me.teetime_btn.Location = New System.Drawing.Point(118, 79)
        Me.teetime_btn.Name = "teetime_btn"
        Me.teetime_btn.Size = New System.Drawing.Size(110, 38)
        Me.teetime_btn.TabIndex = 1
        Me.teetime_btn.Text = "Book A Tee Time"
        Me.teetime_btn.UseVisualStyleBackColor = True
        '
        'score_btn
        '
        Me.score_btn.Location = New System.Drawing.Point(118, 143)
        Me.score_btn.Name = "score_btn"
        Me.score_btn.Size = New System.Drawing.Size(110, 38)
        Me.score_btn.TabIndex = 2
        Me.score_btn.Text = "Post Your Score!"
        Me.score_btn.UseVisualStyleBackColor = True
        '
        'lesson_btn
        '
        Me.lesson_btn.Location = New System.Drawing.Point(118, 207)
        Me.lesson_btn.Name = "lesson_btn"
        Me.lesson_btn.Size = New System.Drawing.Size(110, 38)
        Me.lesson_btn.TabIndex = 3
        Me.lesson_btn.Text = "Book a Lesson"
        Me.lesson_btn.UseVisualStyleBackColor = True
        '
        'event_btn
        '
        Me.event_btn.Location = New System.Drawing.Point(118, 278)
        Me.event_btn.Name = "event_btn"
        Me.event_btn.Size = New System.Drawing.Size(110, 38)
        Me.event_btn.TabIndex = 4
        Me.event_btn.Text = "Book an Event!"
        Me.event_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(856, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 37)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Welcome back"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1180, 632)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.event_btn)
        Me.Controls.Add(Me.lesson_btn)
        Me.Controls.Add(Me.score_btn)
        Me.Controls.Add(Me.teetime_btn)
        Me.Controls.Add(Me.user_lbl)
        Me.Name = "main"
        Me.Text = "main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents user_lbl As Label
    Friend WithEvents teetime_btn As Button
    Friend WithEvents score_btn As Button
    Friend WithEvents lesson_btn As Button
    Friend WithEvents event_btn As Button
    Friend WithEvents Label1 As Label
End Class
