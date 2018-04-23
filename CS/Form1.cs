using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPrinting;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPivotGrid.Data;
using System.Drawing.Printing;

namespace S130362 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
			PrintingSystem ps = new PrintingSystem();
			PrintableComponentLink link = new PrintableComponentLink(ps);
			link.Component = pivotGridControl1;
			PageSettings pageSettings = pivotGridControl1.OptionsPrint.PageSettings.ToPageSettings();
			link.PaperKind = pageSettings.PaperSize.Kind;
			if(pageSettings.PaperSize.Width != 0 && pageSettings.PaperSize.Height != 0)
				link.CustomPaperSize = new Size(pageSettings.PaperSize.Width, pageSettings.PaperSize.Height);
			link.PaperName = pageSettings.PaperSize.PaperName;
			link.Landscape = pageSettings.Landscape;
			link.Margins = pageSettings.Margins;

			link.ShowPreviewDialog(this);

			PivotGridPageSettings pivotSettings = pivotGridControl1.OptionsPrint.PageSettings;
			pivotSettings.PaperKind = link.PaperKind;
			if(pivotSettings.PaperKind == PaperKind.Custom) {
				pivotSettings.PaperWidth = link.CustomPaperSize.Width;
				pivotSettings.PaperHeight = link.CustomPaperSize.Height;
			}
			pivotSettings.Landscape = link.Landscape;
			pivotSettings.Margins = link.Margins;

			link.Dispose();
			ps.Dispose();
		}
	}
}