using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webshop2.Startup))]
namespace webshop2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
