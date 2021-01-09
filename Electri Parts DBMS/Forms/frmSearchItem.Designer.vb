<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchItem))
        Me.lstvwItems = New System.Windows.Forms.ListView
        Me.ItemNo = New System.Windows.Forms.ColumnHeader
        Me.Description = New System.Windows.Forms.ColumnHeader
        Me.Quantity = New System.Windows.Forms.ColumnHeader
        Me.SP = New System.Windows.Forms.ColumnHeader
        Me.ItemDate = New System.Windows.Forms.ColumnHeader
        Me.ItemId = New System.Windows.Forms.ColumnHeader
        Me.SAP = New System.Windows.Forms.ColumnHeader
        Me.UnitCost = New System.Windows.Forms.ColumnHeader
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbtnNonzero = New System.Windows.Forms.RadioButton
        Me.rbtnZero = New System.Windows.Forms.RadioButton
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstvwItems
        '
        Me.lstvwItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ItemNo, Me.Description, Me.Quantity, Me.SP, Me.ItemDate, Me.ItemId, Me.SAP, Me.UnitCost})
        Me.lstvwItems.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwItems.FullRowSelect = True
        Me.lstvwItems.GridLines = True
        Me.lstvwItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwItems.Location = New System.Drawing.Point(13, 34)
        Me.lstvwItems.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstvwItems.MultiSelect = False
        Me.lstvwItems.Name = "lstvwItems"
        Me.lstvwItems.Size = New System.Drawing.Size(797, 227)
        Me.lstvwItems.TabIndex = 1
        Me.lstvwItems.UseCompatibleStateImageBehavior = False
        Me.lstvwItems.View = System.Windows.Forms.View.Details
        '
        'ItemNo
        '
        Me.ItemNo.Text = "Item #"
        Me.ItemNo.Width = 69
        '
        'Description
        '
        Me.Description.Text = "Description"
        Me.Description.Width = 366
        '
        'Quantity
        '
        Me.Quantity.Text = "Qty"
        Me.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Quantity.Width = 46
        '
        'SP
        '
        Me.SP.Text = "SP"
        Me.SP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SP.Width = 79
        '
        'ItemDate
        '
        Me.ItemDate.Text = "Date"
        Me.ItemDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ItemDate.Width = 210
        '
        'ItemId
        '
        Me.ItemId.Text = "ItemId"
        Me.ItemId.Width = 0
        '
        'SAP
        '
        Me.SAP.Text = "SAP"
        Me.SAP.Width = 0
        '
        'UnitCost
        '
        Me.UnitCost.Text = "UnitCost"
        Me.UnitCost.Width = 0
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(13, 8)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(604, 26)
        Me.txtSearch.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.magnifier
        Me.PictureBox1.Location = New System.Drawing.Point(625, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnZero)
        Me.GroupBox1.Controls.Add(Me.rbtnNonzero)
        Me.GroupBox1.Location = New System.Drawing.Point(658, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(153, 35)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'rbtnNonzero
        '
        Me.rbtnNonzero.AutoSize = True
        Me.rbtnNonzero.Checked = True
        Me.rbtnNonzero.Location = New System.Drawing.Point(7, 12)
        Me.rbtnNonzero.Name = "rbtnNonzero"
        Me.rbtnNonzero.Size = New System.Drawing.Size(66, 17)
        Me.rbtnNonzero.TabIndex = 0
        Me.rbtnNonzero.TabStop = True
        Me.rbtnNonzero.Text = "non-zero"
        Me.rbtnNonzero.UseVisualStyleBackColor = True
        '
        'rbtnZero
        '
        Me.rbtnZero.AutoSize = True
        Me.rbtnZero.Location = New System.Drawing.Point(79, 12)
        Me.rbtnZero.Name = "rbtnZero"
        Me.rbtnZero.Size = New System.Drawing.Size(45, 17)
        Me.rbtnZero.TabIndex = 1
        Me.rbtnZero.Text = "zero"
        Me.rbtnZero.UseVisualStyleBackColor = True
        '
        'frmSearchItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 267)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lstvwItems)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSearchItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Item"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstvwItems As System.Windows.Forms.ListView
    Friend WithEvents ItemNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Description As System.Windows.Forms.ColumnHeader
    Friend WithEvents ItemDate As System.Windows.Forms.ColumnHeader
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Quantity As System.Windows.Forms.ColumnHeader
    Friend WithEvents ItemId As System.Windows.Forms.ColumnHeader
    Friend WithEvents SP As System.Windows.Forms.ColumnHeader
    Friend WithEvents SAP As System.Windows.Forms.ColumnHeader
    Friend WithEvents UnitCost As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnZero As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnNonzero As System.Windows.Forms.RadioButton
End Class
