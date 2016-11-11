using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pubs2.Startup))]
namespace Pubs2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
