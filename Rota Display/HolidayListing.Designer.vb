<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HolidayListing
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.AcceptButton = New System.Windows.Forms.Button()
        Me.DeclineButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.HolidayPerson = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.HolidayInfo = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'AcceptButton
        '
        Me.AcceptButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AcceptButton.Font = New System.Drawing.Font("Wingdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.AcceptButton.Location = New System.Drawing.Point(255, 0)
        Me.AcceptButton.Name = "AcceptButton"
        Me.AcceptButton.Size = New System.Drawing.Size(27, 42)
        Me.AcceptButton.TabIndex = 0
        Me.AcceptButton.Text = "ü"
        Me.AcceptButton.UseVisualStyleBackColor = True
        '
        'DeclineButton
        '
        Me.DeclineButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeclineButton.Font = New System.Drawing.Font("Wingdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.DeclineButton.Location = New System.Drawing.Point(288, 0)
        Me.DeclineButton.Name = "DeclineButton"
        Me.DeclineButton.Size = New System.Drawing.Size(27, 42)
        Me.DeclineButton.TabIndex = 1
        Me.DeclineButton.Text = "û"
        Me.DeclineButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.HolidayPerson)
        Me.Panel1.Location = New System.Drawing.Point(3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(108, 42)
        Me.Panel1.TabIndex = 2
        '
        'HolidayPerson
        '
        Me.HolidayPerson.AutoSize = True
        Me.HolidayPerson.Location = New System.Drawing.Point(3, 4)
        Me.HolidayPerson.Name = "HolidayPerson"
        Me.HolidayPerson.Size = New System.Drawing.Size(40, 13)
        Me.HolidayPerson.TabIndex = 4
        Me.HolidayPerson.Text = "Person"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.HolidayInfo)
        Me.Panel2.Controls.Add(Me.AcceptButton)
        Me.Panel2.Controls.Add(Me.DeclineButton)
        Me.Panel2.Location = New System.Drawing.Point(117, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(315, 42)
        Me.Panel2.TabIndex = 3
        '
        'HolidayInfo
        '
        Me.HolidayInfo.Location = New System.Drawing.Point(3, 4)
        Me.HolidayInfo.Name = "HolidayInfo"
        Me.HolidayInfo.Size = New System.Drawing.Size(251, 38)
        Me.HolidayInfo.TabIndex = 5
        Me.HolidayInfo.Text = "Info"
        '
        'HolidayListing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "HolidayListing"
        Me.Size = New System.Drawing.Size(436, 47)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AcceptButton As Button
    Friend WithEvents DeclineButton As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents HolidayPerson As Label
    Friend WithEvents HolidayInfo As Label
End Class
