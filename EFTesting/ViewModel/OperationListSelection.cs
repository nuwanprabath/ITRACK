using ITRACK.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTesting.ViewModel
{
  public  class OperationListSelection
    {

      public bool Selected { get; set; }

      public string OprationNo { get; set; }

      public string OprationName { get; set; }


      public string SMVType { get; set; }

      public string MachineType { get; set; }

      public string OperationRole { get; set; }

      public string PartName { get; set; }

      public double SMV { get; set; }

      public int WorkstationNo { get; set; }

     
      public OperationListSelection() { }

      public OperationListSelection(string oNo,string oName,double smv,int workstation,bool _selected,string smvType,string partName,string _oprationRole,string machineType) {
        
          this.Selected = _selected;
          this.OprationNo = oNo;
          this.OprationName = oName;
          this.SMV = smv;
          this.WorkstationNo = workstation;
          this.SMVType = smvType;
          this.PartName = partName;
          this.OperationRole = _oprationRole;
          this.MachineType = machineType;
        
          
      
      }

    }
}
