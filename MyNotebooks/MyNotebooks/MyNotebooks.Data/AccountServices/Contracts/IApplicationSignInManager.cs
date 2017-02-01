using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Data.AccountServices.Contracts
{
    public interface IApplicationSignInManager
    {
        bool SignIn(string userName, string password, bool isPersistent, bool shouldLockout = false);
    }
}
