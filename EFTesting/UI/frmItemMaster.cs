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
using System.IO;

namespace EFTesting.UI
{
    public partial class frmItemMaster : DevExpress.XtraEditors.XtraForm
    {
        public frmItemMaster()
        {
            InitializeComponent();
        }

        #region Diclaration

        Validator validate = new Validator();

        #endregion  

        #region Validation

        public bool isValidItemMaster()
        {
            if (!validate.isPresent(txtItemType, "Item Type"))
            {
                return false;
            }

            if (!validate.isPresent(txtItemCode, "Item Code"))
            {
                return false;        
            }

            if (!validate.isPresent(txtCustomField1, "Custom Field 1"))
            {
                return false;        
            }

            if (!validate.isPresent(txtSupplierItemCode, "Supplier Code"))
             {
                 return false;
             }

            if (!validate.isPresent(cmbUom, "uom"))
             {
                 return false;
             }


             return true;
        }

        public bool isValidItemSpecification()
        {
            if (!validate.isPresent(txtMaxQty,"Max Qty"))
            {
                return false;
            }

            if (!validate.isPresent(txtReOrderQty, "Re-Order Qty"))
            {
                return false;
            }

            if (!validate.isPresent(txtMinimumQty, "Minimum Qty"))
            {
                return false;
            }


            return true;
        }

           

        #endregion

        #region CUID

        GenaricRepository<Items> _ItemMasterRepo = new GenaricRepository<Items>(new ItrackContext());
        GenaricRepository<CustomeFieldSetup> _CustomFieldRepo = new GenaricRepository<CustomeFieldSetup>(new ItrackContext());
        Items _item = new Items();
        Int32 CustomFID = 0;

        private Items AssingItems()

        {
            _item.ItemType      = txtItemType.Text;
            _item.ItemsID       = txtItemCode.Text;
            _item.CustomFiled1  = txtCustomField1.Text;
            _item.CustomField2  = txtCustomField2.Text;
            _item.CustomField3  = txtCustomField3.Text;
            _item.CustomField4  = txtCustomField4.Text;
            _item.CustomField5  = txtCustomField5.Text;
            _item.CustomField6  = txtCustomField6.Text;
            _item.SupplierItemCode = txtSupplierItemCode.Text;
            _item.Uom = cmbUom.Text;
            _item.MaxQty = txtMaxQty.Text;
            _item.ReOrderQty = txtReOrderQty.Text;
            _item.MinimumQty = txtMinimumQty.Text;
            _item.CustomeFieldSetupID = CustomFID;

            if (chkActive.Checked == true)
            {
                _item.Status = "Active";
            }
            else
            {
                _item.Status = "Inactive";
            }


            if (chkBatchItem.Checked == true)
            {
                _item.BatchItem = true;
            }
            else {
                _item.BatchItem = false;
            }

            if (chkServiceItem.Checked == true)
            {
                _item.ServiceItem = true;
            }
            else
            {
                _item.BatchItem = false;
            }

            if (chkShowInFrontEnd.Checked == true)
            {
                _item.ShowInFrontEnd = true;
            }
            else
            {
                  _item.ShowInFrontEnd = false;
            }

            if (chkDiscount.Checked == true)
            {
                _item.Discount = true;
            }
            else
            {
                _item.Discount = false;
            }

            if (chkCustomeReturnOrder.Checked == true)
            {
                _item.CustomerReturnOrder = true;
            }
            else
            {
                _item.CustomerReturnOrder = false;
            }

            if (chkSerialItem.Checked == true)
            {
                _item.SerialItems = true;
            }
            else
            {
                _item.SerialItems = false;
            }

            _item.Image = imageToByteArray(imgprofile.Image);  
            
            return _item;
           
        }


        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }

        /// <summary>
        /// Add Item calling this method
        /// </summary>
        private void AddField()
        {
            try
            {
                _ItemMasterRepo.Add(AssingItems());
            }

            catch (Exception ex)
            {

            }
        }

        //Search Items
        private void SearchItem()
        {
          try

            {

                splashScreenManager1.ShowWaitForm();
                GenaricRepository<Items> _ItemMasterRepo = new GenaricRepository<Items>(new ItrackContext());
                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(Items), "s");
                Expression nameProperty = Expression.Property(argParam, "ItemsID");
                Expression namespaceProperty = Expression.Property(argParam, "CustomFiled1");

                var val1 = Expression.Constant(txtSearchBox.Text);
                var val2 = Expression.Constant(txtSearchBox.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(namespaceProperty, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<Items, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _ItemMasterRepo.SearchFor(lambda1).ToList() select new { item.ItemsID,item.ItemType,item.CustomFiled1,item.CustomField2 };

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

                splashScreenManager1.CloseWaitForm();
            }
           catch(Exception ex)
            {


            }

        }


        private void SearchItemType()
        
        {
             try

            {

              GenaricRepository<CustomeFieldSetup> _CustomFieldRepo = new GenaricRepository<CustomeFieldSetup>(new ItrackContext());
                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(CustomeFieldSetup), "s");
                Expression nameProperty = Expression.Property(argParam, "ItemType");
                Expression namespaceProperty = Expression.Property(argParam, "CustomField1");

                var val1 = Expression.Constant(txtItemType.Text);
                var val2 = Expression.Constant(txtItemType.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(namespaceProperty, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<CustomeFieldSetup, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _CustomFieldRepo.SearchFor(lambda1).ToList() select new {item.CustomeFieldSetupID ,item.ItemType };

                //check is record exist in selected item
                if (selected.Count() > 0)
                {
                    grdSearchItemType.Show();
                    btnClose.Show();

                    grdSearchItemType.DataSource = selected;
                }
                else
                {
                    grdSearchItemType.DataSource = null;
                }


            }
            catch (Exception ex)
            {


            }

        }

        void getItemMasterFeild(string ID)
        {
            try
            {

                foreach (var item in GetItemByID(ID))
                {

                 txtItemCode.Text =    item.ItemsID;
                 txtItemType.Text = item.ItemType;
                 if (item.CustomFieldSetup.CustomField1 != "None") {
                     lblCustomf1.Text = item.CustomFieldSetup.CustomField1;
                     txtCustomField1.Text = item.CustomFiled1;
                 }

                 if (item.CustomFieldSetup.CustomField2 != "None")
                 {
                     lblCustomf2.Text = item.CustomFieldSetup.CustomField2;
                     txtCustomField2.Text = item.CustomField2;
                 }

                 if (item.CustomFieldSetup.CustomField3 != "None")
                 {
                     lblCustomf3.Text = item.CustomFieldSetup.CustomField3;
                     txtCustomField3.Text = item.CustomField3;
                 }

                 if (item.CustomFieldSetup.CustomField4 != "None")
                 {
                     lblCustomf4.Text = item.CustomFieldSetup.CustomField4;
                     txtCustomField4.Text = item.CustomField4;
                 }

                 if (item.CustomFieldSetup.CustomField5 != "None")
                 {
                     lblCustomf5.Text = item.CustomFieldSetup.CustomField5;
                     txtCustomField5.Text = item.CustomField5;
                 }

                 if (item.CustomFieldSetup.CustomField6 != "None")
                 {
                     lblCustomf6.Text = item.CustomFieldSetup.CustomField6;
                     txtCustomField6.Text = item.CustomField6;
                 }

                 txtSupplierItemCode.Text = item.SupplierItemCode;
                 cmbUom.Text = item.Uom;

                 if (item.Status == "Active")
                 {
                     chkActive.Checked = true;
                 }
                 else
                 {
                     chkActive.Checked = false;
                 }

                 txtMaxQty.Text = item.MaxQty;
                 txtReOrderQty.Text = item.ReOrderQty;
                 txtMinimumQty.Text = item.MinimumQty;

                    if (item.BatchItem == true)
                    {
                        chkBatchItem.Checked = true;
                    }
                    else
                    {
                        chkBatchItem.Checked = false;
                    }

                    if (item.ServiceItem == true)
                    {
                        chkServiceItem.Checked = true;
                    }
                    else
                    {
                        chkServiceItem.Checked = false;
                    }

                    if (item.ShowInFrontEnd == true)
                    {
                        chkShowInFrontEnd.Checked = true;
                    }
                    else
                    {
                        chkShowInFrontEnd.Checked = false;
                    }

                    if (item.Discount == true)
                    {
                        chkDiscount.Checked = true;
                    }
                    else
                    {
                        chkDiscount.Checked = false;
                    }

                    if (item.CustomerReturnOrder == true)
                    {
                        chkCustomeReturnOrder.Checked = true;
                   }
                    else
                    {
                        chkCustomeReturnOrder.Checked = false;
                    }

                    if (item.SerialItems == true)
                    {
                        chkSerialItem.Checked = true;
                    }
                    else
                    {
                        chkSerialItem.Checked = false;
                    }

                    byte[] picture = item.Image;
                    imgprofile.Image = Image.FromStream(new MemoryStream(picture));
                    imgprofile.Refresh();
            
                 grdSearch.Hide();
                 grdSearchItemType.Hide();
                 txtSearchBox.Hide();
                 btnClose.Hide();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private List<Items> GetItemByID(string ID)
        {
            try
            {
                return _ItemMasterRepo.GetAll().Where(u => u.ItemsID == ID).ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

        }

        // get selected object values to form controls 
        void getCutomField(int ID)
        {
            try
            {

                foreach (var item in getCustomeFieldSetupID(ID))
                {
                    txtItemType.Text = item.ItemType;

                    if (item.CustomField1 != "")
                    {
                        lblCustomf1.Text = item.CustomField1;
                    }
                    else {
                        lblCustomf1.Text = "Custom Field 1";
                    }


                    if ( item.CustomField2 != "")
                    {
                        lblCustomf2.Text = item.CustomField2;
                    }
                    else
                    {
                        lblCustomf2.Text = "Custom Field 2";
                    }

                    if ( item.CustomField3 != "")
                    {
                        lblCustomf3.Text = item.CustomField3;
                    }
                    else
                    {
                        lblCustomf3.Text = "Custom Field 3";
                    }


                    if (item.CustomField4 != "")
                    {
                        lblCustomf4.Text = item.CustomField4;
                    }
                    else
                    {
                        lblCustomf4.Text = "Custom Field 4";
                    }


                    if ( item.CustomField5 != "")
                    {
                        lblCustomf5.Text = item.CustomField5;
                    }
                    else
                    {
                        lblCustomf5.Text = "Custom Field 5";
                    }


                    if (item.CustomField6 != "")
                    {
                        lblCustomf6.Text = item.CustomField6;
                    }
                    else {
                        lblCustomf6.Text = "Custom Field 6";
                    }

                    grdSearchItemType.Hide();
            

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


        // All Events
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValidItemMaster() == true)
            {
                AddField();
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmItemMaster_Load(object sender, EventArgs e)
        {
            grdSearch.Hide();
            grdSearchItemType.Hide();  
            btnClose.Hide();
            txtSearchBox.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
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
                grdSearch.Select();
            }

            else if (e.KeyData == Keys.Escape)
            {

                grdSearch.Hide();
                
            }
        }

        private void txtItemCode_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtItemCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdSearchItemType.Select();
            }

            else if (e.KeyData == Keys.Escape)
            {
                grdSearchItemType.Hide();
            }

        }

        private void grdSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) {

                splashScreenManager1.ShowWaitForm();
               _item.ItemsID = gridView1.GetFocusedRowCellValue("ItemsID").ToString();
               getItemMasterFeild(_item.ItemsID);
               splashScreenManager1.CloseWaitForm();
             
            
            }
        }

        private void grdSearchItemType_Click(object sender, EventArgs e)
        {
            SearchItemType();
        }

        private void cmbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchItemType();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtItemType.Text = "";
            txtItemCode.Text = "";
            txtCustomField1.Text = "";
            txtCustomField2.Text = "";
            txtCustomField3.Text = "";
            txtCustomField4.Text = "";
            txtCustomField5.Text = "";
            txtCustomField6.Text = "";
            txtSupplierItemCode.Text = "";
            cmbUom.Text = "";
            chkActive.Checked = false;
            chkInactive.Checked = false;
            txtMaxQty.Text = "";
            txtMinimumQty.Text = "";
            txtReOrderQty.Text = "";
            chkBatchItem.Checked = false;
            chkServiceItem.Checked = false;
            chkShowInFrontEnd.Checked = false;
            chkDiscount.Checked = false;
            chkCustomeReturnOrder.Checked = false;
            chkSerialItem.Checked = false;

            grdSearchItemType.Hide();

        }

        private void txtItemType_EditValueChanged(object sender, EventArgs e)
        {
            SearchItemType();
        }

        private void txtItemType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdSearchItemType.Select();
            }
            else if (e.KeyData == Keys.Escape)
            {
                grdSearchItemType.Hide();
            }

        }

        private void grdSearchItemType_KeyDown(object sender, KeyEventArgs e)
        {            
                if (e.KeyData == Keys.Enter)
                {

                    _item.CustomeFieldSetupID = Convert.ToInt32( gridView2.GetFocusedRowCellValue("CustomeFieldSetupID").ToString());
                    CustomFID = _item.CustomeFieldSetupID;
                    getCutomField(Convert.ToInt16(_item.CustomeFieldSetupID));

                }
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }



    }
}