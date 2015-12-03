using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LHPlatform.Startup))]
namespace LHPlatform
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
