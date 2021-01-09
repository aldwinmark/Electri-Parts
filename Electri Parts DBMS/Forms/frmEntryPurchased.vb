'Created by Aldwin Mark F. Solis
'Date: July 4 2010
'Form: Inventory entry Form 

Imports System.Data.OleDb

Public Class frmEntryPurchased

    Dim StrSelect As String

#Region "Varaible declaration"
    Friend Id As Integer
#End Region

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

#End Region

#Region "Loading List"
    Friend Sub ItemList()
        FillItems("SELECT * FROM tblItems ORDER BY [Description] ASC")
    End Sub
    Friend Sub VendorList()
        FillVendors("SELECT * FROM tblVendor ORDER BY [VendorName] ASC")
    End Sub
#End Region

    Private Sub frmEntryInventory_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmEntryInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.btnEnter.Text = "&Save" Then
            ItemList()
            VendorList()
        End If
    End Sub

    Private Sub cmbxItemNo_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbxItemNo.DropDownClosed
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
        Else

            Dim strArr(1) As String
            strArr = Me.cmbxVendor.Text.Split(":")

            If frmMain.ToolStripStatusUserId.Text = "-----" Then frmMain.ToolStripStatusUserId.Text = 0

            If SearchExistingRecords(Me.cmbxItemNo.Text) = False Then
                MsgBox("Record does not exist in the masterlist.", MsgBoxStyle.Information, "Required")
                Me.cmbxItemNo.Focus()
                Exit Sub
            End If

            If Me.btnEnter.Text = "&Save" Then

                If frmMain.ToolStripStatusUserId.Text = "-----" Then frmMain.ToolStripStatusUserId.Text = 0
                StrSelect = "INSERT INTO tblPurchased" & _
                                    "([ItemNo],[Quantity],[OrigQuantity],[DateIn],[UnitCost],[Remarks],[Lock],[Vendor],[RSNo],[UserId])VALUES " + _
                                    "('" & CSQ(Me.cmbxItemNo.Text) & "','" & _
                                    "" & CSQ(Me.txtQuantity.Text) & "','" & _
                                    "" & CSQ(Me.txtQuantity.Text) & "','" & _
                                    "" & Me.dtpDate.Value & "'," & _
                                    "" & (Me.lblUnitCost.Text) & ",'" & _
                                    "" & "" & "','" & _
                                    "" & 0 & " ','" & _
                                    "" & strArr(1) & " ','" & _
                                    "" & CSQ(Me.txtRSNo.Text) & _
                                    "', '" + frmMain.ToolStripStatusUserId.Text & "')"

                CheckConnection(cn)
                Dim cmdSave As New OleDbCommand(StrSelect, cn)
                cmdSave.ExecuteNonQuery()
                MsgBox(Me.cmbxItemNo.Text & " item# has been successfully inserted.", MsgBoxStyle.Information, "Inserted")
            Else
                If CInt(Me.txtQuantity.Text) > CInt(Me.txtOrigQty.Text) Then
                    MsgBox("Quantity is greater than the original quantity , please enter a valid quantity.", MsgBoxStyle.Information, "Required")
                    Me.txtQuantity.Focus()
                    Exit Sub
                End If

                'update the record
                StrSelect = "UPDATE tblPurchased SET " & _
                "[ItemNo]='" & CSQ(Me.cmbxItemNo.Text) & _
                "',[Quantity]='" & CSQ(Me.txtQuantity.Text) & _
                "',[DateIn]='" & Me.dtpDate.Value & _
                "',[Vendor]='" & strArr(1) & _
                "',[UserId]='" & frmMain.ToolStripStatusUserId.Text & _
                "',[RSNo]='" & CSQ(Me.txtRSNo.Text) & _
                "',[OrigQuantity]='" & CSQ(Me.txtOrigQty.Text) & _
                "'WHERE Id=" & Id & ""

                CheckConnection(cn)

                Dim cmd As New OleDbCommand(StrSelect, cn)
                cmd.ExecuteNonQuery()
                MsgBox(Me.cmbxItemNo.Text & " item# has been successfully updated.", MsgBoxStyle.Information, "Updated")
            End If
        frmPurchased.ItemList()
        Me.btnCancel_Click(sender, e)
        End If

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

End Class