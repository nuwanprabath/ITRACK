using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public  class StyleOperation
    {
        public int StyleOperationID { get; set; }

        public double SMV { get; set; }


        public virtual PartDefinition PartDefinition { get; set; }

        public string PartDefinitionID { get; set; }

    }
}
