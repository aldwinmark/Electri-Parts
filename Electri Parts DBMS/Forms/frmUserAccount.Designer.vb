<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserAccount))
        Me.Label1 = New System.Windows.Forms.Label
        Me.lstvwUserAccount = New System.Windows.Forms.ListView
        Me.Id = New System.Windows.Forms.ColumnHeader
        Me.Username = New System.Windows.Forms.ColumnHeader
        Me.Password = New System.Windows.Forms.ColumnHeader
        Me.UserLevel = New System.Windows.Forms.ColumnHeader
        Me.CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UserMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblTotalNo = New System.Windows.Forms.Label
        Me.CMS.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "List of user account."
        '
        'lstvwUserAccount
        '
        Me.lstvwUserAccount.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Id, Me.Username, Me.Password, Me.UserLevel})
        Me.lstvwUserAccount.ContextMenuStrip = Me.CMS
        Me.lstvwUserAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lstvwUserAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstvwUserAccount.FullRowSelect = True
        Me.lstvwUserAccount.GridLines = True
        Me.lstvwUserAccount.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvwUserAccount.Location = New System.Drawing.Point(17, 39)
        Me.lstvwUserAccount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstvwUserAccount.MultiSelect = False
        Me.lstvwUserAccount.Name = "lstvwUserAccount"
        Me.lstvwUserAccount.Size = New System.Drawing.Size(377, 478)
        Me.lstvwUserAccount.TabIndex = 1
        Me.lstvwUserAccount.UseCompatibleStateImageBehavior = False
        Me.lstvwUserAccount.View = System.Windows.Forms.View.Details
        '
        'Id
        '
        Me.Id.Text = ""
        Me.Id.Width = 0
        '
        'Username
        '
        Me.Username.Text = "Username"
        Me.Username.Width = 153
        '
        'Password
        '
        Me.Password.Text = "Password"
        Me.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Password.Width = 0
        '
        'UserLevel
        '
        Me.UserLevel.Text = "Level"
        Me.UserLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.UserLevel.Width = 59
        '
        'CMS
        '
        Me.CMS.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserMenuToolStripMenuItem, Me.ToolStripSeparator1, Me.AddToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.RefreshToolStripMenuItem})
        Me.CMS.Name = "CMS"
        Me.CMS.Size = New System.Drawing.Size(163, 140)
        '
        'UserMenuToolStripMenuItem
        '
        Me.UserMenuToolStripMenuItem.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.user_silhouette
        Me.UserMenuToolStripMenuItem.Name = "UserMenuToolStripMenuItem"
        Me.UserMenuToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.UserMenuToolStripMenuItem.Text = "User Menu"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(159, 6)
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.AddToolStripMenuItem.Text = "&Add"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.DeleteToolStripMenuItem.Text = "&Delete"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.Refresh
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 522)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total no.:"
        '
        'lblTotalNo
        '
        Me.lblTotalNo.AutoSize = True
        Me.lblTotalNo.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalNo.ForeColor = System.Drawing.Color.Maroon
        Me.lblTotalNo.Location = New System.Drawing.Point(101, 522)
        Me.lblTotalNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalNo.Name = "lblTotalNo"
        Me.lblTotalNo.Size = New System.Drawing.Size(19, 20)
        Me.lblTotalNo.TabIndex = 3
        Me.lblTotalNo.Text = "0"
        '
        'frmUserAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(409, 545)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotalNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstvwUserAccount)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUserAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Account"
        Me.CMS.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstvwUserAccount As System.Windows.Forms.ListView
    Friend WithEvents Username As System.Windows.Forms.ColumnHeader
    Friend WithEvents Password As System.Windows.Forms.ColumnHeader
    Friend WithEvents UserLevel As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTotalNo As System.Windows.Forms.Label
    Friend WithEvents CMS As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents UserMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Id As System.Windows.Forms.ColumnHeader
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
