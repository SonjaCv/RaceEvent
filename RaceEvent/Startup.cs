using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RaceEvent.Startup))]
namespace RaceEvent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
