using MyNotebooks.Core.Presenters.Contracts;
using MyNotebooks.Core.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsMvp;
using MyNotebooks.Data.AccountServices;

namespace MyNotebooks.Core.Presenters
{
    public class ManagePresenter : Presenter<IManageView>, IManagePresenter
    {
        private IManageView view;

        public ManagePresenter(IManageView view) : base(view)
        {
            this.view = view;
            this.view.Load += Load;   
        }

        public void Load(object sender, EventArgs e)
        {
            var manager = this.view.UserManager;

            this.view.LoginsCount = this.view.GetLoginsCount;

            var authenticationManager = this.view.AuthManager;

            if (!this.view.IsPostBackRequest)
            {
                if (this.view.HasPassword)
                {
                    this.view.ChangePasswordVisible = true;
                }
                else
                {
                    this.view.CreatePasswordVisible = true;
                    this.view.ChangePasswordVisible = false;
                }

                var message = this.view.RequestQueryMessage;

                if (message != null)
                {
                    this.view.setFormActionUrl = "~/Account/Manage";
                    this.view.SuccessMessage =
                        message == "ChangePwdSuccess" ? "Your password has been changed."
                        : message == "SetPwdSuccess" ? "Your password has been set."
                        : message == "RemoveLoginSuccess" ? "The account was removed."
                        : message == "AddPhoneNumberSuccess" ? "Phone number has been added"
                        : message == "RemovePhoneNumberSuccess" ? "Phone number was removed"
                        : String.Empty;
                    this.view.SuccessMessageVisible = !String.IsNullOrEmpty(this.view.SuccessMessage);
                }
            }
        }
    }
}
