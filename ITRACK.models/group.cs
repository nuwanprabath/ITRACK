using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    public class Group {
        [Key]
        public string GroupID { get; set; }
        public string  GroupName { get; set; }
        public string  Address { get; set; }

        public string  TeleNo { get; set; }

        public string FaxNo { get; set; }

        public virtual ICollection<Company> Company { get; set; }

       


    
    }
}
