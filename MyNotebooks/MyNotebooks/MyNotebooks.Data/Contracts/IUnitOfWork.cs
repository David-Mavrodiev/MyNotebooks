using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Data.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        void setContext(DbContext context);

        void Commit();
    }
}
