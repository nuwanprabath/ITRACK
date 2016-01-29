using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace EFTesting.Reports
{
    public partial class rptPoDiliveries : DevExpress.XtraReports.UI.XtraReport
    {
        public rptPoDiliveries()
        {
            InitializeComponent();
        }

        private void rptPoDiliveries_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

        }

    }
}
