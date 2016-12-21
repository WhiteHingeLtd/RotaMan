<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainRotaDisplay
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainRotaDisplay))
        Me.DateSelectionBox = New System.Windows.Forms.DateTimePicker()
        Me.RotaZone = New System.Windows.Forms.FlowLayoutPanel()
        Me.RotaWeekPersonControl1 = New Rota_Display.RotaWeekPersonControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DecreaseWeek = New System.Windows.Forms.Button()
        Me.IncreaseWeek = New System.Windows.Forms.Button()
        Me.WeekSaveButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FridayDate = New System.Windows.Forms.Label()
        Me.ThursdayDate = New System.Windows.Forms.Label()
        Me.WednesdayDate = New System.Windows.Forms.Label()
        Me.TuesdayDate = New System.Windows.Forms.Label()
        Me.MondayDate = New System.Windows.Forms.Label()
        Me.SundayDate = New System.Windows.Forms.Label()
        Me.SaturdayDate = New System.Windows.Forms.Label()
        Me.Fri2Date = New System.Windows.Forms.Label()
        Me.Thu2Date = New System.Windows.Forms.Label()
        Me.Wed2Date = New System.Windows.Forms.Label()
        Me.Tue2Date = New System.Windows.Forms.Label()
        Me.Mon2Date = New System.Windows.Forms.Label()
        Me.Sun2Date = New System.Windows.Forms.Label()
        Me.Sat2Date = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.LoadBtn = New System.Windows.Forms.Button()
        Me.RotaZone.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateSelectionBox
        '
        Me.DateSelectionBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateSelectionBox.Location = New System.Drawing.Point(169, 12)
        Me.DateSelectionBox.Name = "DateSelectionBox"
        Me.DateSelectionBox.Size = New System.Drawing.Size(200, 26)
        Me.DateSelectionBox.TabIndex = 0
        '
        'RotaZone
        '
        Me.RotaZone.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RotaZone.AutoScroll = True
        Me.RotaZone.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.RotaZone.Controls.Add(Me.RotaWeekPersonControl1)
        Me.RotaZone.Location = New System.Drawing.Point(12, 117)
        Me.RotaZone.Name = "RotaZone"
        Me.RotaZone.Size = New System.Drawing.Size(1779, 475)
        Me.RotaZone.TabIndex = 1
        '
        'RotaWeekPersonControl1
        '
        Me.RotaWeekPersonControl1.ActiveWeek = Nothing
        Me.RotaWeekPersonControl1.Employee = Nothing
        Me.RotaWeekPersonControl1.Location = New System.Drawing.Point(3, 3)
        Me.RotaWeekPersonControl1.Name = "RotaWeekPersonControl1"
        Me.RotaWeekPersonControl1.Size = New System.Drawing.Size(1765, 105)
        Me.RotaWeekPersonControl1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Week Commencing:"
        '
        'DecreaseWeek
        '
        Me.DecreaseWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecreaseWeek.Location = New System.Drawing.Point(375, 12)
        Me.DecreaseWeek.Name = "DecreaseWeek"
        Me.DecreaseWeek.Size = New System.Drawing.Size(75, 26)
        Me.DecreaseWeek.TabIndex = 3
        Me.DecreaseWeek.Text = "< Week"
        Me.DecreaseWeek.UseVisualStyleBackColor = True
        '
        'IncreaseWeek
        '
        Me.IncreaseWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncreaseWeek.Location = New System.Drawing.Point(456, 12)
        Me.IncreaseWeek.Name = "IncreaseWeek"
        Me.IncreaseWeek.Size = New System.Drawing.Size(75, 26)
        Me.IncreaseWeek.TabIndex = 4
        Me.IncreaseWeek.Text = "Week >"
        Me.IncreaseWeek.UseVisualStyleBackColor = True
        '
        'WeekSaveButton
        '
        Me.WeekSaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WeekSaveButton.Location = New System.Drawing.Point(637, 12)
        Me.WeekSaveButton.Name = "WeekSaveButton"
        Me.WeekSaveButton.Size = New System.Drawing.Size(101, 26)
        Me.WeekSaveButton.TabIndex = 5
        Me.WeekSaveButton.Text = "Save Week"
        Me.WeekSaveButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Employee"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(176, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Saturday"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(286, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Sunday"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(392, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Monday"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(490, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tuesday"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(587, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Wednesday"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(703, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Thursday"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(816, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Friday"
        '
        'FridayDate
        '
        Me.FridayDate.AutoSize = True
        Me.FridayDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FridayDate.Location = New System.Drawing.Point(811, 67)
        Me.FridayDate.Name = "FridayDate"
        Me.FridayDate.Size = New System.Drawing.Size(67, 13)
        Me.FridayDate.TabIndex = 20
        Me.FridayDate.Text = "dd/MM/yyyy"
        '
        'ThursdayDate
        '
        Me.ThursdayDate.AutoSize = True
        Me.ThursdayDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThursdayDate.Location = New System.Drawing.Point(710, 67)
        Me.ThursdayDate.Name = "ThursdayDate"
        Me.ThursdayDate.Size = New System.Drawing.Size(67, 13)
        Me.ThursdayDate.TabIndex = 19
        Me.ThursdayDate.Text = "dd/MM/yyyy"
        '
        'WednesdayDate
        '
        Me.WednesdayDate.AutoSize = True
        Me.WednesdayDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WednesdayDate.Location = New System.Drawing.Point(601, 67)
        Me.WednesdayDate.Name = "WednesdayDate"
        Me.WednesdayDate.Size = New System.Drawing.Size(67, 13)
        Me.WednesdayDate.TabIndex = 18
        Me.WednesdayDate.Text = "dd/MM/yyyy"
        '
        'TuesdayDate
        '
        Me.TuesdayDate.AutoSize = True
        Me.TuesdayDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TuesdayDate.Location = New System.Drawing.Point(497, 67)
        Me.TuesdayDate.Name = "TuesdayDate"
        Me.TuesdayDate.Size = New System.Drawing.Size(67, 13)
        Me.TuesdayDate.TabIndex = 17
        Me.TuesdayDate.Text = "dd/MM/yyyy"
        '
        'MondayDate
        '
        Me.MondayDate.AutoSize = True
        Me.MondayDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MondayDate.Location = New System.Drawing.Point(394, 67)
        Me.MondayDate.Name = "MondayDate"
        Me.MondayDate.Size = New System.Drawing.Size(67, 13)
        Me.MondayDate.TabIndex = 16
        Me.MondayDate.Text = "dd/MM/yyyy"
        '
        'SundayDate
        '
        Me.SundayDate.AutoSize = True
        Me.SundayDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SundayDate.Location = New System.Drawing.Point(288, 67)
        Me.SundayDate.Name = "SundayDate"
        Me.SundayDate.Size = New System.Drawing.Size(67, 13)
        Me.SundayDate.TabIndex = 15
        Me.SundayDate.Text = "dd/MM/yyyy"
        '
        'SaturdayDate
        '
        Me.SaturdayDate.AutoSize = True
        Me.SaturdayDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaturdayDate.Location = New System.Drawing.Point(183, 67)
        Me.SaturdayDate.Name = "SaturdayDate"
        Me.SaturdayDate.Size = New System.Drawing.Size(67, 13)
        Me.SaturdayDate.TabIndex = 14
        Me.SaturdayDate.Text = "dd/MM/yyyy"
        '
        'Fri2Date
        '
        Me.Fri2Date.AutoSize = True
        Me.Fri2Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fri2Date.Location = New System.Drawing.Point(1603, 67)
        Me.Fri2Date.Name = "Fri2Date"
        Me.Fri2Date.Size = New System.Drawing.Size(67, 13)
        Me.Fri2Date.TabIndex = 34
        Me.Fri2Date.Text = "dd/MM/yyyy"
        '
        'Thu2Date
        '
        Me.Thu2Date.AutoSize = True
        Me.Thu2Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Thu2Date.Location = New System.Drawing.Point(1502, 67)
        Me.Thu2Date.Name = "Thu2Date"
        Me.Thu2Date.Size = New System.Drawing.Size(67, 13)
        Me.Thu2Date.TabIndex = 33
        Me.Thu2Date.Text = "dd/MM/yyyy"
        '
        'Wed2Date
        '
        Me.Wed2Date.AutoSize = True
        Me.Wed2Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wed2Date.Location = New System.Drawing.Point(1393, 67)
        Me.Wed2Date.Name = "Wed2Date"
        Me.Wed2Date.Size = New System.Drawing.Size(67, 13)
        Me.Wed2Date.TabIndex = 32
        Me.Wed2Date.Text = "dd/MM/yyyy"
        '
        'Tue2Date
        '
        Me.Tue2Date.AutoSize = True
        Me.Tue2Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tue2Date.Location = New System.Drawing.Point(1289, 67)
        Me.Tue2Date.Name = "Tue2Date"
        Me.Tue2Date.Size = New System.Drawing.Size(67, 13)
        Me.Tue2Date.TabIndex = 31
        Me.Tue2Date.Text = "dd/MM/yyyy"
        '
        'Mon2Date
        '
        Me.Mon2Date.AutoSize = True
        Me.Mon2Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mon2Date.Location = New System.Drawing.Point(1186, 67)
        Me.Mon2Date.Name = "Mon2Date"
        Me.Mon2Date.Size = New System.Drawing.Size(67, 13)
        Me.Mon2Date.TabIndex = 30
        Me.Mon2Date.Text = "dd/MM/yyyy"
        '
        'Sun2Date
        '
        Me.Sun2Date.AutoSize = True
        Me.Sun2Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sun2Date.Location = New System.Drawing.Point(1080, 67)
        Me.Sun2Date.Name = "Sun2Date"
        Me.Sun2Date.Size = New System.Drawing.Size(67, 13)
        Me.Sun2Date.TabIndex = 29
        Me.Sun2Date.Text = "dd/MM/yyyy"
        '
        'Sat2Date
        '
        Me.Sat2Date.AutoSize = True
        Me.Sat2Date.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sat2Date.Location = New System.Drawing.Point(975, 67)
        Me.Sat2Date.Name = "Sat2Date"
        Me.Sat2Date.Size = New System.Drawing.Size(67, 13)
        Me.Sat2Date.TabIndex = 28
        Me.Sat2Date.Text = "dd/MM/yyyy"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(1608, 80)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 20)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "Friday"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(1495, 80)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 20)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "Thursday"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(1379, 80)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(102, 20)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Wednesday"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(1282, 80)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(76, 20)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "Tuesday"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(1184, 80)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(71, 20)
        Me.Label21.TabIndex = 23
        Me.Label21.Text = "Monday"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(1078, 80)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(69, 20)
        Me.Label22.TabIndex = 22
        Me.Label22.Text = "Sunday"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(968, 80)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(81, 20)
        Me.Label23.TabIndex = 21
        Me.Label23.Text = "Saturday"
        '
        'LoadBtn
        '
        Me.LoadBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadBtn.Location = New System.Drawing.Point(537, 12)
        Me.LoadBtn.Name = "LoadBtn"
        Me.LoadBtn.Size = New System.Drawing.Size(94, 26)
        Me.LoadBtn.TabIndex = 35
        Me.LoadBtn.Text = "Load Date"
        Me.LoadBtn.UseVisualStyleBackColor = True
        '
        'MainRotaDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1802, 604)
        Me.Controls.Add(Me.LoadBtn)
        Me.Controls.Add(Me.Fri2Date)
        Me.Controls.Add(Me.Thu2Date)
        Me.Controls.Add(Me.Wed2Date)
        Me.Controls.Add(Me.Tue2Date)
        Me.Controls.Add(Me.Mon2Date)
        Me.Controls.Add(Me.Sun2Date)
        Me.Controls.Add(Me.Sat2Date)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.FridayDate)
        Me.Controls.Add(Me.ThursdayDate)
        Me.Controls.Add(Me.WednesdayDate)
        Me.Controls.Add(Me.TuesdayDate)
        Me.Controls.Add(Me.MondayDate)
        Me.Controls.Add(Me.SundayDate)
        Me.Controls.Add(Me.SaturdayDate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.WeekSaveButton)
        Me.Controls.Add(Me.IncreaseWeek)
        Me.Controls.Add(Me.DecreaseWeek)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RotaZone)
        Me.Controls.Add(Me.DateSelectionBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainRotaDisplay"
        Me.Text = "MainRotaDisplay"
        Me.RotaZone.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateSelectionBox As DateTimePicker
    Friend WithEvents RotaZone As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents DecreaseWeek As Button
    Friend WithEvents IncreaseWeek As Button
    Friend WithEvents WeekSaveButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents FridayDate As Label
    Friend WithEvents ThursdayDate As Label
    Friend WithEvents WednesdayDate As Label
    Friend WithEvents TuesdayDate As Label
    Friend WithEvents MondayDate As Label
    Friend WithEvents SundayDate As Label
    Friend WithEvents SaturdayDate As Label
    Friend WithEvents RotaWeekPersonControl1 As RotaWeekPersonControl
    Friend WithEvents Fri2Date As Label
    Friend WithEvents Thu2Date As Label
    Friend WithEvents Wed2Date As Label
    Friend WithEvents Tue2Date As Label
    Friend WithEvents Mon2Date As Label
    Friend WithEvents Sun2Date As Label
    Friend WithEvents Sat2Date As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents LoadBtn As Button
End Class
