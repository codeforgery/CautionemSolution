﻿using System;
using System.Collections.Generic;

namespace Cautionem.Models
{
    public partial class Customer
    {
        public Customer()
        {
            File = new HashSet<File>();
        }

        public int CompanyId { get; set; }
        public int CustomerId { get; set; }
        public string FiscalId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public string Zip { get; set; }
        public string CountryId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public int IsLocked { get; set; }

        public virtual Company Company { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<File> File { get; set; }
    }
}
