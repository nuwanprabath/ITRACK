using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public class LayinDetails
   {
       public int LayinDetailsID { get; set; }

       public string   MarkerNo { get; set; }

       public DateTime Date { get; set; }

       public string FabricRollID { get; set; }

       public double LayerLenth { get; set; }

       public double FabricRollLenth { get; set; }

       public int NoofPlys { get; set; }

       public double Rest { get; set; }

       public double FabricUsed { get; set; }

       public int TotalPcs { get; set; }

       public string StyleID { get; set; }


       public virtual Style Style { get; set; }





    }
}
