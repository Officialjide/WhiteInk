using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ink.Core
{
    public class TakesUserStore : UserStore<IdentityUser>
    {
        public TakesUserStore() : base(new TakesContext())
        {

        }
    }
}
