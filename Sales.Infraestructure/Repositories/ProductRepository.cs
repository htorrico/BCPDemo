using Sales.Domain.Products;
using Sales.Domain.Users;

namespace Sales.Infraestructure.Repositories
{
    public class ProductRepository : RepositoryBase<Product>
        , IProductRepository
    {
        public ProductRepository(EFContext dbContext) : base(dbContext)
        {
        }
    }
}