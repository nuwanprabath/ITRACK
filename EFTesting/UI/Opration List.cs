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
using System.Linq.Expressions;
using ITRACK.models;
using DevExpress.XtraGrid.Columns;
using EFTesting.ViewModel;
using DevExpress.Office.Utils;

namespace EFTesting.UI
{
    public partial class Opration_List : DevExpress.XtraEditors.XtraForm
    {
        public Opration_List()
        {
            InitializeComponent();
        }

        private void Opration_List_Load(object sender, EventArgs e)
        {

        }

     

        public Opration_List(int _divdinPlanHeader)
        {

            this.DividingPlanHeader = _divdinPlanHeader;
            InitializeComponent();
        }

        public int DividingPlanHeader { get; set; }
        List<OperationListSelection> lst = new List<OperationListSelection>();

        List<OperationListSelection> lstselected = new List<OperationListSelection>();
        private void SearchOperation()
        {

            try
            {

                GenaricRepository<OperationPool> _OperationRepository = new GenaricRepository<OperationPool>(new ItrackContext());
                //create expression 
                 ParameterExpression argParam = Expression.Parameter(typeof(OperationPool), "s");
                Expression nameProperty = Expression.Property(argParam, "OperationPoolID");
                Expression namespaceProperty = Expression.Property(argParam, "OpationName");

              var val1 = Expression.Constant(txtOperationNo.Text);
                var val2 = Expression.Constant(txtOName.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(namespaceProperty, "Contains", null, val2);

                if (chkAnd.Checked == true) {
                    var andExp = Expression.And(e1, e2);

                    // get expresttion to labda objet 
                    var lambda1 = Expression.Lambda<Func<OperationPool, bool>>(andExp, argParam);
                    // pass object to query 
                    var selected = from item in _OperationRepository.SearchFor(lambda1).ToList() select new { item.OperationPoolID, item.OpationName, item.SMV, item.SMVType, item.PartName, item.MachineType };
                    lst.Clear();

                    foreach (var op in selected)
                    {

                        lst.Add(new OperationListSelection(op.OperationPoolID, op.OpationName, op.SMV, 0, false, op.SMVType, op.PartName, "None", op.MachineType));


                    }
                }
                else if (chkOr.Checked == true) {

                    var andExp = Expression.Or(e1, e2);

                    // get expresttion to labda objet 
                    var lambda1 = Expression.Lambda<Func<OperationPool, bool>>(andExp, argParam);
                    // pass object to query 
                    var selected = from item in _OperationRepository.SearchFor(lambda1).ToList() select new { item.OperationPoolID, item.OpationName, item.SMV, item.SMVType, item.PartName, item.MachineType };
                    lst.Clear();

                    foreach (var op in selected)
                    {

                        lst.Add(new OperationListSelection(op.OperationPoolID, op.OpationName, op.SMV, 0, false, op.SMVType, op.PartName, "None", op.MachineType));


                    }
                }
               
               

                
                
                
                
                //check is record exist in selected item
                if (lst.Count() > 0)
                {
                    grdOpList.Show();


                    grdOpList.DataSource = lst;
                    grdOpList.RefreshDataSource();
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


        void updateList(string oNo) {

            foreach (var item in lst.Where(x => x.OprationNo == oNo)) 
            {
                item.Selected = true;
                item.WorkstationNo = Convert.ToInt16(gridView1.GetFocusedRowCellValue("WorkstationNo").ToString());
            }
        
        }


        void getUpdatedList() {

            foreach (var item in lst.Where(x => x.Selected == true))
            {
                //lstselected.Add(new OperationListSelection(item.OprationNo, item.OprationName, item.SMV, item.WorkstationNo,item.Selected));
                MessageBox.Show(item.OprationNo);
                DividingPlanItem _item = new DividingPlanItem();
                if (_item.DividingPlanHeaderID != 0)
                {
                    _item.DividingPlanHeaderID = Convert.ToInt16(this.DividingPlanHeader);
                }
                else
                {
                    _item.DividingPlanHeaderID = DividingPlanHeader;
                }

                
                _item.OprationNo = item.OprationNo;
                _item.OprationName = item.OprationName;
                _item.MachineType = item.MachineType;
                _item.SMVType = item.SMVType;
                _item.SMV = item.SMV;
                _item.PartName = item.PartName;
                _item.OperationRole = item.OperationRole;
                _item.WorkstationNo = item.WorkstationNo;
                GenaricRepository<DividingPlanItem> _pDidingItemRepository = new GenaricRepository<DividingPlanItem>(new ItrackContext());

                _item.OpNo =    _pDidingItemRepository.GetAll().ToList().Where(X => X.DividingPlanHeaderID == _item.DividingPlanHeaderID).Count();

                if (_pDidingItemRepository.Insert(_item) == true) 
                {
                    
                }
                


            }
            MessageBox.Show("Save Sucessfully !", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        
        }

       
        private void txtOperationNo_EditValueChanged(object sender, EventArgs e)
        {
        
            SearchOperation();
    
           
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           
          string oNo=  gridView1.GetFocusedRowCellValue("OprationNo").ToString();
          updateList(oNo);

          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //setSelectedOperation();
            getUpdatedList();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            SearchOperation();
        }

        private void chkAnd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAnd.Checked == true) {
                chkOr.Checked = false;
            }
        }

        private void chkOr_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOr.Checked == true) {
                chkAnd.Checked = false;
            }
        }
    }
}