'Created by Aldwin Mark F. Solis
'Date: July 4 2010
'Form: Inventory Form 

Imports System.Data.OleDb

Public Class frmTransMon

#Region "Variable Declaration"

#End Region

#Region "Functions"

    Private Sub FillIPurchased(ByVal SqlString As String)
        Dim Quantity As Integer = 0
        Dim TQuantity As Integer = 0
        Me.lstvwItemsP.Items.Clear()
        ds.Clear()

        oledbda.SelectCommand = New OleDbCommand(SqlString, cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        oledbda.Fill(ds)

        Me.lblPTotalList.Text = FormatNumber(ds.Tables(0).Rows.Count, 0)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows

                Dim MyItem = Me.lstvwItemsP.Items.Add(dr("tblPurchased.Id"))
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("DateIn"))
                    .SubItems.Add(dr("tblPurchased.ItemNo"))
                    .SubItems.Add(Trim(dr("Description")))
                    .SubItems.Add(dr("Quantity"))
                    .SubItems.Add(dr("OrigQuantity"))
                    .SubItems.Add(dr("VendorName"))
                    If IsDBNull(dr("Remarks")) = True Then
                        .SubItems.Add("")
                    Else
                        .SubItems.Add(dr("Remarks"))
                    End If

                    .SubItems.Add(dr("RSNo"))
                    .SubItems.Add(dr("tblPurchased.ID"))
                End With

                Quantity += CInt(dr("Quantity"))
                TQuantity += CInt(dr("OrigQuantity"))

            Next
        End If
        cn.Close()

        'Me.lblPQuantity.Text = Quantity
        Me.lblPOrigQuantity.Text = TQuantity

    End Sub

    Private Sub FillISales(ByVal SqlString As String)
        Dim Quantity As Integer = 0
        Me.lstvwItemsS.Items.Clear()
        ds.Clear()

        oledbda.SelectCommand = New OleDbCommand(SqlString, cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        oledbda.Fill(ds)

        Me.lblSTotalList.Text = FormatNumber(ds.Tables(0).Rows.Count, 0)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows

                Dim MyItem = Me.lstvwItemsS.Items.Add(dr("tblSales.Id"))
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("DateSales"))
                    .SubItems.Add(dr("tblPurchased.ItemNo"))
                    .SubItems.Add(Trim(dr("vwPurchasedItems.Description")))
                    .SubItems.Add(dr("tblSales.Quantity"))
                    .SubItems.Add(dr("CustomerName"))
                    .SubItems.Add(dr("tblSales.Remarks"))
                    .SubItems.Add(dr("DRNo"))
                    .SubItems.Add(dr("tblSales.ItemNo"))
                End With

                Quantity += CInt(dr("tblSales.Quantity"))

            Next
        End If
        cn.Close()

        Me.lblSQuantity.Text = Quantity

    End Sub

#End Region

#Region "Loading List"

    Friend Sub ItemListP()

        Dim Perc As String = ""
        Dim SearchType As String = ""

        Dim FieldP As String = ""
        Dim SortType As String = ""

        Dim strArr(2) As String

        'Ascending and Descending
        If Me.rbtnAscP.Checked = True Then
            SortType = "ASC"
        Else
            SortType = "DESC"
        End If

        strArr = Me.cmbxSortP.Text.Split("-")
        If strArr(0) = 1 Then
            If Not Len(Trim(Me.txtSearchP.Text)) = 0 Then
                FieldP = "tblPurchased.ItemNo"
                SearchType = "LIKE '"
                Perc = "'"
            Else
                FieldP = "tblPurchased.ItemNo"
                SearchType = "LIKE '"
                Perc = "%'"
            End If
        ElseIf strArr(0) = 2 Then
            If Not Len(Trim(Me.txtSearchP.Text)) = 0 Then
                FieldP = "RSNo"
                SearchType = "LIKE '"
                Perc = "'"
            Else
                FieldP = "RSNo"
                SearchType = "LIKE '"
                Perc = "%'"
            End If
        ElseIf strArr(0) = 3 Then
            FieldP = "Description"
            SearchType = "LIKE '"
            Perc = "%'"
        ElseIf strArr(0) = 4 Then
            If Not Len(Trim(Me.txtSearchP.Text)) = 0 Then
                FieldP = "Quantity"
                SearchType = "LIKE '"
                Perc = "'"
            Else
                FieldP = "Quantity"
                SearchType = "LIKE '"
                Perc = "%'"
            End If
        End If

        If Me.chkbxPurchased.Checked = True Then
            FillIPurchased("SELECT  * FROM vwPurchasedItems WHERE " & FieldP & " " & SearchType & CSQ(Me.txtSearchP.Text) & Perc & " ORDER BY " & "tblPurchased.ID" & " " & SortType & "")
        Else
            FillIPurchased("SELECT  * FROM vwPurchasedItems WHERE " & FieldP & " " & SearchType & CSQ(Me.txtSearchP.Text) & Perc & " AND DateIn >=#" & Me.dtpStartP.Value.ToShortDateString & " 12:00:00 AM# AND DateIn <#" & Me.dtpEndP.Value.AddDays(1).ToShortDateString & " 12:00:00 AM# ORDER BY " & "tblPurchased.ID" & " " & SortType & "")
        End If

    End Sub

    Friend Sub ItemListS()

        Dim Perc As String = ""
        Dim SearchType As String = ""

        Dim FieldS As String = ""
        Dim SortType As String = ""

        Dim strArr(2) As String

        'Ascending and Descending
        If Me.rbtnAscS.Checked = True Then
            SortType = "ASC"
        Else
            SortType = "DESC"
        End If

        strArr = Me.cmbxSortS.Text.Split("-")
        If strArr(0) = 1 Then
            If Not Len(Trim(Me.txtSearchS.Text)) = 0 Then
                FieldS = "tblPurchased.ItemNo"
                SearchType = "LIKE '"
                Perc = "'"
            Else
                FieldS = "tblPurchased.ItemNo"
                SearchType = "LIKE '"
                Perc = "%'"
            End If
        ElseIf strArr(0) = 2 Then
            If Not Len(Trim(Me.txtSearchS.Text)) = 0 Then
                FieldS = "DRNo"
                SearchType = "LIKE '"
                Perc = "'"
            Else
                FieldS = "DRNo"
                SearchType = "LIKE '"
                Perc = "%'"
            End If
        ElseIf strArr(0) = 3 Then
            FieldS = "vwPurchasedItems.Description"
            SearchType = "LIKE '"
            Perc = "%'"
        ElseIf strArr(0) = 4 Then
            If Not Len(Trim(Me.txtSearchS.Text)) = 0 Then
                FieldS = "tblSales.Quantity"
                SearchType = "LIKE '"
                Perc = "'"
            Else
                FieldS = "tblSales.Quantity"
                SearchType = "LIKE '"
                Perc = "%'"
            End If
        End If

        If Me.chkbxSales.Checked = True Then
            FillISales("SELECT * FROM vwSales WHERE " & FieldS & " " & SearchType & CSQ(Me.txtSearchS.Text) & Perc & " ORDER BY " & "tblSales.ItemNo" & " " & SortType)
        Else
            FillISales("SELECT * FROM vwSales WHERE " & FieldS & " " & SearchType & CSQ(Me.txtSearchS.Text) & Perc & " AND DateSales >=#" & Me.dtpStartS.Value.ToShortDateString & " 12:00:00 AM# AND DateSales <#" & Me.dtpEndS.Value.AddDays(1).ToShortDateString & " 12:00:00 AM#  ORDER BY " & "tblSales.ItemNo" & " " & SortType)
        End If

    End Sub

#End Region

#Region "Reports"

#End Region

    Private Sub frmTransMon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbxSortP.Text = "1-Item#"
        Me.cmbxSortS.Text = "1-Item#"
        ItemListP()
        ItemListS()
    End Sub

    Private Sub cmbxSortP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbxSortP.SelectedIndexChanged
        ItemListP()
    End Sub

    Private Sub rbtnDescP_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnDescP.Click
        ItemListP()
    End Sub

    Private Sub rbtnAscP_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnAscP.Click
        ItemListP()
    End Sub

    Private Sub chkbxSales_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxSales.CheckedChanged
        If Me.chkbxSales.Checked = True Then
            Me.grpbxDateSales.Enabled = False
        Else
            Me.grpbxDateSales.Enabled = True
        End If
        If Me.txtSearchS.TextLength <= 0 And Me.chkbxSales.CheckState = CheckState.Checked Then
            Me.chkbxSales.CheckState = CheckState.Unchecked
            MessageBox.Show("Please enter an item to search", "No Entry", MessageBoxButtons.OK)
            Me.txtSearchS.Focus()
        Else
            ItemListS()
        End If
    End Sub

    Private Sub chkbxPurchased_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkbxPurchased.CheckedChanged
        If Me.chkbxPurchased.Checked = True Then
            Me.grpbxDatePurchased.Enabled = False
        Else
            Me.grpbxDatePurchased.Enabled = True
        End If

        If Me.txtSearchP.TextLength <= 0 And Me.chkbxPurchased.CheckState = CheckState.Checked Then
            Me.chkbxPurchased.CheckState = CheckState.Unchecked
            MessageBox.Show("Please enter an item to search", "No Entry", MessageBoxButtons.OK)
            Me.txtSearchP.Focus()
        Else
            ItemListP()
        End If

    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearchP.KeyDown
        If e.KeyData = Keys.Enter = True Then
            ItemListP()
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchP.Click
        ItemListP()
    End Sub

    Private Sub cmbxSortS_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbxSortS.SelectedIndexChanged
        ItemListS()
    End Sub

    Private Sub rbtnAscS_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnAscS.Click
        ItemListS()
    End Sub

    Private Sub rbtnDescS_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtnDescS.Click
        ItemListS()
    End Sub

    Private Sub txtSearchS_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearchS.KeyDown
        If e.KeyData = Keys.Enter = True Then
            ItemListS()
        End If
    End Sub

    Private Sub btnSearchS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchS.Click
        ItemListS()
    End Sub

    Private Sub lstvwItemsP_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lstvwItemsP.ItemSelectionChanged
        Dim x As Integer
        Me.lblPSelCount.Text = 0
        If Me.lstvwItemsP.SelectedItems.Count > 0 Then
            For x = 0 To Me.lstvwItemsP.Items.Count - 1
                If Me.lstvwItemsP.Items(x).Selected = True Then
                    Me.lblPSelCount.Text = CInt(Me.lblPSelCount.Text) + CInt(Me.lstvwItemsP.Items(x).SubItems(5).Text)
                End If
            Next
        End If
    End Sub

    Private Sub lstvwItemsS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstvwItemsS.SelectedIndexChanged
        Dim x As Integer
        Me.lblSSelCount.Text = 0
        If Me.lstvwItemsS.SelectedItems.Count > 0 Then
            For x = 0 To Me.lstvwItemsS.Items.Count - 1
                If Me.lstvwItemsS.Items(x).Selected = True Then
                    Me.lblSSelCount.Text = CInt(Me.lblSSelCount.Text) + CInt(Me.lstvwItemsS.Items(x).SubItems(4).Text)
                End If
            Next
        End If
    End Sub

End Class