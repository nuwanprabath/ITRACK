using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
  public  class GrnItems
    {

        public int GrnItemsID { get; set; }

        public string ItemCode { get; set; }
        public string Description { get; set; }

        public string Color { get; set; }

        public string Width { get; set; }

        public string Unit { get; set; }

        public double Qty { get; set; }

        public double ReceivedQty { get; set; }

        public double UnitPrice { get; set; }

        public double ReceivedPrice { get; set; }


        public double LineDiscount { get; set; }

        public double waistadeQty { get; set; }

        public double SubTotal { get; set; }


        public virtual GRN GRN { get; set; }

        public string GRNID { get; set; }


        public GrnItems() {
        
        }

        public GrnItems(
            
            string _itemCode,
            string _description,
            string _color,
            string _width,
            string _unit,
            double _UnitPrice,
            double _Qty,
            double _ReceivedQty,
            double _ReceivedPrice,
            double _SubTotal,
            double _WaistadeQty

            
            ) {

                this.ItemCode = _itemCode;
                this.Description = _description;
                this.Color = _color;
                this.Width = _width;
                this.Unit = _unit;
                this.UnitPrice = _UnitPrice;
                this.Qty = _Qty;
                this.ReceivedQty = _ReceivedQty;
                this.ReceivedPrice = _ReceivedPrice;
                this.SubTotal = _SubTotal;
                this.waistadeQty = _WaistadeQty;
        }









    }
}
