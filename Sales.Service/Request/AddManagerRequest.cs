﻿using Sales.Domain.Agencies;
using Sales.Domain.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Service.Request
{
    public class AddManagerRequest
    {

        public string UserName { get; set; }
        public string Password { get; set; }
        public int DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }        
        public int AgencyId { get; set; }        

    }
}
