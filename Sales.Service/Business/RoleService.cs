//using API.DTOs.Users;
using Sales.Domain.Interfaces;
using Sales.Domain.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.Service;
using Sales.Service.Response;
using Sales.Service.Request;

namespace Sales.Services
{
    public class RoleService : BaseService
    {
        public RoleService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<AddRoleResponse> AddNewAsync(AddRoleRequest model)
        {
            // You can you some mapping tools as such as AutoMapper
            var Role = new Role( model.Name, model.Description);

            var repository = UnitOfWork.AsyncRepository<Role>();
            await repository.AddAsync(Role);
            await UnitOfWork.SaveChangesAsync();

            var response = new AddRoleResponse()
            {
                Id = Role.Id,                
            };

            return response;
        }
        public async Task<List<RoleResponse>> SearchAsync()
        {
            var repository = UnitOfWork.AsyncRepository<Role>();
            var list = await repository
                .ListAllAsync();

            var response = list.Select(_ => new RoleResponse()
            {
                Id=_.Id,
                Name= _.Name,
                Description= _.Description
            })
            .ToList();
            return response;
        }

        
    }
}