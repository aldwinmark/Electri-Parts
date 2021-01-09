'Created by Aldwin Mark F. Solis
'Date: July 31 2010
'Form: Search Item Form 

Imports System.Data.OleDb

Public Class frmSearchItem

#Region "Declarations"
    Friend AddMulti As Boolean
#End Region

#Region "User Function"

    Private Sub FillItems(ByVal SqlString As String)
        Me.lstvwItems.Items.Clear()
        ds.Clear()

        oledbda.SelectCommand = New OleDbCommand(SqlString, cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        oledbda.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows

                Dim MyItem = Me.lstvwItems.Items.Add(dr("tblPurchased.ItemNo"))
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(Trim(dr("Description")))
                    .SubItems.Add(dr("Quantity"))
                    .SubItems.Add(FormatNumber(dr("SalesPrice")))
                    .SubItems.Add(dr("DateIn"))
                    .SubItems.Add(dr("tblPurchased.Id"))
                    .SubItems.Add(dr("SalesAgentPrice"))
                    .SubItems.Add(dr("tblPurchased.UnitCost"))
                End With
            Next
        End If
        cn.Close()

    End Sub

#End Region

#Region "Loading"
    Private Sub ItemList()
        If Me.rbtnZero.Checked = False Then
            FillItems("SELECT TOP 20 * FROM vwPurchasedItems WHERE (tblPurchased.ItemNo LIKE '" + CSQ(Me.txtSearch.Text) + "%' OR Description LIKE '" + CSQ(Me.txtSearch.Text) + "%') AND Quantity>0 ORDER BY Description ASC")
        Else
            FillItems("SELECT TOP 20 * FROM vwPurchasedItems WHERE (tblPurchased.ItemNo LIKE '" + CSQ(Me.txtSearch.Text) + "%' OR Description LIKE '" + CSQ(Me.txtSearch.Text) + "%')  ORDER BY Description ASC")
        End If
    End Sub
#End Region

    Private Sub frmSearchItem_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmSearchItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ItemList()
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Down = True Then
            If Me.lstvwItems.Items.Count > 0 Then
                SelectTopItem(Me.lstvwItems)
            End If
        End If
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        ItemList()
    End Sub

    Private Sub lstvwItems_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstvwItems.KeyDown
        If e.KeyCode = Keys.Enter = True Then
            If AddMulti = False Then
                With frmEntrySales
                    .txtItemId.Text = Me.lstvwItems.SelectedItems(0).SubItems(5).Text
                    .txtItemNo.Text = Me.lstvwItems.SelectedItems(0).SubItems(0).Text
                    .lblDescription.Text = Me.lstvwItems.SelectedItems(0).SubItems(1).Text
                    .lblTotalQuantity.Text = Me.lstvwItems.SelectedItems(0).SubItems(2).Text

                    .txtSalesPrice.Text = Me.lstvwItems.SelectedItems(0).SubItems(3).Text
                    .txtSAP.Text = Me.lstvwItems.SelectedItems(0).SubItems(6).Text

                    .txtUnitCost.Text = Me.lstvwItems.SelectedItems(0).SubItems(7).Text

                    .txtQuantity.Focus()
                End With
                Me.Close()
            Else
                With frmEntrySalesMulti
                    .txtItemId.Text = Me.lstvwItems.SelectedItems(0).SubItems(5).Text
                    .txtItemNo.Text = Me.lstvwItems.SelectedItems(0).SubItems(0).Text
                    .lblDescription.Text = Me.lstvwItems.SelectedItems(0).SubItems(1).Text
                    .lblTotalQuantity.Text = Me.lstvwItems.SelectedItems(0).SubItems(2).Text

                    .txtSalesPrice.Text = Me.lstvwItems.SelectedItems(0).SubItems(3).Text
                    .txtSAP.Text = Me.lstvwItems.SelectedItems(0).SubItems(6).Text

                    .txtUnitCost.Text = Me.lstvwItems.SelectedItems(0).SubItems(7).Text

                    .txtQuantity.Focus()

                    If Not Len(.txtItemNo.Text.Trim("")) <= 0 Then
                        .txtSalesPrice.Enabled = True
                        .txtSAP.Enabled = True
                        .txtCommision.Enabled = True
                        .txtQuantity.Enabled = True
                        .btnAddEntry.Enabled = True
                    Else
                        .txtSalesPrice.Enabled = False
                        .txtSAP.Enabled = False
                        .txtCommision.Enabled = False
                        .txtQuantity.Enabled = False
                        .btnAddEntry.Enabled = False
                    End If

                End With
                Me.Close()
            End If
        ElseIf e.KeyCode = Keys.Escape = True Then
            Me.txtSearch.Focus()
        End If
    End Sub

    Private Sub rbtnNonzero_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnNonzero.CheckedChanged
        ItemList()
    End Sub

    Private Sub rbtnZero_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnZero.CheckedChanged
        ItemList()
    End Sub

End Class