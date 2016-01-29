using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
  public  class Items
    {

        public string ItemsID { get; set; }

        public string ItemType { get; set; }

        public string CustomFiled1 { get; set; }

        public string CustomField2 { get; set; }

        public string CustomField3 { get; set; }

        public string CustomField4 { get; set; }

        public string CustomField5 { get; set; }

        public string CustomField6 { get; set; }

        public string SupplierItemCode { get; set; }

        public string Uom { get; set; }

        public string Status { get; set; }

        public string MaxQty { get; set; }

        public string ReOrderQty { get; set; }

        public string MinimumQty { get; set; }

        public bool BatchItem { get; set; }

        public bool ServiceItem { get; set; }

        public bool ShowInFrontEnd { get; set; }

        public bool Discount { get; set; }

        public bool CustomerReturnOrder { get; set; }

        public bool SerialItems { get; set; }


        [Column(TypeName = "image")]

        public byte[] Image { get; set; }
        public Int32 CustomeFieldSetupID { get; set; }


        public virtual CustomeFieldSetup CustomFieldSetup { get; set; }

        public virtual ICollection<PoItems> PoItems { get; set; }

      

    }
}
