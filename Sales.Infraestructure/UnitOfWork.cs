﻿using Sales.Domain.Base;
using Sales.Domain.Interfaces;
using Sales.Infraestructure.Repositories;
using System;
using System.Threading.Tasks;

namespace Sales.Infraestructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EFContext _dbContext;

        public UnitOfWork(EFContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IAsyncRepository<T> AsyncRepository<T>() where T : BaseEntity
        {
            return new RepositoryBase<T>(_dbContext);
        }

        public Task<int> SaveChangesAsync()
        {
            return _dbContext.SaveChangesAsync();
        }
    }
}