using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
  public  class PurchaseOrderHeader
    {
        public string PurchaseOrderHeaderID { get; set; }
        public string Article { get; set; }

        public string Season { get; set; }

        public string DeliveryTerms { get; set; }

        public bool PlaceWashingFactory { get; set; }

        public double OrderPrice { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }


        public string Remark { get; set; }
        public virtual Style Style { get; set; }


        public string StyleID { get; set; }

        public virtual ICollection<PurchaseOrderItems> PurchaseOrderItems { get; set; }

    }
}
