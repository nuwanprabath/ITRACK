using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public class DividingPlanTemp
    {

        public int DividingPlanTempID { get; set; }

        public string LineNo { get; set; }

        public string TotalEmployee { get; set; }

        public string Target { get; set; }

        public string ProductionPerHour { get; set; }

        public string StyleID { get; set; }

       
        public string OprationNo { get; set; }

        public string OprationName { get; set; }

        public string SMVType { get; set; }


        public string MachineType { get; set; }


        public string SMV { get; set; }

        public bool Selected { get; set; }

        public string PartName { get; set; }


        public DividingPlanTemp() { }
        public DividingPlanTemp(int _tempId,string _oprationCode,string _oprationName,string _smvType,string _machineType,string _smv,bool _selected,string _partName) {

            this.DividingPlanTempID = _tempId;
            this.OprationNo = _oprationCode;
            this.OprationName = _oprationName;
            this.SMVType = _smvType;
            this.MachineType = _machineType;
            this.Selected = _selected;
            this.PartName = _partName;
            this.SMV = _smv;
            

        }
    }
}
