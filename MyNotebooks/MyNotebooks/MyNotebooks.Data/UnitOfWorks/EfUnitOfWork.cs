using Microsoft.AspNet.Identity.EntityFramework;
using MyNotebooks.Data.Contracts;
using MyNotebooks.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNotebooks.Data.UnitOfWorks
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private DbContext context;

        public EfUnitOfWork()
        {
            
        }

        public void setContext(IdentityDbContext<User> context)
        {
            this.context = context;
        }

        public void Commit()
        {
            this.context.SaveChanges();
        }

        public void Dispose()
        {
            this.context.Dispose();
        }
    }
}
