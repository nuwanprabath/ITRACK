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
    public partial class frmIndividualProductionDialog : DevExpress.XtraEditors.XtraForm
    {
        public frmIndividualProductionDialog()
        {
            InitializeComponent();
        }



        List<HourlyIndividualProduction> lstProduction = new List<HourlyIndividualProduction>();

        GenaricRepository<IndividualProductionDetails> _OperationRepository = new GenaricRepository<IndividualProductionDetails>(new ItrackContext());


        string GetEmployeeNameByID(string _id) {
            try {
                GenaricRepository<Employee> _EMployeeRepo = new GenaricRepository<Employee>(new ItrackContext());
                  // _EMployeeRepo.GetAll().Where(x => x.EmployeeID == _id).Last().FullName.ToString();

                string EmployeName ="";
                   foreach( var item in _EMployeeRepo.GetAll().Where(x=>x.EmployeeID==_id).ToList())
                   {
                       EmployeName = item.FullName;
                   }

                   return EmployeName;
            }
            catch(Exception ex){
                return null;
            }
        }
        private void GetData(DateTime _fromDate,DateTime _toDate){
           try {
            
               var DataList =  from items in _OperationRepository.GetAll().ToList()

                              where items.Date >= _fromDate && items.Date >= _toDate

                               orderby items.WorkstationNo  
                               
                               select items;

               foreach (var pcs in DataList)
               {

                   lstProduction.Add(new HourlyIndividualProduction { EmployeeID=pcs.EmployeeID, Name=GetEmployeeNameByID(pcs.EmployeeID),   WorkstationNo=pcs.WorkstationNo,OperationNo=pcs.OperationNo,OperationName=pcs.OperationName,HourNo=pcs.HourNo,Efficiency=pcs.Efficiency,EarnSAH=pcs.SAH ,PCS=pcs.Pcs,Date=pcs.Date,StyleNo=pcs.StyleNo});
               
               }



               HourlyProductionByOperation report = new HourlyProductionByOperation();
               report.DataSource = lstProduction;
               ReportPrintTool tool = new ReportPrintTool(report);
               report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
               tool.ShowPreview();


            }
            catch(Exception ex){
            
            }
        
        }

        private void btnGenarate_Click(object sender, EventArgs e)
        {
            GetData(Convert.ToDateTime(txtFromDate.Text), Convert.ToDateTime(txttoDate.Text));
        }
    }
}