using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTesting.Reports
{
  public  class HourlyIndividualProduction
    {


        public DateTime Date { get; set; }

        public string LineNo { get; set; }

        public string StyleNo { get; set; }

        public int WorkstationNo { get; set; }


        public string EmployeeID { get; set; }

        public string Name { get; set; }

        public string OperationNo { get; set; }

        public string OperationName { get; set; }


        public int HourNo { get; set; }

        public double EarnSAH { get; set; }

        public double Efficiency { get; set; }

        public int PCS { get; set; }





    }
}
