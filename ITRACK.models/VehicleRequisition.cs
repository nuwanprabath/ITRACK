using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    public class VehicleRequisition
    {
        public string VehicleRequisitionID { get; set; }

        public string RequestDate { get; set; }

        public string RequestTime { get; set; }

        public string RequestBy { get; set; }

        public string Department { get; set; }

        public string VehicleType { get; set; }

        public string Purpose { get; set; }

        public string DriverName { get; set; }

        public string ContactNo { get; set; }

        public string VehicleNo { get; set; }

        public string SpeedDialNo { get; set; }

        public string Payment { get; set; }

        public string AssignToJob { get; set; }

        public string TimeStart { get; set; }

        public string TimeFinished { get; set; }

        public string MyProperty { get; set; }

        public string StartMeter { get; set; }

        public string FinishedMeter { get; set; }

        public string TravelledDistance { get; set; }

        public Int32 CompanyID { get; set; }

        public virtual Company Company { get; set; }


    }
}
