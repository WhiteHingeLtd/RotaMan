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

Public Class NeoRotaDisplay
    'Not really a matrix reference. I could add one, but with how many numbers there's gonna be, when it's ready, I won't have to.
    Public Emp As Employee
    Public Emplist As New EmployeeCollection
    Public shifts As New NewRota.Shifts

    Private Sub NeoRotaDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateSelectionBox.Value = Now.AddDays(14)
        LoadTable()

        For Each shift As NewRota.Rotashift In shifts
            'Add a button with the text being shift.text if isholiday is not set to true
            If Not shift.isHoliday Then


                Dim RotaMenuItem As New ToolStripMenuItem(shift.Text)
                RotaMenuItem.Tag = shift
                AddHandler RotaMenuItem.Click, AddressOf RotaEventHandler
                RotaModMenu.Items.Add(RotaMenuItem)
            End If
        Next

    End Sub

    Private Sub RotaEventHandler(sender As ToolStripMenuItem, e As EventArgs)

        For Each cell As DataGridViewCell In RotaDisplayGrid.SelectedCells
            Dim RotaEntry As NewRota.RotaEntry = cell.Tag
            Dim aShift As NewRota.Rotashift = sender.Tag
            RotaEntry.ShiftId = aShift.ShiftId


            RotaEntry.Save()
            cell.Value = shifts.Id(RotaEntry.ShiftId).Text
        Next

    End Sub

    Private Sub WeekSaveButton_Click(sender As Object, e As EventArgs) Handles WeekSaveButton.Click
        '-----   -----   -----   -----   -----   COME BACK TO THIS AFTER TABLE COMPLETION   -----   -----   -----   -----   -----

        'For Each currentControl As Control In RotaZone.Controls
        '    Try
        '        Dim rotaData As RotaWeekPersonControl = currentControl
        '        rotaData.SaveAll()
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try
        'Next

        MsgBox("Week saved!", MsgBoxStyle.Information, "Rota Update")
        DateSelectionBox.Value = DateSelectionBox.Value.AddDays(1)
    End Sub

    Private Sub DecreaseWeek_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DecreaseWeek.Click
        DateSelectionBox.Value = DateSelectionBox.Value.AddDays(-14)
        LoadBtn.BackColor = Color.Yellow
    End Sub

    Private Sub IncreaseWeek_Click(ByVal sender As Object, ByVal e As EventArgs) Handles IncreaseWeek.Click
        DateSelectionBox.Value = DateSelectionBox.Value.AddDays(14)
        LoadBtn.BackColor = Color.Yellow
    End Sub

    Private Sub DateSelectionBox_ValueChanged() Handles DateSelectionBox.ValueChanged
        LoadBtn.BackColor = Color.Yellow
    End Sub

    Private Sub LoadBtnClicked() Handles LoadBtn.Click
        Forms.LoadingDisplay.Show()
        Application.DoEvents()
        LoadTable()
        Forms.LoadingDisplay.Close()
    End Sub

    Private Sub LoadTable()
        LoadBtn.BackColor = SystemColors.Control

        If (DateSelectionBox.Value.DayOfWeek.ToString = "Saturday") Then

            If ((DateTime.Compare(DateSelectionBox.Value, DateAndTime.Now) < 0) And Not Forms.RotaManagerMenu.employee.Permissions.RotaHistoryView) Then
                MsgBox("You are not allowed to change the rota for this week or weeks that have already passed.")
                DateSelectionBox.Value = DateAndTime.Now.AddDays(7)
            Else
                SaturdayDate.Text = DateSelectionBox.Value.AddDays(0).ToShortDateString
                SundayDate.Text = DateSelectionBox.Value.AddDays(1).ToShortDateString
                MondayDate.Text = DateSelectionBox.Value.AddDays(2).ToShortDateString
                TuesdayDate.Text = DateSelectionBox.Value.AddDays(3).ToShortDateString
                WednesdayDate.Text = DateSelectionBox.Value.AddDays(4).ToShortDateString
                ThursdayDate.Text = DateSelectionBox.Value.AddDays(5).ToShortDateString
                FridayDate.Text = DateSelectionBox.Value.AddDays(6).ToShortDateString
                Sat2Date.Text = DateSelectionBox.Value.AddDays(7).ToShortDateString
                Sun2Date.Text = DateSelectionBox.Value.AddDays(8).ToShortDateString
                Mon2Date.Text = DateSelectionBox.Value.AddDays(9).ToShortDateString
                Tue2Date.Text = DateSelectionBox.Value.AddDays(10).ToShortDateString
                Wed2Date.Text = DateSelectionBox.Value.AddDays(11).ToShortDateString
                Thu2Date.Text = DateSelectionBox.Value.AddDays(12).ToShortDateString
                Fri2Date.Text = DateSelectionBox.Value.AddDays(13).ToShortDateString
            End If

            '-----   -----   -----   -----   -----   COME BACK TO THIS AFTER TABLE COMPLETION   -----   -----   -----   -----   -----

            'For Each current As RotaWeekPersonControl In RotaZone.Controls

            '    'Dim person As New RotaWeekPersonControl
            '    If Not current.Employee Is Nothing Then
            '        current.ActiveWeek = DateSelectionBox.Value.ToShortDateString
            '        current.SetupDayCount()
            '    End If

            'Next

            LoadingDisplay.RotaLoadingBar.Maximum = Emplist.Employees.Count
            LoadingDisplay.RotaLoadingBar.Value = 0

            RotaDisplayGrid.Rows.Clear()

            For Each employee As Employee In Emplist.Employees
                If employee.Visible Then
                    'Dim person As New RotaWeekPersonControl
                    'person.Employee = employee
                    'RotaZone.Controls.Add(person)

                    'Initialise row.
                    Dim newRow As New DataGridViewRow
                    newRow.CreateCells(RotaDisplayGrid)

                    newRow.DefaultCellStyle.Font = New Font("Segoe UI", 11.0!)

                    'Set the header to the employee name.
                    newRow.HeaderCell.Value = employee.FullName
                    newRow.HeaderCell.Style.Font = New Font("Segoe UI", 11.0!)

                    'Counter of days in
                    Dim InCount As Integer = 0

                    'Fill 14 days with rota data
                    'Date. The saturday is the DateSelectionBox date value. All others use "AddDays(++)". Follow with employee and the day number, equivelant to the AddDays value.
                    'I should put this in a for loop with an array of rota entries.

                    Dim rotaArray(13) As NewRota.RotaEntry
                    For i As Integer = 0 To 13

                        newRow.Cells.Item(i).Tag = rotaArray(i)
                        Dim tempShift As NewRota.Rotashift = shifts.Id(rotaArray(i).ShiftId)
                        newRow.Cells.Item(i).Value = tempShift.Text

                        If tempShift.isAttendance Then
                            InCount += 1
                            newRow.Cells.Item(i).Style.BackColor = Color.FromArgb(190, &HD1, &HBB)
                        ElseIf tempShift.isHoliday Then
                            newRow.Cells.Item(i).Style.BackColor = Color.FromArgb(220, 220, &HBB)
                        Else
                            newRow.Cells.Item(i).Style.BackColor = Color.FromArgb(&HD1, &HBB, &HBB)
                        End If

                        If rotaArray(i).isDefault Then
                            newRow.Cells.Item(i).Style.Font = New Font("Segoe UI", 11.0!, FontStyle.Bold)
                        Else
                            newRow.Cells.Item(i).Style.Font = New Font("Segoe UI", 11.0!)
                        End If

                    Next


                    'Show how many of these days they should be in for
                    newRow.Cells.Item(14).Value = InCount.ToString

                    'Show how many of these days they were in for
                    newRow.Cells.Item(15).Value = 0 '-----   -----   -----   --!-- # -!!!-###   COME BACK TO THIS   ###-!!!- # --!--   -----   -----   -----

                    'Compare
                    newRow.Cells.Item(16).Value = (newRow.Cells.Item(15).Value - newRow.Cells.Item(14).Value)

                    'In minus Scheduled. If they're in for 10, scheduled for 10, 0. If they missed 2 days, it's -2.
                    If newRow.Cells.Item(16).Value < 0 Then
                        'They missed days
                        newRow.Cells.Item(16).Style.BackColor = Color.PaleVioletRed
                    ElseIf newRow.Cells.Item(16).Value = 0 Then
                        'They were in for all days
                        newRow.Cells.Item(16).Style.BackColor = Color.LightBlue
                    Else
                        'They must have done overtime
                        newRow.Cells.Item(16).Style.BackColor = Color.LightGreen
                    End If

                    'Add the row.
                    newRow.Height = 36
                    RotaDisplayGrid.Rows.Add(newRow)

                End If
                'Increase the loading bar. Even if the employee isn't visible, they're in the list, they contribute to the total.
                LoadingDisplay.RotaLoadingBar.Value += 1
                Application.DoEvents()

            Next

        Else
            DateSelectionBox.Value = DateSelectionBox.Value.AddDays(-1)
            'Oh yeah, this isn't automatic anymore... Let's fix that.
            LoadTable()
        End If
    End Sub

End Class