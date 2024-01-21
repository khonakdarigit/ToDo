using Microsoft.Owin;
using Owin;
using ToDo.Web.Properties;

[assembly: OwinStartupAttribute(typeof(ToDo.Web.Startup))]
namespace ToDo.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
