using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public class FabricDetails
    {

       // fabric details 
        public int FabricDetailsID { get; set; }

        public string  FabricType { get; set; }
       // name 
        public string  FabricName { get; set; }

        public string  Color { get; set; }

        public double PlanedConsumtion { get; set; }

        public string  Remark  { get; set; }

        public string StyleID { get; set; }


        public virtual Style Style { get; set; }





    }
}
