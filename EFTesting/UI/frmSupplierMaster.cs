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
using ITRACK.Validator;
using ITRACK.models;
using System.Linq.Expressions;
using System.Diagnostics;

namespace EFTesting.UI
{
    public partial class frmSupplierMaster : DevExpress.XtraEditors.XtraForm
    {
        public frmSupplierMaster()
        {
            InitializeComponent();
        }


        #region Diclaration

        Validator validate = new Validator();

        #endregion


        #region Validation
        public bool isValidSupplierMaster()
        {
            if (!validate.isPresent(txtSupplierId, "Supplier ID"))
            {
                return false;
            }

            if (!validate.isPresent(txtSupplierName, "Supplier Name"))
            {
                return false;
            }

            if (!validate.isPresent(txtSupplierType, "Supplier Type"))
            {
                return false;
            }

            if (!validate.isPresent(txtCity, "City"))
            {
                return false;
            }

            if (!validate.isPresent(txtCountry, "Country"))
            {
                return false;
            }

            if (!validate.isPresent(txtContactName, "Contact Name"))
            {
                return false;
            }

            if (!validate.isPresent(txtContactTitle, "Contact Title"))
            {
                return false;
            }

            if (!validate.isPresent(txtTelephoneNumber, "Telephone Number"))
            {
                return false;
            }

            return true;
        }

        public bool isValidAccountDetail()
        {
            if (!validate.isPresent(txtBankName, "Bank Name"))
            {
                return false;
            }

            if (!validate.isPresent(txtNameAsBank, "Name as Bank"))
            {
                return false;
            }

            if (!validate.isPresent(txtAccountNumber, "Account Number"))
            {
                return false;
            }

            if (!validate.isPresent(txtBranch, "Branch"))
            {
                return false;
            }

            if (!validate.isPresent(cmbChequeType, "Cheque Type"))
            {
                return false;
            }

            if (!validate.isPresent(txtCurrency, "Currency"))
            {
                return false;
            }

            if (!validate.isPresent(cmbCreditTerm, "Credit Term"))
            {
                return false;
            }
         
            return true;
        }
        

        #endregion

        #region CRUD

        GenaricRepository<SupplierMaster> _SupplierMasterRepo = new GenaricRepository<SupplierMaster>(new ItrackContext());
        GenaricRepository<Company> _CompanyRepository = new GenaricRepository<Company>(new ItrackContext());
        
        SupplierMaster _SupplierMaster = new SupplierMaster();
        Company _Company = new Company();


        private SupplierMaster AssingSupplier()
        {
            foreach (var item in _CompanyRepository.GetAll().Where(x => x.isDefaultCompany == true))
            {
                _Company.CompanyID = item.CompanyID;

            }

            _SupplierMaster.CompanyID = _Company.CompanyID;
            _SupplierMaster.SupplierMasterID = txtSupplierId.Text;
            _SupplierMaster.SupplierName = txtSupplierName.Text;
            _SupplierMaster.SupplierType = txtSupplierType.Text;
            _SupplierMaster.SupplierAddress = txtAddress.Text;
            _SupplierMaster.City = txtCity.Text;
            _SupplierMaster.Country = txtCountry.Text;

            if (chkActive.Checked == true)
            {
                _SupplierMaster.Status = "Active";
            }
            else if(chkInactive.Checked == true)
            {
                _SupplierMaster.Status = "Inactive";
            }
            else
            {
                _SupplierMaster.Status = "Suspend";
            }

            _SupplierMaster.ContactName = txtContactName.Text;
            _SupplierMaster.ContactTitle = txtContactTitle.Text;
            _SupplierMaster.TelephoneNumber = txtTelephoneNumber.Text;
            _SupplierMaster.FaxNumber = txtFaxNumber.Text;
            _SupplierMaster.EmailAddress = txtEmailAddress.Text;
            _SupplierMaster.WebAddress = txtWebAddress.Text;
            _SupplierMaster.PosalCode = txtPostalCode.Text;
            _SupplierMaster.BankName = txtBankName.Text;
            _SupplierMaster.AccountName = txtNameAsBank.Text;
            _SupplierMaster.AccountNumber = txtAccountNumber.Text;
            _SupplierMaster.Branch = txtBranch.Text;
            _SupplierMaster.ChequeType = cmbChequeType.Text;
            _SupplierMaster.BankAddress = txtBankAddress.Text;
            _SupplierMaster.Currency = txtCurrency.Text;
            _SupplierMaster.CreditTerm = cmbCreditTerm.Text;
            _SupplierMaster.SvatNo = txtSvatNo.Text;

            return _SupplierMaster;
        }

        /// <summary>
        /// Add Item calling this method
        /// </summary>
        private void AddSupplier()
        {
            try
            {
                _SupplierMasterRepo.Add(AssingSupplier());

            }
            catch (Exception ex)
            {

            }

        }

        private void EditSupplier()
        {
            try
            {
                GenaricRepository<SupplierMaster> _SupplierMasterRepoEdit = new GenaricRepository<SupplierMaster>(new ItrackContext());
                _SupplierMasterRepoEdit.Edit (AssingSupplier());
            }
            catch (Exception ex)
            {
               
            }

        }



        private void SearchItem()
        {
            try
            {

                GenaricRepository<SupplierMaster> _SupplierMasterRepo = new GenaricRepository<SupplierMaster>(new ItrackContext());
                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(SupplierMaster), "s");
                Expression nameProperty = Expression.Property(argParam, "SupplierMasterID");
                Expression namespaceProperty = Expression.Property(argParam, "SupplierName");

                var val1 = Expression.Constant(txtSearchBox.Text);
                var val2 = Expression.Constant(txtSearchBox.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(namespaceProperty, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<SupplierMaster, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _SupplierMasterRepo.SearchFor(lambda1).ToList() select new { item.SupplierMasterID, item.SupplierName, item.SupplierType,item.TelephoneNumber };

                //check is record exist in selected item
                if (selected.Count() > 0)
                {
                    grdSearch1.Show();
                    btnClose.Show();

                    grdSearch1.DataSource = selected;
                }
                else
                {
                    grdSearch1.DataSource = null;
                }


            }
            catch (Exception ex)
            {


            }

        }


        void getSupplierMaster(string ID)
        {
            try
            {
                foreach (var item in getSupplierMasterByID(ID))
                {
                    txtSupplierId.Text = item.SupplierMasterID;
                    txtSupplierName.Text = item.SupplierName;
                    txtSupplierType.Text = item.SupplierType;
                    txtAddress.Text = item.SupplierAddress;
                    txtCity.Text = item.City;
                    txtCountry.Text = item.Country;

                    if (item.Status == "Active")
                    {
                        chkActive.Checked = true;
                    }
                    else
                    {
                        chkActive.Checked = false;
                    }

                    if (item.Status == "Inactive")
                    {
                        chkInactive.Checked = true;
                    }
                    else
                    {
                        chkInactive.Checked = false;
                    }

                    if (item.Status == "Suspend")
                    {
                        chkSuspend.Checked = true;
                    }
                    else
                    {
                        chkSuspend.Checked = false;
                    }


                    txtContactName.Text = item.ContactName;
                    txtContactTitle.Text = item.ContactTitle;
                    txtTelephoneNumber.Text = item.TelephoneNumber;
                    txtFaxNumber.Text = item.FaxNumber;
                    txtEmailAddress.Text = item.EmailAddress;
                    txtWebAddress.Text = item.WebAddress;
                    txtPostalCode.Text = item.PosalCode;
                    txtBankName.Text = item.BankName;
                    txtNameAsBank.Text = item.BankName;
                    txtAccountNumber.Text = item.AccountNumber;
                    txtBranch.Text = item.Branch;
                    cmbChequeType.Text = item.ChequeType;
                    txtBankAddress.Text = item.BankAddress;
                    txtCurrency.Text = item.Currency;
                    cmbCreditTerm.Text = item.CreditTerm;

                    grdSearch1.Hide();
                    txtSearchBox.Hide();
                    btnClose.Hide();

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
     

        private List<SupplierMaster> getSupplierMasterByID(string ID)
        {
            try
            {
                return _SupplierMasterRepo.GetAll().Where(u => u.SupplierMasterID == ID).ToList();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        #endregion



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            chkInactive.Checked = false;
            chkSuspend.Checked = false;
        }

        private void chkInactive_CheckedChanged(object sender, EventArgs e)
        {
            chkSuspend.Checked = false;
            chkActive.Checked = false;

        }

        private void chkSuspend_CheckedChanged(object sender, EventArgs e)
        {
            chkActive.Checked = false;
            chkInactive.Checked = false;
        }

        private void frmSupplierMaster_Load(object sender, EventArgs e)
        {
            grdSearch1.Hide();
            btnClose.Hide();
            txtSearchBox.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValidSupplierMaster() == true)
            {
                AddSupplier();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtSearchBox.Show();
            btnClose.Show();
            txtSearchBox.Focus();
        }

        private void txtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
            SearchItem();
        }

        private void txtSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdSearch1.Select();
            }
            else if (e.KeyData == Keys.Escape)
            {
                grdSearch1.Hide();
            }
        }

        private void grdSearch1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                _SupplierMaster.SupplierMasterID = gridView1.GetFocusedRowCellValue("SupplierMasterID").ToString();
                getSupplierMaster(_SupplierMaster.SupplierMasterID);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtSupplierId.Text = "";
            txtSupplierName.Text = "";
            txtSupplierType.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";
            chkActive.Checked = false;
            chkInactive.Checked = false;
            chkSuspend.Checked = false;
            txtContactName.Text = "";
            txtContactTitle.Text = "";
            txtTelephoneNumber.Text = "";
            txtFaxNumber.Text = "";
            txtEmailAddress.Text = "";
            txtWebAddress.Text = "";
            txtBankName.Text = "";
            txtNameAsBank.Text = "";
            txtAccountNumber.Text = "";
            txtBranch.Text = "";
            cmbChequeType.Text = "";
            txtBankAddress.Text = "";
            txtCurrency.Text = "";
            cmbCreditTerm.Text = "";
            txtSvatNo.Text = "";

            txtSupplierId.Focus();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditSupplier();
        }
    }
}