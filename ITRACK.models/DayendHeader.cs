using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public  class DayendHeader
    {

        public string DayendHeaderID  { get; set; }

        public DateTime Date { get; set; }

        public string  DayendTime { get; set; }

        public string DayendBy { get; set; }

        public string  ApprovedBy { get; set; }

        public string  ApprovedAt { get; set; }


        public string  Status { get; set; }

        public Int32 CompanyID { get; set; }


        public virtual Company Company { get; set; }

        public virtual ICollection<Dayend> Dayend { get; set; }

        public virtual ICollection<IndividualProductionSummery> IndividualProductionSummery { get; set; }

        public virtual ICollection<CuttingSummary> CuttingSummary { get; set; }
    }
}
