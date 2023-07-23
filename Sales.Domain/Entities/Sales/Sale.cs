using Sales.Domain.Base;
using Sales.Domain.Products;
using Sales.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Sales
{
    public partial class Sale : BaseEntity<int>
    {
        public User Customer { get; set; }
        public int CustomerId { get; set; }


        public User  Seller { get; set; }
        public int SellerId { get; set; }

        public Product   Product { get; set; }
        public int ProductId { get; set; }

        public decimal Amount { get; set; }
        public decimal Points { get; set; }

        public DateTime Date { get; set; }

        public int Year { get; set; }
        public int Month { get; set; }


    }
}
