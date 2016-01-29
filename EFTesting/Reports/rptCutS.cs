using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace EFTesting.Reports
{
    public partial class rptCutS : DevExpress.XtraReports.UI.XtraReport
    {
        public rptCutS()
        {
            InitializeComponent();
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
           
        }

        private void rptCutS_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            DevExpress.XtraReports.UI.XtraReport report = (DevExpress.XtraReports.UI.XtraReport)sender;
            xrPivotGrid1.DataSource = report.DataSource;
           
            
        }

        private void xrPivotGrid1_AfterPrint(object sender, EventArgs e)
        {
          
        }

    }
}
