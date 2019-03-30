using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Parc.Startup))]
namespace MVC_Parc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
