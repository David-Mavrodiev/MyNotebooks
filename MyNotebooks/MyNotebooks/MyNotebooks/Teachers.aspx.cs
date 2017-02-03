using MyNotebooks.Core.Models;
using MyNotebooks.Core.Presenters.Contracts;
using MyNotebooks.Core.Views;
using MyNotebooks.Data;
using MyNotebooks.Data.Contracts;
using MyNotebooks.Data.Repositories;
using MyNotebooks.Data.UnitOfWorks;
using MyNotebooks.DataModels.Models;
using MyNotebooks.Services.Contracts;
using MyNotebooks.Services.Services;
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
    [PresenterBinding(typeof(ITeacherPresenter))]
    public partial class Teachers : MvpPage<TeacherModel>, ITeacherView
    {
        public event EventHandler<EventArgs> AddTeacher;

        public List<Relationship> GetRelationships { get; set; }

        public string Username
        {
            get
            {
                return User.Identity.Name;
            }
        }

        public string Subject
        {
            get
            {
                return this.Subjects.SelectedItem.Value;
            }
        }

        public string TeacherUsername
        {
            get
            {
                return this.TeacherName.Text;
            }
        }

        public bool IsPageRefresh { get; set; }

        public IDictionary<string, string> Titles { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.AddButton.Click += Click_AddButton;
            if (!IsPostBack)
            {
                ViewState["postids"] = System.Guid.NewGuid().ToString();
                Session["postid"] = ViewState["postids"].ToString();
            }
            else
            {
                if (ViewState["postids"].ToString() != Session["postid"].ToString())
                {
                    IsPageRefresh = true;
                }
                Session["postid"] = System.Guid.NewGuid().ToString();
                ViewState["postids"] = Session["postid"].ToString();
            }
        }

        protected void Click_AddButton(object sender, EventArgs e)
        {
            if (!this.IsPageRefresh)
            {
                AddTeacher(sender, e);
            }
        }

        public void SetDropdown()
        {
            if (!IsPostBack)
            {
                for (int i = 0; i < this.Titles.Count; i++)
                {
                    this.Subjects.Items.Insert(i, new ListItem(this.Titles.ElementAt(i).Key, this.Titles.ElementAt(i).Value));
                }
            }
        }
    }
}