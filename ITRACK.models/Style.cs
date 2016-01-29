using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public class Style
    {

        [Key] 
        public string StyleID { get; set; }

        public string Article { get; set; }

        public string Season { get; set; }

        public string GarmantType { get; set; }

        public string Status { get; set; }

        public string Remark { get; set; }

        public string FeedingRule { get; set; }

        public string ForecastingRule { get; set; }

        public Int32 CompanyID { get; set; }

        public virtual Company Company { get; set; }

        public virtual Buyer Buyer { get; set; }

        public Int32 BuyerID { get; set; }

       
        public virtual ICollection<SketchDefinition> SketchDefinition { get; set; }

        public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeader { get; set; }

        public virtual ICollection<CuttingHeader> CuttingHeader { get; set; }


        public virtual ICollection<DividingPlanHeader> DividingPlanHeader { get; set; }


        public virtual ICollection<FabricDetails> FabricDetails { get; set; }

        public virtual Workflow Workflow { get; set; }

        public int WorkflowID { get; set; }
    }
}
