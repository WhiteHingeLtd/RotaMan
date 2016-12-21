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
Imports System.Windows.Forms.ListViewItem

Public Class HolidayEntitlements
    Private Sub HolidayEntitlements_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Year2Col.Text = DateAndTime.Now.AddYears(1).Year.ToString
        ChangeNextYear.Text = ("Change " & DateAndTime.Now.AddYears(1).Year.ToString)
        ChangeThisYear.Text = ("Change " & DateAndTime.Now.AddYears(0).Year.ToString)
        Year1Col.Text = DateAndTime.Now.AddYears(0).Year.ToString

        UpdateTable()

    End Sub

    'Created to prevent issues with loading the table again. Goodness knows why it was running the main loop a second time.
    'Also, this doesn't work. Yet. It seems to happen on conversion of a string to int16. 
    Private Sub UpdateTable()
        AllowanceList.Items.Clear()
        Dim Emps As New EmployeeCollection
        For Each emp As Employee In Emps.Employees
            If emp.Visible Then
                '-----For debugging-----
                Dim ThisYearLeftPerm As Integer = 0
                Dim NextYearLeftPerm As Integer = 0
                '-----------------------

                Try
                    'Get this years total allowance
                    Dim ThisYear As String = Now.Year.ToString

                    Dim ThisYearAllowance As Integer
                    Try
                        ThisYearAllowance = MySql.SelectData("SELECT * FROM whldata.holiday_allowances WHERE payrollId=" + emp.PayrollId.ToString + " AND ApplicableYear=" + ThisYear + " LIMIT 1;")(0)(3)
                    Catch ex As Exception
                        ThisYearAllowance = 0
                    End Try

                    Dim ThisYearUsed As Integer
                    Try
                        ThisYearUsed = MySql.SelectData("SELECT SUM(length) FROM whldata.holiday_request WHERE payrollId=" + emp.PayrollId.ToString + " AND year='" + ThisYear + "';")(0)(0)
                    Catch ex As Exception
                        ThisYearUsed = 0
                    End Try

                    Dim ThisYearLeft As Integer = ThisYearAllowance - ThisYearUsed

                    '-----For debugging-----
                    ThisYearLeftPerm = ThisYearLeft
                    '-----------------------
                Catch ex As Exception

                End Try

                Try
                    'Get next years allowances
                    'Get this years total allowance
                    Dim NextYear As String = Now.AddYears(1).Year.ToString

                    Dim NextYearAllowance As Integer
                    Try
                        NextYearAllowance = MySql.SelectData("SELECT * FROM whldata.holiday_allowances WHERE payrollId=" + emp.PayrollId.ToString + " AND ApplicableYear=" + NextYear + " LIMIT 1;")(0)(3)
                    Catch ex As Exception
                        NextYearAllowance = 0
                    End Try

                    Dim NextYearUsed As Integer
                    Try
                        NextYearUsed = MySql.SelectData("SELECT SUM(length) FROM whldata.holiday_request WHERE payrollId=" + emp.PayrollId.ToString + " AND year='" + NextYear + "';")(0)(0)
                    Catch ex As Exception
                        NextYearUsed = 0
                    End Try

                    Dim NextYearLeft As Integer = NextYearAllowance - NextYearUsed

                    '-----For debugging-----
                    NextYearLeftPerm = NextYearLeft
                    '-----------------------
                Catch ex As Exception

                End Try

                Try
                    'Create the ListViewItem
                    Dim NewLVI As New ListViewItem
                    NewLVI.SubItems.Add("")
                    NewLVI.SubItems.Add("")
                    NewLVI.SubItems.Add("")
                    'Set the values
                    NewLVI.SubItems.Item(0).Text = emp.FullName

                    '-----For debugging-----
                    'NewLVI.SubItems.Item(1).Text = ThisYearLeft.ToString       'Uncomment these after debugging
                    'NewLVI.SubItems.Item(2).Text = NextYearLeft.ToString
                    NewLVI.SubItems.Item(1).Text = ThisYearLeftPerm.ToString
                    NewLVI.SubItems.Item(2).Text = NextYearLeftPerm.ToString
                    '-----------------------

                    NewLVI.SubItems.Item(3).Text = emp.PayrollId.ToString
                    'Add the LVI to the list./
                    AllowanceList.Items.Add(NewLVI)
                Catch ex As Exception

                End Try

            End If
        Next
    End Sub


    Private Sub ModifyAllowance(ByVal sender As Button, ByVal e As EventArgs)
        Dim str As String = sender.Text.Substring(7)
        If (AllowanceList.SelectedItems.Count = 1) Then
            Forms.HolidayModifyAllowance.year.Text = str
            Forms.HolidayModifyAllowance.EmpName.Text = AllowanceList.SelectedItems.Item(0).SubItems.Item(0).Text.ToString
            If (sender.Name = "ChangeThisYear") Then
                Forms.HolidayModifyAllowance.Current.Text = AllowanceList.SelectedItems.Item(0).SubItems.Item(1).Text
            Else
                Forms.HolidayModifyAllowance.Current.Text = AllowanceList.SelectedItems.Item(0).SubItems.Item(2).Text
            End If
            Forms.HolidayModifyAllowance.changeval.Text = "1"
            Forms.HolidayModifyAllowance.EmpId = Conversions.ToInteger(AllowanceList.SelectedItems.Item(0).SubItems.Item(3).Text)
            Forms.HolidayModifyAllowance.ShowDialog()
            'HolidayEntitlements_Load(sender, e)
            'MsgBox("Temporary Issue: The table will update on loading this window again.")
            UpdateTable()

        Else
            MsgBox("You must select a person to change their remaining allowance!")
        End If
    End Sub

    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As EventArgs)
        DialogResult = DialogResult.OK
        Close()
        Dispose()
    End Sub

    Private Sub ChangeThisYear_Click(sender As Object, e As EventArgs) Handles ChangeThisYear.Click
        ModifyAllowance(ChangeThisYear, e)
    End Sub

    Private Sub ChangeNextYear_Click(sender As Object, e As EventArgs) Handles ChangeNextYear.Click
        Me.ModifyAllowance(ChangeNextYear, e)
    End Sub



End Class