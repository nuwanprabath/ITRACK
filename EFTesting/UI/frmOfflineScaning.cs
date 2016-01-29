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
using DevExpress.Office.Utils;
using ITRACK.models;
using System.Linq.Expressions;
using EFTesting.ViewModel;
using System.Globalization;
using EFTesting.Reports;

namespace EFTesting.UI
{
    public partial class frmOfflineScaning : DevExpress.XtraEditors.XtraForm
    {
        public frmOfflineScaning()
        {
            InitializeComponent();
        }



        void SearchScanSchadual(Int16 id) {

            try {
                GenaricRepository<ScaningTimeSchadual> _ScaningTimeSchadualRepository = new GenaricRepository<ScaningTimeSchadual>(new ItrackContext());

                var list = from item in _ScaningTimeSchadualRepository.GetAll().ToList()
                           where item.ScaningTimeSchadualID == id
                           select new { item.ScaningTimeSchadualID, item.HourNO, item.ScaningTime };

                if (list.Count() > 0)
                {
                    grdSearch.DataSource = list;

                }
              

                

            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
        
        }



        private void Search()
        {

            try
            {


                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(ScaningTimeSchadual), "s");
                Expression nameProperty = Expression.Property(argParam, "ScaningTime");
                Expression namespaceProperty = Expression.Property(argParam, "ScaningTime");

                var val1 = Expression.Constant(txtScanTime.Text);
                var val2 = Expression.Constant(txtScanTime.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(namespaceProperty, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                GenaricRepository<ScaningTimeSchadual> _ScaningTimeSchadualRepository = new GenaricRepository<ScaningTimeSchadual>(new ItrackContext());
                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<ScaningTimeSchadual, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _ScaningTimeSchadualRepository.SearchFor(lambda1).ToList() select new { item.ScaningTimeSchadualID, item.HourNO, item.ScaningTime };
                grdSearch.Show();
                //check is record exist in selected item
                if (selected.Count() > 0)
                {



                    grdSearch.DataSource = selected;
                }
                else
                {
                    grdSearch.DataSource = null;
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error - B-0007", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtHourNo_EditValueChanged(object sender, EventArgs e)
        {

            Search();
        }

        private void txtHourNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdSearch.Select();
            }
            else if (e.KeyData == Keys.Escape)
            {
                grdSearch.Hide();

            }
        }



        private bool ProcessTextFile()
        {

            // textfileOpen.Filter = "Text Files (*.txt) | *.doc";
            textfileOpen.InitialDirectory = @"C:\";
            textfileOpen.Title = "Select Text File To Process";
            TextFileReadingHelper _helper = new TextFileReadingHelper();
            if (textfileOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {


                string _path = textfileOpen.FileName;

                txtLocation.Text = _path;



            }

            return true;

        }

        Employee _employee = new Employee();

        TextFileReadingHelper _helper = new TextFileReadingHelper();
        public string BarcodeID { get; set; }
        public string Grade { get; set; }

        public string Role { get; set; }


        bool isEmployeeExist = false;
        private void DoScan(){

            

            foreach (var Line in _helper.getAllLines(txtLocation.Text))
            {

                if (Line.Length == 5)
                {
                    GenaricRepository<Employee> _EmployeeRepos = new GenaricRepository<Employee>(new ItrackContext());
                    var emplist = _EmployeeRepos.GetAll().Where(x => x.EmployeeID == Line);
                    if (emplist.Count() > 0)
                    {
                        _employee.EmployeeID = Line;
                       
                        txtLog.MaskBox.AppendText("Emp No  -> :" + _employee.EmployeeID + "" + "\r\n");
                        isEmployeeExist = true;

                    }
                    else
                    {

                        Debug.WriteLine("Error :" + Line + "\r\n");

                        isEmployeeExist = false;
                        txtLog.MaskBox.AppendText("Error   ->Canot find emplayee ID :" + Line + "" + "\r\n");

                    }

                    
                }
                else if (Line.Length == 6)
                {

                    offlineScaning(Line);
                  //  Debug.WriteLine(Line);
                 
                   
                }

            }
        
        }

        private void offlineScaning(string _barcode)
        {
            try
            {
                GenaricRepository<OprationBarcodes> _BarcodeRepository = new GenaricRepository<OprationBarcodes>(new ItrackContext());
                GenaricRepository<OprationBarcodes> _BarcodeEditRepository = new GenaricRepository<OprationBarcodes>(new ItrackContext());
                foreach (var barcode in _BarcodeRepository.GetAll().Where(p => p.OprationBarcodesID == _barcode).ToList())
                {
                  

                      OprationBarcodes _sbarcode = new OprationBarcodes();
                      _sbarcode.OprationComplteAt = Convert.ToDateTime(txtDate.Text + " " + txtScanTime.Text);
                      _sbarcode.isOparationComplete = true;
                      _sbarcode.EmployeeID = _employee.EmployeeID;
                      _sbarcode.OprationBarcodesID = this.BarcodeID;
                      _sbarcode.OprationNO = barcode.OprationNO; ;
                      _sbarcode.OparationName = barcode.OparationName;
                      _sbarcode.OprationGrade = barcode.OprationGrade;
                      _sbarcode.OprationRole = barcode.OprationRole;
                      _sbarcode.BundleDetailsID = barcode.BundleDetails.BundleDetailsID;
                      _sbarcode.PartName = barcode.PartName;
                      _sbarcode.LineNo = barcode.LineNo;
                      _sbarcode.StyleNo = barcode.StyleNo;
                      _sbarcode.OprationBarcodesID = _barcode;
                      _sbarcode.OperationPoolID = barcode.OprationNO;
                      _sbarcode.WorkstationNo = barcode.WorkstationNo;
                      _sbarcode.HourNo = txtHourNo.Text;
                      if (isEmployeeExist == true)
                      {
                          txtLog.MaskBox.AppendText("Barcode ID  -> :" + _barcode + "  - Operation No :" + _sbarcode.OprationNO + "  Operation Name:" + _sbarcode.OparationName + "\r\n");
                          _BarcodeEditRepository.Update(_sbarcode);

                      }
                      else
                      {
                          txtLog.MaskBox.AppendText("Employee Not exist : Barcode ID  -> :" + _barcode + "  - Operation No :" + _sbarcode.OprationNO + "  Operation Name:" + _sbarcode.OparationName + "\r\n");
                         
                      }
                  }
                    
                   
                    

              
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }



        private void grdSearch_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter) {
                txtScanTime.Text = gridView4.GetFocusedRowCellValue("ScaningTime").ToString();
                txtHourNo.Text = gridView4.GetFocusedRowCellValue("HourNO").ToString();
                grdSearch.Hide();
            }
            
          
        }

        private void frmOfflineScaning_Load(object sender, EventArgs e)
        {
            grdSearch.Hide();
            grdSearchStyle.Hide();

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            ProcessTextFile();
        }




        public static async Task<bool> AddIndividualProductionSummary(DateTime dayendDate,string _HourNo)
        {
            try
            {

                GenaricRepository<OprationBarcodes> _OperationBarcode = new GenaricRepository<OprationBarcodes>(new ItrackContext());
                GenaricRepository<IndividualProductionSummery> _IndivialProudctionRepo = new GenaricRepository<IndividualProductionSummery>(new ItrackContext());

                IndividualProductionSummery _individualProductionSummary = new IndividualProductionSummery();

                var itemList = from items in _OperationBarcode.GetAll().ToList()

                               where items.isOparationComplete == true && items.OprationComplteAt.Day == dayendDate.Day && items.OprationComplteAt.Month == dayendDate.Month && items.OprationComplteAt.Year == dayendDate.Year && items.HourNo == _HourNo

                               group items by new { items.OprationComplteAt.Date, items.LineNo, items.EmployeeID, items.OprationNO, items.OparationName } into ItemG

                               select new { ItemG.Key.Date, ItemG.Key.LineNo, ItemG.Key.EmployeeID, ItemG.Key.OprationNO, ItemG.Key.OparationName, TotalItem = ItemG.Sum(c => c.BundleDetails.NoOfItem), SMV = ItemG.Sum(c => c.OperationPool.SMV * c.BundleDetails.NoOfItem) };



                foreach (var summary in itemList)
                {

                    Debug.WriteLine("Employee Name -" + summary.EmployeeID + " opration Name" + summary.OparationName + " No Of Item - " + summary.TotalItem + " Total SAH - " + summary.SMV / 60);
                    GenaricRepository<IndividualProductionSummery> _IndivialRepo = new GenaricRepository<IndividualProductionSummery>(new ItrackContext());

                    _individualProductionSummary.EmployeeID = summary.EmployeeID;

                    _individualProductionSummary.OprationNo = summary.OprationNO;
                    _individualProductionSummary.Pcs = Convert.ToInt16(summary.TotalItem);
                    _individualProductionSummary.EarnSAH = Convert.ToDouble((summary.SMV / 60).ToString("G7", CultureInfo.InvariantCulture));
                    _individualProductionSummary.Effiency = summary.SMV;
                    _individualProductionSummary.DayendHeaderID = Convert.ToString(dayendDate.Year + dayendDate.Month + dayendDate.Day);
                    _individualProductionSummary.IndividualProductionSummeryID = _individualProductionSummary.DayendHeaderID + summary.EmployeeID;
                    _IndivialRepo.Insert(_individualProductionSummary);



                }

                return true;

            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
                return false;
            }

        }









        private void txtScanTime_EditValueChanged(object sender, EventArgs e)
        {

        }


        StyleVM SVM = new StyleVM();



        
       
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            // Do Production Scan
            DoScan();

            // Do Finalized Process
            clsProductionSummary.FinalizedProductionStatus(Convert.ToDateTime(txtDate.Text), txtHourNo.Text, "TR 100 A", "TR M 421");
            
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            SVM.SearchStyle2(grdSearchStyle, txtStyleNo);
        }
    }
}