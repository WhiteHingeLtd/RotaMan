<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeDataSet
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IDText = New System.Windows.Forms.TextBox()
        Me.LoadExistingPanel = New System.Windows.Forms.Panel()
        Me.LoadFromIDText = New System.Windows.Forms.TextBox()
        Me.LoadFromIDBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FirstNameText = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SurnameText = New System.Windows.Forms.TextBox()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.StartDateBox = New System.Windows.Forms.DateTimePicker()
        Me.VisibleCheck = New System.Windows.Forms.CheckBox()
        Me.PinChangeText = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DefaultRotaTable = New System.Windows.Forms.DataGridView()
        Me.Saturday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sunday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tuesday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Wednesday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Thursday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Friday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RotaStateMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LoadExistingPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DefaultRotaTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'IDText
        '
        Me.IDText.Location = New System.Drawing.Point(71, 8)
        Me.IDText.Name = "IDText"
        Me.IDText.Size = New System.Drawing.Size(49, 20)
        Me.IDText.TabIndex = 1
        '
        'LoadExistingPanel
        '
        Me.LoadExistingPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadExistingPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LoadExistingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LoadExistingPanel.Controls.Add(Me.LoadFromIDText)
        Me.LoadExistingPanel.Controls.Add(Me.LoadFromIDBtn)
        Me.LoadExistingPanel.Controls.Add(Me.Label2)
        Me.LoadExistingPanel.Location = New System.Drawing.Point(381, 5)
        Me.LoadExistingPanel.Name = "LoadExistingPanel"
        Me.LoadExistingPanel.Size = New System.Drawing.Size(131, 78)
        Me.LoadExistingPanel.TabIndex = 2
        '
        'LoadFromIDText
        '
        Me.LoadFromIDText.Location = New System.Drawing.Point(76, 53)
        Me.LoadFromIDText.Name = "LoadFromIDText"
        Me.LoadFromIDText.Size = New System.Drawing.Size(52, 20)
        Me.LoadFromIDText.TabIndex = 2
        '
        'LoadFromIDBtn
        '
        Me.LoadFromIDBtn.Location = New System.Drawing.Point(3, 51)
        Me.LoadFromIDBtn.Name = "LoadFromIDBtn"
        Me.LoadFromIDBtn.Size = New System.Drawing.Size(60, 23)
        Me.LoadFromIDBtn.TabIndex = 1
        Me.LoadFromIDBtn.Text = "Load"
        Me.LoadFromIDBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 39)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Type an employee ID" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and press Load to get" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "particular info"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Name"
        '
        'FirstNameText
        '
        Me.FirstNameText.Location = New System.Drawing.Point(71, 34)
        Me.FirstNameText.Name = "FirstNameText"
        Me.FirstNameText.Size = New System.Drawing.Size(113, 20)
        Me.FirstNameText.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Start Date"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.SurnameText)
        Me.Panel1.Controls.Add(Me.SaveBtn)
        Me.Panel1.Controls.Add(Me.StartDateBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.IDText)
        Me.Panel1.Controls.Add(Me.LoadExistingPanel)
        Me.Panel1.Controls.Add(Me.VisibleCheck)
        Me.Panel1.Controls.Add(Me.PinChangeText)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.FirstNameText)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(3, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(518, 90)
        Me.Panel1.TabIndex = 11
        '
        'SurnameText
        '
        Me.SurnameText.Location = New System.Drawing.Point(190, 34)
        Me.SurnameText.Name = "SurnameText"
        Me.SurnameText.Size = New System.Drawing.Size(108, 20)
        Me.SurnameText.TabIndex = 19
        '
        'SaveBtn
        '
        Me.SaveBtn.Location = New System.Drawing.Point(296, 57)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(75, 23)
        Me.SaveBtn.TabIndex = 18
        Me.SaveBtn.Text = "Save"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'StartDateBox
        '
        Me.StartDateBox.Location = New System.Drawing.Point(71, 56)
        Me.StartDateBox.Name = "StartDateBox"
        Me.StartDateBox.Size = New System.Drawing.Size(133, 20)
        Me.StartDateBox.TabIndex = 17
        Me.StartDateBox.Value = New Date(2016, 5, 4, 9, 0, 0, 0)
        '
        'VisibleCheck
        '
        Me.VisibleCheck.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VisibleCheck.AutoSize = True
        Me.VisibleCheck.Checked = True
        Me.VisibleCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.VisibleCheck.Location = New System.Drawing.Point(315, 35)
        Me.VisibleCheck.Name = "VisibleCheck"
        Me.VisibleCheck.Size = New System.Drawing.Size(56, 17)
        Me.VisibleCheck.TabIndex = 14
        Me.VisibleCheck.Text = "Visible"
        Me.VisibleCheck.UseVisualStyleBackColor = True
        '
        'PinChangeText
        '
        Me.PinChangeText.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PinChangeText.Location = New System.Drawing.Point(315, 8)
        Me.PinChangeText.MaxLength = 4
        Me.PinChangeText.Name = "PinChangeText"
        Me.PinChangeText.Size = New System.Drawing.Size(56, 20)
        Me.PinChangeText.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(262, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "New Pin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Primary ID info"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.DefaultRotaTable)
        Me.Panel2.Location = New System.Drawing.Point(3, 150)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(518, 99)
        Me.Panel2.TabIndex = 17
        '
        'DefaultRotaTable
        '
        Me.DefaultRotaTable.AllowUserToAddRows = False
        Me.DefaultRotaTable.AllowUserToDeleteRows = False
        Me.DefaultRotaTable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DefaultRotaTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DefaultRotaTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Saturday, Me.Sunday, Me.Monday, Me.Tuesday, Me.Wednesday, Me.Thursday, Me.Friday})
        Me.DefaultRotaTable.ContextMenuStrip = Me.RotaStateMenu
        Me.DefaultRotaTable.Location = New System.Drawing.Point(3, 3)
        Me.DefaultRotaTable.Name = "DefaultRotaTable"
        Me.DefaultRotaTable.ReadOnly = True
        Me.DefaultRotaTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DefaultRotaTable.RowHeadersWidth = 90
        Me.DefaultRotaTable.Size = New System.Drawing.Size(512, 93)
        Me.DefaultRotaTable.TabIndex = 40
        '
        'Saturday
        '
        Me.Saturday.HeaderText = "Saturday"
        Me.Saturday.Name = "Saturday"
        Me.Saturday.ReadOnly = True
        Me.Saturday.Width = 60
        '
        'Sunday
        '
        Me.Sunday.HeaderText = "Sunday"
        Me.Sunday.Name = "Sunday"
        Me.Sunday.ReadOnly = True
        Me.Sunday.Width = 60
        '
        'Monday
        '
        Me.Monday.HeaderText = "Monday"
        Me.Monday.Name = "Monday"
        Me.Monday.ReadOnly = True
        Me.Monday.Width = 60
        '
        'Tuesday
        '
        Me.Tuesday.HeaderText = "Tuesday"
        Me.Tuesday.Name = "Tuesday"
        Me.Tuesday.ReadOnly = True
        Me.Tuesday.Width = 60
        '
        'Wednesday
        '
        Me.Wednesday.HeaderText = "Wednesday"
        Me.Wednesday.Name = "Wednesday"
        Me.Wednesday.ReadOnly = True
        Me.Wednesday.Width = 60
        '
        'Thursday
        '
        Me.Thursday.HeaderText = "Thursday"
        Me.Thursday.Name = "Thursday"
        Me.Thursday.ReadOnly = True
        Me.Thursday.Width = 60
        '
        'Friday
        '
        Me.Friday.HeaderText = "Friday"
        Me.Friday.Name = "Friday"
        Me.Friday.ReadOnly = True
        Me.Friday.Width = 60
        '
        'RotaStateMenu
        '
        Me.RotaStateMenu.Name = "RotaStateMenu"
        Me.RotaStateMenu.Size = New System.Drawing.Size(61, 4)
        Me.RotaStateMenu.Text = "Rota State"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Default Rota Setup"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(220, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Click Save after changes / additions."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(220, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(235, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Table is saved automatically after every change."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(408, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EmployeeDataSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(524, 283)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EmployeeDataSet"
        Me.Text = "Employee Data"
        Me.LoadExistingPanel.ResumeLayout(False)
        Me.LoadExistingPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DefaultRotaTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents IDText As TextBox
    Friend WithEvents LoadExistingPanel As Panel
    Friend WithEvents LoadFromIDText As TextBox
    Friend WithEvents LoadFromIDBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FirstNameText As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents VisibleCheck As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PinChangeText As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents RotaStateMenu As ContextMenuStrip
    Friend WithEvents DefaultRotaTable As DataGridView
    Friend WithEvents Saturday As DataGridViewTextBoxColumn
    Friend WithEvents Sunday As DataGridViewTextBoxColumn
    Friend WithEvents Monday As DataGridViewTextBoxColumn
    Friend WithEvents Tuesday As DataGridViewTextBoxColumn
    Friend WithEvents Wednesday As DataGridViewTextBoxColumn
    Friend WithEvents Thursday As DataGridViewTextBoxColumn
    Friend WithEvents Friday As DataGridViewTextBoxColumn
    Friend WithEvents StartDateBox As DateTimePicker
    Friend WithEvents SaveBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents SurnameText As TextBox
    Friend WithEvents Button1 As Button
End Class
