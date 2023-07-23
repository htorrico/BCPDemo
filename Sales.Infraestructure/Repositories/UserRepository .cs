using Sales.Domain.Users;

namespace Sales.Infraestructure.Repositories
{
    public class UserRepository : RepositoryBase<User>
        , IUserRepository
    {
        public UserRepository(EFContext dbContext) : base(dbContext)
        {
        }
    }
}