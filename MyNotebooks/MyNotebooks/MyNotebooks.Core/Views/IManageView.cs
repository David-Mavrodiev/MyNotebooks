using Microsoft.Owin.Security;
using MyNotebooks.Core.Models;
using MyNotebooks.Data.AccountServices.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsMvp;

namespace MyNotebooks.Core.Views
{
    public interface IManageView : IView<ManageModel>
    {
        string SuccessMessage { get; set; }

        int LoginsCount { get; set; }

        IApplicationUserManager UserManager { get; }

        IAuthenticationManager AuthManager { get; }

        bool IsPostBackRequest { get; }

        bool ChangePasswordVisible { get; set; }

        bool CreatePasswordVisible { get; set; }

        bool HasPassword { get; }

        string setFormActionUrl { set; }

        string RequestQueryMessage { get; }

        bool SuccessMessageVisible { get; set; }

        int GetLoginsCount { get; }
    }
}
