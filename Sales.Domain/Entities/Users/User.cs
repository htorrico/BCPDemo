using Sales.Domain.Agencies;
using Sales.Domain.Base;
using Sales.Domain.Roles;
using System.Collections.Generic;

namespace Sales.Domain.Users
{
    public partial class User : BaseEntity<int>
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public string DNI { get; set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }        
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public int AgencyId { get; set; }
        public Agency Agency { get; set; }
                

    }
}