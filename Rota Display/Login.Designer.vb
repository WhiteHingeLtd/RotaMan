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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.LoginBtn = New System.Windows.Forms.Button()
        Me.IDBox = New System.Windows.Forms.TextBox()
        Me.PinBox = New System.Windows.Forms.TextBox()
        Me.PinLabel = New System.Windows.Forms.Label()
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.InfoLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LoginBtn
        '
        Me.LoginBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBtn.Location = New System.Drawing.Point(197, 14)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(75, 42)
        Me.LoginBtn.TabIndex = 0
        Me.LoginBtn.Text = "Log in"
        Me.LoginBtn.UseVisualStyleBackColor = True
        '
        'IDBox
        '
        Me.IDBox.Location = New System.Drawing.Point(59, 14)
        Me.IDBox.Name = "IDBox"
        Me.IDBox.Size = New System.Drawing.Size(132, 20)
        Me.IDBox.TabIndex = 1
        '
        'PinBox
        '
        Me.PinBox.Location = New System.Drawing.Point(59, 40)
        Me.PinBox.Name = "PinBox"
        Me.PinBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PinBox.Size = New System.Drawing.Size(132, 20)
        Me.PinBox.TabIndex = 2
        '
        'PinLabel
        '
        Me.PinLabel.AutoSize = True
        Me.PinLabel.Location = New System.Drawing.Point(12, 43)
        Me.PinLabel.Name = "PinLabel"
        Me.PinLabel.Size = New System.Drawing.Size(22, 13)
        Me.PinLabel.TabIndex = 3
        Me.PinLabel.Text = "Pin"
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.Location = New System.Drawing.Point(12, 17)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(18, 13)
        Me.IDLabel.TabIndex = 4
        Me.IDLabel.Text = "ID"
        '
        'InfoLabel
        '
        Me.InfoLabel.AutoSize = True
        Me.InfoLabel.Location = New System.Drawing.Point(12, 63)
        Me.InfoLabel.Name = "InfoLabel"
        Me.InfoLabel.Size = New System.Drawing.Size(229, 13)
        Me.InfoLabel.TabIndex = 5
        Me.InfoLabel.Text = "Enter your User ID and Pin, then press ""log in""."
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 82)
        Me.Controls.Add(Me.InfoLabel)
        Me.Controls.Add(Me.IDLabel)
        Me.Controls.Add(Me.PinLabel)
        Me.Controls.Add(Me.PinBox)
        Me.Controls.Add(Me.IDBox)
        Me.Controls.Add(Me.LoginBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginBtn As Button
    Friend WithEvents IDBox As TextBox
    Friend WithEvents PinBox As TextBox
    Friend WithEvents PinLabel As Label
    Friend WithEvents IDLabel As Label
    Friend WithEvents InfoLabel As Label
End Class
