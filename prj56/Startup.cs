using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(prj56.Startup))]
namespace prj56
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
