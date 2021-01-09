'Created by Aldwin Mark F. Solis
'Date: July 4 2010
'Form: Inventory Form 

Imports System.Data.OleDb

Public Class frmPurchased

#Region "Variable Declaration"
    Friend StartAccum As Boolean
#End Region

#Region "Functions"

    Private Sub UpdateLockItems(ByVal Id As Integer, ByVal Check As Integer)
        Dim StrSelect As String
        'update the record
        StrSelect = "UPDATE tblPurchased SET " & _
        "[Lock]='" & Check & "'" & _
        "WHERE Id=" & Id & ""

        CheckConnection(cn)

        Dim cmd As New OleDbCommand(StrSelect, cn)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub FillIPurchased(ByVal SqlString As String)
        Me.lstvwItems.Items.Clear()
        ds.Clear()

        oledbda.SelectCommand = New OleDbCommand(SqlString, cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        oledbda.Fill(ds)

        Me.lblTotalList.Text = FormatNumber(ds.Tables(0).Rows.Count, 0)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows

                Dim MyItem = Me.lstvwItems.Items.Add(dr("tblPurchased.Id"))
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("tblPurchased.ItemNo"))
                    .SubItems.Add(Trim(dr("Description")))
                    .SubItems.Add(Trim(dr("VendorName")))
                    .SubItems.Add(FormatNumber(dr("tblPurchased.UnitCost")))
                    .SubItems.Add(dr("Quantity"))
                    .SubItems.Add(dr("DateIn"))
                    .SubItems.Add(dr("tblVendor.Id"))
                    .SubItems.Add(dr("Remarks"))
                    .SubItems.Add(dr("Lock"))
                    .SubItems.Add(dr("OrigQuantity"))
                    .SubItems.Add(dr("RSNo"))
                End With
            Next
        End If
        cn.Close()

        Dim y As Integer

        For y = 0 To Me.lstvwItems.Items.Count - 1
            If Len(Trim(Me.lstvwItems.Items(y).SubItems(8).Text)) > 0 Then
                Me.lstvwItems.Items(y).BackColor = Color.Red
            End If
        Next

        Dim z As Integer
        For z = 0 To Me.lstvwItems.Items.Count - 1
            If CInt(Me.lstvwItems.Items(z).SubItems(9).Text) = 1 Then
                Me.lstvwItems.Items(z).Checked = True
            Else
                Me.lstvwItems.Items(z).Checked = False
            End If

        Next

    End Sub

    Private Sub FillIInventoryAcc(ByVal SqlString As String)
        Me.lstvwAccumulated.Items.Clear()
        ds.Clear()

        oledbda.SelectCommand = New OleDbCommand(SqlString, cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        oledbda.Fill(ds)

        Me.lblTotalList.Text = FormatNumber(ds.Tables(0).Rows.Count, 0)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows

                Dim MyItem = Me.lstvwAccumulated.Items.Add(dr("ItemNo"))
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("Description"))
                    .SubItems.Add(dr("AccQuantity"))
                    .SubItems.Add(dr("TotalQuantity"))
                End With
            Next
        End If
        cn.Close()
    End Sub

    Private Sub CheckAll(ByVal lstvw As ListView, ByVal check As Boolean)
        Dim j As Integer
        If Me.lstvwItems.Items.Count > 0 Then
            For j = 0 To lstvw.Items.Count - 1
                If check = True Then
                    lstvw.Items(j).Checked = True
                Else
                    lstvw.Items(j).Checked = False
                End If
            Next
        Else
            MsgBox("No item to lock", MsgBoxStyle.Information, "Item locked")
        End If

    End Sub

#End Region

#Region "Loading List"
    Friend Sub ItemList()

        Dim Field As String
        Dim Perc As String
        Dim SearchType As String
        Dim SortType As String
        Dim strArr(2) As String

        If StartAccum = True Then
            Me.cmbxSortAcc.Text = "1-Item#"
            Me.cmbxSortIndi.Text = "1-Item#"
            StartAccum = False
        End If

        'Ascending and Descending
        If Me.rbtnAsc.Checked = True Then
            SortType = "ASC"
        Else
            SortType = "DESC"
        End If

        If Me.chkbxReadOnly.CheckState = False Then

            Me.cmbxSortAcc.Visible = False
            Me.cmbxSortIndi.Visible = True

            strArr = Me.cmbxSortIndi.Text.Split("-")
            If strArr(0) = 1 Then
                If Not Len(Trim(Me.txtSearch.Text)) = 0 Then
                    Field = "tblPurchased.ItemNo"
                    SearchType = "LIKE '"
                    Perc = "'"
                Else
                    Field = "tblPurchased.ItemNo"
                    SearchType = "LIKE '"
                    Perc = "%'"
                End If
            ElseIf strArr(0) = 2 Then
                Field = "Description"
                SearchType = "LIKE '"
                Perc = "%'"
            ElseIf strArr(0) = 3 Then
                Field = "VendorName"
                SearchType = "LIKE '"
                Perc = "%'"
            Else
                If Not Len(Trim(Me.txtSearch.Text)) = 0 Then
                    Field = "Quantity"
                    SearchType = "LIKE '"
                    Perc = "'"
                Else
                    Field = "Quantity"
                    SearchType = "LIKE '"
                    Perc = "%'"
                End If
            End If

            Me.lstvwAccumulated.Visible = False
            Me.lstvwItems.Visible = True

            If Me.grpbxDate.Enabled = True Then
                FillIPurchased("SELECT * FROM vwPurchasedItems WHERE " & Field & " " & SearchType & CSQ(Me.txtSearch.Text) & Perc & "  AND DateIn >=#" & Me.dtpStart.Value.ToShortDateString & " 12:00:00 AM# AND DateIn <#" & Me.dtpEnd.Value.AddDays(1).ToShortDateString & " 12:00:00 AM# ORDER BY " & "tblPurchased.ID" & " " & SortType & "")
            Else
                FillIPurchased("SELECT TOP 50 * FROM vwPurchasedItems WHERE " & Field & " " & SearchType & CSQ(Me.txtSearch.Text) & Perc & "  ORDER BY " & "tblPurchased.ID" & " " & SortType & "")
            End If
        Else
            Me.cmbxSortAcc.Visible = True
            Me.cmbxSortIndi.Visible = False

            strArr = Me.cmbxSortAcc.Text.Split("-")
            If strArr(0) = 1 Then
                If Not Len(Trim(Me.txtSearch.Text)) = 0 Then
                    Field = "ItemNo"
                    SearchType = "LIKE '"
                    Perc = "'"
                Else
                    Field = "ItemNo"
                    SearchType = "LIKE '"
                    Perc = "%'"
                End If
            Else
                Field = "Description"
                SearchType = "LIKE '"
                Perc = "%'"
            End If

            Me.lstvwAccumulated.Visible = True
            Me.lstvwItems.Visible = False

            FillIInventoryAcc("SELECT * FROM vwTotalPurchasedItems WHERE " & Field & " " & SearchType & CSQ(Me.txtSearch.Text) & Perc & " ORDER BY " & Field & " " & SortType & "")
        End If

        'hide the unit cost column
        If frmMain.ToolStripStatuslblLevel.Text = "1" Then
            Me.lstvwItems.Columns.Item(4).Text = "Unit Cost"
            Me.lstvwItems.Columns.Item(4).Width = 90
        Else
            Me.lstvwItems.Columns.Item(4).Text = ""
            Me.lstvwItems.Columns.Item(4).Width = 0
        End If

    End Sub
#End Region

#Region "Reports"

#End Region

    Private Sub frmInventory_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cmbxSortIndi.Text = "1-Item#"
        Me.cmbxSortAcc.Text = "1-Item#"
        ItemList()
        If frmMain.ToolStripStatuslblLevel.Text = "1" Then
            Me.grpbxLock.Visible = True
            Me.lstvwItems.CheckBoxes = True
            Me.lstvwItems.Columns.Item(0).Width = 20
        Else
            Me.grpbxLock.Visible = False
            Me.lstvwItems.CheckBoxes = False
            Me.lstvwItems.Columns.Item(0).Width = 0
        End If

    End Sub

    Private Sub CMS_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMS.Opening

        If frmMain.ToolStripStatuslblLevel.Text = "1" Then
            Me.AddToolStripMenuItem.Enabled = True
            Me.AddMultiToolStripMenuItem.Enabled = True
        ElseIf frmMain.ToolStripStatuslblLevel.Text = "2" Then
            Me.AddToolStripMenuItem.Enabled = True
            Me.AddMultiToolStripMenuItem.Enabled = True
        ElseIf frmMain.ToolStripStatuslblLevel.Text = "3" Then
            Me.AddToolStripMenuItem.Enabled = False
            Me.AddMultiToolStripMenuItem.Enabled = True
        End If

        If (Me.lstvwItems.Items.Count > 0 And Me.lstvwItems.SelectedItems.Count > 0) Then
            If frmMain.ToolStripStatuslblLevel.Text = "1" Then
                Me.EditToolStripMenuItem.Enabled = True
                Me.DeleteToolStripMenuItem.Enabled = True
                Me.AdjToolStripMenuItem.Enabled = True
            ElseIf frmMain.ToolStripStatuslblLevel.Text = "2" Then
                Me.EditToolStripMenuItem.Enabled = True
                Me.DeleteToolStripMenuItem.Enabled = False
                Me.AdjToolStripMenuItem.Enabled = False
            ElseIf frmMain.ToolStripStatuslblLevel.Text = "3" Then
                Me.EditToolStripMenuItem.Enabled = False
                Me.DeleteToolStripMenuItem.Enabled = False
                Me.AdjToolStripMenuItem.Enabled = False
            End If
        Else
            Me.EditToolStripMenuItem.Enabled = False
            Me.DeleteToolStripMenuItem.Enabled = False
            Me.AdjToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        ItemList()
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        With frmEntryPurchased
            .dtpDate.Text = Date.Now
            .txtOrigQty.Enabled = False
            .cmbxItemNo.Focus()
            .btnEnter.Text = "&Save"
            .ShowDialog()
        End With
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click

        If CInt(Me.lstvwItems.SelectedItems(0).SubItems(9).Text) = 0 Then
            With frmEntryPurchased
                .ItemList()
                .VendorList()
                .Id = Me.lstvwItems.SelectedItems(0).SubItems(0).Text
                .cmbxItemNo.Text = Me.lstvwItems.SelectedItems(0).SubItems(1).Text
                .cmbxDescription.Text = Me.lstvwItems.SelectedItems(0).SubItems(2).Text
                .cmbxVendor.Text = Me.lstvwItems.SelectedItems(0).SubItems(3).Text & Space(150) & ":" & Me.lstvwItems.SelectedItems(0).SubItems(7).Text

                .dtpDate.Value = CDate(Me.lstvwItems.SelectedItems(0).SubItems(6).Text)

                .txtQuantity.Text = FormatNumber(Me.lstvwItems.SelectedItems(0).SubItems(5).Text, 0)
                .txtOrigQty.Text = FormatNumber(Me.lstvwItems.SelectedItems(0).SubItems(10).Text, 0)

                If frmMain.ToolStripStatuslblLevel.Text = "1" Then
                    .txtOrigQty.Enabled = True
                Else
                    .txtOrigQty.Enabled = False
                End If

                .txtRSNo.Text = Me.lstvwItems.SelectedItems(0).SubItems(11).Text
                .btnEnter.Text = "&Update"
                .cmbxItemNo.Focus()
                .ShowDialog()
            End With
        Else
            MsgBox("The selected item can't be edited beacause it is locked.", MsgBoxStyle.Critical, "Item lock")
        End If

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If CInt(Me.lstvwItems.SelectedItems(0).SubItems(9).Text) = 0 Then
            Dim StrSelect As String
            If MessageBox.Show("Are you sure you want to delete Item " + Me.lstvwItems.SelectedItems(0).SubItems(1).Text + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                StrSelect = "DELETE FROM tblPurchased " & _
                     "WHERE Id = " + Me.lstvwItems.SelectedItems(0).Text + ""

                CheckConnection(cn)

                Dim cmd As New OleDbCommand(StrSelect, cn)

                cmd.ExecuteNonQuery()
                MsgBox(Me.lstvwItems.SelectedItems(0).SubItems(1).Text & " has been successfully deleted.", MsgBoxStyle.Information, "")
                ItemList()
            End If
        Else
            MsgBox("The selected item can't be deleted beacause it is locked.", MsgBoxStyle.Critical, "Item lock")
        End If
    End Sub

    'Private Sub dtpMain_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpStart.ValueChanged
    '    If Me.dtpStart.Value.Date > Me.dtpEnd.Value.Date Then
    '        Me.dtpEnd.Value = Me.dtpStart.Value.Date.AddDays(1)
    '    End If
    'End Sub

    Private Sub chkbxAccumulated_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxReadOnly.CheckedChanged
        ItemList()
        Me.txtSearch.Focus()
        If Me.chkbxReadOnly.CheckState = CheckState.Checked Or Me.chckbxDormant.Checked = True Then
            Me.grpbxDate.Enabled = False
        Else
            Me.grpbxDate.Enabled = True
        End If
    End Sub

    'Private Sub dtpEnd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpEnd.ValueChanged
    '    If Me.dtpEnd.Value.Date < Me.dtpStart.Value.Date Then
    '        MsgBox("Invalid ending date, please enter a valid ending date.", MsgBoxStyle.Exclamation, "Invalid")
    '        Me.dtpEnd.Value = Me.dtpStart.Value.Date.AddDays(1)
    '    End If
    'End Sub

    Private Sub cmbxSort_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbxSortIndi.DropDownClosed
        Me.ItemList()
    End Sub

    Private Sub rbtnAsc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnAsc.Click
        ItemList()
    End Sub

    Private Sub rbtnDesc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnDesc.Click
        ItemList()
    End Sub

    Private Sub AdjToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdjToolStripMenuItem.Click
        With frmAdjustment
            .Adjtbl = 0
            .txtQuantity.Text = CInt(Me.lstvwItems.SelectedItems(0).SubItems(5).Text)
            .Id = Me.lstvwItems.SelectedItems(0).Text
            .lblItemNo.Text = Me.lstvwItems.SelectedItems(0).SubItems(1).Text
            .lblDescription.Text = Me.lstvwItems.SelectedItems(0).SubItems(2).Text
            .txtRemarks.Text = Me.lstvwItems.SelectedItems(0).SubItems(8).Text
            .btnEnter.Text = "&Update"
            .ShowDialog()
            .txtQuantity.Focus()
        End With
    End Sub

    Private Sub btnCheckAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckAll.Click
        CheckAll(Me.lstvwItems, True)
    End Sub

    Private Sub btnUncheckAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUncheckAll.Click
        CheckAll(Me.lstvwItems, False)
    End Sub

    Private Sub btnLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLock.Click
        Dim x As Integer
        If Me.lstvwItems.Items.Count > 0 Then
            For x = 0 To Me.lstvwItems.Items.Count - 1
                If Me.lstvwItems.Items(x).Checked = True Then
                    UpdateLockItems(Me.lstvwItems.Items(x).SubItems(0).Text, 1)
                Else
                    UpdateLockItems(Me.lstvwItems.Items(x).SubItems(0).Text, 0)
                End If
            Next
            Me.ItemList()
            MsgBox("Items has been successfully lock.", MsgBoxStyle.Information, "Item locked")
        Else
            MsgBox("No item to lock", MsgBoxStyle.Information, "Item locked")
        End If
    End Sub

    Private Sub cmbxSort_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbxSortIndi.SelectedIndexChanged
        ItemList()
    End Sub

    Private Sub chckbxDormant_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chckbxDormant.CheckedChanged
        If Me.chckbxDormant.Checked = True Then
            Me.grpbxDate.Enabled = False
        Else
            Me.grpbxDate.Enabled = True
        End If
        ItemList()
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyData = Keys.Enter = True Then
            ItemList()
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ItemList()
    End Sub

    Private Sub AddMultiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddMultiToolStripMenuItem.Click
        frmEntryPurchasedMulti.ShowDialog()
    End Sub

End Class