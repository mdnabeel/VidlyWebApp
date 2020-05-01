using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyWebApp.Startup))]
namespace VidlyWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
