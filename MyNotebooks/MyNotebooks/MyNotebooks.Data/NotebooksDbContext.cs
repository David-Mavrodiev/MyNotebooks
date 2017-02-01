using Microsoft.AspNet.Identity.EntityFramework;
using MyNotebooks.Data.Contracts;
using MyNotebooks.Data.Models;
using MyNotebooks.DataModels.Models;
using Ninject;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Data
{
    public class NotebooksDbContext : IdentityDbContext<User>, INotebookDbContext
    {
        [Inject]
        public NotebooksDbContext() : base("MyNotebooks", throwIfV1Schema: false)
        {
            
        }

        public virtual IDbSet<Notebook> Notebooks { get; set; }

        public static NotebooksDbContext Create()
        {
            return new NotebooksDbContext();
        }
    }
}
