using MyNotebooks.Core.Models;
using MyNotebooks.Core.Presenters.Contracts;
using MyNotebooks.Core.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsMvp;
using WebFormsMvp.Web;

namespace MyNotebooks
{
    [PresenterBinding(typeof(IDefaultPresenter))]
    public partial class _Default : MvpPage<DefaultModel>, IDefaultView
    {
        public bool AboutVisible
        {
            get
            {
                return this.about.Visible;
            }

            set
            {
                this.about.Visible = value;
            }
        }

        public IDictionary<string, string> GetImages { get; set; }

        public IDictionary<string, string> GetNotebooks { get; set; }

        public bool IsLogged
        {
            get
            {
                if (this.User.Identity.IsAuthenticated)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool NotebooksVisible
        {
            get
            {
                return this.notebooks.Visible;
            }

            set
            {
                this.notebooks.Visible = value;
            }
        }

        public int NumberOfNotebooks { get; set; }

        public bool UserIsInRole(string role)
        {
            return User.IsInRole(role);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}