using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using MyNotebooks.Data.AccountServices;
using MyNotebooks.Data.AccountServices.Helpers;
using MyNotebooks.Core.Views;
using MyNotebooks.Core.Models;
using WebFormsMvp.Web;
using MyNotebooks.Core.Presenters.Contracts;
using WebFormsMvp;
using MyNotebooks.Data.AccountServices.Contracts;

namespace MyNotebooks.Account
{
    [PresenterBinding(typeof(ILoginPresenter))]
    public partial class Login : MvpPage<LoginModel>, ILoginView
    {
        public IApplicationSignInManager SignInManager
        {
            get
            {
                return this.Context.GetOwinContext().GetUserManager<ApplicationSignInManager>();
            }
        }

        public bool Remember
        {
            get
            {
                return this.RememberMe.Checked;
            }
            set
            {
                this.RememberMe.Checked = value;
            }
        }

        string ILoginView.Password
        {
            get
            {
                return this.Password.Text;
            }

            set
            {
                this.Password.Text = value;
            }
        }

        string ILoginView.Email
        {
            get
            {
                return this.Email.Text;
            }

            set
            {
                this.Email.Text = value;
            }
        }

        public string ErrorMessageText
        {
            get
            {
                return this.FailureText.Text;
            }

            set
            {
                this.FailureText.Text = value;
            }
        }

        public string NavigateUrl
        {
            get
            {
                return this.RegisterHyperLink.NavigateUrl;
            }
            set
            {
                this.RegisterHyperLink.NavigateUrl = value;
            }
        }

        public bool IsPropertiesValid
        {
            get
            {
                return this.IsValid;
            }
        }

        public event EventHandler<EventArgs> LoginUser;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.LoginButton.Click += LogIn;
        }

        protected void LogIn(object sender, EventArgs e)
        {
            this.LoginUser(sender, e);
        }

        public bool ErrorTextVisible
        {
            get
            {
                return this.ErrorMessage.Visible;
            }

            set
            {
                this.ErrorMessage.Visible = value;
            }
        }

        public void Success()
        {
            this.Response.Redirect("~/");
        }

        public bool IsInRole(string role)
        {
            return User.IsInRole(role);
        }
    }
}