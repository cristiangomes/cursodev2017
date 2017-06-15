using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VisualOS.Startup))]
namespace VisualOS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
