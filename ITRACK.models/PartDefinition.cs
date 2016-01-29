using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    public class PartDefinition
    {
         [Key]
        public int PartDefinitionID { get; set; }

         public string PartName { get; set; }

         public string ItemType { get; set; }

         public string Remark { get; set; }


         public Int32 SketchDefinitionID { get; set; }


         public virtual SketchDefinition SketchDefinition { get; set; } 

       public virtual ICollection<StyleOperation> StyleOperation { get; set; }



    }
}
