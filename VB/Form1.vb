Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraPivotGrid.Data
Imports System.Drawing.Printing

Namespace S130362
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim ps As New PrintingSystem()
			Dim link As New PrintableComponentLink(ps)
			link.Component = pivotGridControl1
			Dim pageSettings As PageSettings = pivotGridControl1.OptionsPrint.PageSettings.ToPageSettings()
			link.PaperKind = pageSettings.PaperSize.Kind
			If pageSettings.PaperSize.Width <> 0 AndAlso pageSettings.PaperSize.Height <> 0 Then
				link.CustomPaperSize = New Size(pageSettings.PaperSize.Width, pageSettings.PaperSize.Height)
			End If
			link.PaperName = pageSettings.PaperSize.PaperName
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