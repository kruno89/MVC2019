using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ispit_MVC.Startup))]
namespace Ispit_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
