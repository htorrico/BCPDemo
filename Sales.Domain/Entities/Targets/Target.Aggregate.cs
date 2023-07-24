using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Targets
{
    public partial class Target
    {
        public Target()
        {
            //Users = new HashSet<User>();
        }

        public Target(int managerId,int sellerId,int year, int month, decimal minimumPoints) : this()
        {
            this.Update(managerId,sellerId, year,month, minimumPoints);
        }

        public void Update(int managerId,int sellerId,int year, int month, decimal minimumPoints)
        {
            ManagerId = managerId;
            SellerId = sellerId;
            Year = year;
            Month = month;
            MinimumPoints= minimumPoints;
            
        }


    }
}
