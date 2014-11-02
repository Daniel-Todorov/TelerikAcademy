using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_02.SampleHelloApp.Startup))]
namespace _02.SampleHelloApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
