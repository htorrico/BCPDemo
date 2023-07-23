//using API.DTOs.Users;
using Sales.Domain.Interfaces;
using Sales.Domain.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.Service;
using Sales.Service.Response;
using Sales.Service.Request;

namespace Sales.Services
{
    public class DepartmentService : BaseService
    {
        public DepartmentService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<AddDepartmentResponse> AddNewAsync(AddDepartmentRequest model)
        {
            // You can you some mapping tools as such as AutoMapper
            var department = new Department( model.Name,"");

            var repository = UnitOfWork.AsyncRepository<Department>();
            await repository.AddAsync(department);
            await UnitOfWork.SaveChangesAsync();

            var response = new AddDepartmentResponse()
            {
                Id = department.Id,                
            };

            return response;
        }
        public async Task<List<DepartmentInfoDTO>> SearchAsync()
        {
            var repository = UnitOfWork.AsyncRepository<Department>();
            var deparments = await repository
                .ListAsync(_ => _.Name.Contains(""));

            var deparmentDTOs = deparments.Select(_ => new DepartmentInfoDTO()
            {
                Id = _.Id                
            })
            .ToList();

            return deparmentDTOs;
        }

        
    }
}