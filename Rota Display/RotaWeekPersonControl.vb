Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports WHLClasses

Public Class RotaWeekPersonControl

    Private EmpDetails As Employee
    Private Thisweek As String
    Private StartDate As Date



    Public Property ActiveWeek As String
        Get
            Return Me.Thisweek
        End Get
        Set(ByVal value As String)
            Dim time As DateTime
            Me.Thisweek = value
            DateTime.TryParse(value, time)
            SatControl.TargetDate = time.AddDays(0).ToShortDateString
            SunControl.TargetDate = time.AddDays(1).ToShortDateString
            MonControl.TargetDate = time.AddDays(2).ToShortDateString
            TueControl.TargetDate = time.AddDays(3).ToShortDateString
            WedControl.TargetDate = time.AddDays(4).ToShortDateString
            ThuControl.TargetDate = time.AddDays(5).ToShortDateString
            FriControl.TargetDate = time.AddDays(6).ToShortDateString
            SatNext.TargetDate = time.AddDays(7).ToShortDateString
            SunNext.TargetDate = time.AddDays(8).ToShortDateString
            MonNext.TargetDate = time.AddDays(9).ToShortDateString
            TueNext.TargetDate = time.AddDays(10).ToShortDateString
            WedNext.TargetDate = time.AddDays(11).ToShortDateString
            ThuNext.TargetDate = time.AddDays(12).ToShortDateString
            FriNext.TargetDate = time.AddDays(13).ToShortDateString

            'Refresh the notes. This needs doing.
            SatControl.RefreshNote()
            SunControl.RefreshNote()
            MonControl.RefreshNote()
            TueControl.RefreshNote()
            WedControl.RefreshNote()
            ThuControl.RefreshNote()
            FriControl.RefreshNote()
            SatNext.RefreshNote()
            SunNext.RefreshNote()
            MonNext.RefreshNote()
            TueNext.RefreshNote()
            WedNext.RefreshNote()
            ThuNext.RefreshNote()
            FriNext.RefreshNote()


            StartDate = time
        End Set
    End Property

    Public Property Employee As Employee
        Get
            Return Me.EmpDetails
        End Get
        Set(ByVal value As Employee)
            Me.EmpDetails = value
            Try
                Me.NameLabel.Text = Me.EmpDetails.FullName
                SunControl.EmployeeId = Me.EmpDetails.PayrollId
                MonControl.EmployeeId = Me.EmpDetails.PayrollId
                TueControl.EmployeeId = Me.EmpDetails.PayrollId
                WedControl.EmployeeId = Me.EmpDetails.PayrollId
                ThuControl.EmployeeId = Me.EmpDetails.PayrollId
                FriControl.EmployeeId = Me.EmpDetails.PayrollId
                SatControl.EmployeeId = Me.EmpDetails.PayrollId
                SunNext.EmployeeId = Me.EmpDetails.PayrollId
                MonNext.EmployeeId = Me.EmpDetails.PayrollId
                TueNext.EmployeeId = Me.EmpDetails.PayrollId
                WedNext.EmployeeId = Me.EmpDetails.PayrollId
                ThuNext.EmployeeId = Me.EmpDetails.PayrollId
                FriNext.EmployeeId = Me.EmpDetails.PayrollId
                SatNext.EmployeeId = Me.EmpDetails.PayrollId
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                Me.NameLabel.Text = "Not initiated properly."
                ProjectData.ClearProjectError()
            End Try
        End Set
    End Property
End Class
