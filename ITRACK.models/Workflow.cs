using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public  class Workflow
    {

        public int WorkflowID { get; set; }

        public string WorkflowName { get; set; }


        public string Remark { get; set; }


        public virtual ICollection<Style> Style { get; set; }

        public virtual ICollection<WorkflowSetup> WorkflowSetup { get; set; }
    }
}
