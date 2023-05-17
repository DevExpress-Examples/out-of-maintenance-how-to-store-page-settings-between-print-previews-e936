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
using DevExpress.Drawing.Printing;

namespace S130362 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();			
		}

        private void Form1_Load(object sender, EventArgs e) {
            sqlDataSource1.Fill();
        }

        private void button1_Click(object sender, EventArgs e) {
			PrintingSystem ps = new PrintingSystem();
			PrintableComponentLink link = new PrintableComponentLink(ps);
			link.Component = pivotGridControl1;
			PivotGridPageSettings pageSettings = pivotGridControl1.OptionsPrint.PageSettings;
			link.PaperKind = (DXPaperKind)pageSettings.PaperKind;
			if(pageSettings.PaperWidth != 0 && pageSettings.PaperHeight != 0)
				link.CustomPaperSize = new Size(pageSettings.PaperWidth, pageSettings.PaperHeight);
			link.Landscape = pageSettings.Landscape;
			link.Margins = pageSettings.Margins;

			link.ShowPreviewDialog(this);

			PivotGridPageSettings pivotSettings = pivotGridControl1.OptionsPrint.PageSettings;
			pivotSettings.PaperKind = (PaperKind)link.PaperKind;
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