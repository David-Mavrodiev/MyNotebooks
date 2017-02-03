using MyNotebooks.Core.Presenters.Contracts;
using MyNotebooks.Core.Views;
using MyNotebooks.Data.AccountServices.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsMvp;

namespace MyNotebooks.Core.Presenters
{
    public class LoginPresenter : Presenter<ILoginView>, ILoginPresenter
    {
        private ILoginView view;

        public LoginPresenter(ILoginView view) : base(view)
        {
            this.view = view;
            this.view.LoginUser += Login;
            this.view.NavigateUrl = "Register";
        }

        public void Login(object sender, EventArgs e)
        {
            if (this.view.IsPropertiesValid)
            {
                IApplicationSignInManager signinManager = this.view.SignInManager;
                bool isLogIn = signinManager.SignIn(this.view.Email, this.view.Password, this.view.Remember);
                
                if (isLogIn)
                {
                    if (this.view.IsInRole("administrator"))
                    {
                        isLogIn = true; 
                    }
                    else
                    {
                        isLogIn = true;
                    }

                    this.view.Success();
                }
                else
                {
                    this.view.ErrorMessageText = "Invalid login attempt";
                    this.view.ErrorTextVisible = true;
                }
            }
        }
    }
}
