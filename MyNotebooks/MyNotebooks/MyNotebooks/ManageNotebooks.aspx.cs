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
using MyNotebooks.DataModels.Models;

namespace MyNotebooks
{
    [PresenterBinding(typeof(IManageNotebooksPresenter))]
    public partial class ManageNotebooks : MvpPage<ManageNotebooksModel>, IManageNotebooksView
    {
        public List<Relationship> GetNotebooks { get; set; }

        public IDictionary<string, string> Titles { get; set; }

        public string Username
        {
            get
            {
                return User.Identity.Name;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}