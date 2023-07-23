using Sales.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Agencies
{
    public partial class Agency : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
