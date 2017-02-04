using MyNotebooks.Core.Models;
using MyNotebooks.Core.Presenters;
using MyNotebooks.Core.Presenters.Contracts;
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
    [PresenterBinding(typeof(INotebookPresenter))]
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

        public string Mode { get; set; }

        public string Type { get; set; }

        public string Username
        {
            get
            {
                if (this.Mode == "Check")
                {
                    return Request.QueryString["studentName"];
                }
                else
                {
                    return Page.User.Identity.Name;
                }
            }
        }

        public string NotebookTitle { get; set; }

        public string NotebookType { get; set; }

        public event EventHandler<EventArgs> SaveChanges;

        protected void Page_Init(object sender, EventArgs e)
        {
            if (this.Mode == "Check")
            {
                this.Subject = Request.QueryString["Subject"];
                this.NotebookTitle = Request.QueryString["Bg"];
            }
        }

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