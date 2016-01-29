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
    public partial class dlgSizelist : DevExpress.XtraEditors.XtraForm
    {
        public dlgSizelist()
        {
            InitializeComponent();
        }

        #region Diclaration

        Validator validator = new Validator();

        #endregion

        #region Validation

        public bool isValidSizelist()
        {

            if (!validator.isPresent(txtSize, "Size"))
            {
                return false;
            }

            if (!validator.isPresent(txtQty, "Qty"))
            {
                return false;
            }

            return true;
               

        }


     

        #endregion


        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }
    }
}