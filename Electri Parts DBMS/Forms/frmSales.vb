'Created by Aldwin Mark F. Solis
'Date: July 3 2010
'Form: User Account Form 

Imports System.Data.OleDb

Public Class frmSales

#Region "Variable Declaration"

#End Region

#Region "Functions"

    Private Sub UpdateLockItems(ByVal Id As Integer, ByVal Check As Integer)
        Dim StrSelect As String
        'update the record
        StrSelect = "UPDATE tblSales SET " & _
        "[Lock]='" & Check & "'" & _
        "WHERE Id=" & Id & ""

        CheckConnection(cn)

        Dim cmd As New OleDbCommand(StrSelect, cn)
        cmd.ExecuteNonQuery()
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

    Private Sub FillISales(ByVal SqlString As String)

        Dim ItemNo As String
        Dim Description As String
        Dim ItemId As String

        Me.lstvwItems.Items.Clear()
        ds.Clear()

        oledbda.SelectCommand = New OleDbCommand(SqlString, cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        oledbda.Fill(ds)

        Me.lblTotalList.Text = FormatNumber(ds.Tables(0).Rows.Count, 0)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows

                Dim MyItem = Me.lstvwItems.Items.Add(dr("tblSales.Id"))
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("DRNo"))

                    If IsDBNull(dr("tblPurchased.ItemNo")) Then
                        ItemNo = "Item Deleted in the master file."
                    Else
                        ItemNo = dr("tblPurchased.ItemNo")
                    End If

                    If IsDBNull(Trim(dr("vwPurchasedItems.Description"))) Then
                        Description = "Item Deleted in the master file."
                    Else
                        Description = dr("vwPurchasedItems.Description")
                    End If

                    If IsDBNull(dr("tblPurchased.Id")) Then
                        ItemId = "Item Deleted in the master file."
                    Else
                        ItemId = dr("tblPurchased.Id")
                    End If

                    .SubItems.Add(ItemNo)
                    .SubItems.Add(Description)
                    .SubItems.Add(dr("CustomerName"))
                    .SubItems.Add(FormatNumber(dr("tblSales.Quantity"), 0))

                    .SubItems.Add(FormatNumber(dr("ActualSP")))
                    .SubItems.Add(FormatNumber(dr("TSP")))

                    .SubItems.Add(FormatNumber(dr("tblSales.SalesAgentPrice")))
                    .SubItems.Add(FormatNumber(dr("TSAP")))

                    .SubItems.Add(FormatNumber(dr("Commision")))
                    .SubItems.Add(FormatNumber(dr("TCommision")))

                    .SubItems.Add(FormatDateTime(dr("DateSales"), DateFormat.ShortDate))
                    .SubItems.Add(ItemId)
                    .SubItems.Add(dr("vwPurchasedItems.Quantity"))
                    .SubItems.Add(dr("tblSales.Remarks"))
                    .SubItems.Add(dr("tblSales.Lock"))
                End With
            Next
        End If
        cn.Close()

        Dim y As Integer

        For y = 0 To Me.lstvwItems.Items.Count - 1
            If Len(Trim(Me.lstvwItems.Items(y).SubItems(15).Text)) > 0 Then
                Me.lstvwItems.Items(y).BackColor = Color.Red
            End If
        Next

        Dim z As Integer
        For z = 0 To Me.lstvwItems.Items.Count - 1
            If CInt(Me.lstvwItems.Items(z).SubItems(16).Text) = 1 Then
                Me.lstvwItems.Items(z).Checked = True
            Else
                Me.lstvwItems.Items(z).Checked = False
            End If
        Next

    End Sub

    Private Sub UpdateQuantity(ByVal Id As String, ByVal Quantity As Integer)
        Dim StrSelect As String
        'ArrStr = ItemId.Split("$")

        'update the record
        StrSelect = "UPDATE tblPurchased SET " & _
        "[Quantity]='" & Quantity & _
        "'WHERE Id=" & Id & ""

        CheckConnection(cn)
        Dim cmd As New OleDbCommand(StrSelect, cn)
        cmd.ExecuteNonQuery()
    End Sub

#End Region

#Region "Loading List"

    Friend Sub ItemList()
        'FillIPurchased("SELECT * FROM tblPurchased INNER JOIN tblItems ON tblPurchased.ItemNo=tblItems.ItemNo WHERE  DatePurchased >= #" & Format(Me.dtpMain.Value, "MM-dd-yyyy") & "# AND DateIn < #" & Format(Me.dtpMain.Value.AddDays(1), "MM-dd-yyyy") & "#  AND (tblItems.ItemNo LIKE '%" + Me.txtSearch.Text + "%' OR tblItems.Description LIKE '%" + Me.txtSearch.Text + "%' OR tblItems.UnitCost LIKE '%" + Me.txtSearch.Text + "%')")
        Dim Field As String
        Dim Perc As String
        Dim SearchType As String
        Dim SortType As String
        Dim strArr(2) As String

        'Ascending and Descending
        If Me.rbtnAsc.Checked = True Then
            SortType = "ASC"
        Else
            SortType = "DESC"
        End If

        strArr = Me.cmbxSort.Text.Split("-")
        If strArr(0) = 1 Then
            If Not Len(Trim(Me.txtSearch.Text)) = 0 Then
                Field = "DRNo"
                SearchType = "LIKE '"
                Perc = "'"
            Else
                Field = "DRNo"
                SearchType = "LIKE '"
                Perc = "%'"
            End If
        ElseIf strArr(0) = 2 Then
            If Not Len(Trim(Me.txtSearch.Text)) = 0 Then
                Field = "tblPurchased.ItemNo"
                SearchType = "LIKE '"
                Perc = "'"
            Else
                Field = "tblPurchased.ItemNo"
                SearchType = "LIKE '"
                Perc = "%'"
            End If
        ElseIf strArr(0) = 3 Then
            Field = "vwPurchasedItems.Description"
            SearchType = "LIKE '"
            Perc = "%'"
        ElseIf strArr(0) = 4 Then
            Field = "CustomerName"
            SearchType = "LIKE '"
            Perc = "%'"
        ElseIf strArr(0) = 5 Then
            If Not Len(Trim(Me.txtSearch.Text)) = 0 Then
                Field = "tblSales.Quantity"
                SearchType = "LIKE '"
                Perc = "'"
            Else
                Field = "tblSales.Quantity"
                SearchType = "LIKE '"
                Perc = "%'"
            End If
        ElseIf strArr(0) = 6 Then
            If Not Len(Trim(Me.txtSearch.Text)) = 0 Then
                Field = "ActualSP"
                SearchType = "LIKE '"
                Perc = "'"
            Else
                Field = "ActualSP"
                SearchType = "LIKE '"
                Perc = "%'"
            End If
        Else
            Field = "DateSales"
            SearchType = "LIKE '"
            Perc = "%'"
        End If

        If Me.chckbxNoDate.Checked = True Then
            FillISales("SELECT TOP 50 * FROM vwSales WHERE  " & Field & " " & SearchType & CSQ(Me.txtSearch.Text) & Perc & " ORDER BY " & "tblSales.ID" & " " & SortType)
        Else
            FillISales("SELECT TOP 50 * FROM vwSales WHERE  " & Field & " " & SearchType & CSQ(Me.txtSearch.Text) & Perc & " AND DateSales >=#" & Me.dtpStart.Value.ToShortDateString & " 12:00:00 AM# AND DateSales <#" & Me.dtpEnd.Value.AddDays(1).ToShortDateString & " 12:00:00 AM#  ORDER BY " & "tblSales.ID" & " " & SortType)
        End If

    End Sub

#End Region

#Region "Reports"

#End Region

    Private Sub frmInventory_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cmbxSort.Text = "1-DR #"
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
            Me.AddMultipleToolStripMenuItem.Enabled = True
        ElseIf frmMain.ToolStripStatuslblLevel.Text = "2" Then
            Me.AddToolStripMenuItem.Enabled = True
            Me.AddMultipleToolStripMenuItem.Enabled = True
        ElseIf frmMain.ToolStripStatuslblLevel.Text = "3" Then
            Me.AddToolStripMenuItem.Enabled = False
            Me.AddMultipleToolStripMenuItem.Enabled = False
        End If

        If Me.lstvwItems.Items.Count > 0 And Me.lstvwItems.SelectedItems.Count > 0 Then
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
        With frmEntrySales
            .txtDRNo.Focus()
            .btnEnter.Text = "&Save"
            .ShowDialog()
        End With
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        If CInt(Me.lstvwItems.SelectedItems(0).SubItems(16).Text) = 0 Then
            With frmEntrySales
                .CustomerList()
                .Id = Me.lstvwItems.SelectedItems(0).SubItems(0).Text
                .dtpDate.Value = Me.lstvwItems.SelectedItems(0).SubItems(12).Text

                .txtDRNo.Text = Me.lstvwItems.SelectedItems(0).SubItems(1).Text

                .txtItemId.Text = Me.lstvwItems.SelectedItems(0).SubItems(13).Text
                .txtItemNo.Text = Me.lstvwItems.SelectedItems(0).SubItems(2).Text
                .lblDescription.Text = Me.lstvwItems.SelectedItems(0).SubItems(3).Text

                .cmbxCustomer.Text = Me.lstvwItems.SelectedItems(0).SubItems(4).Text
                .txtQuantity.Text = Me.lstvwItems.SelectedItems(0).SubItems(5).Text
                .OrigQuantity = Me.lstvwItems.SelectedItems(0).SubItems(5).Text

                .txtSalesPrice.Text = Me.lstvwItems.SelectedItems(0).SubItems(6).Text
                .txtSAP.Text = Me.lstvwItems.SelectedItems(0).SubItems(8).Text
                .txtCommision.Text = Me.lstvwItems.SelectedItems(0).SubItems(10).Text

                .lblTotalQuantity.Text = Me.lstvwItems.SelectedItems(0).SubItems(14).Text

                .btnEnter.Text = "&Update"
                .txtDRNo.Focus()
                .ShowDialog()
            End With
        Else
            MsgBox("The selected item can't be edited beacause it is locked.", MsgBoxStyle.Critical, "Item lock")
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click

        Dim tmp1 As String
        Dim tmp2 As String

        If CInt(Me.lstvwItems.SelectedItems(0).SubItems(16).Text) = 0 Then
            Dim StrSelect As String
            If MessageBox.Show("Are you sure you want to delete Item " + Me.lstvwItems.SelectedItems(0).SubItems(3).Text + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                StrSelect = "DELETE FROM tblSales " & _
                     "WHERE Id = " + Me.lstvwItems.SelectedItems(0).Text + ""

                CheckConnection(cn)

                Dim cmd As New OleDbCommand(StrSelect, cn)

                cmd.ExecuteNonQuery()
                MsgBox(Me.lstvwItems.SelectedItems(0).SubItems(3).Text & " has been successfully deleted.", MsgBoxStyle.Information, "")

                tmp1 = Me.lstvwItems.SelectedItems(0).SubItems(5).Text
                tmp2 = Me.lstvwItems.SelectedItems(0).SubItems(14).Text

                UpdateQuantity(Me.lstvwItems.SelectedItems(0).SubItems(13).Text, CInt(Me.lstvwItems.SelectedItems(0).SubItems(5).Text) + CInt(Me.lstvwItems.SelectedItems(0).SubItems(14).Text))
                ItemList()
            End If
        Else
            MsgBox("The selected item can't be deleted beacause it is locked.", MsgBoxStyle.Critical, "Item lock")
        End If
    End Sub

    Private Sub dtpMain_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ItemList()
    End Sub

    Private Sub rbtnAsc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnAsc.Click
        ItemList()
    End Sub

    Private Sub rbtnDesc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnDesc.Click
        ItemList()
    End Sub

    'Private Sub dtpStart_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpStart.ValueChanged
    '    If Me.dtpStart.Value.Date > Me.dtpEnd.Value.Date Then
    '        Me.dtpEnd.Value = Me.dtpStart.Value.Date.AddDays(1)
    '    End If
    'End Sub

    'Private Sub dtpEnd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpEnd.ValueChanged
    '    If Me.dtpEnd.Value.Date < Me.dtpStart.Value.Date Then
    '        MsgBox("Invalid ending date, please enter a valid ending date.", MsgBoxStyle.Exclamation, "Invalid")
    '        Me.dtpEnd.Value = Me.dtpStart.Value.Date.AddDays(1)
    '    End If
    'End Sub

    Private Sub AdjToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdjToolStripMenuItem.Click
        With frmAdjustment
            .Adjtbl = 1
            .txtQuantity.Text = CInt(Me.lstvwItems.SelectedItems(0).SubItems(5).Text)
            .Id = Me.lstvwItems.SelectedItems(0).Text
            .lblItemNo.Text = Me.lstvwItems.SelectedItems(0).SubItems(2).Text
            .lblDescription.Text = Me.lstvwItems.SelectedItems(0).SubItems(3).Text
            .txtRemarks.Text = Me.lstvwItems.SelectedItems(0).SubItems(15).Text
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

    Private Sub cmbxSort_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbxSort.SelectedIndexChanged
        ItemList()
    End Sub

    Private Sub AddMultipleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddMultipleToolStripMenuItem.Click
        With frmEntrySalesMulti
            .btnEnter.Text = "&Save"
            .txtDRNo.Focus()
            .ShowDialog()
        End With
    End Sub

    Private Sub chckbxNoDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chckbxNoDate.CheckedChanged
        If Me.chckbxNoDate.Checked = True Then
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

End Class