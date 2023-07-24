//using API.DTOs.Users;
using Sales.Domain.Interfaces;
using Sales.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.Service;
using Sales.Service.Response;
using Sales.Service.Request;
using Sales.Service.Helpers;

namespace Sales.Services
{
    public class UserService : BaseService
    {
        public UserService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<AddUserResponse> AddNewCustomerAsync(AddCustomerRequest model)
        {

            // You can you some mapping tools as such as AutoMapper
            var User = new User(string.Empty, string.Empty, model.DocumentType, model.DocumentNumber,
                                model.FirstName, model.LastName,model.Email,model.Phone, model.Address,
                                (int)Enums.Role.Customer,model.AgencyId
                                );

            var repository = UnitOfWork.AsyncRepository<User>();
            await repository.AddAsync(User);
            await UnitOfWork.SaveChangesAsync();

            var response = new AddUserResponse()
            {
                Id = User.Id,                
            };

            return response;
        }

        public async Task<AddUserResponse> AddNewSellerAsync(AddSellerRequest model)
        {

            // You can you some mapping tools as such as AutoMapper
            var User = new User(model.UserName, model.Password, model.DocumentType, model.DocumentNumber,
                                model.FirstName, model.LastName, model.Email, model.Phone, model.Address,
                                (int)Enums.Role.Seller, model.AgencyId
                                );

            var repository = UnitOfWork.AsyncRepository<User>();
            await repository.AddAsync(User);
            await UnitOfWork.SaveChangesAsync();

            var response = new AddUserResponse()
            {
                Id = User.Id,
            };

            return response;
        }
        public async Task<AddUserResponse> AddNewManagerAsync(AddManagerRequest model)
        {

            // You can you some mapping tools as such as AutoMapper
            var User = new User(model.UserName, model.Password, model.DocumentType, model.DocumentNumber,
                                model.FirstName, model.LastName, model.Email, model.Phone, model.Address,
                                (int)Enums.Role.Manager, model.AgencyId
                                );

            var repository = UnitOfWork.AsyncRepository<User>();
            await repository.AddAsync(User);
            await UnitOfWork.SaveChangesAsync();

            var response = new AddUserResponse()
            {
                Id = User.Id,
            };

            return response;
        }

        public async Task<List<UserResponse>> SearchAsync()
        {
            var repository = UnitOfWork.AsyncRepository<User>();
            var list = await repository
                .ListAllAsync();

            var response = list.Select(_ => new UserResponse()
            {
                Id = _.Id,
                FirstName = _.FirstName,
                LastName = _.LastName                
            })
            .ToList();
            return response;
        }

        
    }
}