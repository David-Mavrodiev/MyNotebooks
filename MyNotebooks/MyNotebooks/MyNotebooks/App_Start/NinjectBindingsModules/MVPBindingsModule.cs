﻿using Ninject.Modules;
using Ninject.Extensions.Conventions;
using Ninject.Extensions.Factory;
using Ninject.Web.Common;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebFormsMvp;
using Ninject.Activation;
using Ninject.Parameters;
using Ninject;
using WebFormsMvp.Binder;
using MyNotebooks.App_Start.Factories;
using MyNotebooks.Core.AssemblyId;

namespace MyNotebooks.App_Start.NinjectBindingsModules
{
    public class MVPBindingsModule : NinjectModule
    {
        public override void Load()
        {
            this.Kernel.Bind(x =>
                x.FromAssemblyContaining<ICoreAssemblyId>()
                .SelectAllClasses()
                .BindDefaultInterface()
            );

            this.Bind<IPresenterFactory>()
                .To<CustomWebFormsMvpPresenterFactory>()
                .InSingletonScope();

            this.Bind<ICustomPresenterFactory>()
                .ToFactory()
                .InSingletonScope();

            this.Bind<IPresenter>()
                .ToMethod(this.PresenterFactoryMethod)
                .NamedLikeFactoryMethod((ICustomPresenterFactory factory) => factory.GetPresenter(null, null, null));
        }

        private IPresenter PresenterFactoryMethod(IContext ctx)
        {
            var parameters = ctx.Parameters.ToList();

            //var requestedType = (Type)parameters[0].GetValue(ctx, null);
            //if (requestedType == null)
            //{
            //    throw new ArgumentNullException("Invalid requested presenter type.");
            //}

            //var viewType = (Type)parameters[1].GetValue(ctx, null);
            //if (viewType == null)
            //{
            //    throw new ArgumentNullException("Invalid requested view type.");
            //}

            //var viewTypeInterface = viewType.GetInterfaces().FirstOrDefault(x => x.Name.Contains("View") && !x.Name.Contains("IView"));
            //if (viewTypeInterface == null)
            //{
            //    throw new ArgumentNullException("Invalid requested view type.");
            //}

            //var viewInstance = (IView)parameters[2].GetValue(ctx, null);
            //if (viewInstance == null)
            //{
            //    viewInstance = (IView)ctx.Kernel.Get(viewType);
            //}

            //// Unknown possible parameters for each separate IPresenter
            //// Binding the view so Ninject can resolve each of them separately.
            //var bindingExists = this.Kernel.GetBindings(viewTypeInterface).Any();
            //if (bindingExists)
            //{
            //    this.Rebind(viewTypeInterface).ToMethod(context => viewInstance);
            //}
            //else
            //{
            //    this.Bind(viewTypeInterface).ToMethod(context => viewInstance);
            //}

            //return (IPresenter)ctx.Kernel.Get(requestedType);

            // Alternative binding.
            // http://webformsmvpcontrib.codeplex.com/SourceControl/latest#WebFormsMvp.Contrib/WebFormsMvp.Contrib.Ninject/MvpPresenterKernel.cs
            // Depends on correct constructor parameter name.
            var viewInstance = (IView)parameters[2].GetValue(ctx, null);
            var viewInstanceParameter = new ConstructorArgument("view", viewInstance);

            var requestedType = (Type)parameters[0].GetValue(ctx, null);
            if (requestedType == null)
            {
                throw new ArgumentNullException("Invalid requested presenter type.");
            }

            return (IPresenter)ctx.Kernel.Get(requestedType, viewInstanceParameter);
        }
    }
}