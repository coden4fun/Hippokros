using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DialysisPortal.Startup))]
namespace DialysisPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
