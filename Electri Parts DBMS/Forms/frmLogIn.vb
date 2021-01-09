Imports System.Data.OleDb

Public Class frmLogIn

    'Created by Aldwin Mark F. Solis
    'Date: July 2 2010
    'Form: Main Form 

#Region "Variable Declaration"
    Friend Level As Integer
#End Region

#Region "Functions"

#End Region

#Region "Loading List"

#End Region

#Region "Reports"

#End Region

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        'check if username textbox is not empty
        If Len(Me.txtUsername.Text.Trim) <= 0 Then
            MsgBox("Username is empty, please enter a valid username.", MsgBoxStyle.Information, "Required")
            Me.txtUsername.Focus()
        ElseIf Len(Me.txtPassword.Text.Trim) <= 0 Then
            MsgBox("Password is empty, please enter a valid password.", MsgBoxStyle.Information, "Required")
            Me.txtPassword.Focus()
        ElseIf Len(Me.txtBranch.Text.Trim) <= 0 Then
            MsgBox("Branch is empty, please enter a valid Branch.", MsgBoxStyle.Information, "Required")
            Me.txtBranch.Focus()
        Else
            CheckConnection(cn)
            Dim StrSelect = "SELECT * FROM tblUserAccount WHERE Username='" & CSQ(Me.txtUsername.Text) & "' AND Password = '" & CSQ(Me.txtPassword.Text) & "'"
            Dim cmd As New OleDbCommand(StrSelect, cn)
            Dim Reader As OleDbDataReader = cmd.ExecuteReader
            Reader.Read()
            If Reader.HasRows = True Then
                Level = Reader("UserLevel")
                With frmMain

                    .ToolStripStatuslblUsername.Text = Reader("Username")
                    .ToolStripStatuslblLevel.Text = Reader("UserLevel")
                    .ToolStripStatusUserId.Text = Reader("Id")
                    .lblBranchName.Text = Me.txtBranch.Text

                    If Level = 1 Then
                        .MaintenanceToolStripMenuItem.Visible = True
                        .MasterDataToolStripMenuItem.Visible = True
                        .ItemsToolStripMenuItem.Visible = True
                        .MaintenanceToolStripMenuItem.Visible = True
                        frmPurchased.chkbxReadOnly.Checked = False
                    ElseIf Level = 2 Then
                        frmPurchased.chkbxReadOnly.Checked = False
                        .MasterDataToolStripMenuItem.Visible = True
                        .ItemsToolStripMenuItem.Visible = False
                        .MaintenanceToolStripMenuItem.Visible = False
                    ElseIf Level = 3 Then
                        frmPurchased.StartAccum = True
                        frmPurchased.chkbxReadOnly.Checked = True
                        .MaintenanceToolStripMenuItem.Visible = False
                        .MasterDataToolStripMenuItem.Visible = False
                    End If

                End With
                Me.Close()
            Else
                MsgBox("Username or password is invalid, please enter a valid username or password.", MsgBoxStyle.Information, "invalid username or password")
                Me.txtUsername.Focus()
            End If

            'close the reader
            Reader.Close()
        End If

    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        If MessageBox.Show("Are you sure you want to quit the application?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub frmLogIn_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub txtUsername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsername.KeyDown
        NextControlSelect(Me, e)
    End Sub

    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        NextControlSelect(Me, e)
    End Sub

    Private Sub txtBranch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBranch.KeyDown
        NextControlSelect(Me, e)
    End Sub

End Class