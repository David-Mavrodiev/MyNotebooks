﻿using MyNotebooks.Data;
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
        private NotebooksDbContext notebookDbContext;
        private Notebook notebook;

        public NotebookService()
        {
           
        }

        public NotebookService(string subject, string type, string username)
        {
            this.subject = subject;
            this.type = type;
            this.username = username;
        }

        public void Initialize()
        {
            this.notebookDbContext = new NotebooksDbContext();
            this.notebookDbContext.Database.CreateIfNotExists();
            this.notebook = this.notebookDbContext.Notebooks.SingleOrDefault(n => n.Subject == this.subject && n.Type == this.Type && n.Username == this.Username);
            if (this.notebook == null)
            {
                this.notebook = new Notebook();
                this.notebook.Username = this.username;
                this.notebook.Type = this.type;
                this.notebook.Subject = this.subject;
                this.notebookDbContext.Notebooks.Add(this.notebook);
                this.notebookDbContext.SaveChanges();
            }
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
            this.notebook.Content = content;
            this.notebookDbContext.SaveChanges();
        }

        public string GetContent()
        {
            return this.notebook.Content;
        }
    }
}
