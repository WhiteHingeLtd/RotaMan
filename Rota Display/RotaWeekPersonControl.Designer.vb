<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RotaWeekPersonControl
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
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FriNext = New Rota_Display.RotaDayControls()
        Me.ThuNext = New Rota_Display.RotaDayControls()
        Me.WedNext = New Rota_Display.RotaDayControls()
        Me.TueNext = New Rota_Display.RotaDayControls()
        Me.MonNext = New Rota_Display.RotaDayControls()
        Me.SunNext = New Rota_Display.RotaDayControls()
        Me.SatNext = New Rota_Display.RotaDayControls()
        Me.FriControl = New Rota_Display.RotaDayControls()
        Me.ThuControl = New Rota_Display.RotaDayControls()
        Me.WedControl = New Rota_Display.RotaDayControls()
        Me.TueControl = New Rota_Display.RotaDayControls()
        Me.MonControl = New Rota_Display.RotaDayControls()
        Me.SunControl = New Rota_Display.RotaDayControls()
        Me.SatControl = New Rota_Display.RotaDayControls()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(3, 36)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(143, 20)
        Me.NameLabel.TabIndex = 7
        Me.NameLabel.Text = "Sky Grannel-Baker"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Recorded"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Scheduled"
        '
        'FriNext
        '
        Me.FriNext.EmployeeId = 0
        Me.FriNext.Location = New System.Drawing.Point(1571, 3)
        Me.FriNext.Name = "FriNext"
        Me.FriNext.Size = New System.Drawing.Size(108, 102)
        Me.FriNext.TabIndex = 14
        Me.FriNext.TargetDate = Nothing
        Me.FriNext.TargetDOW = "Friday"
        '
        'ThuNext
        '
        Me.ThuNext.EmployeeId = 0
        Me.ThuNext.Location = New System.Drawing.Point(1466, 3)
        Me.ThuNext.Name = "ThuNext"
        Me.ThuNext.Size = New System.Drawing.Size(108, 102)
        Me.ThuNext.TabIndex = 13
        Me.ThuNext.TargetDate = Nothing
        Me.ThuNext.TargetDOW = "Thursday"
        '
        'WedNext
        '
        Me.WedNext.EmployeeId = 0
        Me.WedNext.Location = New System.Drawing.Point(1361, 3)
        Me.WedNext.Name = "WedNext"
        Me.WedNext.Size = New System.Drawing.Size(109, 102)
        Me.WedNext.TabIndex = 12
        Me.WedNext.TargetDate = Nothing
        Me.WedNext.TargetDOW = "Wednesday"
        '
        'TueNext
        '
        Me.TueNext.EmployeeId = 0
        Me.TueNext.Location = New System.Drawing.Point(1255, 3)
        Me.TueNext.Name = "TueNext"
        Me.TueNext.Size = New System.Drawing.Size(108, 102)
        Me.TueNext.TabIndex = 11
        Me.TueNext.TargetDate = Nothing
        Me.TueNext.TargetDOW = "Tuesday"
        '
        'MonNext
        '
        Me.MonNext.EmployeeId = 0
        Me.MonNext.Location = New System.Drawing.Point(1150, 3)
        Me.MonNext.Name = "MonNext"
        Me.MonNext.Size = New System.Drawing.Size(106, 102)
        Me.MonNext.TabIndex = 10
        Me.MonNext.TargetDate = Nothing
        Me.MonNext.TargetDOW = "Monday"
        '
        'SunNext
        '
        Me.SunNext.EmployeeId = 0
        Me.SunNext.Location = New System.Drawing.Point(1046, 3)
        Me.SunNext.Name = "SunNext"
        Me.SunNext.Size = New System.Drawing.Size(105, 102)
        Me.SunNext.TabIndex = 9
        Me.SunNext.TargetDate = Nothing
        Me.SunNext.TargetDOW = "Sunday"
        '
        'SatNext
        '
        Me.SatNext.EmployeeId = 0
        Me.SatNext.Location = New System.Drawing.Point(940, 3)
        Me.SatNext.Name = "SatNext"
        Me.SatNext.Size = New System.Drawing.Size(108, 102)
        Me.SatNext.TabIndex = 8
        Me.SatNext.TargetDate = Nothing
        Me.SatNext.TargetDOW = "Saturday"
        '
        'FriControl
        '
        Me.FriControl.EmployeeId = 0
        Me.FriControl.Location = New System.Drawing.Point(781, 3)
        Me.FriControl.Name = "FriControl"
        Me.FriControl.Size = New System.Drawing.Size(108, 102)
        Me.FriControl.TabIndex = 6
        Me.FriControl.TargetDate = Nothing
        Me.FriControl.TargetDOW = "Friday"
        '
        'ThuControl
        '
        Me.ThuControl.EmployeeId = 0
        Me.ThuControl.Location = New System.Drawing.Point(676, 3)
        Me.ThuControl.Name = "ThuControl"
        Me.ThuControl.Size = New System.Drawing.Size(108, 102)
        Me.ThuControl.TabIndex = 5
        Me.ThuControl.TargetDate = Nothing
        Me.ThuControl.TargetDOW = "Thursday"
        '
        'WedControl
        '
        Me.WedControl.EmployeeId = 0
        Me.WedControl.Location = New System.Drawing.Point(571, 3)
        Me.WedControl.Name = "WedControl"
        Me.WedControl.Size = New System.Drawing.Size(109, 102)
        Me.WedControl.TabIndex = 4
        Me.WedControl.TargetDate = Nothing
        Me.WedControl.TargetDOW = "Wednesday"
        '
        'TueControl
        '
        Me.TueControl.EmployeeId = 0
        Me.TueControl.Location = New System.Drawing.Point(465, 3)
        Me.TueControl.Name = "TueControl"
        Me.TueControl.Size = New System.Drawing.Size(108, 102)
        Me.TueControl.TabIndex = 3
        Me.TueControl.TargetDate = Nothing
        Me.TueControl.TargetDOW = "Tuesday"
        '
        'MonControl
        '
        Me.MonControl.EmployeeId = 0
        Me.MonControl.Location = New System.Drawing.Point(360, 3)
        Me.MonControl.Name = "MonControl"
        Me.MonControl.Size = New System.Drawing.Size(106, 102)
        Me.MonControl.TabIndex = 2
        Me.MonControl.TargetDate = Nothing
        Me.MonControl.TargetDOW = "Monday"
        '
        'SunControl
        '
        Me.SunControl.EmployeeId = 0
        Me.SunControl.Location = New System.Drawing.Point(256, 3)
        Me.SunControl.Name = "SunControl"
        Me.SunControl.Size = New System.Drawing.Size(105, 102)
        Me.SunControl.TabIndex = 1
        Me.SunControl.TargetDate = Nothing
        Me.SunControl.TargetDOW = "Sunday"
        '
        'SatControl
        '
        Me.SatControl.EmployeeId = 0
        Me.SatControl.Location = New System.Drawing.Point(150, 3)
        Me.SatControl.Name = "SatControl"
        Me.SatControl.Size = New System.Drawing.Size(108, 102)
        Me.SatControl.TabIndex = 0
        Me.SatControl.TargetDate = Nothing
        Me.SatControl.TargetDOW = "Saturday"
        '
        'RotaWeekPersonControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.FriNext)
        Me.Controls.Add(Me.ThuNext)
        Me.Controls.Add(Me.WedNext)
        Me.Controls.Add(Me.TueNext)
        Me.Controls.Add(Me.MonNext)
        Me.Controls.Add(Me.SunNext)
        Me.Controls.Add(Me.SatNext)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.FriControl)
        Me.Controls.Add(Me.ThuControl)
        Me.Controls.Add(Me.WedControl)
        Me.Controls.Add(Me.TueControl)
        Me.Controls.Add(Me.MonControl)
        Me.Controls.Add(Me.SunControl)
        Me.Controls.Add(Me.SatControl)
        Me.Name = "RotaWeekPersonControl"
        Me.Size = New System.Drawing.Size(1761, 105)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SatControl As RotaDayControls
    Friend WithEvents SunControl As RotaDayControls
    Friend WithEvents MonControl As RotaDayControls
    Friend WithEvents TueControl As RotaDayControls
    Friend WithEvents WedControl As RotaDayControls
    Friend WithEvents ThuControl As RotaDayControls
    Friend WithEvents FriControl As RotaDayControls
    Friend WithEvents NameLabel As Label
    Friend WithEvents FriNext As RotaDayControls
    Friend WithEvents ThuNext As RotaDayControls
    Friend WithEvents WedNext As RotaDayControls
    Friend WithEvents TueNext As RotaDayControls
    Friend WithEvents MonNext As RotaDayControls
    Friend WithEvents SunNext As RotaDayControls
    Friend WithEvents SatNext As RotaDayControls
    Friend WithEvents DaysInPanel As Panel
    Friend WithEvents DaysInLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
