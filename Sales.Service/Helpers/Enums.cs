using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Service.Helpers
{
    public static class Enums
    {
        public enum Role :int
        {
            Customer=1,
            Manager=2,
            Seller=3
        }

        public enum ProductType : int
        {
            Card = 1,
            Credit = 2            
        }
    }
}
