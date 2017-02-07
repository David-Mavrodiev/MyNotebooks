using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using MyNotebooks.DataModels.Models;
using WebFormsMvp.Web;
using MyNotebooks.Core.Presenters.Contracts;
using WebFormsMvp;
using MyNotebooks.Core.Models;
using MyNotebooks.Core.Views;
using System.Security.Claims;
using MyNotebooks.Data;
using MyNotebooks.Identity.AccountServices;
using MyNotebooks.Identity.AccountServices.Contracts;

namespace MyNotebooks.Account
{
    [PresenterBinding(typeof(IRegistrationPresenter))]
    public partial class Register : MvpPage<RegistrationModel>, IRegistrationView
    {
        public string ErrorMessageText
        {
            get
            {
                return this.ErrorMessage.Text;
            }

            set
            {
                this.ErrorMessage.Text = value;
            }
        }

        public IApplicationSignInManager SignInManager
        {
            get
            {
                return this.Context.GetOwinContext().Get<ApplicationSignInManager>();
            }
        }

        public IApplicationUserManager UserManager
        {
            get
            {
                return this.Context.GetOwinContext().Get<ApplicationUserManager>();
            }
        }

        string IRegistrationView.Email
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

        string IRegistrationView.Password
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

        public string GetRole
        {
            get
            {
                return this.Roles.SelectedItem.Value;
            }
        }

        public bool HasFile
        {
            get
            {
                return FileUploadControl.HasFile;
            }
        }

        public event EventHandler<EventArgs> RegisterUser;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.RegisterButton.Click += Clicked;
        }

        public void Clicked(object sender, EventArgs e)
        {
            this.RegisterUser(sender, e);
        }

        public void Redirect(string dir)
        {
            this.Response.Redirect(dir);
        }

        public void SaveFile(string filename)
        {
            FileUploadControl.SaveAs(Server.MapPath("~/Uploaded_Files/") + filename);
        }
    }
}