<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransMon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransMon))
        Me.lstvwItemsP = New System.Windows.Forms.ListView
        Me.pId = New System.Windows.Forms.ColumnHeader
        Me.pDateIn = New System.Windows.Forms.ColumnHeader
        Me.pItemNo = New System.Windows.Forms.ColumnHeader
        Me.pDescription = New System.Windows.Forms.ColumnHeader
        Me.pQuantity = New System.Windows.Forms.ColumnHeader
        Me.pOrigQuantity = New System.Windows.Forms.ColumnHeader
        Me.pVendor = New System.Windows.Forms.ColumnHeader
        Me.pRemarks = New System.Windows.Forms.ColumnHeader
        Me.RSNo = New System.Windows.Forms.ColumnHeader
        Me.ID = New System.Windows.Forms.ColumnHeader
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.txtSearchP = New System.Windows.Forms.TextBox
        Me.grpbxDatePurchased = New System.Windows.Forms.GroupBox
        Me.dtpEndP = New System.Windows.Forms.DateTimePicker
        Me.dtpStartP = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lstvwItemsS = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader
        Me.lblPTotalList = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblSTotalList = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbxSortP = New System.Windows.Forms.ComboBox
        Me.rbtnAscP = New System.Windows.Forms.RadioButton
        Me.rbtnDescP = New System.Windows.Forms.RadioButton
        Me.chkbxPurchased = New System.Windows.Forms.CheckBox
        Me.chkbxSales = New System.Windows.Forms.CheckBox
        Me.grpbxDateSales = New System.Windows.Forms.GroupBox
        Me.dtpEndS = New System.Windows.Forms.DateTimePicker
        Me.dtpStartS = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnSearchP = New System.Windows.Forms.Button
        Me.btnSearchS = New System.Windows.Forms.Button
        Me.txtSearchS = New System.Windows.Forms.TextBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbxSortS = New System.Windows.Forms.ComboBox
        Me.rbtnAscS = New System.Windows.Forms.RadioButton
        Me.rbtnDescS = New System.Windows.Forms.RadioButton
        Me.lblPOrigQuantity = New System.Windows.Forms.Label
        Me.lblSQuantity = New System.Windows.Forms.Label
        Me.lblPSelCount = New System.Windows.Forms.Label
        Me.lblSSelCount = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbxDatePurchased.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpbxDateSales.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstvwItemsP
        '
        Me.lstvwItemsP.AllowDrop = True
        Me.lstvwItemsP.BackgroundImageTiled = True
        Me.lstvwItemsP.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.pId, Me.pDateIn, Me.pItemNo, Me.pDescription, Me.pQuantity, Me.pOrigQuantity, Me.pVendor, Me.pRemarks, Me.RSNo, Me.ID})
        Me.lstvwItemsP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwItemsP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwItemsP.FullRowSelect = True
        Me.lstvwItemsP.GridLines = True
        Me.lstvwItemsP.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwItemsP.HideSelection = False
        Me.lstvwItemsP.Location = New System.Drawing.Point(15, 100)
        Me.lstvwItemsP.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.lstvwItemsP.Name = "lstvwItemsP"
        Me.lstvwItemsP.Size = New System.Drawing.Size(996, 224)
        Me.lstvwItemsP.TabIndex = 14
        Me.lstvwItemsP.UseCompatibleStateImageBehavior = False
        Me.lstvwItemsP.View = System.Windows.Forms.View.Details
        '
        'pId
        '
        Me.pId.Text = ""
        Me.pId.Width = 0
        '
        'pDateIn
        '
        Me.pDateIn.Text = "Date-In"
        Me.pDateIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.pDateIn.Width = 124
        '
        'pItemNo
        '
        Me.pItemNo.Text = "Item no."
        Me.pItemNo.Width = 90
        '
        'pDescription
        '
        Me.pDescription.Text = "Description"
        Me.pDescription.Width = 296
        '
        'pQuantity
        '
        Me.pQuantity.Text = "Quantity"
        Me.pQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.pQuantity.Width = 80
        '
        'pOrigQuantity
        '
        Me.pOrigQuantity.Text = "Orig. Quantity"
        Me.pOrigQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.pOrigQuantity.Width = 139
        '
        'pVendor
        '
        Me.pVendor.Text = "Vendor"
        Me.pVendor.Width = 156
        '
        'pRemarks
        '
        Me.pRemarks.Text = ""
        Me.pRemarks.Width = 0
        '
        'RSNo
        '
        Me.RSNo.Text = "RS #"
        Me.RSNo.Width = 100
        '
        'ID
        '
        Me.ID.Text = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.magnifier
        Me.PictureBox1.Location = New System.Drawing.Point(444, 69)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'txtSearchP
        '
        Me.txtSearchP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchP.Location = New System.Drawing.Point(97, 67)
        Me.txtSearchP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSearchP.Name = "txtSearchP"
        Me.txtSearchP.Size = New System.Drawing.Size(342, 26)
        Me.txtSearchP.TabIndex = 15
        '
        'grpbxDatePurchased
        '
        Me.grpbxDatePurchased.BackColor = System.Drawing.Color.Transparent
        Me.grpbxDatePurchased.Controls.Add(Me.dtpEndP)
        Me.grpbxDatePurchased.Controls.Add(Me.dtpStartP)
        Me.grpbxDatePurchased.Controls.Add(Me.Label3)
        Me.grpbxDatePurchased.Controls.Add(Me.Label4)
        Me.grpbxDatePurchased.Controls.Add(Me.Label1)
        Me.grpbxDatePurchased.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxDatePurchased.Location = New System.Drawing.Point(259, 2)
        Me.grpbxDatePurchased.Name = "grpbxDatePurchased"
        Me.grpbxDatePurchased.Size = New System.Drawing.Size(752, 49)
        Me.grpbxDatePurchased.TabIndex = 23
        Me.grpbxDatePurchased.TabStop = False
        Me.grpbxDatePurchased.Text = "Date"
        '
        'dtpEndP
        '
        Me.dtpEndP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpEndP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndP.Location = New System.Drawing.Point(458, 17)
        Me.dtpEndP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpEndP.Name = "dtpEndP"
        Me.dtpEndP.Size = New System.Drawing.Size(286, 26)
        Me.dtpEndP.TabIndex = 20
        '
        'dtpStartP
        '
        Me.dtpStartP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpStartP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartP.Location = New System.Drawing.Point(62, 17)
        Me.dtpStartP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpStartP.Name = "dtpStartP"
        Me.dtpStartP.Size = New System.Drawing.Size(286, 26)
        Me.dtpStartP.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(7, 22)
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
        Me.Label4.Location = New System.Drawing.Point(404, 22)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "End:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(356, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Date"
        '
        'lstvwItemsS
        '
        Me.lstvwItemsS.AllowDrop = True
        Me.lstvwItemsS.BackgroundImageTiled = True
        Me.lstvwItemsS.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.lstvwItemsS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwItemsS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwItemsS.FullRowSelect = True
        Me.lstvwItemsS.GridLines = True
        Me.lstvwItemsS.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwItemsS.HideSelection = False
        Me.lstvwItemsS.Location = New System.Drawing.Point(15, 446)
        Me.lstvwItemsS.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.lstvwItemsS.Name = "lstvwItemsS"
        Me.lstvwItemsS.Size = New System.Drawing.Size(996, 246)
        Me.lstvwItemsS.TabIndex = 24
        Me.lstvwItemsS.UseCompatibleStateImageBehavior = False
        Me.lstvwItemsS.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = ""
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Date-In"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Item no."
        Me.ColumnHeader3.Width = 90
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Description"
        Me.ColumnHeader4.Width = 320
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Quantity"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader5.Width = 80
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Customer"
        Me.ColumnHeader6.Width = 180
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = ""
        Me.ColumnHeader7.Width = 0
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "DR #"
        Me.ColumnHeader8.Width = 100
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = ""
        '
        'lblPTotalList
        '
        Me.lblPTotalList.AutoSize = True
        Me.lblPTotalList.BackColor = System.Drawing.Color.Transparent
        Me.lblPTotalList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPTotalList.ForeColor = System.Drawing.Color.Maroon
        Me.lblPTotalList.Location = New System.Drawing.Point(88, 364)
        Me.lblPTotalList.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPTotalList.Name = "lblPTotalList"
        Me.lblPTotalList.Size = New System.Drawing.Size(19, 20)
        Me.lblPTotalList.TabIndex = 26
        Me.lblPTotalList.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 364)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Total list:"
        '
        'lblSTotalList
        '
        Me.lblSTotalList.AutoSize = True
        Me.lblSTotalList.BackColor = System.Drawing.Color.Transparent
        Me.lblSTotalList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSTotalList.ForeColor = System.Drawing.Color.Maroon
        Me.lblSTotalList.Location = New System.Drawing.Point(88, 713)
        Me.lblSTotalList.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSTotalList.Name = "lblSTotalList"
        Me.lblSTotalList.Size = New System.Drawing.Size(19, 20)
        Me.lblSTotalList.TabIndex = 28
        Me.lblSTotalList.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 713)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Total list:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(871, 76)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 20)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "From Purchased"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(911, 424)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 20)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "From Sales"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmbxSortP)
        Me.GroupBox1.Controls.Add(Me.rbtnAscP)
        Me.GroupBox1.Controls.Add(Me.rbtnDescP)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox1.Location = New System.Drawing.Point(470, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(402, 44)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sort by"
        '
        'cmbxSortP
        '
        Me.cmbxSortP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbxSortP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxSortP.FormattingEnabled = True
        Me.cmbxSortP.Items.AddRange(New Object() {"1-Item#", "2-RS#", "3-Description", "4-Quantity"})
        Me.cmbxSortP.Location = New System.Drawing.Point(7, 16)
        Me.cmbxSortP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbxSortP.Name = "cmbxSortP"
        Me.cmbxSortP.Size = New System.Drawing.Size(171, 24)
        Me.cmbxSortP.TabIndex = 2
        '
        'rbtnAscP
        '
        Me.rbtnAscP.AutoSize = True
        Me.rbtnAscP.Checked = True
        Me.rbtnAscP.ForeColor = System.Drawing.Color.Blue
        Me.rbtnAscP.Location = New System.Drawing.Point(185, 18)
        Me.rbtnAscP.Name = "rbtnAscP"
        Me.rbtnAscP.Size = New System.Drawing.Size(99, 20)
        Me.rbtnAscP.TabIndex = 1
        Me.rbtnAscP.TabStop = True
        Me.rbtnAscP.Text = "Ascending"
        Me.rbtnAscP.UseVisualStyleBackColor = True
        '
        'rbtnDescP
        '
        Me.rbtnDescP.AutoSize = True
        Me.rbtnDescP.ForeColor = System.Drawing.Color.Blue
        Me.rbtnDescP.Location = New System.Drawing.Point(287, 18)
        Me.rbtnDescP.Name = "rbtnDescP"
        Me.rbtnDescP.Size = New System.Drawing.Size(109, 20)
        Me.rbtnDescP.TabIndex = 0
        Me.rbtnDescP.Text = "Descending"
        Me.rbtnDescP.UseVisualStyleBackColor = True
        '
        'chkbxPurchased
        '
        Me.chkbxPurchased.AutoSize = True
        Me.chkbxPurchased.BackColor = System.Drawing.Color.Transparent
        Me.chkbxPurchased.Location = New System.Drawing.Point(966, 54)
        Me.chkbxPurchased.Name = "chkbxPurchased"
        Me.chkbxPurchased.Size = New System.Drawing.Size(45, 24)
        Me.chkbxPurchased.TabIndex = 32
        Me.chkbxPurchased.Text = "All"
        Me.chkbxPurchased.UseVisualStyleBackColor = False
        '
        'chkbxSales
        '
        Me.chkbxSales.AutoSize = True
        Me.chkbxSales.BackColor = System.Drawing.Color.Transparent
        Me.chkbxSales.Location = New System.Drawing.Point(958, 400)
        Me.chkbxSales.Name = "chkbxSales"
        Me.chkbxSales.Size = New System.Drawing.Size(45, 24)
        Me.chkbxSales.TabIndex = 33
        Me.chkbxSales.Text = "All"
        Me.chkbxSales.UseVisualStyleBackColor = False
        '
        'grpbxDateSales
        '
        Me.grpbxDateSales.BackColor = System.Drawing.Color.Transparent
        Me.grpbxDateSales.Controls.Add(Me.dtpEndS)
        Me.grpbxDateSales.Controls.Add(Me.dtpStartS)
        Me.grpbxDateSales.Controls.Add(Me.Label8)
        Me.grpbxDateSales.Controls.Add(Me.Label9)
        Me.grpbxDateSales.Controls.Add(Me.Label10)
        Me.grpbxDateSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxDateSales.Location = New System.Drawing.Point(251, 345)
        Me.grpbxDateSales.Name = "grpbxDateSales"
        Me.grpbxDateSales.Size = New System.Drawing.Size(752, 49)
        Me.grpbxDateSales.TabIndex = 24
        Me.grpbxDateSales.TabStop = False
        Me.grpbxDateSales.Text = "Date"
        '
        'dtpEndS
        '
        Me.dtpEndS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpEndS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEndS.Location = New System.Drawing.Point(458, 17)
        Me.dtpEndS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpEndS.Name = "dtpEndS"
        Me.dtpEndS.Size = New System.Drawing.Size(286, 26)
        Me.dtpEndS.TabIndex = 20
        '
        'dtpStartS
        '
        Me.dtpStartS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpStartS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartS.Location = New System.Drawing.Point(62, 17)
        Me.dtpStartS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpStartS.Name = "dtpStartS"
        Me.dtpStartS.Size = New System.Drawing.Size(286, 26)
        Me.dtpStartS.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(7, 22)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 20)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Start:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(404, 22)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 20)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "End:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(356, 22)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 20)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Date"
        '
        'btnSearchP
        '
        Me.btnSearchP.BackColor = System.Drawing.Color.White
        Me.btnSearchP.BackgroundImage = CType(resources.GetObject("btnSearchP.BackgroundImage"), System.Drawing.Image)
        Me.btnSearchP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchP.ForeColor = System.Drawing.Color.Transparent
        Me.btnSearchP.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.magnifier
        Me.btnSearchP.Location = New System.Drawing.Point(15, 63)
        Me.btnSearchP.Name = "btnSearchP"
        Me.btnSearchP.Size = New System.Drawing.Size(78, 34)
        Me.btnSearchP.TabIndex = 34
        Me.btnSearchP.Text = "Search"
        Me.btnSearchP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchP.UseVisualStyleBackColor = False
        '
        'btnSearchS
        '
        Me.btnSearchS.BackColor = System.Drawing.Color.White
        Me.btnSearchS.BackgroundImage = CType(resources.GetObject("btnSearchS.BackgroundImage"), System.Drawing.Image)
        Me.btnSearchS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchS.ForeColor = System.Drawing.Color.Transparent
        Me.btnSearchS.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.magnifier
        Me.btnSearchS.Location = New System.Drawing.Point(15, 410)
        Me.btnSearchS.Name = "btnSearchS"
        Me.btnSearchS.Size = New System.Drawing.Size(78, 34)
        Me.btnSearchS.TabIndex = 36
        Me.btnSearchS.Text = "Search"
        Me.btnSearchS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearchS.UseVisualStyleBackColor = False
        '
        'txtSearchS
        '
        Me.txtSearchS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchS.Location = New System.Drawing.Point(97, 414)
        Me.txtSearchS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSearchS.Name = "txtSearchS"
        Me.txtSearchS.Size = New System.Drawing.Size(342, 26)
        Me.txtSearchS.TabIndex = 35
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.magnifier
        Me.PictureBox2.Location = New System.Drawing.Point(444, 415)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmbxSortS)
        Me.GroupBox2.Controls.Add(Me.rbtnAscS)
        Me.GroupBox2.Controls.Add(Me.rbtnDescS)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox2.Location = New System.Drawing.Point(470, 396)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(402, 44)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sort by"
        '
        'cmbxSortS
        '
        Me.cmbxSortS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbxSortS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxSortS.FormattingEnabled = True
        Me.cmbxSortS.Items.AddRange(New Object() {"1-Item#", "2-DR#", "3-Description", "4-Quantity"})
        Me.cmbxSortS.Location = New System.Drawing.Point(7, 16)
        Me.cmbxSortS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbxSortS.Name = "cmbxSortS"
        Me.cmbxSortS.Size = New System.Drawing.Size(171, 24)
        Me.cmbxSortS.TabIndex = 2
        '
        'rbtnAscS
        '
        Me.rbtnAscS.AutoSize = True
        Me.rbtnAscS.Checked = True
        Me.rbtnAscS.ForeColor = System.Drawing.Color.Blue
        Me.rbtnAscS.Location = New System.Drawing.Point(185, 18)
        Me.rbtnAscS.Name = "rbtnAscS"
        Me.rbtnAscS.Size = New System.Drawing.Size(99, 20)
        Me.rbtnAscS.TabIndex = 1
        Me.rbtnAscS.TabStop = True
        Me.rbtnAscS.Text = "Ascending"
        Me.rbtnAscS.UseVisualStyleBackColor = True
        '
        'rbtnDescS
        '
        Me.rbtnDescS.AutoSize = True
        Me.rbtnDescS.ForeColor = System.Drawing.Color.Blue
        Me.rbtnDescS.Location = New System.Drawing.Point(287, 18)
        Me.rbtnDescS.Name = "rbtnDescS"
        Me.rbtnDescS.Size = New System.Drawing.Size(109, 20)
        Me.rbtnDescS.TabIndex = 0
        Me.rbtnDescS.Text = "Descending"
        Me.rbtnDescS.UseVisualStyleBackColor = True
        '
        'lblPOrigQuantity
        '
        Me.lblPOrigQuantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPOrigQuantity.Location = New System.Drawing.Point(613, 325)
        Me.lblPOrigQuantity.Name = "lblPOrigQuantity"
        Me.lblPOrigQuantity.Size = New System.Drawing.Size(133, 20)
        Me.lblPOrigQuantity.TabIndex = 39
        Me.lblPOrigQuantity.Text = "0"
        Me.lblPOrigQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSQuantity
        '
        Me.lblSQuantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSQuantity.Location = New System.Drawing.Point(630, 693)
        Me.lblSQuantity.Name = "lblSQuantity"
        Me.lblSQuantity.Size = New System.Drawing.Size(73, 20)
        Me.lblSQuantity.TabIndex = 40
        Me.lblSQuantity.Text = "0"
        Me.lblSQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPSelCount
        '
        Me.lblPSelCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPSelCount.Location = New System.Drawing.Point(878, 325)
        Me.lblPSelCount.Name = "lblPSelCount"
        Me.lblPSelCount.Size = New System.Drawing.Size(133, 20)
        Me.lblPSelCount.TabIndex = 41
        Me.lblPSelCount.Text = "0"
        Me.lblPSelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSSelCount
        '
        Me.lblSSelCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSSelCount.Location = New System.Drawing.Point(878, 693)
        Me.lblSSelCount.Name = "lblSSelCount"
        Me.lblSSelCount.Size = New System.Drawing.Size(133, 20)
        Me.lblSSelCount.TabIndex = 42
        Me.lblSSelCount.Text = "0"
        Me.lblSSelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmTransMon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1030, 737)
        Me.Controls.Add(Me.lblSSelCount)
        Me.Controls.Add(Me.lblPSelCount)
        Me.Controls.Add(Me.lblSQuantity)
        Me.Controls.Add(Me.lblPOrigQuantity)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnSearchS)
        Me.Controls.Add(Me.txtSearchS)
        Me.Controls.Add(Me.btnSearchP)
        Me.Controls.Add(Me.chkbxPurchased)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblSTotalList)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblPTotalList)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstvwItemsS)
        Me.Controls.Add(Me.grpbxDatePurchased)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtSearchP)
        Me.Controls.Add(Me.lstvwItemsP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chkbxSales)
        Me.Controls.Add(Me.grpbxDateSales)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimizeBox = False
        Me.Name = "frmTransMon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction Monitoring"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbxDatePurchased.ResumeLayout(False)
        Me.grpbxDatePurchased.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpbxDateSales.ResumeLayout(False)
        Me.grpbxDateSales.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstvwItemsP As System.Windows.Forms.ListView
    Friend WithEvents pId As System.Windows.Forms.ColumnHeader
    Friend WithEvents pItemNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents pDescription As System.Windows.Forms.ColumnHeader
    Friend WithEvents pVendor As System.Windows.Forms.ColumnHeader
    Friend WithEvents pQuantity As System.Windows.Forms.ColumnHeader
    Friend WithEvents pDateIn As System.Windows.Forms.ColumnHeader
    Friend WithEvents pRemarks As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSearchP As System.Windows.Forms.TextBox
    Friend WithEvents grpbxDatePurchased As System.Windows.Forms.GroupBox
    Friend WithEvents dtpEndP As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStartP As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstvwItemsS As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblPTotalList As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblSTotalList As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbxSortP As System.Windows.Forms.ComboBox
    Friend WithEvents rbtnAscP As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnDescP As System.Windows.Forms.RadioButton
    Friend WithEvents chkbxPurchased As System.Windows.Forms.CheckBox
    Friend WithEvents chkbxSales As System.Windows.Forms.CheckBox
    Friend WithEvents grpbxDateSales As System.Windows.Forms.GroupBox
    Friend WithEvents dtpEndS As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStartS As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnSearchP As System.Windows.Forms.Button
    Friend WithEvents btnSearchS As System.Windows.Forms.Button
    Friend WithEvents txtSearchS As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbxSortS As System.Windows.Forms.ComboBox
    Friend WithEvents rbtnAscS As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnDescS As System.Windows.Forms.RadioButton
    Friend WithEvents RSNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents pOrigQuantity As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblPOrigQuantity As System.Windows.Forms.Label
    Friend WithEvents lblSQuantity As System.Windows.Forms.Label
    Friend WithEvents lblPSelCount As System.Windows.Forms.Label
    Friend WithEvents lblSSelCount As System.Windows.Forms.Label
End Class
