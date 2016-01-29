using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
  public  class Werehouse
    {

        public int WerehouseID { get; set; }

        public string WerehouseName { get; set; }

        public string Remark { get; set; }

        public virtual Company Company { get; set; }
        public Int32 CompanyID { get; set; }

        public virtual ICollection<Rack> Rack { get; set; }
    }
}
