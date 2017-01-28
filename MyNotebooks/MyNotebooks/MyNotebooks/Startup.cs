using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyNotebooks.Startup))]
namespace MyNotebooks
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
