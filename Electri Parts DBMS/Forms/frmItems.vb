'Created by Aldwin Mark F. Solis
'Date: July 3 2010
'Form: Items Form 

Imports System.Data.OleDb

Public Class frmItems

#Region "Variable Declaration"

#End Region

#Region "Functions"
    Private Sub FillItems(ByVal SqlString As String)
        Me.lstvwItems.Items.Clear()
        ds.Clear()

        oledbda.SelectCommand = New OleDbCommand(SqlString, cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        oledbda.Fill(ds)

        Me.lblTotalList.Text = FormatNumber(ds.Tables(0).Rows.Count, 0)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows

                Dim MyItem = Me.lstvwItems.Items.Add(dr("Id"))
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("ItemNo"))
                    .SubItems.Add(dr("Description"))
                    .SubItems.Add(FormatNumber(dr("UnitCost")))
                    .SubItems.Add(FormatNumber(dr("SalesPrice")))
                    .SubItems.Add(FormatNumber(dr("SalesAgentPrice")))
                End With
            Next
        End If
        cn.Close()
    End Sub
#End Region

#Region "Loading List"
    Friend Sub ItemList()

        Dim Field As String
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
            Field = "ItemNo"
        ElseIf strArr(0) = 2 Then
            Field = "Description"
        ElseIf strArr(0) = 3 Then
            Field = "UnitCost"
        ElseIf strArr(0) = 4 Then
            Field = "SalesPrice"
        Else
            Field = "SalesAgentPrice"
        End If

        If Not Me.txtSearch.Text = "Search" Then
            FillItems("SELECT * FROM tblItems WHERE ItemNo LIKE '" + CSQ(Me.txtSearch.Text) + "%' OR Description LIKE '" + CSQ(Me.txtSearch.Text) + "%' OR UnitCost LIKE '%" + CSQ(Me.txtSearch.Text) + "%' ORDER BY " & Field & " " & SortType)
        Else
            FillItems("SELECT * FROM tblItems ORDER BY " & Field & " " & SortType)
        End If

    End Sub
#End Region

#Region "Reports"

#End Region

    Private Sub frmItems_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmItems_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cmbxSort.Text = "1-Item#"
        ItemList()
    End Sub

    Private Sub CMS_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMS.Opening
        If Me.lstvwItems.Items.Count > 0 And Me.lstvwItems.SelectedItems.Count > 0 Then
            Me.EditToolStripMenuItem.Enabled = True
            Me.DeleteToolStripMenuItem.Enabled = True
        Else
            Me.EditToolStripMenuItem.Enabled = False
            Me.DeleteToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        ItemList()
    End Sub

    Friend Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        With frmEntryItem
            .txtItemNo.Focus()
            .btnEnter.Text = "&Save"
            .ShowDialog()
        End With
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        With frmEntryItem
            .Id = Me.lstvwItems.SelectedItems(0).SubItems(0).Text
            .txtItemNo.Text = Me.lstvwItems.SelectedItems(0).SubItems(1).Text
            .txtDescription.Text = Me.lstvwItems.SelectedItems(0).SubItems(2).Text
            .txtUnitCost.Text = Me.lstvwItems.SelectedItems(0).SubItems(3).Text
            .txtSalesPrice.Text = Me.lstvwItems.SelectedItems(0).SubItems(4).Text
            .txtSAP.Text = Me.lstvwItems.SelectedItems(0).SubItems(5).Text
            .btnEnter.Text = "&Update"
            .txtItemNo.Focus()
            .ShowDialog()
        End With
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim StrSelect As String
        If MessageBox.Show("Are you sure you want to delete Item " + Me.lstvwItems.SelectedItems(0).SubItems(1).Text + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            StrSelect = "DELETE FROM tblItems " & _
                 "WHERE Id = " + Me.lstvwItems.SelectedItems(0).Text + ""

            CheckConnection(cn)

            Dim cmd As New OleDbCommand(StrSelect, cn)

            cmd.ExecuteNonQuery()
            MsgBox(Me.lstvwItems.SelectedItems(0).SubItems(1).Text & " has been successfully deleted.", MsgBoxStyle.Information, "")
            ItemList()
        End If
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyData = Keys.Enter = True Then
            ItemList()
        End If
    End Sub

    Private Sub rbtnAsc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnAsc.Click
        ItemList()
    End Sub

    Private Sub rbtnDesc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnDesc.Click
        ItemList()
    End Sub

    Private Sub cmbxSort_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbxSort.SelectedIndexChanged
        ItemList()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ItemList()
    End Sub

End Class