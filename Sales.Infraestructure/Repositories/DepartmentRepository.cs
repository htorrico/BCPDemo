using Sales.Domain.Departments;

namespace Sales.Infraestructure.Repositories
{
    public class DepartmentRepository : RepositoryBase<Department>
        , IDepartmentRepository
    {
        public DepartmentRepository(EFContext dbContext) : base(dbContext)
        {
        }
    }
}