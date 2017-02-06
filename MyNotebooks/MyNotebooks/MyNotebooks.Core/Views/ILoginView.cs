using MyNotebooks.Core.Models;
using MyNotebooks.Identity.AccountServices.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsMvp;

namespace MyNotebooks.Core.Views
{
    public interface ILoginView : IView<LoginModel>
    {
        IApplicationSignInManager SignInManager { get; }

        string Password { get; set; }

        string Email { get; set; }

        bool Remember { get; set; }

        string NavigateUrl { get; set; }

        string ErrorMessageText { get; set; }

        bool IsPropertiesValid { get; }

        event EventHandler<EventArgs> LoginUser;

        void Success(string dir);

        bool ErrorTextVisible { get; set; }

        bool IsInRole(string role);
    }
}
