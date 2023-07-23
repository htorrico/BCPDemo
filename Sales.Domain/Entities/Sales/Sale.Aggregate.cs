using Sales.Domain.Products;
using Sales.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Sales
{
    public partial class Sale
    {
        public Sale()
        {
            //Users = new HashSet<User>();
        }

        public Sale(int customerId, int sellerId, int productId, decimal amount, decimal points, DateTime date, int year, int month) : this()
        {
            this.Update( customerId,sellerId, productId, amount,  points, date,  year, month);
        }

        public void Update(int customerId,int sellerId, int productId, decimal amount, decimal points, DateTime date,int year, int month)
        {
        
            CustomerId = customerId;
            SellerId= sellerId;
            ProductId= productId;
            Amount= amount;
            Points= points;
            Date= date;
            Year= year;
            Month= month;
        }


        



    }
}
