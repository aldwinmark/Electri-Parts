<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.SystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PurchasedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MonitoringToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalesByToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ItemDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalesSummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PurchasedByToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ItemMasterListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MasterDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VendorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UserAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatuslbl = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatuslblUsername = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatuslblLevel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatuslblDate = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusUserId = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblBranchName = New System.Windows.Forms.ToolStripStatusLabel
        Me.tmNow = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.SkyBlue
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SystemToolStripMenuItem, Me.TransactionToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.MasterDataToolStripMenuItem, Me.MaintenanceToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(987, 29)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip"
        '
        'SystemToolStripMenuItem
        '
        Me.SystemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.SystemToolStripMenuItem.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.monitor
        Me.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem"
        Me.SystemToolStripMenuItem.Size = New System.Drawing.Size(93, 25)
        Me.SystemToolStripMenuItem.Text = "&System"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.LogoutToolStripMenuItem.Text = "&Log-out"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(140, 26)
        Me.QuitToolStripMenuItem.Text = "&Quit"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesToolStripMenuItem, Me.PurchasedToolStripMenuItem, Me.MonitoringToolStripMenuItem1})
        Me.TransactionToolStripMenuItem.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.application_side_contract
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(126, 25)
        Me.TransactionToolStripMenuItem.Text = "&Transaction"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.SalesToolStripMenuItem.Text = "&Sales"
        '
        'PurchasedToolStripMenuItem
        '
        Me.PurchasedToolStripMenuItem.Name = "PurchasedToolStripMenuItem"
        Me.PurchasedToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.PurchasedToolStripMenuItem.Text = "&Purchased"
        '
        'MonitoringToolStripMenuItem1
        '
        Me.MonitoringToolStripMenuItem1.Name = "MonitoringToolStripMenuItem1"
        Me.MonitoringToolStripMenuItem1.Size = New System.Drawing.Size(167, 26)
        Me.MonitoringToolStripMenuItem1.Text = "Monitoring"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesByToolStripMenuItem, Me.PurchasedByToolStripMenuItem, Me.ItemMasterListToolStripMenuItem, Me.InventoryToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.report
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(96, 25)
        Me.ReportsToolStripMenuItem.Text = "&Reports"
        '
        'SalesByToolStripMenuItem
        '
        Me.SalesByToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemDetailsToolStripMenuItem, Me.SalesSummaryToolStripMenuItem})
        Me.SalesByToolStripMenuItem.Name = "SalesByToolStripMenuItem"
        Me.SalesByToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.SalesByToolStripMenuItem.Text = "Sales"
        '
        'ItemDetailsToolStripMenuItem
        '
        Me.ItemDetailsToolStripMenuItem.Name = "ItemDetailsToolStripMenuItem"
        Me.ItemDetailsToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.ItemDetailsToolStripMenuItem.Text = "Item Details"
        '
        'SalesSummaryToolStripMenuItem
        '
        Me.SalesSummaryToolStripMenuItem.Name = "SalesSummaryToolStripMenuItem"
        Me.SalesSummaryToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.SalesSummaryToolStripMenuItem.Text = "Sales Summary"
        '
        'PurchasedByToolStripMenuItem
        '
        Me.PurchasedByToolStripMenuItem.Name = "PurchasedByToolStripMenuItem"
        Me.PurchasedByToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.PurchasedByToolStripMenuItem.Text = "Purchased by"
        '
        'ItemMasterListToolStripMenuItem
        '
        Me.ItemMasterListToolStripMenuItem.Name = "ItemMasterListToolStripMenuItem"
        Me.ItemMasterListToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.ItemMasterListToolStripMenuItem.Text = "Item Master List"
        '
        'InventoryToolStripMenuItem
        '
        Me.InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        Me.InventoryToolStripMenuItem.Size = New System.Drawing.Size(201, 26)
        Me.InventoryToolStripMenuItem.Text = "Inventory"
        '
        'MasterDataToolStripMenuItem
        '
        Me.MasterDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemsToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.VendorToolStripMenuItem})
        Me.MasterDataToolStripMenuItem.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.page_white_database
        Me.MasterDataToolStripMenuItem.Name = "MasterDataToolStripMenuItem"
        Me.MasterDataToolStripMenuItem.Size = New System.Drawing.Size(130, 25)
        Me.MasterDataToolStripMenuItem.Text = "Master Data"
        '
        'ItemsToolStripMenuItem
        '
        Me.ItemsToolStripMenuItem.Name = "ItemsToolStripMenuItem"
        Me.ItemsToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.ItemsToolStripMenuItem.Text = "&Items"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.CustomerToolStripMenuItem.Text = "&Customer"
        '
        'VendorToolStripMenuItem
        '
        Me.VendorToolStripMenuItem.Name = "VendorToolStripMenuItem"
        Me.VendorToolStripMenuItem.Size = New System.Drawing.Size(153, 26)
        Me.VendorToolStripMenuItem.Text = "&Vendor"
        '
        'MaintenanceToolStripMenuItem
        '
        Me.MaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserAccountToolStripMenuItem, Me.DatabaseToolStripMenuItem})
        Me.MaintenanceToolStripMenuItem.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.hammer_screwdriver
        Me.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        Me.MaintenanceToolStripMenuItem.Size = New System.Drawing.Size(138, 25)
        Me.MaintenanceToolStripMenuItem.Text = "&Maintenance"
        '
        'UserAccountToolStripMenuItem
        '
        Me.UserAccountToolStripMenuItem.Name = "UserAccountToolStripMenuItem"
        Me.UserAccountToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.UserAccountToolStripMenuItem.Text = "&User account"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackupToolStripMenuItem, Me.RestoreToolStripMenuItem})
        Me.DatabaseToolStripMenuItem.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.database
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.DatabaseToolStripMenuItem.Text = "&Database"
        '
        'BackupToolStripMenuItem
        '
        Me.BackupToolStripMenuItem.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.compress
        Me.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        Me.BackupToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.BackupToolStripMenuItem.Text = "Back-up"
        '
        'RestoreToolStripMenuItem
        '
        Me.RestoreToolStripMenuItem.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.databases
        Me.RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        Me.RestoreToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.RestoreToolStripMenuItem.Text = "Restore"
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.Color.LightSkyBlue
        Me.StatusStrip.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatuslbl, Me.ToolStripStatuslblUsername, Me.ToolStripStatusLabel1, Me.ToolStripStatuslblLevel, Me.ToolStripStatusLabel2, Me.ToolStripStatuslblDate, Me.ToolStripStatusUserId, Me.ToolStripStatusLabel3, Me.lblBranchName})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 581)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(987, 22)
        Me.StatusStrip.TabIndex = 1
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ToolStripStatuslbl
        '
        Me.ToolStripStatuslbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripStatuslbl.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.user_silhouette
        Me.ToolStripStatuslbl.Name = "ToolStripStatuslbl"
        Me.ToolStripStatuslbl.Size = New System.Drawing.Size(89, 17)
        Me.ToolStripStatuslbl.Text = "Username:"
        '
        'ToolStripStatuslblUsername
        '
        Me.ToolStripStatuslblUsername.Name = "ToolStripStatuslblUsername"
        Me.ToolStripStatuslblUsername.Size = New System.Drawing.Size(63, 17)
        Me.ToolStripStatuslblUsername.Text = "-----------"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ToolStripStatusLabel1.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.application_key
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(60, 17)
        Me.ToolStripStatusLabel1.Text = "Level:"
        '
        'ToolStripStatuslblLevel
        '
        Me.ToolStripStatuslblLevel.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatuslblLevel.Name = "ToolStripStatuslblLevel"
        Me.ToolStripStatuslblLevel.Size = New System.Drawing.Size(38, 17)
        Me.ToolStripStatuslblLevel.Text = "------"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.alarm
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel2.Text = "Date and Time:"
        Me.ToolStripStatusLabel2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripStatuslblDate
        '
        Me.ToolStripStatuslblDate.Name = "ToolStripStatuslblDate"
        Me.ToolStripStatuslblDate.Size = New System.Drawing.Size(86, 17)
        Me.ToolStripStatuslblDate.Text = "MM-dd-yyyy"
        '
        'ToolStripStatusUserId
        '
        Me.ToolStripStatusUserId.Name = "ToolStripStatusUserId"
        Me.ToolStripStatusUserId.Size = New System.Drawing.Size(33, 17)
        Me.ToolStripStatusUserId.Text = "-----"
        Me.ToolStripStatusUserId.Visible = False
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(92, 17)
        Me.ToolStripStatusLabel3.Text = "Branch name:"
        '
        'lblBranchName
        '
        Me.lblBranchName.Name = "lblBranchName"
        Me.lblBranchName.Size = New System.Drawing.Size(68, 17)
        Me.lblBranchName.Text = "------------"
        '
        'tmNow
        '
        Me.tmNow.Enabled = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(987, 603)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents SystemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchasedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesByToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatuslbl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatuslblUsername As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatuslblLevel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatuslblDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tmNow As System.Windows.Forms.Timer
    Friend WithEvents MasterDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusUserId As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents VendorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchasedByToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemMasterListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblBranchName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonitoringToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesSummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
