using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(suati3.Startup))]
namespace suati3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
