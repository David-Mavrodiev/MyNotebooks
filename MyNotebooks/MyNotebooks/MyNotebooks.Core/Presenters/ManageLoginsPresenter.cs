using MyNotebooks.Core.Presenters.Contracts;
using MyNotebooks.Core.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsMvp;
using Microsoft.AspNet.Identity;
using MyNotebooks.Data.AccountServices;

namespace MyNotebooks.Core.Presenters
{
    public class ManageLoginsPresenter : Presenter<IManageLoginsView>, IManageLoginsPresenter
    {
        private IManageLoginsView view; 

        public ManageLoginsPresenter(IManageLoginsView view) : base(view)
        {
            this.view = view;
            this.view.Load += Load;
        }

        public void Load(object sender, EventArgs e)
        {
            this.view.CanRemoveExternalLogins = this.view.GetLoginsCount > 1;

            this.view.SuccessMessage = String.Empty;
            this.view.SuccessMessageVisible = !String.IsNullOrEmpty(this.view.SuccessMessage);
        }
    }
}
