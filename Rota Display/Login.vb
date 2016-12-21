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

Public Class Login

    Private EmpList As ArrayList
    Private JustDoIt As Boolean

    Private Sub Login_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LoginBtn.Click
        Login()
    End Sub

    Private Sub Press_EnterKey(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles IDBox.KeyUp, PinBox.KeyUp
        If e.KeyCode = Keys.Return Then
            Login()
        End If
    End Sub

    Private Sub Login()
        'Test to see if the fields have been filled
        If IDBox.Text Is Nothing Then
            MsgBox("Please enter your user ID")
        ElseIf PinBox.Text Is Nothing Then
            MsgBox("Please enter your user pin")
            'Test to see if the fields have been filled properly
        ElseIf Not IsNumeric(IDBox.Text) Then
            MsgBox("The entered ID must be a number.")
        ElseIf Not IsNumeric(PinBox.Text) Then
            MsgBox("The pin must be a number.")
            'Test to see if the fields will fit properly
        ElseIf IDBox.Text > Int16.MaxValue Then
            MsgBox("Incorrect ID / Pin combination.")
            'Well if the fields are full, they contain numbers and don't break an Int16, we can check if the ID is correct
        Else
            If Forms.RotaManagerMenu.WhlEmployees.FindEmployeeByID(Convert.ToInt16(IDBox.Text)).CheckPin(PinBox.Text) Then
                Forms.RotaManagerMenu.Show()
                MyBase.Hide()
                Forms.RotaManagerMenu.employee = Forms.RotaManagerMenu.WhlEmployees.FindEmployeeByID(Convert.ToInt16(IDBox.Text))
            Else 'They must have entered an incorrect ID / Pin
                MsgBox("Incorrect ID / Pin combination.")
            End If
        End If
    End Sub

    'Let's make sure that not logging in will not result in dumb stuff
    'Because handling countless exceptions for not being logged in shouldn't be necessary
    Private Sub LoginClosed() Handles MyBase.Closed
        ProjectData.EndApp()
    End Sub

End Class