using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Uprise.Startup))]
namespace Uprise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
