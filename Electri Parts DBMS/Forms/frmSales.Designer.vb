<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSales))
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.lblTotalList = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lstvwItems = New System.Windows.Forms.ListView
        Me.Id = New System.Windows.Forms.ColumnHeader
        Me.DRNo = New System.Windows.Forms.ColumnHeader
        Me.ItemNo = New System.Windows.Forms.ColumnHeader
        Me.Description = New System.Windows.Forms.ColumnHeader
        Me.Customer = New System.Windows.Forms.ColumnHeader
        Me.Quantity = New System.Windows.Forms.ColumnHeader
        Me.ActualSalesPrice = New System.Windows.Forms.ColumnHeader
        Me.TSalesPrice = New System.Windows.Forms.ColumnHeader
        Me.SAP = New System.Windows.Forms.ColumnHeader
        Me.TSAP = New System.Windows.Forms.ColumnHeader
        Me.Commision = New System.Windows.Forms.ColumnHeader
        Me.TCommision = New System.Windows.Forms.ColumnHeader
        Me.DateIn = New System.Windows.Forms.ColumnHeader
        Me.tblItemNo = New System.Windows.Forms.ColumnHeader
        Me.TotalQty = New System.Windows.Forms.ColumnHeader
        Me.Remarks = New System.Windows.Forms.ColumnHeader
        Me.Lock = New System.Windows.Forms.ColumnHeader
        Me.CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UserMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddMultipleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.AdjToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbxSort = New System.Windows.Forms.ComboBox
        Me.rbtnAsc = New System.Windows.Forms.RadioButton
        Me.rbtnDesc = New System.Windows.Forms.RadioButton
        Me.grpbxDate = New System.Windows.Forms.GroupBox
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker
        Me.dtpStart = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.grpbxLock = New System.Windows.Forms.GroupBox
        Me.btnLock = New System.Windows.Forms.Button
        Me.btnCheckAll = New System.Windows.Forms.Button
        Me.btnUncheckAll = New System.Windows.Forms.Button
        Me.chckbxNoDate = New System.Windows.Forms.CheckBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.CMS.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpbxDate.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbxLock.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Location = New System.Drawing.Point(420, 89)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(811, 26)
        Me.txtSearch.TabIndex = 1
        '
        'lblTotalList
        '
        Me.lblTotalList.AutoSize = True
        Me.lblTotalList.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalList.ForeColor = System.Drawing.Color.Maroon
        Me.lblTotalList.Location = New System.Drawing.Point(92, 720)
        Me.lblTotalList.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalList.Name = "lblTotalList"
        Me.lblTotalList.Size = New System.Drawing.Size(19, 20)
        Me.lblTotalList.TabIndex = 14
        Me.lblTotalList.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 720)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Total list:"
        '
        'lstvwItems
        '
        Me.lstvwItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstvwItems.BackColor = System.Drawing.Color.AliceBlue
        Me.lstvwItems.CheckBoxes = True
        Me.lstvwItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Id, Me.DRNo, Me.ItemNo, Me.Description, Me.Customer, Me.Quantity, Me.ActualSalesPrice, Me.TSalesPrice, Me.SAP, Me.TSAP, Me.Commision, Me.TCommision, Me.DateIn, Me.tblItemNo, Me.TotalQty, Me.Remarks, Me.Lock})
        Me.lstvwItems.ContextMenuStrip = Me.CMS
        Me.lstvwItems.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwItems.FullRowSelect = True
        Me.lstvwItems.GridLines = True
        Me.lstvwItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwItems.Location = New System.Drawing.Point(18, 124)
        Me.lstvwItems.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstvwItems.MultiSelect = False
        Me.lstvwItems.Name = "lstvwItems"
        Me.lstvwItems.Size = New System.Drawing.Size(1237, 591)
        Me.lstvwItems.TabIndex = 2
        Me.lstvwItems.UseCompatibleStateImageBehavior = False
        Me.lstvwItems.View = System.Windows.Forms.View.Details
        '
        'Id
        '
        Me.Id.Text = ""
        Me.Id.Width = 0
        '
        'DRNo
        '
        Me.DRNo.Text = "DR#"
        Me.DRNo.Width = 90
        '
        'ItemNo
        '
        Me.ItemNo.Text = "Item no."
        Me.ItemNo.Width = 90
        '
        'Description
        '
        Me.Description.Text = "Description"
        Me.Description.Width = 270
        '
        'Customer
        '
        Me.Customer.Text = "Customer"
        Me.Customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Customer.Width = 170
        '
        'Quantity
        '
        Me.Quantity.Text = "Quantity"
        Me.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Quantity.Width = 80
        '
        'ActualSalesPrice
        '
        Me.ActualSalesPrice.Text = "Sales Price"
        Me.ActualSalesPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ActualSalesPrice.Width = 203
        '
        'TSalesPrice
        '
        Me.TSalesPrice.Text = "Qty x SP"
        Me.TSalesPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TSalesPrice.Width = 100
        '
        'SAP
        '
        Me.SAP.Text = "SAP"
        Me.SAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SAP.Width = 100
        '
        'TSAP
        '
        Me.TSAP.Text = "Qty x SAP"
        Me.TSAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TSAP.Width = 100
        '
        'Commision
        '
        Me.Commision.Text = "Commision"
        Me.Commision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Commision.Width = 100
        '
        'TCommision
        '
        Me.TCommision.Text = "Qty x Comm."
        Me.TCommision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TCommision.Width = 110
        '
        'DateIn
        '
        Me.DateIn.Text = "Date"
        Me.DateIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.DateIn.Width = 100
        '
        'tblItemNo
        '
        Me.tblItemNo.Text = ""
        Me.tblItemNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tblItemNo.Width = 0
        '
        'TotalQty
        '
        Me.TotalQty.Text = ""
        Me.TotalQty.Width = 100
        '
        'Remarks
        '
        Me.Remarks.Text = "Remarks"
        Me.Remarks.Width = 0
        '
        'Lock
        '
        Me.Lock.Text = ""
        Me.Lock.Width = 0
        '
        'CMS
        '
        Me.CMS.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserMenuToolStripMenuItem, Me.ToolStripSeparator1, Me.AddToolStripMenuItem, Me.AddMultipleToolStripMenuItem, Me.ToolStripSeparator4, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ToolStripSeparator3, Me.AdjToolStripMenuItem, Me.ToolStripSeparator2, Me.RefreshToolStripMenuItem})
        Me.CMS.Name = "CMS"
        Me.CMS.Size = New System.Drawing.Size(181, 210)
        '
        'UserMenuToolStripMenuItem
        '
        Me.UserMenuToolStripMenuItem.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.Green_tag
        Me.UserMenuToolStripMenuItem.Name = "UserMenuToolStripMenuItem"
        Me.UserMenuToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.UserMenuToolStripMenuItem.Text = "Sales Menu"
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
        'AddMultipleToolStripMenuItem
        '
        Me.AddMultipleToolStripMenuItem.Enabled = False
        Me.AddMultipleToolStripMenuItem.Name = "AddMultipleToolStripMenuItem"
        Me.AddMultipleToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.AddMultipleToolStripMenuItem.Text = "Add Multiple"
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(177, 6)
        '
        'AdjToolStripMenuItem
        '
        Me.AdjToolStripMenuItem.Enabled = False
        Me.AdjToolStripMenuItem.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.About
        Me.AdjToolStripMenuItem.Name = "AdjToolStripMenuItem"
        Me.AdjToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.AdjToolStripMenuItem.Text = "Adjustment"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Checked = True
        Me.RefreshToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RefreshToolStripMenuItem.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.Refresh
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmbxSort)
        Me.GroupBox1.Controls.Add(Me.rbtnAsc)
        Me.GroupBox1.Controls.Add(Me.rbtnDesc)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox1.Location = New System.Drawing.Point(197, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(403, 49)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sort by"
        '
        'cmbxSort
        '
        Me.cmbxSort.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxSort.FormattingEnabled = True
        Me.cmbxSort.Items.AddRange(New Object() {"1-DR #", "2-Item#", "3-Description", "4-Customer", "5-Quantity", "6-Sales Price", "7-Date"})
        Me.cmbxSort.Location = New System.Drawing.Point(12, 19)
        Me.cmbxSort.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbxSort.Name = "cmbxSort"
        Me.cmbxSort.Size = New System.Drawing.Size(171, 24)
        Me.cmbxSort.TabIndex = 3
        '
        'rbtnAsc
        '
        Me.rbtnAsc.AutoSize = True
        Me.rbtnAsc.Checked = True
        Me.rbtnAsc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnAsc.ForeColor = System.Drawing.Color.Blue
        Me.rbtnAsc.Location = New System.Drawing.Point(188, 20)
        Me.rbtnAsc.Name = "rbtnAsc"
        Me.rbtnAsc.Size = New System.Drawing.Size(99, 20)
        Me.rbtnAsc.TabIndex = 1
        Me.rbtnAsc.TabStop = True
        Me.rbtnAsc.Text = "Ascending"
        Me.rbtnAsc.UseVisualStyleBackColor = True
        '
        'rbtnDesc
        '
        Me.rbtnDesc.AutoSize = True
        Me.rbtnDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnDesc.ForeColor = System.Drawing.Color.Blue
        Me.rbtnDesc.Location = New System.Drawing.Point(293, 20)
        Me.rbtnDesc.Name = "rbtnDesc"
        Me.rbtnDesc.Size = New System.Drawing.Size(109, 20)
        Me.rbtnDesc.TabIndex = 0
        Me.rbtnDesc.Text = "Descending"
        Me.rbtnDesc.UseVisualStyleBackColor = True
        '
        'grpbxDate
        '
        Me.grpbxDate.BackColor = System.Drawing.Color.Transparent
        Me.grpbxDate.Controls.Add(Me.dtpEnd)
        Me.grpbxDate.Controls.Add(Me.dtpStart)
        Me.grpbxDate.Controls.Add(Me.Label3)
        Me.grpbxDate.Controls.Add(Me.Label4)
        Me.grpbxDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxDate.Location = New System.Drawing.Point(606, 21)
        Me.grpbxDate.Name = "grpbxDate"
        Me.grpbxDate.Size = New System.Drawing.Size(656, 49)
        Me.grpbxDate.TabIndex = 23
        Me.grpbxDate.TabStop = False
        Me.grpbxDate.Text = "Date"
        '
        'dtpEnd
        '
        Me.dtpEnd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnd.Location = New System.Drawing.Point(380, 19)
        Me.dtpEnd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(269, 24)
        Me.dtpEnd.TabIndex = 20
        '
        'dtpStart
        '
        Me.dtpStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStart.Location = New System.Drawing.Point(63, 17)
        Me.dtpStart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(270, 24)
        Me.dtpStart.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(16, 22)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 18)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Start:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(338, 20)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 18)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "End:"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(80, 10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(111, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.magnifier
        Me.PictureBox1.Location = New System.Drawing.Point(1233, 92)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'grpbxLock
        '
        Me.grpbxLock.BackColor = System.Drawing.Color.Transparent
        Me.grpbxLock.Controls.Add(Me.btnLock)
        Me.grpbxLock.Controls.Add(Me.btnCheckAll)
        Me.grpbxLock.Controls.Add(Me.btnUncheckAll)
        Me.grpbxLock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxLock.Location = New System.Drawing.Point(17, 69)
        Me.grpbxLock.Name = "grpbxLock"
        Me.grpbxLock.Size = New System.Drawing.Size(290, 53)
        Me.grpbxLock.TabIndex = 28
        Me.grpbxLock.TabStop = False
        Me.grpbxLock.Text = "Lock"
        '
        'btnLock
        '
        Me.btnLock.BackColor = System.Drawing.Color.White
        Me.btnLock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLock.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.Car_key
        Me.btnLock.Location = New System.Drawing.Point(6, 16)
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
        Me.btnCheckAll.Location = New System.Drawing.Point(53, 16)
        Me.btnCheckAll.Name = "btnCheckAll"
        Me.btnCheckAll.Size = New System.Drawing.Size(115, 34)
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
        Me.btnUncheckAll.Location = New System.Drawing.Point(169, 16)
        Me.btnUncheckAll.Name = "btnUncheckAll"
        Me.btnUncheckAll.Size = New System.Drawing.Size(115, 34)
        Me.btnUncheckAll.TabIndex = 24
        Me.btnUncheckAll.Text = "Uncheck All"
        Me.btnUncheckAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUncheckAll.UseVisualStyleBackColor = False
        '
        'chckbxNoDate
        '
        Me.chckbxNoDate.AutoSize = True
        Me.chckbxNoDate.BackColor = System.Drawing.Color.Transparent
        Me.chckbxNoDate.Location = New System.Drawing.Point(1136, 79)
        Me.chckbxNoDate.Name = "chckbxNoDate"
        Me.chckbxNoDate.Size = New System.Drawing.Size(87, 24)
        Me.chckbxNoDate.TabIndex = 29
        Me.chckbxNoDate.Text = "All items"
        Me.chckbxNoDate.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Transparent
        Me.btnSearch.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.magnifier
        Me.btnSearch.Location = New System.Drawing.Point(311, 85)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(106, 34)
        Me.btnSearch.TabIndex = 27
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1274, 742)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.chckbxNoDate)
        Me.Controls.Add(Me.grpbxLock)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lstvwItems)
        Me.Controls.Add(Me.grpbxDate)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblTotalList)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales"
        Me.CMS.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpbxDate.ResumeLayout(False)
        Me.grpbxDate.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbxLock.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalList As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstvwItems As System.Windows.Forms.ListView
    Friend WithEvents DRNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Description As System.Windows.Forms.ColumnHeader
    Friend WithEvents Quantity As System.Windows.Forms.ColumnHeader
    Friend WithEvents Customer As System.Windows.Forms.ColumnHeader
    Friend WithEvents Id As System.Windows.Forms.ColumnHeader
    Friend WithEvents ItemNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents ActualSalesPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents Commision As System.Windows.Forms.ColumnHeader
    Friend WithEvents SAP As System.Windows.Forms.ColumnHeader
    Friend WithEvents CMS As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents UserMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateIn As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbxSort As System.Windows.Forms.ComboBox
    Friend WithEvents rbtnAsc As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnDesc As System.Windows.Forms.RadioButton
    Friend WithEvents grpbxDate As System.Windows.Forms.GroupBox
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TSalesPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents TSAP As System.Windows.Forms.ColumnHeader
    Friend WithEvents TCommision As System.Windows.Forms.ColumnHeader
    Friend WithEvents tblItemNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents TotalQty As System.Windows.Forms.ColumnHeader
    Friend WithEvents AdjToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Remarks As System.Windows.Forms.ColumnHeader
    Friend WithEvents grpbxLock As System.Windows.Forms.GroupBox
    Friend WithEvents btnLock As System.Windows.Forms.Button
    Friend WithEvents btnCheckAll As System.Windows.Forms.Button
    Friend WithEvents btnUncheckAll As System.Windows.Forms.Button
    Friend WithEvents Lock As System.Windows.Forms.ColumnHeader
    Friend WithEvents AddMultipleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents chckbxNoDate As System.Windows.Forms.CheckBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
End Class
