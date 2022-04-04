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
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Login = New System.Windows.Forms.Button()
        Me.Register = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Username
        '
        Me.Username.Location = New System.Drawing.Point(231, 62)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(100, 26)
        Me.Username.TabIndex = 0
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(231, 110)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(100, 26)
        Me.Password.TabIndex = 1
        '
        'Login
        '
        Me.Login.Location = New System.Drawing.Point(315, 311)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(100, 30)
        Me.Login.TabIndex = 2
        Me.Login.Text = "Login"
        Me.Login.UseVisualStyleBackColor = True
        '
        'Register
        '
        Me.Register.Location = New System.Drawing.Point(231, 215)
        Me.Register.Name = "Register"
        Me.Register.Size = New System.Drawing.Size(100, 31)
        Me.Register.TabIndex = 3
        Me.Register.Text = "Register"
        Me.Register.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(111, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(111, 316)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Have an account?, Login"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(231, 159)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(115, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Male"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Register)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Username)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Username As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents Login As Button
    Friend WithEvents Register As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
End Class
