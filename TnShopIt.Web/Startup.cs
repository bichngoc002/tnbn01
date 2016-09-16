using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TnShopIt.Web.Startup))]
namespace TnShopIt.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
