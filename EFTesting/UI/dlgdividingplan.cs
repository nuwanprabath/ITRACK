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
using ITRACK.Validator;

namespace EFTesting.UI
{
    public partial class dlgdividingplan : DevExpress.XtraEditors.XtraForm
    {
        public dlgdividingplan()
        {
            InitializeComponent();
        }


        public string DividingPlanNo { get; set; }

        public string StyleNo { get; set; }

        public string LineNo { get; set; }

        public string PPH { get; set; }

        public string Target { get; set; }

        public string TotalEmployee { get; set; }


        List<DividingPlanTemp> lstDividing = new List<DividingPlanTemp>();

        public dlgdividingplan(string _dividingPlanNo ,string _styleNo,string _lineNo,string _pph , string _target ,string _totalEmployee,List<DividingPlanTemp> lst ) {
          
            InitializeComponent();

            this.DividingPlanNo = _dividingPlanNo;
            this.StyleNo = _styleNo;
            this.LineNo = _lineNo;
            this.PPH = _pph;
            this.Target = _target;
            this.TotalEmployee = _totalEmployee;
            this.lstDividing = lst;
        }

        void saveOparation() {
            try {

                GenaricRepository<DividingPlanHeader> _dHeaderRepo = new GenaricRepository<DividingPlanHeader>(new ItrackContext());
                DividingPlanHeader dHeader = new DividingPlanHeader();
                dHeader.LineNo = txtLineNo.Text;
                dHeader.ProductionPerHour =Convert.ToInt16( txtProductionPerHour.Text);
                dHeader.StyleID = txtStyleNo.Text;
                dHeader.TotalEmployee =Convert.ToInt16( txtTotalEmployee.Text);
                dHeader.Target =Convert.ToInt16(txtTarget.Text);

                _dHeaderRepo.Add(dHeader);

                dHeader.DividingPlanheaderID = _dHeaderRepo.GetAll().ToList().Last().DividingPlanheaderID;
                
                
                
                for (int i = 0; i < gridView3.RowCount; i++)
                {
                   
                    GenaricRepository<DividingPlanItem> _dItemRepo = new GenaricRepository<DividingPlanItem>(new ItrackContext());
                    
                    DividingPlanItem dItem = new DividingPlanItem();
                   
                    dItem.OprationNo = gridView3.GetRowCellValue(i, "OprationNo").ToString();
                    dItem.OprationName = gridView3.GetRowCellValue(i, "OprationName").ToString();
                    dItem.SMVType = gridView3.GetRowCellValue(i, "SMVType").ToString();
                    dItem.MachineType = gridView3.GetRowCellValue(i, "MachineType").ToString();
                    dItem.SMV =Convert.ToDouble( gridView3.GetRowCellValue(i, "SMV").ToString());
                    dItem.DividingPlanHeaderID = dHeader.DividingPlanheaderID;
                    dItem.PartName = gridView3.GetRowCellValue(i, "PartName").ToString();
                    
                    string status = gridView3.GetRowCellValue(i, "Selected").ToString();
                    GenaricRepository<DividingPlanTemp> _dItemTempRepo = new GenaricRepository<DividingPlanTemp>(new ItrackContext());
                    DividingPlanTemp dTemp = new DividingPlanTemp();
                    dTemp.DividingPlanTempID = Convert.ToInt16(gridView3.GetRowCellValue(i, "DividingPlanTempID").ToString());
                    if (status == "True")
                    {
                        _dItemRepo.Insert(dItem);
                        _dItemTempRepo.Delete(dTemp);
                    }
                    else { 
                        
                    }

                    
                }
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
        }


        #region Diclaration

        Validator validator = new Validator();

        #endregion


        #region Validation

        public bool isValidDividingplan()
        {


            if (!validator.isPresent(txtDividingPlanNo,"Dividing Plan Number"))
            {
                return false;
            }

            if (!validator.isPresent(txtStyleNo,"Style Number"))
            {
                return false;
            }

            if (!validator.isPresent(txtLineNo,"Line Number"))
            {
                return false;
            }

            if (!validator.isPresent(txtProductionPerHour, "Production Per Hour"))
            {
                return false;
            }

            if (!validator.isPresent(txtTarget, "Target"))
            {
                return false;
            }

            if (!validator.isPresent(txtTotalEmployee, "Total Employee"))
            {
                return false;
            }


            return true;
        }

        #endregion

        private void dlgdividingplan_Load(object sender, EventArgs e)
        {
            var selected = from item in lstDividing select new { item.DividingPlanTempID, item.OprationNo, item.OprationName, item.SMVType, item.MachineType, item.SMV, item.Selected };
            
            grdOperationList.DataSource = lstDividing;
            gridView3.OptionsBehavior.Editable = true;
            gridView3.Columns["LineNo"].Visible = false;
            gridView3.Columns["TotalEmployee"].Visible = false;
            gridView3.Columns["Target"].Visible = false;
            gridView3.Columns["ProductionPerHour"].Visible = false;
            gridView3.Columns["StyleID"].Visible = false;

            txtDividingPlanNo.Text = this.DividingPlanNo;
            txtLineNo.Text = this.LineNo;
            txtProductionPerHour.Text = this.PPH;
            txtTotalEmployee.Text = this.TotalEmployee;
            txtStyleNo.Text = this.StyleNo;


        }

        private void grdOperationList_Click(object sender, EventArgs e)
        {
          
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (isValidDividingplan() == true)
            {

                saveOparation();
                this.Close();
            }
            
            
        }
    }
}