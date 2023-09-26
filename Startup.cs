using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShip.Startup))]
namespace MyShip
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
