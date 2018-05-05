using System;
using System.Collections.Generic;

namespace Ink.Core.Domain
{
    public class Company
    {
        public Company()
        {         
            Items = new List<Item>();
            Centers = new List<Center>();
            CompanyUsers = new List<CompanyUser>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public bool IsActive { get; set; }
        public string OwnerId { get; set; } // user table
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ApproveDate { get; set; }

        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<Center> Centers { get; set; }
        public virtual ICollection<CompanyUser> CompanyUsers { get; set; }
    }

}
