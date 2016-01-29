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
using EFTesting.ViewModel;
using EFTesting.Reports.Stock_Report;
using DevExpress.XtraReports.UI;

namespace EFTesting.UI
{
    public partial class frmPo : DevExpress.XtraEditors.XtraForm
    {
        public frmPo()
        {
            InitializeComponent();
        }

        #region Diclaration

        Validator validate = new Validator();

        #endregion

        #region Validation
        public bool isValidPo()
        {
            if (!validate.isPresent(txtSupplierId, "Supplier ID"))
            {
                return false;
            }

            if (!validate.isPresent(txtSupplierName, "Supplier Name"))
            {
                return false;
            }

            if (!validate.isPresent(txtSupplierAddress, "Supplier Address"))
            {
                return false;
            }

            if (!validate.isPresent(txtCompanyCode, "Company ID"))
            {
                return false;
            }

            if (!validate.isPresent(txtCompanyName, "Company Name"))
            {
                return false;
            }

            if (!validate.isPresent(txtCompanyAddress, "Company Address"))
            {
                return false;
            }

            if (!validate.isPresent(txtPoNo, "PO Number"))
            {
                return false;
            }

            if (!validate.isPresent(txtReferenceNo, "Referece Number"))
            {
                return false;
            }

            if (!validate.isPresent(txtDate, "Po Date"))
            {
                return false;
            }

            if (!validate.isPresent(cmbPurchaseType, "Purchase Type"))
            {
                return false;
            }

            if (!validate.isPresent(cmbCountry, "Country"))
            {
                return false;
            }

            if (!validate.isPresent(txtPort, "Port"))
            {
                return false;
            }

            if (!validate.isPresent(cmbShippingType, "Shipping Type"))
            {
                return false;
            }

            if (!validate.isPresent(txtShippingDate, "Shipping Date"))
            {
                return false;
            }

            if (!validate.isPresent(txtDeliveryDate, "Delivery Date"))
            {
                return false;
            }

            if (!validate.isPresent(txtHandleBy, "Handle By"))
            {
                return false;
            }

            if (!validate.isPresent(txtHandleBy, "Handle By"))
            {
                return false;
            }

            return true;
        }


        public bool isValidPoDetails()
        {

            if (!validate.isPresent(txtItemCode, "Item Code"))
            {
                return false;
            }

            if (!validate.isPresent(txtQty, "Qty"))
            {
                return false;
            }


            if (!validate.isPresent(txtPoPrice, "Price"))
            {
                return false;
            }


            return true;

        }

        #endregion

        #region CRUD

        GenaricRepository<PO> _PORepo = new GenaricRepository<PO>(new ItrackContext());
        GenaricRepository<Company> _CompanyRepository = new GenaricRepository<Company>(new ItrackContext());
        GenaricRepository<CustomeFieldSetup> _CustomFieldRepo = new GenaricRepository<CustomeFieldSetup>(new ItrackContext());
        GenaricRepository<SupplierMaster> _SupplierMasterRepo = new GenaricRepository<SupplierMaster>(new ItrackContext());
        GenaricRepository<Items> _ItemMasterRepo = new GenaricRepository<Items>(new ItrackContext());
        Company _Company = new Company();
        SupplierMaster _SupplierMaster = new SupplierMaster();
        PO _PO = new PO();
        Items _item = new Items();

        private PO AssingPO()
        {
            foreach (var item in _CompanyRepository.GetAll().Where(x => x.isDefaultCompany == true))
            {
                _Company.CompanyID = item.CompanyID;

            }

            _PO.CompanyID = _Company.CompanyID;
            _PO.SupplierMasterID = txtSupplierId.Text;
            _PO.SupplierName = txtSupplierName.Text;
            _PO.SupplierAddress = txtSupplierAddress.Text;
            _PO.CompanyCode = txtCompanyCode.Text;
            _PO.CompanyName = txtCompanyName.Text;
            _PO.CompamyAddress = txtCompanyAddress.Text;
            _PO.POID = txtPoNo.Text;
            _PO.Currency = cmbCurrency.Text;
            _PO.ReferenceNo = txtReferenceNo.Text;
            _PO.Date = txtDate.Text;
            _PO.PurchaseType = cmbPurchaseType.Text;
            _PO.Country = cmbCountry.Text;
            _PO.ShippingType = cmbShippingType.Text;
            _PO.DeliveryDate = txtDeliveryDate.Text;
            _PO.port = txtPort.Text;
            _PO.ShippingDate = txtShippingDate.Text;
            _PO.HandleBy = txtHandleBy.Text;
            _PO.CreditTerms = memCreditTerms.Text;
            _PO.ReturnPolicy = memReturnPolicy.Text;
           

            return _PO;
        }

        #endregion

        /// <summary>
        /// Add PO Calling This Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void AddField()
        {
            try
            {
                GenaricRepository<PO> _PORepo = new GenaricRepository<PO>(new ItrackContext());
                _PORepo.Add(AssingPO());
            }
            catch (Exception ex)
            {

            }
        }


        private void addPoItems() {
            try {

                GenaricRepository<PoItems> _POitemRepo = new GenaricRepository<PoItems>(new ItrackContext());
                PoItems _poitem = new PoItems();

                foreach (var item in lstPoItems) {
                    _poitem.ItemCode = item.ItemCode;
                    _poitem.Price = item.Price;
                    _poitem.Qty = item.Qty;
                    _poitem.SubTotal = item.SubTotal;
                    _poitem.POID = txtPoNo.Text;
                    _poitem.Discount = 0;
                    _poitem.ItemsID = item.ItemCode;
                    _poitem.Description = item.Description;
                    _poitem.Colors = item.Colors;
                    _poitem.Width = item.Width;
                    _poitem.Unit = item.Unit;
                    _POitemRepo.Add(_poitem);
                
                }
            
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
        
        }

        //Search Items
        private void SearchItem()
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                GenaricRepository<PO> _PORepo = new GenaricRepository<PO>(new ItrackContext());
                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(PO), "s");
                Expression nameProperty = Expression.Property(argParam, "POID");
                Expression namespaceProperty = Expression.Property(argParam, "SupplierMasterID");

                var val1 = Expression.Constant(txtSearchBox.Text);
                var val2 = Expression.Constant(txtSearchBox.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(namespaceProperty, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<PO, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _PORepo.SearchFor(lambda1).ToList() select new { item.POID, item.SupplierName, item.Date };

                //check is record exist in selected item
                if (selected.Count() > 0)
                {
                    grdSearchPo.Show();
                    btnClose.Show();

                    grdSearchPo.DataSource = selected;
                }
                else
                {
                    grdSearchPo.DataSource = null;
                }

                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {


            }

        }

        private void SearchSupplier()
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
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
                var selected = from item in _SupplierMasterRepo.SearchFor(lambda1).ToList() select new { item.SupplierMasterID, item.SupplierName, item.SupplierType, item.TelephoneNumber };

                //check is record exist in selected item
                if (selected.Count() > 0)
                {
                    grdPoSupplier.Show();
                    btnClose.Show();

                    grdPoSupplier.DataSource = selected;
                }
                else
                {
                    grdPoSupplier.DataSource = null;
                }

                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {


            }

        }



        private void SearchCompany()
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                GenaricRepository<Company> _genaricrepositorycompany = new GenaricRepository<Company>(new ItrackContext());
                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(Company), "s");
                Expression nameProperty = Expression.Property(argParam, "CompanyName");
                Expression namespaceProperty = Expression.Property(argParam, "CompanyName");

                var val1 = Expression.Constant(txtSearchBox.Text);
                var val2 = Expression.Constant(txtSearchBox.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(namespaceProperty, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<Company, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _genaricrepositorycompany.SearchFor(lambda1).ToList() select new { item.CompanyID, item.CompanyName, item.CompanyAddress };

                //check is record exist in selected item
                if (selected.Count() > 0)
                {
                    grdCompany.Show();
                    btnClose.Show();

                    grdCompany.DataSource = selected;
                }
                else
                {
                    grdCompany.DataSource = null;
                }

                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {


            }

        }



        private void SearchPoItem()
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
                var selected = from item in _ItemMasterRepo.SearchFor(lambda1).ToList() select new { item.ItemsID, item.ItemType, item.CustomFiled1, item.CustomField2 };

                //check is record exist in selected item
                if (selected.Count() > 0)
                {
                    grdSearchPoItem.Show();
                    btnClose.Show();

                    grdSearchPoItem.DataSource = selected;
                }
                else
                {
                    grdSearchPoItem.DataSource = null;
                }

                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {


            }

        }



        void getPo(string ID)
        {
            try
            {
                foreach (var item in getPoID(ID))
                {
                    txtSupplierId.Text = item.SupplierMasterID;
                    txtSupplierName.Text = item.SupplierName;
                    txtSupplierAddress.Text = item.SupplierAddress;
                    txtCompanyCode.Text = item.CompanyCode;
                    txtCompanyName.Text = item.CompanyName;
                    txtCompanyAddress.Text = item.CompamyAddress;
                    txtPoNo.Text = item.POID;
                    cmbCurrency.Text = item.Currency;
                    txtReferenceNo.Text = item.ReferenceNo;
                    txtDate.Text = item.Date;
                    cmbPurchaseType.Text = item.PurchaseType;
                    cmbCountry.Text = item.Country;
                    cmbShippingType.Text = item.ShippingType;
                    txtDeliveryDate.Text = item.DeliveryDate;
                    txtPort.Text = item.port;
                    txtShippingDate.Text = item.ShippingDate;
                    txtHandleBy.Text = item.HandleBy;
                    memCreditTerms.Text = item.CreditTerms;
                    memReturnPolicy.Text = item.ReturnPolicy;
                  

                    grdSearchPo.Hide();
                    txtSearchBox.Hide();
                    btnClose.Hide();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private List<PO> getPoID(string ID)
        {
            try
            {
                return _PORepo.GetAll().Where(u => u.POID == ID).ToList();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
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
                    txtSupplierAddress.Text = item.SupplierAddress;
                    cmbCountry.Text = item.Country;
                    cmbCurrency.Text = item.Currency;
                    cmbPurchaseType.Text = item.SupplierType;
                    txtPort.Text = "None";
                }

                grdPoSupplier.Hide();

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



        void getCompanyDetail(int ID)
        {
            try
            {
                foreach (var item in getCompanyID(ID))
                {
                    _Company.CompanyID = item.CompanyID;
                    txtCompanyName.Text = item.CompanyName;
                    txtCompanyAddress.Text = item.CompanyAddress;
                    txtCompanyCode.Text = item.LocationCode;

                }

                grdCompany.Hide();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }









        private List<Company> getCompanyID(int ID)
        {
            try
            {
                return _CompanyRepository.GetAll().Where(u => u.CompanyID == ID).ToList();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        int getPoCount()
        {
            try
            {
                GenaricRepository<PO> _PoRepo = new GenaricRepository<PO>(new ItrackContext());
                return _PoRepo.GetAll().ToList().Count;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return 0;
            }

        }


        void GetNewCode()
        {
            try
            {

                RunningNo _No = new RunningNo();
                clsRuningNoEngine _Engine = new clsRuningNoEngine();

                GenaricRepository<RunningNo> _RunningNoRepo = new GenaricRepository<RunningNo>(new ItrackContext());
                foreach (var item in _RunningNoRepo.GetAll().ToList().Where(x => x.Venue == "PO"))
                {
                    _No.Prefix = item.Prefix;
                    _No.Starting = item.Starting;
                    _No.Length = item.Length;

                    txtPoNo.Text = _Engine.GenarateNo(_No, getPoCount());


                }


            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }


        private void chkSuspend_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkInactive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmPo_Load(object sender, EventArgs e)
        {
            grdSearchPo.Hide();
            btnClose.Hide();
            txtSearchBox.Hide();
            grdPoSupplier.Hide();
            grdCompany.Hide();
            grdSearchPoItem.Hide();
            txtDate.Text = Convert.ToString(DateTime.Now);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValidPo() == true)
            {
                AddField();
                addPoItems();
            }
        }

        private void txtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
            SearchItem();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtSearchBox.Show();
            btnClose.Show();
            txtSearchBox.Focus();
        }

        private void txtSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdSearchPo.Select();
            }

            else if (e.KeyData == Keys.Escape)
            {
                grdSearchPo.Hide();
            }

        }

        void setPoItems(string poNo) {
            try {
                GenaricRepository<PoItems> _ItemRepo = new GenaricRepository<PoItems>(new ItrackContext());
                var dataSource = from item in _ItemRepo.GetAll().ToList() where item.POID == poNo select new {  item.ItemCode,item.Description, item.Colors, item.Width, item.Unit, item.Qty, item.Price, item.SubTotal};
                grdAdd.DataSource = dataSource;
            }
            
            catch(Exception ex){
            
            }
        }


        private void grdSearchPo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                _PO.POID = gridView2.GetFocusedRowCellValue("POID").ToString();
                setPoItems(_PO.POID);
                getPo(_PO.POID);
                grdPoSupplier.Hide();
                grdCompany.Hide();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            grdSearchPo.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
        }

        private void txtSupplierId_EditValueChanged(object sender, EventArgs e)
        {
            SearchSupplier();
        }

        private void txtSupplierId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdPoSupplier.Select();
            }
            else if (e.KeyData == Keys.Escape)
            {
                grdPoSupplier.Hide();
            }
        }

        private void grdPoSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                _SupplierMaster.SupplierMasterID = gridView3.GetFocusedRowCellValue("SupplierMasterID").ToString();
                getSupplierMaster(_SupplierMaster.SupplierMasterID);
                txtCompanyCode.Focus();
            }
        }

        private void txtCompanyCode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCompanyCode_EditValueChanged(object sender, EventArgs e)
        {
            SearchCompany();
        }

        private void txtCompanyCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdCompany.Select();
            }
            else if (e.KeyData == Keys.Escape)
            {
                grdCompany.Hide();
            }
        }

        private void grdCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                _Company.CompanyID = Convert.ToInt32(gridView4.GetFocusedRowCellValue("CompanyID").ToString());
                getCompanyDetail(_Company.CompanyID);
                txtReferenceNo.Focus();
            }
        }


        void getItemMasterFeild(string ID)
        {
            try
            {

                foreach (var item in GetItemByID(ID))
                {
                    _item.ItemsID = item.ItemsID;
                    txtItemCode.Text = item.ItemsID;
                    txtName.Text = item.ItemType;
                   
                }

                grdSearchPoItem.Hide();
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

        private void grdCompany_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            GetNewCode();
        }

        private void grdSearchPo_Click(object sender, EventArgs e)
        {

        }

        private void txtItemCode_EditValueChanged(object sender, EventArgs e)
        {
            SearchPoItem();
        }

        private void txtItemCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdSearchPoItem.Select();
            }
            else if (e.KeyData == Keys.Escape)
            {
                grdSearchPoItem.Hide();
            }
        }

        private void grdSearchPoItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {

                _item.ItemsID = gridView5.GetFocusedRowCellValue("ItemsID").ToString();
                 getItemMasterFeild(_item.ItemsID);
                
                }
            }

        List<PoItems> lstPoItems = new List<PoItems>();
        private void feedPoItems(PoItems _item) {

           
            try {

                lstPoItems.Add(_item);

                var itemList = from items in lstPoItems select new { items.ItemCode,items.Description,items.Colors, items.Width, items.Unit, items.Price,items.Qty,items.SubTotal };
                grdAdd.DataSource = itemList;
            
            }
            catch(Exception ex){

                Debug.WriteLine(ex.Message);
            }
        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            
            PoItems _item = new PoItems();
            _item.ItemCode = txtItemCode.Text;
            _item.ItemsID = _item.ItemCode;
            _item.Price =Convert.ToDouble( txtPoPrice.Text);
            _item.Qty = Convert.ToInt16(txtQty.Text);
            _item.SubTotal =  _item.Qty * _item.Price;
            _item.Description = txtName.Text;
            _item.Colors = txtColor.Text;
            _item.Width = txtWidth.Text;
            _item.Unit = txtUnit.Text;
            feedPoItems(_item);
        }


        void PrintReport() {
            try {

                rtPO report = new rtPO();


                GenaricRepository<PoItems> _ItemRepo = new GenaricRepository<PoItems>(new ItrackContext());
                var dataSource = from item in _ItemRepo.GetAll().ToList()
                                 where item.POID == txtPoNo.Text
                                 select item;

                report.DataSource = dataSource;

              ReportPrintTool preview = new ReportPrintTool(report);

              preview.ShowPreview();
            }
            catch(Exception ex){
            
            }
        
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            PrintReport();
        }

        private void txtPoNo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void grdAdd_Click(object sender, EventArgs e)
        {

        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }


        
    }
}