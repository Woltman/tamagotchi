using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TamagotchiMVC.Startup))]
namespace TamagotchiMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
