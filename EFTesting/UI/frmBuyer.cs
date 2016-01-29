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
using System.Linq.Expressions;
using ITRACK.Validator;

namespace EFTesting.UI
{
    public partial class frmBuyer : DevExpress.XtraEditors.XtraForm
    {
        public frmBuyer()
        {
            InitializeComponent();
        }

        #region Declarations 

        GenaricRepository<Company> _CompanyRepository = new GenaricRepository<Company>(new ItrackContext());
        GenaricRepository<Buyer> _BuyerRepository = new GenaricRepository<Buyer>(new ItrackContext());
        GenaricRepository<Buyer> _BuyerRepositoryNew = new GenaricRepository<Buyer>(new ItrackContext());
        Buyer _Buyer = new Buyer();
        Company _Company = new Company();

        Validator Validator = new Validator();
        #endregion

        #region CRUD

        void Clear()
        {
            try
            {
                txtBuyerName.Text = "";
                txtAddress.Text = "";
                txtTeleNo.Text = "";
                txtFaxNo.Text = "";
                txtEmail.Text = "";
                txtBuyerName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0001", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        Buyer AssignBuyer() {
            try {

                foreach (var item in _CompanyRepository.GetAll().Where(x=> x.isDefaultCompany==true) ) {
                    _Company.CompanyID = item.CompanyID;

                }
                _Buyer.BuyerName = txtBuyerName.Text;
                _Buyer.BuyerTeleNo = txtTeleNo.Text;
                _Buyer.FaxNo = txtFaxNo.Text;
                _Buyer.BuyerShippingAddress = txtAddress.Text;
                _Buyer.CompanyID = _Company.CompanyID;
                _Buyer.EmailAddress = txtEmail.Text;
                return _Buyer;

            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "Error - B-0002", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        
        }

        private void AddBuyer() {
            try
            {
                _BuyerRepository.Add(AssignBuyer());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        async void editBuyer()
        {

            try
            {
                GenaricRepository<Company> _genaricrepositorycompanynew = new GenaricRepository<Company>(new ItrackContext());
                await _BuyerRepositoryNew.EditAsync(AssignBuyer());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0004", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        async void DeleteBuyer()
        {

            try
            {
                GenaricRepository<Buyer> _genaricrepositorybuyernew = new GenaricRepository<Buyer>(new ItrackContext());
                await _BuyerRepositoryNew.DeleteAsync(AssignBuyer());
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0005", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<Buyer> GetBuyerByID(int ID)
        {
            try
            {
                return _BuyerRepository.GetAll().Where(u => u.BuyerID == ID).ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

        }
        private void SearchBuyer() {

            try {


                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(Buyer), "s");
                Expression nameProperty = Expression.Property(argParam, "BuyerName");
                Expression namespaceProperty = Expression.Property(argParam, "BuyerName");

                var val1 = Expression.Constant(txtSearchBox.Text);
                var val2 = Expression.Constant(txtSearchBox.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(namespaceProperty, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<Buyer, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _BuyerRepository.SearchFor(lambda1).ToList() select new { item.BuyerID, item.BuyerName, item.BuyerTeleNo, item.FaxNo, item.BuyerShippingAddress };

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
            catch(Exception ex){

                MessageBox.Show(ex.Message, "Error - B-0007", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        // get selected object values to form controls 
        void getCompanyFeild(int ID)
        {
            try
            {

                foreach (var buyer in GetBuyerByID(ID))
                {
                    txtBuyerName.Text = buyer.BuyerName;
                    txtTeleNo.Text = buyer.BuyerTeleNo;
                    txtAddress.Text = buyer.BuyerShippingAddress;
                    txtFaxNo.Text = buyer.FaxNo;
                    txtEmail.Text = buyer.EmailAddress;
                    _Company.CompanyID = buyer.CompanyID;
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        #endregion

        #region Events 

        

        private void frmBuyer_Load(object sender, EventArgs e)
        {
            grdSearch.Hide();
            btnClose.Hide();
            txtSearchBox.Hide();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValidBuyer() == true) {

                AddBuyer();
            }
            
        }

        private void txtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
            SearchBuyer();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            grdSearch.Hide();
            btnClose.Hide();
            txtSearchBox.Hide();

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

            }
        }

        private void grdSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            _Buyer.BuyerID = Convert.ToInt16(gridView1.GetFocusedRowCellValue("BuyerID").ToString());
            getCompanyFeild(_Buyer.BuyerID);
            grdSearch.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtSearchBox.Show();
            btnClose.Show();
            txtSearchBox.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editBuyer();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteBuyer();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Clear();
        }

        #endregion

        #region valitation
        public bool isValidBuyer()
        {


            if (!Validator.isPresent(txtBuyerName, "Buyer Name"))
            {
                return false;
            }

            if (!Validator.isPresent(txtTeleNo, "Telephone No"))
            {
                return false;
            }

            if (!Validator.isPresent(txtFaxNo, "Fax No"))
            {
                return false;
            }

            if (!Validator.isPresent(txtEmail, "Email Address"))
            {
                return false;
            }

            if (!Validator.IsValidEmail(txtEmail.Text, "Email Address"))
            {
                return false;
            }

            if (!Validator.isPresent(txtAddress, "Address"))
            {
                return false;
            }

            return true;
        }
        #endregion

        private void grdSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtBuyerName_EditValueChanged(object sender, EventArgs e)
        {

        }


    }
}