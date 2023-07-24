//using API.DTOs.Users;
using Sales.Domain.Interfaces;
using Sales.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales.Service;
using Sales.Service.Response;
using Sales.Service.Request;

namespace Sales.Services
{
    public class ProductService : BaseService
    {
        public ProductService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<AddProductResponse> AddNewAsync(AddProductRequest model)
        {
            // You can you some mapping tools as such as AutoMapper
            var Product = new Product( model.Name,model.Description, model.ProductType,model.Percent,model.Points);

            var repository = UnitOfWork.AsyncRepository<Product>();
            await repository.AddAsync(Product);
            await UnitOfWork.SaveChangesAsync();

            var response = new AddProductResponse()
            {
                Id = Product.Id,                
            };

            return response;
        }
        public async Task<List<ProductResponse>> SearchAsync()
        {
            var repository = UnitOfWork.AsyncRepository<Product>();
            var list = await repository
                .ListAllAsync();

            var response = list.Select(_ => new ProductResponse()
            {
                Id=_.Id,
                Name= _.Name,
                Description= _.Description,
            })
            .ToList();
            return response;
        }

        
    }
}