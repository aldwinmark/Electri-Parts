'Created by Aldwin Mark F. Solis
'Date: July 3 2010
'Form: User Account Form 

Imports System.Data.OleDb

Public Class frmEntryUserAccount

    Dim StrSelect As String

#Region "Varaible declaration"
    Friend Id As Integer
#End Region

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        If Me.cmbxUserLevel.Text = "" Then
            MsgBox("User level is empty, please select a user level in the list.", MsgBoxStyle.Information, "Required")
            Me.cmbxUserLevel.Focus()
        ElseIf Len(Me.txtUsername.Text.Trim) <= 0 Then
            MsgBox("Username is empty, please enter a valid username.", MsgBoxStyle.Information, "Required")
            Me.txtUsername.Focus()
        ElseIf Len(Me.txtUsername.Text.Trim) < 6 Then
            MsgBox("Username is <6 character, please enter a valid username.", MsgBoxStyle.Information, "Required")
            Me.txtUsername.Focus()
        ElseIf Len(Me.txtPassword.Text.Trim) <= 0 Then
            MsgBox("Password is empty, please enter a valid password.", MsgBoxStyle.Information, "Required")
            Me.txtPassword.Focus()
        ElseIf Len(Me.txtPassword.Text.Trim) < 5 Then
            MsgBox("Password is <5 character, please enter a valid Password.", MsgBoxStyle.Information, "Required")
            Me.txtPassword.Focus()
        ElseIf Not Me.txtPassword.Text = Me.txtConfirmed.Text Then
            MsgBox("The password entered is not equal to the confirmed password.", MsgBoxStyle.Information, "Required")
            Me.txtConfirmed.Focus()
        Else
            If Me.btnEnter.Text = "&Save" Then
                StrSelect = "INSERT INTO tblUserAccount" & _
                                    "([Username],[Password],[UserLevel])VALUES " + _
                                    "('" + (Me.txtUsername.Text) + "','" + _
                                    "" + (Me.txtPassword.Text) + _
                                    "', '" + Me.cmbxUserLevel.Text + "')"

                CheckConnection(cn)
                Dim cmdSave As New OleDbCommand(StrSelect, cn)
                cmdSave.ExecuteNonQuery()
                MsgBox(Me.txtUsername.Text & " user account has been successfully saved.", MsgBoxStyle.Information, "Saved")
            Else
                'update the record
                StrSelect = "UPDATE tblUserAccount SET " & _
                "[Username]='" & CSQ(Me.txtUsername.Text) & _
                "',[Password]='" & CSQ(Me.txtPassword.Text) & _
                "',[UserLevel]='" & CSQ(Me.cmbxUserLevel.Text) & _
                "'WHERE Id=" & Id & ""

                CheckConnection(cn)

                Dim cmd As New OleDbCommand(StrSelect, cn)
                cmd.ExecuteNonQuery()
                MsgBox(Me.txtUsername.Text & " user account has been successfully updated.", MsgBoxStyle.Information, "Updated")
            End If
            frmUserAccount.UserAccountList()
            Me.btnCancel_Click(sender, e)
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmEntryUserAccount_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

End Class