using Sales.Domain.Users;

namespace Sales.Infraestructure.Repositories
{
    public class ProductRepository : RepositoryBase<User>
        , IUserRepository
    {
        public ProductRepository(EFContext dbContext) : base(dbContext)
        {
        }
    }
}