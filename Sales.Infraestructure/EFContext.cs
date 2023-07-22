using Microsoft.EntityFrameworkCore;

namespace Sales.Infraestructure
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options)
        {
        }
    }
}