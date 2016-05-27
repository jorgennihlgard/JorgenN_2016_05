using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JorgenN.Startup))]
namespace JorgenN
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
