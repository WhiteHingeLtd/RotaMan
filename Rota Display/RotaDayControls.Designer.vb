<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RotaDayControls
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
        Me.components = New System.ComponentModel.Container()
        Me.RotaDayStart = New System.Windows.Forms.TextBox()
        Me.BackPanel = New System.Windows.Forms.Panel()
        Me.NotesBox = New System.Windows.Forms.TextBox()
        Me.AttendPanel = New System.Windows.Forms.Panel()
        Me.AttendRedPanel = New System.Windows.Forms.Panel()
        Me.AttendGreenPanel = New System.Windows.Forms.Panel()
        Me.AttendOrangePanel = New System.Windows.Forms.Panel()
        Me.RotaDayEnd = New System.Windows.Forms.TextBox()
        Me.HyphenBox = New System.Windows.Forms.Label()
        Me.DateDisplay = New System.Windows.Forms.Label()
        Me.PanelToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BackPanel.SuspendLayout()
        Me.AttendPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'RotaDayStart
        '
        Me.RotaDayStart.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RotaDayStart.Location = New System.Drawing.Point(3, 49)
        Me.RotaDayStart.Name = "RotaDayStart"
        Me.RotaDayStart.Size = New System.Drawing.Size(30, 20)
        Me.RotaDayStart.TabIndex = 0
        '
        'BackPanel
        '
        Me.BackPanel.BackColor = System.Drawing.Color.Silver
        Me.BackPanel.Controls.Add(Me.NotesBox)
        Me.BackPanel.Controls.Add(Me.AttendPanel)
        Me.BackPanel.Controls.Add(Me.RotaDayEnd)
        Me.BackPanel.Controls.Add(Me.HyphenBox)
        Me.BackPanel.Controls.Add(Me.DateDisplay)
        Me.BackPanel.Controls.Add(Me.RotaDayStart)
        Me.BackPanel.Location = New System.Drawing.Point(3, 3)
        Me.BackPanel.Name = "BackPanel"
        Me.BackPanel.Size = New System.Drawing.Size(100, 96)
        Me.BackPanel.TabIndex = 2
        '
        'NotesBox
        '
        Me.NotesBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.NotesBox.Location = New System.Drawing.Point(3, 73)
        Me.NotesBox.MaxLength = 300
        Me.NotesBox.Name = "NotesBox"
        Me.NotesBox.Size = New System.Drawing.Size(94, 20)
        Me.NotesBox.TabIndex = 7
        '
        'AttendPanel
        '
        Me.AttendPanel.Controls.Add(Me.AttendRedPanel)
        Me.AttendPanel.Controls.Add(Me.AttendGreenPanel)
        Me.AttendPanel.Controls.Add(Me.AttendOrangePanel)
        Me.AttendPanel.Location = New System.Drawing.Point(0, 49)
        Me.AttendPanel.Name = "AttendPanel"
        Me.AttendPanel.Size = New System.Drawing.Size(100, 20)
        Me.AttendPanel.TabIndex = 6
        '
        'AttendRedPanel
        '
        Me.AttendRedPanel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.AttendRedPanel.BackColor = System.Drawing.Color.Red
        Me.AttendRedPanel.Location = New System.Drawing.Point(67, 0)
        Me.AttendRedPanel.Name = "AttendRedPanel"
        Me.AttendRedPanel.Size = New System.Drawing.Size(28, 20)
        Me.AttendRedPanel.TabIndex = 4
        '
        'AttendGreenPanel
        '
        Me.AttendGreenPanel.BackColor = System.Drawing.Color.YellowGreen
        Me.AttendGreenPanel.Location = New System.Drawing.Point(4, 0)
        Me.AttendGreenPanel.Name = "AttendGreenPanel"
        Me.AttendGreenPanel.Size = New System.Drawing.Size(29, 20)
        Me.AttendGreenPanel.TabIndex = 3
        '
        'AttendOrangePanel
        '
        Me.AttendOrangePanel.BackColor = System.Drawing.Color.DarkOrange
        Me.AttendOrangePanel.Location = New System.Drawing.Point(39, 0)
        Me.AttendOrangePanel.Name = "AttendOrangePanel"
        Me.AttendOrangePanel.Size = New System.Drawing.Size(24, 20)
        Me.AttendOrangePanel.TabIndex = 5
        '
        'RotaDayEnd
        '
        Me.RotaDayEnd.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.RotaDayEnd.Location = New System.Drawing.Point(66, 49)
        Me.RotaDayEnd.Name = "RotaDayEnd"
        Me.RotaDayEnd.Size = New System.Drawing.Size(29, 20)
        Me.RotaDayEnd.TabIndex = 5
        '
        'HyphenBox
        '
        Me.HyphenBox.AutoSize = True
        Me.HyphenBox.Location = New System.Drawing.Point(46, 52)
        Me.HyphenBox.Name = "HyphenBox"
        Me.HyphenBox.Size = New System.Drawing.Size(10, 13)
        Me.HyphenBox.TabIndex = 4
        Me.HyphenBox.Text = "-"
        '
        'DateDisplay
        '
        Me.DateDisplay.AutoSize = True
        Me.DateDisplay.Location = New System.Drawing.Point(1, 1)
        Me.DateDisplay.Name = "DateDisplay"
        Me.DateDisplay.Size = New System.Drawing.Size(73, 13)
        Me.DateDisplay.TabIndex = 3
        Me.DateDisplay.Text = "[Date Display]"
        '
        'InOutState
        '
        '
        'RotaDayControls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BackPanel)
        Me.Name = "RotaDayControls"
        Me.Size = New System.Drawing.Size(106, 102)
        Me.BackPanel.ResumeLayout(False)
        Me.BackPanel.PerformLayout()
        Me.AttendPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RotaDayStart As TextBox
    Friend WithEvents BackPanel As Panel
    Friend WithEvents AttendGreenPanel As Panel
    Friend WithEvents AttendRedPanel As Panel
    Friend WithEvents AttendOrangePanel As Panel
    Friend WithEvents DateDisplay As Label
    Friend WithEvents HyphenBox As Label
    Friend WithEvents PanelToolTip As ToolTip
    Friend WithEvents RotaDayEnd As TextBox
    Friend WithEvents AttendPanel As Panel
    Friend WithEvents NotesBox As TextBox
End Class
