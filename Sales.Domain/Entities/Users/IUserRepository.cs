using Sales.Domain.Interfaces;

namespace Sales.Domain.Users
{
    public interface IUserRepository : IAsyncRepository<User>
    {
    }
}