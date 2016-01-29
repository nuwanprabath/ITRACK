using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    public class DividingPlanHeader
    {

        public int DividingPlanheaderID { get; set; }

        public string LineNo { get; set; }

        public int TotalEmployee { get; set; }

        public int Target { get; set; }

        public int ProductionPerHour { get; set; }

        public string Remark { get; set; }

        public string StyleID { get; set; }

        public virtual Style Style { get; set; }



    }
}
