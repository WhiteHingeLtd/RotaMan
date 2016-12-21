<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HolidayEntitlements
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HolidayEntitlements))
        Me.ChangeNextYear = New System.Windows.Forms.Button()
        Me.ChangeThisYear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AllowanceList = New System.Windows.Forms.ListView()
        Me.EmployeeCol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Year1Col = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Year2Col = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChangeNextYear
        '
        Me.ChangeNextYear.Location = New System.Drawing.Point(339, 237)
        Me.ChangeNextYear.Name = "ChangeNextYear"
        Me.ChangeNextYear.Size = New System.Drawing.Size(90, 23)
        Me.ChangeNextYear.TabIndex = 1
        Me.ChangeNextYear.Text = "Change 2017"
        Me.ChangeNextYear.UseVisualStyleBackColor = True
        '
        'ChangeThisYear
        '
        Me.ChangeThisYear.Location = New System.Drawing.Point(243, 237)
        Me.ChangeThisYear.Name = "ChangeThisYear"
        Me.ChangeThisYear.Size = New System.Drawing.Size(90, 23)
        Me.ChangeThisYear.TabIndex = 2
        Me.ChangeThisYear.Text = "Change 2016"
        Me.ChangeThisYear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(402, 39)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "This list shows each employee's remaining holiday allowance for this year and nex" &
    "t." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Using the buttons, you can also manually reduce it, maybe for unplanned holi" &
    "days or" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "sickness."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.AllowanceList)
        Me.Panel1.Location = New System.Drawing.Point(12, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(417, 179)
        Me.Panel1.TabIndex = 4
        '
        'AllowanceList
        '
        Me.AllowanceList.BackColor = System.Drawing.SystemColors.Window
        Me.AllowanceList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.EmployeeCol, Me.Year1Col, Me.Year2Col})
        Me.AllowanceList.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.AllowanceList.Location = New System.Drawing.Point(0, 0)
        Me.AllowanceList.Name = "AllowanceList"
        Me.AllowanceList.Size = New System.Drawing.Size(417, 179)
        Me.AllowanceList.TabIndex = 4
        Me.AllowanceList.UseCompatibleStateImageBehavior = False
        Me.AllowanceList.View = System.Windows.Forms.View.Details
        '
        'EmployeeCol
        '
        Me.EmployeeCol.Text = "Employee"
        Me.EmployeeCol.Width = 275
        '
        'Year1Col
        '
        Me.Year1Col.Text = "2016"
        '
        'Year2Col
        '
        Me.Year2Col.Text = "2017"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Controls.Add(Me.OkButton)
        Me.Panel2.Location = New System.Drawing.Point(-3, 265)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(447, 100)
        Me.Panel2.TabIndex = 5
        '
        'OkButton
        '
        Me.OkButton.Location = New System.Drawing.Point(357, 15)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(75, 23)
        Me.OkButton.TabIndex = 0
        Me.OkButton.Text = "OK"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'HolidayEntitlements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 318)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ChangeNextYear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChangeThisYear)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HolidayEntitlements"
        Me.Text = "HolidayEntitlements"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChangeNextYear As Button
    Friend WithEvents ChangeThisYear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AllowanceList As ListView
    Friend WithEvents EmployeeCol As ColumnHeader
    Friend WithEvents Year1Col As ColumnHeader
    Friend WithEvents Year2Col As ColumnHeader
    Friend WithEvents Panel2 As Panel
    Friend WithEvents OkButton As Button
End Class
