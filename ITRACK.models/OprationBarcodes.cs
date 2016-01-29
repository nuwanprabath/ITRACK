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

        public string  LineNo { get; set; }

        public string  StyleNo { get; set; }

        public string OprationNO { get; set; }

        public string  OparationName { get; set; }

        public string  OprationGrade { get; set; }

        public string  OprationRole  { get; set; }


        public string  PartName { get; set; }


        public bool isOparationComplete { get; set; }


        public DateTime OprationComplteAt { get; set; }


        public string EmployeeID { get; set; }

        public virtual Employee Employee { get; set; }
       
       public int BundleDetailsID { get; set; }
       
       public virtual BundleDetails BundleDetails { get; set; }

       public string OperationPoolID { get; set; }

       public virtual OperationPool OperationPool { get; set; }

       public string HourNo { get; set; }

       public int WorkstationNo { get; set; }


       public int OpNo { get; set; }




     

       public OprationBarcodes() { }

       public OprationBarcodes (string _OprationBarcodesID,string _LineNo,string _StyleNo, string _OprationNO, string _OparationName, string _OprationGrade, string _OprationRole, string _PartName, bool _isOparationComplete,DateTime _OprationComplteAt,string _EmployeeID, int _BundleDetailsID,string _oprationPoolID,string _hourNo,int _workstationNo,int _OpNo){
           this.OprationBarcodesID = _OprationBarcodesID;
           this.LineNo = _LineNo;
           this.StyleNo = _StyleNo;
           this.OprationNO = _OprationNO;
           this.OparationName = _OparationName;
           this.OprationGrade = _OprationGrade;
           this.OprationRole = _OprationRole;
           this.PartName = _PartName;
           this.isOparationComplete = _isOparationComplete;
           this.OprationComplteAt = _OprationComplteAt;
           this.EmployeeID = _EmployeeID;
           this.BundleDetailsID = _BundleDetailsID;
           this.OperationPoolID = _oprationPoolID;
           this.WorkstationNo = _workstationNo;
           this.HourNo = _hourNo;
           this.OpNo = _OpNo;
           

   }

       
    





    }
}
