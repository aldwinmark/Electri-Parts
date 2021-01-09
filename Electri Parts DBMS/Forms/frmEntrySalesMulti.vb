'Created by Aldwin Mark F. Solis
'Date: August 6 2010
'Form: Multiple entry in sales Form 

Imports System.Data.OleDb

Public Class frmEntrySalesMulti

#Region "Varaible declaration"
    Friend Id As Integer
    Friend OrigQuantity As Integer
    Private num As Integer = 200
    Private StrSelect As String
    Private x As Integer
#End Region

#Region "Functions"

    Private Function SeacrhItemID(ByVal ItemId As Integer) As Boolean

        SeacrhItemID = False

        Dim x As Integer

        For x = 0 To Me.lstvwItems.Items.Count - 1
            If Me.lstvwItems.Items(x).Text = ItemId Then
                SeacrhItemID = True
                Exit For
            End If
        Next

        Return SeacrhItemID

    End Function

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

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        frmSearchItem.AddMulti = True
        frmSearchItem.ShowDialog()
        frmSearchItem.txtSearch.Focus()
    End Sub

    Private Sub btnAddEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddEntry.Click
        If Len(Me.txtDRNo.Text.Trim) <= 0 Then
            MsgBox("DR# is empty, please enter a valid DR#.", MsgBoxStyle.Information, "Required")
            Me.txtDRNo.Focus()
        ElseIf Me.cmbxCustomer.Text = "" Then
            MsgBox("Customer is empty, please select a Customer in the list.", MsgBoxStyle.Information, "Required")
            Me.cmbxCustomer.Focus()
        ElseIf SeacrhItemID(CInt(Me.txtItemId.Text)) = True Then
            MsgBox("The item already exist in the list, can't have duplicate item entry", MsgBoxStyle.Exclamation, "")
            Me.btnSearch.Focus()
            'ElseIf CInt(Me.lblTotalQuantity.Text) < CInt(Me.txtQuantity.Text) Then
            '    MsgBox("The quantity is less than the total quantity in the inventory", MsgBoxStyle.Exclamation, "")
            '    Me.txtQuantity.Focus()
        Else
            Dim MyItem = Me.lstvwItems.Items.Add(Me.txtItemId.Text)
            With MyItem
                'ItemNo
                .SubItems.Add(Me.txtItemNo.Text)
                'Description
                .SubItems.Add(Me.lblDescription.Text)
                'Quantity
                .SubItems.Add(Me.txtQuantity.Text)
                'TotalQuantity
                .SubItems.Add(Me.lblTotalQuantity.Text)
                'Sales price
                .SubItems.Add(Me.txtSalesPrice.Text)
                'SAP
                .SubItems.Add(Me.txtSAP.Text)
                'Commision
                .SubItems.Add(Me.txtCommision.Text)
                'Unit Cost
                .SubItems.Add(Me.txtUnitCost.Text)
                'DRNo
                .SubItems.Add(Me.txtDRNo.Text)
                'Customer
                .SubItems.Add(Me.cmbxCustomer.Text)
            End With
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Me.lstvwItems.SelectedItems(0).Remove()
    End Sub

    Private Sub frmEntrySalesMulti_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmEntrySalesMulti_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.btnEnter.Text = "&Save" Then
            CustomerList()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtSalesPrice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSalesPrice.KeyDown
        NextControlSelect(Me, e)
    End Sub

    Private Sub txtSalesPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSalesPrice.TextChanged
        ComputeCommision()
    End Sub

    Private Sub txtSAP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSAP.KeyDown
        NextControlSelect(Me, e)
    End Sub

    Private Sub txtSAP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSAP.TextChanged
        ComputeCommision()
    End Sub

    Private Sub CMS_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMS.Opening
        If Me.lstvwItems.SelectedItems.Count <= 0 Then
            Me.DeleteToolStripMenuItem.Enabled = False
        Else
            Me.DeleteToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub dtpDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDate.KeyDown
        NextControlSelect(Me, e)
    End Sub

    Private Sub txtDRNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDRNo.KeyDown
        NextControlSelect(Me, e)
    End Sub

    Private Sub cmbxCustomer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbxCustomer.KeyDown
        NextControlSelect(Me, e)
    End Sub

    Private Sub txtCommision_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCommision.KeyDown
        NextControlSelect(Me, e)
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        If Len(Me.txtDRNo.Text.Trim) <= 0 Then
            MsgBox("DR# is empty, please enter a valid DR#.", MsgBoxStyle.Information, "Required")
            Me.txtDRNo.Focus()
        ElseIf Me.cmbxCustomer.Text = "" Then
            MsgBox("Customer is empty, please select a Customer in the list.", MsgBoxStyle.Information, "Required")
            Me.cmbxCustomer.Focus()
        ElseIf Me.lstvwItems.Items.Count <= 0 Then
            MsgBox("Please enter atleast one item in the list view.", MsgBoxStyle.Information, "Required")
            Me.btnSearch.Focus()
        Else
            For x = 0 To Me.lstvwItems.Items.Count - 1

                If frmMain.ToolStripStatusUserId.Text = "-----" Then frmMain.ToolStripStatusUserId.Text = 0

                StrSelect = "INSERT INTO tblSales" & _
                                    "(DRNo,CustomerName,ItemNo,[Quantity],[ActualSP],[Commision],[SalesAgentPrice],[ActualUC],[UserId],[Lock],[Remarks],[DateSales])VALUES " + _
                                    "('" & CSQ(Me.lstvwItems.Items(x).SubItems(9).Text) & "'," & _
                                    "'" & CSQ(Me.lstvwItems.Items(x).SubItems(10).Text) & "'," & _
                                    "'" & Me.lstvwItems.Items(x).SubItems(0).Text & "'," & _
                                    "'" & CInt(Me.lstvwItems.Items(x).SubItems(3).Text) & "'," & _
                                    "'" & CDbl(Me.lstvwItems.Items(x).SubItems(5).Text) & "'," & _
                                    "'" & CDbl(Me.lstvwItems.Items(x).SubItems(7).Text) & "'," & _
                                    "'" & CDbl(Me.lstvwItems.Items(x).SubItems(6).Text) & "'," + _
                                    "'" & CDbl(Me.lstvwItems.Items(x).SubItems(8).Text) & "'," + _
                                    "'" & frmMain.ToolStripStatusUserId.Text & "'," & _
                                    "'" & 0 & "'," & _
                                    "'" & "" & "'," & _
                                    "'" & Me.dtpDate.Value & "')"

                CheckConnection(cn)
                Dim cmdSave As New OleDbCommand(StrSelect, cn)
                cmdSave.ExecuteNonQuery()

                UpdateItemQuantity(Me.lstvwItems.Items(x).SubItems(0).Text, CInt(Me.lstvwItems.Items(x).SubItems(4).Text) - CInt(Me.lstvwItems.Items(x).SubItems(3).Text))

            Next
            MsgBox("Item(s) has been successfully inserted.", MsgBoxStyle.Information, "Inserted")
            frmSales.ItemList()
            Me.btnCancel_Click(sender, e)
        End If
    End Sub

End Class