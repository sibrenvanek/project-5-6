using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webshop.Startup))]
namespace webshop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
