using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Two_States.Startup))]
namespace Two_States
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
