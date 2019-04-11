using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Adresar2.Startup))]
namespace Adresar2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
