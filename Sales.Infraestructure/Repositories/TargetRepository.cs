using Sales.Domain.Targets;

namespace Sales.Infraestructure.Repositories
{
    public class TargetRepository : RepositoryBase<Target>
        , ITargetRepository
    {
        public TargetRepository(EFContext dbContext) : base(dbContext)
        {
        }
    }
}