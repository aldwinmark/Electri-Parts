'Created by Aldwin Mark F. Solis
'Date: July 4 2010
'Form: Tellering entry Form 

Imports System.Data.OleDb

Public Class frmTellering

#Region "Variable Declaration"

#End Region

#Region "User Functions"

    Private Sub GetInvoiceNo()

        CheckConnection(cn)

        Dim cmd As New OleDbCommand("SELECT * FROM tblInvoiceNo", cn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader
        Reader.Read()
        If Reader.HasRows = True Then
            Me.txtInvoiceNo.Text = Reader("InvoiceNo")
        Else
            MessageBox.Show("Item information is not found.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        'close the reader
        Reader.Close()

    End Sub

    Private Sub GetItemInfo(ByVal str As String)

        CheckConnection(cn)

        Dim cmd As New OleDbCommand("SELECT * FROM tblItems WHERE [Description]='" & CSQ(str) & "'", cn)
        Dim Reader As OleDbDataReader = cmd.ExecuteReader
        Reader.Read()
        If Reader.HasRows = True Then
            Me.lblDescription.Text = Reader("Description")
            Me.lblItemNo.Text = Reader("ItemNo")
            Me.lblSalesPrice.Text = FormatNumber(Reader("SalesPrice"))
            Me.lblSAP.Text = FormatNumber(Reader("SalesAgentPrice"))
        Else
            MessageBox.Show("Item information is not found.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.lblDescription.Text = ""
            Me.lblItemNo.Text = ""
            Me.lblSalesPrice.Text = FormatNumber(0)
            Me.lblSAP.Text = FormatNumber(0)
        End If
        'close the reader
        Reader.Close()

    End Sub

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

#End Region

#Region "Loading List"

    Friend Sub ItemList()
        FillItems("SELECT DISTINCT [Description],[tblItems.ItemNo] FROM vwPurchasedItems GROUP BY [Description],[tblItems.ItemNo] ORDER BY [Description] ASC")
    End Sub

#End Region

#Region "Filling List"

    Private Sub FillItems(ByVal Sqlstring As String)
        'Me.cmbxDescription.Items.Clear()
        Me.cmbxDescription.Items.Clear()
        CheckConnection(cn)
        oledbda.SelectCommand = New OleDbCommand(Sqlstring, cn)
        oledbcmbldr = New OleDbCommandBuilder(oledbda)

        ds.Clear()
        oledbda.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            For Each dr In ds.Tables(0).Rows
                'Me.cmbxItemNo.Items.Add(dr("ItemNo"))
                Me.cmbxDescription.Items.Add(dr("Description"))
            Next
        End If
    End Sub

#End Region

    Private Sub txtQuantity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQuantity.KeyDown

        Dim x As Integer

        If e.KeyValue = Keys.Enter Then
            If Me.txtCustomer.Text = "" Then
                MsgBox("'Sold to' is empty, please enter a Customer.", MsgBoxStyle.Information, "Required")
                Me.txtCustomer.Focus()
            ElseIf Len(Me.txtInvoiceNo.Text.Trim) <= 0 Then
                MsgBox("Invoice# is empty, please enter a valid Invoice#.", MsgBoxStyle.Information, "Required")
                Me.txtQuantity.Focus()
            ElseIf Me.cmbxDescription.Text = "" Then
                MsgBox("Please select an item to add.", MsgBoxStyle.Information, "Required")
                Me.cmbxDescription.Focus()
            ElseIf Me.txtQuantity.Text = "" Then
                MsgBox("Please enter a quantity.", MsgBoxStyle.Information, "Required")
                Me.txtQuantity.Focus()
            Else
                If SeacrhItemID(Me.lblItemNo.Text) = False Then
                    Dim MyItem = Me.lstvwItems.Items.Add(Me.lblItemNo.Text)
                    MyItem.tag = x
                    x = x + 1
                    With MyItem
                        .SubItems.Add(Me.lblDescription.Text)
                        .SubItems.Add(Me.txtQuantity.TextLength)
                        .SubItems.Add(Me.lblSalesPrice.Text)
                    End With
                Else
                    MessageBox.Show("The selected item already exist in the listview.", "Record exist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                Me.cmbxDescription.Focus()
            End If
        End If
    End Sub

    Private Sub txtCustomer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCustomer.KeyDown
        NextControlSelect(Me, e)
    End Sub

    Private Sub txtAddress_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAddress.KeyDown
        NextControlSelect(Me, e)
    End Sub

    Private Sub cmbxDescription_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbxDescription.KeyDown
        NextControlSelect(Me, e)
    End Sub

    Private Sub frmTellering_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ItemList()
        GetInvoiceNo()
    End Sub

    Private Sub cmbxDescription_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbxDescription.SelectedIndexChanged
        If Not Me.cmbxDescription.Text = "" Then
            GetItemInfo(Me.cmbxDescription.Text)
        End If
    End Sub

    Private Sub txtInvoiceNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtInvoiceNo.KeyDown

        If e.KeyValue = Keys.Enter = True Then
            Dim StrSelect As String

            'update the record
            StrSelect = "UPDATE tblInvoiceNo SET " & _
            "[InvoiceNo]='" & CSQ(Me.txtInvoiceNo.Text) & _
            "'"

            CheckConnection(cn)

            Dim cmd As New OleDbCommand(StrSelect, cn)
            cmd.ExecuteNonQuery()

            MsgBox(Me.txtInvoiceNo.Text & " invoice no.  has been successfully updated.", MsgBoxStyle.Information, "Updated")
            Me.cmbxDescription.Focus()
        End If

    End Sub

End Class