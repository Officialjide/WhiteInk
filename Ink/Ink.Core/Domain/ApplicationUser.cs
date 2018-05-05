using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Ink.Core.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Subscriptions = new List<Subscription>();
            CompanyUsers = new List<CompanyUser>();
        }

        //public bool IsActive { get; set; }
        public string CustomerIdentifier { get; set; }
        public virtual ICollection<Subscription> Subscriptions { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<CompanyUser> CompanyUsers { get; set; }
    }

}
