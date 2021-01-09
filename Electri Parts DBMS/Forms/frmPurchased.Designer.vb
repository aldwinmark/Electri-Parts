<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchased
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPurchased))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.lstvwItems = New System.Windows.Forms.ListView
        Me.Id = New System.Windows.Forms.ColumnHeader
        Me.ItemNo = New System.Windows.Forms.ColumnHeader
        Me.Description = New System.Windows.Forms.ColumnHeader
        Me.IVendor = New System.Windows.Forms.ColumnHeader
        Me.UnitCost = New System.Windows.Forms.ColumnHeader
        Me.Quantity = New System.Windows.Forms.ColumnHeader
        Me.DateIn = New System.Windows.Forms.ColumnHeader
        Me.VendorId = New System.Windows.Forms.ColumnHeader
        Me.Remarks = New System.Windows.Forms.ColumnHeader
        Me.Lock = New System.Windows.Forms.ColumnHeader
        Me.OrigQty = New System.Windows.Forms.ColumnHeader
        Me.RSNo = New System.Windows.Forms.ColumnHeader
        Me.CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UserMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddMultiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.AdjToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.lblTotalList = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lstvwAccumulated = New System.Windows.Forms.ListView
        Me.accItemNo = New System.Windows.Forms.ColumnHeader
        Me.accDescription = New System.Windows.Forms.ColumnHeader
        Me.accQuantity = New System.Windows.Forms.ColumnHeader
        Me.TotalQuantity = New System.Windows.Forms.ColumnHeader
        Me.chkbxReadOnly = New System.Windows.Forms.CheckBox
        Me.dtpStart = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker
        Me.grpbxDate = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbxSortAcc = New System.Windows.Forms.ComboBox
        Me.rbtnDesc = New System.Windows.Forms.RadioButton
        Me.cmbxSortIndi = New System.Windows.Forms.ComboBox
        Me.rbtnAsc = New System.Windows.Forms.RadioButton
        Me.btnLock = New System.Windows.Forms.Button
        Me.btnCheckAll = New System.Windows.Forms.Button
        Me.btnUncheckAll = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.grpbxLock = New System.Windows.Forms.GroupBox
        Me.chckbxDormant = New System.Windows.Forms.CheckBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.CMS.SuspendLayout()
        Me.grpbxDate.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbxLock.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(550, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "List of Items"
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(892, 93)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(251, 26)
        Me.txtSearch.TabIndex = 11
        '
        'lstvwItems
        '
        Me.lstvwItems.AllowDrop = True
        Me.lstvwItems.BackgroundImageTiled = True
        Me.lstvwItems.CheckBoxes = True
        Me.lstvwItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Id, Me.ItemNo, Me.Description, Me.IVendor, Me.UnitCost, Me.Quantity, Me.DateIn, Me.VendorId, Me.Remarks, Me.Lock, Me.OrigQty, Me.RSNo})
        Me.lstvwItems.ContextMenuStrip = Me.CMS
        Me.lstvwItems.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwItems.FullRowSelect = True
        Me.lstvwItems.GridLines = True
        Me.lstvwItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwItems.HideSelection = False
        Me.lstvwItems.Location = New System.Drawing.Point(23, 128)
        Me.lstvwItems.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstvwItems.MultiSelect = False
        Me.lstvwItems.Name = "lstvwItems"
        Me.lstvwItems.Size = New System.Drawing.Size(1149, 577)
        Me.lstvwItems.TabIndex = 13
        Me.lstvwItems.UseCompatibleStateImageBehavior = False
        Me.lstvwItems.View = System.Windows.Forms.View.Details
        '
        'Id
        '
        Me.Id.Text = ""
        Me.Id.Width = 20
        '
        'ItemNo
        '
        Me.ItemNo.DisplayIndex = 2
        Me.ItemNo.Text = "Item no."
        Me.ItemNo.Width = 90
        '
        'Description
        '
        Me.Description.DisplayIndex = 3
        Me.Description.Text = "Description"
        Me.Description.Width = 306
        '
        'IVendor
        '
        Me.IVendor.DisplayIndex = 4
        Me.IVendor.Text = "Vendor"
        Me.IVendor.Width = 165
        '
        'UnitCost
        '
        Me.UnitCost.DisplayIndex = 5
        Me.UnitCost.Text = "Unit cost"
        Me.UnitCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.UnitCost.Width = 86
        '
        'Quantity
        '
        Me.Quantity.DisplayIndex = 6
        Me.Quantity.Text = "Quantity"
        Me.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Quantity.Width = 80
        '
        'DateIn
        '
        Me.DateIn.DisplayIndex = 8
        Me.DateIn.Text = "Date-In"
        Me.DateIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DateIn.Width = 200
        '
        'VendorId
        '
        Me.VendorId.DisplayIndex = 9
        Me.VendorId.Text = ""
        Me.VendorId.Width = 0
        '
        'Remarks
        '
        Me.Remarks.DisplayIndex = 10
        Me.Remarks.Text = ""
        Me.Remarks.Width = 0
        '
        'Lock
        '
        Me.Lock.DisplayIndex = 11
        Me.Lock.Text = ""
        Me.Lock.Width = 0
        '
        'OrigQty
        '
        Me.OrigQty.DisplayIndex = 7
        Me.OrigQty.Text = "Orig. Qty"
        Me.OrigQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.OrigQty.Width = 94
        '
        'RSNo
        '
        Me.RSNo.DisplayIndex = 1
        Me.RSNo.Text = "RS #"
        Me.RSNo.Width = 81
        '
        'CMS
        '
        Me.CMS.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserMenuToolStripMenuItem, Me.ToolStripSeparator1, Me.AddToolStripMenuItem, Me.AddMultiToolStripMenuItem, Me.ToolStripSeparator4, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator2, Me.AdjToolStripMenuItem, Me.RefreshToolStripMenuItem, Me.ToolStripSeparator3})
        Me.CMS.Name = "CMS"
        Me.CMS.Size = New System.Drawing.Size(181, 210)
        '
        'UserMenuToolStripMenuItem
        '
        Me.UserMenuToolStripMenuItem.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.clipboard_text
        Me.UserMenuToolStripMenuItem.Name = "UserMenuToolStripMenuItem"
        Me.UserMenuToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.UserMenuToolStripMenuItem.Text = "Item Menu"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Enabled = False
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.AddToolStripMenuItem.Text = "&Add"
        '
        'AddMultiToolStripMenuItem
        '
        Me.AddMultiToolStripMenuItem.Enabled = False
        Me.AddMultiToolStripMenuItem.Name = "AddMultiToolStripMenuItem"
        Me.AddMultiToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.AddMultiToolStripMenuItem.Text = "Add Multiple"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(177, 6)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Enabled = False
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Enabled = False
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.DeleteToolStripMenuItem.Text = "&Delete"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'AdjToolStripMenuItem
        '
        Me.AdjToolStripMenuItem.Enabled = False
        Me.AdjToolStripMenuItem.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.About
        Me.AdjToolStripMenuItem.Name = "AdjToolStripMenuItem"
        Me.AdjToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.AdjToolStripMenuItem.Text = "Adjustment"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.Refresh
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(177, 6)
        '
        'lblTotalList
        '
        Me.lblTotalList.AutoSize = True
        Me.lblTotalList.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalList.ForeColor = System.Drawing.Color.Maroon
        Me.lblTotalList.Location = New System.Drawing.Point(107, 710)
        Me.lblTotalList.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalList.Name = "lblTotalList"
        Me.lblTotalList.Size = New System.Drawing.Size(19, 20)
        Me.lblTotalList.TabIndex = 15
        Me.lblTotalList.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 710)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Total list:"
        '
        'lstvwAccumulated
        '
        Me.lstvwAccumulated.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.accItemNo, Me.accDescription, Me.accQuantity, Me.TotalQuantity})
        Me.lstvwAccumulated.ContextMenuStrip = Me.CMS
        Me.lstvwAccumulated.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwAccumulated.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwAccumulated.FullRowSelect = True
        Me.lstvwAccumulated.GridLines = True
        Me.lstvwAccumulated.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwAccumulated.Location = New System.Drawing.Point(23, 128)
        Me.lstvwAccumulated.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstvwAccumulated.Name = "lstvwAccumulated"
        Me.lstvwAccumulated.Size = New System.Drawing.Size(1148, 577)
        Me.lstvwAccumulated.TabIndex = 16
        Me.lstvwAccumulated.UseCompatibleStateImageBehavior = False
        Me.lstvwAccumulated.View = System.Windows.Forms.View.Details
        Me.lstvwAccumulated.Visible = False
        '
        'accItemNo
        '
        Me.accItemNo.Text = "Item no."
        Me.accItemNo.Width = 100
        '
        'accDescription
        '
        Me.accDescription.Text = "Description"
        Me.accDescription.Width = 600
        '
        'accQuantity
        '
        Me.accQuantity.Text = "Actual quantity"
        Me.accQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.accQuantity.Width = 150
        '
        'TotalQuantity
        '
        Me.TotalQuantity.Text = "Total Quantity"
        Me.TotalQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TotalQuantity.Width = 176
        '
        'chkbxReadOnly
        '
        Me.chkbxReadOnly.AutoSize = True
        Me.chkbxReadOnly.BackColor = System.Drawing.Color.Transparent
        Me.chkbxReadOnly.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkbxReadOnly.Location = New System.Drawing.Point(1046, 69)
        Me.chkbxReadOnly.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chkbxReadOnly.Name = "chkbxReadOnly"
        Me.chkbxReadOnly.Size = New System.Drawing.Size(100, 24)
        Me.chkbxReadOnly.TabIndex = 17
        Me.chkbxReadOnly.Text = "Read-only"
        Me.chkbxReadOnly.UseVisualStyleBackColor = False
        '
        'dtpStart
        '
        Me.dtpStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStart.Location = New System.Drawing.Point(99, 17)
        Me.dtpStart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(336, 26)
        Me.dtpStart.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(43, 22)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Start:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(752, 22)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "End:"
        '
        'dtpEnd
        '
        Me.dtpEnd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnd.Location = New System.Drawing.Point(802, 17)
        Me.dtpEnd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(339, 26)
        Me.dtpEnd.TabIndex = 20
        '
        'grpbxDate
        '
        Me.grpbxDate.BackColor = System.Drawing.Color.Transparent
        Me.grpbxDate.Controls.Add(Me.dtpEnd)
        Me.grpbxDate.Controls.Add(Me.dtpStart)
        Me.grpbxDate.Controls.Add(Me.Label3)
        Me.grpbxDate.Controls.Add(Me.Label4)
        Me.grpbxDate.Controls.Add(Me.Label1)
        Me.grpbxDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxDate.Location = New System.Drawing.Point(23, 12)
        Me.grpbxDate.Name = "grpbxDate"
        Me.grpbxDate.Size = New System.Drawing.Size(1148, 49)
        Me.grpbxDate.TabIndex = 22
        Me.grpbxDate.TabStop = False
        Me.grpbxDate.Text = "Date"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmbxSortAcc)
        Me.GroupBox1.Controls.Add(Me.rbtnDesc)
        Me.GroupBox1.Controls.Add(Me.cmbxSortIndi)
        Me.GroupBox1.Controls.Add(Me.rbtnAsc)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox1.Location = New System.Drawing.Point(330, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(398, 50)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sort by"
        '
        'cmbxSortAcc
        '
        Me.cmbxSortAcc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbxSortAcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxSortAcc.FormattingEnabled = True
        Me.cmbxSortAcc.Items.AddRange(New Object() {"1-Item#", "2-Description"})
        Me.cmbxSortAcc.Location = New System.Drawing.Point(7, 17)
        Me.cmbxSortAcc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbxSortAcc.Name = "cmbxSortAcc"
        Me.cmbxSortAcc.Size = New System.Drawing.Size(171, 24)
        Me.cmbxSortAcc.TabIndex = 3
        '
        'rbtnDesc
        '
        Me.rbtnDesc.AutoSize = True
        Me.rbtnDesc.ForeColor = System.Drawing.Color.Blue
        Me.rbtnDesc.Location = New System.Drawing.Point(283, 20)
        Me.rbtnDesc.Name = "rbtnDesc"
        Me.rbtnDesc.Size = New System.Drawing.Size(109, 20)
        Me.rbtnDesc.TabIndex = 0
        Me.rbtnDesc.Text = "Descending"
        Me.rbtnDesc.UseVisualStyleBackColor = True
        '
        'cmbxSortIndi
        '
        Me.cmbxSortIndi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbxSortIndi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxSortIndi.FormattingEnabled = True
        Me.cmbxSortIndi.Items.AddRange(New Object() {"1-Item#", "2-Description", "3-Vendor Name", "4-Quantity"})
        Me.cmbxSortIndi.Location = New System.Drawing.Point(7, 18)
        Me.cmbxSortIndi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbxSortIndi.Name = "cmbxSortIndi"
        Me.cmbxSortIndi.Size = New System.Drawing.Size(171, 24)
        Me.cmbxSortIndi.TabIndex = 2
        '
        'rbtnAsc
        '
        Me.rbtnAsc.AutoSize = True
        Me.rbtnAsc.Checked = True
        Me.rbtnAsc.ForeColor = System.Drawing.Color.Blue
        Me.rbtnAsc.Location = New System.Drawing.Point(185, 20)
        Me.rbtnAsc.Name = "rbtnAsc"
        Me.rbtnAsc.Size = New System.Drawing.Size(99, 20)
        Me.rbtnAsc.TabIndex = 1
        Me.rbtnAsc.TabStop = True
        Me.rbtnAsc.Text = "Ascending"
        Me.rbtnAsc.UseVisualStyleBackColor = True
        '
        'btnLock
        '
        Me.btnLock.BackColor = System.Drawing.Color.White
        Me.btnLock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLock.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.Car_key
        Me.btnLock.Location = New System.Drawing.Point(6, 17)
        Me.btnLock.Name = "btnLock"
        Me.btnLock.Size = New System.Drawing.Size(41, 34)
        Me.btnLock.TabIndex = 26
        Me.btnLock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLock.UseVisualStyleBackColor = False
        '
        'btnCheckAll
        '
        Me.btnCheckAll.BackColor = System.Drawing.Color.White
        Me.btnCheckAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckAll.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.Apply
        Me.btnCheckAll.Location = New System.Drawing.Point(53, 17)
        Me.btnCheckAll.Name = "btnCheckAll"
        Me.btnCheckAll.Size = New System.Drawing.Size(110, 34)
        Me.btnCheckAll.TabIndex = 25
        Me.btnCheckAll.Text = "Check All"
        Me.btnCheckAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCheckAll.UseVisualStyleBackColor = False
        '
        'btnUncheckAll
        '
        Me.btnUncheckAll.BackColor = System.Drawing.Color.White
        Me.btnUncheckAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUncheckAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUncheckAll.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.Red_mark
        Me.btnUncheckAll.Location = New System.Drawing.Point(169, 17)
        Me.btnUncheckAll.Name = "btnUncheckAll"
        Me.btnUncheckAll.Size = New System.Drawing.Size(115, 34)
        Me.btnUncheckAll.TabIndex = 24
        Me.btnUncheckAll.Text = "Uncheck All"
        Me.btnUncheckAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUncheckAll.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.magnifier
        Me.PictureBox1.Location = New System.Drawing.Point(1149, 95)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'grpbxLock
        '
        Me.grpbxLock.BackColor = System.Drawing.Color.Transparent
        Me.grpbxLock.Controls.Add(Me.btnLock)
        Me.grpbxLock.Controls.Add(Me.btnCheckAll)
        Me.grpbxLock.Controls.Add(Me.btnUncheckAll)
        Me.grpbxLock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxLock.Location = New System.Drawing.Point(23, 75)
        Me.grpbxLock.Name = "grpbxLock"
        Me.grpbxLock.Size = New System.Drawing.Size(289, 53)
        Me.grpbxLock.TabIndex = 27
        Me.grpbxLock.TabStop = False
        Me.grpbxLock.Text = "Lock"
        '
        'chckbxDormant
        '
        Me.chckbxDormant.AutoSize = True
        Me.chckbxDormant.BackColor = System.Drawing.Color.Transparent
        Me.chckbxDormant.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chckbxDormant.Location = New System.Drawing.Point(892, 69)
        Me.chckbxDormant.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.chckbxDormant.Name = "chckbxDormant"
        Me.chckbxDormant.Size = New System.Drawing.Size(101, 24)
        Me.chckbxDormant.TabIndex = 28
        Me.chckbxDormant.Text = "Include All"
        Me.chckbxDormant.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Transparent
        Me.btnSearch.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.magnifier
        Me.btnSearch.Location = New System.Drawing.Point(779, 89)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(106, 34)
        Me.btnSearch.TabIndex = 29
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'frmPurchased
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1198, 747)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.chckbxDormant)
        Me.Controls.Add(Me.grpbxDate)
        Me.Controls.Add(Me.grpbxLock)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblTotalList)
        Me.Controls.Add(Me.chkbxReadOnly)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lstvwItems)
        Me.Controls.Add(Me.lstvwAccumulated)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPurchased"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Purchased"
        Me.CMS.ResumeLayout(False)
        Me.grpbxDate.ResumeLayout(False)
        Me.grpbxDate.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbxLock.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lstvwItems As System.Windows.Forms.ListView
    Friend WithEvents ItemNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Description As System.Windows.Forms.ColumnHeader
    Friend WithEvents Quantity As System.Windows.Forms.ColumnHeader
    Friend WithEvents DateIn As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblTotalList As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CMS As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents UserMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnitCost As System.Windows.Forms.ColumnHeader
    Friend WithEvents Id As System.Windows.Forms.ColumnHeader
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstvwAccumulated As System.Windows.Forms.ListView
    Friend WithEvents accItemNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents accDescription As System.Windows.Forms.ColumnHeader
    Friend WithEvents accQuantity As System.Windows.Forms.ColumnHeader
    Friend WithEvents chkbxReadOnly As System.Windows.Forms.CheckBox
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents IVendor As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents grpbxDate As System.Windows.Forms.GroupBox
    Friend WithEvents VendorId As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnAsc As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnDesc As System.Windows.Forms.RadioButton
    Friend WithEvents cmbxSortIndi As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AdjToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Remarks As System.Windows.Forms.ColumnHeader
    Friend WithEvents Lock As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnUncheckAll As System.Windows.Forms.Button
    Friend WithEvents btnCheckAll As System.Windows.Forms.Button
    Friend WithEvents btnLock As System.Windows.Forms.Button
    Friend WithEvents grpbxLock As System.Windows.Forms.GroupBox
    Friend WithEvents cmbxSortAcc As System.Windows.Forms.ComboBox
    Friend WithEvents chckbxDormant As System.Windows.Forms.CheckBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents OrigQty As System.Windows.Forms.ColumnHeader
    Friend WithEvents TotalQuantity As System.Windows.Forms.ColumnHeader
    Friend WithEvents RSNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents AddMultiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
End Class
