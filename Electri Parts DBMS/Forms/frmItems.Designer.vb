<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItems))
        Me.lblTotalList = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lstvwItems = New System.Windows.Forms.ListView
        Me.Id = New System.Windows.Forms.ColumnHeader
        Me.ItemNo = New System.Windows.Forms.ColumnHeader
        Me.Description = New System.Windows.Forms.ColumnHeader
        Me.UnitCost = New System.Windows.Forms.ColumnHeader
        Me.SalesPrice = New System.Windows.Forms.ColumnHeader
        Me.SAP = New System.Windows.Forms.ColumnHeader
        Me.CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbxSort = New System.Windows.Forms.ComboBox
        Me.rbtnAsc = New System.Windows.Forms.RadioButton
        Me.rbtnDesc = New System.Windows.Forms.RadioButton
        Me.btnSearch = New System.Windows.Forms.Button
        Me.CMS.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTotalList
        '
        Me.lblTotalList.AutoSize = True
        Me.lblTotalList.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalList.ForeColor = System.Drawing.Color.Maroon
        Me.lblTotalList.Location = New System.Drawing.Point(104, 546)
        Me.lblTotalList.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalList.Name = "lblTotalList"
        Me.lblTotalList.Size = New System.Drawing.Size(19, 20)
        Me.lblTotalList.TabIndex = 7
        Me.lblTotalList.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 546)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Total list:"
        '
        'lstvwItems
        '
        Me.lstvwItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Id, Me.ItemNo, Me.Description, Me.UnitCost, Me.SalesPrice, Me.SAP})
        Me.lstvwItems.ContextMenuStrip = Me.CMS
        Me.lstvwItems.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwItems.FullRowSelect = True
        Me.lstvwItems.GridLines = True
        Me.lstvwItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwItems.Location = New System.Drawing.Point(20, 102)
        Me.lstvwItems.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstvwItems.MultiSelect = False
        Me.lstvwItems.Name = "lstvwItems"
        Me.lstvwItems.Size = New System.Drawing.Size(886, 437)
        Me.lstvwItems.TabIndex = 1
        Me.lstvwItems.UseCompatibleStateImageBehavior = False
        Me.lstvwItems.View = System.Windows.Forms.View.Details
        '
        'Id
        '
        Me.Id.Text = ""
        Me.Id.Width = 0
        '
        'ItemNo
        '
        Me.ItemNo.Text = "Item no."
        Me.ItemNo.Width = 103
        '
        'Description
        '
        Me.Description.Text = "Description"
        Me.Description.Width = 351
        '
        'UnitCost
        '
        Me.UnitCost.Text = "Unit cost"
        Me.UnitCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.UnitCost.Width = 132
        '
        'SalesPrice
        '
        Me.SalesPrice.Text = "Sales price"
        Me.SalesPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SalesPrice.Width = 111
        '
        'SAP
        '
        Me.SAP.Text = "Sales Agent Price"
        Me.SAP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SAP.Width = 159
        '
        'CMS
        '
        Me.CMS.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ToolStripSeparator1, Me.AddToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.RefreshToolStripMenuItem})
        Me.CMS.Name = "CMS"
        Me.CMS.Size = New System.Drawing.Size(164, 140)
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.box
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.MenuToolStripMenuItem.Text = "Item Menu"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(160, 6)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.AddToolStripMenuItem.Text = "&Add"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.DeleteToolStripMenuItem.Text = "&Delete"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.Refresh
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(163, 26)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 77)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Master List of Items"
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(422, 71)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(454, 26)
        Me.txtSearch.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.magnifier
        Me.PictureBox1.Location = New System.Drawing.Point(881, 72)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmbxSort)
        Me.GroupBox1.Controls.Add(Me.rbtnAsc)
        Me.GroupBox1.Controls.Add(Me.rbtnDesc)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox1.Location = New System.Drawing.Point(19, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 50)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sort by"
        '
        'cmbxSort
        '
        Me.cmbxSort.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbxSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxSort.FormattingEnabled = True
        Me.cmbxSort.Items.AddRange(New Object() {"1-Item#", "2-Description", "3-Unit Cost", "4-Sales Price", "5-Sales Agent Price"})
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
        Me.rbtnAsc.ForeColor = System.Drawing.Color.Blue
        Me.rbtnAsc.Location = New System.Drawing.Point(207, 20)
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
        Me.rbtnDesc.ForeColor = System.Drawing.Color.Blue
        Me.rbtnDesc.Location = New System.Drawing.Point(312, 20)
        Me.rbtnDesc.Name = "rbtnDesc"
        Me.rbtnDesc.Size = New System.Drawing.Size(109, 20)
        Me.rbtnDesc.TabIndex = 0
        Me.rbtnDesc.Text = "Descending"
        Me.rbtnDesc.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Transparent
        Me.btnSearch.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.magnifier
        Me.btnSearch.Location = New System.Drawing.Point(317, 66)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(102, 34)
        Me.btnSearch.TabIndex = 36
        Me.btnSearch.Text = "Search"
        Me.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'frmItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(927, 574)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblTotalList)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstvwItems)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmItems"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Items"
        Me.CMS.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTotalList As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstvwItems As System.Windows.Forms.ListView
    Friend WithEvents ItemNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Description As System.Windows.Forms.ColumnHeader
    Friend WithEvents UnitCost As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SalesPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents CMS As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Id As System.Windows.Forms.ColumnHeader
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SAP As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnAsc As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnDesc As System.Windows.Forms.RadioButton
    Friend WithEvents cmbxSort As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
End Class
