using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Repaso2.Startup))]
namespace Repaso2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
