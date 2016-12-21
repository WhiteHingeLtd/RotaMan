Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Rota_Display.My
Imports Rota_Display.My.Resources
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports WHLClasses

Public Class RotaManagerMenu

    Public employee As Employee
    Public WhlEmployees As New EmployeeCollection
    Dim newauth As New Authentication.AuthClass

    Private Sub WeekRotaButton_Click(sender As Object, e As EventArgs) Handles WeekRotaButton.Click
        If employee.Permissions.ApproveHolidays Then

            Forms.LoadingDisplay.Show()
            Application.DoEvents()
            Forms.MainRotaDisplay.Show()
            Forms.LoadingDisplay.Close()
        Else
            MsgBox("You do not have permission to use this utility.", MsgBoxStyle.Critical, "Access Denied")
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        MyBase.DialogResult = DialogResult.Cancel
        MyBase.Close()
    End Sub

    Private Sub RequestsButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RequestsButton.Click
        If employee.Permissions.ApproveHolidays Then
            Forms.HolidayPendingList.Show()
        Else
            MsgBox("You do not have permission to use this utility.", MsgBoxStyle.Critical, "Access Denied")
        End If
    End Sub

    Private Sub ManageVisitorsButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ManageVisitorsButton.Click
        For Each Emp As Employee In WhlEmployees.Employees
            MsgBox(Emp.FullName)
        Next
    End Sub

    Private Sub MainMenu_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        Dim EmployeesList As List(Of Employee)
        'Forms.Login.ShowDialog()
        EmployeeListGrid.Rows.Clear()

        employee = newauth.AuthenticatedUser

        EmployeesList = WhlEmployees.Employees
        For Each employee As Employee In EmployeesList
            Dim current As Employee = employee
            Dim item As New DataGridViewRow
            EmployeeListGrid.Rows.Add(item)
        Next
    End Sub

    Private Sub OKButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OKButton.Click
        ApplyButton.PerformClick()
        DialogResult = DialogResult.OK
        MyBase.Close()
    End Sub

    Private Sub RotaButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DefaultRotaButton.Click
        If employee.Permissions.ManageRota Then
            Forms.MainRotaDisplay.Emp = Me.employee
            Forms.MainRotaDisplay.Show()
        Else
            MsgBox("You do not have permission to use this utility.", MsgBoxStyle.Critical, "Access Denied")
        End If
    End Sub

    Private Sub HolSettingsButton_Click(sender As Object, e As EventArgs) Handles HolSettingsButton.Click
        If employee.Permissions.ApproveHolidays Then
            Forms.HolidayEntitlements.Show()
        Else
            MsgBox("You do not have permission to use this utility.", MsgBoxStyle.Critical, "Access Denied")
        End If
    End Sub

    Private Sub NewEmpBtn_Click(sender As Object, e As EventArgs) Handles NewEmpBtn.Click
        Forms.EmployeeDataSet.isNewEmp = True
        Forms.EmployeeDataSet.ShowDialog()

    End Sub

    Private Sub EditEmpBtn_Click(sender As Object, e As EventArgs) Handles EditEmpBtn.Click
        Forms.EmployeeDataSet.isNewEmp = False
        Forms.EmployeeDataSet.ShowDialog()

    End Sub

    Private Sub NewRotaBtn_Click(sender As Object, e As EventArgs) Handles NewRotaBtn.Click
        If employee.Permissions.ApproveHolidays Then

            Forms.LoadingDisplay.Show()
            Application.DoEvents()
            Forms.NeoRotaDisplay.Show()
            Forms.LoadingDisplay.Close()
        Else
            MsgBox("You do not have permission to use this utility.", MsgBoxStyle.Critical, "Access Denied")
        End If
    End Sub
End Class
