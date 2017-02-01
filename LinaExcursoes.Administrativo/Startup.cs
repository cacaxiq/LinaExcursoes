using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LinaExcursoes.Administrativo.Startup))]
namespace LinaExcursoes.Administrativo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
