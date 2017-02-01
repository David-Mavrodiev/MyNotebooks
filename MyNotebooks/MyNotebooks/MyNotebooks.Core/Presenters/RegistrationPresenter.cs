using Microsoft.AspNet.Identity;
using MyNotebooks.Core.Presenters.Contracts;
using MyNotebooks.Core.Views;
using MyNotebooks.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsMvp;

namespace MyNotebooks.Core.Presenters
{
    public class RegistrationPresenter : Presenter<IRegistrationView>, IRegistrationPresenter
    {
        private IRegistrationView view;

        public RegistrationPresenter(IRegistrationView view) : base(view)
        {
            this.view = view;
            this.view.RegisterUser += Register;
        }

        public void Register(object sender, EventArgs e)
        {
            var manager = this.view.UserManager;
            var signInManager = this.view.SignInManager;
            var user = new User() { UserName = this.view.Email, Email = this.view.Email };
            bool result = manager.CreateUser(user, this.view.Password);
            if (result)
            {
                signInManager.SignIn(user.UserName, this.View.Password, false);
                this.view.Redirect();
            }
            else
            {
                this.view.ErrorMessageText = "Your username or password is incorrect!";
            }
        }
    }
}
