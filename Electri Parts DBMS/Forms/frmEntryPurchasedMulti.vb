'Created by Aldwin Mark F. Solis
'Date: November 1 2010
'Form: Multiple entry in purchased Form 

Imports System.Data.OleDb

Public Class frmEntryPurchasedMulti

    Dim StrSelect As String

#Region "Functions"

    Private Sub FillItems(ByVal Sqlstring As String)
        Me.cmbxItemNo.Items.Clear()
        Me.cmbxDescription.Items.Clear()
        CheckConnection(cn)
        oledbda.SelectCommand = New OleDbCommand(Sqlstring, cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        ds.Clear()
        oledbda.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Me.cmbxItemNo.Items.Add(dr("ItemNo"))
                Me.cmbxDescription.Items.Add(dr("Description"))
            Next
        End If
    End Sub

    Private Sub FillVendors(ByVal Sqlstring As String)
        Me.cmbxVendor.Items.Clear()
        CheckConnection(cn)
        oledbda.SelectCommand = New OleDbCommand(Sqlstring, cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        ds.Clear()
        oledbda.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                Me.cmbxVendor.Items.Add(dr("VendorName") & Space(150) & ":" & dr("Id"))
            Next
        End If
    End Sub

    Private Function SearchExistingRecords(ByVal ItemNo As String) As Boolean
        CheckConnection(cn)
        '"SELECT  SUM(tblInventory.Quantity) as Quantity,Description,tblInventory.ItemNo FROM tblInventory INNER JOIN tblItems ON tblInventory.ItemNo=tblItems.ItemNo WHERE (tblInventory.ItemNo LIKE '%" + Me.txtSearch.Text + "%' OR Description LIKE '%" + Me.txtSearch.Text + "%') GROUP BY tblInventory.ItemNo,Description"
        Dim StrSelect = "SELECT * FROM tblItems WHERE ItemNo=" & ItemNo & ""
        Dim cmd As New OleDbCommand(StrSelect, cn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader
        Reader.Read()
        If Reader.HasRows = True Then
            If Me.cmbxDescription.Text = Reader("Description") Then
                SearchExistingRecords = True
            Else
                SearchExistingRecords = False
            End If

        Else
            SearchExistingRecords = False
        End If
        'close the reader
        Reader.Close()
    End Function

    Private Function SeacrhItemID(ByVal ItemId As Integer) As Boolean

        SeacrhItemID = False

        Dim x As Integer

        For x = 0 To Me.lstvwItems.Items.Count - 1
            If Me.lstvwItems.Items(x).SubItems(2).Text = ItemId Then
                SeacrhItemID = True
                Exit For
            End If
        Next

        Return SeacrhItemID

    End Function

    Private Sub UpdateItemQuantity(ByVal ItemId As String, ByVal Quantity As Integer)

        Dim StrSelect As String

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
    Friend Sub ItemList()
        FillItems("SELECT * FROM tblItems ORDER BY [Description] ASC")
    End Sub
    Friend Sub VendorList()
        FillVendors("SELECT * FROM tblVendor ORDER BY [VendorName] ASC")
    End Sub
#End Region

    Private Sub btnAddEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddEntry.Click
        If Len(Me.txtRSNo.Text.Trim) <= 0 Then
            MsgBox("RS# is empty, please enter a valid RS#.", MsgBoxStyle.Information, "Required")
            Me.txtRSNo.Focus()
        ElseIf Me.cmbxVendor.Text = "" Then
            MsgBox("Vendor is empty, please select a Vendor in the list.", MsgBoxStyle.Information, "Required")
            Me.cmbxVendor.Focus()
        ElseIf SeacrhItemID(CInt(Me.cmbxItemNo.Text)) = True Then
            MsgBox("The item already exist in the list, can't have duplicate item entry", MsgBoxStyle.Exclamation, "")
            Me.btnAddEntry.Focus()
        Else
            If SearchExistingRecords(Me.cmbxItemNo.Text) = False Then
                MsgBox("Record does not exist in the masterlist.", MsgBoxStyle.Information, "Required")
                Me.cmbxItemNo.Focus()
                Exit Sub
            End If

            Dim MyItem = Me.lstvwItems.Items.Add(Me.txtRSNo.Text)
            With MyItem
                'Vendor
                .SubItems.Add(Me.cmbxVendor.Text)
                'Item no
                .SubItems.Add(Me.cmbxItemNo.Text)
                'Description
                .SubItems.Add(Me.cmbxDescription.Text)
                'Quantity
                .SubItems.Add(Me.txtQuantity.Text)
                'Orig. Quantity
                .SubItems.Add(Me.txtOrigQty.Text)
                'UnitCost
                .SubItems.Add(Me.lblUnitCost.Text)
            End With
        End If
    End Sub

    Private Sub frmEntryPurchasedMulti_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmEntryPurchasedMulti_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ItemList()
        VendorList()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtQuantity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQuantity.KeyDown
        ChangeSign(sender, e)
    End Sub

    Private Sub txtQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQuantity.KeyPress
        CurrencyCheckPeriod(sender, e)
    End Sub

    Private Sub txtQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuantity.TextChanged
        RestrictCurrency(sender, e)
    End Sub

    Private Sub cmbxDescription_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbxDescription.SelectedIndexChanged
        If Not Me.cmbxDescription.Text = "" Then
            CheckConnection(cn)
            Dim StrSelect = "SELECT * FROM tblItems WHERE Description='" & CSQ(Me.cmbxDescription.Text) & "'"
            Dim cmd As New OleDbCommand(StrSelect, cn)
            Dim Reader As OleDbDataReader = cmd.ExecuteReader
            Reader.Read()
            If Reader.HasRows = True Then
                Me.cmbxItemNo.Text = Reader("ItemNo")
                Me.lblUnitCost.Text = Reader("UnitCost")
            End If
            'close the reader
            Reader.Close()
            'Me.txtQuantity.Focus()
            'Me.txtQuantity.SelectAll()
        End If
    End Sub

    Private Sub txtOrigQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOrigQty.KeyDown
        ChangeSign(sender, e)
    End Sub

    Private Sub txtOrigQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOrigQty.KeyPress
        CurrencyCheckPeriod(sender, e)
    End Sub

    Private Sub txtOrigQty_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOrigQty.TextChanged
        RestrictCurrency(sender, e)
    End Sub

    Private Sub cmbxItemNo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbxItemNo.SelectedIndexChanged
        If Not Me.cmbxItemNo.Text = "" Then
            CheckConnection(cn)
            Dim StrSelect = "SELECT * FROM tblItems WHERE ItemNo=" & CSQ(Me.cmbxItemNo.Text) & ""
            Dim cmd As New OleDbCommand(StrSelect, cn)
            Dim Reader As OleDbDataReader = cmd.ExecuteReader
            Reader.Read()
            If Reader.HasRows = True Then
                Me.cmbxDescription.Text = Reader("Description")
                Me.lblUnitCost.Text = Reader("UnitCost")
            End If
            'close the reader
            Reader.Close()
            'Me.txtQuantity.Focus()
            'Me.txtQuantity.SelectAll()
        End If
    End Sub

    Private Sub cmbxItemNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbxItemNo.TextChanged
        If Not Me.cmbxItemNo.Text = "" Then
            Me.btnAddEntry.Enabled = True
        Else
            Me.btnAddEntry.Enabled = False
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Me.lstvwItems.SelectedItems(0).Remove()
    End Sub

    Private Sub btnEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnter.Click
        If Me.txtRSNo.Text = "" Then
            MsgBox("RS # is empty, please enter an RS #.", MsgBoxStyle.Information, "Required")
            Me.txtRSNo.Focus()
        ElseIf Me.cmbxItemNo.Text = "" Then
            MsgBox("Item # is empty, please select a item # in the list.", MsgBoxStyle.Information, "Required")
            Me.cmbxItemNo.Focus()
        ElseIf Me.cmbxDescription.Text = "" Then
            MsgBox("Description is empty, please select a Description in the list.", MsgBoxStyle.Information, "Required")
            Me.cmbxDescription.Focus()
        ElseIf Len(Me.txtQuantity.Text.Trim) <= 0 Then
            MsgBox("Quantity is empty, please enter a valid quantity.", MsgBoxStyle.Information, "Required")
            Me.txtQuantity.Focus()
        ElseIf Me.cmbxVendor.Text = "" Then
            MsgBox("Vendor is empty, please enter a vendor.", MsgBoxStyle.Information, "Required")
            Me.cmbxVendor.Focus()
        ElseIf Me.lstvwItems.Items.Count <= 0 Then
            MsgBox("Please enter atleast one item in the list view.", MsgBoxStyle.Information, "Required")
            Me.btnAddEntry.Focus()
        Else
            Dim x As Integer
            For x = 0 To Me.lstvwItems.Items.Count - 1
                Dim strArr(1) As String
                strArr = Me.lstvwItems.Items(x).SubItems(1).Text.Split(":")

                If frmMain.ToolStripStatusUserId.Text = "-----" Then frmMain.ToolStripStatusUserId.Text = 0
                StrSelect = "INSERT INTO tblPurchased" & _
                                    "([ItemNo],[Quantity],[OrigQuantity],[DateIn],[UnitCost],[Remarks],[Lock],[Vendor],[RSNo],[UserId])VALUES " + _
                                    "('" & CSQ(Me.lstvwItems.Items(x).SubItems(2).Text) & "','" & _
                                    "" & CSQ(Me.lstvwItems.Items(x).SubItems(4).Text) & "','" & _
                                    "" & CSQ(Me.lstvwItems.Items(x).SubItems(4).Text) & "','" & _
                                    "" & Me.dtpDate.Value & "'," & _
                                    "" & (Me.lstvwItems.Items(x).SubItems(6).Text) & ",'" & _
                                    "" & "" & "','" & _
                                    "" & 0 & " ','" & _
                                    "" & strArr(1) & " ','" & _
                                    "" & CSQ(Me.lstvwItems.Items(x).SubItems(0).Text) & _
                                    "', '" + frmMain.ToolStripStatusUserId.Text & "')"

                CheckConnection(cn)
                Dim cmdSave As New OleDbCommand(StrSelect, cn)
                cmdSave.ExecuteNonQuery()
            Next
            MsgBox("Item(s) has been successfully inserted.", MsgBoxStyle.Information, "Inserted")
            frmPurchased.ItemList()
            Me.btnCancel_Click(sender, e)
        End If

    End Sub

    Private Sub CMS_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMS.Opening
        If Me.lstvwItems.SelectedItems.Count > 0 Then
            Me.DeleteToolStripMenuItem.Enabled = True
        Else
            Me.DeleteToolStripMenuItem.Enabled = False
        End If
    End Sub

End Class