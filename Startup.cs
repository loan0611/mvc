using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChiaSeTL.Startup))]
namespace ChiaSeTL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
