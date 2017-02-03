using MyNotebooks.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyNotebooks.DataModels.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MyNotebooks.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        public NotebooksDbContext Context { get; set; }

        public UserRepository()
        {

        }

        public void setContext(NotebooksDbContext context)
        {
            this.Context = context;
        }

        public void Add(User entity)
        {
            this.Context.Users.Add(entity);
        }

        public bool AddClaimToUser(string username, string claimType, string claimValue)
        {
            var user = this.Context.Users.Where(s => s.UserName == username).FirstOrDefault();
            IdentityUserClaim claim = new IdentityUserClaim();

            claim.ClaimType = claimType;
            claim.ClaimValue = claimValue;
            claim.UserId = user.Id;

            user.Claims.Add(claim);

            return true;
        }

        public bool AddRoleToUser(string username, string roleName)
        {
            var user = this.Context.Users.Where(s => s.UserName == username).FirstOrDefault();
            user.Roles.Add(new IdentityUserRole() { RoleId = this.Context.Roles.Where(s => s.Name == roleName).First().Id });
            return true;
        }

        public bool ContainsClaim(string username, string claimType, string claimValue)
        {
            var user = this.Context.Users.Where(s => s.UserName == username).FirstOrDefault();
            return user.Claims.Where(s => s.ClaimType == claimType && s.ClaimValue == claimValue).Count() > 0;
        }

        public void Delete(User entity)
        {
            this.Context.Users.Remove(entity);
        }

        public User Find(string username)
        {
            var user = this.Context.Users.Where(s => s.UserName == username).FirstOrDefault();
            return user;
        }
    }
}
