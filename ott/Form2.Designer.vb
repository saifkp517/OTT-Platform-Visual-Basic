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
        Me.SuspendLayout()
        '
        'LoginPassword
        '
        Me.LoginPassword.Location = New System.Drawing.Point(470, 161)
        Me.LoginPassword.Name = "LoginPassword"
        Me.LoginPassword.Size = New System.Drawing.Size(100, 26)
        Me.LoginPassword.TabIndex = 0
        '
        'LoginName
        '
        Me.LoginName.Location = New System.Drawing.Point(470, 100)
        Me.LoginName.Name = "LoginName"
        Me.LoginName.Size = New System.Drawing.Size(100, 26)
        Me.LoginName.TabIndex = 1
        '
        'Login
        '
        Me.Login.Location = New System.Drawing.Point(470, 222)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(100, 28)
        Me.Login.TabIndex = 2
        Me.Login.Text = "Login"
        Me.Login.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
End Class
