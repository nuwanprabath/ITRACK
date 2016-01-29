using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    public class Award
    {

        public int AwardID { get; set; }

        public string AwardName { get; set; }

        public DateTime AwardDate { get; set; }

        public string Remark { get; set; }


        public virtual Employee Employee { get; set; }

        public string EmployeeID { get; set; }

        public static void ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}
