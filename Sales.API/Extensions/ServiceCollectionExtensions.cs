﻿
using Sales.Domain.Departments;
using Sales.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sales.Infraestructure.Repositories;
using Sales.Infraestructure;
using Sales.Services;
using Sales.Domain.Roles;
using Sales.Domain.Agencies;
using Sales.Domain.Products;
using Sales.Domain.Targets;
using Sales.Domain.Users;
using Sales.Domain.Sales;

namespace Sales.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>))                
                .AddScoped<IDepartmentRepository, DepartmentRepository>()
                .AddScoped<IRoleRepository, RoleRepository>()
                .AddScoped<IAgencyRepository, AgencyRepository>()
                .AddScoped<IProductRepository, ProductRepository>()
                .AddScoped<ITargetRepository, TargetRepository>()
                .AddScoped<IUserRepository, UserRepository>()
                .AddScoped<ISaleRepository, SaleRepository>();
        }

        public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
        {
            return services
                .AddScoped<IUnitOfWork, UnitOfWork>();
        }

        //public static IServiceCollection AddDatabase(this IServiceCollection services
        //    , IConfiguration configuration)
        //{
        //    return services.AddDbContext<EFContext>(options =>
        //             options.UseSqlServer(configuration.GetConnectionString("DDDConnectionString")));
        //}

        public static IServiceCollection AddBusinessServices(this IServiceCollection services
           )
        {
            return services
                .AddScoped<DepartmentService>()
                .AddScoped<RoleService>()
                .AddScoped<AgencyService>()
                .AddScoped<ProductService>()
                .AddScoped<TargetService>()
                .AddScoped<UserService>()
                .AddScoped<SaleService>()
                ;
        }
    }
}