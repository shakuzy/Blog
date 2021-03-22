using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DotNetSeguridad.Startup))]
namespace DotNetSeguridad
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
