using MyNotebooks.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Data.Contracts
{
    public interface INotebookDbContext
    {
        IDbSet<Notebook> Notebooks { get; set; }

        int SaveChanges();
    }
}
