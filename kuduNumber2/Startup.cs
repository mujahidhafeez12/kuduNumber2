using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(kuduNumber2.Startup))]
namespace kuduNumber2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
