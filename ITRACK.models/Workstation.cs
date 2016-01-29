using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    public class Workstation
    {
        public int WorkstationID { get; set; }

        public string WorkstationName { get; set; }

        public string Remark { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual WorkflowSetup WorkflowSetup { get; set; }


       
    }
}
