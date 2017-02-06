using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using MyNotebooks.Identity.AccountServices.Contracts;
using MyNotebooks.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Identity.AccountServices
{
    public class ApplicationSignInManager : SignInManager<User, string>, IApplicationSignInManager
    {
        public ApplicationSignInManager(ApplicationUserManager userManager, IAuthenticationManager authenticationManager) :
            base(userManager, authenticationManager)
        {
        }

        public override Task<ClaimsIdentity> CreateUserIdentityAsync(User user)
        {
            return user.GenerateUserIdentityAsync((ApplicationUserManager)UserManager);
        }

        public static ApplicationSignInManager Create(IdentityFactoryOptions<ApplicationSignInManager> options, IOwinContext context)
        {
            return new ApplicationSignInManager(context.GetUserManager<ApplicationUserManager>(), context.Authentication);
        }

        public bool SignIn(string userName, string password, bool isPersistent, bool shouldLockout)
        {
            var signedIn = this.PasswordSignIn<User, string>(userName, password, isPersistent, shouldLockout);

            if (signedIn == SignInStatus.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
