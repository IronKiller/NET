using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Repaso.Startup))]
namespace Repaso
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
