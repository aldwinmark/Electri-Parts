<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintSales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintSales))
        Me.grpbxGrouping = New System.Windows.Forms.GroupBox
        Me.rbtnDate = New System.Windows.Forms.RadioButton
        Me.rbtnItemNo = New System.Windows.Forms.RadioButton
        Me.rbtnDR = New System.Windows.Forms.RadioButton
        Me.rbtnCustomer = New System.Windows.Forms.RadioButton
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnPrintPreview = New System.Windows.Forms.Button
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker
        Me.dtpStart = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.grpbxGrouping.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpbxGrouping
        '
        Me.grpbxGrouping.Controls.Add(Me.rbtnDate)
        Me.grpbxGrouping.Controls.Add(Me.rbtnItemNo)
        Me.grpbxGrouping.Controls.Add(Me.rbtnDR)
        Me.grpbxGrouping.Controls.Add(Me.rbtnCustomer)
        Me.grpbxGrouping.ForeColor = System.Drawing.Color.Red
        Me.grpbxGrouping.Location = New System.Drawing.Point(25, 133)
        Me.grpbxGrouping.Name = "grpbxGrouping"
        Me.grpbxGrouping.Size = New System.Drawing.Size(294, 116)
        Me.grpbxGrouping.TabIndex = 2
        Me.grpbxGrouping.TabStop = False
        Me.grpbxGrouping.Text = "Group by"
        '
        'rbtnDate
        '
        Me.rbtnDate.AutoSize = True
        Me.rbtnDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtnDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnDate.ForeColor = System.Drawing.Color.Black
        Me.rbtnDate.Location = New System.Drawing.Point(191, 68)
        Me.rbtnDate.Name = "rbtnDate"
        Me.rbtnDate.Size = New System.Drawing.Size(66, 24)
        Me.rbtnDate.TabIndex = 3
        Me.rbtnDate.Text = "Date"
        Me.rbtnDate.UseVisualStyleBackColor = True
        '
        'rbtnItemNo
        '
        Me.rbtnItemNo.AutoSize = True
        Me.rbtnItemNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtnItemNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnItemNo.ForeColor = System.Drawing.Color.Black
        Me.rbtnItemNo.Location = New System.Drawing.Point(191, 38)
        Me.rbtnItemNo.Name = "rbtnItemNo"
        Me.rbtnItemNo.Size = New System.Drawing.Size(78, 24)
        Me.rbtnItemNo.TabIndex = 2
        Me.rbtnItemNo.Text = "Item #"
        Me.rbtnItemNo.UseVisualStyleBackColor = True
        '
        'rbtnDR
        '
        Me.rbtnDR.AutoSize = True
        Me.rbtnDR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtnDR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnDR.ForeColor = System.Drawing.Color.Black
        Me.rbtnDR.Location = New System.Drawing.Point(15, 68)
        Me.rbtnDR.Name = "rbtnDR"
        Me.rbtnDR.Size = New System.Drawing.Size(68, 24)
        Me.rbtnDR.TabIndex = 1
        Me.rbtnDR.Text = "DR #"
        Me.rbtnDR.UseVisualStyleBackColor = True
        '
        'rbtnCustomer
        '
        Me.rbtnCustomer.AutoSize = True
        Me.rbtnCustomer.Checked = True
        Me.rbtnCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtnCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnCustomer.ForeColor = System.Drawing.Color.Black
        Me.rbtnCustomer.Location = New System.Drawing.Point(15, 38)
        Me.rbtnCustomer.Name = "rbtnCustomer"
        Me.rbtnCustomer.Size = New System.Drawing.Size(104, 24)
        Me.rbtnCustomer.TabIndex = 0
        Me.rbtnCustomer.TabStop = True
        Me.rbtnCustomer.Text = "Customer"
        Me.rbtnCustomer.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Red
        Me.btnCancel.Location = New System.Drawing.Point(230, 272)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 39)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnPrintPreview
        '
        Me.btnPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrintPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintPreview.Image = Global.Electri_Parts_DBMS.My.Resources.Resources.printer
        Me.btnPrintPreview.Location = New System.Drawing.Point(103, 272)
        Me.btnPrintPreview.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPrintPreview.Name = "btnPrintPreview"
        Me.btnPrintPreview.Size = New System.Drawing.Size(122, 39)
        Me.btnPrintPreview.TabIndex = 3
        Me.btnPrintPreview.Text = "&Print preview"
        Me.btnPrintPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPrintPreview.UseVisualStyleBackColor = True
        '
        'dtpEnd
        '
        Me.dtpEnd.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEnd.Location = New System.Drawing.Point(61, 74)
        Me.dtpEnd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(264, 22)
        Me.dtpEnd.TabIndex = 1
        '
        'dtpStart
        '
        Me.dtpStart.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStart.Location = New System.Drawing.Point(61, 28)
        Me.dtpStart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(264, 22)
        Me.dtpStart.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(13, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 18)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Start:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(13, 74)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 18)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "End:"
        '
        'frmPrintSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 328)
        Me.Controls.Add(Me.dtpEnd)
        Me.Controls.Add(Me.dtpStart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPrintPreview)
        Me.Controls.Add(Me.grpbxGrouping)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPrintSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Sales"
        Me.grpbxGrouping.ResumeLayout(False)
        Me.grpbxGrouping.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpbxGrouping As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnDate As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnItemNo As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnDR As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCustomer As System.Windows.Forms.RadioButton
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
