using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public class CuttingHeader
    {
        public string CuttingHeaderID { get; set; }

        public int OrderQuantity { get; set; }

        public int PlanQuantity  { get; set; }

        public int BundleSize { get; set; }
        public string ItemType { get; set; }

        public DateTime Date { get; set; }

        public string  Remark { get; set; }

        public string status { get; set; }

        public string StyleID { get; set; }

        public virtual Style Style { get; set; }

        public virtual ICollection<CuttingItem> CuttingItem { get; set; }
        

    }
}
