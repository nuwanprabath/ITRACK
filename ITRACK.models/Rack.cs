using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    public class Rack
    {
        public int RackID { get; set; }

        public string RackName { get; set; }

        public string Remark { get; set; }

        public virtual Werehouse Werehouse { get; set; }

        public int WerehouseID { get; set; }

        public virtual ICollection<Bin> Bin { get; set; }
    }
}
