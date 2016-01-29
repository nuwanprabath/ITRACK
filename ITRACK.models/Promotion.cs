using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
  public  class Promotion
    {
        public int PromotionID { get; set; }

        public string Designation { get; set; }

        public DateTime fromDate { get; set; }

        public DateTime ToDate { get; set; }


        public string Remark { get; set; }

        public virtual Employee Employee { get; set; }

        public string EmployeeID { get; set; }

    }
}
