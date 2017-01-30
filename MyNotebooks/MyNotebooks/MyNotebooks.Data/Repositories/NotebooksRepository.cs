using MyNotebooks.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MyNotebooks.Data.Contracts;
using MyNotebooks.Data;

namespace MyNotebooks.Data.Repositories
{
    public class NotebooksRepository : INotebooksRepository
    {
        public NotebooksDbContext Context { get; set; }

        public NotebooksRepository(NotebooksDbContext context)
        {
            this.Context = context;   
        }

        public void Add(Notebook entity)
        {
            this.Context.Notebooks.Add(entity);
        }

        public void Delete(Notebook entity)
        {
            this.Context.Notebooks.Remove(entity);
        }

        public void Update(Notebook entity, object content)
        {
            entity.Content = content.ToString();
        }

        public void Update(Notebook entity, string content)
        {
            entity.Content = content;
        }

        public Notebook Find(string subject, string type, string username)
        {
            var notebook = this.Context.Notebooks.SingleOrDefault(n => n.Subject == subject && n.Type == type && n.Username == username);
            if (notebook == null)
            {
                notebook = new Notebook();
                notebook.Username = username;
                notebook.Type = type;
                notebook.Subject = subject;
                this.Context.Notebooks.Add(notebook);
            }

            return notebook;
        }
    }
}
