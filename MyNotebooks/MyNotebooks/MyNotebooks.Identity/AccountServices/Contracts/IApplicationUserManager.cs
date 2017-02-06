using MyNotebooks.DataModels.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Identity.AccountServices.Contracts
{
    public interface IApplicationUserManager
    {
        bool CreateUser(IUser user, string password);
    }
}
