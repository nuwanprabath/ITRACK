using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    public class OperationPool
    {

          [Key] 
        public string OperationPoolID { get; set; }

        public string OpationName { get; set; }


        public string MachineType { get; set; }

        public double SMV { get; set; }

        public string SMVType { get; set; }

        public string Remark { get; set; }

        public string PartName { get; set; }

        public string OprationRole { get; set; }

        public string OprationGrade { get; set; }
        public Int32 CompanyID { get; set; }

        public virtual Company Company { get; set; }

        public virtual ICollection<OprationBarcodes> OprationBarcodes { get; set; }

        public OperationPool() { }
        public OperationPool(
            string _oprationPoolID,
            string _oprationName,
            string _MachineType,
            string SMVtype,
            double _SMV
            
            ) {

            this.OperationPoolID = _oprationPoolID;
            this.OpationName = _oprationName;
            this.MachineType = _MachineType;
            this.SMVType = SMVType;
            this.SMV = _SMV;
        }


    }
}
