using MyNotebooks.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyNotebooks.Notebooks.Homework
{
    public partial class DrawHomework : System.Web.UI.Page
    {
        private NotebookService notebookService;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.notebookService = new NotebookService("Draw", "Homework", User.Identity.Name);
            this.SaveButton.Click += SaveButton_Click;
            if (this.TextContent.Text == "")
            {
                this.TextContent.Text = this.notebookService.GetContent();
            }
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            this.notebookService.SaveContent(this.TextContent.Text);
        }
    }
}