[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(MyNotebooks.App_Start.AppCompositionRoot), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(MyNotebooks.App_Start.AppCompositionRoot), "Stop")]

namespace MyNotebooks.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;
    using NinjectBindingsModules;
    using WebFormsMvp.Binder;

    public static class AppCompositionRoot
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        private static volatile IKernel ninjectKernelInstance;
        private static object syncRoot = new Object();

        /// <summary>
        /// Singleton implementation
        /// https://msdn.microsoft.com/en-us/library/ff650316.aspx
        /// 
        /// Singleton should not be required,
        /// Ninject kernel is guaranteed to be only 
        /// registered once by Ninject itself. (?)
        /// </summary>
        public static IKernel NinjectKernelInstance
        {
            get
            {
                return AppCompositionRoot.ninjectKernelInstance;
            }

            set
            {
                if (ninjectKernelInstance == null)
                {
                    lock (syncRoot)
                    {
                        if (ninjectKernelInstance == null)
                        {
                            AppCompositionRoot.ninjectKernelInstance = value;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                RegisterPresenterFactory(kernel);
                RegisterControllerFactory(kernel);
                InitializeAutomapperConfig(kernel);

                // Make IKernel instance available.
                AppCompositionRoot.NinjectKernelInstance = kernel;

                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Load(new MVPBindingsModule());
            kernel.Load(new DataBindingsModule());
            kernel.Load(new ServicesBindingsModule());
        }

        private static void RegisterPresenterFactory(IKernel kernel)
        {
            var customPresenterFactory = kernel.Get<IPresenterFactory>();
            PresenterBinder.Factory = customPresenterFactory;
        }

        private static void RegisterControllerFactory(IKernel kernel)
        {

        }

        private static void InitializeAutomapperConfig(IKernel kernel)
        {

        }
    }
}
