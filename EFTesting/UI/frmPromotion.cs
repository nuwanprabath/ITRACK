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
using DevExpress.Office.Utils;

namespace EFTesting.UI
{
    public partial class frmPromotion : DevExpress.XtraEditors.XtraForm
    {
        public frmPromotion()
        {
            InitializeComponent();
        }


        public EmployeeMaster EmpUi { get; set; }

        public Promotion Promotion { get; set; }

        public frmPromotion(string _empId) {

            this.EmpID = _empId;
            InitializeComponent();
        
        }

        public frmPromotion(Promotion pr,EmployeeMaster _empUi) {

            InitializeComponent();
            this.Promotion = pr;
            this.EmpUi = _empUi;
            setPromotionValues();
        }

        Promotion Pr = new Promotion();
        int PID { get; set; }
        public string EmpID { get; set; }

        Promotion AssignValues() {
            try
            {
                GenaricRepository<Promotion> _PromotionRepository = new GenaricRepository<Promotion>(new ItrackContext());
                Pr.PromotionID = PID;
                Pr.FromDesignation = txtFromDesignation.Text;
                Pr.ToDesignation = txtToDesigation.Text;
                Pr.PromotedDate =Convert.ToDateTime( txtFromotedDate.Text);

                Pr.JobDescription = txtJobDescription.Text;
                Pr.Remark = txtRemark.Text;
                Pr.EmployeeID = EmpID;
                return Pr;
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return null;
            
            }
        
        }

        void setPromotionValues() 
        {

            try 
            {
                txtFromDesignation.Text = Promotion.FromDesignation;
                txtToDesigation.Text = Promotion.ToDesignation;
                txtFromotedDate.Text =Convert.ToString( Promotion.PromotedDate);
                txtJobDescription.Text = Promotion.JobDescription;
                txtRemark.Text = Promotion.Remark;
                PID = Promotion.PromotionID;

            }
            catch(Exception ex){
            
            }
        }

        void AddPromotion()
        {
            try
            {
                _PromotionRepository.Add(AssignValues());
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
        
        }

        #region Diclaration

        Validator validate = new Validator();
        GenaricRepository<Promotion> _PromotionRepository = new GenaricRepository<Promotion>(new ItrackContext());
        #endregion

        #region Validation

        public bool isValidPromotion()
        {
           
            if (!validate.isPresent(txtDesignation, "Designation"))
            {
                return false;
            }

            if (!validate.isPresent(txtFromotedDate, "From Date"))
            {
                return false;
            }

           


            return true;




        }


        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPromotion();
        }


    }
}


