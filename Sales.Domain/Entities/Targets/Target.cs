using Sales.Domain.Base;
using Sales.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Targets
{
    public partial class Target : BaseEntity<int>
   {               
        public  User Manager { get; set; }
        public int ManagerId { get; set; }

        public  User Seller { get; set; }
        public int SellerId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }        
        public decimal MinimumPoints { get; set; }

        


    }
}
