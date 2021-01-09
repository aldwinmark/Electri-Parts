'Created by Aldwin Mark F. Solis
'Date: July 3 2010
'Form: Entry of customer Form 

Imports System.Data.OleDb

Public Class frmEntryCustomer

    Dim StrSelect As String

#Region "Varaible declaration"
    Friend Id As Integer
#End Region

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        If Len(Trim(Me.txtCompany.Text)) <= 0 Then
            MsgBox("Company name is empty, please enter a valid Company name.", MsgBoxStyle.Information, "Required")
            Me.txtCompany.Focus()
        ElseIf Len(Trim(Me.txtOwner.Text)) <= 0 Then
            MsgBox("Owner/Proprietor name is empty, please enter a valid Owner/Proprietor.", MsgBoxStyle.Information, "Required")
            Me.txtOwner.Focus()
        ElseIf Len(Trim(Me.txtAddress.Text)) <= 0 Then
            MsgBox("Address is empty, please enter a valid Address.", MsgBoxStyle.Information, "Required")
            Me.txtAddress.Focus()
        ElseIf Len(Trim(Me.txtContactNo.Text)) <= 0 Then
            MsgBox("Contact no. is empty, please enter a valid Contact no.", MsgBoxStyle.Information, "Required")
            Me.txtContactNo.Focus()
        ElseIf Len(Trim(Me.txtTerms.Text)) <= 0 Then
            MsgBox("Terms is empty, please enter terms if any or none", MsgBoxStyle.Information, "<optional>")
            Me.txtTerms.Focus()
        Else
            If Me.btnEnter.Text = "&Save" Then
                StrSelect = "INSERT INTO tblCustomer" & _
                                    "([Company],[Owner],[Address],[ContactNo],[Terms])VALUES(" & _
                                    "'" + CSQ(Me.txtCompany.Text) + "'" & _
                                    ",'" + CSQ(Me.txtOwner.Text) + "'" & _
                                    ",'" + CSQ(Me.txtAddress.Text) + "'" & _
                                    ",'" + CSQ(Me.txtContactNo.Text) + "'" & _
                                    ",'" + CSQ(Me.txtTerms.Text) + "')"

                CheckConnection(cn)
                Dim cmdSave As New OleDbCommand(StrSelect, cn)

                cmdSave.ExecuteNonQuery()
                MsgBox(Me.txtCompany.Text & " customer has been successfully saved.", MsgBoxStyle.Information, "Saved")
            Else
                'update the record
                StrSelect = "UPDATE tblCustomer SET " & _
                "[Company]='" & CSQ(Me.txtCompany.Text) & _
                "',[Owner]='" & CSQ(Me.txtOwner.Text) & _
                "',[Address]='" & CSQ(Me.txtAddress.Text) & _
                "',[ContactNo]='" & CSQ(Me.txtContactNo.Text) & _
                "',[Terms]='" & CSQ(Me.txtTerms.Text) & _
                "'WHERE Id=" & Id & ""

                CheckConnection(cn)

                Dim cmd As New OleDbCommand(StrSelect, cn)
                cmd.ExecuteNonQuery()

                MsgBox(Me.txtCompany.Text & " customer has been successfully updated.", MsgBoxStyle.Information, "Updated")

            End If
            frmCustomer.CustomerList()
            Me.btnCancel_Click(sender, e)
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmEntryCustomer_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

End Class