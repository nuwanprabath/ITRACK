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

namespace EFTesting.UI
{
    public partial class frmCustomFieldsSetup : DevExpress.XtraEditors.XtraForm
    {
        public frmCustomFieldsSetup()
        {
            InitializeComponent();
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        #region Diclaration

        Validator validate = new Validator();

        #endregion

        #region Validation

        public bool isValidCustomFieldSetup()
        {
            if (!validate.isPresent(cmbItem, "Item Type"))
            {
                return false;
            }

            if (!validate.isPresent(txtCustomField1, "Item Field"))
            {
                return false;
            }

            if (!validate.isPresent(txtCodeLength, "Code Length"))
            {
                return false;
            }


            return true;

        }




        #endregion



        #region CRUD

        GenaricRepository<CustomeFieldSetup> _CustomFieldRepo = new GenaricRepository<CustomeFieldSetup>(new ItrackContext());
        GenaricRepository<Company> _CompanyRepository = new GenaricRepository<Company>(new ItrackContext());
        Company _Company = new Company();
        CustomeFieldSetup field = new CustomeFieldSetup();

        private CustomeFieldSetup AssingCustomField()
        {



            foreach (var item in _CompanyRepository.GetAll().Where(x => x.isDefaultCompany == true))
            {
                _Company.CompanyID = item.CompanyID;

            }

            field.ItemType = cmbItem.Text;
            field.CompanyID = _Company.CompanyID;
            field.CustomField1 = txtCustomField1.Text;
            field.CustomField2 = txtCustomField2.Text;
            field.CustomField3 = txtCustomField3.Text;
            field.CustomField4 = txtCustomField4.Text;
            field.CustomField5 = txtCustomField5.Text;
            field.CustomField6 = txtCustomField6.Text;
            field.CodeLength = Convert.ToInt32(txtCodeLength.Text);

            if (chkAuto.Checked == true)
            {
                field.ItemCodeGenerate = true;

            }
            else
            {
                field.ItemCodeGenerate = false;
            }

            if (chkManual.Checked == true)
            {
                field.ItemCodeGenerate = true;
            }
            else
            {
                field.ItemCodeGenerate = false;
            }

            return field;

        }

        /// <summary>
        /// Add Item Calling This Method
        /// </summary>

        private void AddField()
        {
            try
            {

                _CustomFieldRepo.Add(AssingCustomField());
            }

            catch (Exception ex)
            {


            }

        }

        private void SearchItem()
        {
            try
            {

              GenaricRepository<CustomeFieldSetup> _CustomFieldRepo = new GenaricRepository<CustomeFieldSetup>(new ItrackContext());
                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(CustomeFieldSetup), "s");
                Expression nameProperty = Expression.Property(argParam, "ItemType");
                Expression namespaceProperty = Expression.Property(argParam, "CustomField1");

                var val1 = Expression.Constant(txtSearchBox.Text);
                var val2 = Expression.Constant(txtSearchBox.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(namespaceProperty, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<CustomeFieldSetup, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _CustomFieldRepo.SearchFor(lambda1).ToList() select new {item.CustomeFieldSetupID, item.ItemType, item.CustomField1, item.CustomField2, item.CustomField3 };

                //check is record exist in selected item
                if (selected.Count() > 0)
                {
                    grdSearch2.Show();
                    btnClose.Show();

                    grdSearch2.DataSource = selected;
                }
                else
                {
                    grdSearch2.DataSource = null;
                }


            }
            catch (Exception ex)
            {


            }

        }

        // get selected object values to form controls 
        void getCutomField (int ID)
        {
            try
            {

                foreach (var item in getCustomeFieldSetupID(ID))
                {
                    cmbItem.Text = item.ItemType;
                    txtCustomField1.Text = item.CustomField1;
                    txtCustomField2.Text = item.CustomField2;
                    txtCustomField3.Text = item.CustomField3;
                    txtCustomField4.Text = item.CustomField4;
                    txtCustomField5.Text = item.CustomField5;
                    txtCustomField6.Text = item.CustomField6;
                    txtCodeLength.Text = Convert.ToString(item.CodeLength);

                    if (item.ItemCodeGenerate == true)
                    {
                        chkAuto.Checked = true;
                    }
                    else
                    {
                        chkAuto.Checked = false;
                    }

                    if (item.ItemCodeGenerate == true)
                    {
                        chkManual.Checked = true;
                    }
                    else
                    {
                        chkManual.Checked = false;
                    }


                    grdSearch2.Hide();
                    txtSearchBox.Hide();
                    btnClose.Hide();

              }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<CustomeFieldSetup> getCustomeFieldSetupID(int ID)
        {
            try
            {
                return _CustomFieldRepo.GetAll().Where(u => u.CustomeFieldSetupID == ID).ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

        }

        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValidCustomFieldSetup() == true)
            {
                AddField();
            }
        }

        private void frmCustomFieldsSetup_Load(object sender, EventArgs e)
        {
            grdSearch.Hide();
            grdSearch2.Hide();
            btnClose.Hide();
            txtSearchBox.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSearchBox.Show();
            btnClose.Show();
            txtSearchBox.Focus();
        }

        private void grdSearch2_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchBox_EditValueChanged_1(object sender, EventArgs e)
        {
            SearchItem();
        }

        private void txtSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdSearch2.Select();
            }

            else if (e.KeyData == Keys.Escape)
            {
                grdSearch2.Hide();

            }



        }

        private void grdSearch2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                field.CustomeFieldSetupID = Convert.ToInt32 (gridView1.GetFocusedRowCellValue("CustomeFieldSetupID").ToString());
                getCutomField(field.CustomeFieldSetupID);
            }
        }

        private void cmbItemType_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            cmbItem.Text = "";
            txtCustomField1.Text = "";
            txtCustomField2.Text = "";
            txtCustomField3.Text = "";
            txtCustomField4.Text = "";
            txtCustomField5.Text = "";
            txtCustomField6.Text = "";
            txtCodeLength.Text = "";
            chkAuto.Checked = false;
            chkManual.Checked = false;
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

     
      


        
        }
    }

