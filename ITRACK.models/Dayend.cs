using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
  public  class Dayend
    {
        [Key, Column(Order = 0)]
        public  string  DayendID { get; set; }
      
        [Key, Column(Order = 1)]
        public DateTime Date { get; set; }
      
        [Key, Column(Order = 2)]
        public string  LineNo { get; set; }

        [Key, Column(Order = 3)]
        public string  StyleNo { get; set; }
        [Key, Column(Order = 4)]
        public string  Color { get; set; }
        [Key, Column(Order = 5)]
        public string  Size { get; set; }

        public string  Length { get; set; }

        public int CutQty { get; set; }

        public int LineIn { get; set; }

        public int LineOut { get; set; }

        public int WHIn { get; set; }

        public int WHOut { get; set; }


        public string DayendHeaderID { get; set; }

        public virtual DayendHeader DayendHeader { get; set; } 




    }
}
