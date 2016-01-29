using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public  class PurchaseOrderItems
    {
        [Key]
        [Column(Order = 1)] 
        public string PurchaseOrderID { get; set; }
        [Key]
        [Column(Order = 2)] 
        public string Color { get; set; }
        [Key]
        [Column(Order = 3)] 
        public string Size { get; set; }
        [Key]
        [Column(Order = 4)] 
        public string Length { get; set; }

        public int Quantity { get; set; }

        public virtual PurchaseOrderHeader PurchaseOrderHeader { get; set; }

        public string PurchaseOrderHeaderID { get; set; }

    }
}
