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

namespace EFTesting.UI
{
    public partial class frmPromotion : DevExpress.XtraEditors.XtraForm
    {
        public frmPromotion()
        {
            InitializeComponent();
        }

        #region Diclaration

        Validator validate = new Validator();

        #endregion

        #region Validation

        public bool isValidPromotion()
        {
            if (!validate.isPresent(txtPromotionID, "Promotion ID"))
            {
                return false;
            }

            if (!validate.isPresent(txtDesignation, "Designation"))
            {
                return false;
            }

            if (!validate.isPresent(txtFromDate, "From Date"))
            {
                return false;
            }

            if (!validate.isPresent(txtToDate, "To Date"))
            {
                return false;
            }


            return true;




        }


        #endregion


    }
}


