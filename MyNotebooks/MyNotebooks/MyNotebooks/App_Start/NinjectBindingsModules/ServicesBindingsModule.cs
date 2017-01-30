using Ninject.Modules;
using Ninject.Extensions.Conventions;
using Ninject.Extensions.Factory;
using Ninject.Web.Common;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyNotebooks.Services.AssemblyId;
using MyNotebooks.Services.Contracts;
using MyNotebooks.Services.Services;

namespace MyNotebooks.App_Start.NinjectBindingsModules
{
    public class ServicesBindingsModule : NinjectModule
    {
        public override void Load()
        {
            this.Kernel.Bind(x =>
                x.FromAssemblyContaining<IServiceAssemblyId>()
                .SelectAllClasses()
                .BindDefaultInterface()
            );
        }
    }
}