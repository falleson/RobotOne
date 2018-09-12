using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RobotOne.Web.Startup))]
namespace RobotOne.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
