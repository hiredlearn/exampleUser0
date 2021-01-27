using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RobinProjectApp.Startup))]
namespace RobinProjectApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
