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
    public partial class frmParts : DevExpress.XtraEditors.XtraForm
    {
        public frmParts()
        {
            InitializeComponent();
        }

        #region Initilization 

        PartDefinition _Part = new PartDefinition();
        GenaricRepository<PartDefinition> _PartRepository = new GenaricRepository<PartDefinition>(new ItrackContext());
        GenaricRepository<Style> _StyleRepository = new GenaricRepository<Style>(new ItrackContext());
        GenaricRepository<PartDefinition> _EditPartRepository = new GenaricRepository<PartDefinition>(new ItrackContext());
        GenaricRepository<OperationPool> _OperationRepository = new GenaricRepository<OperationPool>(new ItrackContext());
        GenaricRepository<StyleOperation> _StyleOperationRepository = new GenaricRepository<StyleOperation>(new ItrackContext());
        GenaricRepository<StyleOperation> _EditStyleOperationRepository = new GenaricRepository<StyleOperation>(new ItrackContext());
        GenaricRepository<SketchDefinition> _SketchRepository = new GenaricRepository<SketchDefinition>(new ItrackContext());
        OperationPool _Operation =new OperationPool();
        StyleOperation _StyleOperation = new StyleOperation();
        
        #endregion 

        #region CRUD

        /// <summary>
        /// assign part values 
        /// </summary>
        /// <returns></returns>
        PartDefinition AssignPart() {
            try {
              
                _Part.PartName = txtPartName.Text;
                _Part.Remark = txtRemark.Text;
                _Part.ItemType = cmbItemType.Text;
                return _Part; 
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Assign operation values 
        /// </summary>
        /// <returns></returns>
        StyleOperation AssignStyleoperation() {
            try {
                _StyleOperation.SMV = Convert.ToDouble(txtSMV.Text);
             //   _StyleOperation.OperationPoolID = _Operation.OperationPoolID;
                _StyleOperation.PartDefinitionID =Convert.ToString(_Part.PartDefinitionID);
                return _StyleOperation;
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
                return null;
            }
        
        }

        /// <summary>
        /// add part using part repository 
        /// </summary>

        private void AddPart()
        {
            try
            {
                _PartRepository.Add(AssignPart());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Error - B-0003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// edit part for editing part values 
        /// </summary>

        private void EditPart()
        {
            try
            {
                _EditPartRepository.Edit(AssignPart());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Error - B-0003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /// <summary>
        /// edit part for editing part values 
        /// </summary>

        private void AddSyleOperation()
        {
            try
            {
                if (isOprationAlreadyExist(_Operation.OperationPoolID ,Convert.ToString( _Part.PartDefinitionID)) == true)
                {
                    MessageBox.Show("Opration Already Exist !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    _StyleOperationRepository.Add(AssignStyleoperation());
                }
               
               // GetStyleOperationByID(Convert.ToString(_Part.PartDefinitionID));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Error - B-0003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void EditSyleOperation()
        {
            try
            {
                _EditStyleOperationRepository.Add(AssignStyleoperation());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Error - B-0003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        //search operation 

        private void Searchoperation()
        {

            try
            {


                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(OperationPool), "s");
                Expression nameProperty = Expression.Property(argParam, "OperationPoolID");
                Expression namespaceProperty = Expression.Property(argParam, "OpationName");

                var val1 = Expression.Constant(txtSearchBox.Text);
                var val2 = Expression.Constant(txtSearchBox.Text);
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
                    grdSearchOperation.Show();
                    btnClose.Show();

                    grdSearchOperation.DataSource = selected;
                }
                else
                {
                    grdSearchOperation.DataSource = null;
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error - B-0007", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        // serach part definition 

        private void SearchPart()
        {

            try
            {


                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(PartDefinition), "s");
                Expression nameProperty = Expression.Property(argParam, "PartName");
              

                var val1 = Expression.Constant(txtSearchBox.Text);
                var val2 = Expression.Constant(txtSearchBox.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(nameProperty, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<PartDefinition, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _PartRepository.SearchFor(lambda1).ToList() select new { item.PartDefinitionID,item.PartName,item.Remark};

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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error - B-0007", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // get part feilds 

        void getPartFeild(int ID)
        {
            try
            {
                
                foreach (var part in GetPartByID(ID))
                {

                    txtPartName.Text = part.PartName;
                    txtRemark.Text = part.Remark;
                    cmbItemType.Text = part.ItemType;
                    _Part.PartDefinitionID = part.PartDefinitionID;
                    txtSketchName.Text = part.SketchDefinition.SketchName;
                    _Part.SketchDefinitionID = part.SketchDefinitionID;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

         // get part by id 
        private List<PartDefinition> GetPartByID(int ID)
        {
            try
            {
                return _PartRepository.GetAll().Where(u => u.PartDefinitionID == ID).ToList() ;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

        }







        /// <summary>
        /// get style related opration of selected part by part ID 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        private void GetStyleOperationByID(string ID)
        {
            try
            {
            //    var oprationList = from item in _StyleOperationRepository.GetAll().Where(u => u.PartDefinitionID == ID).ToList() select new { item.OperationPoolID,item.SMV,item.OperationPool.OpationName,item.OperationPool.SMVType};
                

             //   if (oprationList.Count() > 0)
              //  {
                  

              //      grdOpration.DataSource = oprationList;
             //   }
              ///  else
            //    {
               //     grdSearch.DataSource = null;
              //  }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }

        }




        private void SearchSketch()
        {

            try
            {


                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(SketchDefinition), "s");
                Expression nameProperty = Expression.Property(argParam, "SketchName");
                Expression namespaceProperty = Expression.Property(argParam, "SketchName");

                var val1 = Expression.Constant(txtSketchName.Text);
                var val2 = Expression.Constant(txtSketchName.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(namespaceProperty, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<SketchDefinition, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _SketchRepository.SearchFor(lambda1).ToList() select new { item.SketchDefinitionID, item.SketchName, item.StyleID };

                //check is record exist in selected item
                if (selected.Count() > 0)
                {
                    grdSearchSketch.Show();
                    

                    grdSearchSketch.DataSource = selected;
                }
                else
                {
                    grdSearchSketch.DataSource = null;
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error - B-0007", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }






        public bool isOprationAlreadyExist(string ID,string partID) {

            try {
                //var oprationList = from item in _StyleOperationRepository.GetAll().Where(u => u.OperationPoolID == ID && u => u.OperationPoolID == ID ).ToList() select new { item.OperationPoolID, item.SMV, item.OperationPool.OpationName, item.OperationPool.SMVType };

               // var oprationList = from item in _StyleOperationRepository.GetAll().AsEnumerable()
                             //      where
                                 //      item.OperationPoolID == ID && item.PartDefinitionID == partID
                                 //  select item;

                
              //  if (oprationList.Count() > 0) {
                //    return true;
              //  }
              //  else {
                 //   return false;
              //  }

                return true;
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
                return false;
              
            }
        }






        #endregion

        #region Diclaration

        Validator validate = new Validator();

        #endregion

        #region Validation

        public bool isValidHeader()
        {
            if (!validate.isPresent(txtPartName, "Part Name"))
            {
                return false;
            }

            if (!validate.isPresent(txtSketchName, "Sketch Name"))
            {
                return false;
            }

            if (!validate.isPresent(cmbItemType, "Irem Type"))
            {
                return false;
            }

            return true;
        }

        public bool isValidPart()
        {

            if (!validate.isPresent(txtOperationName, "Operation Name"))
            {
                return false;
            }

            if (!validate.isPresent(cmbSMVType, "Operation Type"))
            {
                return false;
            }

            if (!validate.isPresent(txtSMV, "SMV"))
            {
                return false;
            }

            return true;
        }


        #endregion
        private void frmParts_Load(object sender, EventArgs e)
        {
            grdSearchOperation.Hide();
            grdSearchSketch.Hide();
            grdSearch.Hide();
            btnClose.Hide();
            txtSearchBox.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValidHeader() == true)
            {
                AddPart();
            }
            
            
        }

        private void txtPartName_EditValueChanged(object sender, EventArgs e)
        {
            Searchoperation();
        }

        private void txtPartName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdSearchOperation.Select();
            }
            else if (e.KeyData == Keys.Escape)
            {
                grdSearchOperation.Hide();
             

            }
        }

        private void grdSearchOperation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _Operation.OperationPoolID = gridView1.GetFocusedRowCellValue("OperationPoolID").ToString();
                txtOperationName.Text = gridView1.GetFocusedRowCellValue("OpationName").ToString();
                cmbSMVType.Text = gridView1.GetFocusedRowCellValue("SMVType").ToString();
                txtSMV.Text = gridView1.GetFocusedRowCellValue("SMV").ToString();
               grdSearchOperation.Hide();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditPart();
        }

        private void txtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
            SearchPart();
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
                txtSearchBox.Hide();
                btnClose.Hide();

            }
        }

        private void grdSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _Part.PartDefinitionID = Convert.ToInt16( gridView3.GetFocusedRowCellValue("PartDefinitionID").ToString());
               // getOperationFeild(_Operation.OperationPoolID);
                getPartFeild(_Part.PartDefinitionID);
                GetStyleOperationByID(Convert.ToString(_Part.PartDefinitionID));
                grdSearch.Hide();
                txtSearchBox.Hide();
                btnClose.Hide();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtSearchBox.Show();
            btnClose.Show();
            txtSearchBox.Focus();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (isValidPart() == true)
            {
                AddSyleOperation();
            }
                      
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            SearchSketch();
        }

        private void txtSketchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down)
            {
                grdSearchSketch.Select();
            }
            else if (e.KeyData == Keys.Escape)
            {
                grdSearchSketch.Hide();
             
                
            }
        }

        private void grdSearchSketch_KeyDown(object sender, KeyEventArgs e)
        {
            _Part.SketchDefinitionID = Convert.ToInt16(gridView4.GetFocusedRowCellValue("SketchDefinitionID").ToString());
            txtSketchName.Text= gridView4.GetFocusedRowCellValue("SketchName").ToString();
            grdSearchSketch.Hide();
        }
    }
}