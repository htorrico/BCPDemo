using Sales.Domain.Agencies;

namespace Sales.Infraestructure.Repositories
{
    public class AgencyRepository : RepositoryBase<Agency>
        , IAgencyRepository
    {
        public AgencyRepository(EFContext dbContext) : base(dbContext)
        {
        }
    }
}