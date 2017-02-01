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
    public interface IRegistrationView : IView<RegistrationModel>
    {
        IApplicationSignInManager SignInManager { get; }

        IApplicationUserManager UserManager { get; }

        string Password { get; set; }

        string Email { get; set; }

        string ErrorMessageText { get; set; }

        event EventHandler<EventArgs> RegisterUser;

        void Redirect();
    }
}
