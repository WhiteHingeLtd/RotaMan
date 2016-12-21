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
Imports System.Globalization

Public Class RotaDayControls

    Private AGmessage As String
    Private AOmessage As String
    Private ARmessage As String
    Private DayOfWeek As String
    Private EmpId As Integer
    Private HasStuffChanged As Boolean = False
    Private preexisting As Boolean = False
    Private properDate As DateTime = New DateTime
    Private RawEntryId As Integer = 0
    Private Thisdate As String
    Private NewNote As Rota.RotaNote = Nothing

    Public Sub RefreshNote()

        If Not NewNote Is Nothing Then
            NotesBox.Text = NewNote.NoteText
        Else
            NotesBox.Text = ""
        End If

    End Sub

    Private Sub AcquireAttendance()
        Dim NewArray As ArrayList
        Dim InArray, OutArray, BreakArray As New ArrayList
        NewArray = WHLClasses.MySQL.SelectData("SELECT UserStatus, UserTime, UsedCard FROM whldata.log_clockcard WHERE UserId=" + EmpId.ToString + " AND UserTime Like '" + Thisdate + "%';")
        AttendRedPanel.Visible = False
        AttendOrangePanel.Visible = False
        AttendGreenPanel.Visible = False
        ARmessage = ""
        AGmessage = ""
        AOmessage = ""
        For Each NewArrayList As ArrayList In NewArray
            Dim CurrentStatus As String = NewArrayList(0).ToString
            If (NewArrayList.Count > 0) Then

                If CurrentStatus.Contains("IN") Then

                    AttendGreenPanel.Visible = True
                    'AGmessage = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(AGmessage, NewArrayList.Item(1)), " "), NewArrayList.Item(2).ToString), ChrW(13) & ChrW(10)))
                    AGmessage = AGmessage + NewArrayList.Item(1) + " " + NewArrayList.Item(2).ToString

                    PanelToolTip.SetToolTip(AttendGreenPanel, AGmessage)
                ElseIf CurrentStatus.Contains("LUNCH") Then

                    AttendOrangePanel.Visible = True
                    'AOmessage = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(AOmessage, NewArrayList.Item(1)), " "), NewArrayList.Item(2).ToString), ChrW(13) & ChrW(10)))
                    AOmessage = AOmessage + NewArrayList.Item(1) + " " + NewArrayList.Item(2).ToString

                    PanelToolTip.SetToolTip(AttendOrangePanel, AOmessage)
                ElseIf CurrentStatus.Contains("OUT") Then
                    AttendRedPanel.Visible = True

                    'ARmessage = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(ARmessage, NewArrayList.Item(1)), " "), NewArrayList.Item(2).ToString), ChrW(13) & ChrW(10)))
                    ARmessage = ARmessage + NewArrayList.Item(1) + " " + NewArrayList.Item(2).ToString
                    PanelToolTip.SetToolTip(AttendRedPanel, ARmessage)
                Else

                End If
            Else
            End If
        Next














        'InArray = WHLClasses.MySQL.SelectData("SELECT UserStatus, UserTime, UsedCard FROM whldata.log_clockcard WHERE UserId=" + EmpId.ToString + " AND UserStatus='IN' AND UserTime Like '" + Thisdate + "%';")
        'Dim list As ArrayList = InArray
        'If (list.Count > 0) Then
        '    AttendGreenPanel.Visible = True
        '    AGmessage = ""
        '    For Each current As ArrayList In list
        '        AGmessage = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(AGmessage, current.Item(1)), " "), current.Item(2).ToString), ChrW(13) & ChrW(10)))
        '    Next
        '    PanelToolTip.SetToolTip(AttendGreenPanel, AGmessage)
        'Else
        '    AttendGreenPanel.Visible = False
        'End If

        'BreakArray = WHLClasses.MySQL.SelectData("SELECT UserStatus, UserTime, UsedCard FROM whldata.log_clockcard WHERE UserId=" + EmpId.ToString + " AND UserStatus='LUNCH' AND UserTime Like '" + Thisdate + "%';")
        'Dim list3 As ArrayList = BreakArray
        'If (list3.Count > 0) Then
        '    AttendOrangePanel.Visible = True
        '    AOmessage = ""
        '    For Each current As ArrayList In list3
        '        AOmessage = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(AOmessage, current.Item(1)), " "), current.Item(2).ToString), ChrW(13) & ChrW(10)))
        '    Next
        '    PanelToolTip.SetToolTip(AttendOrangePanel, AOmessage)
        'Else
        '    AttendOrangePanel.Visible = False
        'End If

        'OutArray = WHLClasses.MySQL.SelectData("SELECT UserStatus, UserTime, UsedCard FROM whldata.log_clockcard WHERE UserId=" + EmpId.ToString + " AND UserStatus='OUT' AND UserTime Like '" + Thisdate + "%';")

        'Dim list5 As ArrayList = OutArray
        'If (list5.Count > 0) Then
        '    AttendRedPanel.Visible = True
        '    ARmessage = ""
        '    For Each current As ArrayList In list5
        '        ARmessage = Conversions.ToString(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(ARmessage, current.Item(1)), " "), current.Item(2).ToString), ChrW(13) & ChrW(10)))
        '    Next
        '    PanelToolTip.SetToolTip(AttendRedPanel, ARmessage)
        'Else
        '    AttendRedPanel.Visible = False
        'End If

    End Sub

    Function isDivisible(x As Integer, d As Integer) As Boolean
        Return (x Mod d) = 0
    End Function


    Private Sub LoadRotaDay()

        HasStuffChanged = False
        Try
            Dim RotaNote As Rota.RotaNote = Rota.GetRotaNote(RawEntryId)
            NewNote = RotaNote
            NotesBox.Text = NewNote.NoteText
        Catch ex As Rota.RotaException

        End Try

        If Not NotesBox.Text = "" Then
            NotesBox.BackColor = Color.DarkOrange
        Else
            NotesBox.BackColor = Color.WhiteSmoke
        End If

    End Sub

    Public Sub SaveRotaDay()
    End Sub

    Private Sub RotaDayStart_TextChanged(sender As Object, e As EventArgs) Handles RotaDayStart.TextChanged
        HasStuffChanged = True
    End Sub

    Private Sub RotaDayEnd_TextChanged(sender As Object, e As EventArgs)
        HasStuffChanged = True
    End Sub


    Private Sub AttendGreen_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles AttendRedPanel.Click
        MsgBox(AGmessage)
    End Sub

    Private Sub AttendOrange_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles AttendRedPanel.Click
        MsgBox(AOmessage)
    End Sub

    Private Sub AttendRed_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles AttendRedPanel.Click
        MsgBox(ARmessage)
    End Sub

    Public Property TargetDate As String
        Get
            Return Me.Thisdate
        End Get
        Set(ByVal value As String)
            If Not IsNothing(value) Then
                Me.Thisdate = value
                Me.DateDisplay.Text = value
                NewNote = Nothing
                Dim separator As Char() = New Char() {"/"c}
                Dim chArray2 As Char() = New Char() {"/"c}
                Dim chArray3 As Char() = New Char() {"/"c}
                Me.properDate = New DateTime(Conversions.ToInteger(value.Split(separator)(2)), Conversions.ToInteger(value.Split(chArray2)(1)), Conversions.ToInteger(value.Split(chArray3)(0)))


                Me.LoadRotaDay()

                Try
                    If (DateTime.Compare(Me.properDate.AddDays(1), DateAndTime.Now) < 0) Then
                        Me.AttendPanel.Visible = True
                        Me.AcquireAttendance()
                    Else
                        Me.AttendPanel.Visible = False
                    End If
                Catch exception1 As Exception
                    ProjectData.SetProjectError(exception1)
                    Dim exception As Exception = exception1
                    ProjectData.ClearProjectError()
                End Try
            End If

        End Set
    End Property

    Public Property EmployeeId As Integer
        Get
            Return Me.EmpId
        End Get
        Set(ByVal value As Integer)
            Me.EmpId = value
        End Set
    End Property

    Public Property TargetDOW As String
        Get
            Return Me.DayOfWeek
        End Get
        Set(ByVal value As String)
            Me.DayOfWeek = value
        End Set
    End Property

    Private Sub NotesBox_LeaveFocus(sender As Object, e As EventArgs) Handles NotesBox.Leave

        If IsNothing(NewNote) Then
            NewNote = Rota.CreateNoteForRotaID(RawEntryId, RotaManagerMenu.employee)
        End If
        NewNote.UpdateNoteText(NotesBox.Text, RotaManagerMenu.employee)

        If Not NotesBox.Text = "" Then
            NotesBox.BackColor = Color.DarkOrange
        Else
            NotesBox.BackColor = Color.WhiteSmoke
        End If

    End Sub

End Class
