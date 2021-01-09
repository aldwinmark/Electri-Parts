<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vwfrmAdmin
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
        Me.crptvwAdmin = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crptvwAdmin
        '
        Me.crptvwAdmin.ActiveViewIndex = -1
        Me.crptvwAdmin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.crptvwAdmin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crptvwAdmin.Location = New System.Drawing.Point(0, 0)
        Me.crptvwAdmin.Name = "crptvwAdmin"
        Me.crptvwAdmin.SelectionFormula = ""
        Me.crptvwAdmin.Size = New System.Drawing.Size(993, 541)
        Me.crptvwAdmin.TabIndex = 0
        Me.crptvwAdmin.ViewTimeSelectionFormula = ""
        '
        'vwfrmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 541)
        Me.Controls.Add(Me.crptvwAdmin)
        Me.Name = "vwfrmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crptvwAdmin As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
