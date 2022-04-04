<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.LoginPassword = New System.Windows.Forms.TextBox()
        Me.LoginName = New System.Windows.Forms.TextBox()
        Me.Login = New System.Windows.Forms.Button()
        Me.Logout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LoginPassword
        '
        Me.LoginPassword.Location = New System.Drawing.Point(276, 170)
        Me.LoginPassword.Name = "LoginPassword"
        Me.LoginPassword.Size = New System.Drawing.Size(187, 26)
        Me.LoginPassword.TabIndex = 0
        '
        'LoginName
        '
        Me.LoginName.Location = New System.Drawing.Point(276, 107)
        Me.LoginName.Name = "LoginName"
        Me.LoginName.Size = New System.Drawing.Size(187, 26)
        Me.LoginName.TabIndex = 1
        '
        'Login
        '
        Me.Login.Location = New System.Drawing.Point(320, 227)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(100, 28)
        Me.Login.TabIndex = 2
        Me.Login.Text = "Login"
        Me.Login.UseVisualStyleBackColor = True
        '
        'Logout
        '
        Me.Logout.Location = New System.Drawing.Point(320, 280)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(100, 32)
        Me.Logout.TabIndex = 3
        Me.Logout.Text = "Logout"
        Me.Logout.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(276, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(272, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "password"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Logout)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.LoginName)
        Me.Controls.Add(Me.LoginPassword)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginPassword As TextBox
    Friend WithEvents LoginName As TextBox
    Friend WithEvents Login As Button
    Friend WithEvents Logout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
