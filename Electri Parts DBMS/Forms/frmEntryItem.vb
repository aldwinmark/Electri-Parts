'Created by Aldwin Mark F. Solis
'Date: July 3 2010
'Form: Item entry Form 

Imports System.Data.OleDb

Public Class frmEntryItem

    Dim StrSelect As String

#Region "Varaible declaration"
    Friend Id As Integer
#End Region

#Region "Functions"

    Private Function SearchExistingRecords(ByVal ItemNo As String) As Boolean
        CheckConnection(cn)
        '"SELECT  SUM(tblInventory.Quantity) as Quantity,Description,tblInventory.ItemNo FROM tblInventory INNER JOIN tblItems ON tblInventory.ItemNo=tblItems.ItemNo WHERE (tblInventory.ItemNo LIKE '%" + Me.txtSearch.Text + "%' OR Description LIKE '%" + Me.txtSearch.Text + "%') GROUP BY tblInventory.ItemNo,Description"
        Dim StrSelect = "SELECT * FROM tblItems WHERE ItemNo=" & ItemNo & ""
        Dim cmd As New OleDbCommand(StrSelect, cn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader
        Reader.Read()
        If Reader.HasRows = True Then
            SearchExistingRecords = True
        Else
            SearchExistingRecords = False
        End If
        'close the reader
        Reader.Close()
    End Function

#End Region

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click

        If Len(Me.txtItemNo.Text.Trim) <= 0 Then
            MsgBox("Item # is empty, please enter a valid item #.", MsgBoxStyle.Information, "Required")
            Me.txtItemNo.Focus()
        ElseIf Len(Me.txtDescription.Text.Trim) < 0 Then
            MsgBox("Description is empty, please enter a valid description.", MsgBoxStyle.Information, "Required")
            Me.txtDescription.Focus()
        Else
            If Me.btnEnter.Text = "&Save" Then

                If SearchExistingRecords(Me.txtItemNo.Text) = True Then
                    MsgBox(Me.txtItemNo.Text & " is already an existing item #, please enter another item #.", MsgBoxStyle.Information, "Invalid")
                    Me.txtItemNo.Focus()
                    Exit Sub
                End If

                StrSelect = "INSERT INTO tblItems" & _
                                    "([ItemNo],[Description],[UnitCost],[SalesPrice],[SalesAgentPrice])VALUES " + _
                                    "('" + (Me.txtItemNo.Text) + "','" + _
                                    "" + CSQ(Me.txtDescription.Text) + "','" + _
                                    "" + (Me.txtUnitCost.Text) + "','" + _
                                    "" + (Me.txtSalesPrice.Text) + _
                                    "', '" + Me.txtSAP.Text + "')"

                CheckConnection(cn)
                Dim cmdSave As New OleDbCommand(StrSelect, cn)
                cmdSave.ExecuteNonQuery()
                MsgBox(Me.txtItemNo.Text & " item# has been successfully saved.", MsgBoxStyle.Information, "Saved")
            Else
                'update the record
                StrSelect = "UPDATE tblItems SET " & _
                "[ItemNo]='" & CSQ(Me.txtItemNo.Text) & _
                "',[Description]='" & CSQ(Me.txtDescription.Text) & _
                "',[UnitCost]='" & CSQ(Me.txtUnitCost.Text) & _
                "',[SalesPrice]='" & CSQ(Me.txtSalesPrice.Text) & _
                "',[SalesAgentPrice]='" & CSQ(Me.txtSAP.Text) & _
                "'WHERE Id=" & Id & ""

                CheckConnection(cn)

                Dim cmd As New OleDbCommand(StrSelect, cn)
                cmd.ExecuteNonQuery()
                MsgBox(Me.txtItemNo.Text & " item# has been successfully updated.", MsgBoxStyle.Information, "Updated")
            End If
            frmItems.ItemList()
            Me.btnCancel_Click(sender, e)
        End If
    End Sub

    Private Sub txtUnitCost_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUnitCost.KeyDown
        NextControlSelect(Me, e)
        ChangeSign(sender, e)
    End Sub

    Private Sub txtUnitCost_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUnitCost.KeyPress
        CurrencyCheckPeriod(sender, e)
    End Sub

    Private Sub txtUnitCost_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUnitCost.TextChanged
        RestrictCurrency(sender, e)
    End Sub

    Private Sub txtSalesPrice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSalesPrice.KeyDown
        NextControlSelect(Me, e)
        ChangeSign(sender, e)
    End Sub

    Private Sub txtSalesPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSalesPrice.KeyPress
        CurrencyCheckPeriod(sender, e)
    End Sub

    Private Sub txtSalesPrice_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSalesPrice.TextChanged
        RestrictCurrency(sender, e)
    End Sub

    Private Sub frmEntryItem_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub txtSAP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSAP.KeyDown
        NextControlSelect(Me, e)
        ChangeSign(sender, e)
    End Sub

    Private Sub txtSAP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSAP.KeyPress
        CurrencyCheckPeriod(sender, e)
    End Sub

    Private Sub txtSAP_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSAP.TextChanged
        RestrictCurrency(sender, e)
    End Sub

    Private Sub txtItemNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemNo.KeyDown
        NextControlSelect(Me, e)
    End Sub

    Private Sub txtItemNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItemNo.KeyPress
        e.Handled = OnlyNumeric(Asc(e.KeyChar))
    End Sub

End Class