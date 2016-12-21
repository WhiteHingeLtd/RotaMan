<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NeoRotaDisplay
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
        Me.RotaDisplayGrid = New System.Windows.Forms.DataGridView()
        Me.DayStateSat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DayStateSun = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DayStateMon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DayStateTue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DayStateWed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DayStateThu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DayStateFri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DayStateSat2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DayStateSun2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DayStateMon2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DayStateTue2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DayStateWed2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DayStateThu2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DayStateFri2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeToSpend = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeSpentIn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comparison = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RotaModMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LoadBtn = New System.Windows.Forms.Button()
        Me.WeekSaveButton = New System.Windows.Forms.Button()
        Me.IncreaseWeek = New System.Windows.Forms.Button()
        Me.DecreaseWeek = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateSelectionBox = New System.Windows.Forms.DateTimePicker()
        Me.FridayDate = New System.Windows.Forms.Label()
        Me.ThursdayDate = New System.Windows.Forms.Label()
        Me.WednesdayDate = New System.Windows.Forms.Label()
        Me.TuesdayDate = New System.Windows.Forms.Label()
        Me.MondayDate = New System.Windows.Forms.Label()
        Me.SundayDate = New System.Windows.Forms.Label()
        Me.SaturdayDate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Fri2Date = New System.Windows.Forms.Label()
        Me.Thu2Date = New System.Windows.Forms.Label()
        Me.Wed2Date = New System.Windows.Forms.Label()
        Me.Tue2Date = New System.Windows.Forms.Label()
        Me.Mon2Date = New System.Windows.Forms.Label()
        Me.Sun2Date = New System.Windows.Forms.Label()
        Me.Sat2Date = New System.Windows.Forms.Label()
        CType(Me.RotaDisplayGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RotaDisplayGrid
        '
        Me.RotaDisplayGrid.AllowUserToAddRows = False
        Me.RotaDisplayGrid.AllowUserToDeleteRows = False
        Me.RotaDisplayGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RotaDisplayGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RotaDisplayGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DayStateSat, Me.DayStateSun, Me.DayStateMon, Me.DayStateTue, Me.DayStateWed, Me.DayStateThu, Me.DayStateFri, Me.DayStateSat2, Me.DayStateSun2, Me.DayStateMon2, Me.DayStateTue2, Me.DayStateWed2, Me.DayStateThu2, Me.DayStateFri2, Me.TimeToSpend, Me.TimeSpentIn, Me.Comparison})
        Me.RotaDisplayGrid.ContextMenuStrip = Me.RotaModMenu
        Me.RotaDisplayGrid.Location = New System.Drawing.Point(11, 59)
        Me.RotaDisplayGrid.Name = "RotaDisplayGrid"
        Me.RotaDisplayGrid.ReadOnly = True
        Me.RotaDisplayGrid.RowHeadersWidth = 170
        Me.RotaDisplayGrid.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RotaDisplayGrid.RowTemplate.Height = 36
        Me.RotaDisplayGrid.Size = New System.Drawing.Size(1763, 533)
        Me.RotaDisplayGrid.TabIndex = 0
        '
        'DayStateSat
        '
        Me.DayStateSat.HeaderText = "Saturday      [WK 1]"
        Me.DayStateSat.Name = "DayStateSat"
        Me.DayStateSat.ReadOnly = True
        Me.DayStateSat.Width = 105
        '
        'DayStateSun
        '
        Me.DayStateSun.HeaderText = "Sunday      [WK 1]"
        Me.DayStateSun.Name = "DayStateSun"
        Me.DayStateSun.ReadOnly = True
        Me.DayStateSun.Width = 105
        '
        'DayStateMon
        '
        Me.DayStateMon.HeaderText = "Monday      [WK 1]"
        Me.DayStateMon.Name = "DayStateMon"
        Me.DayStateMon.ReadOnly = True
        Me.DayStateMon.Width = 105
        '
        'DayStateTue
        '
        Me.DayStateTue.HeaderText = "Tuesday      [WK 1]"
        Me.DayStateTue.Name = "DayStateTue"
        Me.DayStateTue.ReadOnly = True
        Me.DayStateTue.Width = 105
        '
        'DayStateWed
        '
        Me.DayStateWed.HeaderText = "Wednesday [WK 1]"
        Me.DayStateWed.Name = "DayStateWed"
        Me.DayStateWed.ReadOnly = True
        Me.DayStateWed.Width = 105
        '
        'DayStateThu
        '
        Me.DayStateThu.HeaderText = "Thursday     [WK 1]"
        Me.DayStateThu.Name = "DayStateThu"
        Me.DayStateThu.ReadOnly = True
        Me.DayStateThu.Width = 105
        '
        'DayStateFri
        '
        Me.DayStateFri.HeaderText = "Friday            [WK 1]"
        Me.DayStateFri.Name = "DayStateFri"
        Me.DayStateFri.ReadOnly = True
        Me.DayStateFri.Width = 105
        '
        'DayStateSat2
        '
        Me.DayStateSat2.HeaderText = "Saturday      [WK 2]"
        Me.DayStateSat2.Name = "DayStateSat2"
        Me.DayStateSat2.ReadOnly = True
        Me.DayStateSat2.Width = 105
        '
        'DayStateSun2
        '
        Me.DayStateSun2.HeaderText = "Sunday      [WK 2]"
        Me.DayStateSun2.Name = "DayStateSun2"
        Me.DayStateSun2.ReadOnly = True
        Me.DayStateSun2.Width = 105
        '
        'DayStateMon2
        '
        Me.DayStateMon2.HeaderText = "Monday      [WK 2]"
        Me.DayStateMon2.Name = "DayStateMon2"
        Me.DayStateMon2.ReadOnly = True
        Me.DayStateMon2.Width = 105
        '
        'DayStateTue2
        '
        Me.DayStateTue2.HeaderText = "Tuesday      [WK 2]"
        Me.DayStateTue2.Name = "DayStateTue2"
        Me.DayStateTue2.ReadOnly = True
        Me.DayStateTue2.Width = 105
        '
        'DayStateWed2
        '
        Me.DayStateWed2.HeaderText = "Wednesday [WK 2]"
        Me.DayStateWed2.Name = "DayStateWed2"
        Me.DayStateWed2.ReadOnly = True
        Me.DayStateWed2.Width = 105
        '
        'DayStateThu2
        '
        Me.DayStateThu2.HeaderText = "Thursday     [WK 2]"
        Me.DayStateThu2.Name = "DayStateThu2"
        Me.DayStateThu2.ReadOnly = True
        Me.DayStateThu2.Width = 105
        '
        'DayStateFri2
        '
        Me.DayStateFri2.HeaderText = "Friday           [WK 2]"
        Me.DayStateFri2.Name = "DayStateFri2"
        Me.DayStateFri2.ReadOnly = True
        Me.DayStateFri2.Width = 105
        '
        'TimeToSpend
        '
        Me.TimeToSpend.HeaderText = "Scheduled In"
        Me.TimeToSpend.Name = "TimeToSpend"
        Me.TimeToSpend.ReadOnly = True
        Me.TimeToSpend.Width = 50
        '
        'TimeSpentIn
        '
        Me.TimeSpentIn.HeaderText = "Recorded In"
        Me.TimeSpentIn.Name = "TimeSpentIn"
        Me.TimeSpentIn.ReadOnly = True
        Me.TimeSpentIn.Width = 50
        '
        'Comparison
        '
        Me.Comparison.HeaderText = "Expected / Recorded"
        Me.Comparison.Name = "Comparison"
        Me.Comparison.ReadOnly = True
        Me.Comparison.Width = 70
        '
        'RotaModMenu
        '
        Me.RotaModMenu.Name = "RotaModMenu"
        Me.RotaModMenu.Size = New System.Drawing.Size(61, 4)
        '
        'LoadBtn
        '
        Me.LoadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoadBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadBtn.Location = New System.Drawing.Point(595, 4)
        Me.LoadBtn.Name = "LoadBtn"
        Me.LoadBtn.Size = New System.Drawing.Size(94, 26)
        Me.LoadBtn.TabIndex = 41
        Me.LoadBtn.Text = "Load Date"
        Me.LoadBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LoadBtn.UseVisualStyleBackColor = True
        '
        'WeekSaveButton
        '
        Me.WeekSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WeekSaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeekSaveButton.Location = New System.Drawing.Point(695, 4)
        Me.WeekSaveButton.Name = "WeekSaveButton"
        Me.WeekSaveButton.Size = New System.Drawing.Size(101, 26)
        Me.WeekSaveButton.TabIndex = 40
        Me.WeekSaveButton.Text = "Save Week"
        Me.WeekSaveButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.WeekSaveButton.UseVisualStyleBackColor = True
        '
        'IncreaseWeek
        '
        Me.IncreaseWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IncreaseWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncreaseWeek.Location = New System.Drawing.Point(485, 4)
        Me.IncreaseWeek.Name = "IncreaseWeek"
        Me.IncreaseWeek.Size = New System.Drawing.Size(104, 26)
        Me.IncreaseWeek.TabIndex = 39
        Me.IncreaseWeek.Text = "2 Weeks >"
        Me.IncreaseWeek.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.IncreaseWeek.UseVisualStyleBackColor = True
        '
        'DecreaseWeek
        '
        Me.DecreaseWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DecreaseWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecreaseWeek.Location = New System.Drawing.Point(375, 4)
        Me.DecreaseWeek.Name = "DecreaseWeek"
        Me.DecreaseWeek.Size = New System.Drawing.Size(104, 26)
        Me.DecreaseWeek.TabIndex = 38
        Me.DecreaseWeek.Text = "< 2 Weeks"
        Me.DecreaseWeek.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DecreaseWeek.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 20)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Week Commencing:"
        '
        'DateSelectionBox
        '
        Me.DateSelectionBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateSelectionBox.Location = New System.Drawing.Point(169, 4)
        Me.DateSelectionBox.Name = "DateSelectionBox"
        Me.DateSelectionBox.Size = New System.Drawing.Size(200, 26)
        Me.DateSelectionBox.TabIndex = 36
        '
        'FridayDate
        '
        Me.FridayDate.AutoSize = True
        Me.FridayDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FridayDate.Location = New System.Drawing.Point(816, 40)
        Me.FridayDate.Name = "FridayDate"
        Me.FridayDate.Size = New System.Drawing.Size(67, 13)
        Me.FridayDate.TabIndex = 56
        Me.FridayDate.Text = "dd/MM/yyyy"
        '
        'ThursdayDate
        '
        Me.ThursdayDate.AutoSize = True
        Me.ThursdayDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThursdayDate.Location = New System.Drawing.Point(711, 40)
        Me.ThursdayDate.Name = "ThursdayDate"
        Me.ThursdayDate.Size = New System.Drawing.Size(67, 13)
        Me.ThursdayDate.TabIndex = 55
        Me.ThursdayDate.Text = "dd/MM/yyyy"
        '
        'WednesdayDate
        '
        Me.WednesdayDate.AutoSize = True
        Me.WednesdayDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WednesdayDate.Location = New System.Drawing.Point(606, 40)
        Me.WednesdayDate.Name = "WednesdayDate"
        Me.WednesdayDate.Size = New System.Drawing.Size(67, 13)
        Me.WednesdayDate.TabIndex = 54
        Me.WednesdayDate.Text = "dd/MM/yyyy"
        '
        'TuesdayDate
        '
        Me.TuesdayDate.AutoSize = True
        Me.TuesdayDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TuesdayDate.Location = New System.Drawing.Point(501, 40)
        Me.TuesdayDate.Name = "TuesdayDate"
        Me.TuesdayDate.Size = New System.Drawing.Size(67, 13)
        Me.TuesdayDate.TabIndex = 53
        Me.TuesdayDate.Text = "dd/MM/yyyy"
        '
        'MondayDate
        '
        Me.MondayDate.AutoSize = True
        Me.MondayDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MondayDate.Location = New System.Drawing.Point(397, 40)
        Me.MondayDate.Name = "MondayDate"
        Me.MondayDate.Size = New System.Drawing.Size(67, 13)
        Me.MondayDate.TabIndex = 52
        Me.MondayDate.Text = "dd/MM/yyyy"
        '
        'SundayDate
        '
        Me.SundayDate.AutoSize = True
        Me.SundayDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SundayDate.Location = New System.Drawing.Point(291, 40)
        Me.SundayDate.Name = "SundayDate"
        Me.SundayDate.Size = New System.Drawing.Size(67, 13)
        Me.SundayDate.TabIndex = 51
        Me.SundayDate.Text = "dd/MM/yyyy"
        '
        'SaturdayDate
        '
        Me.SaturdayDate.AutoSize = True
        Me.SaturdayDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaturdayDate.Location = New System.Drawing.Point(185, 40)
        Me.SaturdayDate.Name = "SaturdayDate"
        Me.SaturdayDate.Size = New System.Drawing.Size(67, 13)
        Me.SaturdayDate.TabIndex = 50
        Me.SaturdayDate.Text = "dd/MM/yyyy"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Employee"
        '
        'Fri2Date
        '
        Me.Fri2Date.AutoSize = True
        Me.Fri2Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fri2Date.Location = New System.Drawing.Point(1549, 40)
        Me.Fri2Date.Name = "Fri2Date"
        Me.Fri2Date.Size = New System.Drawing.Size(67, 13)
        Me.Fri2Date.TabIndex = 63
        Me.Fri2Date.Text = "dd/MM/yyyy"
        '
        'Thu2Date
        '
        Me.Thu2Date.AutoSize = True
        Me.Thu2Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Thu2Date.Location = New System.Drawing.Point(1444, 40)
        Me.Thu2Date.Name = "Thu2Date"
        Me.Thu2Date.Size = New System.Drawing.Size(67, 13)
        Me.Thu2Date.TabIndex = 62
        Me.Thu2Date.Text = "dd/MM/yyyy"
        '
        'Wed2Date
        '
        Me.Wed2Date.AutoSize = True
        Me.Wed2Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wed2Date.Location = New System.Drawing.Point(1339, 40)
        Me.Wed2Date.Name = "Wed2Date"
        Me.Wed2Date.Size = New System.Drawing.Size(67, 13)
        Me.Wed2Date.TabIndex = 61
        Me.Wed2Date.Text = "dd/MM/yyyy"
        '
        'Tue2Date
        '
        Me.Tue2Date.AutoSize = True
        Me.Tue2Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tue2Date.Location = New System.Drawing.Point(1236, 40)
        Me.Tue2Date.Name = "Tue2Date"
        Me.Tue2Date.Size = New System.Drawing.Size(67, 13)
        Me.Tue2Date.TabIndex = 60
        Me.Tue2Date.Text = "dd/MM/yyyy"
        '
        'Mon2Date
        '
        Me.Mon2Date.AutoSize = True
        Me.Mon2Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mon2Date.Location = New System.Drawing.Point(1131, 40)
        Me.Mon2Date.Name = "Mon2Date"
        Me.Mon2Date.Size = New System.Drawing.Size(67, 13)
        Me.Mon2Date.TabIndex = 59
        Me.Mon2Date.Text = "dd/MM/yyyy"
        '
        'Sun2Date
        '
        Me.Sun2Date.AutoSize = True
        Me.Sun2Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sun2Date.Location = New System.Drawing.Point(1026, 40)
        Me.Sun2Date.Name = "Sun2Date"
        Me.Sun2Date.Size = New System.Drawing.Size(67, 13)
        Me.Sun2Date.TabIndex = 58
        Me.Sun2Date.Text = "dd/MM/yyyy"
        '
        'Sat2Date
        '
        Me.Sat2Date.AutoSize = True
        Me.Sat2Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sat2Date.Location = New System.Drawing.Point(921, 40)
        Me.Sat2Date.Name = "Sat2Date"
        Me.Sat2Date.Size = New System.Drawing.Size(67, 13)
        Me.Sat2Date.TabIndex = 57
        Me.Sat2Date.Text = "dd/MM/yyyy"
        '
        'NeoRotaDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1786, 604)
        Me.Controls.Add(Me.Fri2Date)
        Me.Controls.Add(Me.Thu2Date)
        Me.Controls.Add(Me.Wed2Date)
        Me.Controls.Add(Me.Tue2Date)
        Me.Controls.Add(Me.Mon2Date)
        Me.Controls.Add(Me.Sun2Date)
        Me.Controls.Add(Me.Sat2Date)
        Me.Controls.Add(Me.FridayDate)
        Me.Controls.Add(Me.ThursdayDate)
        Me.Controls.Add(Me.WednesdayDate)
        Me.Controls.Add(Me.TuesdayDate)
        Me.Controls.Add(Me.MondayDate)
        Me.Controls.Add(Me.SundayDate)
        Me.Controls.Add(Me.SaturdayDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LoadBtn)
        Me.Controls.Add(Me.WeekSaveButton)
        Me.Controls.Add(Me.IncreaseWeek)
        Me.Controls.Add(Me.DecreaseWeek)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateSelectionBox)
        Me.Controls.Add(Me.RotaDisplayGrid)
        Me.Name = "NeoRotaDisplay"
        Me.Text = "Rota Display"
        CType(Me.RotaDisplayGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RotaDisplayGrid As DataGridView
    Friend WithEvents LoadBtn As Button
    Friend WithEvents WeekSaveButton As Button
    Friend WithEvents IncreaseWeek As Button
    Friend WithEvents DecreaseWeek As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DateSelectionBox As DateTimePicker
    Friend WithEvents FridayDate As Label
    Friend WithEvents ThursdayDate As Label
    Friend WithEvents WednesdayDate As Label
    Friend WithEvents TuesdayDate As Label
    Friend WithEvents MondayDate As Label
    Friend WithEvents SundayDate As Label
    Friend WithEvents SaturdayDate As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Fri2Date As Label
    Friend WithEvents Thu2Date As Label
    Friend WithEvents Wed2Date As Label
    Friend WithEvents Tue2Date As Label
    Friend WithEvents Mon2Date As Label
    Friend WithEvents Sun2Date As Label
    Friend WithEvents Sat2Date As Label
    Friend WithEvents DayStateSat As DataGridViewTextBoxColumn
    Friend WithEvents DayStateSun As DataGridViewTextBoxColumn
    Friend WithEvents DayStateMon As DataGridViewTextBoxColumn
    Friend WithEvents DayStateTue As DataGridViewTextBoxColumn
    Friend WithEvents DayStateWed As DataGridViewTextBoxColumn
    Friend WithEvents DayStateThu As DataGridViewTextBoxColumn
    Friend WithEvents DayStateFri As DataGridViewTextBoxColumn
    Friend WithEvents DayStateSat2 As DataGridViewTextBoxColumn
    Friend WithEvents DayStateSun2 As DataGridViewTextBoxColumn
    Friend WithEvents DayStateMon2 As DataGridViewTextBoxColumn
    Friend WithEvents DayStateTue2 As DataGridViewTextBoxColumn
    Friend WithEvents DayStateWed2 As DataGridViewTextBoxColumn
    Friend WithEvents DayStateThu2 As DataGridViewTextBoxColumn
    Friend WithEvents DayStateFri2 As DataGridViewTextBoxColumn
    Friend WithEvents TimeToSpend As DataGridViewTextBoxColumn
    Friend WithEvents TimeSpentIn As DataGridViewTextBoxColumn
    Friend WithEvents Comparison As DataGridViewTextBoxColumn
    Friend WithEvents RotaModMenu As ContextMenuStrip
End Class
