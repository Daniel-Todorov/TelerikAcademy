using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_01.ChatCanal.Startup))]
namespace _01.ChatCanal
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
