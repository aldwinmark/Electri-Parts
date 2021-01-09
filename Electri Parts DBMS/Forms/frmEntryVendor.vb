'Created by Aldwin Mark F. Solis
'Date: July 8 2010
'Form: Entry of vendors Form 

Imports System.Data.OleDb

Public Class frmEntryVendor

    Dim StrSelect As String

#Region "Varaible declaration"
    Friend Id As Integer
#End Region

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        If Len(Trim(Me.txtVendorName.Text)) <= 0 Then
            MsgBox("Vendor name is empty, please enter a valid Vendor name.", MsgBoxStyle.Information, "Required")
            Me.txtVendorName.Focus()
        ElseIf Len(Trim(Me.txtAddress.Text)) <= 0 Then
            MsgBox("Address is empty, please enter a valid Address.", MsgBoxStyle.Information, "Required")
            Me.txtAddress.Focus()
        ElseIf Len(Trim(Me.txtContactNo.Text)) <= 0 Then
            MsgBox("Contact # is empty, please enter a Contact #.", MsgBoxStyle.Information, "Required")
            Me.txtContactNo.Focus()
        Else
            If Me.btnEnter.Text = "&Save" Then
                StrSelect = "INSERT INTO tblVendor" & _
                                    "([VendorName],[Address],[ContactNo])VALUES(" & _
                                    "'" + CSQ(Me.txtVendorName.Text) + "'" & _
                                    ",'" + CSQ(Me.txtAddress.Text) + "'" & _
                                    ",'" + CSQ(Me.txtContactNo.Text) + "')"

                CheckConnection(cn)
                Dim cmdSave As New OleDbCommand(StrSelect, cn)

                cmdSave.ExecuteNonQuery()
                MsgBox(Me.txtVendorName.Text & " vendor has been successfully saved.", MsgBoxStyle.Information, "Saved")
            Else
                'update the record
                StrSelect = "UPDATE tblVendor SET " & _
                "[VendorName]='" & CSQ(Me.txtVendorName.Text) & _
                "',[Address]='" & CSQ(Me.txtAddress.Text) & _
                "',[ContactNo]='" & CSQ(Me.txtContactNo.Text) & _
                "'WHERE Id=" & Id & ""

                CheckConnection(cn)

                Dim cmd As New OleDbCommand(StrSelect, cn)
                cmd.ExecuteNonQuery()

                MsgBox(Me.txtVendorName.Text & " vendor has been successfully updated.", MsgBoxStyle.Information, "Updated")

            End If
            frmVendor.VendorList()
            Me.btnCancel_Click(sender, e)
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmEntryVendor_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

End Class