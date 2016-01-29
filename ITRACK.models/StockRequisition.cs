using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    class StockRequisition
    {
        public string StockRequisitionID { get; set; }

        public string LocationCode { get; set; }

        public string LocationName { get; set; }

        public string Date { get; set; }

        public string FromDepartment { get; set; }

        public string ToDepartment { get; set; }

        
    }
}
