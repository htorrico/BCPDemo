using Sales.Domain.Interfaces;

namespace Sales.Domain.Departments
{
    public interface IDepartmentRepository : IAsyncRepository<Department>
    {
    }
}