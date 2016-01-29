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
using ITRACK.models;
using EFTesting.ViewModel;
using DevExpress.Office.Utils;
using DevExpress.XtraReports.UI;
using EFTesting.Reports;

namespace EFTesting.UI
{
    public partial class frmHourlyProductionOut : DevExpress.XtraEditors.XtraForm
    {
        public frmHourlyProductionOut()
        {
            InitializeComponent();
        }



        List<HourlyProductionList> lstPro = new List<HourlyProductionList>();



        private List<HourlyProductionList> GetReportData(DateTime _fromDate, DateTime _toDate)
        {

            GenaricRepository<DividingPlanItem> _DividingPlanRepo = new GenaricRepository<DividingPlanItem>(new ItrackContext());
             GenaricRepository<OperationPool> _OperationPoolRepo = new GenaricRepository<OperationPool>(new ItrackContext());
            string InputOperationNo = "";
            string OutputOperationNo = "";


            // get input Operation No
            var input = from item in _DividingPlanRepo.GetAll().ToList()
                        where item.OperationRole == "In"
                        select new { item.OprationNo, item.OprationName };
            InputOperationNo = input.Last().OprationNo;

            // Get Output operation No
             var output = from item in _DividingPlanRepo.GetAll().ToList()
                        where item.OperationRole == "Out"
                        select new { item.OprationNo, item.OprationName };
            OutputOperationNo = output.Last().OprationNo;



            

               
         


            try
            {

                GenaricRepository<OprationBarcodes> _BarcodeRepo = new GenaricRepository<OprationBarcodes>(new ItrackContext());


                // get All input 
                var result = from items in _BarcodeRepo.GetAll().ToList()
                             where
                                 (items.OprationComplteAt.Day <= _toDate.Day && items.OprationComplteAt.Day >= _fromDate.Day)
                                 && (items.OprationComplteAt.Month <= _toDate.Month && items.OprationComplteAt.Month >= _fromDate.Month)
                                 && (items.OprationComplteAt.Year <= _toDate.Year && items.OprationComplteAt.Year >= _fromDate.Year)
                                 && items.isOparationComplete == true
                                 && items.OprationNO == InputOperationNo
                             //group by result and get sum by operation no and hour 
                             group items by new { items.OprationComplteAt.Date, items.OprationComplteAt.Hour, items.OprationComplteAt.Minute, items.LineNo, items.StyleNo } into ItemG

                             select new { ItemG.Key.Date, ItemG.Key.Hour, ItemG.Key.Minute, ItemG.Key.LineNo, ItemG.Key.StyleNo, Count = ItemG.Sum(c => c.BundleDetails.NoOfItem) };


                
                var outPutOp = from items in _BarcodeRepo.GetAll().ToList()
                             where
                                 (items.OprationComplteAt.Day <= _toDate.Day && items.OprationComplteAt.Day >= _fromDate.Day)
                                 && (items.OprationComplteAt.Month <= _toDate.Month && items.OprationComplteAt.Month >= _fromDate.Month)
                                 && (items.OprationComplteAt.Year <= _toDate.Year && items.OprationComplteAt.Year >= _fromDate.Year)
                                 && items.isOparationComplete == true
                                 && items.OprationNO == OutputOperationNo
                             //group by result and get sum by operation no and hour 
                             group items by new { items.OprationComplteAt.Date, items.OprationComplteAt.Hour, items.OprationComplteAt.Minute, items.LineNo, items.StyleNo } into ItemG

                             select new { ItemG.Key.Date, ItemG.Key.Hour, ItemG.Key.Minute, ItemG.Key.LineNo, ItemG.Key.StyleNo, Count = ItemG.Sum(c => c.BundleDetails.NoOfItem) };
              
                
                foreach (var production in result)
                {

                    var outputlist = from o in outPutOp
                                     where o.Date.Day == production.Date.Day
                                     && o.Date.Day == production.Date.Day
                                     && o.Date.Month == production.Date.Month
                                     && o.Date.Year == production.Date.Year
                                     && o.LineNo == production.LineNo
                                     && o.Hour == production.Hour
                                     && o.Minute == production.Minute

                                     select new { o.Count };

                    Debug.WriteLine("Line Out -" + outputlist.Last().Count);

                    lstPro.Add(new HourlyProductionList { StyleNo = production.StyleNo, Date = production.Date.Date, LineNo = production.LineNo, Hour = production.Hour + "." + production.Minute, Pcs = Convert.ToInt16(production.Count) });

                }




                return lstPro;

            }
            catch (Exception)
            {
                return lstPro;
            }

        }

        private void frmHourlyProductionOut_Load(object sender, EventArgs e)
        {

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