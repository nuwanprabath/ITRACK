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
using EFTesting.ViewModel;
using DevExpress.Office.Utils;
using DevExpress.XtraGrid.Views.Grid;
using EFTesting.Reports.Stock_Report;
using DevExpress.XtraReports.UI;

namespace EFTesting.UI
{
    public partial class frmGRN : DevExpress.XtraEditors.XtraForm
    {
        public frmGRN()
        {
            InitializeComponent();
        }

        #region Diclaration

        Validator validate = new Validator();

        #endregion

        #region CUID

        GenaricRepository<GRN> _GRNRepo = new GenaricRepository<GRN>(new ItrackContext());
        GenaricRepository<PO> _PORepo = new GenaricRepository<PO>(new ItrackContext());
        GenaricRepository<PoItems> _PoItemsRepo = new GenaricRepository<PoItems>(new ItrackContext());
        GRN _GRN = new GRN();
        PO _PO = new PO();

        private GRN AssingGRN()
        {
            _GRN.LocationCode = cmbLocationCode.Text;
            _GRN.GRNID = txtGrnNo.Text;
            _GRN.Date = txtGrnDate.Text;
            _GRN.POID = txtPo.Text;
            _GRN.PoDate = txtPoDate.Text;
            _GRN.Supplier = txtSupplier.Text;
            _GRN.SupplierCode = txtSupplierCode.Text;
            _GRN.SupplierInvoiceNo = txtSupplierInvoiceNo.Text;
            _GRN.InvoiceDate = cmbInvoiceDate.Text;
            _GRN.ShipmentType = cmbShipmentType.Text;
            _GRN.Currency = cmbCurrency.Text;
            _GRN.ExchangeRate = txtExchangeRate.Text;



            return _GRN;

        }


        private void AddField()
        {
            try
            {
                GenaricRepository<GRN> _GRNRepo = new GenaricRepository<GRN>(new ItrackContext());
                _GRNRepo.Add(AssingGRN());
            }
            catch (Exception ex)
            {

            }
        }

        private void feedLedger(GrnItems _item) {
            try {

                StockLedger _ledger = new StockLedger();
                _ledger.ItemCode = _item.ItemCode;
                _ledger.ItemType = "";
                _ledger.TransactionBy = "Admin";
                _ledger.TransactionTime = DateTime.Now;
                _ledger.TransactionType = "GRN";
                _ledger.DocNo = _item.GRNID;
                _ledger.GetTransactionID();
                
                
                _ledger.FeedLedger(_ledger);
            }
            catch (Exception ex) {

            }
        }
            
            


        private void SearchGRN()
        {
            try
            {

                GenaricRepository<GRN> _GRNRepo = new GenaricRepository<GRN>(new ItrackContext());
                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(GRN), "s");
                Expression nameProperty = Expression.Property(argParam, "GRNID");
                Expression namespaceProperty = Expression.Property(argParam, "POID");

                var val1 = Expression.Constant(txtSearchBox.Text);
                var val2 = Expression.Constant(txtSearchBox.Text);
                //expresttion 1 
               Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(namespaceProperty, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<GRN, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _GRNRepo.SearchFor(lambda1).ToList() select new { item.GRNID, item.POID, item.LocationCode, item.Date, item.Supplier, item.SupplierCode };

                //check is record exist in selected item
                if (selected.Count() > 0)
                {
                    grdSearchGRN.Show();
                    btnClose.Show();

                    grdSearchGRN.DataSource = selected;
                }
                else
                {
                    grdSearchGRN.DataSource = null;
                }

                
            }
            catch (Exception ex)
            {


            }

        }



        private void SearchPo()
        {
            try
            {
                
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
                    grdPOSearch.Show();
                    btnClose.Show();

                    grdPOSearch.DataSource = selected;
                }
                else
                {
                    grdPOSearch.DataSource = null;
                }

              
            }
            catch (Exception ex)
            {


            }

        }

        void getGrn(string ID)
        {
            try
            {
                foreach (var item in getGrnID(ID))
                {
                    cmbLocationCode.Text = item.LocationCode;
                    txtGrnNo.Text = item.GRNID;
                    txtGrnDate.Text = item.Date;
                    txtPo.Text = item.POID;
                    txtPoDate.Text = item.PoDate;
                    txtSupplier.Text = item.Supplier;
                    txtSupplierCode.Text = item.SupplierCode;
                    txtSupplierInvoiceNo.Text = item.SupplierInvoiceNo;
                    cmbInvoiceDate.Text = item.InvoiceDate;
                    cmbShipmentType.Text = item.ShipmentType;
                    cmbCurrency.Text = item.Currency;
                    txtExchangeRate.Text = item.ExchangeRate;

                }

                grdPOSearch.Hide();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private List<GRN> getGrnID(string ID)
        {
            try
            {
                return _GRNRepo.GetAll().Where(u => u.GRNID == ID).ToList();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        void getGRN(string ID)
        {
            try
            {
                foreach (var item in getGrnID(ID))
                {
                    cmbLocationCode.Text = item.LocationCode;
                    txtGrnNo.Text = item.GRNID;
                    txtGrnDate.Text = item.Date;
                    txtPo.Text = item.POID;
                    txtPoDate.Text = item.PoDate;
                    txtSupplier.Text = item.Supplier;
                    txtSupplierCode.Text = item.SupplierCode;
                    txtSupplierInvoiceNo.Text = item.SupplierInvoiceNo;
                    cmbInvoiceDate.Text = item.InvoiceDate;
                    cmbShipmentType.Text = item.ShipmentType;
                    cmbCurrency.Text = item.Currency;
                    txtExchangeRate.Text = item.ExchangeRate;

                    grdPOSearch.Hide();
                    txtSearchBox.Hide();
                    btnClose.Hide();
                }
               
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        

        }


        void getPO (string ID)
        {
         try
            {

                foreach (var item in getPOID(ID))
                {
                    txtPo.Text = item.POID;
                    txtPoDate.Text = item.Date;
                    txtSupplier.Text = item.SupplierName;
                    txtSupplierCode.Text = item.SupplierMasterID;
                    cmbShipmentType.Text = item.ShippingType;
                    cmbCurrency.Text = item.Currency;
                    txtPort.Text = item.port;
                    
                }

                grdPOSearch.Hide();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        
        
        }


         private List<PO> getPOID(string ID)
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


         int getPoCount()
         {
             try
             {
                 GenaricRepository<GRN> _GRNRepo = new GenaricRepository<GRN>(new ItrackContext());
                 return _GRNRepo.GetAll().ToList().Count;
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
                 foreach (var item in _RunningNoRepo.GetAll().ToList().Where(x => x.Venue == "GRN"))
                 {
                     _No.Prefix = item.Prefix;
                     _No.Starting = item.Starting;
                     _No.Length = item.Length;

                     txtGrnNo.Text = _Engine.GenarateNo(_No, getPoCount());


                 }


             }
             catch (Exception ex)
             {
                 Debug.WriteLine(ex.Message);
             }

         }



        #endregion


         private void addGrnItems()
         {
             try
             {
                 GenaricRepository<GrnItems> _GrnItemsRepo = new GenaricRepository<GrnItems>(new ItrackContext());
                 GrnItems _grnitems = new GrnItems();

                 foreach (var item in lstGrnItems)
                 {
                     _grnitems.ItemCode = item.ItemCode;
                     _grnitems.Description = item.Description;
                     _grnitems.Color = item.Color;
                     _grnitems.Width = item.Width;
                     _grnitems.Unit = item.Unit;
                     _grnitems.Qty = item.Qty;
                     _grnitems.ReceivedQty = item.ReceivedQty;
                     _grnitems.UnitPrice = item.UnitPrice;
                     _grnitems.ReceivedPrice = item.ReceivedPrice;
                     _grnitems.LineDiscount = item.LineDiscount;
                     _grnitems.waistadeQty = item.waistadeQty;
                     _grnitems.SubTotal = item.SubTotal;
                     _grnitems.GRNID = txtGrnNo.Text;
                     _GrnItemsRepo.Add(_grnitems);
                      feedLedger(_grnitems);
                 }

                 
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
             

         }


        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {

        }

        private void txtSupplierType_EditValueChanged(object sender, EventArgs e)
        {
            SearchPo();
        }


        List<GrnItems> lstGrnItems = new List<GrnItems>();
        private void feedGrnItems()
        {
            try
            {
                var itemList = from items in lstGrnItems select items;
                grdGrnAdd.DataSource = itemList;
                gridView3.Columns["GRN"].Visible = false;
                gridView3.Columns["GRNID"].Visible = false;

            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
            }
        }


        void getPoItem(string ID)
        {
            try
            {
               
                foreach (var item in getPoItemsID(ID))
                {

                    GrnItems gItems = new GrnItems();
                    gItems.GRNID = txtGrnNo.Text;
                    gItems.ItemCode = item.ItemCode;
                    gItems.Description = item.Description;
                    gItems.Color = item.Colors;
                    gItems.Width = item.Width;
                    gItems.Unit = item.Unit;
                    gItems.Qty = item.Qty;
                    gItems.ReceivedQty = item.Qty;
                    gItems.UnitPrice = item.Price;
                    gItems.waistadeQty = 0;
                    gItems.LineDiscount = 0;
                    gItems.SubTotal = item.SubTotal;


                    
                    lstGrnItems.Add(gItems);
                    
                }

                feedGrnItems();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        
        
        }
        


       


        private List<PoItems> getPoItemsID(string ID)
        {
            try
            {
                return _PoItemsRepo.GetAll().Where(x => x.POID == ID).ToList();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }




        private void txtSupplierType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdPOSearch.Select();
            }
            else if (e.KeyData == Keys.Escape)
            {
                grdPOSearch.Hide();
            }
        }

        private void grdPOSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                 if (e.KeyData == Keys.Enter)
            {
                _PO.POID = gridView4.GetFocusedRowCellValue("POID").ToString();
                getPO(_PO.POID);
                getPoItem(_PO.POID);
                     
            }                
                 
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            GetNewCode();
        }

        private void txtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
            SearchGRN();
        }

        private void txtSearchBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdSearchGRN.Select();
            }

            else if (e.KeyData == Keys.Escape)
            {
                grdSearchGRN.Hide();
            }
        }





        #region Conditional Update

        void Update(string _itemcode,double _rPrice,double _qty,double _dic) {
            try
            {
                foreach (var item in lstGrnItems.Where(x=>x.ItemCode==_itemcode))
                
                {
                    item.SubTotal = _rPrice * _qty - _dic;
                }

                grdAdd.DataSource = lstGrnItems;



            }
            catch (Exception ex)
            {

            }
        
        }



        #endregion






        void setGrnItems(string GrnNo)
        {
            try
            {
                GenaricRepository<GrnItems> _GrnItemsRepo = new GenaricRepository<GrnItems>(new ItrackContext());
              //var dataSource = from item in _GrnItemsRepo.GetAll().ToList() where item.GRNID == GrnNo select new {item.ItemCode};


                var data = _GrnItemsRepo.GetAll().Where(x => x.GRNID == GrnNo).ToList();
                grdGrnAdd.DataSource = data;
                gridView3.Columns["GRN"].Visible = false;
                gridView3.Columns["GRNID"].Visible = false;
            }

            catch (Exception ex)
            {

            }
        }

        private void grdSearchGRN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                _GRN.GRNID = gridView2.GetFocusedRowCellValue("GRNID").ToString();
                setGrnItems(_GRN.GRNID);
                getGRN(_GRN.GRNID);
                grdSearchGRN.Hide();
                
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddField();
            addGrnItems();
        }


        void initilizeValues() {
            GetNewCode();
            txtGrnDate.Text = DateTime.Now.ToShortDateString();

            GenaricRepository<Company> _CompanyRepository = new GenaricRepository<Company>(new ItrackContext());

            foreach (var item in _CompanyRepository.GetAll().Where(x => x.isDefaultCompany == true))
            {
                cmbLocationCode.Text = item.LocationCode;

            }

        
        }
        private void frmGRN_Load(object sender, EventArgs e)
        {
            grdPOSearch.Hide();
            grdSearchGRN.Hide();
            btnClose.Hide();
            txtSearchBox.Hide();
            initilizeValues();


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtSearchBox.Show();
            btnClose.Show();
            txtSearchBox.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            grdSearchGRN.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
        }

        private void grdSearchGRN_Click(object sender, EventArgs e)
        {

        }

        private void grdGrnAdd_DataSourceChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("Datasource Changed");
        }

        private void grdGrnAdd_EditorKeyDown(object sender, KeyEventArgs e)
        {
           
        }


       


        private void grdGrnAdd_TabIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("Datasource Changed");
        }

        private void gridView3_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {


            if (e.FocusedColumn.Name == "colReceivedQty") {
                Debug.WriteLine("Datasource Changed");
                
            }


        }

        double _reQty = 0;
        double _rQty = 0;
        double _rPrice = 0;
        double _lDisc = 0;

        private void gridView3_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name == "colReceivedQty")
            {
                Debug.WriteLine(e.Value);
            }
            
        }

        private void gridView3_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {


            _reQty = Convert.ToDouble(gridView3.GetFocusedRowCellValue("ReceivedQty").ToString());

            _lDisc = Convert.ToDouble(gridView3.GetFocusedRowCellValue("LineDiscount").ToString());

            _rPrice = Convert.ToDouble(gridView3.GetFocusedRowCellValue("ReceivedPrice").ToString());

            if (e.Column.Name == "colReceivedQty")
            {

                _reQty = Convert.ToDouble(e.Value);
            }
            else if (e.Column.Name == "colLineDiscount")
            {
                _lDisc = Convert.ToDouble(e.Value);
            }
            else if (e.Column.Name == "colReceivedPrice")
            {

                _rPrice =Convert.ToDouble( e.Value);
            }

            string itemCode = gridView3.GetFocusedRowCellValue("ItemCode").ToString();

            Update(itemCode, _rPrice, _reQty, _lDisc);


        }

        void PrintReport()
        {
            try
            {
                rtGRN report = new rtGRN();

                GenaricRepository<GrnItems> _ItemRepo = new GenaricRepository<GrnItems>(new ItrackContext());
                var dataSource = from item in _ItemRepo.GetAll().ToList()
                                 where item.GRNID == txtGrnNo.Text
                                 select item;

                report.DataSource = dataSource;

              ReportPrintTool preview = new ReportPrintTool(report);

              preview.ShowPreview();
            }
            catch(Exception ex){
            
            }
        
        }
            
        


        private void grdPOSearch_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            PrintReport();
        }
        }
}