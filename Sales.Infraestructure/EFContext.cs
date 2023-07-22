using Microsoft.EntityFrameworkCore;
using Sales.Domain.Departments;

namespace Sales.Infraestructure
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
    }
}