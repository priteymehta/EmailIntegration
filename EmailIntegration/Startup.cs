using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmailIntegration.Startup))]
namespace EmailIntegration
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
