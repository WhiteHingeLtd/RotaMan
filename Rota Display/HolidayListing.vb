Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Rota_Display.My
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports WHLClasses

Public Class HolidayListing
    'Public EmployeeID As Integer
    'Public RequestDate As String
    'Public RequestKey As Integer
    'Public HolidayLength As Integer
    'Public Holidate As DateTime

    Private DateRequested As String
    Private Employee As ArrayList
    Private Holength As Integer
    Private HolidayKey As Integer
    Private requestid As Integer
    Private StartDate As DateTime



    Private Sub AcceptButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AcceptButton.Click
        If (MsgBox("Are you sure you want to accept this holiday and add entries to the rota? This can't be undone.", MsgBoxStyle.YesNo, "Confirm acceptance") = MsgBoxResult.Yes) Then

            Dim left As Object = MySql.insertupdate(("UPDATE whldata.holiday_request SET isApproved='Yes' WHERE requestId=" & requestid.ToString & ";"))

            If Operators.ConditionalCompareObjectEqual(left, 1, False) Then
                Dim i As Integer
                For i = 0 To Me.Holength - 1
                    Dim str As String = StartDate.AddDays(CDbl(i)).ToString("dd/MM/yyyy")
                    Dim str2 As String = DateAndTime.Now.ToString
                    Dim str3 As String = EmployeeID.ToString
                    'Dim textArray1 As String() = New String() {"INSERT INTO whldata.holiday_raw (payrollId, Date, SaveTime) VALUES (", str3, ", '", str, "', '", str2, "');"}
                    'If Not Operators.ConditionalCompareObjectEqual(MySql.insertupdate(String.Concat(textArray1)), 1, False) Then
                    'Interaction.MsgBox("Date entry could not be saved!", MsgBoxStyle.ApplicationModal, Nothing)
                    'End If
                Next i
                Forms.HolidayPendingList.UpdateList()
            Else
                MsgBox(("The approval could not be saved for some reason:" & ChrW(13) & ChrW(10) & left.ToString))
            End If
        End If
    End Sub

    Private Sub DeclineButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DeclineButton.Click
        If (Interaction.MsgBox("Are you sure you want to reject this holiday? This can't be undone.", MsgBoxStyle.YesNo, "Confirm acceptance") = MsgBoxResult.Yes) Then
            Dim left As Object = MySql.insertupdate(("DELETE FROM whldata.holiday_request WHERE requestId=" & Me.requestid.ToString & ";"))
            If Operators.ConditionalCompareObjectEqual(left, 1, False) Then
                MyProject.Forms.HolidayPendingList.UpdateList()
            Else
                Interaction.MsgBox(("The rejection could not be saved for some reason:" & ChrW(13) & ChrW(10) & left.ToString), MsgBoxStyle.ApplicationModal, Nothing)
            End If
        End If
    End Sub


    Public Sub COMBINE()
        Me.HolidayPerson.Text = Conversions.ToString(Operators.AddObject(Operators.AddObject(Me.Employee.Item(1), " "), Me.Employee.Item(2)))
        Dim textArray1 As String() = New String() {Me.StartDate.ToString("dd/MM/yyyy"), " to ", Me.StartDate.AddDays(CDbl((Me.Holength - 1))).ToString("dd/MM/yyyy"), " (", Me.Holength.ToString, " days) - Requested ", Me.DateRequested}
        Me.HolidayInfo.Text = String.Concat(textArray1)
    End Sub


    '-----Properties-----

    Public Property EmployeeID As Integer
        Get
            Return Conversions.ToInteger(Me.Employee.Item(0))
        End Get
        Set(ByVal value As Integer)
            Dim arguments As Object() = New Object() {0}
            Me.Employee = DirectCast(NewLateBinding.LateIndexGet(MySql.SelectData(("SELECT * FROM whldata.employees WHERE PayrollNo=" & value.ToString & ";")), arguments, Nothing), ArrayList)
        End Set
    End Property

    Public Property Holidate As DateTime
        Get
            Return Me.StartDate
        End Get
        Set(ByVal value As DateTime)
            Me.StartDate = value
        End Set
    End Property

    Public Property HolidayLength As Integer
        Get
            Return Me.Holength
        End Get
        Set(ByVal value As Integer)
            Me.Holength = value
        End Set
    End Property

    Public Property RequestDate As String
        Get
            Return Me.DateRequested
        End Get
        Set(ByVal value As String)
            Me.DateRequested = value
        End Set
    End Property

    Public Property RequestKey As Integer
        Get
            Return Me.requestid
        End Get
        Set(ByVal value As Integer)
            Me.requestid = value
        End Set
    End Property


End Class
