using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Roles
{
    public partial class Role
    {
        public Role()
        {
            //Users = new HashSet<User>();
        }

        public Role(string name,string description) : this()
        {
            this.Update(name, description);
        }

        public void Update(string name, string description)
        {
            Name= name;
            Description= description;
        }


    }
}
