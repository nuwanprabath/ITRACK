using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public class IndividualProductionSummery
    {
        public string IndividualProductionSummeryID { get; set; }

        public string EmployeeID { get; set; }

        public string OprationNo { get; set; }

        public int Pcs { get; set; }

        public double WorkingHours { get; set; }

        public double OfftadredHours { get; set; }

        public double OfftanderdEffiency { get; set; }

        public double EarnSAH { get; set; }

        public double Effiency { get; set; }

        public string DayendHeaderID { get; set; }

        public virtual DayendHeader DayendHeader { get; set; } 
    }
}
