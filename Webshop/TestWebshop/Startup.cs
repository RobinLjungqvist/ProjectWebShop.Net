using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestWebshop.Startup))]
namespace TestWebshop
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
