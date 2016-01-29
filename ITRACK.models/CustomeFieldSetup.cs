using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    public class CustomeFieldSetup
    {

        public Int32 CustomeFieldSetupID { get; set; }

        public string  ItemType { get; set; }

        public string CustomField1 { get; set; }

        public string CustomField2 { get; set; }

        public string CustomField3 { get; set; }

        public string CustomField4 { get; set; }

        public string CustomField5 { get; set; }

        public string CustomField6 { get; set; }

        public int CodeLength { get; set; }

        public bool ItemCodeGenerate { get; set; }

        public ICollection<Items> Items { get; set; }

        public Int32 CompanyID { get; set; }

        public virtual Company Company { get; set; }

    }
}
