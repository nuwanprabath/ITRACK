using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public class ScaningTimeSchadual
    {
       public int ScaningTimeSchadualID { get; set; }

        public string ScaningTime { get; set; }

       public int HourNO { get; set; }

        public string  Remark { get; set; }

        public virtual Company Company { get; set; }

        public Int32 CompanyID { get; set; }

       

    }
}
