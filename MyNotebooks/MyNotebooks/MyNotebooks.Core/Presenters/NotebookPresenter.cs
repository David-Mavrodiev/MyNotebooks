using MyNotebooks.Core.Views;
using MyNotebooks.Services.Contracts;
using MyNotebooks.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsMvp;

namespace MyNotebooks.Core.Presenters
{
    public class NotebookPresenter : Presenter<INotebookView>
    {
        private INotebookService service;
        private INotebookView view;

        public NotebookPresenter(INotebookView view) : this(view, new NotebookService(view.Subject, view.Type, view.Username))
        {
        }

        public NotebookPresenter(INotebookView view, INotebookService service) : base(view)
        {
            view.Load += Load;
            view.SaveChanges += SaveChanges;
            this.view = view;
            this.service = service;
        }

        public void Load(object sender, EventArgs e)
        {
            if (this.view.Content == "")
            {
                this.view.Content = this.service.GetContent();
            }
        }

        public void SaveChanges(object sender, EventArgs e)
        {
            this.service.SaveContent(this.view.Content);
        }
    }
}
