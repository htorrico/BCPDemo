//using API.DTOs.Users;
using Sales.Domain.Interfaces;
using Sales.Domain.Targets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.Service;
using Sales.Service.Response;
using Sales.Service.Request;

namespace Sales.Services
{
    public class TargetService : BaseService
    {
        public TargetService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<AddTargetResponse> AddNewAsync(AddTargetRequest model)
        {
            // You can you some mapping tools as such as AutoMapper
            var Target = new Target(model.ManagerId,model.SellerId,model.Year,model.Month,model.Points );

            var repository = UnitOfWork.AsyncRepository<Target>();
            await repository.AddAsync(Target);
            await UnitOfWork.SaveChangesAsync();

            var response = new AddTargetResponse()
            {
                Id = Target.Id,                
            };

            return response;
        }
        public async Task<List<TargetResponse>> SearchAsync()
        {
            var repository = UnitOfWork.AsyncRepository<Target>();
            var list = await repository
                .ListAllAsync();

            var response = list.Select(_ => new TargetResponse()
            { 
                Id = _.Id,
                Month= _.Month,
                Year   = _.Year,
                MinimumPoints = _.MinimumPoints,
                 
            })
            .ToList();
            return response;
        }

        
    }
}