using Microsoft.AspNet.Identity;
using MyNotebooks.Core.Models;
using MyNotebooks.Identity.AccountServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsMvp;

namespace MyNotebooks.Core.Views
{
    public interface IManageLoginsView : IView<ManageLoginsModel>
    {
        string SuccessMessage { get; set; }

        bool SuccessMessageVisible { get; set; }

        bool CanRemoveExternalLogins { get; set; }

        bool HasPassword(ApplicationUserManager manager);

        IEnumerable<UserLoginInfo> GetLogins();

        void RemoveLogin(string loginProvider, string providerKey);

        int GetLoginsCount { get; }
    }
}
