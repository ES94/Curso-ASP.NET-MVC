using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogGo.Startup))]
namespace BlogGo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
