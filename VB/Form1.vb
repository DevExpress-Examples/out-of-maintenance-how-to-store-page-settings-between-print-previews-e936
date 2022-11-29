Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPivotGrid
Imports System.Drawing.Printing

Namespace S130362

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            sqlDataSource1.Fill()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim ps As PrintingSystem = New PrintingSystem()
            Dim link As PrintableComponentLink = New PrintableComponentLink(ps)
            link.Component = pivotGridControl1
            Dim pageSettings As PivotGridPageSettings = pivotGridControl1.OptionsPrint.PageSettings
            link.PaperKind = pageSettings.PaperKind
            If pageSettings.PaperWidth <> 0 AndAlso pageSettings.PaperHeight <> 0 Then link.CustomPaperSize = New Size(pageSettings.PaperWidth, pageSettings.PaperHeight)
            link.Landscape = pageSettings.Landscape
            link.Margins = pageSettings.Margins
            link.ShowPreviewDialog(Me)
            Dim pivotSettings As PivotGridPageSettings = pivotGridControl1.OptionsPrint.PageSettings
            pivotSettings.PaperKind = link.PaperKind
            If pivotSettings.PaperKind = PaperKind.Custom Then
                pivotSettings.PaperWidth = link.CustomPaperSize.Width
                pivotSettings.PaperHeight = link.CustomPaperSize.Height
            End If

            pivotSettings.Landscape = link.Landscape
            pivotSettings.Margins = link.Margins
            link.Dispose()
            ps.Dispose()
        End Sub
    End Class
End Namespace
