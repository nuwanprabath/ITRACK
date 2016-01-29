using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
  public class SketchDefinition
    {
        public Int32 SketchDefinitionID { get; set; }

        public string SketchName { get; set; }

        public string Remark { get; set; }

        public string ItemType { get; set; }

        [Column(TypeName = "image")]

        public byte[] Image { get; set; }

        public string StyleID { get; set; }

        public virtual Style Company { get; set; }

        public virtual ICollection<PartDefinition> PartDefinition { get; set; }
    }
}
