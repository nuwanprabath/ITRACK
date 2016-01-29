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
using System.IO;
using System.Diagnostics;
using System.Linq.Expressions;
using ITRACK.Validator;

namespace EFTesting.UI
{
    public partial class frmSketchMaster : DevExpress.XtraEditors.XtraForm
    {
        public frmSketchMaster()
        {
            InitializeComponent();
        }

        #region Declaration 
        SketchDefinition _Sketch = new SketchDefinition();
        GenaricRepository<SketchDefinition> _SketchRepository = new GenaricRepository<SketchDefinition>(new ItrackContext());
        GenaricRepository<PartDefinition> _PartRepository = new GenaricRepository<PartDefinition>(new ItrackContext());
        GenaricRepository<Style> _StyleRepository = new GenaricRepository<Style>(new ItrackContext());
        GenaricRepository<SketchDefinition> _EditSketchRepository = new GenaricRepository<SketchDefinition>(new ItrackContext());
        Validator validate = new Validator();

        #endregion

        #region CRUD

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        SketchDefinition AssignValues() {
            try {
                _Sketch.SketchName = txtSketchName.Text;
                _Sketch.ItemType = cmbItemType.Text;
                _Sketch.Remark = txtRemark.Text;
                _Sketch.StyleID = txtStyleNo.Text;
                _Sketch.Image = imageToByteArray(imgprofile.Image);
                return _Sketch;
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
                return null;
            }
        
        }



        private void AddSketch()
        {
            try
            {
                _SketchRepository.Add(AssignValues());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Error - B-0003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// edit sketch for editing sketch values 
        /// </summary>

        private void EditSketch()
        {
            try
            {
                _EditSketchRepository.Edit(AssignValues());
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, "Error - B-0003", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                var val1 = Expression.Constant(txtSearchBox.Text);
                var val2 = Expression.Constant(txtSearchBox.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(namespaceProperty, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<SketchDefinition, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _SketchRepository.SearchFor(lambda1).ToList() select new { item.SketchDefinitionID,item.SketchName,item.StyleID };

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


        void getSketchFeild(int ID)
        {
            try
            {

                foreach (var sketch in GetSketchByID(ID))
                {
                   
                    
                    txtSketchName.Text = sketch.SketchName;
                    txtRemark.Text = sketch.Remark;
                    txtStyleNo.Text = sketch.StyleID;
                    cmbItemType.Text = sketch.ItemType;
               

                    byte[] picture = sketch.Image;
                    imgprofile.Image = Image.FromStream(new MemoryStream(picture));
                    imgprofile.Refresh();

                   






                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0008", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<SketchDefinition> GetSketchByID(int ID)
        {
            try
            {
                return _SketchRepository.GetAll().Where(u => u.SketchDefinitionID == ID).ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - B-0006", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

        }




        public void GetSketchItems(int ID)
        {

            try
            {

                var datasource = from item in GetPartByID(ID) select new { item.PartDefinitionID,item.PartName,item.ItemType,item.Remark };
                grdParts.DataSource = datasource;



            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }


        private List<PartDefinition> GetPartByID(int ID)
        {
            try
            {

                return _PartRepository.GetAll().Where(u => u.SketchDefinitionID == ID).ToList();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error - C-0004", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

        }


        #endregion

        #region Validation

        public bool isValidSketchMaster()
        {
            if (!validate.isPresent(txtStyleNo, "Style Number"))
            {
                return false;
            }

            if (!validate.isPresent(txtSketchName, "Sketch Name"))
            {
                return false;
            }

            if (!validate.isPresent(cmbItemType, "Item Type"))
            {
                return false;
            }

            return true;
        }


        #endregion



        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isValidSketchMaster() == true)
            {
                AddSketch();
            }            
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditSketch();
        }

        private void frmSketchMaster_Load(object sender, EventArgs e)
        {
            grdSearch.Hide();
            btnClose.Hide();
            txtSearchBox.Hide();
        }

        private void txtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
            SearchSketch();
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
            _Sketch.SketchDefinitionID =Convert.ToInt16(gridView1.GetFocusedRowCellValue("SketchDefinitionID").ToString());
            getSketchFeild(_Sketch.SketchDefinitionID);
            GetSketchItems(_Sketch.SketchDefinitionID);
            grdSearch.Hide();
            txtSearchBox.Hide();
            btnClose.Hide();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtSearchBox.Show();
            btnClose.Show();
        }
    }
}