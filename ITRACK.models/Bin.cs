using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
  public class Bin
    {
        public int BinID { get; set; }

        public string BinName { get; set; }

        public string Remark { get; set; }

        public virtual Rack Rack { get; set; }

        public int RackID { get; set; }
    }
}
