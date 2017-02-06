using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using WebFormsMvp.Web;
using MyNotebooks.Core.Models;
using MyNotebooks.Core.Views;
using WebFormsMvp;
using MyNotebooks.Core.Presenters.Contracts;
using MyNotebooks.Identity.AccountServices;

namespace MyNotebooks.Account
{
    [PresenterBinding(typeof(IManageLoginsPresenter))]
    public partial class ManageLogins : MvpPage<ManageLoginsModel>, IManageLoginsView
    {
        public string SuccessMessage
        {
            get;
            set;
        }

        public bool CanRemoveExternalLogins
        {
            get;
            set;
        }

        public int GetLoginsCount
        {
            get
            {
                return Context.GetOwinContext().GetUserManager<ApplicationUserManager>().GetLogins(User.Identity.GetUserId()).Count();
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
                this.successMessage.Visible = value;
            }
        }

        public bool HasPassword(ApplicationUserManager manager)
        {
            return manager.HasPassword(User.Identity.GetUserId());
        }

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        public IEnumerable<UserLoginInfo> GetLogins()
        {
            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var accounts = manager.GetLogins(User.Identity.GetUserId());
            CanRemoveExternalLogins = accounts.Count() > 1 || HasPassword(manager);
            return accounts;
        }

        public void RemoveLogin(string loginProvider, string providerKey)
        {
            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var signInManager = Context.GetOwinContext().Get<ApplicationSignInManager>();
            var result = manager.RemoveLogin(User.Identity.GetUserId(), new UserLoginInfo(loginProvider, providerKey));
            string msg = String.Empty;
            if (result.Succeeded)
            {
                var user = manager.FindById(User.Identity.GetUserId());
                signInManager.SignIn(user, isPersistent: false, rememberBrowser: false);
                msg = "?m=RemoveLoginSuccess";
            }
            Response.Redirect("~/Account/ManageLogins" + msg);
        }
    }
}