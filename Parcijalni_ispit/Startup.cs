using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Parcijalni_ispit.Startup))]
namespace Parcijalni_ispit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
