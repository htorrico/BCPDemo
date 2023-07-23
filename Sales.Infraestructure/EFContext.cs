using Microsoft.EntityFrameworkCore;
using Sales.Domain.Agencies;
using Sales.Domain.Departments;
using Sales.Domain.Products;
using Sales.Domain.Roles;
using Sales.Domain.Targets;
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
        public DbSet<Role> Roles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Agency> Agencies { get; set; }
        public DbSet<Target> Targets { get; set; }
        public DbSet<Target> Sales { get; set; }

    }
}