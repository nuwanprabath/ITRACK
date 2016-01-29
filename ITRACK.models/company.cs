using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public class Company
    {
       [Key] 
       public Int32 CompanyID { get; set; }

       [Required]
       [MaxLength(10)]
        public string  LocationCode { get; set; }
        public string  CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string  TeleNo { get; set; }
        public string  FaxNo { get; set; }

        public bool isDefaultCompany { get; set; } 

        public virtual Group Group { get; set; }
        public virtual ICollection<Buyer> Buyer { get; set; }

        public virtual ICollection<Style> Style { get; set; }

        public virtual ICollection<Werehouse> Werehouse { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }

        public virtual ICollection<OperationPool> OperationPool { get; set; }

        public virtual ICollection<DayendHeader> DayendHeader { get; set; }


        public virtual ICollection<ScaningTimeSchadual> ScaningTimeSchadual { get; set; }

        public virtual ICollection<IndividualProductionDetails> IndividualProductionDetails { get; set; }
        public string GroupID { get; set; }

        


    }
}
