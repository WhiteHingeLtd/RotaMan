Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Rota_Display.My
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports WHLClasses

Public Class EmployeeDataSet
    'This class is going to edit and add new employee data
    'In the event of a new employee, certain information should be changeable.
    'This same information should not be changed for old employees.
    'On loading the form, give a boolean value. If true, new, everything is normal. If false, old, disable payroll ID editing, etc.
    Public isNewEmp As Boolean
    Dim shifts As New NewRota.Shifts
    Dim currentEmp As Employee
    Dim EmpCol As New EmployeeCollection


    Private Sub EmployeeDataSet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DefaultRotaTable.Rows.Clear()
        currentEmp = Nothing
        LoadFromIDText.Text = ""
        FirstNameText.Text = ""
        SurnameText.Text = ""
        PinChangeText.Text = ""
        IDText.Text = ""
        'Firstly, security. If it's an edit, don't allow certain changes.
        If Not isNewEmp Then
            'Simply, disable the stuff that shouldn't change.
            IDText.Enabled = False
            LoadFromIDBtn.Enabled = True
            LoadFromIDText.Enabled = True
            FirstNameText.ReadOnly = True
            SurnameText.Visible = False
        Else
            'If the window is reopened afterwards, this needs to re-enable stuff for a new employee
            IDText.Enabled = True
            LoadFromIDBtn.Enabled = False
            LoadFromIDText.Enabled = False
            FirstNameText.ReadOnly = False
            SurnameText.Visible = True
        End If

        DataGridView1_Load()

        For Each shift As NewRota.Rotashift In shifts
            'Add a button with the text being shift.text if isholiday is not set to true
            If Not shift.isHoliday Then

                Dim RotaMenuItem As New ToolStripMenuItem(shift.Text)
                RotaMenuItem.Tag = shift
                AddHandler RotaMenuItem.Click, AddressOf DefaultRotaEventHandler
                RotaStateMenu.Items.Add(RotaMenuItem)
            End If
        Next

    End Sub

    Private Sub DefaultRotaEventHandler(sender As ToolStripMenuItem, e As EventArgs)
        Dim rotaEntry As NewRota.RotaEntry


        If Not currentEmp Is Nothing Then
            'For Each cell As DataGridViewCell In DefaultRotaTable.SelectedCells
            '    Dim shift As NewRota.Rotashift = sender.Tag
            '    Dim selColumn As Integer = cell.ColumnIndex
            '    Dim theDayName As String = DefaultRotaTable.Columns(selColumn).HeaderText
            '    Dim theDay As DayOfWeek = CType([Enum].Parse(GetType(DayOfWeek), theDayName), DayOfWeek)
            '    Dim selRow As Integer = cell.RowIndex + 1
            '    rotaEntry = NewRota.AddDefaultEntry(theDay, selRow, shift.ShiftId, currentEmp.PayrollId)
            '    cell.Value = shifts.Id(rotaEntry.ShiftId).Text

            'Next
        Else
            MsgBox("There is no loaded employee.")
        End If


    End Sub

    Private Sub DataGridView1_Load()

        DefaultRotaTable.Rows.Clear()

        'Initialise the rows.
        Dim GridRowWeek1 As New DataGridViewRow
        GridRowWeek1.CreateCells(DefaultRotaTable)

        Dim GridRowWeek2 As New DataGridViewRow
        GridRowWeek2.CreateCells(DefaultRotaTable)

        'Add stuff for week1 and week2 row data
        '-----  -----   -----   -----   -----

        GridRowWeek1.HeaderCell.Value = "Week 1"

        GridRowWeek2.HeaderCell.Value = "Week 2"

        If Not currentEmp Is Nothing Then
            GridRowWeek1.Cells.Item(0).Value = shifts.Id(NewRota.GetDefaultRota(currentEmp.PayrollId, 1, DayOfWeek.Saturday).ShiftId).Text
            GridRowWeek1.Cells.Item(1).Value = shifts.Id(NewRota.GetDefaultRota(currentEmp.PayrollId, 1, DayOfWeek.Sunday).ShiftId).Text
            GridRowWeek1.Cells.Item(2).Value = shifts.Id(NewRota.GetDefaultRota(currentEmp.PayrollId, 1, DayOfWeek.Monday).ShiftId).Text
            GridRowWeek1.Cells.Item(3).Value = shifts.Id(NewRota.GetDefaultRota(currentEmp.PayrollId, 1, DayOfWeek.Tuesday).ShiftId).Text
            GridRowWeek1.Cells.Item(4).Value = shifts.Id(NewRota.GetDefaultRota(currentEmp.PayrollId, 1, DayOfWeek.Wednesday).ShiftId).Text
            GridRowWeek1.Cells.Item(5).Value = shifts.Id(NewRota.GetDefaultRota(currentEmp.PayrollId, 1, DayOfWeek.Thursday).ShiftId).Text
            GridRowWeek1.Cells.Item(6).Value = shifts.Id(NewRota.GetDefaultRota(currentEmp.PayrollId, 1, DayOfWeek.Friday).ShiftId).Text

            GridRowWeek2.Cells.Item(0).Value = shifts.Id(NewRota.GetDefaultRota(currentEmp.PayrollId, 2, DayOfWeek.Saturday).ShiftId).Text
            GridRowWeek2.Cells.Item(1).Value = shifts.Id(NewRota.GetDefaultRota(currentEmp.PayrollId, 2, DayOfWeek.Sunday).ShiftId).Text
            GridRowWeek2.Cells.Item(2).Value = shifts.Id(NewRota.GetDefaultRota(currentEmp.PayrollId, 2, DayOfWeek.Monday).ShiftId).Text
            GridRowWeek2.Cells.Item(3).Value = shifts.Id(NewRota.GetDefaultRota(currentEmp.PayrollId, 2, DayOfWeek.Tuesday).ShiftId).Text
            GridRowWeek2.Cells.Item(4).Value = shifts.Id(NewRota.GetDefaultRota(currentEmp.PayrollId, 2, DayOfWeek.Wednesday).ShiftId).Text
            GridRowWeek2.Cells.Item(5).Value = shifts.Id(NewRota.GetDefaultRota(currentEmp.PayrollId, 2, DayOfWeek.Thursday).ShiftId).Text
            GridRowWeek2.Cells.Item(6).Value = shifts.Id(NewRota.GetDefaultRota(currentEmp.PayrollId, 2, DayOfWeek.Friday).ShiftId).Text

            GridRowWeek1.Cells.Item(0).Tag = shifts.Id(NewRota.GetDefaultRota(currentEmp.PayrollId, 1, DayOfWeek.Saturday).ShiftId)
            GridRowWeek1.Cells.Item(1).Tag = shifts.Id(NewRota.GetDefaultRota(currentEmp.PayrollId, 1, DayOfWeek.Sunday).ShiftId)
            GridRowWeek1.Cells.Item(2).Tag = shifts.Id(NewRota.GetDefaultRota(currentEmp.PayrollId, 1, DayOfWeek.Monday).ShiftId)
            GridRowWeek1.Cells.Item(3).Tag = shifts.Id(NewRota.GetDefaultRota(currentEmp.PayrollId, 1, DayOfWeek.Tuesday).ShiftId)
            GridRowWeek1.Cells.Item(4).Tag = shifts.Id(NewRota.GetDefaultRota(currentEmp.PayrollId, 1, DayOfWeek.Wednesday).ShiftId)
            GridRowWeek1.Cells.Item(5).Tag = shifts.Id(NewRota.GetDefaultRota(currentEmp.PayrollId, 1, DayOfWeek.Thursday).ShiftId)
            GridRowWeek1.Cells.Item(6).Tag = shifts.Id(NewRota.GetDefaultRota(currentEmp.PayrollId, 1, DayOfWeek.Friday).ShiftId)

            GridRowWeek2.Cells.Item(0).Tag = shifts.Id(NewRota.GetDefaultRota(currentEmp.PayrollId, 2, DayOfWeek.Saturday).ShiftId)
            GridRowWeek2.Cells.Item(1).Tag = shifts.Id(NewRota.GetDefaultRota(currentEmp.PayrollId, 2, DayOfWeek.Sunday).ShiftId)
            GridRowWeek2.Cells.Item(2).Tag = shifts.Id(NewRota.GetDefaultRota(currentEmp.PayrollId, 2, DayOfWeek.Monday).ShiftId)
            GridRowWeek2.Cells.Item(3).Tag = shifts.Id(NewRota.GetDefaultRota(currentEmp.PayrollId, 2, DayOfWeek.Tuesday).ShiftId)
            GridRowWeek2.Cells.Item(4).Tag = shifts.Id(NewRota.GetDefaultRota(currentEmp.PayrollId, 2, DayOfWeek.Wednesday).ShiftId)
            GridRowWeek2.Cells.Item(5).Tag = shifts.Id(NewRota.GetDefaultRota(currentEmp.PayrollId, 2, DayOfWeek.Thursday).ShiftId)
            GridRowWeek2.Cells.Item(6).Tag = shifts.Id(NewRota.GetDefaultRota(currentEmp.PayrollId, 2, DayOfWeek.Friday).ShiftId)
        End If

        '-----  -----   -----   -----   -----



        'Now add the rows to the grid.
        DefaultRotaTable.Rows.Add(GridRowWeek1)
        DefaultRotaTable.Rows.Add(GridRowWeek2)

    End Sub

    Private Sub EmployeeDataSet_Close(sender As Object, e As EventArgs) Handles MyBase.Closed

    End Sub

    Private Sub LoadFromIDBtn_Click(sender As Object, e As EventArgs) Handles LoadFromIDBtn.Click

        If Not LoadFromIDText Is Nothing And IsNumeric(LoadFromIDText.Text) Then
            currentEmp = EmpCol.FindEmployeeByID(LoadFromIDText.Text)
            DataGridView1_Load()

            'Add employee data to info.
            IDText.Text = currentEmp.PayrollId.ToString
            FirstNameText.Text = currentEmp.FullName
            VisibleCheck.Checked = currentEmp.Visible
            'StartDateBox.Value = currentEmp.StartDate

        End If

    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        'We need to ensure new employees are in fact new, and old employee data saving won't have an issue with an existing ID.

        If isNewEmp Then
            Dim FoundEmp As Boolean = False
            Dim totalEmps As Integer = 0
            Dim topEmpID As Integer = 0

            'They are new, ensure the ID doesn't exist
            For Each tempEmp As Employee In EmpCol.Employees
                If tempEmp.PayrollId = IDText.Text Then
                    FoundEmp = True
                End If
                'For message reporting, in the event of an issue.
                totalEmps += 1
                If topEmpID < tempEmp.PayrollId And tempEmp.PayrollId < 900 Then
                    topEmpID = tempEmp.PayrollId
                End If
            Next

            If FoundEmp Then
                'Oh. Tell them that.
                MsgBox("An employee already exists with that ID. The highest recorded ID was: " + topEmpID.ToString + ".")
            Else
                'Now we know our employee ID is in fact a new employee ID, let's make an employee record

                '-----  -----   -----   -----   -----
                If IDText.Text = "" Then
                    MsgBox("The ID field is empty.")
                ElseIf Not IsNumeric(IDText.Text) Then
                    MsgBox("The ID needs to be numeric.")

                ElseIf FirstNameText.Text = "" Then
                    MsgBox("The first name field is empty.")

                ElseIf SurnameText.Text = "" Then
                    MsgBox("The surname field is empty.")

                ElseIf PinChangeText.Text = "" Then
                    MsgBox("The pin field is empty.")
                ElseIf Not IsNumeric(PinChangeText.Text) Then
                    MsgBox("The pin needs to be numeric.")

                Else
                    'ID is numeric, Pin is numeric, name is filled in, some last minute data setup

                    'There will always be a yes / no from the checkbox
                    Dim isVis As Integer
                    If VisibleCheck.Checked Then
                        isVis = 0
                    Else
                        isVis = 1
                    End If

                    'The date isn't really used, so... in theory, it should work... Because it... doesn't have to??? ? ?
                    'Expert coding theory. If nothing uses it, it won't break something unless you're filling memory with it.
                    Dim dateString As String = StartDateBox.Value.ToString

                    'Save
                    Dim tempEmp As New Employee
                    tempEmp.SaveData(IDText.Text, FirstNameText.Text, SurnameText.Text, PinChangeText.Text, isVis, dateString)
                End If


                '-----  -----   -----   -----   -----

            End If

        Else
            'They aren't new. Thankfully, the ID wasn't changeable, so there's no check for the ID existing.
            'Plus, what really could have changed? The pin and visibility? Not much to do here.

            'Check that we loaded an employee
            If Not currentEmp Is Nothing Then
                'Check that what we're saving will work
                If IsNumeric(PinChangeText.Text) Then
                    'Save the number.
                    currentEmp.SetNewPin(PinChangeText.Text)
                Else
                    'Let's tell our user how they goofed.
                    MsgBox("The new pin isn't a number")
                End If
                'Now let's save the visibility
                currentEmp.SetVisibility(VisibleCheck.Checked)
            Else
                MsgBox("You haven't loaded an employee.")
            End If

        End If
    End Sub
End Class