using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vijesti.Startup))]
namespace Vijesti
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
