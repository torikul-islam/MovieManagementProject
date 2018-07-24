using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieHunt.Startup))]
namespace MovieHunt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
