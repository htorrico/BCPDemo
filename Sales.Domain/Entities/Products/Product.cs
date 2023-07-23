using Sales.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Products
{
    public partial class Product : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int ProductType { get; set; }
        public decimal Percent { get; set; }
        public decimal Points { get; set; }



    }
}
