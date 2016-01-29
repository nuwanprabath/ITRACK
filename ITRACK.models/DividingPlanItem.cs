using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public class DividingPlanItem
    {
        public int DividingPlanItemID { get; set; }

        public string OprationNo { get; set; }

        public string OprationName { get; set; }

        public string SMVType { get; set; }

        public string MachineType { get; set; }

        public string OperationRole { get; set; }

        public string PartName { get; set; }

        public double SMV { get; set; }

        public int WorkstationNo { get; set; }

        public int OpNo { get; set; }

        public virtual DividingPlanHeader DividingPlanHeader { get; set; }

        public int  DividingPlanHeaderID { get; set; } 
    }
}
