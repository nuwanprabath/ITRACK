using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public  class OprationBarcodes
    {
        public string OprationBarcodesID { get; set; }

        public string OprationNO { get; set; }

        public string  OparationName { get; set; }

        public string  OprationGrade { get; set; }

        public string  OprationRole  { get; set; }


        public string  PartName { get; set; }


        public bool isOparationComplete { get; set; }


        public DateTime OprationComplteAt { get; set; }


        public string  EmployeeID { get; set; }
       
       public int BundleDetailsID { get; set; }
       
       public virtual BundleDetails BundleDetails { get; set; }

       public OprationBarcodes() { }

       public OprationBarcodes (string _OprationBarcodesID,string _OprationNO, string _OparationName, string _OprationGrade, string _OprationRole, string _PartName, bool _isOparationComplete,DateTime _OprationComplteAt,string _EmployeeID, int _BundleDetailsID){
           this.OprationBarcodesID = _OprationBarcodesID;
           this.OprationNO = _OprationNO;
           this.OparationName = _OparationName;
           this.OprationGrade = _OprationGrade;
           this.OprationRole = _OprationRole;
           this.PartName = _PartName;
           this.isOparationComplete = _isOparationComplete;
           this.OprationComplteAt = _OprationComplteAt;
           this.EmployeeID = _EmployeeID;
           this.BundleDetailsID = _BundleDetailsID;

   }

       
    





    }
}
