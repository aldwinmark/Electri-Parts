'Created by Aldwin Mark F. Solis
'Date: July 4 2010
'Form: Inventory entry Form 

Imports System.Data.OleDb

Public Class frmEntrySales

    Dim StrSelect As String

#Region "Varaible declaration"
    Friend Id As Integer
    Friend OrigQuantity As Integer
    Dim num As Integer = 200
#End Region

#Region "Functions"

    Private Sub ComputeCommision()
        If IsNumeric(Me.txtSalesPrice.Text) = True And IsNumeric(Me.txtSAP.Text) = True Then
            Me.txtCommision.Text = FormatNumber(CDbl(Me.txtSalesPrice.Text) - CDbl(Me.txtSAP.Text))
        End If
    End Sub

    Private Sub FillCustomer(ByVal Sqlstring As String)
        Me.cmbxCustomer.Items.Clear()
        CheckConnection(cn)
        oledbda.SelectCommand = New OleDbCommand(Sqlstring, cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        ds.Clear()
        oledbda.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Me.cmbxCustomer.Items.Add(dr("Company"))
            Next
        End If
    End Sub

    Private Sub UpdateItemQuantity(ByVal ItemId As String, ByVal Quantity As Integer)

        'update the record
        StrSelect = "UPDATE tblPurchased SET " & _
        "[Quantity]='" & Quantity & _
        "'WHERE Id=" & ItemId & ""

        CheckConnection(cn)
        Dim cmd As New OleDbCommand(StrSelect, cn)
        cmd.ExecuteNonQuery()
    End Sub

#End Region

#Region "Loading List"

    Friend Sub CustomerList()
        FillCustomer("SELECT * FROM tblCustomer ORDER BY [Company] ASC")
    End Sub

#End Region

    Private Sub frmEntryInventory_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmEntryInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.btnEnter.Text = "&Save" Then
            CustomerList()
        End If
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click

        If Len(Me.txtDRNo.Text.Trim) <= 0 Then
            MsgBox("DR# is empty, please enter a valid DR#.", MsgBoxStyle.Information, "Required")
            Me.txtDRNo.Focus()
        ElseIf Me.cmbxCustomer.Text = "" Then
            MsgBox("Customer is empty, please select a Customer in the list.", MsgBoxStyle.Information, "Required")
            Me.cmbxCustomer.Focus()
        ElseIf Len(Trim(Me.txtItemNo.Text)) <= 0 Or Len(Trim(Me.txtItemId.Text)) <= 0 Then
            MsgBox("Item # is empty, please search for an item # in the list.", MsgBoxStyle.Information, "Required")
            Me.btnSearch.Focus()
        ElseIf Len(Me.txtQuantity.Text.Trim) <= 0 Then
            MsgBox("Quantity is empty, please enter a valid quantity.", MsgBoxStyle.Information, "Required")
            Me.txtQuantity.Focus()
            ' ElseIf CInt(Me.txtQuantity.Text) <= 0 Then
            'MsgBox("Quantity is invalid , please enter a valid quantity.", MsgBoxStyle.Information, "Required")
            'Me.txtQuantity.Focus()
        ElseIf Len(Me.txtSalesPrice.Text.Trim) <= 0 Then
            MsgBox("Sales price is empty, please enter a valid Sales price.", MsgBoxStyle.Information, "Required")
            Me.txtSalesPrice.Focus()
            'ElseIf CInt(Me.txtSalesPrice.Text) <= 0 Then
            '    MsgBox("Sales price is invalid , please enter a valid Sales price.", MsgBoxStyle.Information, "Required")
            '    Me.txtSalesPrice.Focus()
        ElseIf Len(Me.txtCommision.Text.Trim) <= 0 Then
            MsgBox("Commission is empty, please enter a valid Commission.", MsgBoxStyle.Information, "Required")
            Me.txtCommision.Focus()
        ElseIf Len(Me.txtSAP.Text.Trim) <= 0 Then
            MsgBox("Sales agent price is empty, please enter a valid Sales agent price.", MsgBoxStyle.Information, "Required")
            Me.txtSAP.Focus()
        Else
            If frmMain.ToolStripStatusUserId.Text = "-----" Then frmMain.ToolStripStatusUserId.Text = 0

            If Me.btnEnter.Text = "&Save" Then

                'If CInt(Me.txtQuantity.Text) > CInt(Me.lblTotalQuantity.Text) Then
                '    MsgBox("Quantity is invalid , please enter a valid quantity.", MsgBoxStyle.Information, "Required")
                '    Me.txtQuantity.Focus()
                '    Exit Sub
                'End If

                If frmMain.ToolStripStatusUserId.Text = "-----" Then frmMain.ToolStripStatusUserId.Text = 0

                StrSelect = "INSERT INTO tblSales" & _
                                    "(DRNo,CustomerName,ItemNo,[Quantity],[ActualSP],[Commision],[SalesAgentPrice],[ActualUC],[UserId],[Lock],[Remarks],[DateSales])VALUES " + _
                                    "('" & CSQ(CStr(Me.txtDRNo.Text)) & "'," & _
                                    "'" & CSQ(Me.cmbxCustomer.Text) & "'," & _
                                    "'" & Me.txtItemId.Text & "'," & _
                                    "'" & CInt(Me.txtQuantity.Text) & "'," & _
                                    "'" & CDbl(Me.txtSalesPrice.Text) & "'," & _
                                    "'" & CDbl(Me.txtCommision.Text) & "'," & _
                                    "'" & CDbl(Me.txtSAP.Text) & "'," + _
                                    "'" & CDbl(Me.txtUnitCost.Text) & "'," + _
                                    "'" & frmMain.ToolStripStatusUserId.Text & "'," & _
                                    "'" & 0 & "'," & _
                                    "'" & "" & "'," & _
                                    "'" & Me.dtpDate.Value & "')"

                CheckConnection(cn)
                Dim cmdSave As New OleDbCommand(StrSelect, cn)
                cmdSave.ExecuteNonQuery()

                UpdateItemQuantity(Me.txtItemId.Text, CInt(Me.lblTotalQuantity.Text) - CInt(Me.txtQuantity.Text))
                MsgBox(Trim(Me.txtItemNo.Text) & "-" & Trim(Me.lblDescription.Text) & " item has been successfully inserted.", MsgBoxStyle.Information, "Inserted")

            Else
                'update the record
                StrSelect = "UPDATE tblSales SET " & _
                "[DRNo]='" & CSQ(Me.txtDRNo.Text) & _
                "',[CustomerName]='" & CSQ(Me.cmbxCustomer.Text) & _
                "',[ItemNo]='" & Me.txtItemId.Text & _
                "',[Quantity]='" & CInt(Me.txtQuantity.Text) & _
                "',[ActualSP]='" & CDec(Me.txtSalesPrice.Text) & _
                "',[Commision]='" & CDec(Me.txtCommision.Text) & _
                "',[SalesAgentPrice]='" & CDec(Me.txtSAP.Text) & _
                "',[UserId]='" & frmMain.ToolStripStatusUserId.Text & _
                "',[DateSales]='" & Me.dtpDate.Value & _
                "'WHERE Id=" & Id & ""

                CheckConnection(cn)

                Dim cmd As New OleDbCommand(StrSelect, cn)
                cmd.ExecuteNonQuery()

                If CInt(Me.txtQuantity.Text) > OrigQuantity Then
                    UpdateItemQuantity(Me.txtItemId.Text, CInt(Me.lblTotalQuantity.Text) - (CInt(Me.txtQuantity.Text) - CInt(OrigQuantity)))
                Else
                    UpdateItemQuantity(Me.txtItemId.Text, CInt(Me.lblTotalQuantity.Text) + (CInt(OrigQuantity) - CInt(Me.txtQuantity.Text)))
                End If

                MsgBox(Trim(Me.txtItemNo.Text) & "-" & Trim(Me.lblDescription.Text) & " item has been successfully updated.", MsgBoxStyle.Information, "Updated")
            End If
            frmSales.ItemList()
            Me.btnCancel_Click(sender, e)
            End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtQuantity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQuantity.KeyDown
        ChangeSign(sender, e)
        NextControlSelect(Me, e)
    End Sub

    Private Sub txtQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity.KeyPress
        CurrencyCheckPeriod(sender, e)
    End Sub

    Private Sub txtQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuantity.TextChanged
        RestrictCurrency(sender, e)
    End Sub

    Private Sub txtSalesPrice_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSalesPrice.GotFocus
        Me.txtSalesPrice.SelectAll()
    End Sub

    Private Sub txtSalesPrice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSalesPrice.KeyDown
        ChangeSign(sender, e)
        NextControlSelect(Me, e)
    End Sub

    Private Sub txtSalesPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSalesPrice.KeyPress
        CurrencyCheckPeriod(sender, e)
    End Sub

    Private Sub txtSalesPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSalesPrice.TextChanged
        RestrictCurrency(sender, e)
        ComputeCommision()
    End Sub

    Private Sub txtCommision_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCommision.GotFocus
        Me.txtCommision.SelectAll()
    End Sub

    Private Sub txtCommision_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCommision.KeyDown
        ChangeSign(sender, e)
        NextControlSelect(Me, e)
    End Sub

    Private Sub txtCommision_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCommision.KeyPress
        CurrencyCheckPeriod(sender, e)
    End Sub

    Private Sub txtCommision_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCommision.TextChanged
        ComputeCommision()
        RestrictCurrency(sender, e)
    End Sub

    Private Sub txtSAP_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSAP.GotFocus
        Me.txtSAP.SelectAll()
    End Sub

    Private Sub txtSAP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSAP.KeyDown
        ChangeSign(sender, e)
        NextControlSelect(Me, e)
    End Sub

    Private Sub txtSAP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSAP.KeyPress
        CurrencyCheckPeriod(sender, e)
    End Sub

    Private Sub txtSAP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSAP.TextChanged
        RestrictCurrency(sender, e)
        ComputeCommision()
    End Sub

    Private Sub cmbxItemNo_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs)
        'Me.txtQuantity.Focus()
        'Me.txtQuantity.SelectAll()
    End Sub

    Private Sub dtpDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDate.KeyDown
        NextControlSelect(Me, e)
    End Sub

    Private Sub txtDRNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDRNo.KeyDown
        NextControlSelect(Me, e)
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        frmSearchItem.AddMulti = False
        frmSearchItem.ShowDialog()
        frmSearchItem.txtSearch.Focus()
    End Sub

End Class