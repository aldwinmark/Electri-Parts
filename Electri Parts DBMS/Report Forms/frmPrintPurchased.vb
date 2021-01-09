Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmPrintPurchased

    Private Sub btnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintPreview.Click

        Dim DateStart As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim DateEnd As CrystalDecisions.CrystalReports.Engine.TextObject

        Dim Branch As CrystalDecisions.CrystalReports.Engine.TextObject
        Dim Username As CrystalDecisions.CrystalReports.Engine.TextObject

        Dim crSections As Sections
        Dim crSection As Section
        Dim crReportObjects As ReportObjects
        'Dim crReportObject As ReportObject
        Dim myTable As CrystalDecisions.CrystalReports.Engine.Table
        Dim myLogin As CrystalDecisions.Shared.TableLogOnInfo
        'Dim crSubreportObject As SubreportObject
        'Dim crSubreportDocument As ReportDocument
        'Dim crDatabase As Database
        'Dim crTables As Tables
        'Dim aTable As Table
        'Dim crTableLogOnInfo As TableLogOnInfo

        Dim repDoc

        If frmMain.ToolStripStatuslblLevel.Text = "1" Then
            repDoc = New Purchased
        Else
            If Me.chckbxAll.Checked = True Then
                repDoc = New UPurchased
            Else
                repDoc = New UIndPurchased
            End If
        End If

        DateStart = repDoc.ReportDefinition.ReportObjects.Item("txtStartingDate")
        DateEnd = repDoc.ReportDefinition.ReportObjects.Item("txtEndingDate")
        Branch = repDoc.ReportDefinition.ReportObjects.Item("txtBranch")
        Username = repDoc.ReportDefinition.ReportObjects.Item("txtUsername")

        DateStart.Text = Me.dtpStart.Value.ToShortDateString
        DateEnd.Text = Me.dtpEnd.Value.ToShortDateString
        Username.Text = frmMain.ToolStripStatuslblUsername.Text
        Branch.Text = frmMain.lblBranchName.Text

        For Each myTable In repDoc.Database.Tables
            myLogin = myTable.LogOnInfo
            myLogin.ConnectionInfo.ServerName = GetcrptDBPath() & "\ElectriPartsDB.mdb"
            myLogin.ConnectionInfo.DatabaseName = GetcrptDBPath() & "\ElectriPartsDB.mdb"
            myTable.ApplyLogOnInfo(myLogin)
        Next

        crSections = repDoc.ReportDefinition.Sections
        'loop through all the sections to find all the report objects
        For Each crSection In crSections
            crReportObjects = crSection.ReportObjects
            'loop through all the report objects in there to find all subreports 
            'For Each crReportObject In crReportObjects
            '    If crReportObject.Kind = ReportObjectKind.SubreportObject Then
            '        crSubreportObject = CType(crReportObject, SubreportObject)
            '        'open the subreport object and logon as for the general report
            '        crSubreportDocument = crSubreportObject.OpenSubreport(crSubreportObject.SubreportName)
            '        crDatabase = crSubreportDocument.Database
            '        crTables = crDatabase.Tables
            '        For Each aTable In crTables
            '            crTableLogOnInfo = aTable.LogOnInfo
            '            crTableLogOnInfo.ConnectionInfo.UserID = "Admin"
            '            crTableLogOnInfo.ConnectionInfo.Password = ""
            '            'crTableLogOnInfo.ConnectionInfo.DatabaseName = GetcrptDBPath() & "\ElectriPartsDB.mdb"
            '            aTable.ApplyLogOnInfo(crTableLogOnInfo)
            '        Next
            '    End If
            'Next
        Next
        vwfrmAdmin.crptvwAdmin.ReportSource = repDoc
        vwfrmAdmin.crptvwAdmin.SelectionFormula = " {vwPurchasedItems.DateIn}>= #" & Me.dtpStart.Value.ToShortDateString & "# And {vwPurchasedItems.DateIn}< #" & Me.dtpEnd.Value.AddDays(1).ToShortDateString & "#"
        vwfrmAdmin.crptvwAdmin.RefreshReport()
        vwfrmAdmin.ShowDialog()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmPrintPurchased_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frmMain.ToolStripStatuslblLevel.Text = "1" Then
            Me.chckbxAll.Visible = False
            Me.chckbxAll.Enabled = False
        Else
            Me.chckbxAll.Visible = True
            Me.chckbxAll.Enabled = True
        End If
    End Sub

End Class