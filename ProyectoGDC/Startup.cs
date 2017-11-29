using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoGDC.Startup))]
namespace ProyectoGDC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
