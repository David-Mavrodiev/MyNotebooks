using MyNotebooks.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Data.AccountServices.Contracts
{
    public interface IUserService
    {
        User Find(string username);

        bool AddRoleToUser(string username, string roleName);

        bool AddClaimToUser(string username, string claimType, string claimValue);

        bool ContainsClaim(string username, string claimType, string claimValue);
    }
}
