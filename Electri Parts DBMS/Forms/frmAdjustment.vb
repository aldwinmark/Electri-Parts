'Created by Aldwin Mark F. Solis
'Date: July 18 2010
'Form: Adjustment Form 

Imports System.Data.OleDb

Public Class frmAdjustment

#Region "Variable Declaration"

    Dim StrSelect As String

    Friend Adjtbl As Integer
    Friend Id As Integer

#End Region

#Region "Functions"

#End Region

    Private Sub frmAdjustment_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click

        If Adjtbl = 1 Then
            'update the record
            StrSelect = "UPDATE tblSales SET " & _
            "[Remarks]='" & CSQ(Me.txtRemarks.Text) & "'," & _
            "[Quantity]='" & CInt(Me.txtQuantity.Text) & _
            "'WHERE Id=" & Id & ""

            CheckConnection(cn)

            Dim cmd As New OleDbCommand(StrSelect, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Remarks has been successfully updated.", MsgBoxStyle.Information, "Updated")
            frmSales.ItemList()
        Else
            'update the record
            StrSelect = "UPDATE tblPurchased SET " & _
            "[Remarks]='" & CSQ(Me.txtRemarks.Text) & "'," & _
            "[Quantity]='" & CInt(Me.txtQuantity.Text) & _
            "'WHERE Id=" & Id & ""

            CheckConnection(cn)

            Dim cmd As New OleDbCommand(StrSelect, cn)
            cmd.ExecuteNonQuery()
            MsgBox("Remarks has been successfully updated.", MsgBoxStyle.Information, "Updated")
            frmPurchased.ItemList()
        End If

        Me.btnCancel_Click(sender, e)

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class