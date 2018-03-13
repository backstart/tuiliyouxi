using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tuili.Startup))]
namespace tuili
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
