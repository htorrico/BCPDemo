using Sales.Domain.Roles;

namespace Sales.Infraestructure.Repositories
{
    public class RoleRepository : RepositoryBase<Role>
        , IRoleRepository
    {
        public RoleRepository(EFContext dbContext) : base(dbContext)
        {
        }
    }
}