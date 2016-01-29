using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    public class ItrackContextInitializer : DropCreateDatabaseIfModelChanges<ItrackContext>
    {
        protected override void Seed(ItrackContext context)
        {
            var group = new List<Group>
            {
                new Group { GroupName ="Vougue Tex",Address="address",TeleNo="077426888" ,FaxNo="011252325",GroupID="VT" }
              
            };
            group.ForEach(s => context.Group.Add(s));
            context.SaveChanges();
        }
    }
}
