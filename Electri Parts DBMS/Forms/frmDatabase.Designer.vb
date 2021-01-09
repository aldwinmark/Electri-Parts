<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatabase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatabase))
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnPath = New System.Windows.Forms.Button
        Me.SFDDatabase = New System.Windows.Forms.SaveFileDialog
        Me.OFDDatabase = New System.Windows.Forms.OpenFileDialog
        Me.txtDBPath = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnRestore = New System.Windows.Forms.Button
        Me.btnBackup = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Red
        Me.btnCancel.Location = New System.Drawing.Point(368, 116)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(82, 46)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnPath
        '
        Me.btnPath.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPath.Location = New System.Drawing.Point(411, 12)
        Me.btnPath.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPath.Name = "btnPath"
        Me.btnPath.Size = New System.Drawing.Size(39, 25)
        Me.btnPath.TabIndex = 0
        Me.btnPath.Text = "......."
        Me.btnPath.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPath.UseVisualStyleBackColor = True
        '
        'txtDBPath
        '
        Me.txtDBPath.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtDBPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDBPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDBPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDBPath.Location = New System.Drawing.Point(16, 38)
        Me.txtDBPath.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDBPath.Multiline = True
        Me.txtDBPath.Name = "txtDBPath"
        Me.txtDBPath.ReadOnly = True
        Me.txtDBPath.Size = New System.Drawing.Size(434, 68)
        Me.txtDBPath.TabIndex = 9
        Me.txtDBPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 18)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Path of file to restore\back-up"
        '
        'btnRestore
        '
        Me.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestore.Enabled = False
        Me.btnRestore.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestore.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.databases
        Me.btnRestore.Location = New System.Drawing.Point(223, 116)
        Me.btnRestore.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(137, 46)
        Me.btnRestore.TabIndex = 12
        Me.btnRestore.Text = "Start restore"
        Me.btnRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRestore.UseVisualStyleBackColor = True
        Me.btnRestore.Visible = False
        '
        'btnBackup
        '
        Me.btnBackup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackup.Enabled = False
        Me.btnBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.compress
        Me.btnBackup.Location = New System.Drawing.Point(223, 116)
        Me.btnBackup.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(137, 46)
        Me.btnBackup.TabIndex = 1
        Me.btnBackup.Text = "Start Back up"
        Me.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBackup.UseVisualStyleBackColor = True
        Me.btnBackup.Visible = False
        '
        'frmDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(463, 178)
        Me.Controls.Add(Me.btnRestore)
        Me.Controls.Add(Me.btnBackup)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDBPath)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPath)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPath As System.Windows.Forms.Button
    Friend WithEvents SFDDatabase As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OFDDatabase As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtDBPath As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents btnRestore As System.Windows.Forms.Button
End Class
