using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace EFTesting.Reports
{
    public partial class rptHProduction : DevExpress.XtraReports.UI.XtraReport
    {
        public rptHProduction()
        {
            InitializeComponent();
        }

        private void rptHProduction_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            DevExpress.XtraReports.UI.XtraReport report = (DevExpress.XtraReports.UI.XtraReport)sender;
            xrPivotGrid1.DataSource = report.DataSource;
        }

    }
}
