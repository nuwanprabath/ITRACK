using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public class PastEmployeement
    {
        public int PastEmployeementID { get; set; }

        public string CompanyName { get; set; }

        public string Designation { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public string Remark { get; set; }

        public virtual Employee Employee { get; set; }

        public string EmployeeID { get; set; }
    }
}
