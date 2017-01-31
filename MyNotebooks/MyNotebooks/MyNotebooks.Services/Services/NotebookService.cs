using MyNotebooks.Data;
using MyNotebooks.Data.Contracts;
using MyNotebooks.Data.Models;
using MyNotebooks.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Services.Services
{
    public class NotebookService : INotebookService
    {
        private string type, subject, username;
        private Notebook notebook;
        private INotebooksRepository repository;
        private IUnitOfWork unitOfWork;

        public NotebookService(INotebooksRepository repository, IUnitOfWork unitOfWork, NotebooksDbContext context)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;

            this.repository.setNotebookDbContext(context);
            this.unitOfWork.setContext(context);
        }

        public void Initialize()
        {
            var notebook = this.repository.Find(this.subject, this.type, this.username);
            this.notebook = notebook;
            this.unitOfWork.Commit();
        }

        public string Subject
        {
            get
            {
                return this.subject;
            }
            set
            {
                this.subject = value;
            }
        }

        public string Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public string Username
        {
            get
            {
                return this.username;
            }
            set
            {
                this.username = value;
            }
        }

        public Notebook Notebook
        {
            get
            {
                return this.notebook;
            }
        }

        public void SaveContent(string content)
        {
            this.repository.Update(this.notebook, content);
            this.unitOfWork.Commit();
        }

        public string GetContent()
        {
            return this.notebook.Content;
        }
    }
}
