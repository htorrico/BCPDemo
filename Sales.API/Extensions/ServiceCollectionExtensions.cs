
using Sales.Domain.Departments;
using Sales.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sales.Infraestructure.Repositories;
using Sales.Infraestructure;
using Sales.Services;

namespace Sales.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>))
                //.AddScoped<IUserRepository, UserRepository>()
                .AddScoped<IDepartmentRepository, DepartmentRepository>();
        }

        public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
        {
            return services
                .AddScoped<IUnitOfWork, UnitOfWork>();
        }

        public static IServiceCollection AddDatabase(this IServiceCollection services
            , IConfiguration configuration)
        {
            return services.AddDbContext<EFContext>(options =>
                     options.UseSqlServer(configuration.GetConnectionString("DDDConnectionString")));
        }

        public static IServiceCollection AddBusinessServices(this IServiceCollection services
           )
        {
            return services
                .AddScoped<DepartmentService>();
        }
    }
}