using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    public class PO
    {
        public string POID { get; set; }

        public string SupplierMasterID { get; set; }

        public virtual SupplierMaster SupplierMaster { get; set; }
       

        public string SupplierName { get; set; }

        public string SupplierAddress { get; set; }

        public string CompanyCode { get; set; }

        public string CompanyName { get; set; }

        public string CompamyAddress { get; set; }


        public string ReferenceNo { get; set; }

        public string Date { get; set; }

        public string PurchaseType { get; set; }

        public string Currency { get; set; }

        public string Country { get; set; }

        public string ShippingType { get; set; }

        public string DeliveryDate { get; set; }

        public string port { get; set; }

        public string ShippingDate { get; set; }

        public string HandleBy { get; set; }

        public string CreditTerms { get; set; }

        public string ReturnPolicy { get; set; }

        public string Qty { get; set; }

        public Int32 CompanyID { get; set; }

        public virtual Company Company { get; set; }

        public virtual ICollection<PoItems> PoItems { get; set; }

        public virtual ICollection<GRN> GRN { get; set; }

    }
}
