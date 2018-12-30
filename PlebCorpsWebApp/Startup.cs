using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PlebCorpsWebApp.Startup))]
namespace PlebCorpsWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
