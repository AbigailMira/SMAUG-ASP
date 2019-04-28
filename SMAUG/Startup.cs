using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SMAUG.Startup))]
namespace SMAUG
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
