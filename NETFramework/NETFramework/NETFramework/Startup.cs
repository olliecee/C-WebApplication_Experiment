using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NETFramework.Startup))]
namespace NETFramework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
