using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Products
{
    public partial class Product
    {
        public Product()
        {
            //Users = new HashSet<User>();
        }
        
        public Product(string name,string description, int productType, decimal percent, decimal points) : this()
        {
            this.Update(name, description,productType, percent, points);
        }

        public void Update(string name, string description, int productType, decimal percent, decimal points)
        {
            Name= name;
            Description= description;
            ProductType= productType;
            Percent= percent;
            Points= points;
        }


    }
}
