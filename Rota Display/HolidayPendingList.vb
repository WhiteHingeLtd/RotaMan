Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports WHLClasses

Public Class HolidayPendingList

    Private Sub HolidayPendingList_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        UpdateList()
    End Sub

    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OkBtn.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub

    'Private Sub Cancel_Button_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    DialogResult = DialogResult.Cancel
    '    Close()
    'End Sub

    Public Sub UpdateList()
        HolidayPendingPanel.Controls.Clear()
        Dim list As New ArrayList
        list = DirectCast(MySql.SelectData("SELECT * FROM whldata.holiday_request WHERE isApproved='No';"), ArrayList)
        For Each current As ArrayList In list
            Dim listing As New HolidayListing With {.EmployeeID = Conversions.ToInteger(current.Item(1))}
            Dim separator As Char() = New Char() {"-"c}
            Dim chArray2 As Char() = New Char() {"-"c}
            Dim chArray3 As Char() = New Char() {"-"c}
            Dim tempData As DateTime = New DateTime(Conversions.ToInteger(current.Item(2).ToString.Split(separator)(0)), Conversions.ToInteger(current.Item(2).ToString.Split(chArray2)(1)), Conversions.ToInteger(current.Item(2).ToString.Split(chArray3)(2)))
            listing.Holidate = tempData
            listing.HolidayLength = Conversions.ToInteger(current.Item(3))
            listing.RequestKey = Conversions.ToInteger(current.Item(0))
            listing.RequestDate = Conversions.ToString(current.Item(6))
            Try
                listing.COMBINE()
            Catch ex As Exception

            End Try
            HolidayPendingPanel.Controls.Add(listing)
        Next
    End Sub



End Class