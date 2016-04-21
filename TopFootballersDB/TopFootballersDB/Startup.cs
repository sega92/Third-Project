using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TopFootballersDB.Startup))]
namespace TopFootballersDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
