using Ninject.Modules;
using Ninject.Extensions.Conventions;
using Ninject.Extensions.Factory;
using Ninject.Web.Common;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyNotebooks.Data.AssemblyId;
using MyNotebooks.Data.Contracts;
using MyNotebooks.Data.Models;
using MyNotebooks.Data.Repositories;
using MyNotebooks.Data;
using MyNotebooks.Data.UnitOfWorks;

namespace MyNotebooks.App_Start.NinjectBindingsModules
{
    public class DataBindingsModule : NinjectModule
    {
        public override void Load()
        {
            this.Kernel.Bind(x =>
                x.FromAssemblyContaining<IDataAssemblyId>()
                .SelectAllClasses()
                .BindDefaultInterface()
            );

            this.Kernel.Bind<NotebooksDbContext>().To<NotebooksDbContext>().InSingletonScope();
            this.Bind<INotebookDbContext>().To<NotebooksDbContext>().InSingletonScope();

            this.Bind<IUnitOfWork>().ToConstructor(c => new EfUnitOfWork( new NotebooksDbContext()));
            

            //this.Bind<INotebooksRepository>().ToConstructor(c => new NotebooksRepository(new NotebooksDbContext()));
            // this.Bind<INotebooksRepository>().To<NotebooksRepository>();
            //this.Bind<INotebookDbContext>().To<NotebooksDbContext>().InSingletonScope();
        }
    }
}