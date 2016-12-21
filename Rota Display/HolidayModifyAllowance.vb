Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports WHLClasses

Public Class HolidayModifyAllowance
    Public EmpId As Integer


    Private Sub changeval_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles changeval.TextChanged
        If IsNumeric(changeval.Text) Then
            Try
                newnext.Text = Conversions.ToString((Conversions.ToDouble(Current.Text) - Conversions.ToDouble(changeval.Text)))
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                ProjectData.ClearProjectError()
            End Try
        Else
            MsgBox("The entered data must be numeric")
            changeval.Text = "1"
        End If
    End Sub

    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OK_Button.Click
        Dim obj2 As Object = MySql.insertupdate(String.Concat(New String() {"INSERT INTO whldata.holiday_request (payrollID, startDate, length, year, isApproved) VALUES (", Me.EmpId.ToString, ", '0000-00-00', ", Me.changeval.Text, ", '", Me.year.Text, "', 'Yes')"}))
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Cancel_Button.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

End Class