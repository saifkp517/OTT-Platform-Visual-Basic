<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Subscriptions
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SubName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AnnualSubPrice = New System.Windows.Forms.TextBox()
        Me.QuarterlySubPrice = New System.Windows.Forms.TextBox()
        Me.MonthlySubPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(435, 410)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(241, 47)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Add Sub"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(34, 410)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 46)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Remove Sub"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(430, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Subscription Name"
        '
        'SubName
        '
        Me.SubName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubName.Location = New System.Drawing.Point(435, 54)
        Me.SubName.Name = "SubName"
        Me.SubName.Size = New System.Drawing.Size(241, 30)
        Me.SubName.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(430, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Price(Annual)"
        '
        'AnnualSubPrice
        '
        Me.AnnualSubPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnnualSubPrice.Location = New System.Drawing.Point(435, 150)
        Me.AnnualSubPrice.Name = "AnnualSubPrice"
        Me.AnnualSubPrice.Size = New System.Drawing.Size(241, 30)
        Me.AnnualSubPrice.TabIndex = 1
        '
        'QuarterlySubPrice
        '
        Me.QuarterlySubPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuarterlySubPrice.Location = New System.Drawing.Point(435, 241)
        Me.QuarterlySubPrice.Name = "QuarterlySubPrice"
        Me.QuarterlySubPrice.Size = New System.Drawing.Size(241, 30)
        Me.QuarterlySubPrice.TabIndex = 7
        '
        'MonthlySubPrice
        '
        Me.MonthlySubPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthlySubPrice.Location = New System.Drawing.Point(435, 342)
        Me.MonthlySubPrice.Name = "MonthlySubPrice"
        Me.MonthlySubPrice.Size = New System.Drawing.Size(241, 30)
        Me.MonthlySubPrice.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(430, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Price(Quarterly)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(430, 314)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Price(Monthly)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Subscriptions"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 29
        Me.ListBox1.Location = New System.Drawing.Point(34, 78)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(337, 294)
        Me.ListBox1.TabIndex = 0
        '
        'Subscriptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(721, 495)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MonthlySubPrice)
        Me.Controls.Add(Me.QuarterlySubPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AnnualSubPrice)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SubName)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Subscriptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents SubName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents AnnualSubPrice As TextBox
    Friend WithEvents QuarterlySubPrice As TextBox
    Friend WithEvents MonthlySubPrice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBox1 As ListBox
End Class
