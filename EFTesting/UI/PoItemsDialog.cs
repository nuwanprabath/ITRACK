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
using EFTesting.ViewModel;
using ITRACK.models;
using ITRACK.Validator;

namespace EFTesting.UI
{
    public partial class PoItemsDialog : DevExpress.XtraEditors.XtraForm
    {
        public PoItemsDialog()
        {
            InitializeComponent();
        }

        PurchaseOrderItems PoItems { get; set; }
        public PoItemsDialog(PurchaseOrderItems item,frmPurchaseOrder PoUI) {
            this.PoItems = item;
            this.POUI = PoUI;
            InitializeComponent();

            SetValues();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PoItemsDialog_FormClosing);
        }

        PurchaseHeaderVM Pvm = new PurchaseHeaderVM();
        GenaricRepository<PurchaseOrderItems> _PORepository = new GenaricRepository<PurchaseOrderItems>(new ItrackContext());
        GenaricRepository<PurchaseOrderItems> _PORepositorynew = new GenaricRepository<PurchaseOrderItems>(new ItrackContext());
        PurchaseOrderItems _PoItem = new PurchaseOrderItems();
        frmPurchaseOrder POUI;


        private PurchaseOrderItems AssignPoItems() {
            try {
               
                PurchaseOrderItems _PoItems = new PurchaseOrderItems();
                _PoItems.PurchaseOrderID = txtPoNo.Text;
                _PoItems.Color = txtColorCode.Text;
                _PoItems.Size = txtSize.Text;
                _PoItems.Length = txtLength.Text;
                _PoItems.Quantity = Convert.ToInt16(txtQuntity.Text);
                _PoItems.PurchaseOrderHeaderID = _PoItems.PurchaseOrderID;
                return _PoItems;
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "Error - B-0002", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        
        }

        private void SetValues (){
          txtPoNo.Text =   PoItems.PurchaseOrderHeaderID;
          txtSize.Text = PoItems.Size;
          txtColorCode.Text = PoItems.Color;
          txtLength.Text = PoItems.Length;
          txtQuntity.Text = Convert.ToString(PoItems.Quantity);
          grdSearchPo.Hide();
          btnAdd.Enabled = false;
        }

        private void AddPOItems()
        {
            try
            {
                GenaricRepository<PurchaseOrderItems> _PoRepository = new GenaricRepository<PurchaseOrderItems>(new ItrackContext());
                _PoRepository.Add(AssignPoItems());
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void EditPOItems()
        {
            try
            {

                _PORepositorynew.Edit(AssignPoItems());
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        #region CRUD

        private void SearchPo()
        {
            try
            {
                Pvm.SearchPoWithoutClose(grdSearchPo, txtPoNo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region Diclaration

        Validator validate = new Validator();

        #endregion

        #region Validation

        public bool isValidPoItem()
        {
            if (!validate.isPresent(txtPoNo, "Po Number"))
            {
                return false;
            }

            if (!validate.isPresent(txtSize, "Size"))
            {
                return false;
            }

            if (!validate.isPresent(txtColorCode, "Color Code"))
            {
                return false;
            }

            if (!validate.isPresent(txtLength, "Length"))
            {
                return false;
            }

            if (!validate.isPresent(txtQuntity, "Quntity"))
            {
                return false;
            }

            return true;


        }


        #endregion



        private void txtPoNo_EditValueChanged(object sender, EventArgs e)
        {
            SearchPo();
        }

        private void txtPoNo_KeyDown(object sender, KeyEventArgs e)
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

        private void grdSearchPo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                txtPoNo.Text = gridView2.GetFocusedRowCellValue("PurchaseOrderHeaderID").ToString();
                grdSearchPo.Hide();
            
            }
        }

        private void PoItemsDialog_Load(object sender, EventArgs e)
        {
            grdSearchPo.Hide();
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValidPoItem() == true)
            {
                AddPOItems();
                frmPurchaseOrder PO_ = new frmPurchaseOrder(txtPoNo.Text);
                PO_.RefreshGrid();
                this.Close();
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditPOItems();
            frmPurchaseOrder PO_ = new frmPurchaseOrder(txtPoNo.Text);
            PO_.RefreshGrid();
        }

        private void PoItemsDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            AddPOItems();
            txtSize.Text = "";
            txtColorCode.Text = "";
            txtLength.Text = "";
            txtQuntity.Text = "";
            txtSize.Focus();
        }
    }
}