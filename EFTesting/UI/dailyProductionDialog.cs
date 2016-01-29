using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using EFTesting.Reports;
using ITRACK.models;
using DevExpress.XtraReports.UI;

namespace EFTesting.UI
{
    public partial class dailyProductionDialog : DevExpress.XtraEditors.XtraForm
    {
        public dailyProductionDialog()
        {
            InitializeComponent();
        }

        List<dailyProductionByHour> GetReportData(DateTime _fromDate, DateTime _toDate) 
        {

            try {

                List<dailyProductionByHour> lstProduction = new List<dailyProductionByHour>();

                GenaricRepository<DailyProduction> _ProRepo = new GenaricRepository<DailyProduction>(new ItrackContext());

                var result = from item in _ProRepo.GetAll().ToList()
                           //  where item.Date <= _fromDate && item.Date <= _toDate
                             select item;

                foreach (var production in result)
                {
                    lstProduction.Add(new dailyProductionByHour { StyleNo=production.StyleID,PoNo=production.PoNo,Date=production.Date,LineNo=production.LineNo,HourNo=production.HourNo,Color=production.Color,Type=production.Type,Qty= production.Qty});
                }

                return lstProduction;
            }
            catch(Exception ex){
                return null;
            
            }
        
        
        }


        private void GenarateReport()
        {

            try
            {

                rptDailiyProByHour report = new rptDailiyProByHour();
                report.DataSource = GetReportData(Convert.ToDateTime(txtFromDate.Text), Convert.ToDateTime(txttoDate.Text));
                report.Landscape = true;
                report.PrintingSystem.Document.AutoFitToPagesWidth = 1;

                ReportPrintTool tool = new ReportPrintTool(report);

                tool.ShowPreview();

            }
            catch (Exception ex)
            {

            }

        }

        private void btnGenarate_Click(object sender, EventArgs e)
        {
            GenarateReport();
        }
    }
}