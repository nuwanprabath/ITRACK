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
using ITRACK.Validator;

namespace EFTesting.UI
{
    public partial class frmDividingPlanItem : DevExpress.XtraEditors.XtraForm
    {
        public frmDividingPlanItem()
        {
            InitializeComponent();
        }

        public int DividingPlanID { get; set; }
        public string  OprationNo { get; set; }

        public string OprationName { get; set; }

        public string  SMVType { get; set; }

        public string MachineType { get; set; }

        public double SMV { get; set; }

        public int DividingPlanItemID { get; set; }

        public string  DividingPlanHeaderID { get; set; }


        public frmDividingPlanItem(int _divdinPlanHeader) {

            this.DividingPlanID = _divdinPlanHeader;
            InitializeComponent();
        }

        public frmDividingPlanItem(int _dPlanId,string _oprationNo, string _oprationName,string _smvType,string _machineType,double _smv,string _dHeaderID) {
            this.DividingPlanID = _dPlanId;
            this.OprationNo = _oprationNo;
            this.OprationName = _oprationName;
            this.SMVType = _smvType;
            this.MachineType = _machineType;
            this.SMV = _smv;
            this.DividingPlanHeaderID = _dHeaderID;
           
            InitializeComponent();
        }



        GenaricRepository<DividingPlanItem> _pDidingItemEditRepository = new GenaricRepository<DividingPlanItem>(new ItrackContext());
        GenaricRepository<DividingPlanItem> _pDidingItemRepository = new GenaricRepository<DividingPlanItem>(new ItrackContext());
      
        #region CRUD 

        DividingPlanItem AssignValues()
        {
            try {
                 DividingPlanItem _item = new DividingPlanItem();
                _item.DividingPlanHeaderID =Convert.ToInt16(this.DividingPlanHeaderID);
                _item.DividingPlanItemID = this.DividingPlanID;
                _item.OprationNo = txtOprationNo.Text;
                _item.OprationName = txtoprationName.Text;
                _item.MachineType = cmbMachineType.Text;
                _item.SMVType = cmbSmvType.Text;
                _item.SMV =Convert.ToDouble( txtSMV.Text);
                _item.PartName = txtPartName.Text;
             

                return _item;
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
                return null;
            }
        
        }


        private bool AddItem() {
            try {
             
                _pDidingItemRepository.Add(AssignValues());
                return true;
            }
            catch(Exception ex){
                return false;
            }
        }


        private bool UpdateItem()
        {
            try
            {
              
                _pDidingItemEditRepository.Edit(AssignValues());
                
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }



       
       /* 
        void SearchOperation(string _key) {
            try {
                GenaricRepository<OperationPool> _OpRepository = new GenaricRepository<OperationPool>(new ItrackContext());
                var operation = from items in _OpRepository.GetAll().ToList() where items.OpationName == _key || items.OperationPoolID == _key select new { items.OperationPoolID, items.OpationName, items.SMV, items.SMVType };
                grdOpList.DataSource = operation;
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            
            }
        
        }
        */

        void getOperationFeild(string ID)
        {
            try
            {

                foreach (var operation in GetoprationByID(ID))
                {


                    txtOprationNo.Text = operation.OperationPoolID;
                    txtoprationName.Text = operation.OpationName;
                    txtSMV.Text = Convert.ToString(operation.SMV);
                    cmbSmvType.Text = operation.SMVType;
                    txtPartName.Text = operation.PartName;
                    cmbMachineType.Text = operation.MachineType;


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

        #endregion 

        #region Diclaration

        Validator validate = new Validator();

        #endregion

        #region Validation

        public bool isValidDividingPlanItem()
        {
            if (!validate.isPresent(txtOprationNo, "Operation Number"))
            {
                return false;
            }

            if (!validate.isPresent(cmbMachineType, "Machine Type"))
            {
                return false;
            }

            if (!validate.isPresent(txtoprationName, "Operation Name"))
            {
                return false;
            }

            if (!validate.isPresent(txtSMV, "SMV"))
            {
                return false;
            }

            if (!validate.isPresent(cmbSmvType, "SMV Type"))
            {
                return false;
            }

            if (!validate.isPresent(txtPartName, "Part Name"))
            {
                return false;
            }

            return true;


        }



        #endregion



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValidDividingPlanItem() == true)
            {
                 AddItem();
            }
                      
        }

        private void frmDividingPlanItem_Load(object sender, EventArgs e)
        {
            txtOprationNo.Text = this.OprationNo;
            txtoprationName.Text = this.OprationName;
            cmbMachineType.Text = this.MachineType;
            cmbSmvType.Text = this.SMVType;
            txtSMV.Text =Convert.ToString(this.SMV);
           
            grdOpList.Hide();
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateItem();
            this.Close();
        }



        private void SearchOperation()
        {

            try
            {

                GenaricRepository<OperationPool> _OperationRepository = new GenaricRepository<OperationPool>(new ItrackContext());
                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(OperationPool), "s");
                Expression nameProperty = Expression.Property(argParam, "OperationPoolID");
                Expression namespaceProperty = Expression.Property(argParam, "OpationName");

                var val1 = Expression.Constant(txtOprationNo.Text);
                var val2 = Expression.Constant(txtOprationNo.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(namespaceProperty, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<OperationPool, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _OperationRepository.SearchFor(lambda1).ToList() select new { item.OperationPoolID, item.OpationName, item.SMV, item.SMVType };

                //check is record exist in selected item
                if (selected.Count() > 0)
                {
                    grdOpList.Show();
                 

                    grdOpList.DataSource = selected;
                }
                else
                {
                    grdOpList.DataSource = null;
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error - B-0007", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void txtOprationNo_EditValueChanged(object sender, EventArgs e)
        {
            SearchOperation();
         
        }

        private void grdOpList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) {
                txtOprationNo.Text = gridView2.GetFocusedRowCellValue("OperationPoolID").ToString();
                getOperationFeild(txtOprationNo.Text);
                grdOpList.Hide();
            }
            
           
        }

        private void txtOprationNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdOpList.Select();
            }
            else if (e.KeyData == Keys.Escape)
            {
                grdOpList.Hide();
               

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}