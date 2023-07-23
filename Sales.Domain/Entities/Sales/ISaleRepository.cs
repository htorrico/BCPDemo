using Sales.Domain.Interfaces;
using Sales.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Domain.Sales
{
    public interface ISaleRepository : IAsyncRepository<Sale>
    {
    }
}
