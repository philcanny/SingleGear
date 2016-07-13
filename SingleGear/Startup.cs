using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SingleGear.Startup))]
namespace SingleGear
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
