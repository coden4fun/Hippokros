using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hippokros.Startup))]
namespace Hippokros
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
