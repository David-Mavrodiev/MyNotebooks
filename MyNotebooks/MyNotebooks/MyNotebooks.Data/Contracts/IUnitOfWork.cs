using Microsoft.AspNet.Identity.EntityFramework;
using MyNotebooks.DataModels.Models;
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
        void setContext(IdentityDbContext<User> context);

        void Commit();
    }
}
