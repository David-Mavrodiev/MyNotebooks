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
    public interface IRegistrationView : IView<RegistrationModel>
    {
        IApplicationSignInManager SignInManager { get; }

        IApplicationUserManager UserManager { get; }

        string Password { get; set; }

        string Email { get; set; }

        string ErrorMessageText { get; set; }

        string GetRole { get; }

        event EventHandler<EventArgs> RegisterUser;

        void Redirect(string dir);

        bool HasFile { get; }

        void SaveFile(string filename);
    }
}
