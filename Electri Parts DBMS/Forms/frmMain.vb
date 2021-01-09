Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmMain

    'Created by Aldwin Mark F. Solis
    'Date: July 2 2010
    'Form: Main Form 

#Region "Variable Declaration"

#End Region

#Region "Functions"

#End Region

#Region "Loading List"

#End Region

#Region "Reports"

#End Region

    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to quit the application?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        frmLogIn.ShowDialog()
        frmLogIn.txtUsername.Focus()
        'Me.tmNow.Start()
        Me.ToolStripStatuslblDate.Text = Date.Now
    End Sub

    Private Sub tmNow_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmNow.Tick
        Me.ToolStripStatuslblDate.Text = Date.Now
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to log-out?", "Log-out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            frmLogIn.ShowDialog()
            frmLogIn.txtUsername.Focus()
        End If
    End Sub

    Private Sub UserAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserAccountToolStripMenuItem.Click
        frmUserAccount.ShowDialog()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerToolStripMenuItem.Click
        frmCustomer.ShowDialog()
    End Sub

    Private Sub ItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemsToolStripMenuItem.Click
        frmItems.ShowDialog()
    End Sub

    Private Sub PurchaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesToolStripMenuItem.Click
        frmSales.ShowDialog()
    End Sub

    Private Sub InventoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchasedToolStripMenuItem.Click
        frmPurchased.ShowDialog()
    End Sub

    Private Sub VendorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendorToolStripMenuItem.Click
        frmVendor.ShowDialog()
    End Sub

    Private Sub PurchasedByToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchasedByToolStripMenuItem.Click
        frmPrintPurchased.ShowDialog()
    End Sub

    Private Sub ItemMasterListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemMasterListToolStripMenuItem.Click

        Dim Branch As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Username As CrystalDecisions.CrystalReports.Engine.TextObject

        'Dim crSections As Sections
        'Dim crSection As Section
        'Dim crReportObjects As ReportObjects
        'Dim crReportObject As ReportObject
        'Dim myTable As CrystalDecisions.CrystalReports.Engine.Table
        'Dim myLogin As CrystalDecisions.Shared.TableLogOnInfo
        'Dim crSubreportObject As SubreportObject
        'Dim crSubreportDocument As ReportDocument
        'Dim crDatabase As Database
        'Dim crTables As Tables
        'Dim aTable As Table
        'Dim crTableLogOnInfo As TableLogOnInfo

        Dim repDoc As New ReportDocument()

        If Me.ToolStripStatuslblLevel.Text = "1" Then
            repDoc = New Purchased
        Else
            repDoc = New UPurchased
        End If

        If Me.ToolStripStatuslblLevel.Text = "1" Then
            repDoc = New MasterListItems
        Else
            repDoc = New UMasterListItems
        End If

        Branch = repDoc.ReportDefinition.ReportObjects.Item("txtBranch")
        Username = repDoc.ReportDefinition.ReportObjects.Item("txtUsername")

        Username.Text = Me.ToolStripStatuslblUsername.Text
        Branch.Text = Me.lblBranchName.Text

        'For Each myTable In repDoc.Database.Tables
        '    myLogin = myTable.LogOnInfo
        '    'myLogin.ConnectionInfo.ServerName = GetcrptDBPath() & "\ElectriPartsDB.mdb"
        '    myLogin.ConnectionInfo.DatabaseName = GetcrptDBPath() & "\ElectriPartsDB.mdb"
        '    myTable.ApplyLogOnInfo(myLogin)
        'Next

        'crSections = repDoc.ReportDefinition.Sections
        ''loop through all the sections to find all the report objects
        'For Each crSection In crSections
        '    crReportObjects = crSection.ReportObjects
        '    'loop through all the report objects in there to find all subreports 
        '    For Each crReportObject In crReportObjects
        '        If crReportObject.Kind = ReportObjectKind.SubreportObject Then
        '            crSubreportObject = CType(crReportObject, SubreportObject)
        '            'open the subreport object and logon as for the general report
        '            crSubreportDocument = crSubreportObject.OpenSubreport(crSubreportObject.SubreportName)
        '            crDatabase = crSubreportDocument.Database
        '            crTables = crDatabase.Tables
        '            For Each aTable In crTables
        '                crTableLogOnInfo = aTable.LogOnInfo
        '                'crTableLogOnInfo.ConnectionInfo.UserID = "Admin"
        '                'crTableLogOnInfo.ConnectionInfo.Password = ""
        '                aTable.ApplyLogOnInfo(crTableLogOnInfo)
        '            Next
        '        End If
        '    Next
        'Next
        vwfrmAdmin.crptvwAdmin.ReportSource = repDoc
        vwfrmAdmin.crptvwAdmin.Refresh()
        vwfrmAdmin.ShowDialog()

    End Sub

    Private Sub BackupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupToolStripMenuItem.Click
        With frmDatabase
            .btnBackup.Visible = True
            .btnRestore.Visible = False
            .ShowDialog()
        End With
    End Sub

    Private Sub RestoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoreToolStripMenuItem.Click
        With frmDatabase
            .btnBackup.Visible = False
            .btnRestore.Visible = True
            .ShowDialog()
        End With
    End Sub

    Private Sub MonitoringToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonitoringToolStripMenuItem1.Click
        frmTransMon.ShowDialog()
    End Sub

    Private Sub SalesSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesSummaryToolStripMenuItem.Click
        frmPrintSales.ShowDialog()
    End Sub

    Private Sub ItemDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemDetailsToolStripMenuItem.Click
        frmPrintSalesInd.ShowDialog()
    End Sub

    Private Sub InventoryToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventoryToolStripMenuItem.Click
        Dim DateStart As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim DateEnd As CrystalDecisions.CrystalReports.Engine.TextObject

        Dim Branch As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Username As CrystalDecisions.CrystalReports.Engine.TextObject

        'Dim crSections As Sections
        'Dim crSection As Section
        'Dim crReportObjects As ReportObjects
        'Dim crReportObject As ReportObject
        'Dim myTable As CrystalDecisions.CrystalReports.Engine.Table
        'Dim myLogin As CrystalDecisions.Shared.TableLogOnInfo
        'Dim crSubreportObject As SubreportObject
        'Dim crSubreportDocument As ReportDocument
        'Dim crDatabase As Database
        Dim crTables As Tables
        Dim aTable As Table
        Dim crTableLogOnInfo As New TableLogOnInfo()
        Dim crConnectionInfo As New ConnectionInfo()

        Dim repDoc As New ReportDocument()

        repDoc = New Inventory
        repDoc.Load(Application.StartupPath & "\Inventory.rpt")

        DateStart = repDoc.ReportDefinition.ReportObjects.Item("txtStartingDate")
        DateEnd = repDoc.ReportDefinition.ReportObjects.Item("txtEndingDate")
        Branch = repDoc.ReportDefinition.ReportObjects.Item("txtBranch")
        Username = repDoc.ReportDefinition.ReportObjects.Item("txtUsername")

        Username.Text = Me.ToolStripStatuslblUsername.Text
        Branch.Text = Me.lblBranchName.Text

        With crConnectionInfo
            .UserID = "Admin"
            '.Password = "Admin"
            '.ServerName = GetcrptDBPath() & "\ElectriPartsDB.mdb"
            .DatabaseName = GetcrptDBPath() & "\ElectriPartsDB.mdb"
            '.ServerName = Application.StartupPath & "\ElectriPartsDB.mdb"
            '.DatabaseName = Application.StartupPath & "\ElectriPartsDB.mdb"
        End With

        crTables = repDoc.Database.Tables

        For Each aTable In crTables
            crTableLogOnInfo = aTable.LogOnInfo
            crTableLogOnInfo.ConnectionInfo = crConnectionInfo
            aTable.ApplyLogOnInfo(crTableLogOnInfo)
        Next

        'For Each myTable In repDoc.Database.Tables
        '    myLogin = myTable.LogOnInfo
        '    'myLogin.ConnectionInfo.ServerName = GetcrptDBPath() & "\ElectriPartsDB.mdb"
        '    myLogin.ConnectionInfo.ServerName = Application.StartupPath & "\ElectriPartsDB.mdb"
        '    'myLogin.ConnectionInfo.DatabaseName = GetcrptDBPath() & "\ElectriPartsDB.mdb"
        '    myTable.ApplyLogOnInfo(myLogin)
        'Next

        'crSections = repDoc.ReportDefinition.Sections
        ''loop through all the sections to find all the report objects
        'For Each crSection In crSections
        '    crReportObjects = crSection.ReportObjects
        '    'loop through all the report objects in there to find all subreports 
        '    For Each crReportObject In crReportObjects
        '        If crReportObject.Kind = ReportObjectKind.SubreportObject Then
        '            crSubreportObject = CType(crReportObject, SubreportObject)
        '            'open the subreport object and logon as for the general report
        '            crSubreportDocument = crSubreportObject.OpenSubreport(crSubreportObject.SubreportName)
        '            crDatabase = crSubreportDocument.Database
        '            crTables = crDatabase.Tables
        '            For Each aTable In crTables
        '                crTableLogOnInfo = aTable.LogOnInfo
        '                'crTableLogOnInfo.ConnectionInfo.UserID = "Admin"
        '                'crTableLogOnInfo.ConnectionInfo.Password = ""
        '                'crTableLogOnInfo.ConnectionInfo.DatabaseName = GetcrptDBPath() & "\ElectriPartsDB.mdb"
        '                aTable.ApplyLogOnInfo(crTableLogOnInfo)
        '            Next
        '        End If
        '    Next
        'Next

        vwfrmAdmin.crptvwAdmin.ReportSource = repDoc
        'vwfrmAdmin.crptvwAdmin.SelectionFormula = " {vwPurchasedItems.DateIn}>= #" & Me.dtpStart.Value.ToShortDateString & "# And {vwPurchasedItems.DateIn}< #" & Me.dtpEnd.Value.AddDays(1).ToShortDateString & "#"
        vwfrmAdmin.crptvwAdmin.Refresh()
        vwfrmAdmin.ShowDialog()
    End Sub

End Class
