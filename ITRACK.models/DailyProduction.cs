using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public class DailyProduction
   {


       public int DailyProductionID { get; set; }
       
       public string PoNo { get; set; }

       public DateTime Date { get; set; }

       public int HourNo { get; set; }

       public string LineNo { get; set; }

       public string Color { get; set; }

       public string Size { get; set; }

       public string  Type { get; set; }

       public double Qty { get; set; }

       public string StyleID { get; set; }

       public virtual Style Style { get; set; }



   
   
   }
    
}
