using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContinuousDeliveryWeb.Startup))]
namespace ContinuousDeliveryWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
