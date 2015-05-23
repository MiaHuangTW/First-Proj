using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NumberHelpers.Startup))]
namespace NumberHelpers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
