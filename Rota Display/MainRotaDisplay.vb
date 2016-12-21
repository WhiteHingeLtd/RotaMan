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

Public Class MainRotaDisplay
    Public Emp As Employee
    Public Emplist As New EmployeeCollection

    Private Sub MainRotaDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RotaZone.Controls.Clear()

        LoadingDisplay.RotaLoadingBar.Maximum = Emplist.Employees.Count
        LoadingDisplay.RotaLoadingBar.Value = 0

        For Each employee As Employee In Emplist.Employees
            If employee.Visible Then
                Dim person As New RotaWeekPersonControl
                person.Employee = employee
                RotaZone.Controls.Add(person)

                LoadingDisplay.RotaLoadingBar.Value += 1
                Application.DoEvents()
            End If
        Next
        DateSelectionBox.Value = Now.AddDays(14)
        LoadTable()
    End Sub

    Private Sub DecreaseWeek_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DecreaseWeek.Click
        DateSelectionBox.Value = DateSelectionBox.Value.AddDays(-14)
        LoadBtn.BackColor = Color.Yellow
    End Sub

    Private Sub IncreaseWeek_Click(ByVal sender As Object, ByVal e As EventArgs) Handles IncreaseWeek.Click
        DateSelectionBox.Value = DateSelectionBox.Value.AddDays(14)
        LoadBtn.BackColor = Color.Yellow
    End Sub

    Private Sub DateSelectionBox_ValueChanged(sender As Object, e As EventArgs) Handles DateSelectionBox.ValueChanged
        LoadBtn.BackColor = Color.Yellow
    End Sub

    Private Sub LoadTable() Handles LoadBtn.Click
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
            For Each current As RotaWeekPersonControl In RotaZone.Controls

                'Dim person As New RotaWeekPersonControl
                If Not current.Employee Is Nothing Then
                    current.ActiveWeek = DateSelectionBox.Value.ToShortDateString
                End If

            Next

        Else
            DateSelectionBox.Value = DateSelectionBox.Value.AddDays(-1)
            LoadTable()
        End If
    End Sub
End Class