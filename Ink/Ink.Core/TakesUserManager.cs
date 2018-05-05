using Ink.Core.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Ink.Core
{
    public class TakesUserManager : UserManager<ApplicationUser> //: UserManager<IdentityUser>
    {        
        public TakesUserManager(IUserStore<ApplicationUser> store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<ApplicationUser> passwordHasher, IEnumerable<IUserValidator<ApplicationUser>> userValidators, IEnumerable<IPasswordValidator<ApplicationUser>> passwordValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<ApplicationUser>> logger) 
            : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {

        }

        /*to get info like full name {firstname + lastname} etc.*/
        public async Task<string> GetNameAsync(ClaimsPrincipal principal)
        {
            var user = await GetUserAsync(principal);
            return user.FirstName; //user.FirstName + user.LastName
        }

        //public static TakesUserManager Create()
        //{ }

        /*
         * public async Task<string> GetNameAsync(ClaimsPrincipal principal)
    {
        var user = await GetUserAsync(principal);
        return user.Name;
    }

        And add it to the services:

services.AddIdentity<ApplicationUser, ApplicationRole>()
    .AddEntityFrameworkStores<SomeContext>()
    .AddUserManager<MyManager>()
    .AddDefaultTokenProviders();
         */
    }
}
