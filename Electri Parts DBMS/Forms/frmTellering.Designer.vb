<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTellering
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTellering))
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblDescription = New System.Windows.Forms.Label
        Me.lblItemNo = New System.Windows.Forms.Label
        Me.lblSalesPrice = New System.Windows.Forms.Label
        Me.lblSAP = New System.Windows.Forms.Label
        Me.txtQuantity = New System.Windows.Forms.TextBox
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
        Me.txtCustomer = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbxDescription = New System.Windows.Forms.ComboBox
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'dtpDate
        '
        Me.dtpDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpDate.Enabled = False
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Location = New System.Drawing.Point(113, 17)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(255, 22)
        Me.dtpDate.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(18, 61)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Sold To:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(19, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 18)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Date:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(643, 214)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 18)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = "Quantity:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(393, 59)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 18)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "Description:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(393, 20)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 18)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Item no:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(393, 132)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(143, 18)
        Me.Label15.TabIndex = 91
        Me.Label15.Text = "Sales agent price:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(393, 97)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 18)
        Me.Label13.TabIndex = 89
        Me.Label13.Text = "Sales Price:"
        '
        'lblDescription
        '
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.Color.Black
        Me.lblDescription.Location = New System.Drawing.Point(559, 58)
        Me.lblDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(287, 20)
        Me.lblDescription.TabIndex = 95
        '
        'lblItemNo
        '
        Me.lblItemNo.BackColor = System.Drawing.Color.Transparent
        Me.lblItemNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblItemNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemNo.ForeColor = System.Drawing.Color.Black
        Me.lblItemNo.Location = New System.Drawing.Point(559, 19)
        Me.lblItemNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblItemNo.Name = "lblItemNo"
        Me.lblItemNo.Size = New System.Drawing.Size(287, 20)
        Me.lblItemNo.TabIndex = 96
        '
        'lblSalesPrice
        '
        Me.lblSalesPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblSalesPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSalesPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesPrice.ForeColor = System.Drawing.Color.Red
        Me.lblSalesPrice.Location = New System.Drawing.Point(559, 98)
        Me.lblSalesPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSalesPrice.Name = "lblSalesPrice"
        Me.lblSalesPrice.Size = New System.Drawing.Size(287, 20)
        Me.lblSalesPrice.TabIndex = 97
        '
        'lblSAP
        '
        Me.lblSAP.BackColor = System.Drawing.Color.Transparent
        Me.lblSAP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSAP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSAP.ForeColor = System.Drawing.Color.Red
        Me.lblSAP.Location = New System.Drawing.Point(559, 132)
        Me.lblSAP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSAP.Name = "lblSAP"
        Me.lblSAP.Size = New System.Drawing.Size(287, 20)
        Me.lblSAP.TabIndex = 98
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtQuantity.Location = New System.Drawing.Point(716, 213)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(130, 24)
        Me.txtQuantity.TabIndex = 4
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lstvwItems
        '
        Me.lstvwItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ItemId, Me.ItemNo, Me.Description, Me.Quantity, Me.TotalQty, Me.SalesPrice, Me.SAP, Me.Commision, Me.UnitCost, Me.DRNo, Me.Customer})
        Me.lstvwItems.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwItems.FullRowSelect = True
        Me.lstvwItems.GridLines = True
        Me.lstvwItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwItems.Location = New System.Drawing.Point(22, 240)
        Me.lstvwItems.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstvwItems.Name = "lstvwItems"
        Me.lstvwItems.Size = New System.Drawing.Size(825, 319)
        Me.lstvwItems.TabIndex = 5
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
        Me.ItemNo.Width = 76
        '
        'Description
        '
        Me.Description.DisplayIndex = 4
        Me.Description.Text = "Description"
        Me.Description.Width = 268
        '
        'Quantity
        '
        Me.Quantity.DisplayIndex = 5
        Me.Quantity.Text = "Quantity"
        Me.Quantity.Width = 81
        '
        'TotalQty
        '
        Me.TotalQty.DisplayIndex = 6
        Me.TotalQty.Text = "Total QTY"
        Me.TotalQty.Width = 0
        '
        'SalesPrice
        '
        Me.SalesPrice.DisplayIndex = 7
        Me.SalesPrice.Text = "Sales Price"
        Me.SalesPrice.Width = 104
        '
        'SAP
        '
        Me.SAP.DisplayIndex = 8
        Me.SAP.Text = "SAP"
        Me.SAP.Width = 0
        '
        'Commision
        '
        Me.Commision.DisplayIndex = 9
        Me.Commision.Text = "Commision"
        Me.Commision.Width = 0
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
        Me.DRNo.Width = 0
        '
        'Customer
        '
        Me.Customer.DisplayIndex = 1
        Me.Customer.Text = "Customer"
        Me.Customer.Width = 0
        '
        'txtCustomer
        '
        Me.txtCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomer.Location = New System.Drawing.Point(113, 56)
        Me.txtCustomer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(255, 24)
        Me.txtCustomer.TabIndex = 1
        Me.txtCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(19, 132)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 18)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Invoice #:"
        '
        'txtAddress
        '
        Me.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAddress.Location = New System.Drawing.Point(113, 94)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(255, 24)
        Me.txtAddress.TabIndex = 2
        Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(18, 99)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 18)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "Address:"
        '
        'cmbxDescription
        '
        Me.cmbxDescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbxDescription.DropDownHeight = 150
        Me.cmbxDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbxDescription.FormattingEnabled = True
        Me.cmbxDescription.ItemHeight = 18
        Me.cmbxDescription.Location = New System.Drawing.Point(22, 211)
        Me.cmbxDescription.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbxDescription.MaxDropDownItems = 10
        Me.cmbxDescription.MaxLength = 200
        Me.cmbxDescription.Name = "cmbxDescription"
        Me.cmbxDescription.Size = New System.Drawing.Size(613, 26)
        Me.cmbxDescription.TabIndex = 3
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Enabled = False
        Me.txtInvoiceNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtInvoiceNo.Location = New System.Drawing.Point(113, 130)
        Me.txtInvoiceNo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(255, 24)
        Me.txtInvoiceNo.TabIndex = 108
        Me.txtInvoiceNo.TabStop = False
        Me.txtInvoiceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmTellering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(868, 586)
        Me.Controls.Add(Me.txtInvoiceNo)
        Me.Controls.Add(Me.cmbxDescription)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCustomer)
        Me.Controls.Add(Me.lstvwItems)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.lblSAP)
        Me.Controls.Add(Me.lblSalesPrice)
        Me.Controls.Add(Me.lblItemNo)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTellering"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tellering"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblItemNo As System.Windows.Forms.Label
    Friend WithEvents lblSalesPrice As System.Windows.Forms.Label
    Friend WithEvents lblSAP As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents lstvwItems As System.Windows.Forms.ListView
    Friend WithEvents ItemId As System.Windows.Forms.ColumnHeader
    Friend WithEvents ItemNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Description As System.Windows.Forms.ColumnHeader
    Friend WithEvents Quantity As System.Windows.Forms.ColumnHeader
    Friend WithEvents TotalQty As System.Windows.Forms.ColumnHeader
    Friend WithEvents SalesPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents SAP As System.Windows.Forms.ColumnHeader
    Friend WithEvents Commision As System.Windows.Forms.ColumnHeader
    Friend WithEvents UnitCost As System.Windows.Forms.ColumnHeader
    Friend WithEvents DRNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Customer As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtCustomer As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbxDescription As System.Windows.Forms.ComboBox
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
End Class
