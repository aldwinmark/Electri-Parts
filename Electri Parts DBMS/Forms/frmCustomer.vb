'Created by Aldwin Mark F. Solis
'Date: July 3 2010
'Form: Cusomer Form 

Imports System.Data.OleDb

Public Class frmCustomer

#Region "Variable Declaration"

#End Region

#Region "Functions"
    Private Sub FillCustomer(ByVal SqlString As String)
        Me.lstvwCustomer.Items.Clear()
        ds.Clear()

        oledbda.SelectCommand = New OleDbCommand(SqlString, cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        oledbda.Fill(ds)

        Me.lblTotalList.Text = FormatNumber(ds.Tables(0).Rows.Count, 0)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim X = Me.BindingContext(ds.Tables(0)).Position
            For Each dr In ds.Tables(0).Rows

                Dim MyItem = Me.lstvwCustomer.Items.Add(dr("Id"))
                MyItem.tag = X
                X = X + 1
                With MyItem
                    .SubItems.Add(dr("Company"))
                    .SubItems.Add(dr("Owner"))
                    .SubItems.Add(dr("Address"))
                    .SubItems.Add(dr("ContactNo"))
                    .SubItems.Add(dr("Terms"))
                End With
            Next
        End If
        cn.Close()
    End Sub
#End Region

#Region "Loading List"
    Friend Sub CustomerList()
        If Me.rbtnAsc.Checked = True Then
            FillCustomer("SELECT * FROM tblCustomer WHERE Company LIKE '%" + CSQ(Me.txtSearch.Text) + "%' ORDER BY Company ASC")
        Else
            FillCustomer("SELECT * FROM tblCustomer WHERE Company LIKE '%" + CSQ(Me.txtSearch.Text) + "%' ORDER BY Company DESC")
        End If
    End Sub
#End Region

#Region "Reports"

#End Region


    Private Sub frmCustomer_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub frmCustomer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CustomerList()
    End Sub

    Private Sub CMS_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CMS.Opening
        If Me.lstvwCustomer.Items.Count > 0 And Me.lstvwCustomer.SelectedItems.Count > 0 Then
            Me.EditToolStripMenuItem.Enabled = True
            Me.DeleteToolStripMenuItem.Enabled = True
        Else
            Me.EditToolStripMenuItem.Enabled = False
            Me.DeleteToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub AddToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddToolStripMenuItem.Click
        With frmEntryCustomer
            .btnEnter.Text = "&Save"
            .ShowDialog()
            .txtCompany.Focus()
        End With
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim StrSelect As String
        If MessageBox.Show("Are you sure you want to delete customer " + Me.lstvwCustomer.SelectedItems(0).SubItems(1).Text + "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            StrSelect = "DELETE FROM tblCustomer " & _
                 "WHERE Id = " + Me.lstvwCustomer.SelectedItems(0).Text + ""

            CheckConnection(cn)

            Dim cmd As New OleDbCommand(StrSelect, cn)

            cmd.ExecuteNonQuery()
            MsgBox(Me.lstvwCustomer.SelectedItems(0).SubItems(1).Text & " has been successfully deleted.", MsgBoxStyle.Information, "")
            CustomerList()
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        With frmEntryCustomer
            .Id = Me.lstvwCustomer.SelectedItems(0).SubItems(0).Text
            .txtCompany.Text = Me.lstvwCustomer.SelectedItems(0).SubItems(1).Text
            .txtOwner.Text = Me.lstvwCustomer.SelectedItems(0).SubItems(2).Text
            .txtAddress.Text = Me.lstvwCustomer.SelectedItems(0).SubItems(3).Text
            .txtContactNo.Text = Me.lstvwCustomer.SelectedItems(0).SubItems(4).Text
            .txtTerms.Text = Me.lstvwCustomer.SelectedItems(0).SubItems(5).Text
            .btnEnter.Text = "&Update"
            .txtCompany.Focus()
            .ShowDialog()
        End With
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        CustomerList()
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyData = Keys.Enter = True Then
            CustomerList()
        End If
    End Sub

    Private Sub lstvwCustomer_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles lstvwCustomer.ItemSelectionChanged
        If e.IsSelected = True Then
            Me.lblTerms.Text = e.Item.SubItems(5).Text
        Else
            Me.lblTerms.Text = ""
        End If
    End Sub

    Private Sub rbtnAsc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnAsc.CheckedChanged
        CustomerList()
    End Sub

    Private Sub rbtnDesc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnDesc.CheckedChanged
        CustomerList()
    End Sub

End Class