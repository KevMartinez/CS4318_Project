using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CS4318_Project.Startup))]
namespace CS4318_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
