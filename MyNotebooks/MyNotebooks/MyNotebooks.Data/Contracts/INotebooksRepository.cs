using MyNotebooks.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Data.Contracts
{
    public interface INotebooksRepository : IGenericRepository<Notebook>
    {
        void Update(Notebook entity, string content);

        Notebook Find(string subject, string type, string username);
    }
}
