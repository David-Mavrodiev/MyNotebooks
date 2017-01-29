using MyNotebooks.Core.Models;
using MyNotebooks.Core.Presenters;
using MyNotebooks.Core.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsMvp;
using WebFormsMvp.Web;

namespace MyNotebooks.Notebooks.Controls
{
    [PresenterBinding(typeof(NotebookPresenter))]
    public partial class NotebookControl : MvpUserControl<NotebookModel>, INotebookView
    {
        public string Content
        {
            get
            {
                return this.TextContent.Text;
            }

            set
            {
                this.TextContent.Text = value;
            }
        }

        public string Subject { get; set; }

        public string Type { get; set; }

        public string Username
        {
            get
            {
                return Page.User.Identity.Name;
            }
        }

        public string NotebookTitle { get; set; }

        public string NotebookType { get; set; }

        public event EventHandler<EventArgs> SaveChanges;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.SaveButton.Click += Btn_Click;
        }

        protected void Btn_Click(object sender, EventArgs e)
        {
            SaveChanges(sender, e);
        }
    }
}