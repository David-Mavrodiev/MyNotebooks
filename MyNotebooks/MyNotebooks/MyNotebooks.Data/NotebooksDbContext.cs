using MyNotebooks.Data.Contracts;
using MyNotebooks.Data.Models;
using Ninject;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Data
{
    public class NotebooksDbContext : DbContext, INotebookDbContext
    {
        [Inject]
        public NotebooksDbContext() : base("MyNotebooks")
        {
            
        }

        public virtual IDbSet<Notebook> Notebooks { get; set; }
    }
}
