using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Owin;
using MyNotebooks.Core.Models;
using WebFormsMvp.Web;
using MyNotebooks.Core.Views;
using MyNotebooks.Core.Presenters.Contracts;
using WebFormsMvp;
using MyNotebooks.Identity.AccountServices.Contracts;
using MyNotebooks.Identity.AccountServices;

namespace MyNotebooks.Account
{
    [PresenterBinding(typeof(IManagePresenter))]
    public partial class Manage : MvpPage<ManageModel>, IManageView
    {
        public string SuccessMessage
        {
            get;
            set;
        }

        public int LoginsCount { get; set; }

        public IApplicationUserManager UserManager
        {
            get
            {
                return Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
        }

        public IAuthenticationManager AuthManager
        {
            get
            {
                return HttpContext.Current.GetOwinContext().Authentication;
            }
        }

        public bool IsPostBackRequest
        {
            get
            {
                return IsPostBack;
            }
        }

        public bool ChangePasswordVisible
        {
            get
            {
                return this.ChangePassword.Visible;
            }

            set
            {
                this.ChangePassword.Visible = value;
            }
        }

        public bool CreatePasswordVisible
        {
            get
            {
                return this.CreatePassword.Visible;
            }

            set
            {
                this.CreatePassword.Visible = value;
            }
        }

        bool IManageView.HasPassword
        {
            get
            {
                return Context.GetOwinContext().GetUserManager<ApplicationUserManager>().HasPassword(User.Identity.GetUserId());
            }
        }

        public string setFormActionUrl
        {
            set
            {
                Form.Action = ResolveUrl(value);
            }
        }

        public string RequestQueryMessage
        {
            get
            {
                return Request.QueryString["m"];
            }
        }

        public bool SuccessMessageVisible
        {
            get
            {
                return this.successMessage.Visible;
            }

            set
            {
                this.successMessage.Visible = true;
            }
        }

        public int GetLoginsCount
        {
            get
            {
                return Context.GetOwinContext().GetUserManager<ApplicationUserManager>().GetLogins(User.Identity.GetUserId()).Count;
            }
        }

        protected void Page_Load()
        {

        }
    }
}