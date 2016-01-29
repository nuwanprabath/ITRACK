using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public class Employee
    {

        public string EmployeeID { get; set; }

        public string FullName { get; set; }

        public string NicNo { get; set; }

        public string EPFNo { get; set; }

        public string ETFNo { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string MaritalStatus { get; set; }

        public string Department { get; set; }

        public string Designation { get; set; }

        public string JobStatus { get; set; }

        public string Address { get; set; }

        public string MobileNo { get; set; }

        public string LandNo { get; set; }

        public string EmailAddress { get; set; }

        public string EmergencyContactNo { get; set; }

        public string EmergencyContactPerson { get; set; }

       
       
        [Column(TypeName = "image")]

        public byte[] Image { get; set; }

        public virtual Company Company { get; set; }

        public Int32 CompanyID { get; set; }

        public virtual ICollection<PastEmployeement> PastEmployeement { get; set; }

        public virtual ICollection<Promotion> Promotion { get; set; }

        public virtual ICollection<Award> Award { get; set; }

        public virtual ICollection<OprationBarcodes> OprationBarcodes { get; set; }
        public virtual User User { get; set; }

        public virtual Workstation Workstation { get; set; }

     

    }
}
