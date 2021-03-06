﻿using MyNotebooks.Core.Presenters.Contracts;
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
    public class NotebookPresenter : Presenter<INotebookView>, INotebookPresenter
    {
        private INotebookService service;
        private INotebookView view;

        public NotebookPresenter(INotebookView view, INotebookService service) : base(view)
        {
            view.Load += Load;
            view.SaveChanges += SaveChanges;
            this.view = view;
            this.service = service;
            this.service.Subject = this.view.Subject;
            this.service.Type = this.view.Type;
            this.service.Username = this.view.Username;
            this.service.Initialize();
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
