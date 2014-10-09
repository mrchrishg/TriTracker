using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TriTracker.Web.Startup))]
namespace TriTracker.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
