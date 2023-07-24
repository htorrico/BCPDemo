using Sales.Domain.Products;
using Sales.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Service.Request
{
    public class AddSaleRequest
    {        
        public int CustomerId { get; set; }
        public int SellerId { get; set; }        
        public int ProductId { get; set; }
        public decimal Amount { get; set; }
                   

    }
}
