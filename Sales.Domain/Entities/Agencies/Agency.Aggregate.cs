using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Agencies
{
    public partial class Agency
    {
        public Agency()
        {
            //Users = new HashSet<User>();
        }

        public Agency(string name,string description) : this()
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
