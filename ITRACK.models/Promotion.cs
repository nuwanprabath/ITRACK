using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
  public  class Promotion
    {

      [Key]
      public int PromotionID { get; set; }

        public string FromDesignation { get; set; }

        public string ToDesignation { get; set; }

        public DateTime PromotedDate { get; set; }


        public string JobDescription { get; set; }

        public string Remark { get; set; }

        public virtual Employee Employee { get; set; }

        public string EmployeeID { get; set; }

    }
}
