using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Service.Request
{
    public class AddTargetRequest
    {
        public int  ManagerId { get; set; }
        public int SellerId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal MinimumPoints { get; set; }
        
    }
}
