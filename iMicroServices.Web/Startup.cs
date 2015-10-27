using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iMicroServices.Web.Startup))]
namespace iMicroServices.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
