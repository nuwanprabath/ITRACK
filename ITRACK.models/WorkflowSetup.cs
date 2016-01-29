using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public class WorkflowSetup
    {

        public int WorkflowSetupID { get; set; }

        public int Sequence { get; set; }

        public virtual Workstation Workstation { get; set; }

        public virtual Workflow Workflow { get; set; }

        public int WorkflowID { get; set; }

      
    }
}
