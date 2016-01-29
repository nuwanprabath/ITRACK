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
using MyTeamApp;
using ITRACK.models;
using System.Diagnostics;
using System.Linq.Expressions;
using ITRACK.Validator;
using EFTesting.Reports;
using DevExpress.XtraReports.UI;

namespace EFTesting.UI
{
    public partial class frmDividingPlan : DevExpress.XtraEditors.XtraForm
    {

        GenaricRepository<DividingPlanTemp> _TempDidingRepository = new GenaricRepository<DividingPlanTemp>(new ItrackContext());
        GenaricRepository<OperationPool> _OperationRepository = new GenaricRepository<OperationPool>(new ItrackContext());
        GenaricRepository<DividingPlanHeader> _DividingHeaderRepository = new GenaricRepository<DividingPlanHeader>(new ItrackContext());
        GenaricRepository<DividingPlanItem> _DividingItemRepository = new GenaricRepository<DividingPlanItem>(new ItrackContext());
        DividingPlanHeader _header = new DividingPlanHeader();
        DividingPlanItem _item = new DividingPlanItem();

        public frmDividingPlan()
        {
            InitializeComponent();
        }
        ExcelHelpers E = new ExcelHelpers();
        OpenFileDialog ExcelDialog = new OpenFileDialog();


        public string DividingPlanNo { get; set; }

        public string StyleNo { get; set; }

        public string LineNo { get; set; }

        public string PPH { get; set; }

        public string Target { get; set; }

        public string TotalEmployee { get; set; }


        private void simpleButton5_Click(object sender, EventArgs e)
        {
           
            ExcelDialog.Filter = "Excel Files (*.xlsx) | *.xlsx";
            ExcelDialog.InitialDirectory = @"C:\";
            ExcelDialog.Title = "Select your Dividing Plan Excel";
            if (ExcelDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                
                E.DB_PATH = ExcelDialog.FileName;
                txtFileName.Text = ExcelDialog.FileName;
                txtFileName.ReadOnly = true;
             

            }
        }

        private List<OperationPool> GetoprationByID(string ID)
        {
            try
            {
                return _OperationRepository.GetAll().Where(u => u.OperationPoolID == ID).ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

        }


        private List<DividingPlanItem> GetDividingPlanByID(int Id) {
            try {
                return _DividingItemRepository.GetAll().ToList().Where(x => x.DividingPlanHeaderID == Id).ToList();
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
                return null;
            }
        
        }

        #region Diclaration

        Validator validate = new Validator();

        #endregion

        #region Validation

        public bool isValidDividingPlan()
        {
            if (!validate.isPresent(txtDividingPlanNo, "Dividing Plan Number"))
            {
                return false;
            }

            if (!validate.isPresent(txtStyleNo, "Style Number"))
            {
                return false;
            }

            if (!validate.isPresent(txtLineNo, "Line Number"))
            {
                return false;
            }

            if (!validate.isPresent(txtProductionPerHour, "Production per Hour"))
            {
                return false;
            }

            if (!validate.isPresent(txtTarget, "Target"))
            {
                return false;
            }

            if (!validate.isPresent(txtTotalEmployee, "Total Employees"))
            {
                return false;
            }


            return true;

        }


        #endregion


        #region Analays Dividing Plan
        List<DividingPlanTemp> lstDividingPlan = new List<DividingPlanTemp>();
        
        private async Task<bool> AnalysDevidingPlan()
        {
            string pName = "";

            foreach (var _temp in _TempDidingRepository.GetAll())
            {
                this.StyleNo = _temp.StyleID;
                this.TotalEmployee = _temp.TotalEmployee;
                this.LineNo = _temp.LineNo;
                this.PPH = _temp.ProductionPerHour;
                this.Target = _temp.Target;
                 
                foreach (var item in GetoprationByID(_temp.OprationNo).ToList()) {
                     pName = item.PartName;
                }
                if (GetoprationByID(_temp.OprationNo).Count > 0)
                {
                            lstDividingPlan.Add(new DividingPlanTemp(
                           _temp.DividingPlanTempID,
                           _temp.OprationNo,
                           _temp.OprationName,
                           _temp.SMVType,
                           _temp.MachineType,
                          _temp.SMV,
                           true,
                           pName
                       ));

                }
                else
                { 
                
                }
               
            
            }

            dlgdividingplan dialog = new dlgdividingplan(this.DividingPlanNo, this.StyleNo, this.LineNo, this.PPH, this.Target, this.TotalEmployee, lstDividingPlan);
            dialog.ShowDialog();
            return true;
        }

      public async Task DoDividingPlanAnalays()
        {
            await Task.Run(() =>
            {
               AnalysDevidingPlan();
            });

           

        }

      public async Task<bool> DoDividingPlanReading()
      {
          await Task.Run(() =>
          {
              ExcelHelpers.ReadDevidingPlan();
          });
          DoDividingPlanAnalays();
          progressPanel1.Hide();

       
          return true;
      }

         
    
        #endregion 

        private void btnProcess_Click(object sender, EventArgs e)
        {
            progressPanel1.Show();
            E.InitializeDevidingPlan();
            DoDividingPlanReading();


        }

        private void frmDividingPlan_Load(object sender, EventArgs e)
        {
            progressPanel1.Hide();
            grdSearch.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }


        #region CRUD 

        DividingPlanHeader AssignHeader() {

            try {
                _header.DividingPlanheaderID = Convert.ToInt16(txtDividingPlanNo.Text);
                _header.StyleID = txtStyleNo.Text;
                _header.LineNo = txtLineNo.Text;
                _header.ProductionPerHour = Convert.ToInt16(txtProductionPerHour.Text);
                _header.Target = Convert.ToInt16(txtTarget.Text);
                _header.TotalEmployee = Convert.ToInt16(txtTotalEmployee.Text);
                _header.Remark = txtRemark.Text;
                return _header;

            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
                return null;
            }
         
          
        }


        private bool AddHeader() {
            try {
                _DividingHeaderRepository.Add(AssignHeader());
                return true;
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
                return false;
            }
        
        }

        private void SearchDividingPlan()
        {

            try
            {


                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(DividingPlanHeader), "s");
                Expression nameProperty = Expression.Property(argParam, "StyleID");
                Expression namespaceProperty = Expression.Property(argParam, "StyleID");

                var val1 = Expression.Constant(txtSearchBox.Text);
                var val2 = Expression.Constant(txtSearchBox.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(namespaceProperty, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<DividingPlanHeader, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _DividingHeaderRepository.SearchFor(lambda1).ToList() select new { item.DividingPlanheaderID,item.LineNo,item.TotalEmployee,item.Target,item.StyleID,item.Style.Buyer.BuyerName};

                //check is record exist in selected item
                if (selected.Count() > 0)
                {
                    grdSearch.Show();
                    btnClose.Show();

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


        private List<DividingPlanHeader> GetDividingByID(int ID)
        {
            try
            {
                return _DividingHeaderRepository.GetAll().Where(u => u.DividingPlanheaderID == ID).ToList();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - C-0004", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

        }

        private List<DividingPlanItem> GetDividingItemByID(int ID)
        {
            try
            {
                return _DividingItemRepository.GetAll().Where(u => u.DividingPlanHeaderID == ID).ToList() ;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - C-0004", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

        }


        void getStyleFeild(int ID)
        {
            try
            {

                foreach (var dividing in GetDividingByID(ID))
                {

                    txtDividingPlanNo.Text =Convert.ToString( dividing.DividingPlanheaderID);
                    txtLineNo.Text = Convert.ToString(dividing.LineNo);
                    txtProductionPerHour.Text = Convert.ToString(dividing.ProductionPerHour);
                    txtTarget.Text = Convert.ToString(dividing.Target);
                    txtTotalEmployee.Text = Convert.ToString(TotalEmployee);
                    txtStyleNo.Text = dividing.StyleID;
                    txtRemark.Text = "None";
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - C-0005", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void PrintDividingPlan(int ID) {
            try {
                rptDividingPlan report = new rptDividingPlan();
                report.DataSource = GetDividingPlanByID(ID);
       
               ReportPrintTool tool = new ReportPrintTool(report);
              tool.ShowPreview();
            
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
        }


        #endregion 

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValidDividingPlan() == true) 
            {
                AddHeader();          
            }
            
            
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            
            frmDividingPlanItem item = new frmDividingPlanItem(Convert.ToInt16(txtDividingPlanNo.Text));
            item.ShowDialog();
        }

        private void txtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
            SearchDividingPlan();
        }

        private void grdSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                _header.DividingPlanheaderID =Convert.ToInt16(gridView1.GetFocusedRowCellValue("DividingPlanheaderID").ToString());
                getStyleFeild(_header.DividingPlanheaderID);

                var selected = from item in GetDividingItemByID(_header.DividingPlanheaderID) select new { item.DividingPlanItemID, item.OprationNo, item.WorkstationNo,item.OpNo, item.OprationName, item.SMVType, item.MachineType, item.SMV, item.PartName };
                grdOpration.DataSource = selected;
                grdSearch.Hide();
                btnClose.Hide();
                txtSearchBox.Hide();
             
            }
        }

        private void txtSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdSearch.Select();
                txtSearchBox.Focus();
            }
            else if (e.KeyData == Keys.Escape)
            {
                grdSearch.Hide();

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtSearchBox.Show();
            btnClose.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            _item.DividingPlanItemID = Convert.ToInt16(gridView2.GetFocusedRowCellValue("DividingPlanItemID").ToString());
            _item.OprationNo = gridView2.GetFocusedRowCellValue("OprationNo").ToString();
            _item.OprationName = gridView2.GetFocusedRowCellValue("OprationName").ToString();
            _item.SMVType = gridView2.GetFocusedRowCellValue("SMVType").ToString();
            try {
                _item.MachineType = gridView2.GetFocusedRowCellValue("MachineType").ToString();
            }
            catch(Exception ex){
            }
            
            _item.SMV = Convert.ToDouble(gridView2.GetFocusedRowCellValue("SMV").ToString());
            _item.PartName = gridView2.GetFocusedRowCellValue("PartName").ToString();
            _item.WorkstationNo = Convert.ToInt16(gridView2.GetFocusedRowCellValue("WorkstationNo").ToString());
            _item.OpNo =Convert.ToInt16( gridView2.GetFocusedRowCellValue("OpNo").ToString());

            frmDividingPlanItem dItem = new frmDividingPlanItem(_item.DividingPlanItemID, _item.OprationNo, _item.OprationName, _item.SMVType, _item.MachineType, _item.SMV, Convert.ToString(_header.DividingPlanheaderID), _item.PartName,_item.OpNo,_item.WorkstationNo);
            dItem.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (txtDividingPlanNo.Text != "")
            {
                PrintDividingPlan(Convert.ToInt16(txtDividingPlanNo.Text));
            }
            else {

                MessageBox.Show("Please Select Dividing Plan First !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnClose.Hide();
            txtSearchBox.Hide();
            grdSearch.Hide();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            Opration_List list = new Opration_List(Convert.ToInt16(txtDividingPlanNo.Text));
            list.ShowDialog();
        }


    }
}