//using API.DTOs.Users;
using Sales.Domain.Interfaces;
using Sales.Domain.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.Service;
using Sales.Service.Response;
using Sales.Service.Request;
using Sales.Domain.Products;
using Sales.Service.Helpers;

namespace Sales.Services
{
    public class SaleService : BaseService
    {
        public SaleService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<AddSaleResponse> AddNewAsync(AddSaleRequest model)
        {

            var repositoryProduct = UnitOfWork.AsyncRepository<Product>();
            var product = await repositoryProduct.GetAsync(x => x.Id == model.ProductId);
            decimal points = product.Points;

            if (product.ProductType == (int)Enums.ProductType.Credit)
                points = (product.Percent * model.Amount)/100;



            // You can you some mapping tools as such as AutoMapper
            var Sale = new Sale( model.CustomerId,model.SellerId,model.ProductId,model.Amount, points,
                        DateTime.Today,DateTime.Today.Year,DateTime.Today.Month);

            var repository = UnitOfWork.AsyncRepository<Sale>();
            await repository.AddAsync(Sale);
            await UnitOfWork.SaveChangesAsync();

            var response = new AddSaleResponse()
            {
                Id = Sale.Id,                
            };

            return response;
        }
        public async Task<List<SaleResponse>> SearchAsync()
        {
            var repository = UnitOfWork.AsyncRepository<Sale>();
            var list = await repository
                .ListAllAsync();

            var response = list.Select(_ => new SaleResponse()
            { 
                Id = _.Id,
                Points= _.Points
                
            })
            .ToList();
            return response;
        }

        
    }
}