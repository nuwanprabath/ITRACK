using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    public class GRN
    {
        public string GRNID { get; set; }

        public string LocationCode { get; set; }

        public string POID { get; set; }

        public string PoDate { get; set; }

        public string Date { get; set; }

        public string Supplier { get; set; }

        public string SupplierCode { get; set; }

        public string SupplierInvoiceNo { get; set; }

        public string InvoiceDate { get; set; }

        public string ShipmentType { get; set; }

        public string Currency { get; set; }

        public string ExchangeRate { get; set; }

        public virtual PO PO { get; set; }

        public virtual ICollection<GrnItems> GrnItems { get; set; }
        

    }
}
