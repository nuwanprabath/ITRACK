using ITRACK.models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFTesting
{
   public class CompanyVM
    {
       GenaricRepository<Company> _CompanyRepository = new GenaricRepository<Company>(new ItrackContext());
       Company _Company = new Company();
        public int GetCompany (){

            try {
                _Company.CompanyID = 0;
                foreach (var item in _CompanyRepository.GetAll().Where(x => x.isDefaultCompany == true))
                {
                    _Company.CompanyID = item.CompanyID;

                }
                return _Company.CompanyID;
            
            }
            catch(Exception ex) {
                Debug.WriteLine(ex.Message);
                return 0;
            }
        }


        public bool isExistingDefualtCompany() {

            try
            {
                _Company.CompanyID = 0;
                int count = _CompanyRepository.GetAll().Where(x => x.isDefaultCompany == true).Count();
                if (count > 0) {
                    MessageBox.Show("You canot Add More Then One Defualt Comapny.", "Already Have Defualt Company", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }else{
                
                    return false;
                }
                

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return true;
            }
        
        }

    }
}
