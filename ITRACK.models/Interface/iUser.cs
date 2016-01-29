using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models.Interface
{
    interface iUser
    {
        List<User> GetUser(User _User);
    }
}
