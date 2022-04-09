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
        Me.LoginName = New System.Windows.Forms.TextBox()
        Me.Login = New System.Windows.Forms.Button()
        Me.Logout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LoginPassword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LoginName
        '
        Me.LoginName.Location = New System.Drawing.Point(82, 119)
        Me.LoginName.Name = "LoginName"
        Me.LoginName.Size = New System.Drawing.Size(187, 26)
        Me.LoginName.TabIndex = 1
        '
        'Login
        '
        Me.Login.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Login.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login.ForeColor = System.Drawing.Color.White
        Me.Login.Location = New System.Drawing.Point(82, 239)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(182, 40)
        Me.Login.TabIndex = 2
        Me.Login.Text = "Login"
        Me.Login.UseVisualStyleBackColor = False
        '
        'Logout
        '
        Me.Logout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Logout.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Logout.ForeColor = System.Drawing.Color.White
        Me.Logout.Location = New System.Drawing.Point(82, 298)
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(182, 43)
        Me.Logout.TabIndex = 3
        Me.Logout.Text = "Logout"
        Me.Logout.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(82, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(78, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "password"
        '
        'LoginPassword
        '
        Me.LoginPassword.Location = New System.Drawing.Point(82, 187)
        Me.LoginPassword.Name = "LoginPassword"
        Me.LoginPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.LoginPassword.Size = New System.Drawing.Size(187, 26)
        Me.LoginPassword.TabIndex = 0
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(370, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Logout)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.LoginName)
        Me.Controls.Add(Me.LoginPassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(900, 650)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoginName As TextBox
    Friend WithEvents Login As Button
    Friend WithEvents Logout As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LoginPassword As TextBox
End Class
