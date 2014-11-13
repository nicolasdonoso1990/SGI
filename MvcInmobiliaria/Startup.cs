using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcInmobiliaria.Startup))]
namespace MvcInmobiliaria
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
