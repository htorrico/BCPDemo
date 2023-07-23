using Sales.Domain.Sales;

namespace Sales.Infraestructure.Repositories
{
    public class SaleRepository : RepositoryBase<Sale>
        , ISaleRepository
    {
        public SaleRepository(EFContext dbContext) : base(dbContext)
        {
        }
    }
}