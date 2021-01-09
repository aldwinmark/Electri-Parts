'Created by Aldwin Mark F. Solis
'Date: July 3 2010
'Form: Cusomer Form 

Imports System.Data.OleDb

Public Class frmVendor

#Region "Variable Declaration"

#End Region

#Region "Functions"
    Private Sub FillVendor(ByVal SqlString As String)
        Me.lstvwVendor.Items.Clear()
        ds.Clear()

        oledbda.SelectCommand = New OleDbCommand(SqlString, cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        oledbda.Fill(ds)

        Me.lblTotalList.Text = FormatNumber(ds.Tables(0).Rows.Count, 0)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows

                Dim MyItem = Me.lstvwVendor.Items.Add(dr("Id"))
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("VendorName"))
                    .SubItems.Add(dr("Address"))
                    .SubItems.Add(dr("ContactNo"))
                End With
            Next
        End If
        cn.Close()
    End Sub
#End Region

#Region "Loading List"
    Friend Sub VendorList()
        If Me.rbtnAsc.Checked = True Then
            FillVendor("SELECT TOP 100 * FROM tblVendor WHERE VendorName LIKE '" + CSQ(Me.txtSearch.Text) + "%' ORDER BY VendorName ASC")
        Else
            FillVendor("SELECT TOP 100 * FROM tblVendor WHERE VendorName LIKE '" + CSQ(Me.txtSearch.Text) + "%' ORDER BY VendorName DESC")
        End If
    End Sub
#End Region

#Region "Reports"

#End Region

    Private Sub frmVendor_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmVendor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        VendorList()
    End Sub

    Private Sub CMS_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMS.Opening
        If Me.lstvwVendor.Items.Count > 0 And Me.lstvwVendor.SelectedItems.Count > 0 Then
            Me.EditToolStripMenuItem.Enabled = True
            Me.DeleteToolStripMenuItem.Enabled = True
        Else
            Me.EditToolStripMenuItem.Enabled = False
            Me.DeleteToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        With frmEntryVendor
            .btnEnter.Text = "&Save"
            .ShowDialog()
            .txtVendorName.Focus()
        End With
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim StrSelect As String
        If MessageBox.Show("Are you sure you want to delete vendor " + Me.lstvwVendor.SelectedItems(0).SubItems(1).Text + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            StrSelect = "DELETE FROM tblVendor " & _
                 "WHERE Id = " + Me.lstvwVendor.SelectedItems(0).Text + ""

            CheckConnection(cn)

            Dim cmd As New OleDbCommand(StrSelect, cn)

            cmd.ExecuteNonQuery()
            MsgBox(Me.lstvwVendor.SelectedItems(0).SubItems(1).Text & " has been successfully deleted.", MsgBoxStyle.Information, "")
            VendorList()
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        With frmEntryVendor
            .Id = Me.lstvwVendor.SelectedItems(0).SubItems(0).Text
            .txtVendorName.Text = Me.lstvwVendor.SelectedItems(0).SubItems(1).Text
            .txtAddress.Text = Me.lstvwVendor.SelectedItems(0).SubItems(2).Text
            .txtContactNo.Text = Me.lstvwVendor.SelectedItems(0).SubItems(3).Text
            .btnEnter.Text = "&Update"
            .txtVendorName.Focus()
            .ShowDialog()
        End With
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        VendorList()
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyData = Keys.Enter = True Then
            VendorList()
        End If
    End Sub

    Private Sub rbtnAsc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnAsc.CheckedChanged
        VendorList()
    End Sub

    Private Sub rbtnDesc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnDesc.CheckedChanged
        VendorList()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        VendorList()
    End Sub

End Class