using Ninject.Modules;
using Ninject.Extensions.Conventions;
using Ninject.Extensions.Factory;
using Ninject.Web.Common;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyNotebooks.App_Start.NinjectBindingsModules
{
    public class DataBindingsModule : NinjectModule
    {
        public override void Load()
        {
            /*this.Kernel.Bind(x =>
                x.FromAssemblyContaining<IDataAssemblyId>()
                .SelectAllClasses()
                .BindDefaultInterface()
            );

            this.Bind<IDisposableUnitOfWork>().To<UnitOfWork>();

            this.Bind<IDisposableUnitOfWorkFactory>()
                .ToFactory()
                .InSingletonScope();

            this.Bind(typeof(IAsyncRepository<>))
                .To<AsyncGenericRepository<Worker>>()
                .WhenInjectedInto<WorkersDataService>()
                .InSingletonScope();

            this.Bind<IWhenItsDoneDbContext>()
                .To<WhenItsDoneDbContext>()
                .InRequestScope();

            this.Bind<IStatefulFactory>().ToFactory().InSingletonScope();*/

            // if binding above do not work change with code below maybe

            //this.Bind(typeof(IStateful<>)).ToMethod(ctx =>
            //{
            //    var param = ctx.Parameters.Single();

            //    var result = ctx.Kernel.Get(typeof(IStateful<>), param);

            //    return result;
            //})
            //.InSingletonScope()
            //// GetStateful<object> ?!?
            //.NamedLikeFactoryMethod((IStatefulFactory fac) => fac.GetStateful<object>(null));
        }
    }
}