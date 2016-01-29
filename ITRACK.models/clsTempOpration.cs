using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    public class TempOpration
    {


        public int TempOprationID { get; set; }
        public string OprationID { get; set; }

        public string OparationName { get; set; }

        public string MachineType { get; set; }

        public double SMV { get; set; }

        public string SMVType { get; set; }

        public string Remark { get; set; }

        public string PartName { get; set; }

        public string OprationRole { get; set; }

        public string OprationGrade { get; set; }


        public TempOpration() { }

        public TempOpration(
          
            string _OprationId,
            string _OprationName,
            string _MachineType,
            double _SMV,
            string _SMVType,
            string _Remark,
            int _id,
            string _Grade,
            string _Part,
            string _Role
            
            ) {

               
                this.OprationID = _OprationId;
                this.OparationName = _OprationName;
                this.MachineType = _MachineType;
                this.SMV = _SMV;
                this.SMVType = _SMVType;
                this.Remark = _Remark;
                this.TempOprationID = _id;
                this.OprationGrade = _Grade;
                this.PartName = _Part;
                this.OprationRole = _Role;

           
        
        }

    }
}
