using Sales.Domain.Products;
using Sales.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Service.Request
{
    public class LoginUserRequest
    {

        public string UserName { get; set; }
        public string Password { get; set; }


    }
}
