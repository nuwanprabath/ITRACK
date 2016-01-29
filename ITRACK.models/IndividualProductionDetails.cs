using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public class IndividualProductionDetails
    {

       [Key]
       [Column(Order = 1)] 
       public string EmployeeID { get; set; }

       [Key]
       [Column(Order = 2)] 
       public string StyleNo { get; set; }

       [Key]
       [Column(Order = 3)] 
        public DateTime Date { get; set; }
       [Key]
       [Column(Order = 4)] 
        public int HourNo { get; set; }

        public int WorkstationNo { get; set; }

        [Key]
        [Column(Order = 5)] 
        public string OperationNo { get; set; }


        public string OperationName { get; set; }


        public int Pcs { get; set; }

        public double SMV { get; set; }


        public double SAH { get; set; }

        public double Efficiency { get; set; }

        public Int32 CompanyID { get; set; }

        public virtual Company Company { get; set; }
    }
}
