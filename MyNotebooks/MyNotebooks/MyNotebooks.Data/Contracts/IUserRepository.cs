using MyNotebooks.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Data.Contracts
{
    public interface IUserRepository : IGenericRepository<User>
    {
        void setContext(NotebooksDbContext context);

        User Find(string username);

        bool AddRoleToUser(string username, string roleName);

        bool AddClaimToUser(string username, string claimType, string claimValue);

        bool ContainsClaim(string username, string claimType, string claimValue);
    }
}
