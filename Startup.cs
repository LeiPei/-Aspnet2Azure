using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Medhat1124.Startup))]
namespace Medhat1124
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
