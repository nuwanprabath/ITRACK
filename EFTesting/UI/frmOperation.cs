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
using System.Diagnostics;
using System.Linq.Expressions;
using MyTeamApp;
using EFTesting.ViewModel;
using ITRACK.Validator;

namespace EFTesting.UI
{
    public partial class frmOperation : DevExpress.XtraEditors.XtraForm
    {
        public frmOperation()
        {
            InitializeComponent();
        }



        #region Initilization

        OperationPool _Operation = new OperationPool();
        TempOpration _TempOpration =new TempOpration();
        GenaricRepository<Company> _CompanyRepository = new GenaricRepository<Company>(new ItrackContext());
      
        GenaricRepository<Style> _StyleRepository = new GenaricRepository<Style>(new ItrackContext());
        GenaricRepository<OperationPool> _EditOperationRepository = new GenaricRepository<OperationPool>(new ItrackContext());
        GenaricRepository<TempOpration> _TempOperationRepository = new GenaricRepository<TempOpration>(new ItrackContext());
      
        Company _Company = new Company();

        #endregion

        #region CRUD
        OperationPool AssignOperation()
        {
            try {
                foreach (var item in _CompanyRepository.GetAll().Where(x => x.isDefaultCompany == true))
                {
                    _Company.CompanyID = item.CompanyID;

                }
                _Operation.CompanyID = _Company.CompanyID;
                _Operation.OperationPoolID = txtOperationCode.Text;
                _Operation.OpationName = txtOperationName.Text;
                _Operation.SMV =Convert.ToDouble( txtSMV.Text);
                _Operation.SMVType = cmbSMVType.Text;
                _Operation.Remark = txtRemark.Text;
                _Operation.PartName = txtPartName.Text;
                _Operation.OprationGrade = cmbOprationGrade.Text;
                _Operation.OprationRole = cmboprationRole.Text;
                return _Operation;
            }
            catch(Exception ex){

                Debug.WriteLine(ex.Message);
                return null;
            
            }
        }

        TempOpration AssignTempOperation()
        {
            try
            {


                return _TempOpration;
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
                return null;

            }
        }

        private void AddOpration()
        {
            try
            {
                GenaricRepository<OperationPool> _OperationRepository = new GenaricRepository<OperationPool>(new ItrackContext());
                _OperationRepository.Add(AssignOperation());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Error - B-0003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void EditOperation()
        {
            try
            {
                _EditOperationRepository.Edit(AssignOperation());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Error - B-0003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       


        private void SearchSketch()
        {

            try
            {

                GenaricRepository<OperationPool> _OperationRepository = new GenaricRepository<OperationPool>(new ItrackContext());
                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(OperationPool), "s");
                Expression nameProperty = Expression.Property(argParam, "OperationPoolID");
                Expression namespaceProperty = Expression.Property(argParam, "OpationName");

                var val1 = Expression.Constant(txtSearchBox.Text);
                var val2 = Expression.Constant(txtSearchBox.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(namespaceProperty, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<OperationPool, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _OperationRepository.SearchFor(lambda1).ToList() select new { item.OperationPoolID,item.OpationName,item.SMV,item.SMVType };

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


        void getOperationFeild(string ID)
        {
            try
            {

                foreach (var operation in GetoprationByID(ID))
                {


                    txtOperationCode.Text = operation.OperationPoolID;
                    txtOperationName.Text = operation.OpationName;
                    txtSMV.Text =Convert.ToString( operation.SMV);
                    cmbSMVType.Text = operation.SMVType;
                    txtRemark.Text = operation.Remark;
                    cmboprationRole.Text = operation.OprationRole;
                    cmbOprationGrade.Text = operation.OprationGrade;
                    txtPartName.Text = operation.PartName;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<OperationPool> GetoprationByID(string ID)
        {
            try
            {
                GenaricRepository<OperationPool> _OperationRepository = new GenaricRepository<OperationPool>(new ItrackContext());
                return _OperationRepository.GetAll().Where(u => u.OperationPoolID == ID).ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

        }


        private void clear() {
            try {
                txtOperationCode.Text = "";
                txtOperationName.Text = "";
                txtSMV.Text = "";
                cmbSMVType.Text ="";
                txtRemark.Text = "";
                txtOperationCode.Focus();
                grdSearch.Hide();
            
            }catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
        
        }
        #endregion

        #region Diclaration

        Validator validate = new Validator();

        #endregion


        #region Validation

        public bool isValidOperation() 
        {
            if (!validate.isPresent(txtOperationCode, "Operation Code"))
            {
                return false;
            }

            if (!validate.isPresent(txtPartName, "Part Name"))
            {
                return false;
            }

            if (!validate.isPresent(txtOperationName, "Operation Name"))
            {
                return false;
            }

            if (!validate.isPresent(cmbSMVType, "SMV Type"))
            {
                return false;
            }

            if (!validate.isPresent(txtSMV, "SMV"))
            {
                return false;
            }

            if (!validate.isPresent(cmboprationRole, "Operation Role"))
            {
                return false;
            }

            if (!validate.isPresent(cmbOprationGrade, "Operation Grade"))
            {
                return false;
            }







            return true;
        
        
        }


        #endregion



        private void frmOperation_Load(object sender, EventArgs e)
        {
            grdSearch.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
            progressBar.Hide();
            btnProcess.Enabled = false;
            
          
        }

        private void txtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
            SearchSketch();
        }

        private void txtSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdSearch.Select();
            }
            else if (e.KeyData == Keys.Escape)
            {
                grdSearch.Hide();
                txtSearchBox.Hide();
                btnClose.Hide();

            }
        }

        private void grdSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try {
                 if (e.KeyCode == Keys.Enter) {
                    _Operation.OperationPoolID = gridView2.GetFocusedRowCellValue("OperationPoolID").ToString();
                    getOperationFeild(_Operation.OperationPoolID);
                    grdSearch.Hide();
                    txtSearchBox.Hide();
                    btnClose.Hide();
                }
            
            }
            catch(Exception ex){
            
            }
           
            
         
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtSearchBox.Show();
            btnClose.Show();
            txtSearchBox.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValidOperation() == true)
            {
                AddOpration();
                clear();
            }
           
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditOperation();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        OpenFileDialog ExcelDialog = new OpenFileDialog();
        ExcelHelpers E = new ExcelHelpers();
        private void simpleButton5_Click(object sender, EventArgs e)
        {


            
            ExcelDialog.Filter = "Excel Files (*.xlsx) | *.xlsx";
            ExcelDialog.InitialDirectory = @"C:\";
            ExcelDialog.Title = "Select your team excel";
            if (ExcelDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
           
               
                E.DB_PATH = ExcelDialog.FileName;
                txtFileName.Text = ExcelDialog.FileName;
                txtFileName.ReadOnly = true;
                btnProcess.Enabled = true;
                
              
                

            }

            //ImportExcelHelper helper = new ImportExcelHelper();

            //grdOperationList.DataSource = helper.UploadExcelSheet("D:\\test.xlsx");


        }




        #region Analyse
        List<TempOpration> lstTempOpration = new List<TempOpration>();
        private void SelectOpration() { 
         

             foreach (var _opration in _TempOperationRepository.GetAll().ToList())
             {
                 if (_opration.OprationID != "" && GetoprationByID(_opration.OprationID).Count==0)
                 {

                     lstTempOpration.Add(new TempOpration(

                         _opration.OprationID, 
                         _opration.OparationName,
                         _opration.MachineType,
                         _opration.SMV,
                         _opration.SMVType,
                         _opration.Remark,
                         _opration.TempOprationID,
                         _opration.OprationGrade,
                         _opration.PartName,
                         _opration.OprationRole


                    ));

                     

                 }
                 
                
             }


             grdOperationList.DataSource = lstTempOpration;
            

        }

        void SaveOpration() {
            try {
                
                foreach (var _opration in lstTempOpration) 
                {
                    GenaricRepository<OperationPool> _ORepository = new GenaricRepository<OperationPool>(new ItrackContext());
                    foreach (var item in _CompanyRepository.GetAll().Where(x => x.isDefaultCompany == true))
                    {
                        _Company.CompanyID = item.CompanyID;

                    }
                    _Operation.CompanyID = _Company.CompanyID;
                    _Operation.OperationPoolID = _opration.OprationID;
                    _Operation.OpationName = _opration.OparationName;
                    _Operation.SMV = _opration.SMV;
                    _Operation.SMVType = _opration.SMVType;
                    _Operation.MachineType = _opration.MachineType;
                    _Operation.Remark = _opration.Remark;
                    _Operation.OprationRole = _opration.OprationRole;
                    _Operation.OprationGrade = _opration.OprationGrade;
                    _Operation.PartName = _opration.PartName;

                    _ORepository.Insert(_Operation);

                    GenaricRepository<TempOpration> _tOpration = new GenaricRepository<TempOpration>(new ItrackContext());
                    TempOpration t = new TempOpration();
                    t.TempOprationID = _opration.TempOprationID;
                   _tOpration.Delete(t);
                  

                }
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
        }

        void removeOpration(int _index) {
            try {
                lstTempOpration.RemoveAt(_index);
                grdOperationList.DataSource = lstTempOpration;
                grdOperationList.RefreshDataSource();
                Debug.Write(lstTempOpration.Count);
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
         
        }

        #endregion
        private void simpleButton4_Click(object sender, EventArgs e)
        {
          
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            E.InitializeExcel();
            E.ReadMyExcel(progressBar);
            Cursor.Current = Cursors.WaitCursor;
            SelectOpration();
            Cursor.Current = Cursors.Default;
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SaveOpration();
            MessageBox.Show("Save Sucessfully !", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      
        private void simpleButton3_Click(object sender, EventArgs e)
        {

            int i = gridView3.FocusedRowHandle;
            removeOpration(gridView3.FocusedRowHandle);
            
        }

        private void grdOperationList_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            grdSearch.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
        }
    }
}