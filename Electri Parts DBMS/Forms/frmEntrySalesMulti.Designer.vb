<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntrySalesMulti
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntrySalesMulti))
        Me.txtUnitCost = New System.Windows.Forms.TextBox
        Me.lblTotalQuantity = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtQuantity = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnAddEntry = New System.Windows.Forms.Button
        Me.txtItemId = New System.Windows.Forms.TextBox
        Me.lblDescription = New System.Windows.Forms.Label
        Me.txtItemNo = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSAP = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtCommision = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtSalesPrice = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button
        Me.lstvwItems = New System.Windows.Forms.ListView
        Me.ItemId = New System.Windows.Forms.ColumnHeader
        Me.ItemNo = New System.Windows.Forms.ColumnHeader
        Me.Description = New System.Windows.Forms.ColumnHeader
        Me.Quantity = New System.Windows.Forms.ColumnHeader
        Me.TotalQty = New System.Windows.Forms.ColumnHeader
        Me.SalesPrice = New System.Windows.Forms.ColumnHeader
        Me.SAP = New System.Windows.Forms.ColumnHeader
        Me.Commision = New System.Windows.Forms.ColumnHeader
        Me.UnitCost = New System.Windows.Forms.ColumnHeader
        Me.DRNo = New System.Windows.Forms.ColumnHeader
        Me.Customer = New System.Windows.Forms.ColumnHeader
        Me.CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnEnter = New System.Windows.Forms.Button
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.txtDRNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbxCustomer = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.CMS.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUnitCost
        '
        Me.txtUnitCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitCost.ForeColor = System.Drawing.Color.Red
        Me.txtUnitCost.Location = New System.Drawing.Point(532, 5)
        Me.txtUnitCost.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUnitCost.Name = "txtUnitCost"
        Me.txtUnitCost.Size = New System.Drawing.Size(141, 26)
        Me.txtUnitCost.TabIndex = 91
        Me.txtUnitCost.Text = "0"
        Me.txtUnitCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtUnitCost.Visible = False
        '
        'lblTotalQuantity
        '
        Me.lblTotalQuantity.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalQuantity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotalQuantity.Location = New System.Drawing.Point(859, 141)
        Me.lblTotalQuantity.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalQuantity.Name = "lblTotalQuantity"
        Me.lblTotalQuantity.Size = New System.Drawing.Size(57, 20)
        Me.lblTotalQuantity.TabIndex = 90
        Me.lblTotalQuantity.Text = "--------"
        Me.lblTotalQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(701, 141)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 20)
        Me.Label12.TabIndex = 89
        Me.Label12.Text = "Total Quantity:"
        '
        'txtQuantity
        '
        Me.txtQuantity.Enabled = False
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.ForeColor = System.Drawing.Color.Red
        Me.txtQuantity.Location = New System.Drawing.Point(855, 102)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(61, 26)
        Me.txtQuantity.TabIndex = 4
        Me.txtQuantity.Text = "0"
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(746, 105)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 20)
        Me.Label10.TabIndex = 88
        Me.Label10.Text = "Quantity:"
        '
        'btnAddEntry
        '
        Me.btnAddEntry.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddEntry.Enabled = False
        Me.btnAddEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEntry.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.add
        Me.btnAddEntry.Location = New System.Drawing.Point(981, 185)
        Me.btnAddEntry.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddEntry.Name = "btnAddEntry"
        Me.btnAddEntry.Size = New System.Drawing.Size(117, 33)
        Me.btnAddEntry.TabIndex = 8
        Me.btnAddEntry.Text = "Add Entry"
        Me.btnAddEntry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddEntry.UseVisualStyleBackColor = True
        '
        'txtItemId
        '
        Me.txtItemId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtItemId.Location = New System.Drawing.Point(701, 5)
        Me.txtItemId.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtItemId.Name = "txtItemId"
        Me.txtItemId.Size = New System.Drawing.Size(148, 26)
        Me.txtItemId.TabIndex = 87
        Me.txtItemId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtItemId.Visible = False
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.Color.Blue
        Me.lblDescription.Location = New System.Drawing.Point(531, 63)
        Me.lblDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(123, 20)
        Me.lblDescription.TabIndex = 86
        Me.lblDescription.Text = "-------------------"
        '
        'txtItemNo
        '
        Me.txtItemNo.BackColor = System.Drawing.Color.White
        Me.txtItemNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItemNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtItemNo.Location = New System.Drawing.Point(532, 28)
        Me.txtItemNo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtItemNo.Name = "txtItemNo"
        Me.txtItemNo.ReadOnly = True
        Me.txtItemNo.Size = New System.Drawing.Size(317, 26)
        Me.txtItemNo.TabIndex = 85
        Me.txtItemNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(418, 63)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 20)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "Description:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(416, 29)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 20)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Item no:"
        '
        'txtSAP
        '
        Me.txtSAP.Enabled = False
        Me.txtSAP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSAP.ForeColor = System.Drawing.Color.Red
        Me.txtSAP.Location = New System.Drawing.Point(578, 141)
        Me.txtSAP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSAP.Name = "txtSAP"
        Me.txtSAP.Size = New System.Drawing.Size(102, 26)
        Me.txtSAP.TabIndex = 6
        Me.txtSAP.Text = "0"
        Me.txtSAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(417, 141)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(154, 20)
        Me.Label15.TabIndex = 82
        Me.Label15.Text = "Sales agent price:"
        '
        'txtCommision
        '
        Me.txtCommision.Enabled = False
        Me.txtCommision.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCommision.ForeColor = System.Drawing.Color.Red
        Me.txtCommision.Location = New System.Drawing.Point(578, 177)
        Me.txtCommision.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCommision.Name = "txtCommision"
        Me.txtCommision.Size = New System.Drawing.Size(102, 26)
        Me.txtCommision.TabIndex = 7
        Me.txtCommision.Text = "0"
        Me.txtCommision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(417, 177)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 20)
        Me.Label14.TabIndex = 81
        Me.Label14.Text = "Commission:"
        '
        'txtSalesPrice
        '
        Me.txtSalesPrice.Enabled = False
        Me.txtSalesPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesPrice.ForeColor = System.Drawing.Color.Red
        Me.txtSalesPrice.Location = New System.Drawing.Point(578, 105)
        Me.txtSalesPrice.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSalesPrice.Name = "txtSalesPrice"
        Me.txtSalesPrice.Size = New System.Drawing.Size(102, 26)
        Me.txtSalesPrice.TabIndex = 5
        Me.txtSalesPrice.Text = "0"
        Me.txtSalesPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(417, 105)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 20)
        Me.Label13.TabIndex = 80
        Me.Label13.Text = "Sales Price:"
        '
        'btnSearch
        '
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.Search
        Me.btnSearch.Location = New System.Drawing.Point(872, 19)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(35, 40)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lstvwItems
        '
        Me.lstvwItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ItemId, Me.ItemNo, Me.Description, Me.Quantity, Me.TotalQty, Me.SalesPrice, Me.SAP, Me.Commision, Me.UnitCost, Me.DRNo, Me.Customer})
        Me.lstvwItems.ContextMenuStrip = Me.CMS
        Me.lstvwItems.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwItems.FullRowSelect = True
        Me.lstvwItems.GridLines = True
        Me.lstvwItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwItems.Location = New System.Drawing.Point(13, 218)
        Me.lstvwItems.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstvwItems.Name = "lstvwItems"
        Me.lstvwItems.Size = New System.Drawing.Size(1085, 197)
        Me.lstvwItems.TabIndex = 9
        Me.lstvwItems.UseCompatibleStateImageBehavior = False
        Me.lstvwItems.View = System.Windows.Forms.View.Details
        '
        'ItemId
        '
        Me.ItemId.DisplayIndex = 2
        Me.ItemId.Text = "ItemId"
        Me.ItemId.Width = 0
        '
        'ItemNo
        '
        Me.ItemNo.DisplayIndex = 3
        Me.ItemNo.Text = "ItemNo"
        Me.ItemNo.Width = 97
        '
        'Description
        '
        Me.Description.DisplayIndex = 4
        Me.Description.Text = "Description"
        Me.Description.Width = 267
        '
        'Quantity
        '
        Me.Quantity.DisplayIndex = 5
        Me.Quantity.Text = "Quantity"
        Me.Quantity.Width = 80
        '
        'TotalQty
        '
        Me.TotalQty.DisplayIndex = 6
        Me.TotalQty.Text = "Total QTY"
        Me.TotalQty.Width = 94
        '
        'SalesPrice
        '
        Me.SalesPrice.DisplayIndex = 7
        Me.SalesPrice.Text = "Sales Price"
        Me.SalesPrice.Width = 112
        '
        'SAP
        '
        Me.SAP.DisplayIndex = 8
        Me.SAP.Text = "SAP"
        Me.SAP.Width = 100
        '
        'Commision
        '
        Me.Commision.DisplayIndex = 9
        Me.Commision.Text = "Commision"
        Me.Commision.Width = 100
        '
        'UnitCost
        '
        Me.UnitCost.DisplayIndex = 10
        Me.UnitCost.Text = ""
        Me.UnitCost.Width = 0
        '
        'DRNo
        '
        Me.DRNo.DisplayIndex = 0
        Me.DRNo.Text = "DR #"
        Me.DRNo.Width = 70
        '
        'Customer
        '
        Me.Customer.DisplayIndex = 1
        Me.Customer.Text = "Customer"
        Me.Customer.Width = 151
        '
        'CMS
        '
        Me.CMS.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.DeleteToolStripMenuItem})
        Me.CMS.Name = "CMS"
        Me.CMS.Size = New System.Drawing.Size(131, 36)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(127, 6)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Enabled = False
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(130, 26)
        Me.DeleteToolStripMenuItem.Text = "&Delete"
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Red
        Me.btnCancel.Location = New System.Drawing.Point(1014, 422)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(84, 43)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(922, 422)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(84, 43)
        Me.btnEnter.TabIndex = 10
        Me.btnEnter.Text = "&Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'dtpDate
        '
        Me.dtpDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Location = New System.Drawing.Point(79, 85)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(285, 26)
        Me.dtpDate.TabIndex = 0
        '
        'txtDRNo
        '
        Me.txtDRNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDRNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDRNo.Location = New System.Drawing.Point(79, 124)
        Me.txtDRNo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDRNo.Name = "txtDRNo"
        Me.txtDRNo.Size = New System.Drawing.Size(285, 26)
        Me.txtDRNo.TabIndex = 1
        Me.txtDRNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(15, 127)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 20)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "DR#:"
        '
        'cmbxCustomer
        '
        Me.cmbxCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbxCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxCustomer.FormattingEnabled = True
        Me.cmbxCustomer.Location = New System.Drawing.Point(114, 165)
        Me.cmbxCustomer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbxCustomer.Name = "cmbxCustomer"
        Me.cmbxCustomer.Size = New System.Drawing.Size(250, 28)
        Me.cmbxCustomer.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(14, 168)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Customer:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 20)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Please select and fill-up the empty fields."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(951, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(147, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 92
        Me.PictureBox1.TabStop = False
        '
        'frmEntrySalesMulti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1117, 473)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtUnitCost)
        Me.Controls.Add(Me.lblTotalQuantity)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnAddEntry)
        Me.Controls.Add(Me.txtItemId)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.txtItemNo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSAP)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtCommision)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtSalesPrice)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lstvwItems)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.txtDRNo)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.cmbxCustomer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEntrySalesMulti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multiple Sales Entries"
        Me.CMS.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUnitCost As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalQuantity As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnAddEntry As System.Windows.Forms.Button
    Friend WithEvents txtItemId As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents txtItemNo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSAP As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCommision As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtSalesPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lstvwItems As System.Windows.Forms.ListView
    Friend WithEvents ItemId As System.Windows.Forms.ColumnHeader
    Friend WithEvents ItemNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Description As System.Windows.Forms.ColumnHeader
    Friend WithEvents Quantity As System.Windows.Forms.ColumnHeader
    Friend WithEvents TotalQty As System.Windows.Forms.ColumnHeader
    Friend WithEvents SalesPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents SAP As System.Windows.Forms.ColumnHeader
    Friend WithEvents Commision As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDRNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbxCustomer As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CMS As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnitCost As System.Windows.Forms.ColumnHeader
    Friend WithEvents DRNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Customer As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
