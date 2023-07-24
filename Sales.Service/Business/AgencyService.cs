//using API.DTOs.Users;
using Sales.Domain.Interfaces;
using Sales.Domain.Agencies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.Service;
using Sales.Service.Response;
using Sales.Service.Request;

namespace Sales.Services
{
    public class AgencyService : BaseService
    {
        public AgencyService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<AddAgencyResponse> AddNewAsync(AddAgencyRequest model)
        {
            // You can you some mapping tools as such as AutoMapper
            var Agency = new Agency( model.Name, model.Description);

            var repository = UnitOfWork.AsyncRepository<Agency>();
            await repository.AddAsync(Agency);
            await UnitOfWork.SaveChangesAsync();

            var response = new AddAgencyResponse()
            {
                Id = Agency.Id,                
            };

            return response;
        }
        public async Task<List<AgencyResponse>> SearchAsync()
        {
            var repository = UnitOfWork.AsyncRepository<Agency>();
            var list = await repository
                .ListAllAsync();

            var response = list.Select(_ => new AgencyResponse()
            {
                Name= _.Name,
                Description= _.Description,
            })
            .ToList();
            return response;
        }

        
    }
}