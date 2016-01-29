using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    public class CuttingSummary
    {

        public int CuttingSummaryID { get; set; }

        public int CuttingIdDetails  { get; set; }

        public string  ProductionLineNo { get; set; }

        public string StyleNo { get; set; }

       
        public string  MarkerNo { get; set; }

        public string  FabricType { get; set; }
        public string  Color { get; set; }

        public string  Size { get; set; }


        public int NoPcs { get; set; }

        public string DayendHeaderID { get; set; }

        public virtual DayendHeader DayendHeader { get; set; } 



    }
}
