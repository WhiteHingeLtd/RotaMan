<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RotaManagerMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RotaManagerMenu))
        Me.ApplyButton = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.TabPageEmployees = New System.Windows.Forms.TabPage()
        Me.EmployeeListContainer = New System.Windows.Forms.GroupBox()
        Me.EmployeeListLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.EmployeeListGrid = New System.Windows.Forms.DataGridView()
        Me.NameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeListDeleteButton = New System.Windows.Forms.Button()
        Me.EmployeeListEditButton = New System.Windows.Forms.Button()
        Me.EmployeeListAddButton = New System.Windows.Forms.Button()
        Me.VisitorGroupBox = New System.Windows.Forms.GroupBox()
        Me.VisitorsLabel = New System.Windows.Forms.Label()
        Me.VisitorPictureBox = New System.Windows.Forms.PictureBox()
        Me.ManageVisitorsButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EditEmpBtn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.NewEmpBtn = New System.Windows.Forms.Button()
        Me.BasicLabel1 = New System.Windows.Forms.Label()
        Me.BasicLabel2 = New System.Windows.Forms.Label()
        Me.BasicLabel3 = New System.Windows.Forms.Label()
        Me.BasicLabel4 = New System.Windows.Forms.Label()
        Me.ReportsButton = New System.Windows.Forms.Button()
        Me.RequestsButton = New System.Windows.Forms.Button()
        Me.TabPageRota = New System.Windows.Forms.TabPage()
        Me.GroupBoxWeekly = New System.Windows.Forms.GroupBox()
        Me.WeekInfo = New System.Windows.Forms.Label()
        Me.PictureBoxWeeklyRota = New System.Windows.Forms.PictureBox()
        Me.WeekRotaButton = New System.Windows.Forms.Button()
        Me.NewRotaBtn = New System.Windows.Forms.Button()
        Me.GroupBoxModified = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBoxModifiedEnts = New System.Windows.Forms.PictureBox()
        Me.ModLogButton = New System.Windows.Forms.Button()
        Me.GroupBoxDefault = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBoxDefaultRota = New System.Windows.Forms.PictureBox()
        Me.DefaultRotaButton = New System.Windows.Forms.Button()
        Me.TabControlMain = New System.Windows.Forms.TabControl()
        Me.TabPageEmployees.SuspendLayout()
        Me.EmployeeListContainer.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeListGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VisitorGroupBox.SuspendLayout()
        CType(Me.VisitorPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageRota.SuspendLayout()
        Me.GroupBoxWeekly.SuspendLayout()
        CType(Me.PictureBoxWeeklyRota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxModified.SuspendLayout()
        CType(Me.PictureBoxModifiedEnts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxDefault.SuspendLayout()
        CType(Me.PictureBoxDefaultRota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'ApplyButton
        '
        Me.ApplyButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ApplyButton.Enabled = False
        Me.ApplyButton.Location = New System.Drawing.Point(287, 399)
        Me.ApplyButton.Name = "ApplyButton"
        Me.ApplyButton.Size = New System.Drawing.Size(75, 23)
        Me.ApplyButton.TabIndex = 1
        Me.ApplyButton.Text = "Apply"
        Me.ApplyButton.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelBtn.Location = New System.Drawing.Point(206, 399)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBtn.TabIndex = 2
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.Location = New System.Drawing.Point(125, 399)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 3
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'TabPageEmployees
        '
        Me.TabPageEmployees.AutoScroll = True
        Me.TabPageEmployees.BackColor = System.Drawing.Color.White
        Me.TabPageEmployees.Controls.Add(Me.GroupBox1)
        Me.TabPageEmployees.Controls.Add(Me.VisitorGroupBox)
        Me.TabPageEmployees.Controls.Add(Me.EmployeeListContainer)
        Me.TabPageEmployees.Location = New System.Drawing.Point(4, 22)
        Me.TabPageEmployees.Name = "TabPageEmployees"
        Me.TabPageEmployees.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageEmployees.Size = New System.Drawing.Size(342, 349)
        Me.TabPageEmployees.TabIndex = 2
        Me.TabPageEmployees.Text = "Employees"
        '
        'EmployeeListContainer
        '
        Me.EmployeeListContainer.Controls.Add(Me.EmployeeListAddButton)
        Me.EmployeeListContainer.Controls.Add(Me.EmployeeListEditButton)
        Me.EmployeeListContainer.Controls.Add(Me.EmployeeListDeleteButton)
        Me.EmployeeListContainer.Controls.Add(Me.EmployeeListGrid)
        Me.EmployeeListContainer.Controls.Add(Me.PictureBox1)
        Me.EmployeeListContainer.Controls.Add(Me.EmployeeListLabel)
        Me.EmployeeListContainer.Location = New System.Drawing.Point(3, 6)
        Me.EmployeeListContainer.Name = "EmployeeListContainer"
        Me.EmployeeListContainer.Size = New System.Drawing.Size(321, 232)
        Me.EmployeeListContainer.TabIndex = 1
        Me.EmployeeListContainer.TabStop = False
        Me.EmployeeListContainer.Text = "Employee List"
        '
        'EmployeeListLabel
        '
        Me.EmployeeListLabel.AutoSize = True
        Me.EmployeeListLabel.Location = New System.Drawing.Point(55, 19)
        Me.EmployeeListLabel.Name = "EmployeeListLabel"
        Me.EmployeeListLabel.Size = New System.Drawing.Size(264, 39)
        Me.EmployeeListLabel.TabIndex = 0
        Me.EmployeeListLabel.Text = "Employee List enables you to view and edit data about" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "an employee. To edit an en" &
    "try, just select it and press" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "edit."
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(43, 41)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'EmployeeListGrid
        '
        Me.EmployeeListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeListGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDCol, Me.NameCol})
        Me.EmployeeListGrid.Location = New System.Drawing.Point(6, 66)
        Me.EmployeeListGrid.Name = "EmployeeListGrid"
        Me.EmployeeListGrid.Size = New System.Drawing.Size(307, 120)
        Me.EmployeeListGrid.TabIndex = 2
        '
        'NameCol
        '
        Me.NameCol.HeaderText = "Name"
        Me.NameCol.Name = "NameCol"
        Me.NameCol.Width = 300
        '
        'IDCol
        '
        Me.IDCol.HeaderText = "ID"
        Me.IDCol.Name = "IDCol"
        Me.IDCol.Width = 50
        '
        'EmployeeListDeleteButton
        '
        Me.EmployeeListDeleteButton.Enabled = False
        Me.EmployeeListDeleteButton.Location = New System.Drawing.Point(238, 203)
        Me.EmployeeListDeleteButton.Name = "EmployeeListDeleteButton"
        Me.EmployeeListDeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.EmployeeListDeleteButton.TabIndex = 3
        Me.EmployeeListDeleteButton.Text = "Delete"
        Me.EmployeeListDeleteButton.UseVisualStyleBackColor = True
        '
        'EmployeeListEditButton
        '
        Me.EmployeeListEditButton.Enabled = False
        Me.EmployeeListEditButton.Location = New System.Drawing.Point(157, 203)
        Me.EmployeeListEditButton.Name = "EmployeeListEditButton"
        Me.EmployeeListEditButton.Size = New System.Drawing.Size(75, 23)
        Me.EmployeeListEditButton.TabIndex = 4
        Me.EmployeeListEditButton.Text = "Edit"
        Me.EmployeeListEditButton.UseVisualStyleBackColor = True
        '
        'EmployeeListAddButton
        '
        Me.EmployeeListAddButton.Enabled = False
        Me.EmployeeListAddButton.Location = New System.Drawing.Point(76, 203)
        Me.EmployeeListAddButton.Name = "EmployeeListAddButton"
        Me.EmployeeListAddButton.Size = New System.Drawing.Size(75, 23)
        Me.EmployeeListAddButton.TabIndex = 5
        Me.EmployeeListAddButton.Text = "Add"
        Me.EmployeeListAddButton.UseVisualStyleBackColor = True
        '
        'VisitorGroupBox
        '
        Me.VisitorGroupBox.Controls.Add(Me.ManageVisitorsButton)
        Me.VisitorGroupBox.Controls.Add(Me.VisitorPictureBox)
        Me.VisitorGroupBox.Controls.Add(Me.VisitorsLabel)
        Me.VisitorGroupBox.Location = New System.Drawing.Point(3, 244)
        Me.VisitorGroupBox.Name = "VisitorGroupBox"
        Me.VisitorGroupBox.Size = New System.Drawing.Size(321, 105)
        Me.VisitorGroupBox.TabIndex = 2
        Me.VisitorGroupBox.TabStop = False
        Me.VisitorGroupBox.Text = "Visitors"
        '
        'VisitorsLabel
        '
        Me.VisitorsLabel.AutoSize = True
        Me.VisitorsLabel.Location = New System.Drawing.Point(55, 19)
        Me.VisitorsLabel.Name = "VisitorsLabel"
        Me.VisitorsLabel.Size = New System.Drawing.Size(247, 52)
        Me.VisitorsLabel.TabIndex = 6
        Me.VisitorsLabel.Text = "Visitors are recognised as special employees which" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "can be spotted as employees w" &
    "ith no permissions" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and with the visitor flag. Visitors ID cards are also" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "diffe" &
    "rent to standard ones."
        '
        'VisitorPictureBox
        '
        Me.VisitorPictureBox.Location = New System.Drawing.Point(6, 19)
        Me.VisitorPictureBox.Name = "VisitorPictureBox"
        Me.VisitorPictureBox.Size = New System.Drawing.Size(43, 41)
        Me.VisitorPictureBox.TabIndex = 7
        Me.VisitorPictureBox.TabStop = False
        '
        'ManageVisitorsButton
        '
        Me.ManageVisitorsButton.Location = New System.Drawing.Point(173, 74)
        Me.ManageVisitorsButton.Name = "ManageVisitorsButton"
        Me.ManageVisitorsButton.Size = New System.Drawing.Size(140, 23)
        Me.ManageVisitorsButton.TabIndex = 8
        Me.ManageVisitorsButton.Text = "Manage Visitors"
        Me.ManageVisitorsButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NewEmpBtn)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.EditEmpBtn)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 355)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 101)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit Employee Data"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(251, 52)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "The old default rota has been removed in favour of" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the ability to edit / add emp" &
    "loyee data through" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "another method. From here, edit existing employees," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "or add " &
    "new ones."
        '
        'EditEmpBtn
        '
        Me.EditEmpBtn.Location = New System.Drawing.Point(80, 71)
        Me.EditEmpBtn.Name = "EditEmpBtn"
        Me.EditEmpBtn.Size = New System.Drawing.Size(100, 23)
        Me.EditEmpBtn.TabIndex = 7
        Me.EditEmpBtn.Text = "Edit Employee"
        Me.EditEmpBtn.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(6, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(43, 41)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'NewEmpBtn
        '
        Me.NewEmpBtn.Location = New System.Drawing.Point(205, 71)
        Me.NewEmpBtn.Name = "NewEmpBtn"
        Me.NewEmpBtn.Size = New System.Drawing.Size(105, 23)
        Me.NewEmpBtn.TabIndex = 8
        Me.NewEmpBtn.Text = "New Employee"
        Me.NewEmpBtn.UseVisualStyleBackColor = True
        '
        'BasicLabel1
        '
        Me.BasicLabel1.AutoSize = True
        Me.BasicLabel1.Location = New System.Drawing.Point(6, 135)
        Me.BasicLabel1.Name = "BasicLabel1"
        Me.BasicLabel1.Size = New System.Drawing.Size(311, 26)
        Me.BasicLabel1.TabIndex = 6
        Me.BasicLabel1.Text = "Generally, the two above figures should be fairly similar for a fairly" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "even spre" &
    "ad of holidays over the year."
        '
        'BasicLabel2
        '
        Me.BasicLabel2.AutoSize = True
        Me.BasicLabel2.Location = New System.Drawing.Point(6, 172)
        Me.BasicLabel2.Name = "BasicLabel2"
        Me.BasicLabel2.Size = New System.Drawing.Size(212, 39)
        Me.BasicLabel2.TabIndex = 7
        Me.BasicLabel2.Text = "To view how many holidays each employee" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "has used, and edit their entitlements, c" &
    "lick" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Holiday Settings."
        '
        'BasicLabel3
        '
        Me.BasicLabel3.AutoSize = True
        Me.BasicLabel3.Location = New System.Drawing.Point(6, 224)
        Me.BasicLabel3.Name = "BasicLabel3"
        Me.BasicLabel3.Size = New System.Drawing.Size(204, 26)
        Me.BasicLabel3.TabIndex = 8
        Me.BasicLabel3.Text = "If you want to print a report of the holidays" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "this year, click Reports."
        '
        'BasicLabel4
        '
        Me.BasicLabel4.AutoSize = True
        Me.BasicLabel4.Location = New System.Drawing.Point(6, 278)
        Me.BasicLabel4.Name = "BasicLabel4"
        Me.BasicLabel4.Size = New System.Drawing.Size(220, 26)
        Me.BasicLabel4.TabIndex = 9
        Me.BasicLabel4.Text = "To accept or reject holiday applications, click" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Requests."
        '
        'ReportsButton
        '
        Me.ReportsButton.Enabled = False
        Me.ReportsButton.Location = New System.Drawing.Point(238, 224)
        Me.ReportsButton.Name = "ReportsButton"
        Me.ReportsButton.Size = New System.Drawing.Size(91, 23)
        Me.ReportsButton.TabIndex = 11
        Me.ReportsButton.Text = "Reports..."
        Me.ReportsButton.UseVisualStyleBackColor = True
        '
        'RequestsButton
        '
        Me.RequestsButton.Location = New System.Drawing.Point(238, 278)
        Me.RequestsButton.Name = "RequestsButton"
        Me.RequestsButton.Size = New System.Drawing.Size(91, 23)
        Me.RequestsButton.TabIndex = 12
        Me.RequestsButton.Text = "Requests..."
        Me.RequestsButton.UseVisualStyleBackColor = True
        '
        'TabPageRota
        '
        Me.TabPageRota.AutoScroll = True
        Me.TabPageRota.BackColor = System.Drawing.Color.White
        Me.TabPageRota.Controls.Add(Me.GroupBoxDefault)
        Me.TabPageRota.Controls.Add(Me.GroupBoxModified)
        Me.TabPageRota.Controls.Add(Me.GroupBoxWeekly)
        Me.TabPageRota.Location = New System.Drawing.Point(4, 22)
        Me.TabPageRota.Name = "TabPageRota"
        Me.TabPageRota.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageRota.Size = New System.Drawing.Size(342, 349)
        Me.TabPageRota.TabIndex = 0
        Me.TabPageRota.Text = "Rota"
        '
        'GroupBoxWeekly
        '
        Me.GroupBoxWeekly.Controls.Add(Me.NewRotaBtn)
        Me.GroupBoxWeekly.Controls.Add(Me.WeekRotaButton)
        Me.GroupBoxWeekly.Controls.Add(Me.PictureBoxWeeklyRota)
        Me.GroupBoxWeekly.Controls.Add(Me.WeekInfo)
        Me.GroupBoxWeekly.Location = New System.Drawing.Point(6, 6)
        Me.GroupBoxWeekly.Name = "GroupBoxWeekly"
        Me.GroupBoxWeekly.Size = New System.Drawing.Size(330, 108)
        Me.GroupBoxWeekly.TabIndex = 0
        Me.GroupBoxWeekly.TabStop = False
        Me.GroupBoxWeekly.Text = "Weekly Rota"
        '
        'WeekInfo
        '
        Me.WeekInfo.AutoSize = True
        Me.WeekInfo.Location = New System.Drawing.Point(77, 16)
        Me.WeekInfo.Name = "WeekInfo"
        Me.WeekInfo.Size = New System.Drawing.Size(218, 39)
        Me.WeekInfo.TabIndex = 0
        Me.WeekInfo.Text = "The Weekly Rota lists all of the employees" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in the system, and enables you to cre" &
    "ate and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "modify the rotas for them on weekly intervals."
        '
        'PictureBoxWeeklyRota
        '
        Me.PictureBoxWeeklyRota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxWeeklyRota.Location = New System.Drawing.Point(20, 31)
        Me.PictureBoxWeeklyRota.Name = "PictureBoxWeeklyRota"
        Me.PictureBoxWeeklyRota.Size = New System.Drawing.Size(32, 35)
        Me.PictureBoxWeeklyRota.TabIndex = 3
        Me.PictureBoxWeeklyRota.TabStop = False
        '
        'WeekRotaButton
        '
        Me.WeekRotaButton.Location = New System.Drawing.Point(80, 79)
        Me.WeekRotaButton.Name = "WeekRotaButton"
        Me.WeekRotaButton.Size = New System.Drawing.Size(98, 23)
        Me.WeekRotaButton.TabIndex = 4
        Me.WeekRotaButton.Text = "Weekly Rota"
        Me.WeekRotaButton.UseVisualStyleBackColor = True
        '
        'NewRotaBtn
        '
        Me.NewRotaBtn.Location = New System.Drawing.Point(212, 79)
        Me.NewRotaBtn.Name = "NewRotaBtn"
        Me.NewRotaBtn.Size = New System.Drawing.Size(98, 23)
        Me.NewRotaBtn.TabIndex = 7
        Me.NewRotaBtn.Text = "New Rota"
        Me.NewRotaBtn.UseVisualStyleBackColor = True
        '
        'GroupBoxModified
        '
        Me.GroupBoxModified.Controls.Add(Me.ModLogButton)
        Me.GroupBoxModified.Controls.Add(Me.PictureBoxModifiedEnts)
        Me.GroupBoxModified.Controls.Add(Me.Label1)
        Me.GroupBoxModified.Location = New System.Drawing.Point(6, 120)
        Me.GroupBoxModified.Name = "GroupBoxModified"
        Me.GroupBoxModified.Size = New System.Drawing.Size(330, 108)
        Me.GroupBoxModified.TabIndex = 1
        Me.GroupBoxModified.TabStop = False
        Me.GroupBoxModified.Text = "Modified Entries"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 52)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "The Modified Entries log allows you to view" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "entries which have been changed, and" &
    " their" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "previous values, as well as who they were" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "modified by."
        '
        'PictureBoxModifiedEnts
        '
        Me.PictureBoxModifiedEnts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxModifiedEnts.Location = New System.Drawing.Point(20, 31)
        Me.PictureBoxModifiedEnts.Name = "PictureBoxModifiedEnts"
        Me.PictureBoxModifiedEnts.Size = New System.Drawing.Size(32, 35)
        Me.PictureBoxModifiedEnts.TabIndex = 2
        Me.PictureBoxModifiedEnts.TabStop = False
        '
        'ModLogButton
        '
        Me.ModLogButton.Enabled = False
        Me.ModLogButton.Location = New System.Drawing.Point(80, 79)
        Me.ModLogButton.Name = "ModLogButton"
        Me.ModLogButton.Size = New System.Drawing.Size(230, 23)
        Me.ModLogButton.TabIndex = 5
        Me.ModLogButton.Text = "Modification Log"
        Me.ModLogButton.UseVisualStyleBackColor = True
        '
        'GroupBoxDefault
        '
        Me.GroupBoxDefault.Controls.Add(Me.DefaultRotaButton)
        Me.GroupBoxDefault.Controls.Add(Me.PictureBoxDefaultRota)
        Me.GroupBoxDefault.Controls.Add(Me.Label2)
        Me.GroupBoxDefault.Location = New System.Drawing.Point(6, 234)
        Me.GroupBoxDefault.Name = "GroupBoxDefault"
        Me.GroupBoxDefault.Size = New System.Drawing.Size(330, 108)
        Me.GroupBoxDefault.TabIndex = 2
        Me.GroupBoxDefault.TabStop = False
        Me.GroupBoxDefault.Text = "Default Rota"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 52)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "The Default Rota is what the Weekly Rota uses" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "as a base for building the rota. I" &
    "t is very useful" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "for filling in the rota when employees work" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the same days eac" &
    "h week."
        '
        'PictureBoxDefaultRota
        '
        Me.PictureBoxDefaultRota.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxDefaultRota.Location = New System.Drawing.Point(20, 31)
        Me.PictureBoxDefaultRota.Name = "PictureBoxDefaultRota"
        Me.PictureBoxDefaultRota.Size = New System.Drawing.Size(32, 35)
        Me.PictureBoxDefaultRota.TabIndex = 4
        Me.PictureBoxDefaultRota.TabStop = False
        '
        'DefaultRotaButton
        '
        Me.DefaultRotaButton.Enabled = False
        Me.DefaultRotaButton.Location = New System.Drawing.Point(80, 79)
        Me.DefaultRotaButton.Name = "DefaultRotaButton"
        Me.DefaultRotaButton.Size = New System.Drawing.Size(230, 23)
        Me.DefaultRotaButton.TabIndex = 6
        Me.DefaultRotaButton.Text = "Default Rota"
        Me.DefaultRotaButton.UseVisualStyleBackColor = True
        '
        'TabControlMain
        '
        Me.TabControlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControlMain.Controls.Add(Me.TabPageRota)
        Me.TabControlMain.Controls.Add(Me.TabPageEmployees)
        Me.TabControlMain.Location = New System.Drawing.Point(12, 12)
        Me.TabControlMain.Name = "TabControlMain"
        Me.TabControlMain.SelectedIndex = 0
        Me.TabControlMain.Size = New System.Drawing.Size(350, 375)
        Me.TabControlMain.TabIndex = 0
        '
        'RotaManagerMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 434)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.ApplyButton)
        Me.Controls.Add(Me.TabControlMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RotaManagerMenu"
        Me.Text = "Rota Manager"
        Me.TabPageEmployees.ResumeLayout(False)
        Me.EmployeeListContainer.ResumeLayout(False)
        Me.EmployeeListContainer.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeListGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VisitorGroupBox.ResumeLayout(False)
        Me.VisitorGroupBox.PerformLayout()
        CType(Me.VisitorPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageRota.ResumeLayout(False)
        Me.GroupBoxWeekly.ResumeLayout(False)
        Me.GroupBoxWeekly.PerformLayout()
        CType(Me.PictureBoxWeeklyRota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxModified.ResumeLayout(False)
        Me.GroupBoxModified.PerformLayout()
        CType(Me.PictureBoxModifiedEnts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxDefault.ResumeLayout(False)
        Me.GroupBoxDefault.PerformLayout()
        CType(Me.PictureBoxDefaultRota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ApplyButton As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents OKButton As Button
    Friend WithEvents TabPageEmployees As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NewEmpBtn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents EditEmpBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents VisitorGroupBox As GroupBox
    Friend WithEvents ManageVisitorsButton As Button
    Friend WithEvents VisitorPictureBox As PictureBox
    Friend WithEvents VisitorsLabel As Label
    Friend WithEvents EmployeeListContainer As GroupBox
    Friend WithEvents EmployeeListAddButton As Button
    Friend WithEvents EmployeeListEditButton As Button
    Friend WithEvents EmployeeListDeleteButton As Button
    Friend WithEvents EmployeeListGrid As DataGridView
    Friend WithEvents IDCol As DataGridViewTextBoxColumn
    Friend WithEvents NameCol As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents EmployeeListLabel As Label
    Friend WithEvents TabPageHolidays As TabPage
    Friend WithEvents RequestsButton As Button
    Friend WithEvents ReportsButton As Button
    Friend WithEvents HolSettingsButton As Button
    Friend WithEvents BasicLabel4 As Label
    Friend WithEvents BasicLabel3 As Label
    Friend WithEvents BasicLabel2 As Label
    Friend WithEvents BasicLabel1 As Label
    Friend WithEvents TabPageRota As TabPage
    Friend WithEvents GroupBoxDefault As GroupBox
    Friend WithEvents DefaultRotaButton As Button
    Friend WithEvents PictureBoxDefaultRota As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBoxModified As GroupBox
    Friend WithEvents ModLogButton As Button
    Friend WithEvents PictureBoxModifiedEnts As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBoxWeekly As GroupBox
    Friend WithEvents NewRotaBtn As Button
    Friend WithEvents WeekRotaButton As Button
    Friend WithEvents PictureBoxWeeklyRota As PictureBox
    Friend WithEvents WeekInfo As Label
    Friend WithEvents TabControlMain As TabControl
End Class
