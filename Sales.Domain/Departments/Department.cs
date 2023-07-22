﻿using Sales.Domain.Base;
using System.Collections.Generic;

namespace Sales.Domain.Departments
{
    public partial class Department : BaseEntity<short>
    {
        public string Name { get; internal set; }
        public string Description { get; internal set; }

        
    }
}