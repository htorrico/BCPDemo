using Microsoft.EntityFrameworkCore;
using Sales.Domain.Departments;
using Sales.Domain.Users;

namespace Sales.Infraestructure
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<User> Users { get; set; }

    }
}