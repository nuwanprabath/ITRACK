using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    public class PoItems
    {
        public Int32 PoItemsID { get; set; }

        public string ItemCode { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public Int32 Qty { get; set; }

        public Int32 Discount { get; set; }

        public string Colors { get; set; }

        public string Width { get; set; }

        public string Unit { get; set; }

        public double SubTotal { get; set; }

        public virtual Items Items { get; set; }

        public string ItemsID { get; set; }

        public virtual PO Po { get; set; }

        public string POID { get; set; }


    }
}
