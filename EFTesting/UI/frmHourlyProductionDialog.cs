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
using DevExpress.XtraReports.UI;
using DevExpress.Office.Utils;
using EFTesting.ViewModel;
using ITRACK.models;

namespace EFTesting.UI
{
    public partial class frmHourlyProductionDialog : DevExpress.XtraEditors.XtraForm
    {
        public frmHourlyProductionDialog()
        {
            InitializeComponent();
        }


        List<HourlyProductionList> lstPro = new List<HourlyProductionList>();

      

        private List<HourlyProductionList> GetReportData(DateTime _fromDate, DateTime _toDate)
        {

            try
            {

                GenaricRepository<OprationBarcodes> _BarcodeRepo = new GenaricRepository<OprationBarcodes>(new ItrackContext());


                // get production result from table and analys by date or date range 
                var result = from items in _BarcodeRepo.GetAll().ToList()
                             where
                                 (items.OprationComplteAt.Day <= _toDate.Day && items.OprationComplteAt.Day >= _fromDate.Day)
                                 && (items.OprationComplteAt.Month <= _toDate.Month && items.OprationComplteAt.Month >= _fromDate.Month)
                                 && (items.OprationComplteAt.Year <= _toDate.Year && items.OprationComplteAt.Year >= _fromDate.Year)
                                 && items.isOparationComplete == true
               //group by result and get sum by operation no and hour 
                             group items by new { items.OprationComplteAt.Date,items.OprationNO,items.Employee.FullName, items.OprationComplteAt.Hour, items.OprationComplteAt.Minute, items.LineNo, items.StyleNo } into ItemG

                             select new { ItemG.Key.Date, ItemG.Key.OprationNO, ItemG.Key.FullName, ItemG.Key.Hour, ItemG.Key.Minute, ItemG.Key.LineNo, ItemG.Key.StyleNo, Count = ItemG.Sum(c => c.BundleDetails.NoOfItem) };
                // go through result and fill foreeach result in to lstPro List
                foreach (var production in result) {


                    lstPro.Add(new HourlyProductionList { StyleNo = production.StyleNo, Date = production.Date.Date, LineNo = production.LineNo,OperationNo=production.OprationNO,EmployeeName=production.FullName ,Hour = production.Hour+"."+production.Minute, Pcs =Convert.ToInt16(production.Count) });
                
                }
                            

               


                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-07", LineNo = "V-6", Hour = "2", LineIn = 5, LineOut = 5 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-07", LineNo = "V-6", Hour = "3", LineIn = 45, LineOut = 45 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-07", LineNo = "V-6", Hour = "4", LineIn = 0, LineOut = 0 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-07", LineNo = "V-6", Hour = "5", LineIn = 0, LineOut = 0 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-07", LineNo = "V-6", Hour = "6", LineIn = 0, LineOut = 0 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-07", LineNo = "V-6", Hour = "7", LineIn = 0, LineOut = 0 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-07", LineNo = "V-6", Hour = "8", LineIn = 0, LineOut = 0 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-07", LineNo = "V-6", Hour = "9", LineIn = 200, LineOut = 200 });


                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-01", LineNo = "V-6", Hour = "1", LineIn = 0, LineOut = 0 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-01", LineNo = "V-6", Hour = "2", LineIn = 0, LineOut = 0 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-01", LineNo = "V-6", Hour = "3", LineIn = 0, LineOut = 0 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-01", LineNo = "V-6", Hour = "4", LineIn = 200, LineOut = 220 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-01", LineNo = "V-6", Hour = "5", LineIn = 0, LineOut = 0 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-01", LineNo = "V-6", Hour = "6", LineIn = 0, LineOut = 0 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-01", LineNo = "V-6", Hour = "7", LineIn = 0, LineOut = 0 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-01", LineNo = "V-6", Hour = "8", LineIn = 0, LineOut = 0 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-01", LineNo = "V-6", Hour = "9", LineIn = 205, LineOut = 200 });


                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-02", LineNo = "V-6", Hour = "1", LineIn = 0, LineOut = 0 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-02", LineNo = "V-6", Hour = "2", LineIn = 0, LineOut = 0 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-02", LineNo = "V-6", Hour = "3", LineIn = 0, LineOut = 0 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-02", LineNo = "V-6", Hour = "4", LineIn = 310, LineOut = 215 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-02", LineNo = "V-6", Hour = "5", LineIn = 0, LineOut = 0 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-02", LineNo = "V-6", Hour = "6", LineIn = 0, LineOut = 0 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-02", LineNo = "V-6", Hour = "7", LineIn = 0, LineOut = 0 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-02", LineNo = "V-6", Hour = "8", LineIn = 0, LineOut = 0 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-02", LineNo = "V-6", Hour = "9", LineIn = 220, LineOut = 255 });


                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-03", LineNo = "V-6", Hour = "1", LineIn = 0, LineOut = 0 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-03", LineNo = "V-6", Hour = "2", LineIn = 0, LineOut = 0 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-03", LineNo = "V-6", Hour = "3", LineIn = 0, LineOut = 0 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-03", LineNo = "V-6", Hour = "4", LineIn = 235, LineOut = 200 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-03", LineNo = "V-6", Hour = "5", LineIn = 0, LineOut = 0 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-03", LineNo = "V-6", Hour = "6", LineIn = 0, LineOut = 0 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-03", LineNo = "V-6", Hour = "7", LineIn = 0, LineOut = 0 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-03", LineNo = "V-6", Hour = "8", LineIn = 0, LineOut = 0 });
                //lstPro.Add(new HourlyProductionList { StyleNo = "46575", Date = "2015-09-03", LineNo = "V-6", Hour = "9", LineIn = 210, LineOut = 205 });



                    
               
              
                return lstPro;

            }
            catch (Exception)
            {
                return lstPro;
            }

        }

        private void GenarateReport()
        {

            try
            {

                rptHProduction report = new rptHProduction();
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