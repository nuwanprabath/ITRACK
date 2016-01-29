using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    public class SupplierMaster
    {

        public string SupplierMasterID { get; set; }

        public string SupplierName { get; set; }

        public string SupplierType { get; set; }

        public string SupplierAddress { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string Status { get; set; }

        public string ContactName { get; set; }

        public string ContactTitle { get; set; }

        public string TelephoneNumber { get; set; }

        public string FaxNumber { get; set; }

        public string EmailAddress { get; set; }

        public string WebAddress { get; set; }

        public string PosalCode { get; set; }

        public string BankName { get; set; }

        public string AccountNumber { get; set; }

        public string ChequeType { get; set; }

        public string Currency { get; set; }

        public string CreditTerm { get; set; }

        public string AccountName { get; set; }

        public string Branch { get; set; }

        public string BankAddress { get; set; }

        public string SvatNo { get; set; }

        public Int32 CompanyID { get; set; }

        public virtual Company Company { get; set; }

        public virtual ICollection<PO> PO { get; set; }

        public string POID { get; set; }

    }
}
