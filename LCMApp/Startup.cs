using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LCMApp.Startup))]
namespace LCMApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
